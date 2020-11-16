# IO.Swagger.Api.CountriesApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllowedCountries**](CountriesApi.md#getallowedcountries) | **GET** /v3/countries/ | Return a list of countries (2 letter country code) where we can take user signups from.
[**GetCurrentCountry**](CountriesApi.md#getcurrentcountry) | **GET** /v3/countries/current/ | Return the user&#x27;s current country and whether it is permitted.
[**GetPermittedCountries**](CountriesApi.md#getpermittedcountries) | **GET** /v0/countries/ | 

<a name="getallowedcountries"></a>
# **GetAllowedCountries**
> CountriesResponse GetAllowedCountries ()

Return a list of countries (2 letter country code) where we can take user signups from.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllowedCountriesExample
    {
        public void main()
        {
            var apiInstance = new CountriesApi();

            try
            {
                // Return a list of countries (2 letter country code) where we can take user signups from.
                CountriesResponse result = apiInstance.GetAllowedCountries();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountriesApi.GetAllowedCountries: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CountriesResponse**](CountriesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcurrentcountry"></a>
# **GetCurrentCountry**
> CurrentCountriesResponse GetCurrentCountry ()

Return the user's current country and whether it is permitted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCurrentCountryExample
    {
        public void main()
        {
            var apiInstance = new CountriesApi();

            try
            {
                // Return the user's current country and whether it is permitted.
                CurrentCountriesResponse result = apiInstance.GetCurrentCountry();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountriesApi.GetCurrentCountry: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CurrentCountriesResponse**](CurrentCountriesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpermittedcountries"></a>
# **GetPermittedCountries**
> List<string> GetPermittedCountries ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPermittedCountriesExample
    {
        public void main()
        {
            var apiInstance = new CountriesApi();

            try
            {
                List&lt;string&gt; result = apiInstance.GetPermittedCountries();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountriesApi.GetPermittedCountries: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
