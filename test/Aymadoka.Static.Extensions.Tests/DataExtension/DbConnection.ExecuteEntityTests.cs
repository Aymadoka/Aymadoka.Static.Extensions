using NSubstitute;
using Shouldly;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public class DbConnection_ExecuteEntityTests
    {
        public class DummyEntity
        {
            public int Id { get; set; }
        }

        private static (DbConnection, DbCommand, IDataReader) CreateMocks(bool hasRow = true)
        {
            var reader = Substitute.For<IDataReader>();
            var readCount = 0;
            reader.Read().Returns(_ => readCount++ == 0 && hasRow);
            reader.ToEntity<DummyEntity>().Returns(new DummyEntity { Id = 123 });

            var command = Substitute.For<DbCommand>();
            command.ExecuteReader().Returns(reader);
            command.Parameters.Returns(Substitute.For<DbParameterCollection>());

            var connection = Substitute.For<DbConnection>();
            connection.CreateCommand().Returns(command);

            return (connection, command, reader);
        }

        [Fact]
        public void ExecuteEntity_AllParameters_ReturnsEntity()
        {
            var (conn, cmd, reader) = CreateMocks();
            var result = conn.ExecuteEntity<DummyEntity>("sql", Array.Empty<DbParameter>(), CommandType.Text, null);
            result.ShouldNotBeNull();
            result.Id.ShouldBe(123);
            cmd.CommandText.ShouldBe("sql");
            cmd.CommandType.ShouldBe(CommandType.Text);
        }

        [Fact]
        public void ExecuteEntity_CommandFactory_ReturnsEntity()
        {
            var (conn, cmd, reader) = CreateMocks();
            var called = false;
            var result = conn.ExecuteEntity<DummyEntity>(c =>
            {
                called = true;
                c.CommandText = "abc";
            });
            called.ShouldBeTrue();
            result.ShouldNotBeNull();
            result.Id.ShouldBe(123);
        }

        [Fact]
        public void ExecuteEntity_CmdTextOnly_ReturnsEntity()
        {
            var (conn, cmd, reader) = CreateMocks();
            var result = conn.ExecuteEntity<DummyEntity>("sql");
            result.ShouldNotBeNull();
            result.Id.ShouldBe(123);
        }

        [Fact]
        public void ExecuteEntity_CmdTextAndTransaction_ReturnsEntity()
        {
            var (conn, cmd, reader) = CreateMocks();
            var tran = Substitute.For<DbTransaction>();
            var result = conn.ExecuteEntity<DummyEntity>("sql", tran);
            result.ShouldNotBeNull();
            result.Id.ShouldBe(123);
        }

        [Fact]
        public void ExecuteEntity_CmdTextAndCommandType_ReturnsEntity()
        {
            var (conn, cmd, reader) = CreateMocks();
            var result = conn.ExecuteEntity<DummyEntity>("sql", CommandType.StoredProcedure);
            result.ShouldNotBeNull();
            result.Id.ShouldBe(123);
        }

        [Fact]
        public void ExecuteEntity_CmdTextCommandTypeTransaction_ReturnsEntity()
        {
            var (conn, cmd, reader) = CreateMocks();
            var tran = Substitute.For<DbTransaction>();
            var result = conn.ExecuteEntity<DummyEntity>("sql", CommandType.Text, tran);
            result.ShouldNotBeNull();
            result.Id.ShouldBe(123);
        }

        [Fact]
        public void ExecuteEntity_CmdTextAndParameters_ReturnsEntity()
        {
            var (conn, cmd, reader) = CreateMocks();
            var result = conn.ExecuteEntity<DummyEntity>("sql", Array.Empty<DbParameter>());
            result.ShouldNotBeNull();
            result.Id.ShouldBe(123);
        }

        [Fact]
        public void ExecuteEntity_CmdTextParametersTransaction_ReturnsEntity()
        {
            var (conn, cmd, reader) = CreateMocks();
            var tran = Substitute.For<DbTransaction>();
            var result = conn.ExecuteEntity<DummyEntity>("sql", Array.Empty<DbParameter>(), tran);
            result.ShouldNotBeNull();
            result.Id.ShouldBe(123);
        }

        [Fact]
        public void ExecuteEntity_CmdTextParametersCommandType_ReturnsEntity()
        {
            var (conn, cmd, reader) = CreateMocks();
            var result = conn.ExecuteEntity<DummyEntity>("sql", Array.Empty<DbParameter>(), CommandType.Text);
            result.ShouldNotBeNull();
            result.Id.ShouldBe(123);
        }

        [Fact]
        public void ExecuteEntity_ReaderReturnsNoRows_Throws()
        {
            var (conn, cmd, reader) = CreateMocks(hasRow: false);
            Should.Throw<Exception>(() =>
            {
                conn.ExecuteEntity<DummyEntity>("sql");
            });
        }
    }
}