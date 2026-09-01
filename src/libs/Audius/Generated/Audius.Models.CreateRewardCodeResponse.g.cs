
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateRewardCodeResponse
    {
        /// <summary>
        /// The generated 6-character alphanumeric reward code<br/>
        /// Example: aB3d5F
        /// </summary>
        /// <example>aB3d5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The coin mint address<br/>
        /// Example: 9LzCMqDgTKYz9Drzqnpgee3SGa89up3a247ypMj2xrqM
        /// </summary>
        /// <example>9LzCMqDgTKYz9Drzqnpgee3SGa89up3a247ypMj2xrqM</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mint { get; set; }

        /// <summary>
        /// The reward address (authorized public key)<br/>
        /// Example: 9XeZbswbSSUU4AHVArQbTQjAEjAPhVweGU5cogBVkvh4
        /// </summary>
        /// <example>9XeZbswbSSUU4AHVArQbTQjAEjAPhVweGU5cogBVkvh4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reward_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RewardAddress { get; set; }

        /// <summary>
        /// The reward amount<br/>
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
        /// Initializes a new instance of the <see cref="CreateRewardCodeResponse" /> class.
        /// </summary>
        /// <param name="code">
        /// The generated 6-character alphanumeric reward code<br/>
        /// Example: aB3d5F
        /// </param>
        /// <param name="mint">
        /// The coin mint address<br/>
        /// Example: 9LzCMqDgTKYz9Drzqnpgee3SGa89up3a247ypMj2xrqM
        /// </param>
        /// <param name="rewardAddress">
        /// The reward address (authorized public key)<br/>
        /// Example: 9XeZbswbSSUU4AHVArQbTQjAEjAPhVweGU5cogBVkvh4
        /// </param>
        /// <param name="amount">
        /// The reward amount<br/>
        /// Example: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRewardCodeResponse(
            string code,
            string mint,
            string rewardAddress,
            int amount)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Mint = mint ?? throw new global::System.ArgumentNullException(nameof(mint));
            this.RewardAddress = rewardAddress ?? throw new global::System.ArgumentNullException(nameof(rewardAddress));
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRewardCodeResponse" /> class.
        /// </summary>
        public CreateRewardCodeResponse()
        {
        }

    }
}