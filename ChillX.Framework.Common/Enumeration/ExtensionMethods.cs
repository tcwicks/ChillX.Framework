using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

namespace ChillX.Framework.Common.Enumeration
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Returns the component model description attribute value of the enum.
        /// </summary>
        /// <param name="value">Enum value</param>
        /// <returns>description attribute value</returns>
        public static string GetDescription(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr =
                           Attribute.GetCustomAttribute(field,
                             typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Returns the name of the enum value
        /// </summary>
        /// <param name="value">Enum value</param>
        /// <returns>name of the enum value</returns>
        public static string GetName(this Enum value)
        {
            return Enum.GetName(value.GetType(), value);
        }
        /// <summary>
        /// Parses string name into specified enum type
        /// Note: Throws an ArgumentException if the specified type is not an enum
        /// Note: specifies case insensitive parsing
        /// Note: exception will be thrown if the parsing fails. <see cref="ToEnum{T}(string, T)"/> for alternative implementation
        /// </summary>
        /// <typeparam name="T">Valid enum type</typeparam>
        /// <param name="value">String name to be parsed into specified enum type</param>
        /// <returns>Parsed enum type</returns>
        public static T ToEnum<T>(this string value)
            where T: struct, IConvertible, IComparable, IFormattable
        {
            Type type = typeof(T);
            if (!type.IsEnum) { throw new ArgumentException(@"Generic Type T is not a valid enum"); }
            return (T)Enum.Parse(type, value, true);
        }
        /// <summary>
        /// Parses string name into specified enum type
        /// Note: Throws an ArgumentException if the specified type is not an enum
        /// Note: specifies case insensitive parsing
        /// Note: if parsing fails the specified default value will be returned instead
        /// </summary>
        /// <typeparam name="T">Valid enum type</typeparam>
        /// <param name="value">string name to be parsed into specified enum type</param>
        /// <param name="DefaultValue">Default value to be returned if parsing fails</param>
        /// <returns>Parsed enum type if successfull or specified default value if parsing fails</returns>
        public static T ToEnum<T>(this string value, T DefaultValue)
            where T: struct, IConvertible, IComparable, IFormattable
        {
            Type type = typeof(T);
            if (!type.IsEnum) { throw new ArgumentException(@"Generic Type T is not a valid enum"); }
            T parsedValue;
            if (!Enum.TryParse<T>(value, true, out parsedValue))
            {
                return DefaultValue;
            }
            return parsedValue;
        }
    }
}
