
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TracksCountResponse
    {
        /// <summary>
        /// The total number of tracks matching the filter criteria<br/>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Data { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracksCountResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The total number of tracks matching the filter criteria<br/>
        /// Example: 15
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TracksCountResponse(
            int data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracksCountResponse" /> class.
        /// </summary>
        public TracksCountResponse()
        {
        }

    }
}