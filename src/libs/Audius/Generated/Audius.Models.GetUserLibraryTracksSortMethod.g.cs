
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUserLibraryTracksSortMethod
    {
        /// <summary>
        ///
        /// </summary>
        AddedDate,
        /// <summary>
        ///
        /// </summary>
        ArtistName,
        /// <summary>
        ///
        /// </summary>
        LastListenDate,
        /// <summary>
        ///
        /// </summary>
        MostListensByUser,
        /// <summary>
        ///
        /// </summary>
        Plays,
        /// <summary>
        ///
        /// </summary>
        ReleaseDate,
        /// <summary>
        ///
        /// </summary>
        Reposts,
        /// <summary>
        ///
        /// </summary>
        Saves,
        /// <summary>
        ///
        /// </summary>
        Title,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUserLibraryTracksSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserLibraryTracksSortMethod value)
        {
            return value switch
            {
                GetUserLibraryTracksSortMethod.AddedDate => "added_date",
                GetUserLibraryTracksSortMethod.ArtistName => "artist_name",
                GetUserLibraryTracksSortMethod.LastListenDate => "last_listen_date",
                GetUserLibraryTracksSortMethod.MostListensByUser => "most_listens_by_user",
                GetUserLibraryTracksSortMethod.Plays => "plays",
                GetUserLibraryTracksSortMethod.ReleaseDate => "release_date",
                GetUserLibraryTracksSortMethod.Reposts => "reposts",
                GetUserLibraryTracksSortMethod.Saves => "saves",
                GetUserLibraryTracksSortMethod.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserLibraryTracksSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "added_date" => GetUserLibraryTracksSortMethod.AddedDate,
                "artist_name" => GetUserLibraryTracksSortMethod.ArtistName,
                "last_listen_date" => GetUserLibraryTracksSortMethod.LastListenDate,
                "most_listens_by_user" => GetUserLibraryTracksSortMethod.MostListensByUser,
                "plays" => GetUserLibraryTracksSortMethod.Plays,
                "release_date" => GetUserLibraryTracksSortMethod.ReleaseDate,
                "reposts" => GetUserLibraryTracksSortMethod.Reposts,
                "saves" => GetUserLibraryTracksSortMethod.Saves,
                "title" => GetUserLibraryTracksSortMethod.Title,
                _ => null,
            };
        }
    }
}