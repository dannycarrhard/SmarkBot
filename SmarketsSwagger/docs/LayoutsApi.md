# IO.Swagger.Api.LayoutsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAppliedImageGroups**](LayoutsApi.md#getappliedimagegroups) | **GET** /v3/applied-image-groups/ | Get applied image groups.
[**GetAttributions**](LayoutsApi.md#getattributions) | **GET** /v3/attributions/ | 
[**GetLayout**](LayoutsApi.md#getlayout) | **GET** /v3/layouts/{layout_id}/ | 

<a name="getappliedimagegroups"></a>
# **GetAppliedImageGroups**
> InlineResponse20032 GetAppliedImageGroups (List<int?> resourceIds = null, List<string> resourceTypes = null, List<string> clientTypes = null)

Get applied image groups.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAppliedImageGroupsExample
    {
        public void main()
        {
            var apiInstance = new LayoutsApi();
            var resourceIds = new List<int?>(); // List<int?> |  (optional) 
            var resourceTypes = new List<string>(); // List<string> |  (optional) 
            var clientTypes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Get applied image groups.
                InlineResponse20032 result = apiInstance.GetAppliedImageGroups(resourceIds, resourceTypes, clientTypes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LayoutsApi.GetAppliedImageGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resourceIds** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **resourceTypes** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **clientTypes** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**InlineResponse20032**](InlineResponse20032.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getattributions"></a>
# **GetAttributions**
> InlineResponse20033 GetAttributions (List<int?> imageIds = null, List<string> clientTypes = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAttributionsExample
    {
        public void main()
        {
            var apiInstance = new LayoutsApi();
            var imageIds = new List<int?>(); // List<int?> |  (optional) 
            var clientTypes = new List<string>(); // List<string> |  (optional) 

            try
            {
                InlineResponse20033 result = apiInstance.GetAttributions(imageIds, clientTypes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LayoutsApi.GetAttributions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageIds** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **clientTypes** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**InlineResponse20033**](InlineResponse20033.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlayout"></a>
# **GetLayout**
> GetLayoutResponse GetLayout (int? layoutId, string jurisdiction = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLayoutExample
    {
        public void main()
        {
            var apiInstance = new LayoutsApi();
            var layoutId = 56;  // int? | 
            var jurisdiction = jurisdiction_example;  // string |  (optional)  (default to null)

            try
            {
                GetLayoutResponse result = apiInstance.GetLayout(layoutId, jurisdiction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LayoutsApi.GetLayout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutId** | **int?**|  | 
 **jurisdiction** | **string**|  | [optional] [default to null]

### Return type

[**GetLayoutResponse**](GetLayoutResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
