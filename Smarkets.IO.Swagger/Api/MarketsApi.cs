/* 
 * Smarkets HTTP API
 *
 * This is the HTTP trading API for Smarkets. It can be used to trade on our exchange.     <br><br>For authenticated requests:<br>     <ul>     <li>Get a session token using the login route:     <a class=\"nostyle\" href=\"#/sessions/create_session\"><span>GET /v3/sessions/</span></a></li>     <li>Click on 'Authorize 🔓', enter your token after 'Session-Token ' and click on the 'Authorize' button</li>     </ul>     <p>In order to place bets and get the latest prices without restrictions     using this API, you need to be a Smarkets API user.<br></p>     <p>To become one, please fill <a href=\"https://docs.google.com/forms/d/1qI8RqypNimakPx- bmoUE_lA0YSP3YogKfL8N14STNSM/viewform?edit_requested=true\">this form</a>.</p>     <p>For questions and feedback about the API, use <a href=\"https://community.smarkets.com/c/developers\">our forum</a>.</p>     <p>The API is not public, but we are granting users access on an ongoing basis.</p>     <p>You can find some sample code to help you bootstrap your integration <a href=\"https://github.com/ smarkets/smk_trading_bot\">here</a>.</p>     
 *
 * OpenAPI spec version: 3
 * Contact: api@smarkets.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IMarketsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve markets by event ids. This should be done after getting events.
        /// </summary>
        /// <remarks>
        /// ## Description Each bettable event has a set of markets. Each market will have a set of contracts.  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventIds">Event IDs to filter by&lt;br&gt;maxItems:50</param>
        /// <param name="sort">The only sorting option for markets is to sort by event_id and then by display order (optional, default to event_id,display_order)</param>
        /// <param name="limitByEvent">How many markets to retrieve per event, sorted by display order (optional)</param>
        /// <param name="popular">Filter market types by the popular market types for the event type (optional, default to false)</param>
        /// <param name="includeHidden">Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional, default to false)</param>
        /// <returns>MarketsResponse</returns>
        MarketsResponse GetMarketsByEventIds (List<int?> eventIds, string sort = null, int? limitByEvent = null, bool? popular = null, bool? includeHidden = null);

        /// <summary>
        /// Retrieve markets by event ids. This should be done after getting events.
        /// </summary>
        /// <remarks>
        /// ## Description Each bettable event has a set of markets. Each market will have a set of contracts.  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventIds">Event IDs to filter by&lt;br&gt;maxItems:50</param>
        /// <param name="sort">The only sorting option for markets is to sort by event_id and then by display order (optional, default to event_id,display_order)</param>
        /// <param name="limitByEvent">How many markets to retrieve per event, sorted by display order (optional)</param>
        /// <param name="popular">Filter market types by the popular market types for the event type (optional, default to false)</param>
        /// <param name="includeHidden">Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional, default to false)</param>
        /// <returns>ApiResponse of MarketsResponse</returns>
        ApiResponse<MarketsResponse> GetMarketsByEventIdsWithHttpInfo (List<int?> eventIds, string sort = null, int? limitByEvent = null, bool? popular = null, bool? includeHidden = null);
        /// <summary>
        /// Retrieve markets by market ids.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="marketIds">maxItems:300</param>
        /// <param name="includeHidden">Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional, default to false)</param>
        /// <returns>MarketsResponse</returns>
        MarketsResponse GetMarketsByMarketIds (List<int?> marketIds, bool? includeHidden = null);

        /// <summary>
        /// Retrieve markets by market ids.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="marketIds">maxItems:300</param>
        /// <param name="includeHidden">Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional, default to false)</param>
        /// <returns>ApiResponse of MarketsResponse</returns>
        ApiResponse<MarketsResponse> GetMarketsByMarketIdsWithHttpInfo (List<int?> marketIds, bool? includeHidden = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve markets by event ids. This should be done after getting events.
        /// </summary>
        /// <remarks>
        /// ## Description Each bettable event has a set of markets. Each market will have a set of contracts.  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventIds">Event IDs to filter by&lt;br&gt;maxItems:50</param>
        /// <param name="sort">The only sorting option for markets is to sort by event_id and then by display order (optional, default to event_id,display_order)</param>
        /// <param name="limitByEvent">How many markets to retrieve per event, sorted by display order (optional)</param>
        /// <param name="popular">Filter market types by the popular market types for the event type (optional, default to false)</param>
        /// <param name="includeHidden">Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional, default to false)</param>
        /// <returns>Task of MarketsResponse</returns>
        System.Threading.Tasks.Task<MarketsResponse> GetMarketsByEventIdsAsync (List<int?> eventIds, string sort = null, int? limitByEvent = null, bool? popular = null, bool? includeHidden = null);

        /// <summary>
        /// Retrieve markets by event ids. This should be done after getting events.
        /// </summary>
        /// <remarks>
        /// ## Description Each bettable event has a set of markets. Each market will have a set of contracts.  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventIds">Event IDs to filter by&lt;br&gt;maxItems:50</param>
        /// <param name="sort">The only sorting option for markets is to sort by event_id and then by display order (optional, default to event_id,display_order)</param>
        /// <param name="limitByEvent">How many markets to retrieve per event, sorted by display order (optional)</param>
        /// <param name="popular">Filter market types by the popular market types for the event type (optional, default to false)</param>
        /// <param name="includeHidden">Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (MarketsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MarketsResponse>> GetMarketsByEventIdsAsyncWithHttpInfo (List<int?> eventIds, string sort = null, int? limitByEvent = null, bool? popular = null, bool? includeHidden = null);
        /// <summary>
        /// Retrieve markets by market ids.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="marketIds">maxItems:300</param>
        /// <param name="includeHidden">Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional, default to false)</param>
        /// <returns>Task of MarketsResponse</returns>
        System.Threading.Tasks.Task<MarketsResponse> GetMarketsByMarketIdsAsync (List<int?> marketIds, bool? includeHidden = null);

        /// <summary>
        /// Retrieve markets by market ids.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="marketIds">maxItems:300</param>
        /// <param name="includeHidden">Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (MarketsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MarketsResponse>> GetMarketsByMarketIdsAsyncWithHttpInfo (List<int?> marketIds, bool? includeHidden = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class MarketsApi : IMarketsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MarketsApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketsApi"/> class
        /// </summary>
        /// <returns></returns>
        public MarketsApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MarketsApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Retrieve markets by event ids. This should be done after getting events. ## Description Each bettable event has a set of markets. Each market will have a set of contracts.  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventIds">Event IDs to filter by&lt;br&gt;maxItems:50</param>
        /// <param name="sort">The only sorting option for markets is to sort by event_id and then by display order (optional, default to event_id,display_order)</param>
        /// <param name="limitByEvent">How many markets to retrieve per event, sorted by display order (optional)</param>
        /// <param name="popular">Filter market types by the popular market types for the event type (optional, default to false)</param>
        /// <param name="includeHidden">Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional, default to false)</param>
        /// <returns>MarketsResponse</returns>
        public MarketsResponse GetMarketsByEventIds (List<int?> eventIds, string sort = null, int? limitByEvent = null, bool? popular = null, bool? includeHidden = null)
        {
             ApiResponse<MarketsResponse> localVarResponse = GetMarketsByEventIdsWithHttpInfo(eventIds, sort, limitByEvent, popular, includeHidden);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve markets by event ids. This should be done after getting events. ## Description Each bettable event has a set of markets. Each market will have a set of contracts.  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventIds">Event IDs to filter by&lt;br&gt;maxItems:50</param>
        /// <param name="sort">The only sorting option for markets is to sort by event_id and then by display order (optional, default to event_id,display_order)</param>
        /// <param name="limitByEvent">How many markets to retrieve per event, sorted by display order (optional)</param>
        /// <param name="popular">Filter market types by the popular market types for the event type (optional, default to false)</param>
        /// <param name="includeHidden">Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional, default to false)</param>
        /// <returns>ApiResponse of MarketsResponse</returns>
        public ApiResponse< MarketsResponse > GetMarketsByEventIdsWithHttpInfo (List<int?> eventIds, string sort = null, int? limitByEvent = null, bool? popular = null, bool? includeHidden = null)
        {
            // verify the required parameter 'eventIds' is set
            if (eventIds == null)
                throw new ApiException(400, "Missing required parameter 'eventIds' when calling MarketsApi->GetMarketsByEventIds");

            var localVarPath = "/v3/events/{event_ids}/markets/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (eventIds != null) localVarPathParams.Add("event_ids", this.Configuration.ApiClient.ParameterToString(eventIds)); // path parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            if (limitByEvent != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit_by_event", limitByEvent)); // query parameter
            if (popular != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "popular", popular)); // query parameter
            if (includeHidden != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_hidden", includeHidden)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetMarketsByEventIds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MarketsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MarketsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MarketsResponse)));
        }

        /// <summary>
        /// Retrieve markets by event ids. This should be done after getting events. ## Description Each bettable event has a set of markets. Each market will have a set of contracts.  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventIds">Event IDs to filter by&lt;br&gt;maxItems:50</param>
        /// <param name="sort">The only sorting option for markets is to sort by event_id and then by display order (optional, default to event_id,display_order)</param>
        /// <param name="limitByEvent">How many markets to retrieve per event, sorted by display order (optional)</param>
        /// <param name="popular">Filter market types by the popular market types for the event type (optional, default to false)</param>
        /// <param name="includeHidden">Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional, default to false)</param>
        /// <returns>Task of MarketsResponse</returns>
        public async System.Threading.Tasks.Task<MarketsResponse> GetMarketsByEventIdsAsync (List<int?> eventIds, string sort = null, int? limitByEvent = null, bool? popular = null, bool? includeHidden = null)
        {
             ApiResponse<MarketsResponse> localVarResponse = await GetMarketsByEventIdsAsyncWithHttpInfo(eventIds, sort, limitByEvent, popular, includeHidden);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve markets by event ids. This should be done after getting events. ## Description Each bettable event has a set of markets. Each market will have a set of contracts.  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventIds">Event IDs to filter by&lt;br&gt;maxItems:50</param>
        /// <param name="sort">The only sorting option for markets is to sort by event_id and then by display order (optional, default to event_id,display_order)</param>
        /// <param name="limitByEvent">How many markets to retrieve per event, sorted by display order (optional)</param>
        /// <param name="popular">Filter market types by the popular market types for the event type (optional, default to false)</param>
        /// <param name="includeHidden">Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (MarketsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MarketsResponse>> GetMarketsByEventIdsAsyncWithHttpInfo (List<int?> eventIds, string sort = null, int? limitByEvent = null, bool? popular = null, bool? includeHidden = null)
        {
            // verify the required parameter 'eventIds' is set
            if (eventIds == null)
                throw new ApiException(400, "Missing required parameter 'eventIds' when calling MarketsApi->GetMarketsByEventIds");

            var localVarPath = "/v3/events/{event_ids}/markets/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (eventIds != null) localVarPathParams.Add("event_ids", this.Configuration.ApiClient.ParameterToString(eventIds)); // path parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            if (limitByEvent != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit_by_event", limitByEvent)); // query parameter
            if (popular != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "popular", popular)); // query parameter
            if (includeHidden != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_hidden", includeHidden)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetMarketsByEventIds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MarketsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MarketsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MarketsResponse)));
        }

        /// <summary>
        /// Retrieve markets by market ids. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="marketIds">maxItems:300</param>
        /// <param name="includeHidden">Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional, default to false)</param>
        /// <returns>MarketsResponse</returns>
        public MarketsResponse GetMarketsByMarketIds (List<int?> marketIds, bool? includeHidden = null)
        {
             ApiResponse<MarketsResponse> localVarResponse = GetMarketsByMarketIdsWithHttpInfo(marketIds, includeHidden);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve markets by market ids. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="marketIds">maxItems:300</param>
        /// <param name="includeHidden">Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional, default to false)</param>
        /// <returns>ApiResponse of MarketsResponse</returns>
        public ApiResponse< MarketsResponse > GetMarketsByMarketIdsWithHttpInfo (List<int?> marketIds, bool? includeHidden = null)
        {
            // verify the required parameter 'marketIds' is set
            if (marketIds == null)
                throw new ApiException(400, "Missing required parameter 'marketIds' when calling MarketsApi->GetMarketsByMarketIds");

            var localVarPath = "/v3/markets/{market_ids}/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (marketIds != null) localVarPathParams.Add("market_ids", this.Configuration.ApiClient.ParameterToString(marketIds)); // path parameter
            if (includeHidden != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_hidden", includeHidden)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetMarketsByMarketIds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MarketsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MarketsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MarketsResponse)));
        }

        /// <summary>
        /// Retrieve markets by market ids. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="marketIds">maxItems:300</param>
        /// <param name="includeHidden">Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional, default to false)</param>
        /// <returns>Task of MarketsResponse</returns>
        public async System.Threading.Tasks.Task<MarketsResponse> GetMarketsByMarketIdsAsync (List<int?> marketIds, bool? includeHidden = null)
        {
             ApiResponse<MarketsResponse> localVarResponse = await GetMarketsByMarketIdsAsyncWithHttpInfo(marketIds, includeHidden);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve markets by market ids. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="marketIds">maxItems:300</param>
        /// <param name="includeHidden">Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (MarketsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MarketsResponse>> GetMarketsByMarketIdsAsyncWithHttpInfo (List<int?> marketIds, bool? includeHidden = null)
        {
            // verify the required parameter 'marketIds' is set
            if (marketIds == null)
                throw new ApiException(400, "Missing required parameter 'marketIds' when calling MarketsApi->GetMarketsByMarketIds");

            var localVarPath = "/v3/markets/{market_ids}/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (marketIds != null) localVarPathParams.Add("market_ids", this.Configuration.ApiClient.ParameterToString(marketIds)); // path parameter
            if (includeHidden != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_hidden", includeHidden)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetMarketsByMarketIds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MarketsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MarketsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MarketsResponse)));
        }

    }
}
