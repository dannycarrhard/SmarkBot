# IO.Swagger.Api.ContractsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetContractsByIds**](ContractsApi.md#getcontractsbyids) | **GET** /v3/contracts/{contract_ids}/ | Retrieve contracts by a set of contract ids.
[**GetContractsByMarketIds**](ContractsApi.md#getcontractsbymarketids) | **GET** /v3/markets/{market_ids}/contracts/ | Retrieve contracts by a set of market ids.
[**GetHorses**](ContractsApi.md#gethorses) | **GET** /v3/markets/{market_ids}/horses/ | Retrieve horses information from a list of markets.

<a name="getcontractsbyids"></a>
# **GetContractsByIds**
> ContractsResponse GetContractsByIds (List<int?> contractIds)

Retrieve contracts by a set of contract ids.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetContractsByIdsExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractIds = new List<int?>(); // List<int?> | maxItems:300

            try
            {
                // Retrieve contracts by a set of contract ids.
                ContractsResponse result = apiInstance.GetContractsByIds(contractIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.GetContractsByIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractIds** | [**List&lt;int?&gt;**](int?.md)| maxItems:300 | 

### Return type

[**ContractsResponse**](ContractsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcontractsbymarketids"></a>
# **GetContractsByMarketIds**
> ContractsResponse GetContractsByMarketIds (List<int?> marketIds, bool? includeHidden = null)

Retrieve contracts by a set of market ids.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetContractsByMarketIdsExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var marketIds = new List<int?>(); // List<int?> | Market IDs to filter by<br>maxItems:100
            var includeHidden = true;  // bool? | Choose to include in the response contracts that are not visible on the website. Hidden contracts may not be displayed for a varied number of reasons, and are not available to bet on. (optional)  (default to false)

            try
            {
                // Retrieve contracts by a set of market ids.
                ContractsResponse result = apiInstance.GetContractsByMarketIds(marketIds, includeHidden);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.GetContractsByMarketIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketIds** | [**List&lt;int?&gt;**](int?.md)| Market IDs to filter by&lt;br&gt;maxItems:100 | 
 **includeHidden** | **bool?**| Choose to include in the response contracts that are not visible on the website. Hidden contracts may not be displayed for a varied number of reasons, and are not available to bet on. | [optional] [default to false]

### Return type

[**ContractsResponse**](ContractsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gethorses"></a>
# **GetHorses**
> HorsesResponse GetHorses (List<int?> marketIds, bool? includeHidden = null)

Retrieve horses information from a list of markets.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHorsesExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var marketIds = new List<int?>(); // List<int?> | maxItems:300
            var includeHidden = true;  // bool? | Choose to include in the response contracts that are not visible on the website. Hidden contracts may not be displayed for a varied number of reasons, and are not available to bet on. (optional)  (default to false)

            try
            {
                // Retrieve horses information from a list of markets.
                HorsesResponse result = apiInstance.GetHorses(marketIds, includeHidden);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.GetHorses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketIds** | [**List&lt;int?&gt;**](int?.md)| maxItems:300 | 
 **includeHidden** | **bool?**| Choose to include in the response contracts that are not visible on the website. Hidden contracts may not be displayed for a varied number of reasons, and are not available to bet on. | [optional] [default to false]

### Return type

[**HorsesResponse**](HorsesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
