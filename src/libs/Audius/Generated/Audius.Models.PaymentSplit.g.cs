
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PaymentSplit
    {
        /// <summary>
        /// Example: 1234
        /// </summary>
        /// <example>1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Percentage { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSplit" /> class.
        /// </summary>
        /// <param name="userId">
        /// Example: 1234
        /// </param>
        /// <param name="percentage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaymentSplit(
            int userId,
            double percentage)
        {
            this.UserId = userId;
            this.Percentage = percentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSplit" /> class.
        /// </summary>
        public PaymentSplit()
        {
        }

    }
}