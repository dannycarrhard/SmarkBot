# IO.Swagger.Api.TicketsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFeedback**](TicketsApi.md#createfeedback) | **POST** /v3/feedback/ | Post feedback ticket.
[**Helpful**](TicketsApi.md#helpful) | **PUT** /v0/tickets/entry/{token}/helpful/ | 
[**UpdateHelpful**](TicketsApi.md#updatehelpful) | **PUT** /v3/tickets/ | Update feedback on a ticket.

<a name="createfeedback"></a>
# **CreateFeedback**
> Object CreateFeedback (PostTicketsRequest body = null)

Post feedback ticket.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateFeedbackExample
    {
        public void main()
        {
            var apiInstance = new TicketsApi();
            var body = new PostTicketsRequest(); // PostTicketsRequest | JSON Request object (optional) 

            try
            {
                // Post feedback ticket.
                Object result = apiInstance.CreateFeedback(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TicketsApi.CreateFeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostTicketsRequest**](PostTicketsRequest.md)| JSON Request object | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="helpful"></a>
# **Helpful**
> Object Helpful (string token, Body5 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HelpfulExample
    {
        public void main()
        {
            var apiInstance = new TicketsApi();
            var token = token_example;  // string | 
            var body = new Body5(); // Body5 | JSON Request object (optional) 

            try
            {
                Object result = apiInstance.Helpful(token, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TicketsApi.Helpful: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**|  | 
 **body** | [**Body5**](Body5.md)| JSON Request object | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatehelpful"></a>
# **UpdateHelpful**
> Object UpdateHelpful (Body55 body = null)

Update feedback on a ticket.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateHelpfulExample
    {
        public void main()
        {
            var apiInstance = new TicketsApi();
            var body = new Body55(); // Body55 | JSON Request object (optional) 

            try
            {
                // Update feedback on a ticket.
                Object result = apiInstance.UpdateHelpful(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TicketsApi.UpdateHelpful: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body55**](Body55.md)| JSON Request object | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
