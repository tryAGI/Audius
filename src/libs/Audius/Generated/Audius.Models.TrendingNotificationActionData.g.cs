
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrendingNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rank { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genre")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Genre { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrackId { get; set; }

        /// <summary>
        /// Example: week
        /// </summary>
        /// <example>week</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_range")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.TrendingNotificationActionDataTimeRangeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.TrendingNotificationActionDataTimeRange TimeRange { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingNotificationActionData" /> class.
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="genre"></param>
        /// <param name="trackId"></param>
        /// <param name="timeRange">
        /// Example: week
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrendingNotificationActionData(
            int rank,
            string genre,
            string trackId,
            global::Audius.TrendingNotificationActionDataTimeRange timeRange)
        {
            this.Rank = rank;
            this.Genre = genre ?? throw new global::System.ArgumentNullException(nameof(genre));
            this.TrackId = trackId ?? throw new global::System.ArgumentNullException(nameof(trackId));
            this.TimeRange = timeRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingNotificationActionData" /> class.
        /// </summary>
        public TrendingNotificationActionData()
        {
        }

    }
}