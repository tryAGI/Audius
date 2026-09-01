
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExtendedTokenGate
    {
        /// <summary>
        /// The mint of the token needed to unlock
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_mint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenMint { get; set; }

        /// <summary>
        /// The amount of the token needed to unlock
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TokenAmount { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedTokenGate" /> class.
        /// </summary>
        /// <param name="tokenMint">
        /// The mint of the token needed to unlock
        /// </param>
        /// <param name="tokenAmount">
        /// The amount of the token needed to unlock
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtendedTokenGate(
            string tokenMint,
            int tokenAmount)
        {
            this.TokenMint = tokenMint ?? throw new global::System.ArgumentNullException(nameof(tokenMint));
            this.TokenAmount = tokenAmount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedTokenGate" /> class.
        /// </summary>
        public ExtendedTokenGate()
        {
        }

    }
}