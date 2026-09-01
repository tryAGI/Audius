
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FollowGate
    {
        /// <summary>
        /// Must follow the given user ID to unlock
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("follow_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FollowUserId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowGate" /> class.
        /// </summary>
        /// <param name="followUserId">
        /// Must follow the given user ID to unlock
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FollowGate(
            int followUserId)
        {
            this.FollowUserId = followUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowGate" /> class.
        /// </summary>
        public FollowGate()
        {
        }

    }
}