
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUserTrackHistorySortMethod
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
    public static class GetUserTrackHistorySortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserTrackHistorySortMethod value)
        {
            return value switch
            {
                GetUserTrackHistorySortMethod.AddedDate => "added_date",
                GetUserTrackHistorySortMethod.ArtistName => "artist_name",
                GetUserTrackHistorySortMethod.LastListenDate => "last_listen_date",
                GetUserTrackHistorySortMethod.MostListensByUser => "most_listens_by_user",
                GetUserTrackHistorySortMethod.Plays => "plays",
                GetUserTrackHistorySortMethod.ReleaseDate => "release_date",
                GetUserTrackHistorySortMethod.Reposts => "reposts",
                GetUserTrackHistorySortMethod.Saves => "saves",
                GetUserTrackHistorySortMethod.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserTrackHistorySortMethod? ToEnum(string value)
        {
            return value switch
            {
                "added_date" => GetUserTrackHistorySortMethod.AddedDate,
                "artist_name" => GetUserTrackHistorySortMethod.ArtistName,
                "last_listen_date" => GetUserTrackHistorySortMethod.LastListenDate,
                "most_listens_by_user" => GetUserTrackHistorySortMethod.MostListensByUser,
                "plays" => GetUserTrackHistorySortMethod.Plays,
                "release_date" => GetUserTrackHistorySortMethod.ReleaseDate,
                "reposts" => GetUserTrackHistorySortMethod.Reposts,
                "saves" => GetUserTrackHistorySortMethod.Saves,
                "title" => GetUserTrackHistorySortMethod.Title,
                _ => null,
            };
        }
    }
}