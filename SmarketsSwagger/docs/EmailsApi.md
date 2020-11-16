# IO.Swagger.Api.EmailsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckEmailVerificationStatus**](EmailsApi.md#checkemailverificationstatus) | **GET** /v3/verified_emails/ | Check the users email address is verified in order to use Smarkets.
[**DoesEmailExist**](EmailsApi.md#doesemailexist) | **GET** /v3/emails/{email}/exists/ | Check if an email belongs to a Smarkets customer.
[**SendVerificationEmail**](EmailsApi.md#sendverificationemail) | **POST** /v3/verification_emails/ | Send another email verification message.
[**VerifyEmail**](EmailsApi.md#verifyemail) | **POST** /v3/verified_emails/ | Set an email address as verified in order to use Smarkets.
[**VerifyEmailV0**](EmailsApi.md#verifyemailv0) | **POST** /v0/emails/tokens/{token}/verified/ | 

<a name="checkemailverificationstatus"></a>
# **CheckEmailVerificationStatus**
> EmailVerifiedStatusResponse CheckEmailVerificationStatus ()

Check the users email address is verified in order to use Smarkets.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CheckEmailVerificationStatusExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EmailsApi();

            try
            {
                // Check the users email address is verified in order to use Smarkets.
                EmailVerifiedStatusResponse result = apiInstance.CheckEmailVerificationStatus();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.CheckEmailVerificationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**EmailVerifiedStatusResponse**](EmailVerifiedStatusResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="doesemailexist"></a>
# **DoesEmailExist**
> EmailExistsResponse DoesEmailExist (string email)

Check if an email belongs to a Smarkets customer.

 ##  Rate limits Maximum 10 requests per 60 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DoesEmailExistExample
    {
        public void main()
        {
            var apiInstance = new EmailsApi();
            var email = email_example;  // string | 

            try
            {
                // Check if an email belongs to a Smarkets customer.
                EmailExistsResponse result = apiInstance.DoesEmailExist(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.DoesEmailExist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**|  | 

### Return type

[**EmailExistsResponse**](EmailExistsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="sendverificationemail"></a>
# **SendVerificationEmail**
> Object SendVerificationEmail ()

Send another email verification message.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendVerificationEmailExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EmailsApi();

            try
            {
                // Send another email verification message.
                Object result = apiInstance.SendVerificationEmail();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.SendVerificationEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="verifyemail"></a>
# **VerifyEmail**
> VerifyEmailResponse VerifyEmail (Body58 body = null)

Set an email address as verified in order to use Smarkets.

 ##  Rate limits Maximum 10 requests per 60 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VerifyEmailExample
    {
        public void main()
        {
            var apiInstance = new EmailsApi();
            var body = new Body58(); // Body58 | JSON Request object (optional) 

            try
            {
                // Set an email address as verified in order to use Smarkets.
                VerifyEmailResponse result = apiInstance.VerifyEmail(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.VerifyEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body58**](Body58.md)| JSON Request object | [optional] 

### Return type

[**VerifyEmailResponse**](VerifyEmailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="verifyemailv0"></a>
# **VerifyEmailV0**
> string VerifyEmailV0 (string token)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VerifyEmailV0Example
    {
        public void main()
        {
            var apiInstance = new EmailsApi();
            var token = token_example;  // string | 

            try
            {
                string result = apiInstance.VerifyEmailV0(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.VerifyEmailV0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
