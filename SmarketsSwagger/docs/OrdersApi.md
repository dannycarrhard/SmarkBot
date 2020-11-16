# IO.Swagger.Api.OrdersApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelOrder**](OrdersApi.md#cancelorder) | **DELETE** /v3/orders/{order_id}/ | Cancel specific order.
[**CancelOrders**](OrdersApi.md#cancelorders) | **DELETE** /v3/orders/ | Cancel all orders.
[**CreateAffiliateOrder**](OrdersApi.md#createaffiliateorder) | **POST** /v3/affiliate/orders/ |      Route for affiliates to place orders via HTTP.
[**CreateOrder**](OrdersApi.md#createorder) | **POST** /v3/orders/ | Place orders on the exchange.
[**GetOrderById**](OrdersApi.md#getorderbyid) | **GET** /v3/orders/{order_id}/ | Get one order by its order id.
[**GetOrders**](OrdersApi.md#getorders) | **GET** /v3/orders/ | Retrieve current orders on Smarkets, these include open and recently settled orders.
[**GetOrdersV0**](OrdersApi.md#getordersv0) | **GET** /v0/orders/ | 

<a name="cancelorder"></a>
# **CancelOrder**
> Object CancelOrder (int? orderId)

Cancel specific order.

 ##  Rate limits Maximum 10 requests per second<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelOrderExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrdersApi();
            var orderId = 56;  // int? | Order ID to cancel

            try
            {
                // Cancel specific order.
                Object result = apiInstance.CancelOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.CancelOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **int?**| Order ID to cancel | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cancelorders"></a>
# **CancelOrders**
> Object CancelOrders (string marketId = null)

Cancel all orders.

 ##  Rate limits Maximum 1 request per 60 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelOrdersExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrdersApi();
            var marketId = marketId_example;  // string | This ID uniquely identifies the market (optional) 

            try
            {
                // Cancel all orders.
                Object result = apiInstance.CancelOrders(marketId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.CancelOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketId** | **string**| This ID uniquely identifies the market | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createaffiliateorder"></a>
# **CreateAffiliateOrder**
> InlineResponse20031 CreateAffiliateOrder (Body17 body = null)

     Route for affiliates to place orders via HTTP.

## Description All orders are placed with a time in force of 'fill-or-kill'.  ##  Rate limits Maximum 1 request per second<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAffiliateOrderExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrdersApi();
            var body = new Body17(); // Body17 | JSON Request object (optional) 

            try
            {
                //      Route for affiliates to place orders via HTTP.
                InlineResponse20031 result = apiInstance.CreateAffiliateOrder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.CreateAffiliateOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body17**](Body17.md)| JSON Request object | [optional] 

### Return type

[**InlineResponse20031**](InlineResponse20031.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createorder"></a>
# **CreateOrder**
> InlineResponse20053 CreateOrder (Body43 body = null)

Place orders on the exchange.

## Description This route only works for Smarkets API users, other users will receive a 403 status code response.<br><br> For immediate_or_cancel orders type, the route will return when the order is matched (or cancelled).<br> For all other order types, the route will return when the order is accepted by the exchange.<br> In the latter case, GET v3/orders should be used to check the status of the order, using the order id returned by this response.  ##  Rate limits Rate limits are applied on an per account basis

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateOrderExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrdersApi();
            var body = new Body43(); // Body43 | JSON Request object (optional) 

            try
            {
                // Place orders on the exchange.
                InlineResponse20053 result = apiInstance.CreateOrder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.CreateOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body43**](Body43.md)| JSON Request object | [optional] 

### Return type

[**InlineResponse20053**](InlineResponse20053.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getorderbyid"></a>
# **GetOrderById**
> OrderResponse GetOrderById (string orderId)

Get one order by its order id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrdersApi();
            var orderId = orderId_example;  // string | 

            try
            {
                // Get one order by its order id.
                OrderResponse result = apiInstance.GetOrderById(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrderById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**|  | 

### Return type

[**OrderResponse**](OrderResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getorders"></a>
# **GetOrders**
> OrdersResponse GetOrders (string contractId = null, DateTime? createdDatetimeMax = null, DateTime? createdDatetimeMin = null, List<string> id = null, int? limit = null, List<string> marketId = null, string paginationLastId = null, int? sequenceNumberMax = null, int? sequenceNumberMin = null, List<string> state = null, string side = null, string sort = null)

Retrieve current orders on Smarkets, these include open and recently settled orders.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrdersExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrdersApi();
            var contractId = contractId_example;  // string | This ID uniquely identifies the contract (optional) 
            var createdDatetimeMax = 2013-10-20T19:20:30+01:00;  // DateTime? | When was the order created (optional) 
            var createdDatetimeMin = 2013-10-20T19:20:30+01:00;  // DateTime? | When was the order created (optional) 
            var id = new List<string>(); // List<string> | Order IDs to filter by (optional) 
            var limit = 56;  // int? | Maximum number of orders to be retrieved in one API call (optional)  (default to 20)
            var marketId = new List<string>(); // List<string> | Market IDs to filter by (optional) 
            var paginationLastId = paginationLastId_example;  // string |  The last order id from the previous page, so we can fetch the subsequent orders.<br> It should be used in conjuntion with the sort parameter (optional) 
            var sequenceNumberMax = 56;  // int? | This refers to the sequence number in the account activity - statement endpoint (optional) 
            var sequenceNumberMin = 56;  // int? | This refers to the sequence number in the account activity - statement endpoint (optional) 
            var state = new List<string>(); // List<string> | Order states to filter by. By default all order states are returned (optional) 
            var side = side_example;  // string |  side can either be:<ul> <li>buy: backing a contract <li>sell: laying a contract </ul> (optional) 
            var sort = sort_example;  // string | How to sort the results, it should be used in conjuntion with the pagination parameter (optional)  (default to id)

            try
            {
                // Retrieve current orders on Smarkets, these include open and recently settled orders.
                OrdersResponse result = apiInstance.GetOrders(contractId, createdDatetimeMax, createdDatetimeMin, id, limit, marketId, paginationLastId, sequenceNumberMax, sequenceNumberMin, state, side, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractId** | **string**| This ID uniquely identifies the contract | [optional] 
 **createdDatetimeMax** | **DateTime?**| When was the order created | [optional] 
 **createdDatetimeMin** | **DateTime?**| When was the order created | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| Order IDs to filter by | [optional] 
 **limit** | **int?**| Maximum number of orders to be retrieved in one API call | [optional] [default to 20]
 **marketId** | [**List&lt;string&gt;**](string.md)| Market IDs to filter by | [optional] 
 **paginationLastId** | **string**|  The last order id from the previous page, so we can fetch the subsequent orders.&lt;br&gt; It should be used in conjuntion with the sort parameter | [optional] 
 **sequenceNumberMax** | **int?**| This refers to the sequence number in the account activity - statement endpoint | [optional] 
 **sequenceNumberMin** | **int?**| This refers to the sequence number in the account activity - statement endpoint | [optional] 
 **state** | [**List&lt;string&gt;**](string.md)| Order states to filter by. By default all order states are returned | [optional] 
 **side** | **string**|  side can either be:&lt;ul&gt; &lt;li&gt;buy: backing a contract &lt;li&gt;sell: laying a contract &lt;/ul&gt; | [optional] 
 **sort** | **string**| How to sort the results, it should be used in conjuntion with the pagination parameter | [optional] [default to id]

### Return type

[**OrdersResponse**](OrdersResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getordersv0"></a>
# **GetOrdersV0**
> InlineResponse20011 GetOrdersV0 (List<int?> marketId = null, List<int?> contractId = null, string side = null, List<string> state = null, int? contractsLimit = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrdersV0Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrdersApi();
            var marketId = new List<int?>(); // List<int?> |  (optional) 
            var contractId = new List<int?>(); // List<int?> |  (optional) 
            var side = side_example;  // string |  side can either be:<ul> <li>buy: backing a contract <li>sell: laying a contract </ul> (optional) 
            var state = new List<string>(); // List<string> |  (optional) 
            var contractsLimit = 56;  // int? |  (optional)  (default to 10)

            try
            {
                InlineResponse20011 result = apiInstance.GetOrdersV0(marketId, contractId, side, state, contractsLimit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrdersV0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketId** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **contractId** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **side** | **string**|  side can either be:&lt;ul&gt; &lt;li&gt;buy: backing a contract &lt;li&gt;sell: laying a contract &lt;/ul&gt; | [optional] 
 **state** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **contractsLimit** | **int?**|  | [optional] [default to 10]

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
