# IO.Swagger.Api.OccupationsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOccupationCategories**](OccupationsApi.md#getoccupationcategories) | **GET** /v3/occupations/ | Get supported job title categories.

<a name="getoccupationcategories"></a>
# **GetOccupationCategories**
> InlineResponse20051 GetOccupationCategories ()

Get supported job title categories.

## Description Each element includes the following data: - code: identifier of the job title; - category: classification of the job based on industry and level; - description: user friendly job title name.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOccupationCategoriesExample
    {
        public void main()
        {
            var apiInstance = new OccupationsApi();

            try
            {
                // Get supported job title categories.
                InlineResponse20051 result = apiInstance.GetOccupationCategories();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OccupationsApi.GetOccupationCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20051**](InlineResponse20051.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
