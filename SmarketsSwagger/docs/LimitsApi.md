# IO.Swagger.Api.LimitsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AcknowledgeResponsibleGambling**](LimitsApi.md#acknowledgeresponsiblegambling) | **POST** /v3/responsible_gambling/acknowledge/ | Acknowledge responsible gambling message.
[**AcknowledgeSelfExclusionPromptSeen**](LimitsApi.md#acknowledgeselfexclusionpromptseen) | **POST** /v3/breaks/self_exclusion_prompt_required/ | 
[**DeleteLimits**](LimitsApi.md#deletelimits) | **DELETE** /v3/{limit_type}_limits/ |      DELETE Limits with specified type and status.
[**DeleteLimits_0**](LimitsApi.md#deletelimits_0) | **DELETE** /v3/{limit_type}_limits/intervals/{interval}/ |      DELETE Limits with specified type and status.
[**GetLimits**](LimitsApi.md#getlimits) | **GET** /v3/{limit_type}_limits/ |      GET Limits associated with your account.
[**GetResponsibleGamblingStatus**](LimitsApi.md#getresponsiblegamblingstatus) | **GET** /v3/responsible_gambling/ | Retrieve responsible gambling status.
[**GetSelfExclusionPromptSeen**](LimitsApi.md#getselfexclusionpromptseen) | **GET** /v3/breaks/self_exclusion_prompt_required/ | 
[**PatchLimits**](LimitsApi.md#patchlimits) | **PATCH** /v3/{limit_type}_limits/ |      PATCH limit.
[**PatchLimits_0**](LimitsApi.md#patchlimits_0) | **PATCH** /v3/{limit_type}_limits/intervals/{interval}/ |      PATCH limit.
[**PostBreak**](LimitsApi.md#postbreak) | **POST** /v3/breaks/ |      POST Break.
[**PostDepositLimits**](LimitsApi.md#postdepositlimits) | **POST** /v3/deposit_limits/ |      POST Limit for your account.
[**PostLossLimits**](LimitsApi.md#postlosslimits) | **POST** /v3/loss_limits/ |      POST Limit for your account.
[**PostSessionLimit**](LimitsApi.md#postsessionlimit) | **POST** /v3/session_limits/ |      POST Session Limit for your account.
[**PostStakeLimit**](LimitsApi.md#poststakelimit) | **POST** /v3/stake_limits/ |      POST Stake Limit for your account.
[**ProcessGamblingSelfTest**](LimitsApi.md#processgamblingselftest) | **POST** /v3/gambling_self_test/ | 

<a name="acknowledgeresponsiblegambling"></a>
# **AcknowledgeResponsibleGambling**
> ResponsibleGamblingAcknowledgeResponse AcknowledgeResponsibleGambling ()

Acknowledge responsible gambling message.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AcknowledgeResponsibleGamblingExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LimitsApi();

            try
            {
                // Acknowledge responsible gambling message.
                ResponsibleGamblingAcknowledgeResponse result = apiInstance.AcknowledgeResponsibleGambling();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LimitsApi.AcknowledgeResponsibleGambling: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ResponsibleGamblingAcknowledgeResponse**](ResponsibleGamblingAcknowledgeResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="acknowledgeselfexclusionpromptseen"></a>
# **AcknowledgeSelfExclusionPromptSeen**
> InlineResponse20035 AcknowledgeSelfExclusionPromptSeen ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AcknowledgeSelfExclusionPromptSeenExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LimitsApi();

            try
            {
                InlineResponse20035 result = apiInstance.AcknowledgeSelfExclusionPromptSeen();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LimitsApi.AcknowledgeSelfExclusionPromptSeen: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20035**](InlineResponse20035.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletelimits"></a>
# **DeleteLimits**
> LimitResponse DeleteLimits (string limitType, string status = null)

     DELETE Limits with specified type and status.

## Description Returns all remaining limits.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteLimitsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LimitsApi();
            var limitType = limitType_example;  // string | 
            var status = status_example;  // string |  (optional) 

            try
            {
                //      DELETE Limits with specified type and status.
                LimitResponse result = apiInstance.DeleteLimits(limitType, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LimitsApi.DeleteLimits: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limitType** | **string**|  | 
 **status** | **string**|  | [optional] 

### Return type

[**LimitResponse**](LimitResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletelimits_0"></a>
# **DeleteLimits_0**
> LimitResponse DeleteLimits_0 (string limitType, string interval, string status = null)

     DELETE Limits with specified type and status.

## Description Returns all remaining limits.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteLimits_0Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LimitsApi();
            var limitType = limitType_example;  // string | 
            var interval = interval_example;  // string | 
            var status = status_example;  // string |  (optional) 

            try
            {
                //      DELETE Limits with specified type and status.
                LimitResponse result = apiInstance.DeleteLimits_0(limitType, interval, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LimitsApi.DeleteLimits_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limitType** | **string**|  | 
 **interval** | **string**|  | 
 **status** | **string**|  | [optional] 

### Return type

[**LimitResponse**](LimitResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlimits"></a>
# **GetLimits**
> LimitResponse GetLimits (string limitType)

     GET Limits associated with your account.

## Description A limit is a limit of some activity (losing money, depositing), that has maximum allowance in a certain period of time (yearly, monthly, weekly, daily).  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLimitsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LimitsApi();
            var limitType = limitType_example;  // string | 

            try
            {
                //      GET Limits associated with your account.
                LimitResponse result = apiInstance.GetLimits(limitType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LimitsApi.GetLimits: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limitType** | **string**|  | 

### Return type

[**LimitResponse**](LimitResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getresponsiblegamblingstatus"></a>
# **GetResponsibleGamblingStatus**
> ResponsibleGamblingStatusResponse GetResponsibleGamblingStatus ()

Retrieve responsible gambling status.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetResponsibleGamblingStatusExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LimitsApi();

            try
            {
                // Retrieve responsible gambling status.
                ResponsibleGamblingStatusResponse result = apiInstance.GetResponsibleGamblingStatus();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LimitsApi.GetResponsibleGamblingStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ResponsibleGamblingStatusResponse**](ResponsibleGamblingStatusResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getselfexclusionpromptseen"></a>
# **GetSelfExclusionPromptSeen**
> InlineResponse20035 GetSelfExclusionPromptSeen ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSelfExclusionPromptSeenExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LimitsApi();

            try
            {
                InlineResponse20035 result = apiInstance.GetSelfExclusionPromptSeen();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LimitsApi.GetSelfExclusionPromptSeen: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20035**](InlineResponse20035.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchlimits"></a>
# **PatchLimits**
> LimitResponse PatchLimits (string limitType, Body61 body = null)

     PATCH limit.

## Description This should only be used to change the status from queued to active.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchLimitsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LimitsApi();
            var limitType = limitType_example;  // string | 
            var body = new Body61(); // Body61 | JSON Request object (optional) 

            try
            {
                //      PATCH limit.
                LimitResponse result = apiInstance.PatchLimits(limitType, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LimitsApi.PatchLimits: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limitType** | **string**|  | 
 **body** | [**Body61**](Body61.md)| JSON Request object | [optional] 

### Return type

[**LimitResponse**](LimitResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchlimits_0"></a>
# **PatchLimits_0**
> LimitResponse PatchLimits_0 (string limitType, string interval, Body62 body = null)

     PATCH limit.

## Description This should only be used to change the status from queued to active.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchLimits_0Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LimitsApi();
            var limitType = limitType_example;  // string | 
            var interval = interval_example;  // string | 
            var body = new Body62(); // Body62 | JSON Request object (optional) 

            try
            {
                //      PATCH limit.
                LimitResponse result = apiInstance.PatchLimits_0(limitType, interval, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LimitsApi.PatchLimits_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limitType** | **string**|  | 
 **interval** | **string**|  | 
 **body** | [**Body62**](Body62.md)| JSON Request object | [optional] 

### Return type

[**LimitResponse**](LimitResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postbreak"></a>
# **PostBreak**
> BreakResponse PostBreak (ModelBreak body = null)

     POST Break.

## Description A timeout is an opt-in, temporary break from betting on Smarkets. You can choose a timeout period of 1, 7, 31, or 42 days. During this time the user will not be able to bet or use the Smarkets site. When the timeout expires their account will automatically be reopened.  A self exclusion will lock your account for a minimum of six months. Once the chosen time period has elapsed, the user must request to reopen their account.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostBreakExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LimitsApi();
            var body = new ModelBreak(); // ModelBreak | JSON Request object (optional) 

            try
            {
                //      POST Break.
                BreakResponse result = apiInstance.PostBreak(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LimitsApi.PostBreak: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ModelBreak**](ModelBreak.md)| JSON Request object | [optional] 

### Return type

[**BreakResponse**](BreakResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postdepositlimits"></a>
# **PostDepositLimits**
> LimitResponse PostDepositLimits (Body26 body = null)

     POST Limit for your account.

## Description A list of all your limits will be returned.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostDepositLimitsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LimitsApi();
            var body = new Body26(); // Body26 | JSON Request object (optional) 

            try
            {
                //      POST Limit for your account.
                LimitResponse result = apiInstance.PostDepositLimits(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LimitsApi.PostDepositLimits: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body26**](Body26.md)| JSON Request object | [optional] 

### Return type

[**LimitResponse**](LimitResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postlosslimits"></a>
# **PostLossLimits**
> LimitResponse PostLossLimits (Body31 body = null)

     POST Limit for your account.

## Description A list of all your limits will be returned.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostLossLimitsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LimitsApi();
            var body = new Body31(); // Body31 | JSON Request object (optional) 

            try
            {
                //      POST Limit for your account.
                LimitResponse result = apiInstance.PostLossLimits(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LimitsApi.PostLossLimits: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body31**](Body31.md)| JSON Request object | [optional] 

### Return type

[**LimitResponse**](LimitResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postsessionlimit"></a>
# **PostSessionLimit**
> LimitResponse PostSessionLimit (Body51 body = null)

     POST Session Limit for your account.

## Description A list of all your limits will be returned.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostSessionLimitExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LimitsApi();
            var body = new Body51(); // Body51 | JSON Request object (optional) 

            try
            {
                //      POST Session Limit for your account.
                LimitResponse result = apiInstance.PostSessionLimit(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LimitsApi.PostSessionLimit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body51**](Body51.md)| JSON Request object | [optional] 

### Return type

[**LimitResponse**](LimitResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="poststakelimit"></a>
# **PostStakeLimit**
> LimitResponse PostStakeLimit (Body54 body = null)

     POST Stake Limit for your account.

## Description A list of all your limits will be returned.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostStakeLimitExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LimitsApi();
            var body = new Body54(); // Body54 | JSON Request object (optional) 

            try
            {
                //      POST Stake Limit for your account.
                LimitResponse result = apiInstance.PostStakeLimit(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LimitsApi.PostStakeLimit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body54**](Body54.md)| JSON Request object | [optional] 

### Return type

[**LimitResponse**](LimitResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="processgamblingselftest"></a>
# **ProcessGamblingSelfTest**
> GamblingSelfTestResponse ProcessGamblingSelfTest (GamblingSelfTestRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProcessGamblingSelfTestExample
    {
        public void main()
        {
            var apiInstance = new LimitsApi();
            var body = new GamblingSelfTestRequest(); // GamblingSelfTestRequest | JSON Request object (optional) 

            try
            {
                GamblingSelfTestResponse result = apiInstance.ProcessGamblingSelfTest(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LimitsApi.ProcessGamblingSelfTest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GamblingSelfTestRequest**](GamblingSelfTestRequest.md)| JSON Request object | [optional] 

### Return type

[**GamblingSelfTestResponse**](GamblingSelfTestResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
