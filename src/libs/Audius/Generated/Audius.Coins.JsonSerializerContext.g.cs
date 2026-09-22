
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Coin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DynamicBondingCurveInsights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistLocker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistCoinFees))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RewardPool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinsVolumeLeadersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CoinsVolumeLeadersResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinsVolumeLeadersResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateCoinResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateCoinResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CoinMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserArtistCoinBadge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoverPhoto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ProfilePicture))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibrary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinInsightsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinInsights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateCoinRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimRewardsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ClaimRewardsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimRewardsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateCoinRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RewardCodeErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RewardCodeErrorResponseError), TypeInfoPropertyName = "RewardCodeErrorResponseError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinMembersCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RedeemAmountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Coin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateCoinResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RewardCodeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinInsightsExtensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinInsightsDynamicBondingCurve))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinsSortMethod), TypeInfoPropertyName = "GetCoinsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinsSortDirection), TypeInfoPropertyName = "GetCoinsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinMembersSortDirection), TypeInfoPropertyName = "GetCoinMembersSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RewardCodeErrorResponseError?), TypeInfoPropertyName = "NullableRewardCodeErrorResponseError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinsSortMethod?), TypeInfoPropertyName = "NullableGetCoinsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinsSortDirection?), TypeInfoPropertyName = "NullableGetCoinsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinMembersSortDirection?), TypeInfoPropertyName = "NullableGetCoinMembersSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CoinsVolumeLeadersResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CoinMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ClaimRewardsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Coin>))]
    internal sealed partial class CoinsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CoinsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CoinsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CoinsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Audius.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Audius.RewardCodeErrorResponseError)

                    || typeToConvert == typeof(global::Audius.RewardCodeErrorResponseError?)

                    || typeToConvert == typeof(global::Audius.GetCoinsSortMethod)

                    || typeToConvert == typeof(global::Audius.GetCoinsSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetCoinsSortDirection)

                    || typeToConvert == typeof(global::Audius.GetCoinsSortDirection?)

                    || typeToConvert == typeof(global::Audius.GetCoinMembersSortDirection)

                    || typeToConvert == typeof(global::Audius.GetCoinMembersSortDirection?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Audius.RewardCodeErrorResponseError))
                {
                    return new global::Audius.JsonConverters.RewardCodeErrorResponseErrorJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.RewardCodeErrorResponseError?))
                {
                    return new global::Audius.JsonConverters.RewardCodeErrorResponseErrorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetCoinsSortMethod))
                {
                    return new global::Audius.JsonConverters.GetCoinsSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetCoinsSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetCoinsSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetCoinsSortDirection))
                {
                    return new global::Audius.JsonConverters.GetCoinsSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetCoinsSortDirection?))
                {
                    return new global::Audius.JsonConverters.GetCoinsSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetCoinMembersSortDirection))
                {
                    return new global::Audius.JsonConverters.GetCoinMembersSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetCoinMembersSortDirection?))
                {
                    return new global::Audius.JsonConverters.GetCoinMembersSortDirectionNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new CoinsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}