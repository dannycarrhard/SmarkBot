# IO.Swagger.Api.CompetitorsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCompetitors**](CompetitorsApi.md#getcompetitors) | **GET** /v3/events/{event_ids}/competitors/ | Retrieve competitors of a set of events.

<a name="getcompetitors"></a>
# **GetCompetitors**
> Competitors GetCompetitors (List<int?> eventIds)

Retrieve competitors of a set of events.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCompetitorsExample
    {
        public void main()
        {
            var apiInstance = new CompetitorsApi();
            var eventIds = new List<int?>(); // List<int?> | maxItems:300

            try
            {
                // Retrieve competitors of a set of events.
                Competitors result = apiInstance.GetCompetitors(eventIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompetitorsApi.GetCompetitors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventIds** | [**List&lt;int?&gt;**](int?.md)| maxItems:300 | 

### Return type

[**Competitors**](Competitors.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
