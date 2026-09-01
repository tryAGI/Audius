#nullable enable

namespace Audius.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAudioTransactionHistorySortMethodNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audius.GetAudioTransactionHistorySortMethod?>
    {
        /// <inheritdoc />
        public override global::Audius.GetAudioTransactionHistorySortMethod? Read(
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
                        return global::Audius.GetAudioTransactionHistorySortMethodExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audius.GetAudioTransactionHistorySortMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audius.GetAudioTransactionHistorySortMethod?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audius.GetAudioTransactionHistorySortMethod? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Audius.GetAudioTransactionHistorySortMethodExtensions.ToValueString(value.Value));
            }
        }
    }
}
