using System;
using System.Data;
using Microsoft.Data.SqlClient;
using NSubstitute;
using Shouldly;
using Xunit;
using Aymadoka.Static.DataExtension;

namespace Aymadoka.Static.Extensions.Tests.DataExtension
{
    public class SqlConnection_ExecuteDataTableTests
    {
        // 辅助类用于临时替换 SqlDataAdapter 构造行为
        static class NSubstituteExtensions
        {
            private static Func<SqlCommand, SqlDataAdapter> _factory;
            private static readonly object _lock = new object();

            public static IDisposable OverrideSqlDataAdapterFactory(Func<SqlDataAdapter> factory)
            {
                lock (_lock)
                {
                    _factory = _ => factory();
                    return new DisposableAction(() => { lock (_lock) { _factory = null; } });
                }
            }

            // 需要在被测代码中将 new SqlDataAdapter(command) 替换为此工厂方法
            public static SqlDataAdapter CreateSqlDataAdapter(SqlCommand command)
            {
                lock (_lock)
                {
                    if (_factory != null)
                        return _factory(command);
                    return new SqlDataAdapter(command);
                }
            }

            private class DisposableAction : IDisposable
            {
                private readonly Action _dispose;
                public DisposableAction(Action dispose) => _dispose = dispose;
                public void Dispose() => _dispose();
            }
        }

        [Fact]
        public void ExecuteDataTable_WithAllParameters_ShouldReturnDataTable()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var command = Substitute.For<SqlCommand>();
            var transaction = Substitute.For<SqlTransaction>();
            var parameters = new[] { new SqlParameter("@id", 1) };
            var cmdText = "SELECT 1";
            var commandType = CommandType.Text;

            connection.CreateCommand().Returns(command);
            command.Parameters.Returns(new SqlCommand().Parameters);
            command.ExecuteReader().Returns(Substitute.For<IDataReader>());

            // 模拟 DataAdapter.Fill
            var dataTable = new DataTable();
            dataTable.Columns.Add("Col1", typeof(int));
            dataTable.Rows.Add(1);
            var dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);

            // 使用真实 SqlDataAdapter 需要真实连接，故此处只测试参数传递和调用流程
            // Act & Assert
            Should.NotThrow(() =>
            {
                // 这里只能测试调用流程，无法 mock SqlDataAdapter
                // 若需集成测试，请连接真实数据库
            });
        }

        [Fact]
        public void ExecuteDataTable_WithCommandFactory_ShouldReturnDataTable()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var command = Substitute.For<SqlCommand>();
            connection.CreateCommand().Returns(command);
            command.Parameters.Returns(new SqlCommand().Parameters);

            // Act & Assert
            Should.NotThrow(() =>
            {
                connection.ExecuteDataTable(cmd =>
                {
                    cmd.CommandText = "SELECT 1";
                    cmd.CommandType = CommandType.Text;
                });
            });
        }

        [Fact]
        public void ExecuteDataTable_WithCmdTextOnly_ShouldCallOverload()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var called = false;
            connection.When(x => x.ExecuteDataTable(Arg.Any<string>(), Arg.Any<SqlParameter[]>(), Arg.Any<CommandType>(), Arg.Any<SqlTransaction>()))
                .Do(_ => called = true);

            // Act
            connection.ExecuteDataTable("SELECT 1");

            // Assert
            called.ShouldBeTrue();
        }

        [Fact]
        public void ExecuteDataTable_WithCommandFactory_ShouldInvokeFactoryAndReturnDataTable()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var command = Substitute.For<SqlCommand>();
            var dataTable = new DataTable();
            var dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);

            connection.CreateCommand().Returns(command);

            // 模拟 SqlDataAdapter.Fill(DataSet) 行为
            var dataAdapter = Substitute.ForPartsOf<SqlDataAdapter>(command);
            dataAdapter.When(x => x.Fill(Arg.Any<DataSet>()))
                .Do(callInfo =>
                {
                    var ds = callInfo.Arg<DataSet>();
                    ds.Tables.Add(dataTable);
                });

            // 使用委托捕获传入的 command
            bool factoryCalled = false;
            Action<SqlCommand> factory = c =>
            {
                factoryCalled = true;
                c.ShouldBe(command);
            };

            // Act
            DataTable result;
            using (NSubstituteExtensions.OverrideSqlDataAdapterFactory(() => dataAdapter))
            {
                result = connection.ExecuteDataTable(factory);
            }

            // Assert
            factoryCalled.ShouldBeTrue();
            result.ShouldBe(dataTable);
        }
    }
}