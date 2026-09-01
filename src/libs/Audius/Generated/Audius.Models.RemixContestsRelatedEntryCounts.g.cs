
#nullable enable

namespace Audius
{
    /// <summary>
    /// Per-contest entry counts keyed by the contest's parent track id (hashid). Lets the discovery UI render entry counts without issuing an extra `/tracks/{id}/remixes?limit=0` per card.
    /// </summary>
    public sealed partial class RemixContestsRelatedEntryCounts
    {

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

    }
}