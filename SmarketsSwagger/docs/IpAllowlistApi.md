# IO.Swagger.Api.IpAllowlistApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteIpAllowlist**](IpAllowlistApi.md#deleteipallowlist) | **DELETE** /v3/ip_allowlist/ | Delete the allowlisted IP.
[**GetIpAllowlist**](IpAllowlistApi.md#getipallowlist) | **GET** /v3/ip_allowlist/ | Get the allowlisted IP.
[**UpdateIpAllowlist**](IpAllowlistApi.md#updateipallowlist) | **PUT** /v3/ip_allowlist/ | Update the allowlisted IP.

<a name="deleteipallowlist"></a>
# **DeleteIpAllowlist**
> InlineResponse20039 DeleteIpAllowlist ()

Delete the allowlisted IP.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteIpAllowlistExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IpAllowlistApi();

            try
            {
                // Delete the allowlisted IP.
                InlineResponse20039 result = apiInstance.DeleteIpAllowlist();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IpAllowlistApi.DeleteIpAllowlist: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20039**](InlineResponse20039.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getipallowlist"></a>
# **GetIpAllowlist**
> InlineResponse20039 GetIpAllowlist ()

Get the allowlisted IP.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetIpAllowlistExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IpAllowlistApi();

            try
            {
                // Get the allowlisted IP.
                InlineResponse20039 result = apiInstance.GetIpAllowlist();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IpAllowlistApi.GetIpAllowlist: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20039**](InlineResponse20039.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateipallowlist"></a>
# **UpdateIpAllowlist**
> InlineResponse20039 UpdateIpAllowlist (Body29 body = null)

Update the allowlisted IP.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateIpAllowlistExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IpAllowlistApi();
            var body = new Body29(); // Body29 | JSON Request object (optional) 

            try
            {
                // Update the allowlisted IP.
                InlineResponse20039 result = apiInstance.UpdateIpAllowlist(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IpAllowlistApi.UpdateIpAllowlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body29**](Body29.md)| JSON Request object | [optional] 

### Return type

[**InlineResponse20039**](InlineResponse20039.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
