# IO.Swagger.Api.CredentialsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeEmail**](CredentialsApi.md#changeemail) | **PUT** /v3/email/ | 
[**ChangePassword**](CredentialsApi.md#changepassword) | **PUT** /v3/password/ | 
[**PasswordReset**](CredentialsApi.md#passwordreset) | **PUT** /v3/password-reset/{token}/ | 
[**PasswordTokenValidation**](CredentialsApi.md#passwordtokenvalidation) | **POST** /v3/password-token/ | 
[**SendPasswordResetEmail**](CredentialsApi.md#sendpasswordresetemail) | **POST** /v3/password-reset-email/ | 

<a name="changeemail"></a>
# **ChangeEmail**
> InlineResponse20037 ChangeEmail (Body28 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangeEmailExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CredentialsApi();
            var body = new Body28(); // Body28 | JSON Request object (optional) 

            try
            {
                InlineResponse20037 result = apiInstance.ChangeEmail(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.ChangeEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body28**](Body28.md)| JSON Request object | [optional] 

### Return type

[**InlineResponse20037**](InlineResponse20037.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="changepassword"></a>
# **ChangePassword**
> InlineResponse20014 ChangePassword (Body47 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangePasswordExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CredentialsApi();
            var body = new Body47(); // Body47 | JSON Request object (optional) 

            try
            {
                InlineResponse20014 result = apiInstance.ChangePassword(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.ChangePassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body47**](Body47.md)| JSON Request object | [optional] 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="passwordreset"></a>
# **PasswordReset**
> InlineResponse20054 PasswordReset (string token, Body45 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PasswordResetExample
    {
        public void main()
        {
            var apiInstance = new CredentialsApi();
            var token = token_example;  // string | 
            var body = new Body45(); // Body45 | JSON Request object (optional) 

            try
            {
                InlineResponse20054 result = apiInstance.PasswordReset(token, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.PasswordReset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**|  | 
 **body** | [**Body45**](Body45.md)| JSON Request object | [optional] 

### Return type

[**InlineResponse20054**](InlineResponse20054.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="passwordtokenvalidation"></a>
# **PasswordTokenValidation**
> InlineResponse20026 PasswordTokenValidation (Body46 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PasswordTokenValidationExample
    {
        public void main()
        {
            var apiInstance = new CredentialsApi();
            var body = new Body46(); // Body46 | JSON Request object (optional) 

            try
            {
                InlineResponse20026 result = apiInstance.PasswordTokenValidation(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.PasswordTokenValidation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body46**](Body46.md)| JSON Request object | [optional] 

### Return type

[**InlineResponse20026**](InlineResponse20026.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="sendpasswordresetemail"></a>
# **SendPasswordResetEmail**
> InlineResponse20014 SendPasswordResetEmail (Body44 body = null)



 ##  Rate limits Maximum 3 requests per 60 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendPasswordResetEmailExample
    {
        public void main()
        {
            var apiInstance = new CredentialsApi();
            var body = new Body44(); // Body44 | JSON Request object (optional) 

            try
            {
                InlineResponse20014 result = apiInstance.SendPasswordResetEmail(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.SendPasswordResetEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body44**](Body44.md)| JSON Request object | [optional] 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
