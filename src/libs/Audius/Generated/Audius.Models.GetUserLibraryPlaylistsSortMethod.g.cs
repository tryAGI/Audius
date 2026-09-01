
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUserLibraryPlaylistsSortMethod
    {
        /// <summary>
        ///
        /// </summary>
        AddedDate,
        /// <summary>
        ///
        /// </summary>
        Reposts,
        /// <summary>
        ///
        /// </summary>
        Saves,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUserLibraryPlaylistsSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserLibraryPlaylistsSortMethod value)
        {
            return value switch
            {
                GetUserLibraryPlaylistsSortMethod.AddedDate => "added_date",
                GetUserLibraryPlaylistsSortMethod.Reposts => "reposts",
                GetUserLibraryPlaylistsSortMethod.Saves => "saves",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserLibraryPlaylistsSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "added_date" => GetUserLibraryPlaylistsSortMethod.AddedDate,
                "reposts" => GetUserLibraryPlaylistsSortMethod.Reposts,
                "saves" => GetUserLibraryPlaylistsSortMethod.Saves,
                _ => null,
            };
        }
    }
}