# IO.Swagger.Api.SsoApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SsoSignInResponse**](SsoApi.md#ssosigninresponse) | **POST** /v3/discourse/sso/ | 

<a name="ssosigninresponse"></a>
# **SsoSignInResponse**
> InlineResponse20036 SsoSignInResponse (Body27 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SsoSignInResponseExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SsoApi();
            var body = new Body27(); // Body27 | JSON Request object (optional) 

            try
            {
                InlineResponse20036 result = apiInstance.SsoSignInResponse(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsoApi.SsoSignInResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body27**](Body27.md)| JSON Request object | [optional] 

### Return type

[**InlineResponse20036**](InlineResponse20036.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
