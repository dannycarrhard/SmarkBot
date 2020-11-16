# IO.Swagger.Api.OddsfeedApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OddsfeedGzip**](OddsfeedApi.md#oddsfeedgzip) | **GET** /oddsfeed.xml.gz | Retrieve the compressed xml odds feed for all events on Smarkets.
[**SbkOddsfeedGzip**](OddsfeedApi.md#sbkoddsfeedgzip) | **GET** /sbk/oddsfeed.xml.gz | Retrieve the compressed xml odds feed for all events on Smarkets.

<a name="oddsfeedgzip"></a>
# **OddsfeedGzip**
> void OddsfeedGzip (List<string> eventType = null)

Retrieve the compressed xml odds feed for all events on Smarkets.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OddsfeedGzipExample
    {
        public void main()
        {
            var apiInstance = new OddsfeedApi();
            var eventType = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Retrieve the compressed xml odds feed for all events on Smarkets.
                apiInstance.OddsfeedGzip(eventType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OddsfeedApi.OddsfeedGzip: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventType** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="sbkoddsfeedgzip"></a>
# **SbkOddsfeedGzip**
> void SbkOddsfeedGzip (List<string> eventType = null)

Retrieve the compressed xml odds feed for all events on Smarkets.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SbkOddsfeedGzipExample
    {
        public void main()
        {
            var apiInstance = new OddsfeedApi();
            var eventType = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Retrieve the compressed xml odds feed for all events on Smarkets.
                apiInstance.SbkOddsfeedGzip(eventType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OddsfeedApi.SbkOddsfeedGzip: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventType** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
