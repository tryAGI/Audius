
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: newest
    /// </summary>
    public enum GetAllEventsSortMethod
    {
        /// <summary>
        ///
        /// </summary>
        Newest,
        /// <summary>
        ///
        /// </summary>
        Timestamp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllEventsSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllEventsSortMethod value)
        {
            return value switch
            {
                GetAllEventsSortMethod.Newest => "newest",
                GetAllEventsSortMethod.Timestamp => "timestamp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllEventsSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "newest" => GetAllEventsSortMethod.Newest,
                "timestamp" => GetAllEventsSortMethod.Timestamp,
                _ => null,
            };
        }
    }
}