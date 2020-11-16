# IO.Swagger.Api.JurisdictionsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetJurisdictions**](JurisdictionsApi.md#getjurisdictions) | **GET** /v3/jurisdictions/ | Return the jurisdiction where the user is in.

<a name="getjurisdictions"></a>
# **GetJurisdictions**
> JurisdictionsResponse GetJurisdictions ()

Return the jurisdiction where the user is in.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetJurisdictionsExample
    {
        public void main()
        {
            var apiInstance = new JurisdictionsApi();

            try
            {
                // Return the jurisdiction where the user is in.
                JurisdictionsResponse result = apiInstance.GetJurisdictions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JurisdictionsApi.GetJurisdictions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**JurisdictionsResponse**](JurisdictionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
