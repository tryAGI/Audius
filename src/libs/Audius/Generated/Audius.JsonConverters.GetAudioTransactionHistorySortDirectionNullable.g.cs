#nullable enable

namespace Audius.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAudioTransactionHistorySortDirectionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audius.GetAudioTransactionHistorySortDirection?>
    {
        /// <inheritdoc />
        public override global::Audius.GetAudioTransactionHistorySortDirection? Read(
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
                        return global::Audius.GetAudioTransactionHistorySortDirectionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audius.GetAudioTransactionHistorySortDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audius.GetAudioTransactionHistorySortDirection?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audius.GetAudioTransactionHistorySortDirection? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Audius.GetAudioTransactionHistorySortDirectionExtensions.ToValueString(value.Value));
            }
        }
    }
}
