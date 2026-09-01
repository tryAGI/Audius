#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Audius.JsonConverters
{
    /// <inheritdoc />
    public class ExtendedAccessGateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audius.ExtendedAccessGate>
    {
        /// <inheritdoc />
        public override global::Audius.ExtendedAccessGate Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("tip_user_id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("follow_user_id")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("usdc_purchase")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("token_gate")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Audius.TipGate? tip = default;
            global::Audius.FollowGate? follow = default;
            global::Audius.ExtendedPurchaseGate? purchase = default;
            global::Audius.TokenGate? token = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TipGate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TipGate> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TipGate).Name}");
                        tip = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FollowGate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FollowGate> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FollowGate).Name}");
                        follow = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ExtendedPurchaseGate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ExtendedPurchaseGate> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ExtendedPurchaseGate).Name}");
                        purchase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TokenGate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TokenGate> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TokenGate).Name}");
                        token = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (tip == null && follow == null && purchase == null && token == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TipGate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TipGate> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TipGate).Name}");
                    tip = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tip == null && follow == null && purchase == null && token == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FollowGate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FollowGate> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FollowGate).Name}");
                    follow = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tip == null && follow == null && purchase == null && token == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ExtendedPurchaseGate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ExtendedPurchaseGate> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ExtendedPurchaseGate).Name}");
                    purchase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tip == null && follow == null && purchase == null && token == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TokenGate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TokenGate> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TokenGate).Name}");
                    token = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Audius.ExtendedAccessGate(
                tip,

                follow,

                purchase,

                token
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audius.ExtendedAccessGate value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTip)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TipGate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TipGate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TipGate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tip!, typeInfo);
            }
            else if (value.IsFollow)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FollowGate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FollowGate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FollowGate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Follow!, typeInfo);
            }
            else if (value.IsPurchase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ExtendedPurchaseGate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ExtendedPurchaseGate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ExtendedPurchaseGate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Purchase!, typeInfo);
            }
            else if (value.IsToken)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TokenGate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TokenGate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TokenGate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Token!, typeInfo);
            }
        }
    }
}