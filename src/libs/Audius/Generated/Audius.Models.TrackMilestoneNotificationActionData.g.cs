
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrackMilestoneNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Threshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrackId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackMilestoneNotificationActionData" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="threshold"></param>
        /// <param name="trackId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackMilestoneNotificationActionData(
            string type,
            int threshold,
            string trackId)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Threshold = threshold;
            this.TrackId = trackId ?? throw new global::System.ArgumentNullException(nameof(trackId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackMilestoneNotificationActionData" /> class.
        /// </summary>
        public TrackMilestoneNotificationActionData()
        {
        }

    }
}