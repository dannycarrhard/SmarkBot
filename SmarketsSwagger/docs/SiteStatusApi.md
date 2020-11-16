# IO.Swagger.Api.SiteStatusApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSiteStatus**](SiteStatusApi.md#getsitestatus) | **GET** /v3/site_status/ | Return a site-wide status message.

<a name="getsitestatus"></a>
# **GetSiteStatus**
> SiteStatus GetSiteStatus ()

Return a site-wide status message.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSiteStatusExample
    {
        public void main()
        {
            var apiInstance = new SiteStatusApi();

            try
            {
                // Return a site-wide status message.
                SiteStatus result = apiInstance.GetSiteStatus();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SiteStatusApi.GetSiteStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SiteStatus**](SiteStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
