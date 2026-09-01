
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum GetUserFeedFilter
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Original,
        /// <summary>
        ///
        /// </summary>
        Repost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUserFeedFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserFeedFilter value)
        {
            return value switch
            {
                GetUserFeedFilter.All => "all",
                GetUserFeedFilter.Original => "original",
                GetUserFeedFilter.Repost => "repost",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserFeedFilter? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetUserFeedFilter.All,
                "original" => GetUserFeedFilter.Original,
                "repost" => GetUserFeedFilter.Repost,
                _ => null,
            };
        }
    }
}