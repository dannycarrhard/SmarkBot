# IO.Swagger.Api.RoutesApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Openapi**](RoutesApi.md#openapi) | **GET** /v0/control/openapi/ | OpenAPI version 2.0 format documentation of routes.
[**Ping**](RoutesApi.md#ping) | **GET** /v0/control/ping/ | Health checking ping.
[**Sentry**](RoutesApi.md#sentry) | **POST** /v0/control/sentry/ | Manually test that exceptions reach sentry.
[**Version**](RoutesApi.md#version) | **GET** /v0/control/version/ | Return the running version from the GIT_COMMIT environment variable.

<a name="openapi"></a>
# **Openapi**
> void Openapi (List<string> tags = null)

OpenAPI version 2.0 format documentation of routes.

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
    public class OpenapiExample
    {
        public void main()
        {
            var apiInstance = new RoutesApi();
            var tags = new List<string>(); // List<string> |  (optional) 

            try
            {
                // OpenAPI version 2.0 format documentation of routes.
                apiInstance.Openapi(tags);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutesApi.Openapi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tags** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="ping"></a>
# **Ping**
> InlineResponse2001 Ping ()

Health checking ping.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PingExample
    {
        public void main()
        {
            var apiInstance = new RoutesApi();

            try
            {
                // Health checking ping.
                InlineResponse2001 result = apiInstance.Ping();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutesApi.Ping: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="sentry"></a>
# **Sentry**
> void Sentry ()

Manually test that exceptions reach sentry.

 ##  Rate limits Maximum 2 requests per 60 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SentryExample
    {
        public void main()
        {
            var apiInstance = new RoutesApi();

            try
            {
                // Manually test that exceptions reach sentry.
                apiInstance.Sentry();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutesApi.Sentry: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="version"></a>
# **Version**
> InlineResponse2002 Version ()

Return the running version from the GIT_COMMIT environment variable.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VersionExample
    {
        public void main()
        {
            var apiInstance = new RoutesApi();

            try
            {
                // Return the running version from the GIT_COMMIT environment variable.
                InlineResponse2002 result = apiInstance.Version();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutesApi.Version: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
