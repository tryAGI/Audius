
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTracksByUserHandleSortMethod
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
    public static class GetTracksByUserHandleSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTracksByUserHandleSortMethod value)
        {
            return value switch
            {
                GetTracksByUserHandleSortMethod.AddedDate => "added_date",
                GetTracksByUserHandleSortMethod.ArtistName => "artist_name",
                GetTracksByUserHandleSortMethod.LastListenDate => "last_listen_date",
                GetTracksByUserHandleSortMethod.MostListensByUser => "most_listens_by_user",
                GetTracksByUserHandleSortMethod.Plays => "plays",
                GetTracksByUserHandleSortMethod.ReleaseDate => "release_date",
                GetTracksByUserHandleSortMethod.Reposts => "reposts",
                GetTracksByUserHandleSortMethod.Saves => "saves",
                GetTracksByUserHandleSortMethod.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTracksByUserHandleSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "added_date" => GetTracksByUserHandleSortMethod.AddedDate,
                "artist_name" => GetTracksByUserHandleSortMethod.ArtistName,
                "last_listen_date" => GetTracksByUserHandleSortMethod.LastListenDate,
                "most_listens_by_user" => GetTracksByUserHandleSortMethod.MostListensByUser,
                "plays" => GetTracksByUserHandleSortMethod.Plays,
                "release_date" => GetTracksByUserHandleSortMethod.ReleaseDate,
                "reposts" => GetTracksByUserHandleSortMethod.Reposts,
                "saves" => GetTracksByUserHandleSortMethod.Saves,
                "title" => GetTracksByUserHandleSortMethod.Title,
                _ => null,
            };
        }
    }
}