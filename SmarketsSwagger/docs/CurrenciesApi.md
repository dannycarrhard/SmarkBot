# IO.Swagger.Api.CurrenciesApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCurrencies**](CurrenciesApi.md#getcurrencies) | **GET** /v3/currencies/ | Retrieve a list of currencies available on the exchange and their current rates.
[**GetCurrenciesV0**](CurrenciesApi.md#getcurrenciesv0) | **GET** /v0/currencies/ | 
[**GetCurrency**](CurrenciesApi.md#getcurrency) | **GET** /v3/currencies/{code}/ | Retrieve the conversion rate for one specific currency.
[**GetSignupCurrencies**](CurrenciesApi.md#getsignupcurrencies) | **GET** /v0/currencies/signup/ | 

<a name="getcurrencies"></a>
# **GetCurrencies**
> CurrenciesResponse GetCurrencies ()

Retrieve a list of currencies available on the exchange and their current rates.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCurrenciesExample
    {
        public void main()
        {
            var apiInstance = new CurrenciesApi();

            try
            {
                // Retrieve a list of currencies available on the exchange and their current rates.
                CurrenciesResponse result = apiInstance.GetCurrencies();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurrenciesApi.GetCurrencies: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CurrenciesResponse**](CurrenciesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcurrenciesv0"></a>
# **GetCurrenciesV0**
> List<InlineResponse2003> GetCurrenciesV0 ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCurrenciesV0Example
    {
        public void main()
        {
            var apiInstance = new CurrenciesApi();

            try
            {
                List&lt;InlineResponse2003&gt; result = apiInstance.GetCurrenciesV0();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurrenciesApi.GetCurrenciesV0: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InlineResponse2003>**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcurrency"></a>
# **GetCurrency**
> Currency GetCurrency (string code)

Retrieve the conversion rate for one specific currency.

## Description This can be used to convert quantities from GBP to the user's currency  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCurrencyExample
    {
        public void main()
        {
            var apiInstance = new CurrenciesApi();
            var code = code_example;  // string | Currency code

            try
            {
                // Retrieve the conversion rate for one specific currency.
                Currency result = apiInstance.GetCurrency(code);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurrenciesApi.GetCurrency: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| Currency code | 

### Return type

[**Currency**](Currency.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsignupcurrencies"></a>
# **GetSignupCurrencies**
> List<InlineResponse2003> GetSignupCurrencies ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSignupCurrenciesExample
    {
        public void main()
        {
            var apiInstance = new CurrenciesApi();

            try
            {
                List&lt;InlineResponse2003&gt; result = apiInstance.GetSignupCurrencies();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurrenciesApi.GetSignupCurrencies: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InlineResponse2003>**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
