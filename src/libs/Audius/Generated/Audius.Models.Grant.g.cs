
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Grant
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grantee_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GranteeAddress { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_revoked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsRevoked { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_approved")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsApproved { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Grant" /> class.
        /// </summary>
        /// <param name="granteeAddress"></param>
        /// <param name="userId"></param>
        /// <param name="isRevoked"></param>
        /// <param name="isApproved"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Grant(
            string granteeAddress,
            string userId,
            bool isRevoked,
            bool isApproved,
            string createdAt,
            string updatedAt)
        {
            this.GranteeAddress = granteeAddress ?? throw new global::System.ArgumentNullException(nameof(granteeAddress));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.IsRevoked = isRevoked;
            this.IsApproved = isApproved;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Grant" /> class.
        /// </summary>
        public Grant()
        {
        }

    }
}