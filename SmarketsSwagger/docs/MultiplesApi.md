# IO.Swagger.Api.MultiplesApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEachWayOrderStatus**](MultiplesApi.md#geteachwayorderstatus) | **GET** /v3/each_way/{win_contract_id}/{place_contract_id}/{u_id}/status/ | Get the status of the each way order with the given contract ids and u_id.
[**GetEachWaySinglePrice**](MultiplesApi.md#geteachwaysingleprice) | **GET** /v3/each_way/{win_contract_id}/{place_contract_id}/prices/ | Get the prices for the two contracts of an each way at a given stake.
[**GetMultiTickSingleCashoutPrice**](MultiplesApi.md#getmultiticksinglecashoutprice) | **GET** /v3/multi_tick_orders/cashout/{contract_id}/prices/ | Get the price used for a cashout on a single.
[**GetMultiTickSinglePrice**](MultiplesApi.md#getmultiticksingleprice) | **GET** /v3/multi_tick_orders/{contract_id}/prices/ | Get the price averaged across ticks for a contract at a given stake.
[**GetMultipleOrderStatus**](MultiplesApi.md#getmultipleorderstatus) | **GET** /v3/multiples/{contract_ids}/{u_id}/status/ | 
[**GetMultiplesCashoutPrice**](MultiplesApi.md#getmultiplescashoutprice) | **GET** /v3/multiples/cashout/{contract_ids}/prices/ | Get the price used for a cashout on a multiple.
[**GetMultiplesPricing**](MultiplesApi.md#getmultiplespricing) | **GET** /v3/multiples/{contract_ids}/prices/ | Create an entry for and get the price of a multiple based on the given contract ids.
[**GetRandomMultiple**](MultiplesApi.md#getrandommultiple) | **GET** /v3/multiples/random/{num_legs}/ | Get a randomly generated multiple with the specified number of legs.
[**GetSingleOrderStatus**](MultiplesApi.md#getsingleorderstatus) | **GET** /v3/multi_tick/{contract_ids}/{u_ids}/status/ | Get the status for a given single order contract.
[**PlaceEachWaySingle**](MultiplesApi.md#placeeachwaysingle) | **POST** /v3/each_way/ | Place an atomic each way bet at the given prices and stake.
[**PlaceMultiTickSingle**](MultiplesApi.md#placemultiticksingle) | **POST** /v3/multi_tick_orders/ | Place a bet averaged across multiple ticks at the given price and stake.
[**PlaceMultiTickSingleCashout**](MultiplesApi.md#placemultiticksinglecashout) | **POST** /v3/multi_tick_orders/cashout/ | Place a cashout bet at the given price and quantity.
[**PlaceMultipleCashoutOrder**](MultiplesApi.md#placemultiplecashoutorder) | **POST** /v3/multiples_orders/cashout/ | Place a multiple cashout for the given contract ids at the given price and quantity.
[**PlaceMultipleOrder**](MultiplesApi.md#placemultipleorder) | **POST** /v3/multiples_orders/ | Place a multiple order for the given contract ids at the given price and stake.

<a name="geteachwayorderstatus"></a>
# **GetEachWayOrderStatus**
> EachWayStatusSchema GetEachWayOrderStatus (int? winContractId, int? placeContractId, string uId)

Get the status of the each way order with the given contract ids and u_id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEachWayOrderStatusExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MultiplesApi();
            var winContractId = 56;  // int? | 
            var placeContractId = 56;  // int? | 
            var uId = uId_example;  // string | 

            try
            {
                // Get the status of the each way order with the given contract ids and u_id.
                EachWayStatusSchema result = apiInstance.GetEachWayOrderStatus(winContractId, placeContractId, uId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiplesApi.GetEachWayOrderStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **winContractId** | **int?**|  | 
 **placeContractId** | **int?**|  | 
 **uId** | **string**|  | 

### Return type

[**EachWayStatusSchema**](EachWayStatusSchema.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="geteachwaysingleprice"></a>
# **GetEachWaySinglePrice**
> EachWaySinglePrice GetEachWaySinglePrice (int? winContractId, int? placeContractId, decimal? stake = null)

Get the prices for the two contracts of an each way at a given stake.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEachWaySinglePriceExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MultiplesApi();
            var winContractId = 56;  // int? | 
            var placeContractId = 56;  // int? | 
            var stake = 1.2;  // decimal? |  (optional) 

            try
            {
                // Get the prices for the two contracts of an each way at a given stake.
                EachWaySinglePrice result = apiInstance.GetEachWaySinglePrice(winContractId, placeContractId, stake);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiplesApi.GetEachWaySinglePrice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **winContractId** | **int?**|  | 
 **placeContractId** | **int?**|  | 
 **stake** | **decimal?**|  | [optional] 

### Return type

[**EachWaySinglePrice**](EachWaySinglePrice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmultiticksinglecashoutprice"></a>
# **GetMultiTickSingleCashoutPrice**
> MultiTickPrice GetMultiTickSingleCashoutPrice (int? contractId)

Get the price used for a cashout on a single.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMultiTickSingleCashoutPriceExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MultiplesApi();
            var contractId = 56;  // int? | 

            try
            {
                // Get the price used for a cashout on a single.
                MultiTickPrice result = apiInstance.GetMultiTickSingleCashoutPrice(contractId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiplesApi.GetMultiTickSingleCashoutPrice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractId** | **int?**|  | 

### Return type

[**MultiTickPrice**](MultiTickPrice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmultiticksingleprice"></a>
# **GetMultiTickSinglePrice**
> MultiTickPrice1 GetMultiTickSinglePrice (int? contractId, decimal? stake = null)

Get the price averaged across ticks for a contract at a given stake.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMultiTickSinglePriceExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MultiplesApi();
            var contractId = 56;  // int? | 
            var stake = 1.2;  // decimal? |  (optional) 

            try
            {
                // Get the price averaged across ticks for a contract at a given stake.
                MultiTickPrice1 result = apiInstance.GetMultiTickSinglePrice(contractId, stake);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiplesApi.GetMultiTickSinglePrice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractId** | **int?**|  | 
 **stake** | **decimal?**|  | [optional] 

### Return type

[**MultiTickPrice1**](MultiTickPrice1.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmultipleorderstatus"></a>
# **GetMultipleOrderStatus**
> MultiplesStatusSchema GetMultipleOrderStatus (List<int?> contractIds, string uId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMultipleOrderStatusExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MultiplesApi();
            var contractIds = new List<int?>(); // List<int?> | maxItems:10<br>minItems:10
            var uId = uId_example;  // string | 

            try
            {
                MultiplesStatusSchema result = apiInstance.GetMultipleOrderStatus(contractIds, uId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiplesApi.GetMultipleOrderStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractIds** | [**List&lt;int?&gt;**](int?.md)| maxItems:10&lt;br&gt;minItems:10 | 
 **uId** | **string**|  | 

### Return type

[**MultiplesStatusSchema**](MultiplesStatusSchema.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmultiplescashoutprice"></a>
# **GetMultiplesCashoutPrice**
> Pricing GetMultiplesCashoutPrice (List<int?> contractIds, string side = null)

Get the price used for a cashout on a multiple.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMultiplesCashoutPriceExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MultiplesApi();
            var contractIds = new List<int?>(); // List<int?> | maxItems:10<br>minItems:10
            var side = side_example;  // string |  side can either be:<ul> <li>buy: backing a contract <li>sell: laying a contract </ul> (optional) 

            try
            {
                // Get the price used for a cashout on a multiple.
                Pricing result = apiInstance.GetMultiplesCashoutPrice(contractIds, side);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiplesApi.GetMultiplesCashoutPrice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractIds** | [**List&lt;int?&gt;**](int?.md)| maxItems:10&lt;br&gt;minItems:10 | 
 **side** | **string**|  side can either be:&lt;ul&gt; &lt;li&gt;buy: backing a contract &lt;li&gt;sell: laying a contract &lt;/ul&gt; | [optional] 

### Return type

[**Pricing**](Pricing.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmultiplespricing"></a>
# **GetMultiplesPricing**
> Pricing GetMultiplesPricing (List<int?> contractIds, string side = null)

Create an entry for and get the price of a multiple based on the given contract ids.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMultiplesPricingExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MultiplesApi();
            var contractIds = new List<int?>(); // List<int?> | maxItems:10<br>minItems:10
            var side = side_example;  // string |  side can either be:<ul> <li>buy: backing a contract <li>sell: laying a contract </ul> (optional) 

            try
            {
                // Create an entry for and get the price of a multiple based on the given contract ids.
                Pricing result = apiInstance.GetMultiplesPricing(contractIds, side);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiplesApi.GetMultiplesPricing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractIds** | [**List&lt;int?&gt;**](int?.md)| maxItems:10&lt;br&gt;minItems:10 | 
 **side** | **string**|  side can either be:&lt;ul&gt; &lt;li&gt;buy: backing a contract &lt;li&gt;sell: laying a contract &lt;/ul&gt; | [optional] 

### Return type

[**Pricing**](Pricing.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrandommultiple"></a>
# **GetRandomMultiple**
> Random GetRandomMultiple (int? numLegs, List<string> contractId = null)

Get a randomly generated multiple with the specified number of legs.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRandomMultipleExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MultiplesApi();
            var numLegs = 56;  // int? | 
            var contractId = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Get a randomly generated multiple with the specified number of legs.
                Random result = apiInstance.GetRandomMultiple(numLegs, contractId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiplesApi.GetRandomMultiple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numLegs** | **int?**|  | 
 **contractId** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**Random**](Random.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsingleorderstatus"></a>
# **GetSingleOrderStatus**
> MultiTickStatusSchema GetSingleOrderStatus (List<int?> contractIds, string uIds)

Get the status for a given single order contract.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSingleOrderStatusExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MultiplesApi();
            var contractIds = new List<int?>(); // List<int?> | 
            var uIds = uIds_example;  // string | 

            try
            {
                // Get the status for a given single order contract.
                MultiTickStatusSchema result = apiInstance.GetSingleOrderStatus(contractIds, uIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiplesApi.GetSingleOrderStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractIds** | [**List&lt;int?&gt;**](int?.md)|  | 
 **uIds** | **string**|  | 

### Return type

[**MultiTickStatusSchema**](MultiTickStatusSchema.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="placeeachwaysingle"></a>
# **PlaceEachWaySingle**
> EachWayPlace PlaceEachWaySingle (EachWayRequestSchema body = null)

Place an atomic each way bet at the given prices and stake.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlaceEachWaySingleExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MultiplesApi();
            var body = new EachWayRequestSchema(); // EachWayRequestSchema | JSON Request object (optional) 

            try
            {
                // Place an atomic each way bet at the given prices and stake.
                EachWayPlace result = apiInstance.PlaceEachWaySingle(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiplesApi.PlaceEachWaySingle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EachWayRequestSchema**](EachWayRequestSchema.md)| JSON Request object | [optional] 

### Return type

[**EachWayPlace**](EachWayPlace.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="placemultiticksingle"></a>
# **PlaceMultiTickSingle**
> MultiTickPlace PlaceMultiTickSingle (MultiTickRequestSchema body = null)

Place a bet averaged across multiple ticks at the given price and stake.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlaceMultiTickSingleExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MultiplesApi();
            var body = new MultiTickRequestSchema(); // MultiTickRequestSchema | JSON Request object (optional) 

            try
            {
                // Place a bet averaged across multiple ticks at the given price and stake.
                MultiTickPlace result = apiInstance.PlaceMultiTickSingle(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiplesApi.PlaceMultiTickSingle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiTickRequestSchema**](MultiTickRequestSchema.md)| JSON Request object | [optional] 

### Return type

[**MultiTickPlace**](MultiTickPlace.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="placemultiticksinglecashout"></a>
# **PlaceMultiTickSingleCashout**
> MultiTickPlace PlaceMultiTickSingleCashout (MultiTickRequestSchema1 body = null)

Place a cashout bet at the given price and quantity.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlaceMultiTickSingleCashoutExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MultiplesApi();
            var body = new MultiTickRequestSchema1(); // MultiTickRequestSchema1 | JSON Request object (optional) 

            try
            {
                // Place a cashout bet at the given price and quantity.
                MultiTickPlace result = apiInstance.PlaceMultiTickSingleCashout(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiplesApi.PlaceMultiTickSingleCashout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiTickRequestSchema1**](MultiTickRequestSchema1.md)| JSON Request object | [optional] 

### Return type

[**MultiTickPlace**](MultiTickPlace.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="placemultiplecashoutorder"></a>
# **PlaceMultipleCashoutOrder**
> MultiplesResponseSchema PlaceMultipleCashoutOrder (MultiplesCashoutRequestSchema body = null)

Place a multiple cashout for the given contract ids at the given price and quantity.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlaceMultipleCashoutOrderExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MultiplesApi();
            var body = new MultiplesCashoutRequestSchema(); // MultiplesCashoutRequestSchema | JSON Request object (optional) 

            try
            {
                // Place a multiple cashout for the given contract ids at the given price and quantity.
                MultiplesResponseSchema result = apiInstance.PlaceMultipleCashoutOrder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiplesApi.PlaceMultipleCashoutOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiplesCashoutRequestSchema**](MultiplesCashoutRequestSchema.md)| JSON Request object | [optional] 

### Return type

[**MultiplesResponseSchema**](MultiplesResponseSchema.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="placemultipleorder"></a>
# **PlaceMultipleOrder**
> MultiplesResponseSchema PlaceMultipleOrder (MultiplesRequestSchema body = null)

Place a multiple order for the given contract ids at the given price and stake.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlaceMultipleOrderExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MultiplesApi();
            var body = new MultiplesRequestSchema(); // MultiplesRequestSchema | JSON Request object (optional) 

            try
            {
                // Place a multiple order for the given contract ids at the given price and stake.
                MultiplesResponseSchema result = apiInstance.PlaceMultipleOrder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiplesApi.PlaceMultipleOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiplesRequestSchema**](MultiplesRequestSchema.md)| JSON Request object | [optional] 

### Return type

[**MultiplesResponseSchema**](MultiplesResponseSchema.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
