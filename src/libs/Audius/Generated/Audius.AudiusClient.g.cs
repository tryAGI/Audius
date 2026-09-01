
#nullable enable

namespace Audius
{
    /// <summary>
    /// ## Overview<br/>
    /// The Audius API provides REST access to the world's largest open music catalog, built on the [Open Audio Protocol](https://openaudio.org). Use it to query and stream tracks, users, playlists, and more—perfect for building music players, discovery apps, and audio-native products.<br/>
    /// ## Key Capabilities<br/>
    /// - **Users** — Profiles, followers, following, search<br/>
    /// - **Tracks** — Search, trending, stream, favorites, reposts<br/>
    /// - **Playlists** — Create, update, browse, curate<br/>
    /// - **Resolve** — Look up content by Audius canonical URLs (e.g. `audius.co/artist/...`)<br/>
    /// - **Explore** — Trending content, charts, discovery<br/>
    /// - **Comments, Tips, Rewards** — Social features and engagement<br/>
    /// ## Authentication<br/>
    /// - **Read-only** — Most endpoints work without credentials. Use an API key for higher rate limits.<br/>
    /// - **Writes** — Upload, favorite, repost, and other mutations require an API key and secret. Get keys at [api.audius.co/plans](https://api.audius.co/plans) or [audius.co/settings](https://audius.co/settings).<br/>
    /// ## Resources<br/>
    /// - [API Docs](https://docs.audius.co/api) — Full reference and guides<br/>
    /// - [API Plans](https://api.audius.co/plans) — Get API keys (free tier available)<br/>
    /// - [Log in with Audius](https://docs.audius.co/developers/guides/log-in-with-audius) — OAuth for user actions<br/>
    /// - [JavaScript SDK](https://www.npmjs.com/package/@audius/sdk) — `@audius/sdk` for Node and browser<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class AudiusClient : global::Audius.IAudiusClient, global::System.IDisposable
    {
        /// <summary>
        /// Production
        /// </summary>
        public const string DefaultBaseUrl = "https://api.audius.co/v1";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Audius.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::Audius.AutoSDKClientOptions Options { get; }


        internal global::Audius.AudiusClient.AutoSDKOAuth2Coordinator AutoSDKOAuth2State { get; set; } = new global::Audius.AudiusClient.AutoSDKOAuth2Coordinator();

        internal global::System.Lazy<global::System.Text.Json.Serialization.JsonSerializerContext> JsonSerializerContextProvider { get; set; } = new(() => global::Audius.SourceGenerationContext.Default);

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext
        {
            get => JsonSerializerContextProvider.Value;
            set => JsonSerializerContextProvider = new(() => value);
        }


        /// <summary>
        /// Challenge related operations.
        /// </summary>
        public ChallengesClient Challenges => new ChallengesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        ///
        /// </summary>
        public CidDataClient CidData => new CidDataClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        ///
        /// </summary>
        public CoinsClient Coins => new CoinsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// Comment related operations.
        /// </summary>
        public CommentsClient Comments => new CommentsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// Protocol dashboard wallet users related operations.
        /// </summary>
        public DashboardWalletUsersClient DashboardWalletUsers => new DashboardWalletUsersClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// Developer app related operations.
        /// </summary>
        public DeveloperAppsClient DeveloperApps => new DeveloperAppsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// Events related operations.
        /// </summary>
        public EventsClient Events => new EventsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// Explore related operations.
        /// </summary>
        public ExploreClient Explore => new ExploreClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        ///
        /// </summary>
        public FanClubClient FanClub => new FanClubClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        ///
        /// </summary>
        public NotificationsClient Notifications => new NotificationsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// Playlist related operations.
        /// </summary>
        public PlaylistsClient Playlists => new PlaylistsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// Prize claiming related operations.
        /// </summary>
        public PrizesClient Prizes => new PrizesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        ///
        /// </summary>
        public ReactionsClient Reactions => new ReactionsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// Audius Canonical URL resolver.
        /// </summary>
        public ResolveClient Resolve => new ResolveClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// Rewards related operations.
        /// </summary>
        public RewardsClient Rewards => new RewardsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        ///
        /// </summary>
        public SearchClient Search => new SearchClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// Tip related operations.
        /// </summary>
        public TipsClient Tips => new TipsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// Track related operations.
        /// </summary>
        public TracksClient Tracks => new TracksClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// User related operations.
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        ///
        /// </summary>
        public WalletClient Wallet => new WalletClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// Creates a new instance of the AudiusClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public AudiusClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Audius.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the AudiusClient with explicit options but no base URL override.
        /// Skips passing <c>baseUri</c> so the default base URL from the OpenAPI spec applies.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public AudiusClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Collections.Generic.List<global::Audius.EndPointAuthorization>? authorizations,
            global::Audius.AutoSDKClientOptions? options,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri: null,
                authorizations,
                options,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the AudiusClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public AudiusClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Uri? baseUri,
            global::System.Collections.Generic.List<global::Audius.EndPointAuthorization>? authorizations,
            global::Audius.AutoSDKClientOptions? options,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Audius.EndPointAuthorization>();
            Options = options ?? new global::Audius.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}