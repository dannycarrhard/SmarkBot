# IO.Swagger.Api.PricesApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetExecutionsTimeSeries**](PricesApi.md#getexecutionstimeseries) | **GET** /v3/contracts/{contract_ids}/executions_time_series/ | Retrieve contract executions data, over a time window.
[**GetLastExecutedPricesByMarket**](PricesApi.md#getlastexecutedpricesbymarket) | **GET** /v3/markets/{market_ids}/last_executed_prices/ | Retrieve the last executed price and timestamp for each contract in the market ids provided.
[**GetMdsCharts**](PricesApi.md#getmdscharts) | **GET** /v3/events/{event_id}/markets/{market_id}/contracts/{contract_ids}/executions_time_series/ | Retrieve contract executions data, over a time window.
[**GetQuotes**](PricesApi.md#getquotes) | **GET** /v3/markets/{market_ids}/quotes/ | Get the current prices from the exchange.
[**GetRecentTrades**](PricesApi.md#getrecenttrades) | **GET** /v3/contracts/{contract_ids}/recent_trades/ | Retrieve the most recent trades for each contract.
[**GetStartPricesByMarket**](PricesApi.md#getstartpricesbymarket) | **GET** /v3/markets/{market_ids}/starting_prices/ | Retrieve starting price (at the off) and timestamp for each contract in the market ids provided.

<a name="getexecutionstimeseries"></a>
# **GetExecutionsTimeSeries**
> PriceSeries GetExecutionsTimeSeries (List<int?> contractIds, int? dataPoints = null, DateTime? timestampMin = null, DateTime? timestampMax = null, DateTime? timestampGe = null, DateTime? timestampLt = null)

Retrieve contract executions data, over a time window.

## Description This can be used to populate charts. The number of data points to receive is configurable and the size of the time buckets over the time range is automatically adjusted. In order to get a round-looking time series you must specify an appropriate number of data points for the time range. The requester can ask for price data for up to MAX_CONTRACTS contracts at a time. If there is no data over a time bucket then the data will be returned as null.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExecutionsTimeSeriesExample
    {
        public void main()
        {
            var apiInstance = new PricesApi();
            var contractIds = new List<int?>(); // List<int?> | maxItems:20
            var dataPoints = 56;  // int? |  (optional) 
            var timestampMin = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var timestampMax = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var timestampGe = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var timestampLt = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Retrieve contract executions data, over a time window.
                PriceSeries result = apiInstance.GetExecutionsTimeSeries(contractIds, dataPoints, timestampMin, timestampMax, timestampGe, timestampLt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.GetExecutionsTimeSeries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractIds** | [**List&lt;int?&gt;**](int?.md)| maxItems:20 | 
 **dataPoints** | **int?**|  | [optional] 
 **timestampMin** | **DateTime?**|  | [optional] 
 **timestampMax** | **DateTime?**|  | [optional] 
 **timestampGe** | **DateTime?**|  | [optional] 
 **timestampLt** | **DateTime?**|  | [optional] 

### Return type

[**PriceSeries**](PriceSeries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlastexecutedpricesbymarket"></a>
# **GetLastExecutedPricesByMarket**
> LastExecutedPricesByMarketResponse GetLastExecutedPricesByMarket (List<int?> marketIds)

Retrieve the last executed price and timestamp for each contract in the market ids provided.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLastExecutedPricesByMarketExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PricesApi();
            var marketIds = new List<int?>(); // List<int?> | Market IDs to filter by<br>maxItems:100

            try
            {
                // Retrieve the last executed price and timestamp for each contract in the market ids provided.
                LastExecutedPricesByMarketResponse result = apiInstance.GetLastExecutedPricesByMarket(marketIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.GetLastExecutedPricesByMarket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketIds** | [**List&lt;int?&gt;**](int?.md)| Market IDs to filter by&lt;br&gt;maxItems:100 | 

### Return type

[**LastExecutedPricesByMarketResponse**](LastExecutedPricesByMarketResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmdscharts"></a>
# **GetMdsCharts**
> ExecutionsTimeSeriesResponse GetMdsCharts (int? eventId, int? marketId, List<int?> contractIds, int? dataPoints = null, DateTime? timestampMin = null, DateTime? timestampMax = null)

Retrieve contract executions data, over a time window.

## Description This can be used to populate charts. The number of data points to receive is configurable and the size of the time buckets over the time range is automatically adjusted. In order to get a round-looking time series you must specify an appropriate number of data points for the time range. The requester can ask for price data for up to MAX_CONTRACTS contracts at a time. If there is no data over a time bucket then the data will be returned as null.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMdsChartsExample
    {
        public void main()
        {
            var apiInstance = new PricesApi();
            var eventId = 56;  // int? | 
            var marketId = 56;  // int? | 
            var contractIds = new List<int?>(); // List<int?> | maxItems:20
            var dataPoints = 56;  // int? |  (optional) 
            var timestampMin = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var timestampMax = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Retrieve contract executions data, over a time window.
                ExecutionsTimeSeriesResponse result = apiInstance.GetMdsCharts(eventId, marketId, contractIds, dataPoints, timestampMin, timestampMax);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.GetMdsCharts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **int?**|  | 
 **marketId** | **int?**|  | 
 **contractIds** | [**List&lt;int?&gt;**](int?.md)| maxItems:20 | 
 **dataPoints** | **int?**|  | [optional] 
 **timestampMin** | **DateTime?**|  | [optional] 
 **timestampMax** | **DateTime?**|  | [optional] 

### Return type

[**ExecutionsTimeSeriesResponse**](ExecutionsTimeSeriesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getquotes"></a>
# **GetQuotes**
> Dictionary<string, Object> GetQuotes (List<int?> marketIds)

Get the current prices from the exchange.

## Description If session token is not sent, these prices will be delayed.<br><br> The rate limits below are applicable to API users. The rate limits for non-API users are lower.  ##  Rate limits Maximum 50 requests per 60 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQuotesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PricesApi();
            var marketIds = new List<int?>(); // List<int?> | Market IDs to filter by<br>maxItems:200

            try
            {
                // Get the current prices from the exchange.
                Dictionary&lt;string, Object&gt; result = apiInstance.GetQuotes(marketIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.GetQuotes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketIds** | [**List&lt;int?&gt;**](int?.md)| Market IDs to filter by&lt;br&gt;maxItems:200 | 

### Return type

**Dictionary<string, Object>**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrecenttrades"></a>
# **GetRecentTrades**
> RecentTrades GetRecentTrades (List<int?> contractIds)

Retrieve the most recent trades for each contract.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRecentTradesExample
    {
        public void main()
        {
            var apiInstance = new PricesApi();
            var contractIds = new List<int?>(); // List<int?> | Contract IDs to filter by<br>maxItems:300

            try
            {
                // Retrieve the most recent trades for each contract.
                RecentTrades result = apiInstance.GetRecentTrades(contractIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.GetRecentTrades: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractIds** | [**List&lt;int?&gt;**](int?.md)| Contract IDs to filter by&lt;br&gt;maxItems:300 | 

### Return type

[**RecentTrades**](RecentTrades.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstartpricesbymarket"></a>
# **GetStartPricesByMarket**
> StartingPricesByMarketResponse GetStartPricesByMarket (List<int?> marketIds)

Retrieve starting price (at the off) and timestamp for each contract in the market ids provided.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStartPricesByMarketExample
    {
        public void main()
        {
            var apiInstance = new PricesApi();
            var marketIds = new List<int?>(); // List<int?> | maxItems:300

            try
            {
                // Retrieve starting price (at the off) and timestamp for each contract in the market ids provided.
                StartingPricesByMarketResponse result = apiInstance.GetStartPricesByMarket(marketIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.GetStartPricesByMarket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketIds** | [**List&lt;int?&gt;**](int?.md)| maxItems:300 | 

### Return type

[**StartingPricesByMarketResponse**](StartingPricesByMarketResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
