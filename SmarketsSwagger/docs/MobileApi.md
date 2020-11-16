# IO.Swagger.Api.MobileApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MobileUpdates**](MobileApi.md#mobileupdates) | **GET** /v3/mobile/minimum_allowed_version/ | Return the minimum allowed version for the mobile app and a description.

<a name="mobileupdates"></a>
# **MobileUpdates**
> MinimumAllowedVersionResponse MobileUpdates ()

Return the minimum allowed version for the mobile app and a description.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MobileUpdatesExample
    {
        public void main()
        {
            var apiInstance = new MobileApi();

            try
            {
                // Return the minimum allowed version for the mobile app and a description.
                MinimumAllowedVersionResponse result = apiInstance.MobileUpdates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileApi.MobileUpdates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MinimumAllowedVersionResponse**](MinimumAllowedVersionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
