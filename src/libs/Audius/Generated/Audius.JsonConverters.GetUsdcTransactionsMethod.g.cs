#nullable enable

namespace Audius.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetUsdcTransactionsMethodJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audius.GetUsdcTransactionsMethod>
    {
        /// <inheritdoc />
        public override global::Audius.GetUsdcTransactionsMethod Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Audius.GetUsdcTransactionsMethodExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audius.GetUsdcTransactionsMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audius.GetUsdcTransactionsMethod);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audius.GetUsdcTransactionsMethod value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Audius.GetUsdcTransactionsMethodExtensions.ToValueString(value));
        }
    }
}
