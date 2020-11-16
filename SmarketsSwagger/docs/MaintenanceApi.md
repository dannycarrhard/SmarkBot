# IO.Swagger.Api.MaintenanceApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSiteMaintenanceBanner**](MaintenanceApi.md#getsitemaintenancebanner) | **GET** /v0/maintenance/ | Return a JSON describing a site-wide maintenance message.

<a name="getsitemaintenancebanner"></a>
# **GetSiteMaintenanceBanner**
> InlineResponse2008 GetSiteMaintenanceBanner ()

Return a JSON describing a site-wide maintenance message.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSiteMaintenanceBannerExample
    {
        public void main()
        {
            var apiInstance = new MaintenanceApi();

            try
            {
                // Return a JSON describing a site-wide maintenance message.
                InlineResponse2008 result = apiInstance.GetSiteMaintenanceBanner();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaintenanceApi.GetSiteMaintenanceBanner: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
