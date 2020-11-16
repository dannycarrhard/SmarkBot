# IO.Swagger.Api.AccountsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAccount**](AccountsApi.md#getaccount) | **GET** /v3/accounts/ | Retrieve account information.
[**GetNetDeposits**](AccountsApi.md#getnetdeposits) | **GET** /v3/accounts/net_deposits/ | Retrieve the net deposits (deposits minus withdrawals) for the account.
[**GetThirdParties**](AccountsApi.md#getthirdparties) | **GET** /v3/accounts/third_parties/ | Get the third party ids authorized to access the account.
[**RevokeAllThirdParties**](AccountsApi.md#revokeallthirdparties) | **DELETE** /v3/accounts/third_parties/ | Revoke all third parties access to the account.
[**RevokeThirdParty**](AccountsApi.md#revokethirdparty) | **DELETE** /v3/accounts/third_parties/{third_party_id}/ | Revoke one third party access to the account.

<a name="getaccount"></a>
# **GetAccount**
> AccountResponse GetAccount ()

Retrieve account information.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();

            try
            {
                // Retrieve account information.
                AccountResponse result = apiInstance.GetAccount();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AccountResponse**](AccountResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getnetdeposits"></a>
# **GetNetDeposits**
> NetDepositsResponseSchema GetNetDeposits ()

Retrieve the net deposits (deposits minus withdrawals) for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetNetDepositsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();

            try
            {
                // Retrieve the net deposits (deposits minus withdrawals) for the account.
                NetDepositsResponseSchema result = apiInstance.GetNetDeposits();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetNetDeposits: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**NetDepositsResponseSchema**](NetDepositsResponseSchema.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getthirdparties"></a>
# **GetThirdParties**
> ApprovedThirdParties GetThirdParties ()

Get the third party ids authorized to access the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetThirdPartiesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();

            try
            {
                // Get the third party ids authorized to access the account.
                ApprovedThirdParties result = apiInstance.GetThirdParties();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetThirdParties: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ApprovedThirdParties**](ApprovedThirdParties.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="revokeallthirdparties"></a>
# **RevokeAllThirdParties**
> DeletedThirdParties RevokeAllThirdParties ()

Revoke all third parties access to the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RevokeAllThirdPartiesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();

            try
            {
                // Revoke all third parties access to the account.
                DeletedThirdParties result = apiInstance.RevokeAllThirdParties();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.RevokeAllThirdParties: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DeletedThirdParties**](DeletedThirdParties.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="revokethirdparty"></a>
# **RevokeThirdParty**
> DeletedThirdParties RevokeThirdParty (int? thirdPartyId)

Revoke one third party access to the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RevokeThirdPartyExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var thirdPartyId = 56;  // int? | 

            try
            {
                // Revoke one third party access to the account.
                DeletedThirdParties result = apiInstance.RevokeThirdParty(thirdPartyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.RevokeThirdParty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **thirdPartyId** | **int?**|  | 

### Return type

[**DeletedThirdParties**](DeletedThirdParties.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
