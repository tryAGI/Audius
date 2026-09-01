
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RewardCodeResponse
    {
        /// <summary>
        /// The reward code<br/>
        /// Example: XYZ123
        /// </summary>
        /// <example>XYZ123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The amount of coins rewarded by this code<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Amount { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RewardCodeResponse" /> class.
        /// </summary>
        /// <param name="code">
        /// The reward code<br/>
        /// Example: XYZ123
        /// </param>
        /// <param name="amount">
        /// The amount of coins rewarded by this code<br/>
        /// Example: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RewardCodeResponse(
            string code,
            int amount)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RewardCodeResponse" /> class.
        /// </summary>
        public RewardCodeResponse()
        {
        }

    }
}