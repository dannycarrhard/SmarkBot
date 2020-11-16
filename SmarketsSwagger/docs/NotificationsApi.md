# IO.Swagger.Api.NotificationsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddEventSubscription**](NotificationsApi.md#addeventsubscription) | **POST** /v3/notifications/subscriptions/{event_id}/ | Add event notification subscriptions.
[**CreateRegistration**](NotificationsApi.md#createregistration) | **POST** /v3/notifications/registrations/ | Add registration id provided by firebase to member.
[**DeleteEventSubscriptions**](NotificationsApi.md#deleteeventsubscriptions) | **DELETE** /v3/notifications/subscriptions/{event_id}/ | Delete event notification subscriptions.
[**DeleteRegistration**](NotificationsApi.md#deleteregistration) | **DELETE** /v3/notifications/registrations/{registration_id}/ | Delete registration from the notifications service.
[**GetEventSubscriptions**](NotificationsApi.md#geteventsubscriptions) | **GET** /v3/notifications/subscriptions/{event_ids}/ | Get event notification subscriptions.
[**GetSubscriptions**](NotificationsApi.md#getsubscriptions) | **GET** /v3/notifications/subscriptions/ | Get notification subscriptions.
[**SendSampleNotification**](NotificationsApi.md#sendsamplenotification) | **POST** /v3/notifications/send_sample/ | Send sample notification to showcase it to customer.
[**SendTestNotification**](NotificationsApi.md#sendtestnotification) | **POST** /v3/notifications/send_test/{registration_id}/ | Send sample notification to showcase it to customer.
[**UpdateEventSubscriptions**](NotificationsApi.md#updateeventsubscriptions) | **PATCH** /v3/notifications/subscriptions/{event_id}/ | Update notification subscriptions.
[**UpdateSubscriptions**](NotificationsApi.md#updatesubscriptions) | **PATCH** /v3/notifications/subscriptions/ | Update notification subscriptions.

<a name="addeventsubscription"></a>
# **AddEventSubscription**
> Object AddEventSubscription (int? eventId)

Add event notification subscriptions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddEventSubscriptionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotificationsApi();
            var eventId = 56;  // int? | 

            try
            {
                // Add event notification subscriptions.
                Object result = apiInstance.AddEventSubscription(eventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.AddEventSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **int?**|  | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createregistration"></a>
# **CreateRegistration**
> Object CreateRegistration (Body35 body = null)

Add registration id provided by firebase to member.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRegistrationExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotificationsApi();
            var body = new Body35(); // Body35 | JSON Request object (optional) 

            try
            {
                // Add registration id provided by firebase to member.
                Object result = apiInstance.CreateRegistration(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.CreateRegistration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body35**](Body35.md)| JSON Request object | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteeventsubscriptions"></a>
# **DeleteEventSubscriptions**
> Object DeleteEventSubscriptions (int? eventId)

Delete event notification subscriptions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteEventSubscriptionsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotificationsApi();
            var eventId = 56;  // int? | 

            try
            {
                // Delete event notification subscriptions.
                Object result = apiInstance.DeleteEventSubscriptions(eventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.DeleteEventSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **int?**|  | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteregistration"></a>
# **DeleteRegistration**
> Object DeleteRegistration (string registrationId)

Delete registration from the notifications service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRegistrationExample
    {
        public void main()
        {
            var apiInstance = new NotificationsApi();
            var registrationId = registrationId_example;  // string | 

            try
            {
                // Delete registration from the notifications service.
                Object result = apiInstance.DeleteRegistration(registrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.DeleteRegistration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="geteventsubscriptions"></a>
# **GetEventSubscriptions**
> InlineResponse20046 GetEventSubscriptions (List<int?> eventIds)

Get event notification subscriptions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEventSubscriptionsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotificationsApi();
            var eventIds = new List<int?>(); // List<int?> | Event Ids to get subscriptions for<br>maxItems:300

            try
            {
                // Get event notification subscriptions.
                InlineResponse20046 result = apiInstance.GetEventSubscriptions(eventIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetEventSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventIds** | [**List&lt;int?&gt;**](int?.md)| Event Ids to get subscriptions for&lt;br&gt;maxItems:300 | 

### Return type

[**InlineResponse20046**](InlineResponse20046.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsubscriptions"></a>
# **GetSubscriptions**
> InlineResponse20045 GetSubscriptions ()

Get notification subscriptions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubscriptionsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotificationsApi();

            try
            {
                // Get notification subscriptions.
                InlineResponse20045 result = apiInstance.GetSubscriptions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20045**](InlineResponse20045.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="sendsamplenotification"></a>
# **SendSampleNotification**
> Object SendSampleNotification ()

Send sample notification to showcase it to customer.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendSampleNotificationExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotificationsApi();

            try
            {
                // Send sample notification to showcase it to customer.
                Object result = apiInstance.SendSampleNotification();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.SendSampleNotification: " + e.Message );
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
<a name="sendtestnotification"></a>
# **SendTestNotification**
> Object SendTestNotification (string registrationId)

Send sample notification to showcase it to customer.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendTestNotificationExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotificationsApi();
            var registrationId = registrationId_example;  // string | 

            try
            {
                // Send sample notification to showcase it to customer.
                Object result = apiInstance.SendTestNotification(registrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.SendTestNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**|  | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateeventsubscriptions"></a>
# **UpdateEventSubscriptions**
> Object UpdateEventSubscriptions (int? eventId, Body37 body = null)

Update notification subscriptions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateEventSubscriptionsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotificationsApi();
            var eventId = 56;  // int? | 
            var body = new Body37(); // Body37 | JSON Request object (optional) 

            try
            {
                // Update notification subscriptions.
                Object result = apiInstance.UpdateEventSubscriptions(eventId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.UpdateEventSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **int?**|  | 
 **body** | [**Body37**](Body37.md)| JSON Request object | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatesubscriptions"></a>
# **UpdateSubscriptions**
> Object UpdateSubscriptions (Body36 body = null)

Update notification subscriptions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateSubscriptionsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotificationsApi();
            var body = new Body36(); // Body36 | JSON Request object (optional) 

            try
            {
                // Update notification subscriptions.
                Object result = apiInstance.UpdateSubscriptions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.UpdateSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body36**](Body36.md)| JSON Request object | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
