# IO.Swagger.Api.WithdrawalsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelWithdrawal**](WithdrawalsApi.md#cancelwithdrawal) | **DELETE** /v3/withdrawals/ | Cancel a pending withdrawal.
[**ConfirmQueuedWithdrawalCancelBlock**](WithdrawalsApi.md#confirmqueuedwithdrawalcancelblock) | **POST** /v3/withdrawals/withdrawal_cancel_block/queued/ | 
[**CreateWithdrawalCancelBlock**](WithdrawalsApi.md#createwithdrawalcancelblock) | **POST** /v3/withdrawals/withdrawal_cancel_block/ | 
[**GetPendingWithdrawals**](WithdrawalsApi.md#getpendingwithdrawals) | **GET** /v3/withdrawals/ | Get pending withdrawals.
[**GetQueuedWithdrawalCancelBlock**](WithdrawalsApi.md#getqueuedwithdrawalcancelblock) | **GET** /v3/withdrawals/withdrawal_cancel_block/queued/ | 
[**GetWithdrawalCancelBlock**](WithdrawalsApi.md#getwithdrawalcancelblock) | **GET** /v3/withdrawals/withdrawal_cancel_block/ | 
[**RemoveQueuedWithdrawalCancelBlock**](WithdrawalsApi.md#removequeuedwithdrawalcancelblock) | **DELETE** /v3/withdrawals/withdrawal_cancel_block/queued/ | 
[**RemoveWithdrawalCancelBlock**](WithdrawalsApi.md#removewithdrawalcancelblock) | **DELETE** /v3/withdrawals/withdrawal_cancel_block/ | 
[**RequestWithdrawal**](WithdrawalsApi.md#requestwithdrawal) | **POST** /v3/withdrawals/ | Request a withdrawal.
[**RequestWithdrawalTrustly**](WithdrawalsApi.md#requestwithdrawaltrustly) | **POST** /v3/trustly_withdrawals/ | Request a Trustly withdrawal.

<a name="cancelwithdrawal"></a>
# **CancelWithdrawal**
> Object CancelWithdrawal (string provider = null, string withdrawalId = null)

Cancel a pending withdrawal.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelWithdrawalExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WithdrawalsApi();
            var provider = provider_example;  // string |  (optional) 
            var withdrawalId = withdrawalId_example;  // string |  (optional) 

            try
            {
                // Cancel a pending withdrawal.
                Object result = apiInstance.CancelWithdrawal(provider, withdrawalId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WithdrawalsApi.CancelWithdrawal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **provider** | **string**|  | [optional] 
 **withdrawalId** | **string**|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="confirmqueuedwithdrawalcancelblock"></a>
# **ConfirmQueuedWithdrawalCancelBlock**
> Object ConfirmQueuedWithdrawalCancelBlock ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConfirmQueuedWithdrawalCancelBlockExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WithdrawalsApi();

            try
            {
                Object result = apiInstance.ConfirmQueuedWithdrawalCancelBlock();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WithdrawalsApi.ConfirmQueuedWithdrawalCancelBlock: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createwithdrawalcancelblock"></a>
# **CreateWithdrawalCancelBlock**
> Object CreateWithdrawalCancelBlock ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateWithdrawalCancelBlockExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WithdrawalsApi();

            try
            {
                Object result = apiInstance.CreateWithdrawalCancelBlock();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WithdrawalsApi.CreateWithdrawalCancelBlock: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpendingwithdrawals"></a>
# **GetPendingWithdrawals**
> PendingWithdrawalResponse GetPendingWithdrawals ()

Get pending withdrawals.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPendingWithdrawalsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WithdrawalsApi();

            try
            {
                // Get pending withdrawals.
                PendingWithdrawalResponse result = apiInstance.GetPendingWithdrawals();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WithdrawalsApi.GetPendingWithdrawals: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PendingWithdrawalResponse**](PendingWithdrawalResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getqueuedwithdrawalcancelblock"></a>
# **GetQueuedWithdrawalCancelBlock**
> WithdrawalCancelBlockQueuedResponse1 GetQueuedWithdrawalCancelBlock ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQueuedWithdrawalCancelBlockExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WithdrawalsApi();

            try
            {
                WithdrawalCancelBlockQueuedResponse1 result = apiInstance.GetQueuedWithdrawalCancelBlock();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WithdrawalsApi.GetQueuedWithdrawalCancelBlock: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**WithdrawalCancelBlockQueuedResponse1**](WithdrawalCancelBlockQueuedResponse1.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getwithdrawalcancelblock"></a>
# **GetWithdrawalCancelBlock**
> WithdrawalCancelBlockQueuedResponse GetWithdrawalCancelBlock ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWithdrawalCancelBlockExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WithdrawalsApi();

            try
            {
                WithdrawalCancelBlockQueuedResponse result = apiInstance.GetWithdrawalCancelBlock();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WithdrawalsApi.GetWithdrawalCancelBlock: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**WithdrawalCancelBlockQueuedResponse**](WithdrawalCancelBlockQueuedResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removequeuedwithdrawalcancelblock"></a>
# **RemoveQueuedWithdrawalCancelBlock**
> Object RemoveQueuedWithdrawalCancelBlock ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveQueuedWithdrawalCancelBlockExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WithdrawalsApi();

            try
            {
                Object result = apiInstance.RemoveQueuedWithdrawalCancelBlock();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WithdrawalsApi.RemoveQueuedWithdrawalCancelBlock: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removewithdrawalcancelblock"></a>
# **RemoveWithdrawalCancelBlock**
> Object RemoveWithdrawalCancelBlock ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveWithdrawalCancelBlockExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WithdrawalsApi();

            try
            {
                Object result = apiInstance.RemoveWithdrawalCancelBlock();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WithdrawalsApi.RemoveWithdrawalCancelBlock: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="requestwithdrawal"></a>
# **RequestWithdrawal**
> PostWithdrawalResponse RequestWithdrawal (Body60 body = null)

Request a withdrawal.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RequestWithdrawalExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WithdrawalsApi();
            var body = new Body60(); // Body60 | JSON Request object (optional) 

            try
            {
                // Request a withdrawal.
                PostWithdrawalResponse result = apiInstance.RequestWithdrawal(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WithdrawalsApi.RequestWithdrawal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body60**](Body60.md)| JSON Request object | [optional] 

### Return type

[**PostWithdrawalResponse**](PostWithdrawalResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="requestwithdrawaltrustly"></a>
# **RequestWithdrawalTrustly**
> PostTrustlyWithdrawalResponse RequestWithdrawalTrustly (Body57 body = null)

Request a Trustly withdrawal.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RequestWithdrawalTrustlyExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WithdrawalsApi();
            var body = new Body57(); // Body57 | JSON Request object (optional) 

            try
            {
                // Request a Trustly withdrawal.
                PostTrustlyWithdrawalResponse result = apiInstance.RequestWithdrawalTrustly(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WithdrawalsApi.RequestWithdrawalTrustly: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body57**](Body57.md)| JSON Request object | [optional] 

### Return type

[**PostTrustlyWithdrawalResponse**](PostTrustlyWithdrawalResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
