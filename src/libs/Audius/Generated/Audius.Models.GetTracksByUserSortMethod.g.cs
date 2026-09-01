
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTracksByUserSortMethod
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
    public static class GetTracksByUserSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTracksByUserSortMethod value)
        {
            return value switch
            {
                GetTracksByUserSortMethod.AddedDate => "added_date",
                GetTracksByUserSortMethod.ArtistName => "artist_name",
                GetTracksByUserSortMethod.LastListenDate => "last_listen_date",
                GetTracksByUserSortMethod.MostListensByUser => "most_listens_by_user",
                GetTracksByUserSortMethod.Plays => "plays",
                GetTracksByUserSortMethod.ReleaseDate => "release_date",
                GetTracksByUserSortMethod.Reposts => "reposts",
                GetTracksByUserSortMethod.Saves => "saves",
                GetTracksByUserSortMethod.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTracksByUserSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "added_date" => GetTracksByUserSortMethod.AddedDate,
                "artist_name" => GetTracksByUserSortMethod.ArtistName,
                "last_listen_date" => GetTracksByUserSortMethod.LastListenDate,
                "most_listens_by_user" => GetTracksByUserSortMethod.MostListensByUser,
                "plays" => GetTracksByUserSortMethod.Plays,
                "release_date" => GetTracksByUserSortMethod.ReleaseDate,
                "reposts" => GetTracksByUserSortMethod.Reposts,
                "saves" => GetTracksByUserSortMethod.Saves,
                "title" => GetTracksByUserSortMethod.Title,
                _ => null,
            };
        }
    }
}