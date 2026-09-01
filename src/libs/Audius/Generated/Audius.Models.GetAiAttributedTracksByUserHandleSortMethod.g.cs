
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAiAttributedTracksByUserHandleSortMethod
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
    public static class GetAiAttributedTracksByUserHandleSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAiAttributedTracksByUserHandleSortMethod value)
        {
            return value switch
            {
                GetAiAttributedTracksByUserHandleSortMethod.AddedDate => "added_date",
                GetAiAttributedTracksByUserHandleSortMethod.ArtistName => "artist_name",
                GetAiAttributedTracksByUserHandleSortMethod.LastListenDate => "last_listen_date",
                GetAiAttributedTracksByUserHandleSortMethod.MostListensByUser => "most_listens_by_user",
                GetAiAttributedTracksByUserHandleSortMethod.Plays => "plays",
                GetAiAttributedTracksByUserHandleSortMethod.ReleaseDate => "release_date",
                GetAiAttributedTracksByUserHandleSortMethod.Reposts => "reposts",
                GetAiAttributedTracksByUserHandleSortMethod.Saves => "saves",
                GetAiAttributedTracksByUserHandleSortMethod.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAiAttributedTracksByUserHandleSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "added_date" => GetAiAttributedTracksByUserHandleSortMethod.AddedDate,
                "artist_name" => GetAiAttributedTracksByUserHandleSortMethod.ArtistName,
                "last_listen_date" => GetAiAttributedTracksByUserHandleSortMethod.LastListenDate,
                "most_listens_by_user" => GetAiAttributedTracksByUserHandleSortMethod.MostListensByUser,
                "plays" => GetAiAttributedTracksByUserHandleSortMethod.Plays,
                "release_date" => GetAiAttributedTracksByUserHandleSortMethod.ReleaseDate,
                "reposts" => GetAiAttributedTracksByUserHandleSortMethod.Reposts,
                "saves" => GetAiAttributedTracksByUserHandleSortMethod.Saves,
                "title" => GetAiAttributedTracksByUserHandleSortMethod.Title,
                _ => null,
            };
        }
    }
}