# IO.Swagger.Api.CommissionApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCommissionTiers**](CommissionApi.md#getcommissiontiers) | **GET** /v3/commission/bands/ | Retrieve commission tier information.

<a name="getcommissiontiers"></a>
# **GetCommissionTiers**
> CommissionBandsResponse GetCommissionTiers ()

Retrieve commission tier information.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCommissionTiersExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CommissionApi();

            try
            {
                // Retrieve commission tier information.
                CommissionBandsResponse result = apiInstance.GetCommissionTiers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommissionApi.GetCommissionTiers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CommissionBandsResponse**](CommissionBandsResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
