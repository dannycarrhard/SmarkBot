# IO.Swagger.Api.VolumesApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetVolumesByMarketIds**](VolumesApi.md#getvolumesbymarketids) | **GET** /v3/markets/{market_ids}/volumes/ | Retrieve traded volumes by market ids.

<a name="getvolumesbymarketids"></a>
# **GetVolumesByMarketIds**
> VolumesResponse GetVolumesByMarketIds (List<int?> marketIds)

Retrieve traded volumes by market ids.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVolumesByMarketIdsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VolumesApi();
            var marketIds = new List<int?>(); // List<int?> | Market IDs to filter by<br>maxItems:300

            try
            {
                // Retrieve traded volumes by market ids.
                VolumesResponse result = apiInstance.GetVolumesByMarketIds(marketIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VolumesApi.GetVolumesByMarketIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketIds** | [**List&lt;int?&gt;**](int?.md)| Market IDs to filter by&lt;br&gt;maxItems:300 | 

### Return type

[**VolumesResponse**](VolumesResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
