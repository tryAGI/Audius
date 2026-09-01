
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListenCount
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trackId")]
        public int? TrackId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listens")]
        public int? Listens { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenCount" /> class.
        /// </summary>
        /// <param name="trackId"></param>
        /// <param name="date"></param>
        /// <param name="listens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenCount(
            int? trackId,
            string? date,
            int? listens)
        {
            this.TrackId = trackId;
            this.Date = date;
            this.Listens = listens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenCount" /> class.
        /// </summary>
        public ListenCount()
        {
        }

    }
}