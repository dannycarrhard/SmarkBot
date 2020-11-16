# IO.Swagger.Api.MarketsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMarketsByEventIds**](MarketsApi.md#getmarketsbyeventids) | **GET** /v3/events/{event_ids}/markets/ | Retrieve markets by event ids. This should be done after getting events.
[**GetMarketsByMarketIds**](MarketsApi.md#getmarketsbymarketids) | **GET** /v3/markets/{market_ids}/ | Retrieve markets by market ids.

<a name="getmarketsbyeventids"></a>
# **GetMarketsByEventIds**
> MarketsResponse GetMarketsByEventIds (List<int?> eventIds, string sort = null, int? limitByEvent = null, bool? popular = null, bool? includeHidden = null)

Retrieve markets by event ids. This should be done after getting events.

## Description Each bettable event has a set of markets. Each market will have a set of contracts.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMarketsByEventIdsExample
    {
        public void main()
        {
            var apiInstance = new MarketsApi();
            var eventIds = new List<int?>(); // List<int?> | Event IDs to filter by<br>maxItems:50
            var sort = sort_example;  // string | The only sorting option for markets is to sort by event_id and then by display order (optional)  (default to event_id,display_order)
            var limitByEvent = 56;  // int? | How many markets to retrieve per event, sorted by display order (optional) 
            var popular = true;  // bool? | Filter market types by the popular market types for the event type (optional)  (default to false)
            var includeHidden = true;  // bool? | Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional)  (default to false)

            try
            {
                // Retrieve markets by event ids. This should be done after getting events.
                MarketsResponse result = apiInstance.GetMarketsByEventIds(eventIds, sort, limitByEvent, popular, includeHidden);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketsApi.GetMarketsByEventIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventIds** | [**List&lt;int?&gt;**](int?.md)| Event IDs to filter by&lt;br&gt;maxItems:50 | 
 **sort** | **string**| The only sorting option for markets is to sort by event_id and then by display order | [optional] [default to event_id,display_order]
 **limitByEvent** | **int?**| How many markets to retrieve per event, sorted by display order | [optional] 
 **popular** | **bool?**| Filter market types by the popular market types for the event type | [optional] [default to false]
 **includeHidden** | **bool?**| Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. | [optional] [default to false]

### Return type

[**MarketsResponse**](MarketsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmarketsbymarketids"></a>
# **GetMarketsByMarketIds**
> MarketsResponse GetMarketsByMarketIds (List<int?> marketIds, bool? includeHidden = null)

Retrieve markets by market ids.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMarketsByMarketIdsExample
    {
        public void main()
        {
            var apiInstance = new MarketsApi();
            var marketIds = new List<int?>(); // List<int?> | maxItems:300
            var includeHidden = true;  // bool? | Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. (optional)  (default to false)

            try
            {
                // Retrieve markets by market ids.
                MarketsResponse result = apiInstance.GetMarketsByMarketIds(marketIds, includeHidden);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketsApi.GetMarketsByMarketIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketIds** | [**List&lt;int?&gt;**](int?.md)| maxItems:300 | 
 **includeHidden** | **bool?**| Choose to include in the response markets that are not visible on the website. Hidden markets may not be displayed for a varied number of reasons, and are not available to bet on. | [optional] [default to false]

### Return type

[**MarketsResponse**](MarketsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
