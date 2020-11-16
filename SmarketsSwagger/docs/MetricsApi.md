# IO.Swagger.Api.MetricsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LogMetrics**](MetricsApi.md#logmetrics) | **POST** /v3/metrics/ | Log custom metrics from clients.

<a name="logmetrics"></a>
# **LogMetrics**
> Object LogMetrics (Object body = null)

Log custom metrics from clients.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogMetricsExample
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var body = new Object(); // Object | JSON Request object (optional) 

            try
            {
                // Log custom metrics from clients.
                Object result = apiInstance.LogMetrics(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.LogMetrics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Object**](Object.md)| JSON Request object | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
