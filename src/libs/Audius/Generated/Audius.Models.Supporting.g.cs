
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Supporting
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rank { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Amount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receiver")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.User Receiver { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Supporting" /> class.
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="amount"></param>
        /// <param name="receiver"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Supporting(
            int rank,
            string amount,
            global::Audius.User receiver)
        {
            this.Rank = rank;
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.Receiver = receiver ?? throw new global::System.ArgumentNullException(nameof(receiver));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Supporting" /> class.
        /// </summary>
        public Supporting()
        {
        }

    }
}