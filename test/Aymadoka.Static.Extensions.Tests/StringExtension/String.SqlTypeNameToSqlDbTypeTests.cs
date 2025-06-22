using System.Data;

namespace Aymadoka.Static.StringExtension
{
    public class String_SqlTypeNameToSqlDbTypeTests
    {
        [Theory]
        [InlineData("int", SqlDbType.Int)]
        [InlineData("nvarchar", SqlDbType.NVarChar)]
        [InlineData("varchar", SqlDbType.VarChar)]
        [InlineData("bigint", SqlDbType.BigInt)]
        [InlineData("bit", SqlDbType.Bit)]
        [InlineData("datetime", SqlDbType.DateTime)]
        [InlineData("time", SqlDbType.Time)]
        [InlineData("date", SqlDbType.Date)]
        [InlineData("float", SqlDbType.Float)]
        [InlineData("decimal", SqlDbType.Decimal)]
        [InlineData("numeric", SqlDbType.Decimal)]
        [InlineData("nchar", SqlDbType.NChar)]
        [InlineData("char", SqlDbType.Char)]
        [InlineData("binary", SqlDbType.Binary)]
        [InlineData("varbinary", SqlDbType.VarBinary)]
        [InlineData("text", SqlDbType.Text)]
        [InlineData("ntext", SqlDbType.NText)]
        [InlineData("uniqueidentifier", SqlDbType.UniqueIdentifier)]
        [InlineData("timestamp", SqlDbType.Timestamp)]
        [InlineData("smallint", SqlDbType.SmallInt)]
        [InlineData("tinyint", SqlDbType.TinyInt)]
        [InlineData("money", SqlDbType.Money)]
        [InlineData("smallmoney", SqlDbType.SmallMoney)]
        [InlineData("smalldatetime", SqlDbType.SmallDateTime)]
        [InlineData("real", SqlDbType.Real)]
        [InlineData("datetime2", SqlDbType.DateTime2)]
        [InlineData("datetimeoffset", SqlDbType.DateTimeOffset)]
        [InlineData("sql_variant", SqlDbType.Variant)]
        [InlineData("sysname", SqlDbType.NVarChar)]
        [InlineData("hierarchyid", SqlDbType.Udt)]
        [InlineData("geometry", SqlDbType.Udt)]
        [InlineData("geography", SqlDbType.Udt)]
        [InlineData("xml", SqlDbType.Xml)]
        [InlineData("image", SqlDbType.Image)]
        public void SqlTypeNameToSqlDbType_ValidTypes_ReturnsExpected(string typeName, SqlDbType expected)
        {
            var result = typeName.SqlTypeNameToSqlDbType();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SqlTypeNameToSqlDbType_UnknownType_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => "unknown_type".SqlTypeNameToSqlDbType());
            Assert.Contains("Unsupported Type", ex.Message);
        }

        [Fact]
        public void SqlTypeNameToSqlDbType_CaseInsensitive_Success()
        {
            var result = "InT".SqlTypeNameToSqlDbType();
            Assert.Equal(SqlDbType.Int, result);
        }
    }
}
