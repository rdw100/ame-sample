using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AME.Framework
{
    /// <summary>
    /// Provides a utility class for enumerations.
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// Converts the specified string value to its equivalent named constant in the specified enumerated type.
        /// </summary>
        /// <typeparam name="T">Generic Type parameter</typeparam>
        /// <param name="value">String representation of the enumerated constant.</param>
        /// <returns>Enumerated constant.</returns>
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }             
    }
}
