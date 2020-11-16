# IO.Swagger.Api.ChatsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateChat**](ChatsApi.md#createchat) | **POST** /v3/chats/ | Create new chat with our customer service.
[**DeleteChat**](ChatsApi.md#deletechat) | **DELETE** /v3/chats/ | Close the current chat.
[**GetChatStatus**](ChatsApi.md#getchatstatus) | **GET** /v3/chats/status/ | Get the current status of the chat service.
[**GetMessages**](ChatsApi.md#getmessages) | **GET** /v3/chats/messages/ | Get the chat messages.
[**LoggedOutCreateChat**](ChatsApi.md#loggedoutcreatechat) | **POST** /v3/chats/logged-out/ | Create new chat with our customer service.
[**LoggedOutDeleteChat**](ChatsApi.md#loggedoutdeletechat) | **DELETE** /v3/chats/logged-out/ | Close the current chat.
[**LoggedOutGetMessages**](ChatsApi.md#loggedoutgetmessages) | **GET** /v3/chats/logged-out/messages/ | Get the chat messages.
[**LoggedOutSendMessage**](ChatsApi.md#loggedoutsendmessage) | **POST** /v3/chats/logged-out/messages/ | Send a new chat message.
[**SendMessage**](ChatsApi.md#sendmessage) | **POST** /v3/chats/messages/ | Send a new chat message.

<a name="createchat"></a>
# **CreateChat**
> Object CreateChat (Body21 body = null)

Create new chat with our customer service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateChatExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChatsApi();
            var body = new Body21(); // Body21 | JSON Request object (optional) 

            try
            {
                // Create new chat with our customer service.
                Object result = apiInstance.CreateChat(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatsApi.CreateChat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body21**](Body21.md)| JSON Request object | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletechat"></a>
# **DeleteChat**
> Object DeleteChat ()

Close the current chat.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteChatExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChatsApi();

            try
            {
                // Close the current chat.
                Object result = apiInstance.DeleteChat();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatsApi.DeleteChat: " + e.Message );
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
<a name="getchatstatus"></a>
# **GetChatStatus**
> GetOnlineResponse GetChatStatus ()

Get the current status of the chat service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChatStatusExample
    {
        public void main()
        {
            var apiInstance = new ChatsApi();

            try
            {
                // Get the current status of the chat service.
                GetOnlineResponse result = apiInstance.GetChatStatus();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatsApi.GetChatStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetOnlineResponse**](GetOnlineResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmessages"></a>
# **GetMessages**
> GetMessagesResponse GetMessages (string lastMessageId = null)

Get the chat messages.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMessagesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChatsApi();
            var lastMessageId = lastMessageId_example;  // string |  (optional) 

            try
            {
                // Get the chat messages.
                GetMessagesResponse result = apiInstance.GetMessages(lastMessageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatsApi.GetMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lastMessageId** | **string**|  | [optional] 

### Return type

[**GetMessagesResponse**](GetMessagesResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="loggedoutcreatechat"></a>
# **LoggedOutCreateChat**
> Object LoggedOutCreateChat (Body22 body = null)

Create new chat with our customer service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoggedOutCreateChatExample
    {
        public void main()
        {
            var apiInstance = new ChatsApi();
            var body = new Body22(); // Body22 | JSON Request object (optional) 

            try
            {
                // Create new chat with our customer service.
                Object result = apiInstance.LoggedOutCreateChat(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatsApi.LoggedOutCreateChat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body22**](Body22.md)| JSON Request object | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="loggedoutdeletechat"></a>
# **LoggedOutDeleteChat**
> Object LoggedOutDeleteChat (Body23 body = null)

Close the current chat.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoggedOutDeleteChatExample
    {
        public void main()
        {
            var apiInstance = new ChatsApi();
            var body = new Body23(); // Body23 | JSON Request object (optional) 

            try
            {
                // Close the current chat.
                Object result = apiInstance.LoggedOutDeleteChat(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatsApi.LoggedOutDeleteChat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body23**](Body23.md)| JSON Request object | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="loggedoutgetmessages"></a>
# **LoggedOutGetMessages**
> GetMessagesResponse LoggedOutGetMessages (string lastMessageId = null, string uniqueIdentifier = null)

Get the chat messages.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoggedOutGetMessagesExample
    {
        public void main()
        {
            var apiInstance = new ChatsApi();
            var lastMessageId = lastMessageId_example;  // string |  (optional) 
            var uniqueIdentifier = uniqueIdentifier_example;  // string |  (optional) 

            try
            {
                // Get the chat messages.
                GetMessagesResponse result = apiInstance.LoggedOutGetMessages(lastMessageId, uniqueIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatsApi.LoggedOutGetMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lastMessageId** | **string**|  | [optional] 
 **uniqueIdentifier** | **string**|  | [optional] 

### Return type

[**GetMessagesResponse**](GetMessagesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="loggedoutsendmessage"></a>
# **LoggedOutSendMessage**
> Object LoggedOutSendMessage (Body24 body = null)

Send a new chat message.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoggedOutSendMessageExample
    {
        public void main()
        {
            var apiInstance = new ChatsApi();
            var body = new Body24(); // Body24 | JSON Request object (optional) 

            try
            {
                // Send a new chat message.
                Object result = apiInstance.LoggedOutSendMessage(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatsApi.LoggedOutSendMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body24**](Body24.md)| JSON Request object | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="sendmessage"></a>
# **SendMessage**
> Object SendMessage (Body25 body = null)

Send a new chat message.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendMessageExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChatsApi();
            var body = new Body25(); // Body25 | JSON Request object (optional) 

            try
            {
                // Send a new chat message.
                Object result = apiInstance.SendMessage(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatsApi.SendMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body25**](Body25.md)| JSON Request object | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
