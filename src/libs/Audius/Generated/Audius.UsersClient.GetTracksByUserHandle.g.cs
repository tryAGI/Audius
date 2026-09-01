
#nullable enable

namespace Audius
{
    public partial class UsersClient
    {


        private static readonly global::Audius.EndPointSecurityRequirement s_GetTracksByUserHandleSecurityRequirement0 =
            new global::Audius.EndPointSecurityRequirement
            {
                Authorizations = new global::Audius.EndPointAuthorizationRequirement[]
                {
                },
            };

        private static readonly global::Audius.EndPointSecurityRequirement s_GetTracksByUserHandleSecurityRequirement1 =
            new global::Audius.EndPointSecurityRequirement
            {
                Authorizations = new global::Audius.EndPointAuthorizationRequirement[]
                {                    new global::Audius.EndPointAuthorizationRequirement
                    {
                        Type = "OAuth2",
                        SchemeId = "OAuth2",
                        Location = "Header",
                        Name = "",
                        FriendlyName = "OAuth2",
                    },
                },
            };
        private static readonly global::Audius.EndPointSecurityRequirement[] s_GetTracksByUserHandleSecurityRequirements =
            new global::Audius.EndPointSecurityRequirement[]
            {                s_GetTracksByUserHandleSecurityRequirement0,
                s_GetTracksByUserHandleSecurityRequirement1,
            };
        partial void PrepareGetTracksByUserHandleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string handle,
            ref int? offset,
            ref int? limit,
            ref string? userId,
            ref global::Audius.GetTracksByUserHandleSort? sort,
            ref string? query,
            ref global::Audius.GetTracksByUserHandleSortMethod? sortMethod,
            ref global::Audius.GetTracksByUserHandleSortDirection? sortDirection,
            ref global::Audius.GetTracksByUserHandleFilterTracks? filterTracks,
            ref string? encodedDataMessage,
            ref string? encodedDataSignature);
        partial void PrepareGetTracksByUserHandleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string handle,
            int? offset,
            int? limit,
            string? userId,
            global::Audius.GetTracksByUserHandleSort? sort,
            string? query,
            global::Audius.GetTracksByUserHandleSortMethod? sortMethod,
            global::Audius.GetTracksByUserHandleSortDirection? sortDirection,
            global::Audius.GetTracksByUserHandleFilterTracks? filterTracks,
            string? encodedDataMessage,
            string? encodedDataSignature);
        partial void ProcessGetTracksByUserHandleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetTracksByUserHandleResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets the tracks created by a user using the user's handle
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="sort">
        /// Default Value: date
        /// </param>
        /// <param name="query"></param>
        /// <param name="sortMethod"></param>
        /// <param name="sortDirection"></param>
        /// <param name="filterTracks">
        /// Default Value: all
        /// </param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Audius.Tracks> GetTracksByUserHandleAsync(
            string handle,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetTracksByUserHandleSort? sort = default,
            string? query = default,
            global::Audius.GetTracksByUserHandleSortMethod? sortMethod = default,
            global::Audius.GetTracksByUserHandleSortDirection? sortDirection = default,
            global::Audius.GetTracksByUserHandleFilterTracks? filterTracks = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetTracksByUserHandleAsResponseAsync(
                handle: handle,
                offset: offset,
                limit: limit,
                userId: userId,
                sort: sort,
                query: query,
                sortMethod: sortMethod,
                sortDirection: sortDirection,
                filterTracks: filterTracks,
                encodedDataMessage: encodedDataMessage,
                encodedDataSignature: encodedDataSignature,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Gets the tracks created by a user using the user's handle
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="sort">
        /// Default Value: date
        /// </param>
        /// <param name="query"></param>
        /// <param name="sortMethod"></param>
        /// <param name="sortDirection"></param>
        /// <param name="filterTracks">
        /// Default Value: all
        /// </param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.Tracks>> GetTracksByUserHandleAsResponseAsync(
            string handle,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetTracksByUserHandleSort? sort = default,
            string? query = default,
            global::Audius.GetTracksByUserHandleSortMethod? sortMethod = default,
            global::Audius.GetTracksByUserHandleSortDirection? sortDirection = default,
            global::Audius.GetTracksByUserHandleFilterTracks? filterTracks = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetTracksByUserHandleArguments(
                httpClient: HttpClient,
                handle: ref handle,
                offset: ref offset,
                limit: ref limit,
                userId: ref userId,
                sort: ref sort,
                query: ref query,
                sortMethod: ref sortMethod,
                sortDirection: ref sortDirection,
                filterTracks: ref filterTracks,
                encodedDataMessage: ref encodedDataMessage,
                encodedDataSignature: ref encodedDataSignature);


            var __authorizations = global::Audius.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetTracksByUserHandleSecurityRequirements,
                operationName: "GetTracksByUserHandleAsync");

            using var __timeoutCancellationTokenSource = global::Audius.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Audius.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Audius.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Audius.PathBuilder(
                                path: $"/users/handle/{handle}/tracks",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("offset", offset?.ToString())
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("user_id", userId)
                                .AddOptionalParameter("sort", sort?.ToValueString())
                                .AddOptionalParameter("query", query)
                                .AddOptionalParameter("sort_method", sortMethod?.ToValueString())
                                .AddOptionalParameter("sort_direction", sortDirection?.ToValueString())
                                .AddOptionalParameter("filter_tracks", filterTracks?.ToValueString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Audius.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            if (encodedDataMessage != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Encoded-Data-Message", encodedDataMessage.ToString());
            }
            if (encodedDataSignature != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Encoded-Data-Signature", encodedDataSignature.ToString());
            }

                global::Audius.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetTracksByUserHandleRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    handle: handle!,
                    offset: offset,
                    limit: limit,
                    userId: userId,
                    sort: sort,
                    query: query,
                    sortMethod: sortMethod,
                    sortDirection: sortDirection,
                    filterTracks: filterTracks,
                    encodedDataMessage: encodedDataMessage,
                    encodedDataSignature: encodedDataSignature);

                global::Audius.AutoSDKHttpRequestOptions.StampAuthorizationOverride(__httpRequest);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Audius.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Audius.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetTracksByUserHandle",
                                methodName: "GetTracksByUserHandleAsync",
                                pathTemplate: "$\"/users/handle/{handle}/tracks\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await global::Audius.AudiusClient.AutoSDKOAuth2Helpers.SendAsync(
                httpClient: HttpClient,
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                authorizations: __authorizations,
                oAuth2Coordinator: AutoSDKOAuth2State,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Audius.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Audius.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Audius.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetTracksByUserHandle",
                                methodName: "GetTracksByUserHandleAsync",
                                pathTemplate: "$\"/users/handle/{handle}/tracks\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Audius.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Audius.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Audius.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Audius.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Audius.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetTracksByUserHandle",
                                methodName: "GetTracksByUserHandleAsync",
                                pathTemplate: "$\"/users/handle/{handle}/tracks\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Audius.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGetTracksByUserHandleResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Audius.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Audius.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetTracksByUserHandle",
                                methodName: "GetTracksByUserHandleAsync",
                                pathTemplate: "$\"/users/handle/{handle}/tracks\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Audius.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Audius.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetTracksByUserHandle",
                                methodName: "GetTracksByUserHandleAsync",
                                pathTemplate: "$\"/users/handle/{handle}/tracks\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            //
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Audius.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            //
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::Audius.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessGetTracksByUserHandleResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Audius.Tracks.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Audius.AutoSDKHttpResponse<global::Audius.Tracks>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Audius.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Audius.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Audius.Tracks.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Audius.AutoSDKHttpResponse<global::Audius.Tracks>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Audius.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Audius.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}