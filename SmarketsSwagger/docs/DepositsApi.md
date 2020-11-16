# IO.Swagger.Api.DepositsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePretokenizationDepositWorldpay**](DepositsApi.md#createpretokenizationdepositworldpay) | **POST** /v3/worldpay_deposits/pretokenization/ | Create deposit corresponding to card tokenization.
[**DepositCard**](DepositsApi.md#depositcard) | **POST** /v3/card_deposits/ |      Create a card deposit.
[**DepositNeteller**](DepositsApi.md#depositneteller) | **POST** /v3/neteller_deposits/ |      Create a Neteller deposit.
[**DepositOpenBankTransfer**](DepositsApi.md#depositopenbanktransfer) | **POST** /v3/open_bank_transfer_deposits/ |      Create an Open Bank Tranfer deposit.
[**DepositPaypal**](DepositsApi.md#depositpaypal) | **POST** /v3/paypal_deposits/ |      Create a Paypal deposit.
[**DepositSkrill**](DepositsApi.md#depositskrill) | **POST** /v3/skrill_deposits/ |      Create a Skrill deposit.
[**DepositTrustly**](DepositsApi.md#deposittrustly) | **POST** /v3/trustly_deposits/ |      Create a Trustly deposit.
[**DepositWithRegistrationIdWorldpay**](DepositsApi.md#depositwithregistrationidworldpay) | **POST** /v3/worldpay_deposits/registration_id/ | Process card deposit with one time use registration id.
[**DepositWorldpay**](DepositsApi.md#depositworldpay) | **POST** /v3/worldpay_deposits/ | Create deposit.
[**GetFirstDepositBonusConditions**](DepositsApi.md#getfirstdepositbonusconditions) | **GET** /v3/deposits/bonus_conditions/ | Retrieve conditions for the first deposit to be bonus eligible.
[**GetOpenBankTransferDepositState**](DepositsApi.md#getopenbanktransferdepositstate) | **GET** /v3/open_bank_transfer_deposits/{provider_reference}/states/ |      Retrieve a Open Bank Transfer deposit.
[**GetPaypalClientToken**](DepositsApi.md#getpaypalclienttoken) | **GET** /v3/paypal_deposits/client_tokens/ | Get client token to initialize Paypal client SDK.
[**GetSkrillDepositState**](DepositsApi.md#getskrilldepositstate) | **GET** /v3/skrill_deposits/{transaction_id}/{skrill_signature}/states/ |      Retrieve a Skrill deposit.
[**PostCardToken**](DepositsApi.md#postcardtoken) | **POST** /v3/card_deposits/token/ |      Create card token.

<a name="createpretokenizationdepositworldpay"></a>
# **CreatePretokenizationDepositWorldpay**
> WorldpayPretokenizationResponse CreatePretokenizationDepositWorldpay (WorldpayPretokenizationRequest body = null)

Create deposit corresponding to card tokenization.

## Description This call creates a deposit and a method placeholders and returns the parameters needed to tokenize a card using the eProtect Worlpay system. The deposit can then be processed by posting the `registration_id` (one time card token) to `/v3/worlspay_deposits/registration_id/`.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePretokenizationDepositWorldpayExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositsApi();
            var body = new WorldpayPretokenizationRequest(); // WorldpayPretokenizationRequest | JSON Request object (optional) 

            try
            {
                // Create deposit corresponding to card tokenization.
                WorldpayPretokenizationResponse result = apiInstance.CreatePretokenizationDepositWorldpay(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositsApi.CreatePretokenizationDepositWorldpay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorldpayPretokenizationRequest**](WorldpayPretokenizationRequest.md)| JSON Request object | [optional] 

### Return type

[**WorldpayPretokenizationResponse**](WorldpayPretokenizationResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="depositcard"></a>
# **DepositCard**
> CardDepositResponse DepositCard (Body19 body = null)

     Create a card deposit.

## Description This route can be used in 3 different ways:  - Deposit with a new card - the card details need to be provided along with the  remaining deposit details. After the deposit succeeds, the card will be added as  a recognized method of payment  - Deposit with an existing card - the method id must be provided along with the  deposit details. This needs to be a card that was previously used for a deposit.  - Deposit with Google/Apple Pay - last four, issuer, token, token type and  token expiry need to be provided.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DepositCardExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositsApi();
            var body = new Body19(); // Body19 | JSON Request object (optional) 

            try
            {
                //      Create a card deposit.
                CardDepositResponse result = apiInstance.DepositCard(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositsApi.DepositCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body19**](Body19.md)| JSON Request object | [optional] 

### Return type

[**CardDepositResponse**](CardDepositResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="depositneteller"></a>
# **DepositNeteller**
> NetellerDepositResponse DepositNeteller (Body33 body = null)

     Create a Neteller deposit.

## Description By calling this route with the amount, neteller secure id and the stored method id, we call neteller to process the transaction and return a success or failure response accordingly.  By calling this route with the amount, success/fail urls and the stored method id, it will return a response that contains a URL. Clients can follow this URL, in order to finish the deposit process on the neteller website.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DepositNetellerExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositsApi();
            var body = new Body33(); // Body33 | JSON Request object (optional) 

            try
            {
                //      Create a Neteller deposit.
                NetellerDepositResponse result = apiInstance.DepositNeteller(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositsApi.DepositNeteller: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body33**](Body33.md)| JSON Request object | [optional] 

### Return type

[**NetellerDepositResponse**](NetellerDepositResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="depositopenbanktransfer"></a>
# **DepositOpenBankTransfer**
> OpenBankTransferDepositResponse DepositOpenBankTransfer (Body41 body = null)

     Create an Open Bank Tranfer deposit.

## Description By calling this route with the details needed to trigger a open bank tranfer deposit, it will return a response that contains a URL. Clients can follow this URL, in order to finish the deposit process on their bank's website/app.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DepositOpenBankTransferExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositsApi();
            var body = new Body41(); // Body41 | JSON Request object (optional) 

            try
            {
                //      Create an Open Bank Tranfer deposit.
                OpenBankTransferDepositResponse result = apiInstance.DepositOpenBankTransfer(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositsApi.DepositOpenBankTransfer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body41**](Body41.md)| JSON Request object | [optional] 

### Return type

[**OpenBankTransferDepositResponse**](OpenBankTransferDepositResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="depositpaypal"></a>
# **DepositPaypal**
> PaypalDepositResponse DepositPaypal (Body48 body = null)

     Create a Paypal deposit.

## Description By calling this route with the amount, paypal payment_method_nonce and paypal payer_id, we call paypal to process the transaction and return a success or failure response accordingly.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DepositPaypalExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositsApi();
            var body = new Body48(); // Body48 | JSON Request object (optional) 

            try
            {
                //      Create a Paypal deposit.
                PaypalDepositResponse result = apiInstance.DepositPaypal(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositsApi.DepositPaypal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body48**](Body48.md)| JSON Request object | [optional] 

### Return type

[**PaypalDepositResponse**](PaypalDepositResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="depositskrill"></a>
# **DepositSkrill**
> SkrillDepositResponse DepositSkrill (Body52 body = null)

     Create a Skrill deposit.

## Description By calling this route with the details needed to trigger a skrill deposit, it will return a response that contains a URL. Clients can follow this URL, in order to finish the deposit process on the skrill website.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DepositSkrillExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositsApi();
            var body = new Body52(); // Body52 | JSON Request object (optional) 

            try
            {
                //      Create a Skrill deposit.
                SkrillDepositResponse result = apiInstance.DepositSkrill(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositsApi.DepositSkrill: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body52**](Body52.md)| JSON Request object | [optional] 

### Return type

[**SkrillDepositResponse**](SkrillDepositResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deposittrustly"></a>
# **DepositTrustly**
> TrustlyDepositResponse DepositTrustly (Body56 body = null)

     Create a Trustly deposit.

## Description By calling this route with the details needed to trigger a trustly deposit, it will return a response that contains a URL. Clients can follow this URL, in order to finish the deposit process on the trustly website.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DepositTrustlyExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositsApi();
            var body = new Body56(); // Body56 | JSON Request object (optional) 

            try
            {
                //      Create a Trustly deposit.
                TrustlyDepositResponse result = apiInstance.DepositTrustly(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositsApi.DepositTrustly: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body56**](Body56.md)| JSON Request object | [optional] 

### Return type

[**TrustlyDepositResponse**](TrustlyDepositResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="depositwithregistrationidworldpay"></a>
# **DepositWithRegistrationIdWorldpay**
> WorldpayDepositResponse DepositWithRegistrationIdWorldpay (WorldpayRegistrationIdDepositRequest body = null)

Process card deposit with one time use registration id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DepositWithRegistrationIdWorldpayExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositsApi();
            var body = new WorldpayRegistrationIdDepositRequest(); // WorldpayRegistrationIdDepositRequest | JSON Request object (optional) 

            try
            {
                // Process card deposit with one time use registration id.
                WorldpayDepositResponse result = apiInstance.DepositWithRegistrationIdWorldpay(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositsApi.DepositWithRegistrationIdWorldpay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorldpayRegistrationIdDepositRequest**](WorldpayRegistrationIdDepositRequest.md)| JSON Request object | [optional] 

### Return type

[**WorldpayDepositResponse**](WorldpayDepositResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="depositworldpay"></a>
# **DepositWorldpay**
> WorldpayDepositResponse DepositWorldpay (WorldpayDepositRequest body = null)

Create deposit.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DepositWorldpayExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositsApi();
            var body = new WorldpayDepositRequest(); // WorldpayDepositRequest | JSON Request object (optional) 

            try
            {
                // Create deposit.
                WorldpayDepositResponse result = apiInstance.DepositWorldpay(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositsApi.DepositWorldpay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorldpayDepositRequest**](WorldpayDepositRequest.md)| JSON Request object | [optional] 

### Return type

[**WorldpayDepositResponse**](WorldpayDepositResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getfirstdepositbonusconditions"></a>
# **GetFirstDepositBonusConditions**
> DepositBonusConditionsResponse GetFirstDepositBonusConditions ()

Retrieve conditions for the first deposit to be bonus eligible.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFirstDepositBonusConditionsExample
    {
        public void main()
        {
            var apiInstance = new DepositsApi();

            try
            {
                // Retrieve conditions for the first deposit to be bonus eligible.
                DepositBonusConditionsResponse result = apiInstance.GetFirstDepositBonusConditions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositsApi.GetFirstDepositBonusConditions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DepositBonusConditionsResponse**](DepositBonusConditionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getopenbanktransferdepositstate"></a>
# **GetOpenBankTransferDepositState**
> DepositStateResponse GetOpenBankTransferDepositState (string providerReference)

     Retrieve a Open Bank Transfer deposit.

## Description By calling this route with the deposit's provider reference, we return the state of the corresponding open bank transfer deposit. This route should be called after the user is redirected back to Smarkets after processing his/her open bank transfer deposit in the bank's website or mobile app.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOpenBankTransferDepositStateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositsApi();
            var providerReference = providerReference_example;  // string | 

            try
            {
                //      Retrieve a Open Bank Transfer deposit.
                DepositStateResponse result = apiInstance.GetOpenBankTransferDepositState(providerReference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositsApi.GetOpenBankTransferDepositState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **providerReference** | **string**|  | 

### Return type

[**DepositStateResponse**](DepositStateResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpaypalclienttoken"></a>
# **GetPaypalClientToken**
> ClientToken GetPaypalClientToken ()

Get client token to initialize Paypal client SDK.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPaypalClientTokenExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositsApi();

            try
            {
                // Get client token to initialize Paypal client SDK.
                ClientToken result = apiInstance.GetPaypalClientToken();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositsApi.GetPaypalClientToken: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ClientToken**](ClientToken.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getskrilldepositstate"></a>
# **GetSkrillDepositState**
> DepositStateResponse GetSkrillDepositState (string transactionId, string skrillSignature)

     Retrieve a Skrill deposit.

## Description By calling this route with the transation id and the skrill signature, we return the state of the corresponding skrill deposit. This route should be called after the user is redirected back to Smarkets after processing his/her skrill deposit in the skrill website.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSkrillDepositStateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositsApi();
            var transactionId = transactionId_example;  // string | 
            var skrillSignature = skrillSignature_example;  // string | 

            try
            {
                //      Retrieve a Skrill deposit.
                DepositStateResponse result = apiInstance.GetSkrillDepositState(transactionId, skrillSignature);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositsApi.GetSkrillDepositState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionId** | **string**|  | 
 **skrillSignature** | **string**|  | 

### Return type

[**DepositStateResponse**](DepositStateResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postcardtoken"></a>
# **PostCardToken**
> CardToken PostCardToken (CardToken body = null)

     Create card token.

## Description By sending Smarkets a card deposit token, we can use that token to contact our card payment provider and figure our whether the underlying payment was successful or not. If the payment succeeded, the response is a 201 status code, if not, a 4xx/5xx type error.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostCardTokenExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositsApi();
            var body = new CardToken(); // CardToken | JSON Request object (optional) 

            try
            {
                //      Create card token.
                CardToken result = apiInstance.PostCardToken(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositsApi.PostCardToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CardToken**](CardToken.md)| JSON Request object | [optional] 

### Return type

[**CardToken**](CardToken.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
