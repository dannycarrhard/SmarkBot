# IO.Swagger.Api.TraderDashboardApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMakerTaker**](TraderDashboardApi.md#getmakertaker) | **GET** /v3/maker_taker_percentages/ | Get the percentage of your volume that is making/taking liquidity.

<a name="getmakertaker"></a>
# **GetMakerTaker**
> MakerTakerPercentages GetMakerTaker (DateTime? datetimeMax = null, DateTime? datetimeMin = null)

Get the percentage of your volume that is making/taking liquidity.

## Description This route tell you what percentage of your volume is making and what percentage is taking liquidity within the selected time period.  This is mostly for our market makers to check how much liquidity they are adding. If you fall into this category then please check this route every day or so and make sure that you are adding liquidity.  ##  Rate limits Maximum 3 requests per 30 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMakerTakerExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TraderDashboardApi();
            var datetimeMax = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var datetimeMin = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Get the percentage of your volume that is making/taking liquidity.
                MakerTakerPercentages result = apiInstance.GetMakerTaker(datetimeMax, datetimeMin);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TraderDashboardApi.GetMakerTaker: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datetimeMax** | **DateTime?**|  | [optional] 
 **datetimeMin** | **DateTime?**|  | [optional] 

### Return type

[**MakerTakerPercentages**](MakerTakerPercentages.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
