
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MonthlyAggregatePlay
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalListens")]
        public int? TotalListens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trackIds")]
        public global::System.Collections.Generic.IList<int>? TrackIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listenCounts")]
        public global::System.Collections.Generic.IList<global::Audius.ListenCount>? ListenCounts { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyAggregatePlay" /> class.
        /// </summary>
        /// <param name="totalListens"></param>
        /// <param name="trackIds"></param>
        /// <param name="listenCounts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MonthlyAggregatePlay(
            int? totalListens,
            global::System.Collections.Generic.IList<int>? trackIds,
            global::System.Collections.Generic.IList<global::Audius.ListenCount>? listenCounts)
        {
            this.TotalListens = totalListens;
            this.TrackIds = trackIds;
            this.ListenCounts = listenCounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyAggregatePlay" /> class.
        /// </summary>
        public MonthlyAggregatePlay()
        {
        }

    }
}