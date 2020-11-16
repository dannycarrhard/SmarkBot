# IO.Swagger.Api.SessionsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfirmNewLogin**](SessionsApi.md#confirmnewlogin) | **POST** /v3/verified_logins/ | Confirm new login from a different country.
[**CreateSession**](SessionsApi.md#createsession) | **POST** /v3/sessions/ | Login using this route.
[**CreateSessionV0**](SessionsApi.md#createsessionv0) | **POST** /v0/sessions/ | 
[**DeleteCurrentSession**](SessionsApi.md#deletecurrentsession) | **DELETE** /v3/sessions/ | Logout from the current session.
[**DeleteSession**](SessionsApi.md#deletesession) | **DELETE** /v0/sessions/current/ | 
[**LoginNemid**](SessionsApi.md#loginnemid) | **POST** /v3/sessions/nemid/ | Login route for Danish customers using NemID.
[**LoginNemidV0**](SessionsApi.md#loginnemidv0) | **POST** /v0/sessions/nemid/ | 
[**RenewSession**](SessionsApi.md#renewsession) | **POST** /v3/sessions/renew/ | Renew the token presented.
[**UpdateExpiredSession**](SessionsApi.md#updateexpiredsession) | **POST** /v3/sessions/reauth/ | Re-authenticate an expired session.
[**UpdateExpiredSessionV0**](SessionsApi.md#updateexpiredsessionv0) | **POST** /v0/sessions/current/ | 
[**UpdateSession**](SessionsApi.md#updatesession) | **PUT** /v3/sessions/current/ | Verify that the session token is valid.
[**UpdateSessionV0**](SessionsApi.md#updatesessionv0) | **PUT** /v0/sessions/current/ | 
[**Verify**](SessionsApi.md#verify) | **POST** /v3/sessions/verify/ | Verify login step for multi factor authentication (MFA).
[**VerifyV0**](SessionsApi.md#verifyv0) | **POST** /v0/sessions/verify/ | 

<a name="confirmnewlogin"></a>
# **ConfirmNewLogin**
> InlineResponse20067 ConfirmNewLogin (Body59 body = null)

Confirm new login from a different country.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConfirmNewLoginExample
    {
        public void main()
        {
            var apiInstance = new SessionsApi();
            var body = new Body59(); // Body59 | JSON Request object (optional) 

            try
            {
                // Confirm new login from a different country.
                InlineResponse20067 result = apiInstance.ConfirmNewLogin(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.ConfirmNewLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body59**](Body59.md)| JSON Request object | [optional] 

### Return type

[**InlineResponse20067**](InlineResponse20067.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createsession"></a>
# **CreateSession**
> TokenResponse CreateSession (SessionCreate body = null)

Login using this route.

## Description This will return a token that can be used in the Authentication header in the form \"Session Token <your_token>\" on authenticated requests.<br> The token is valid for 30min, but if you make an authenticated request with it, it will be renewed for the next 30min.  ##  Rate limits Maximum 10 requests per 60 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSessionExample
    {
        public void main()
        {
            var apiInstance = new SessionsApi();
            var body = new SessionCreate(); // SessionCreate | JSON Request object (optional) 

            try
            {
                // Login using this route.
                TokenResponse result = apiInstance.CreateSession(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.CreateSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SessionCreate**](SessionCreate.md)| JSON Request object | [optional] 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createsessionv0"></a>
# **CreateSessionV0**
> TokenResponse CreateSessionV0 (Body2 body = null)



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
    public class CreateSessionV0Example
    {
        public void main()
        {
            var apiInstance = new SessionsApi();
            var body = new Body2(); // Body2 | JSON Request object (optional) 

            try
            {
                TokenResponse result = apiInstance.CreateSessionV0(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.CreateSessionV0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body2**](Body2.md)| JSON Request object | [optional] 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecurrentsession"></a>
# **DeleteCurrentSession**
> SessionDeleteStatus DeleteCurrentSession ()

Logout from the current session.

 ##  Rate limits Maximum 30 requests per 60 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCurrentSessionExample
    {
        public void main()
        {
            var apiInstance = new SessionsApi();

            try
            {
                // Logout from the current session.
                SessionDeleteStatus result = apiInstance.DeleteCurrentSession();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.DeleteCurrentSession: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SessionDeleteStatus**](SessionDeleteStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletesession"></a>
# **DeleteSession**
> InlineResponse20014 DeleteSession ()



 ##  Rate limits Maximum 30 requests per 60 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSessionExample
    {
        public void main()
        {
            var apiInstance = new SessionsApi();

            try
            {
                InlineResponse20014 result = apiInstance.DeleteSession();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.DeleteSession: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="loginnemid"></a>
# **LoginNemid**
> TokenResponse LoginNemid (NemidLogin body = null)

Login route for Danish customers using NemID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoginNemidExample
    {
        public void main()
        {
            var apiInstance = new SessionsApi();
            var body = new NemidLogin(); // NemidLogin | JSON Request object (optional) 

            try
            {
                // Login route for Danish customers using NemID.
                TokenResponse result = apiInstance.LoginNemid(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.LoginNemid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NemidLogin**](NemidLogin.md)| JSON Request object | [optional] 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="loginnemidv0"></a>
# **LoginNemidV0**
> TokenResponse LoginNemidV0 (Body3 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoginNemidV0Example
    {
        public void main()
        {
            var apiInstance = new SessionsApi();
            var body = new Body3(); // Body3 | JSON Request object (optional) 

            try
            {
                TokenResponse result = apiInstance.LoginNemidV0(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.LoginNemidV0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body3**](Body3.md)| JSON Request object | [optional] 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renewsession"></a>
# **RenewSession**
> SessionRenewStatus RenewSession (SessionRenew body = null)

Renew the token presented.

 ##  Rate limits Maximum 30 requests per 60 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RenewSessionExample
    {
        public void main()
        {
            var apiInstance = new SessionsApi();
            var body = new SessionRenew(); // SessionRenew | JSON Request object (optional) 

            try
            {
                // Renew the token presented.
                SessionRenewStatus result = apiInstance.RenewSession(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.RenewSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SessionRenew**](SessionRenew.md)| JSON Request object | [optional] 

### Return type

[**SessionRenewStatus**](SessionRenewStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateexpiredsession"></a>
# **UpdateExpiredSession**
> SessionUpdateStatus UpdateExpiredSession ()

Re-authenticate an expired session.

 ##  Rate limits Maximum 30 requests per 60 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateExpiredSessionExample
    {
        public void main()
        {
            var apiInstance = new SessionsApi();

            try
            {
                // Re-authenticate an expired session.
                SessionUpdateStatus result = apiInstance.UpdateExpiredSession();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.UpdateExpiredSession: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SessionUpdateStatus**](SessionUpdateStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateexpiredsessionv0"></a>
# **UpdateExpiredSessionV0**
> InlineResponse20015 UpdateExpiredSessionV0 ()



 ##  Rate limits Maximum 30 requests per 60 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateExpiredSessionV0Example
    {
        public void main()
        {
            var apiInstance = new SessionsApi();

            try
            {
                InlineResponse20015 result = apiInstance.UpdateExpiredSessionV0();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.UpdateExpiredSessionV0: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatesession"></a>
# **UpdateSession**
> SessionUpdateStatusUpdated UpdateSession ()

Verify that the session token is valid.

 ##  Rate limits Maximum 30 requests per 60 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateSessionExample
    {
        public void main()
        {
            var apiInstance = new SessionsApi();

            try
            {
                // Verify that the session token is valid.
                SessionUpdateStatusUpdated result = apiInstance.UpdateSession();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.UpdateSession: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SessionUpdateStatusUpdated**](SessionUpdateStatusUpdated.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatesessionv0"></a>
# **UpdateSessionV0**
> InlineResponse20014 UpdateSessionV0 ()



 ##  Rate limits Maximum 30 requests per 60 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateSessionV0Example
    {
        public void main()
        {
            var apiInstance = new SessionsApi();

            try
            {
                InlineResponse20014 result = apiInstance.UpdateSessionV0();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.UpdateSessionV0: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="verify"></a>
# **Verify**
> TokenResponse Verify (TotpLogin body = null)

Verify login step for multi factor authentication (MFA).

## Description To enable MFA on a Smarkets account:<br>  - Go to <a href=\"https://smarkets.com/account/settings/login\">login settings</a> and click \"Enable Two-Factor Authentication\"<br>  - Copy the secret into your TOTP library<br>  - Generate one code using it and paste it in the dialog<br>  - Click \"Enable Two-Factor Authentication\"<br>  Every time you login: <br>  - Make a POST request to /v3/sessions/ to get a token<br>  - Make a POST request to this route with the token and the code generated by you to complete the login<br>   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VerifyExample
    {
        public void main()
        {
            var apiInstance = new SessionsApi();
            var body = new TotpLogin(); // TotpLogin | JSON Request object (optional) 

            try
            {
                // Verify login step for multi factor authentication (MFA).
                TokenResponse result = apiInstance.Verify(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.Verify: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TotpLogin**](TotpLogin.md)| JSON Request object | [optional] 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="verifyv0"></a>
# **VerifyV0**
> TokenResponse VerifyV0 (Body4 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VerifyV0Example
    {
        public void main()
        {
            var apiInstance = new SessionsApi();
            var body = new Body4(); // Body4 | JSON Request object (optional) 

            try
            {
                TokenResponse result = apiInstance.VerifyV0(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.VerifyV0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body4**](Body4.md)| JSON Request object | [optional] 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
