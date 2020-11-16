# IO.Swagger.Api.AddressesApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressPicker**](AddressesApi.md#addresspicker) | **GET** /v0/addresses/{postcode}/ | 
[**GetAddresses**](AddressesApi.md#getaddresses) | **GET** /v3/addresses/{postcode}/ | Return all possible addresses for a given postcode.

<a name="addresspicker"></a>
# **AddressPicker**
> InlineResponse200 AddressPicker (string postcode)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddressPickerExample
    {
        public void main()
        {
            var apiInstance = new AddressesApi();
            var postcode = postcode_example;  // string | 

            try
            {
                InlineResponse200 result = apiInstance.AddressPicker(postcode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressesApi.AddressPicker: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postcode** | **string**|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getaddresses"></a>
# **GetAddresses**
> AddressesResponse GetAddresses (string postcode)

Return all possible addresses for a given postcode.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAddressesExample
    {
        public void main()
        {
            var apiInstance = new AddressesApi();
            var postcode = postcode_example;  // string | 

            try
            {
                // Return all possible addresses for a given postcode.
                AddressesResponse result = apiInstance.GetAddresses(postcode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressesApi.GetAddresses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postcode** | **string**|  | 

### Return type

[**AddressesResponse**](AddressesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
