
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTracksByUserHandleSortDirection
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTracksByUserHandleSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTracksByUserHandleSortDirection value)
        {
            return value switch
            {
                GetTracksByUserHandleSortDirection.Asc => "asc",
                GetTracksByUserHandleSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTracksByUserHandleSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetTracksByUserHandleSortDirection.Asc,
                "desc" => GetTracksByUserHandleSortDirection.Desc,
                _ => null,
            };
        }
    }
}