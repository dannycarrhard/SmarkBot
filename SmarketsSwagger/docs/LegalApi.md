# IO.Swagger.Api.LegalApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfirmTerms**](LegalApi.md#confirmterms) | **POST** /v3/{terms}/terms/last_seen/ | Set the time the user confirmed terms and conditions to the current time.
[**ConfirmTermsV0**](LegalApi.md#confirmtermsv0) | **POST** /v0/legal/terms/confirm/ | Set the time the user confirmed terms and conditions to the current time.
[**GetLastSeenTerms**](LegalApi.md#getlastseenterms) | **GET** /v3/{terms}/terms/last_seen/ | Return when the user last saw the terms and conditions.
[**GetTerms**](LegalApi.md#getterms) | **GET** /v3/{terms}/terms/ | Return the latest terms and conditions, and the date they were last updated.
[**GetTermsV0**](LegalApi.md#gettermsv0) | **GET** /v0/legal/terms/ | Return the latest terms and conditions, and the date they were last updated.

<a name="confirmterms"></a>
# **ConfirmTerms**
> InlineResponse20070 ConfirmTerms (string terms)

Set the time the user confirmed terms and conditions to the current time.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConfirmTermsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LegalApi();
            var terms = terms_example;  // string | 

            try
            {
                // Set the time the user confirmed terms and conditions to the current time.
                InlineResponse20070 result = apiInstance.ConfirmTerms(terms);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalApi.ConfirmTerms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **terms** | **string**|  | 

### Return type

[**InlineResponse20070**](InlineResponse20070.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="confirmtermsv0"></a>
# **ConfirmTermsV0**
> InlineResponse2007 ConfirmTermsV0 ()

Set the time the user confirmed terms and conditions to the current time.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConfirmTermsV0Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LegalApi();

            try
            {
                // Set the time the user confirmed terms and conditions to the current time.
                InlineResponse2007 result = apiInstance.ConfirmTermsV0();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalApi.ConfirmTermsV0: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlastseenterms"></a>
# **GetLastSeenTerms**
> InlineResponse20070 GetLastSeenTerms (string terms)

Return when the user last saw the terms and conditions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLastSeenTermsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LegalApi();
            var terms = terms_example;  // string | 

            try
            {
                // Return when the user last saw the terms and conditions.
                InlineResponse20070 result = apiInstance.GetLastSeenTerms(terms);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalApi.GetLastSeenTerms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **terms** | **string**|  | 

### Return type

[**InlineResponse20070**](InlineResponse20070.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getterms"></a>
# **GetTerms**
> InlineResponse20069 GetTerms (string terms)

Return the latest terms and conditions, and the date they were last updated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTermsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LegalApi();
            var terms = terms_example;  // string | 

            try
            {
                // Return the latest terms and conditions, and the date they were last updated.
                InlineResponse20069 result = apiInstance.GetTerms(terms);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalApi.GetTerms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **terms** | **string**|  | 

### Return type

[**InlineResponse20069**](InlineResponse20069.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettermsv0"></a>
# **GetTermsV0**
> InlineResponse2006 GetTermsV0 ()

Return the latest terms and conditions, and the date they were last updated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTermsV0Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LegalApi();

            try
            {
                // Return the latest terms and conditions, and the date they were last updated.
                InlineResponse2006 result = apiInstance.GetTermsV0();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalApi.GetTermsV0: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
