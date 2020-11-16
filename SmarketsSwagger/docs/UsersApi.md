# IO.Swagger.Api.UsersApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountActivity**](UsersApi.md#accountactivity) | **GET** /v0/users/current/activity/{start_datetime}/{end_datetime}/ | 
[**BalanceExposure**](UsersApi.md#balanceexposure) | **GET** /v0/users/current/balance_exposure/ | 
[**Current**](UsersApi.md#current) | **GET** /v0/users/current/ | 
[**Finance**](UsersApi.md#finance) | **GET** /v0/users/current/finance/ | 
[**GetPaymentTermsAccepted**](UsersApi.md#getpaymenttermsaccepted) | **GET** /v0/payment_terms_accepted/ | 
[**GetUser**](UsersApi.md#getuser) | **GET** /v3/users/ | Get user personal information.
[**PasswordResetV0**](UsersApi.md#passwordresetv0) | **PUT** /v0/users/current/password-reset/{token}/ | 
[**PasswordTokenValidationV0**](UsersApi.md#passwordtokenvalidationv0) | **POST** /v0/users/current/password-token/ | 
[**Pnl**](UsersApi.md#pnl) | **GET** /v0/users/current/pnl/ | 
[**PostPaymentTermsAccepted**](UsersApi.md#postpaymenttermsaccepted) | **POST** /v0/payment_terms_accepted/ | 
[**PotentialWinnings**](UsersApi.md#potentialwinnings) | **GET** /v0/users/current/potential_winnings/ | 
[**SaveAffiliateInformation**](UsersApi.md#saveaffiliateinformation) | **POST** /v3/users/{user_id}/affiliate_tag/ | Save affiliate information for a newly created user.
[**SendPasswordResetEmailV0**](UsersApi.md#sendpasswordresetemailv0) | **POST** /v0/users/current/password-reset-email/ | 
[**Signup**](UsersApi.md#signup) | **POST** /v3/users/ | Create a new member, an account for selected currency (User service).
[**UserWithoutRate**](UsersApi.md#userwithoutrate) | **GET** /v0/users/current/info-without-rate/ | 

<a name="accountactivity"></a>
# **AccountActivity**
> InlineResponse20017 AccountActivity (DateTime? startDatetime, DateTime? endDatetime)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi();
            var startDatetime = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var endDatetime = 2013-10-20T19:20:30+01:00;  // DateTime? | 

            try
            {
                InlineResponse20017 result = apiInstance.AccountActivity(startDatetime, endDatetime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.AccountActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDatetime** | **DateTime?**|  | 
 **endDatetime** | **DateTime?**|  | 

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="balanceexposure"></a>
# **BalanceExposure**
> InlineResponse20018 BalanceExposure ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BalanceExposureExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi();

            try
            {
                InlineResponse20018 result = apiInstance.BalanceExposure();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.BalanceExposure: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20018**](InlineResponse20018.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="current"></a>
# **Current**
> InlineResponse20016 Current ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CurrentExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();

            try
            {
                InlineResponse20016 result = apiInstance.Current();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.Current: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="finance"></a>
# **Finance**
> InlineResponse20020 Finance ()



 ##  Rate limits Maximum 20 requests per 60 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FinanceExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi();

            try
            {
                InlineResponse20020 result = apiInstance.Finance();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.Finance: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20020**](InlineResponse20020.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpaymenttermsaccepted"></a>
# **GetPaymentTermsAccepted**
> InlineResponse20012 GetPaymentTermsAccepted ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPaymentTermsAcceptedExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi();

            try
            {
                InlineResponse20012 result = apiInstance.GetPaymentTermsAccepted();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetPaymentTermsAccepted: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getuser"></a>
# **GetUser**
> UserDetails GetUser ()

Get user personal information.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi();

            try
            {
                // Get user personal information.
                UserDetails result = apiInstance.GetUser();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserDetails**](UserDetails.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="passwordresetv0"></a>
# **PasswordResetV0**
> InlineResponse20025 PasswordResetV0 (string token, Body11 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PasswordResetV0Example
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var token = token_example;  // string | 
            var body = new Body11(); // Body11 | JSON Request object (optional) 

            try
            {
                InlineResponse20025 result = apiInstance.PasswordResetV0(token, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PasswordResetV0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**|  | 
 **body** | [**Body11**](Body11.md)| JSON Request object | [optional] 

### Return type

[**InlineResponse20025**](InlineResponse20025.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="passwordtokenvalidationv0"></a>
# **PasswordTokenValidationV0**
> InlineResponse20026 PasswordTokenValidationV0 (Body12 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PasswordTokenValidationV0Example
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var body = new Body12(); // Body12 | JSON Request object (optional) 

            try
            {
                InlineResponse20026 result = apiInstance.PasswordTokenValidationV0(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PasswordTokenValidationV0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body12**](Body12.md)| JSON Request object | [optional] 

### Return type

[**InlineResponse20026**](InlineResponse20026.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="pnl"></a>
# **Pnl**
> InlineResponse20028 Pnl ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PnlExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi();

            try
            {
                InlineResponse20028 result = apiInstance.Pnl();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.Pnl: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20028**](InlineResponse20028.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postpaymenttermsaccepted"></a>
# **PostPaymentTermsAccepted**
> Body1 PostPaymentTermsAccepted (Body1 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostPaymentTermsAcceptedExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi();
            var body = new Body1(); // Body1 | JSON Request object (optional) 

            try
            {
                Body1 result = apiInstance.PostPaymentTermsAccepted(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostPaymentTermsAccepted: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body1**](Body1.md)| JSON Request object | [optional] 

### Return type

[**Body1**](Body1.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="potentialwinnings"></a>
# **PotentialWinnings**
> InlineResponse20029 PotentialWinnings ()



 ##  Rate limits Maximum 20 requests per 60 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PotentialWinningsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi();

            try
            {
                InlineResponse20029 result = apiInstance.PotentialWinnings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PotentialWinnings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20029**](InlineResponse20029.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="saveaffiliateinformation"></a>
# **SaveAffiliateInformation**
> AffiliateSignup SaveAffiliateInformation (int? userId, AffiliateSignup body = null)

Save affiliate information for a newly created user.

## Description This will store in the Smarkets systems who referred the new user  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveAffiliateInformationExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var body = new AffiliateSignup(); // AffiliateSignup | JSON Request object (optional) 

            try
            {
                // Save affiliate information for a newly created user.
                AffiliateSignup result = apiInstance.SaveAffiliateInformation(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SaveAffiliateInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **body** | [**AffiliateSignup**](AffiliateSignup.md)| JSON Request object | [optional] 

### Return type

[**AffiliateSignup**](AffiliateSignup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="sendpasswordresetemailv0"></a>
# **SendPasswordResetEmailV0**
> Object SendPasswordResetEmailV0 (Body10 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendPasswordResetEmailV0Example
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var body = new Body10(); // Body10 | JSON Request object (optional) 

            try
            {
                Object result = apiInstance.SendPasswordResetEmailV0(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SendPasswordResetEmailV0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body10**](Body10.md)| JSON Request object | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="signup"></a>
# **Signup**
> UserDetails Signup (UsersSignup body = null)

Create a new member, an account for selected currency (User service).

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
    public class SignupExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var body = new UsersSignup(); // UsersSignup | JSON Request object (optional) 

            try
            {
                // Create a new member, an account for selected currency (User service).
                UserDetails result = apiInstance.Signup(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.Signup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UsersSignup**](UsersSignup.md)| JSON Request object | [optional] 

### Return type

[**UserDetails**](UserDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="userwithoutrate"></a>
# **UserWithoutRate**
> InlineResponse20021 UserWithoutRate ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserWithoutRateExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();

            try
            {
                InlineResponse20021 result = apiInstance.UserWithoutRate();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UserWithoutRate: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20021**](InlineResponse20021.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
