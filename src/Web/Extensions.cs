using System.ComponentModel;
using System.Reflection;

namespace Web;

public static class Extensions
{
    public static string Description(this Enum value)
    {
        FieldInfo field = value.GetType().GetField(value.ToString());
        DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();

        return attribute?.Description ?? value.ToString();
    }
}