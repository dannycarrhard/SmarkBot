# IO.Swagger.Api.MfaApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSecret**](MfaApi.md#createsecret) | **POST** /v3/mfa/secrets/ | Create an MFA (Multi Factor Authentication) secret.
[**CreateSecretV0**](MfaApi.md#createsecretv0) | **POST** /v0/mfa/secrets/ | 
[**GenerateBackupCodes**](MfaApi.md#generatebackupcodes) | **POST** /v3/mfa/backup_codes/ | Generate New MFA Backup Codes (invalidates old codes).
[**GetBackupCodes**](MfaApi.md#getbackupcodes) | **GET** /v3/mfa/backup_codes/ | Get MFA Backup Codes.
[**IsMfaEnabled**](MfaApi.md#ismfaenabled) | **GET** /v3/mfa/ | Check if MFA is enabled.
[**IsMfaEnabledV0**](MfaApi.md#ismfaenabledv0) | **GET** /v0/mfa/ | 
[**TurnOffMfa**](MfaApi.md#turnoffmfa) | **DELETE** /v3/mfa/ | Turn off MFA.
[**TurnOffMfaV0**](MfaApi.md#turnoffmfav0) | **DELETE** /v0/mfa/ | 
[**TurnOnMfa**](MfaApi.md#turnonmfa) | **POST** /v3/mfa/ | Turn on MFA.
[**TurnOnMfaV0**](MfaApi.md#turnonmfav0) | **POST** /v0/mfa/ | 

<a name="createsecret"></a>
# **CreateSecret**
> InlineResponse2013 CreateSecret ()

Create an MFA (Multi Factor Authentication) secret.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSecretExample
    {
        public void main()
        {
            var apiInstance = new MfaApi();

            try
            {
                // Create an MFA (Multi Factor Authentication) secret.
                InlineResponse2013 result = apiInstance.CreateSecret();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MfaApi.CreateSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2013**](InlineResponse2013.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createsecretv0"></a>
# **CreateSecretV0**
> InlineResponse201 CreateSecretV0 ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSecretV0Example
    {
        public void main()
        {
            var apiInstance = new MfaApi();

            try
            {
                InlineResponse201 result = apiInstance.CreateSecretV0();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MfaApi.CreateSecretV0: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="generatebackupcodes"></a>
# **GenerateBackupCodes**
> InlineResponse20044 GenerateBackupCodes ()

Generate New MFA Backup Codes (invalidates old codes).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GenerateBackupCodesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MfaApi();

            try
            {
                // Generate New MFA Backup Codes (invalidates old codes).
                InlineResponse20044 result = apiInstance.GenerateBackupCodes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MfaApi.GenerateBackupCodes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20044**](InlineResponse20044.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbackupcodes"></a>
# **GetBackupCodes**
> InlineResponse20044 GetBackupCodes ()

Get MFA Backup Codes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBackupCodesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MfaApi();

            try
            {
                // Get MFA Backup Codes.
                InlineResponse20044 result = apiInstance.GetBackupCodes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MfaApi.GetBackupCodes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20044**](InlineResponse20044.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="ismfaenabled"></a>
# **IsMfaEnabled**
> InlineResponse20043 IsMfaEnabled ()

Check if MFA is enabled.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IsMfaEnabledExample
    {
        public void main()
        {
            var apiInstance = new MfaApi();

            try
            {
                // Check if MFA is enabled.
                InlineResponse20043 result = apiInstance.IsMfaEnabled();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MfaApi.IsMfaEnabled: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20043**](InlineResponse20043.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="ismfaenabledv0"></a>
# **IsMfaEnabledV0**
> InlineResponse2009 IsMfaEnabledV0 ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IsMfaEnabledV0Example
    {
        public void main()
        {
            var apiInstance = new MfaApi();

            try
            {
                InlineResponse2009 result = apiInstance.IsMfaEnabledV0();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MfaApi.IsMfaEnabledV0: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="turnoffmfa"></a>
# **TurnOffMfa**
> Object TurnOffMfa ()

Turn off MFA.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TurnOffMfaExample
    {
        public void main()
        {
            var apiInstance = new MfaApi();

            try
            {
                // Turn off MFA.
                Object result = apiInstance.TurnOffMfa();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MfaApi.TurnOffMfa: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="turnoffmfav0"></a>
# **TurnOffMfaV0**
> Object TurnOffMfaV0 ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TurnOffMfaV0Example
    {
        public void main()
        {
            var apiInstance = new MfaApi();

            try
            {
                Object result = apiInstance.TurnOffMfaV0();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MfaApi.TurnOffMfaV0: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="turnonmfa"></a>
# **TurnOnMfa**
> Body32 TurnOnMfa (Body32 body = null)

Turn on MFA.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TurnOnMfaExample
    {
        public void main()
        {
            var apiInstance = new MfaApi();
            var body = new Body32(); // Body32 | JSON Request object (optional) 

            try
            {
                // Turn on MFA.
                Body32 result = apiInstance.TurnOnMfa(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MfaApi.TurnOnMfa: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body32**](Body32.md)| JSON Request object | [optional] 

### Return type

[**Body32**](Body32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="turnonmfav0"></a>
# **TurnOnMfaV0**
> Object TurnOnMfaV0 (Body body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TurnOnMfaV0Example
    {
        public void main()
        {
            var apiInstance = new MfaApi();
            var body = new Body(); // Body | JSON Request object (optional) 

            try
            {
                Object result = apiInstance.TurnOnMfaV0(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MfaApi.TurnOnMfaV0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)| JSON Request object | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
