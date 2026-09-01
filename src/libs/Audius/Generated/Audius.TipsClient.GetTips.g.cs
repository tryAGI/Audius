
#nullable enable

namespace Audius
{
    public partial class TipsClient
    {


        private static readonly global::Audius.EndPointSecurityRequirement s_GetTipsSecurityRequirement0 =
            new global::Audius.EndPointSecurityRequirement
            {
                Authorizations = new global::Audius.EndPointAuthorizationRequirement[]
                {
                },
            };

        private static readonly global::Audius.EndPointSecurityRequirement s_GetTipsSecurityRequirement1 =
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
        private static readonly global::Audius.EndPointSecurityRequirement[] s_GetTipsSecurityRequirements =
            new global::Audius.EndPointSecurityRequirement[]
            {                s_GetTipsSecurityRequirement0,
                s_GetTipsSecurityRequirement1,
            };
        partial void PrepareGetTipsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? offset,
            ref int? limit,
            ref string? userId,
            ref int? receiverMinFollowers,
            ref bool? receiverIsVerified,
            ref global::Audius.GetTipsCurrentUserFollows? currentUserFollows,
            ref global::Audius.GetTipsUniqueBy? uniqueBy,
            ref int? minSlot,
            ref int? maxSlot,
            global::System.Collections.Generic.IList<string>? txSignatures);
        partial void PrepareGetTipsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? offset,
            int? limit,
            string? userId,
            int? receiverMinFollowers,
            bool? receiverIsVerified,
            global::Audius.GetTipsCurrentUserFollows? currentUserFollows,
            global::Audius.GetTipsUniqueBy? uniqueBy,
            int? minSlot,
            int? maxSlot,
            global::System.Collections.Generic.IList<string>? txSignatures);
        partial void ProcessGetTipsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetTipsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets the most recent tips on the network
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="receiverMinFollowers">
        /// Default Value: 0
        /// </param>
        /// <param name="receiverIsVerified">
        /// Default Value: false
        /// </param>
        /// <param name="currentUserFollows"></param>
        /// <param name="uniqueBy"></param>
        /// <param name="minSlot">
        /// Default Value: 0
        /// </param>
        /// <param name="maxSlot">
        /// Default Value: 0
        /// </param>
        /// <param name="txSignatures"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Audius.GetTipsResponse> GetTipsAsync(
            int? offset = default,
            int? limit = default,
            string? userId = default,
            int? receiverMinFollowers = default,
            bool? receiverIsVerified = default,
            global::Audius.GetTipsCurrentUserFollows? currentUserFollows = default,
            global::Audius.GetTipsUniqueBy? uniqueBy = default,
            int? minSlot = default,
            int? maxSlot = default,
            global::System.Collections.Generic.IList<string>? txSignatures = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetTipsAsResponseAsync(
                offset: offset,
                limit: limit,
                userId: userId,
                receiverMinFollowers: receiverMinFollowers,
                receiverIsVerified: receiverIsVerified,
                currentUserFollows: currentUserFollows,
                uniqueBy: uniqueBy,
                minSlot: minSlot,
                maxSlot: maxSlot,
                txSignatures: txSignatures,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Gets the most recent tips on the network
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="receiverMinFollowers">
        /// Default Value: 0
        /// </param>
        /// <param name="receiverIsVerified">
        /// Default Value: false
        /// </param>
        /// <param name="currentUserFollows"></param>
        /// <param name="uniqueBy"></param>
        /// <param name="minSlot">
        /// Default Value: 0
        /// </param>
        /// <param name="maxSlot">
        /// Default Value: 0
        /// </param>
        /// <param name="txSignatures"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.GetTipsResponse>> GetTipsAsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? userId = default,
            int? receiverMinFollowers = default,
            bool? receiverIsVerified = default,
            global::Audius.GetTipsCurrentUserFollows? currentUserFollows = default,
            global::Audius.GetTipsUniqueBy? uniqueBy = default,
            int? minSlot = default,
            int? maxSlot = default,
            global::System.Collections.Generic.IList<string>? txSignatures = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetTipsArguments(
                httpClient: HttpClient,
                offset: ref offset,
                limit: ref limit,
                userId: ref userId,
                receiverMinFollowers: ref receiverMinFollowers,
                receiverIsVerified: ref receiverIsVerified,
                currentUserFollows: ref currentUserFollows,
                uniqueBy: ref uniqueBy,
                minSlot: ref minSlot,
                maxSlot: ref maxSlot,
                txSignatures: txSignatures);


            var __authorizations = global::Audius.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetTipsSecurityRequirements,
                operationName: "GetTipsAsync");

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
                                path: "/tips",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("offset", offset?.ToString())
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("user_id", userId)
                                .AddOptionalParameter("receiver_min_followers", receiverMinFollowers?.ToString())
                                .AddOptionalParameter("receiver_is_verified", receiverIsVerified?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("current_user_follows", currentUserFollows?.ToValueString())
                                .AddOptionalParameter("unique_by", uniqueBy?.ToValueString())
                                .AddOptionalParameter("min_slot", minSlot?.ToString())
                                .AddOptionalParameter("max_slot", maxSlot?.ToString())
                                .AddOptionalParameter("tx_signatures", txSignatures, delimiter: ",", explode: false)
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
                global::Audius.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetTipsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    offset: offset,
                    limit: limit,
                    userId: userId,
                    receiverMinFollowers: receiverMinFollowers,
                    receiverIsVerified: receiverIsVerified,
                    currentUserFollows: currentUserFollows,
                    uniqueBy: uniqueBy,
                    minSlot: minSlot,
                    maxSlot: maxSlot,
                    txSignatures: txSignatures);

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
                                operationId: "GetTips",
                                methodName: "GetTipsAsync",
                                pathTemplate: "\"/tips\"",
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
                                operationId: "GetTips",
                                methodName: "GetTipsAsync",
                                pathTemplate: "\"/tips\"",
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
                                operationId: "GetTips",
                                methodName: "GetTipsAsync",
                                pathTemplate: "\"/tips\"",
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
                ProcessGetTipsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Audius.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Audius.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetTips",
                                methodName: "GetTipsAsync",
                                pathTemplate: "\"/tips\"",
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
                                operationId: "GetTips",
                                methodName: "GetTipsAsync",
                                pathTemplate: "\"/tips\"",
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
                                ProcessGetTipsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Audius.GetTipsResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Audius.AutoSDKHttpResponse<global::Audius.GetTipsResponse>(
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

                                    var __value = await global::Audius.GetTipsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Audius.AutoSDKHttpResponse<global::Audius.GetTipsResponse>(
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