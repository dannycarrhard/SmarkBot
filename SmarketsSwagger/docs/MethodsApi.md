# IO.Swagger.Api.MethodsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBankTransferMethod**](MethodsApi.md#createbanktransfermethod) | **POST** /v3/bank_transfer_methods/ |      Add a new bank transfer payment method.
[**CreateNetellerMethod**](MethodsApi.md#createnetellermethod) | **POST** /v3/neteller_methods/ |      Add a new neteller payment method.
[**CreateOpenBankTransferMethod**](MethodsApi.md#createopenbanktransfermethod) | **POST** /v3/open_bank_transfer_methods/ |      Add a new open bank transfer payment method.
[**CreateSkrillMethod**](MethodsApi.md#createskrillmethod) | **POST** /v3/skrill_methods/ |      Add a new skrill payment method.
[**DeleteCardMethod**](MethodsApi.md#deletecardmethod) | **DELETE** /v3/card_methods/{method_id}/ |      Disable a user&#x27;s card.
[**DeleteOpenBankTransferMethod**](MethodsApi.md#deleteopenbanktransfermethod) | **DELETE** /v3/open_bank_transfer_methods/{method_id}/ |      Disable a user&#x27;s bank account.
[**DeleteWorldpayMethod**](MethodsApi.md#deleteworldpaymethod) | **DELETE** /v3/worldpay_methods/{method_id}/ |      Disable a user&#x27;s card.
[**GetDepositMethods**](MethodsApi.md#getdepositmethods) | **GET** /v3/deposit_methods/ | Get all payment methods available for depositing funds from the user&#x27;s account.
[**GetOpenBankTransferProviders**](MethodsApi.md#getopenbanktransferproviders) | **GET** /v3/open_bank_transfer_methods/providers/ |      Get the open bank transfer providers.
[**GetPaymentProviderFeatures**](MethodsApi.md#getpaymentproviderfeatures) | **GET** /v3/providers/features/ |      Get payment provider features.
[**GetProviders**](MethodsApi.md#getproviders) | **GET** /v3/{method_type}_methods/providers/ |      Get the payment providers.
[**GetWithdrawalMethods**](MethodsApi.md#getwithdrawalmethods) | **GET** /v3/withdrawal_methods/ | Get all payment methods available for withdrawing funds from the user&#x27;s account.
[**PutCardMethodBillingAddress**](MethodsApi.md#putcardmethodbillingaddress) | **PUT** /v3/card_methods/{method_id}/billing_address/ |      Update the billing address for this method.

<a name="createbanktransfermethod"></a>
# **CreateBankTransferMethod**
> MethodIdResponse CreateBankTransferMethod (Body18 body = null)

     Add a new bank transfer payment method.

## Description By adding the bank account details using this route, the user will be able to withdraw using his/her bank account  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateBankTransferMethodExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MethodsApi();
            var body = new Body18(); // Body18 | JSON Request object (optional) 

            try
            {
                //      Add a new bank transfer payment method.
                MethodIdResponse result = apiInstance.CreateBankTransferMethod(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MethodsApi.CreateBankTransferMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body18**](Body18.md)| JSON Request object | [optional] 

### Return type

[**MethodIdResponse**](MethodIdResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createnetellermethod"></a>
# **CreateNetellerMethod**
> MethodIdResponse CreateNetellerMethod (Body34 body = null)

     Add a new neteller payment method.

## Description By adding the neteller account details using this route, the user will be able to deposit and withdraw using his/her neteller account  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateNetellerMethodExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MethodsApi();
            var body = new Body34(); // Body34 | JSON Request object (optional) 

            try
            {
                //      Add a new neteller payment method.
                MethodIdResponse result = apiInstance.CreateNetellerMethod(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MethodsApi.CreateNetellerMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body34**](Body34.md)| JSON Request object | [optional] 

### Return type

[**MethodIdResponse**](MethodIdResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createopenbanktransfermethod"></a>
# **CreateOpenBankTransferMethod**
> MethodIdResponse CreateOpenBankTransferMethod (Body42 body = null)

     Add a new open bank transfer payment method.

## Description By adding the bank account details using this route, the user will be able to deposit and withdraw using his/her bank account  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateOpenBankTransferMethodExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MethodsApi();
            var body = new Body42(); // Body42 | JSON Request object (optional) 

            try
            {
                //      Add a new open bank transfer payment method.
                MethodIdResponse result = apiInstance.CreateOpenBankTransferMethod(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MethodsApi.CreateOpenBankTransferMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body42**](Body42.md)| JSON Request object | [optional] 

### Return type

[**MethodIdResponse**](MethodIdResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createskrillmethod"></a>
# **CreateSkrillMethod**
> MethodIdResponse CreateSkrillMethod (Body53 body = null)

     Add a new skrill payment method.

## Description By adding the skrill account details using this route, the user will be able to deposit and withdraw using his/her skrill account  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSkrillMethodExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MethodsApi();
            var body = new Body53(); // Body53 | JSON Request object (optional) 

            try
            {
                //      Add a new skrill payment method.
                MethodIdResponse result = apiInstance.CreateSkrillMethod(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MethodsApi.CreateSkrillMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body53**](Body53.md)| JSON Request object | [optional] 

### Return type

[**MethodIdResponse**](MethodIdResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecardmethod"></a>
# **DeleteCardMethod**
> Object DeleteCardMethod (int? methodId)

     Disable a user's card.

## Description The user will no longer be able to deposit/withdraw with the card.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCardMethodExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MethodsApi();
            var methodId = 56;  // int? | 

            try
            {
                //      Disable a user's card.
                Object result = apiInstance.DeleteCardMethod(methodId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MethodsApi.DeleteCardMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **int?**|  | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteopenbanktransfermethod"></a>
# **DeleteOpenBankTransferMethod**
> Object DeleteOpenBankTransferMethod (int? methodId)

     Disable a user's bank account.

## Description The user will no longer be able to deposit/withdraw with the bank account.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteOpenBankTransferMethodExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MethodsApi();
            var methodId = 56;  // int? | 

            try
            {
                //      Disable a user's bank account.
                Object result = apiInstance.DeleteOpenBankTransferMethod(methodId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MethodsApi.DeleteOpenBankTransferMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **int?**|  | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteworldpaymethod"></a>
# **DeleteWorldpayMethod**
> Object DeleteWorldpayMethod (int? methodId)

     Disable a user's card.

## Description The user will no longer be able to deposit/withdraw with the card.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteWorldpayMethodExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MethodsApi();
            var methodId = 56;  // int? | 

            try
            {
                //      Disable a user's card.
                Object result = apiInstance.DeleteWorldpayMethod(methodId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MethodsApi.DeleteWorldpayMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **int?**|  | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdepositmethods"></a>
# **GetDepositMethods**
> DepositMethodsResponse GetDepositMethods ()

Get all payment methods available for depositing funds from the user's account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDepositMethodsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MethodsApi();

            try
            {
                // Get all payment methods available for depositing funds from the user's account.
                DepositMethodsResponse result = apiInstance.GetDepositMethods();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MethodsApi.GetDepositMethods: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DepositMethodsResponse**](DepositMethodsResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getopenbanktransferproviders"></a>
# **GetOpenBankTransferProviders**
> InlineResponse20052 GetOpenBankTransferProviders ()

     Get the open bank transfer providers.

## Description This route returns all the available open bank transfer payment providers in Smarkets, even if the user has no active methods for them. This can be used to display a bank selection dialog and to fetch provider_id before adding the method.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOpenBankTransferProvidersExample
    {
        public void main()
        {
            var apiInstance = new MethodsApi();

            try
            {
                //      Get the open bank transfer providers.
                InlineResponse20052 result = apiInstance.GetOpenBankTransferProviders();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MethodsApi.GetOpenBankTransferProviders: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20052**](InlineResponse20052.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpaymentproviderfeatures"></a>
# **GetPaymentProviderFeatures**
> ProviderFeaturesResponse GetPaymentProviderFeatures ()

     Get payment provider features.

## Description This route returns the different deposit and withdrawal options available together with the minimum and maximum transaction amount, daily limit, processing time and customer fee.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPaymentProviderFeaturesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MethodsApi();

            try
            {
                //      Get payment provider features.
                ProviderFeaturesResponse result = apiInstance.GetPaymentProviderFeatures();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MethodsApi.GetPaymentProviderFeatures: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ProviderFeaturesResponse**](ProviderFeaturesResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproviders"></a>
# **GetProviders**
> ProvidersResponse GetProviders (string methodType)

     Get the payment providers.

## Description This route returns all the available payment providers in Smarkets, even if the user has no active methods for them. This can be used to display maximum and minimum amounts for deposits/withdrawals  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProvidersExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MethodsApi();
            var methodType = methodType_example;  // string | 

            try
            {
                //      Get the payment providers.
                ProvidersResponse result = apiInstance.GetProviders(methodType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MethodsApi.GetProviders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodType** | **string**|  | 

### Return type

[**ProvidersResponse**](ProvidersResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getwithdrawalmethods"></a>
# **GetWithdrawalMethods**
> InlineResponse20068 GetWithdrawalMethods ()

Get all payment methods available for withdrawing funds from the user's account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWithdrawalMethodsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MethodsApi();

            try
            {
                // Get all payment methods available for withdrawing funds from the user's account.
                InlineResponse20068 result = apiInstance.GetWithdrawalMethods();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MethodsApi.GetWithdrawalMethods: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20068**](InlineResponse20068.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putcardmethodbillingaddress"></a>
# **PutCardMethodBillingAddress**
> MethodAddress PutCardMethodBillingAddress (int? methodId, MethodAddress body = null)

     Update the billing address for this method.

## Description This can be called if a user moves house or has mis-typed their address and wants to change it.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutCardMethodBillingAddressExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MethodsApi();
            var methodId = 56;  // int? | 
            var body = new MethodAddress(); // MethodAddress | JSON Request object (optional) 

            try
            {
                //      Update the billing address for this method.
                MethodAddress result = apiInstance.PutCardMethodBillingAddress(methodId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MethodsApi.PutCardMethodBillingAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methodId** | **int?**|  | 
 **body** | [**MethodAddress**](MethodAddress.md)| JSON Request object | [optional] 

### Return type

[**MethodAddress**](MethodAddress.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
