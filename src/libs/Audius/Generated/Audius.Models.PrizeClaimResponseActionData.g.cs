
#nullable enable

namespace Audius
{
    /// <summary>
    /// Prize-specific action data (e.g., redeem code/URL for coin airdrops, download URL for downloads)<br/>
    /// Example: {"code":"aB3d5F","url":"/coins/YAK/redeem/aB3d5F"}
    /// </summary>
    public sealed partial class PrizeClaimResponseActionData
    {

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

    }
}