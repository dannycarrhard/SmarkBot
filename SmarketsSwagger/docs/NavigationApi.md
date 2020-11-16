# IO.Swagger.Api.NavigationApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Root**](NavigationApi.md#root) | **GET** /v0/navigation/ | 

<a name="root"></a>
# **Root**
> InlineResponse20010 Root (string jurisdiction = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RootExample
    {
        public void main()
        {
            var apiInstance = new NavigationApi();
            var jurisdiction = jurisdiction_example;  // string | Jurisdiction of user (optional) 

            try
            {
                InlineResponse20010 result = apiInstance.Root(jurisdiction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NavigationApi.Root: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jurisdiction** | **string**| Jurisdiction of user | [optional] 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
