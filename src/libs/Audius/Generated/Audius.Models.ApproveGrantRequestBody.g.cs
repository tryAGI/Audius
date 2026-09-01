
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApproveGrantRequestBody
    {
        /// <summary>
        /// The user ID of the child user who proposed the manager (grantor)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grantor_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GrantorUserId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproveGrantRequestBody" /> class.
        /// </summary>
        /// <param name="grantorUserId">
        /// The user ID of the child user who proposed the manager (grantor)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApproveGrantRequestBody(
            string grantorUserId)
        {
            this.GrantorUserId = grantorUserId ?? throw new global::System.ArgumentNullException(nameof(grantorUserId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproveGrantRequestBody" /> class.
        /// </summary>
        public ApproveGrantRequestBody()
        {
        }

    }
}