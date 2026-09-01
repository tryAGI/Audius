
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrizeClaimRequestBody
    {
        /// <summary>
        /// The Solana transaction signature for the 2 YAK payment<br/>
        /// Example: 5j7s1QjmRKFuDbCWMRVRNibSV2VAAEcNKP6HWU7GwPdXkBZvhz8n4vQl7bBq8tN4Rz9x1Kj3mP5wQ8rT2Y6zA
        /// </summary>
        /// <example>5j7s1QjmRKFuDbCWMRVRNibSV2VAAEcNKP6HWU7GwPdXkBZvhz8n4vQl7bBq8tN4Rz9x1Kj3mP5wQ8rT2Y6zA</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        /// The wallet address that sent the transaction<br/>
        /// Example: HLnpSz9h2S4hiLQ43rnSD9XkcUThA7B8hQMKmDaiTLcC
        /// </summary>
        /// <example>HLnpSz9h2S4hiLQ43rnSD9XkcUThA7B8hQMKmDaiTLcC</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("wallet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Wallet { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrizeClaimRequestBody" /> class.
        /// </summary>
        /// <param name="signature">
        /// The Solana transaction signature for the 2 YAK payment<br/>
        /// Example: 5j7s1QjmRKFuDbCWMRVRNibSV2VAAEcNKP6HWU7GwPdXkBZvhz8n4vQl7bBq8tN4Rz9x1Kj3mP5wQ8rT2Y6zA
        /// </param>
        /// <param name="wallet">
        /// The wallet address that sent the transaction<br/>
        /// Example: HLnpSz9h2S4hiLQ43rnSD9XkcUThA7B8hQMKmDaiTLcC
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrizeClaimRequestBody(
            string signature,
            string wallet)
        {
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.Wallet = wallet ?? throw new global::System.ArgumentNullException(nameof(wallet));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrizeClaimRequestBody" /> class.
        /// </summary>
        public PrizeClaimRequestBody()
        {
        }

    }
}