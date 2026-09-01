
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RedeemAmountResponse
    {
        /// <summary>
        /// Static amount indicator (always 1)<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Amount { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RedeemAmountResponse" /> class.
        /// </summary>
        /// <param name="amount">
        /// Static amount indicator (always 1)<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RedeemAmountResponse(
            int amount)
        {
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedeemAmountResponse" /> class.
        /// </summary>
        public RedeemAmountResponse()
        {
        }

    }
}