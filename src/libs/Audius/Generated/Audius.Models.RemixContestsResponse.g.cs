
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RemixContestsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Audius.Event>? Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("related")]
        public global::Audius.RemixContestsRelated? Related { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixContestsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="related"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemixContestsResponse(
            global::System.Collections.Generic.IList<global::Audius.Event>? data,
            global::Audius.RemixContestsRelated? related)
        {
            this.Data = data;
            this.Related = related;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixContestsResponse" /> class.
        /// </summary>
        public RemixContestsResponse()
        {
        }

    }
}