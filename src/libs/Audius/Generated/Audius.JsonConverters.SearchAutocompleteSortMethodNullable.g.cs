#nullable enable

namespace Audius.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchAutocompleteSortMethodNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audius.SearchAutocompleteSortMethod?>
    {
        /// <inheritdoc />
        public override global::Audius.SearchAutocompleteSortMethod? Read(
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
                        return global::Audius.SearchAutocompleteSortMethodExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audius.SearchAutocompleteSortMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audius.SearchAutocompleteSortMethod?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audius.SearchAutocompleteSortMethod? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Audius.SearchAutocompleteSortMethodExtensions.ToValueString(value.Value));
            }
        }
    }
}
