
#nullable enable

namespace Audius
{
    /// <summary>
    /// Sanitized metadata (excludes sensitive URLs)<br/>
    /// Example: {"type":"coin_airdrop","amount":1000000000}
    /// </summary>
    public sealed partial class PrizePublicMetadata
    {

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

    }
}