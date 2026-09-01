
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateRewardCodeRequest
    {
        /// <summary>
        /// Base64-encoded Solana Ed25519 signature of the string "code"<br/>
        /// Example: 3fG7xQh2L8vK9pN4mR5sT6uW7vX8yZ1aB2cD3eF4gH5iJ6kL7mN8oP9qR0sT1uV2wX3yZ4aB5cD6eF7gH8iJ9k=
        /// </summary>
        /// <example>3fG7xQh2L8vK9pN4mR5sT6uW7vX8yZ1aB2cD3eF4gH5iJ6kL7mN8oP9qR0sT1uV2wX3yZ4aB5cD6eF7gH8iJ9k=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        /// The coin mint address<br/>
        /// Example: 9LzCMqDgTKYz9Drzqnpgee3SGa89up3a247ypMj2xrqM
        /// </summary>
        /// <example>9LzCMqDgTKYz9Drzqnpgee3SGa89up3a247ypMj2xrqM</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mint { get; set; }

        /// <summary>
        /// The reward amount (must be greater than 0)<br/>
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
        /// Initializes a new instance of the <see cref="CreateRewardCodeRequest" /> class.
        /// </summary>
        /// <param name="signature">
        /// Base64-encoded Solana Ed25519 signature of the string "code"<br/>
        /// Example: 3fG7xQh2L8vK9pN4mR5sT6uW7vX8yZ1aB2cD3eF4gH5iJ6kL7mN8oP9qR0sT1uV2wX3yZ4aB5cD6eF7gH8iJ9k=
        /// </param>
        /// <param name="mint">
        /// The coin mint address<br/>
        /// Example: 9LzCMqDgTKYz9Drzqnpgee3SGa89up3a247ypMj2xrqM
        /// </param>
        /// <param name="amount">
        /// The reward amount (must be greater than 0)<br/>
        /// Example: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRewardCodeRequest(
            string signature,
            string mint,
            int amount)
        {
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.Mint = mint ?? throw new global::System.ArgumentNullException(nameof(mint));
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRewardCodeRequest" /> class.
        /// </summary>
        public CreateRewardCodeRequest()
        {
        }

    }
}