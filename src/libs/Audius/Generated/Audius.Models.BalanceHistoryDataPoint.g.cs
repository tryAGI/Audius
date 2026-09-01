
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BalanceHistoryDataPoint
    {
        /// <summary>
        /// Unix timestamp in seconds<br/>
        /// Example: 1704067200
        /// </summary>
        /// <example>1704067200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// Total portfolio balance in USD at this timestamp<br/>
        /// Example: 1234.56
        /// </summary>
        /// <example>1234.56</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BalanceUsd { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceHistoryDataPoint" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Unix timestamp in seconds<br/>
        /// Example: 1704067200
        /// </param>
        /// <param name="balanceUsd">
        /// Total portfolio balance in USD at this timestamp<br/>
        /// Example: 1234.56
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BalanceHistoryDataPoint(
            global::System.DateTimeOffset timestamp,
            double balanceUsd)
        {
            this.Timestamp = timestamp;
            this.BalanceUsd = balanceUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceHistoryDataPoint" /> class.
        /// </summary>
        public BalanceHistoryDataPoint()
        {
        }

    }
}