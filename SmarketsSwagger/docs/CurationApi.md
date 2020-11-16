# IO.Swagger.Api.CurationApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCuratedEventGroups**](CurationApi.md#getcuratedeventgroups) | **GET** /v3/curated_event_groups/ | 

<a name="getcuratedeventgroups"></a>
# **GetCuratedEventGroups**
> GetCuratedEventGroupsResponse GetCuratedEventGroups (List<string> state = null, List<string> groupByField = null, bool? inplayEnabled = null, int? limitPerGroup = null, List<string> excludedResourceScope = null, string jurisdiction = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCuratedEventGroupsExample
    {
        public void main()
        {
            var apiInstance = new CurationApi();
            var state = new List<string>(); // List<string> |  (optional) 
            var groupByField = new List<string>(); // List<string> |  (optional)  (default to ["scope","domain"])
            var inplayEnabled = true;  // bool? | True if trading will be open when the markets go live in-play (optional) 
            var limitPerGroup = 56;  // int? |  (optional)  (default to 3)
            var excludedResourceScope = new List<string>(); // List<string> |  (optional)  (default to ["outright","outright_category","outright_root"])
            var jurisdiction = jurisdiction_example;  // string |  (optional)  (default to null)

            try
            {
                GetCuratedEventGroupsResponse result = apiInstance.GetCuratedEventGroups(state, groupByField, inplayEnabled, limitPerGroup, excludedResourceScope, jurisdiction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurationApi.GetCuratedEventGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **state** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **groupByField** | [**List&lt;string&gt;**](string.md)|  | [optional] [default to [&quot;scope&quot;,&quot;domain&quot;]]
 **inplayEnabled** | **bool?**| True if trading will be open when the markets go live in-play | [optional] 
 **limitPerGroup** | **int?**|  | [optional] [default to 3]
 **excludedResourceScope** | [**List&lt;string&gt;**](string.md)|  | [optional] [default to [&quot;outright&quot;,&quot;outright_category&quot;,&quot;outright_root&quot;]]
 **jurisdiction** | **string**|  | [optional] [default to null]

### Return type

[**GetCuratedEventGroupsResponse**](GetCuratedEventGroupsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
