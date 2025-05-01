using System.ComponentModel;

namespace Aymadoka.Static.EnumExtension
{
    public enum TestEnum
    { 
        [Description("Value One")]
        Value1,

        [Description("Value Two")]
        Value2,

        Value3 // 无描述
    }
}
