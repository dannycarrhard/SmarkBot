# IO.Swagger.Api.SearchApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEventSearchResults**](SearchApi.md#geteventsearchresults) | **GET** /v3/search/{query}/ | Get the event IDs associated with a search query.

<a name="geteventsearchresults"></a>
# **GetEventSearchResults**
> RecommendedEventsResponse GetEventSearchResults (string query, string jurisdiction = null)

Get the event IDs associated with a search query.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEventSearchResultsExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var query = query_example;  // string | 
            var jurisdiction = jurisdiction_example;  // string | Jurisdiction of user (optional) 

            try
            {
                // Get the event IDs associated with a search query.
                RecommendedEventsResponse result = apiInstance.GetEventSearchResults(query, jurisdiction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetEventSearchResults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**|  | 
 **jurisdiction** | **string**| Jurisdiction of user | [optional] 

### Return type

[**RecommendedEventsResponse**](RecommendedEventsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
