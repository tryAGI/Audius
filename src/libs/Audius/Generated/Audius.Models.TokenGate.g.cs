
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TokenGate
    {
        /// <summary>
        /// Must hold an NFT of the given collection to unlock
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_gate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.ExtendedTokenGate TokenGate1 { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenGate" /> class.
        /// </summary>
        /// <param name="tokenGate1">
        /// Must hold an NFT of the given collection to unlock
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenGate(
            global::Audius.ExtendedTokenGate tokenGate1)
        {
            this.TokenGate1 = tokenGate1 ?? throw new global::System.ArgumentNullException(nameof(tokenGate1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenGate" /> class.
        /// </summary>
        public TokenGate()
        {
        }

    }
}