
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUserFavoriteTracksSortMethod
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
    public static class GetUserFavoriteTracksSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserFavoriteTracksSortMethod value)
        {
            return value switch
            {
                GetUserFavoriteTracksSortMethod.AddedDate => "added_date",
                GetUserFavoriteTracksSortMethod.ArtistName => "artist_name",
                GetUserFavoriteTracksSortMethod.LastListenDate => "last_listen_date",
                GetUserFavoriteTracksSortMethod.MostListensByUser => "most_listens_by_user",
                GetUserFavoriteTracksSortMethod.Plays => "plays",
                GetUserFavoriteTracksSortMethod.ReleaseDate => "release_date",
                GetUserFavoriteTracksSortMethod.Reposts => "reposts",
                GetUserFavoriteTracksSortMethod.Saves => "saves",
                GetUserFavoriteTracksSortMethod.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserFavoriteTracksSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "added_date" => GetUserFavoriteTracksSortMethod.AddedDate,
                "artist_name" => GetUserFavoriteTracksSortMethod.ArtistName,
                "last_listen_date" => GetUserFavoriteTracksSortMethod.LastListenDate,
                "most_listens_by_user" => GetUserFavoriteTracksSortMethod.MostListensByUser,
                "plays" => GetUserFavoriteTracksSortMethod.Plays,
                "release_date" => GetUserFavoriteTracksSortMethod.ReleaseDate,
                "reposts" => GetUserFavoriteTracksSortMethod.Reposts,
                "saves" => GetUserFavoriteTracksSortMethod.Saves,
                "title" => GetUserFavoriteTracksSortMethod.Title,
                _ => null,
            };
        }
    }
}