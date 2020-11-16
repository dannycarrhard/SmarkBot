# IO.Swagger.Api.VerificationApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VerifyCard**](VerificationApi.md#verifycard) | **POST** /v3/card_verification/ |      Verify a card.

<a name="verifycard"></a>
# **VerifyCard**
> CardDepositResponse VerifyCard (Body20 body = null)

     Verify a card.

## Description Attempts to verify a card by using a zero-charge transaction. Some banks may reject zero-charge transactions, in which case a $1 or FX-equivalent transaction may be attempted. Note that we only ask for authorisation for a charge, but never capture it.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VerifyCardExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VerificationApi();
            var body = new Body20(); // Body20 | JSON Request object (optional) 

            try
            {
                //      Verify a card.
                CardDepositResponse result = apiInstance.VerifyCard(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.VerifyCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body20**](Body20.md)| JSON Request object | [optional] 

### Return type

[**CardDepositResponse**](CardDepositResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
