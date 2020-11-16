# IO.Swagger.Api.MappingsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMappings**](MappingsApi.md#getmappings) | **GET** /v3/mappings/ | Retrieve Smarkets event ids given provider data.

<a name="getmappings"></a>
# **GetMappings**
> Mappings GetMappings (List<string> providerIds = null, string providerName = null, string entityType = null)

Retrieve Smarkets event ids given provider data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMappingsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MappingsApi();
            var providerIds = new List<string>(); // List<string> | Provider IDs for which mappings to Smarkets IDs are requested (optional) 
            var providerName = providerName_example;  // string | The name of the provider for which mappings are requested (optional) 
            var entityType = entityType_example;  // string | The entity type of the event. Provider ID is unique for each entity type (optional)  (default to match)

            try
            {
                // Retrieve Smarkets event ids given provider data.
                Mappings result = apiInstance.GetMappings(providerIds, providerName, entityType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MappingsApi.GetMappings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **providerIds** | [**List&lt;string&gt;**](string.md)| Provider IDs for which mappings to Smarkets IDs are requested | [optional] 
 **providerName** | **string**| The name of the provider for which mappings are requested | [optional] 
 **entityType** | **string**| The entity type of the event. Provider ID is unique for each entity type | [optional] [default to match]

### Return type

[**Mappings**](Mappings.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
