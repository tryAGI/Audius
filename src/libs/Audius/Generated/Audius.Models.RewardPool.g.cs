
#nullable enable

namespace Audius
{
    /// <summary>
    /// Reward pool for the coin
    /// </summary>
    public sealed partial class RewardPool
    {
        /// <summary>
        /// Reward pool contract address
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// Reward pool balance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        public double? Balance { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RewardPool" /> class.
        /// </summary>
        /// <param name="address">
        /// Reward pool contract address
        /// </param>
        /// <param name="balance">
        /// Reward pool balance
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RewardPool(
            string? address,
            double? balance)
        {
            this.Address = address;
            this.Balance = balance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RewardPool" /> class.
        /// </summary>
        public RewardPool()
        {
        }

    }
}