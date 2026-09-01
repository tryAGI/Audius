
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAiAttributedTracksByUserHandleSortDirection
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
    public static class GetAiAttributedTracksByUserHandleSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAiAttributedTracksByUserHandleSortDirection value)
        {
            return value switch
            {
                GetAiAttributedTracksByUserHandleSortDirection.Asc => "asc",
                GetAiAttributedTracksByUserHandleSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAiAttributedTracksByUserHandleSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetAiAttributedTracksByUserHandleSortDirection.Asc,
                "desc" => GetAiAttributedTracksByUserHandleSortDirection.Desc,
                _ => null,
            };
        }
    }
}