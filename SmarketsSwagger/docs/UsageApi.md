# IO.Swagger.Api.UsageApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUsage**](UsageApi.md#getusage) | **GET** /v3/usage/{year}/{month}/ | Get the users limits and usage.
[**SetUsageAlert**](UsageApi.md#setusagealert) | **PUT** /v3/usage/alert/ | Set the usage alert settings for this user.

<a name="getusage"></a>
# **GetUsage**
> InlineResponse20066 GetUsage (int? year, int? month)

Get the users limits and usage.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsageExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsageApi();
            var year = 56;  // int? | 
            var month = 56;  // int? | 

            try
            {
                // Get the users limits and usage.
                InlineResponse20066 result = apiInstance.GetUsage(year, month);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsageApi.GetUsage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**|  | 
 **month** | **int?**|  | 

### Return type

[**InlineResponse20066**](InlineResponse20066.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="setusagealert"></a>
# **SetUsageAlert**
> InlineResponse20065 SetUsageAlert ()

Set the usage alert settings for this user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetUsageAlertExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsageApi();

            try
            {
                // Set the usage alert settings for this user.
                InlineResponse20065 result = apiInstance.SetUsageAlert();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsageApi.SetUsageAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20065**](InlineResponse20065.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
