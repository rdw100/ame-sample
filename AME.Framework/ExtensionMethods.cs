using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AME.Framework
{
    /// <summary>
    /// Stores custom extensions methods.
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Adds custom method to existing String type without creating a new derived type, recompiling, or otherwise modifying the original type.
        /// Note: Adds code to Microsoft core classes.
        /// </summary>
        /// <typeparam name="T">Generic Type parameter.</typeparam>
        /// <param name="value">String representation of the enumerated constant.</param>
        /// <returns></returns>
        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
