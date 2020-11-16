# IO.Swagger.Api.Oauth2Api

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeSecret**](Oauth2Api.md#changesecret) | **POST** /v3/oauth2/clients/{client_id}/secret/ | 
[**GetClient**](Oauth2Api.md#getclient) | **GET** /v3/oauth2/clients/{client_id}/ | 
[**IssueToken**](Oauth2Api.md#issuetoken) | **POST** /v3/oauth2/token/ | Issue a new token for oauth2 requests.
[**ProcessAffiliateConsent**](Oauth2Api.md#processaffiliateconsent) | **POST** /v3/oauth2/consent/ | 

<a name="changesecret"></a>
# **ChangeSecret**
> InlineResponse20048 ChangeSecret (int? clientId, Body38 body = null)



 ##  Rate limits Maximum 10 requests per 600 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangeSecretExample
    {
        public void main()
        {
            var apiInstance = new Oauth2Api();
            var clientId = 56;  // int? | 
            var body = new Body38(); // Body38 | JSON Request object (optional) 

            try
            {
                InlineResponse20048 result = apiInstance.ChangeSecret(clientId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Oauth2Api.ChangeSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **int?**|  | 
 **body** | [**Body38**](Body38.md)| JSON Request object | [optional] 

### Return type

[**InlineResponse20048**](InlineResponse20048.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getclient"></a>
# **GetClient**
> InlineResponse20047 GetClient (int? clientId, string redirectUri = null, List<string> scopes = null, string state = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new Oauth2Api();
            var clientId = 56;  // int? | 
            var redirectUri = redirectUri_example;  // string | Client redirect address (optional) 
            var scopes = new List<string>(); // List<string> |  (optional) 
            var state = state_example;  // string | An opaque value used by the client to maintain          state between the request and callback.  The authorization          server includes this value when redirecting the user-agent back          to the client.  The parameter SHOULD be used for preventing          cross-site request forgery (optional) 

            try
            {
                InlineResponse20047 result = apiInstance.GetClient(clientId, redirectUri, scopes, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Oauth2Api.GetClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **int?**|  | 
 **redirectUri** | **string**| Client redirect address | [optional] 
 **scopes** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **state** | **string**| An opaque value used by the client to maintain          state between the request and callback.  The authorization          server includes this value when redirecting the user-agent back          to the client.  The parameter SHOULD be used for preventing          cross-site request forgery | [optional] 

### Return type

[**InlineResponse20047**](InlineResponse20047.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="issuetoken"></a>
# **IssueToken**
> InlineResponse20050 IssueToken (Body40 body = null)

Issue a new token for oauth2 requests.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IssueTokenExample
    {
        public void main()
        {
            var apiInstance = new Oauth2Api();
            var body = new Body40(); // Body40 | JSON Request object (optional) 

            try
            {
                // Issue a new token for oauth2 requests.
                InlineResponse20050 result = apiInstance.IssueToken(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Oauth2Api.IssueToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body40**](Body40.md)| JSON Request object | [optional] 

### Return type

[**InlineResponse20050**](InlineResponse20050.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="processaffiliateconsent"></a>
# **ProcessAffiliateConsent**
> InlineResponse20049 ProcessAffiliateConsent (Body39 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProcessAffiliateConsentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new Oauth2Api();
            var body = new Body39(); // Body39 | JSON Request object (optional) 

            try
            {
                InlineResponse20049 result = apiInstance.ProcessAffiliateConsent(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Oauth2Api.ProcessAffiliateConsent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body39**](Body39.md)| JSON Request object | [optional] 

### Return type

[**InlineResponse20049**](InlineResponse20049.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
