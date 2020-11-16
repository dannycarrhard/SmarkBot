# IO.Swagger.Api.FavouritesApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFavouriteEvent**](FavouritesApi.md#addfavouriteevent) | **PUT** /v3/favourites/event_ids/{event_id}/ | Add a specified event id to favourites.
[**AddFavouriteEventV0**](FavouritesApi.md#addfavouriteeventv0) | **PUT** /v0/favourites/event/{event_id}/ | 
[**ClearFavouriteEvents**](FavouritesApi.md#clearfavouriteevents) | **DELETE** /v3/favourites/event_ids/ | Remove all the event ids from favourites.
[**ClearFavouriteEventsV0**](FavouritesApi.md#clearfavouriteeventsv0) | **DELETE** /v0/favourites/events/ | 
[**GetAllFavouriteEvents**](FavouritesApi.md#getallfavouriteevents) | **GET** /v3/favourites/event_ids/all/ | Get a list of all your favourite event ids.
[**GetFavouriteEvents**](FavouritesApi.md#getfavouriteevents) | **GET** /v3/favourites/event_ids/ | Get a list of all your favourite event ids.
[**GetFavouriteEventsV0**](FavouritesApi.md#getfavouriteeventsv0) | **GET** /v0/favourites/events/ | 
[**RemoveFavouriteEvent**](FavouritesApi.md#removefavouriteevent) | **DELETE** /v3/favourites/event_ids/{event_id}/ | Remove a specified event id from favourites.
[**RemoveFavouriteEventV0**](FavouritesApi.md#removefavouriteeventv0) | **DELETE** /v0/favourites/event/{event_id}/ | 

<a name="addfavouriteevent"></a>
# **AddFavouriteEvent**
> Object AddFavouriteEvent (int? eventId)

Add a specified event id to favourites.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddFavouriteEventExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FavouritesApi();
            var eventId = 56;  // int? | 

            try
            {
                // Add a specified event id to favourites.
                Object result = apiInstance.AddFavouriteEvent(eventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavouritesApi.AddFavouriteEvent: " + e.Message );
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
<a name="addfavouriteeventv0"></a>
# **AddFavouriteEventV0**
> InlineResponse2004 AddFavouriteEventV0 (int? eventId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddFavouriteEventV0Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FavouritesApi();
            var eventId = 56;  // int? | 

            try
            {
                InlineResponse2004 result = apiInstance.AddFavouriteEventV0(eventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavouritesApi.AddFavouriteEventV0: " + e.Message );
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

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="clearfavouriteevents"></a>
# **ClearFavouriteEvents**
> Object ClearFavouriteEvents ()

Remove all the event ids from favourites.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClearFavouriteEventsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FavouritesApi();

            try
            {
                // Remove all the event ids from favourites.
                Object result = apiInstance.ClearFavouriteEvents();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavouritesApi.ClearFavouriteEvents: " + e.Message );
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
<a name="clearfavouriteeventsv0"></a>
# **ClearFavouriteEventsV0**
> InlineResponse2004 ClearFavouriteEventsV0 ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClearFavouriteEventsV0Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FavouritesApi();

            try
            {
                InlineResponse2004 result = apiInstance.ClearFavouriteEventsV0();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavouritesApi.ClearFavouriteEventsV0: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallfavouriteevents"></a>
# **GetAllFavouriteEvents**
> AllFavouriteEventsResponse GetAllFavouriteEvents ()

Get a list of all your favourite event ids.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllFavouriteEventsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FavouritesApi();

            try
            {
                // Get a list of all your favourite event ids.
                AllFavouriteEventsResponse result = apiInstance.GetAllFavouriteEvents();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavouritesApi.GetAllFavouriteEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AllFavouriteEventsResponse**](AllFavouriteEventsResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getfavouriteevents"></a>
# **GetFavouriteEvents**
> FavouriteEventsResponse GetFavouriteEvents ()

Get a list of all your favourite event ids.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFavouriteEventsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FavouritesApi();

            try
            {
                // Get a list of all your favourite event ids.
                FavouriteEventsResponse result = apiInstance.GetFavouriteEvents();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavouritesApi.GetFavouriteEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**FavouriteEventsResponse**](FavouriteEventsResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getfavouriteeventsv0"></a>
# **GetFavouriteEventsV0**
> InlineResponse2005 GetFavouriteEventsV0 ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFavouriteEventsV0Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FavouritesApi();

            try
            {
                InlineResponse2005 result = apiInstance.GetFavouriteEventsV0();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavouritesApi.GetFavouriteEventsV0: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removefavouriteevent"></a>
# **RemoveFavouriteEvent**
> Object RemoveFavouriteEvent (int? eventId)

Remove a specified event id from favourites.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveFavouriteEventExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FavouritesApi();
            var eventId = 56;  // int? | 

            try
            {
                // Remove a specified event id from favourites.
                Object result = apiInstance.RemoveFavouriteEvent(eventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavouritesApi.RemoveFavouriteEvent: " + e.Message );
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
<a name="removefavouriteeventv0"></a>
# **RemoveFavouriteEventV0**
> InlineResponse2004 RemoveFavouriteEventV0 (int? eventId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveFavouriteEventV0Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FavouritesApi();
            var eventId = 56;  // int? | 

            try
            {
                InlineResponse2004 result = apiInstance.RemoveFavouriteEventV0(eventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavouritesApi.RemoveFavouriteEventV0: " + e.Message );
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

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
