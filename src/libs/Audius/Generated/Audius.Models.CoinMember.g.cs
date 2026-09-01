
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CoinMember
    {
        /// <summary>
        /// The user's balance of the specific coin (in wei)<br/>
        /// Example: 100000
        /// </summary>
        /// <example>100000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Balance { get; set; }

        /// <summary>
        /// The ID of the user with a non-zero balance<br/>
        /// Example: 7eP5n
        /// </summary>
        /// <example>7eP5n</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoinMember" /> class.
        /// </summary>
        /// <param name="balance">
        /// The user's balance of the specific coin (in wei)<br/>
        /// Example: 100000
        /// </param>
        /// <param name="userId">
        /// The ID of the user with a non-zero balance<br/>
        /// Example: 7eP5n
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoinMember(
            int balance,
            string userId)
        {
            this.Balance = balance;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoinMember" /> class.
        /// </summary>
        public CoinMember()
        {
        }

    }
}