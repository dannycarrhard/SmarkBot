# IO.Swagger.Api.PopularApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHomeEvents**](PopularApi.md#gethomeevents) | **GET** /v3/popular/home/ | Get the popular events that populate the Smarkets home page.
[**GetPopularEvents**](PopularApi.md#getpopularevents) | **GET** /v3/popular/event_ids/ | Get the list of popular event ids.
[**GetPopularEventsByCategory**](PopularApi.md#getpopulareventsbycategory) | **GET** /v3/popular/event_ids/{display_category}/ | Get a list of popular events ids by category.

<a name="gethomeevents"></a>
# **GetHomeEvents**
> HomeEventsResponse GetHomeEvents (string jurisdiction = null)

Get the popular events that populate the Smarkets home page.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHomeEventsExample
    {
        public void main()
        {
            var apiInstance = new PopularApi();
            var jurisdiction = jurisdiction_example;  // string |  (optional)  (default to null)

            try
            {
                // Get the popular events that populate the Smarkets home page.
                HomeEventsResponse result = apiInstance.GetHomeEvents(jurisdiction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PopularApi.GetHomeEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jurisdiction** | **string**|  | [optional] [default to null]

### Return type

[**HomeEventsResponse**](HomeEventsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpopularevents"></a>
# **GetPopularEvents**
> PopularEventsResponse GetPopularEvents (int? limit = null, List<string> state = null, bool? inplayEnabled = null, List<string> excludedResourceScope = null, string jurisdiction = null)

Get the list of popular event ids.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPopularEventsExample
    {
        public void main()
        {
            var apiInstance = new PopularApi();
            var limit = 56;  // int? |  (optional)  (default to 10)
            var state = new List<string>(); // List<string> |  (optional)  (default to ["upcoming","live"])
            var inplayEnabled = true;  // bool? |  (optional) 
            var excludedResourceScope = new List<string>(); // List<string> |  (optional)  (default to ["outright","outright_category","outright_root"])
            var jurisdiction = jurisdiction_example;  // string |  (optional)  (default to null)

            try
            {
                // Get the list of popular event ids.
                PopularEventsResponse result = apiInstance.GetPopularEvents(limit, state, inplayEnabled, excludedResourceScope, jurisdiction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PopularApi.GetPopularEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**|  | [optional] [default to 10]
 **state** | [**List&lt;string&gt;**](string.md)|  | [optional] [default to [&quot;upcoming&quot;,&quot;live&quot;]]
 **inplayEnabled** | **bool?**|  | [optional] 
 **excludedResourceScope** | [**List&lt;string&gt;**](string.md)|  | [optional] [default to [&quot;outright&quot;,&quot;outright_category&quot;,&quot;outright_root&quot;]]
 **jurisdiction** | **string**|  | [optional] [default to null]

### Return type

[**PopularEventsResponse**](PopularEventsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpopulareventsbycategory"></a>
# **GetPopularEventsByCategory**
> PopularEventsResponse GetPopularEventsByCategory (string displayCategory, int? limit = null, bool? inplayEnabled = null, bool? isLeaf = null, List<string> excludedResourceScope = null, string jurisdiction = null)

Get a list of popular events ids by category.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPopularEventsByCategoryExample
    {
        public void main()
        {
            var apiInstance = new PopularApi();
            var displayCategory = displayCategory_example;  // string | 
            var limit = 56;  // int? |  (optional)  (default to 5)
            var inplayEnabled = true;  // bool? | True if trading will be open when the markets go live in-play (optional) 
            var isLeaf = true;  // bool? |  (optional)  (default to true)
            var excludedResourceScope = new List<string>(); // List<string> |  (optional)  (default to ["outright","outright_category","outright_root"])
            var jurisdiction = jurisdiction_example;  // string |  (optional)  (default to null)

            try
            {
                // Get a list of popular events ids by category.
                PopularEventsResponse result = apiInstance.GetPopularEventsByCategory(displayCategory, limit, inplayEnabled, isLeaf, excludedResourceScope, jurisdiction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PopularApi.GetPopularEventsByCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **displayCategory** | **string**|  | 
 **limit** | **int?**|  | [optional] [default to 5]
 **inplayEnabled** | **bool?**| True if trading will be open when the markets go live in-play | [optional] 
 **isLeaf** | **bool?**|  | [optional] [default to true]
 **excludedResourceScope** | [**List&lt;string&gt;**](string.md)|  | [optional] [default to [&quot;outright&quot;,&quot;outright_category&quot;,&quot;outright_root&quot;]]
 **jurisdiction** | **string**|  | [optional] [default to null]

### Return type

[**PopularEventsResponse**](PopularEventsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
