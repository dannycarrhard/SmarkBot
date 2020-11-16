# IO.Swagger.Api.EventsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEventStates**](EventsApi.md#geteventstates) | **GET** /v3/events/{event_ids}/states/ | Retrieve the current states for events by id.
[**GetEvents**](EventsApi.md#getevents) | **GET** /v3/events/ | Retrieve events that are available on Smarkets to bet on.
[**GetEventsByIds**](EventsApi.md#geteventsbyids) | **GET** /v3/events/{event_ids}/ | Retrieve events by their event ids.
[**GetLeagueTable**](EventsApi.md#getleaguetable) | **GET** /v3/events/{event_id}/league_table/ |      Given a smarkets competition id returns the league tables for it.
[**GetStatsMultipleEvents**](EventsApi.md#getstatsmultipleevents) | **GET** /v3/events/{event_ids}/stats/ | Retrieve stats for multiple events.

<a name="geteventstates"></a>
# **GetEventStates**
> EventStates GetEventStates (List<int?> eventIds)

Retrieve the current states for events by id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEventStatesExample
    {
        public void main()
        {
            var apiInstance = new EventsApi();
            var eventIds = new List<int?>(); // List<int?> | Event IDs to filter by<br>maxItems:300

            try
            {
                // Retrieve the current states for events by id.
                EventStates result = apiInstance.GetEventStates(eventIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.GetEventStates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventIds** | [**List&lt;int?&gt;**](int?.md)| Event IDs to filter by&lt;br&gt;maxItems:300 | 

### Return type

[**EventStates**](EventStates.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getevents"></a>
# **GetEvents**
> Events GetEvents (List<string> id = null, bool? inplayEnabled = null, List<string> state = null, List<string> type = null, List<string> typeDomain = null, List<string> typeScope = null, bool? withNewType = null, List<string> parentId = null, DateTime? startDatetimeMin = null, DateTime? startDatetimeMax = null, DateTime? lastModifiedMin = null, DateTime? lastModifiedMax = null, int? paginationLastDisplayOrder = null, DateTime? paginationLastStartDatetime = null, string paginationLastId = null, string paginationLastName = null, string sort = null, int? limit = null, bool? includeHidden = null, string jurisdiction = null)

Retrieve events that are available on Smarkets to bet on.

## Description Events in Smarkets follow a tree structure per sport, where events can have several child events, but only one parent event.<br> As an example for football, we have:<ul> <li>The root event which is the sport - Football <li>Child events which are leagues - Premier League, La Liga, etc <li>Grandchild events which are football matches - Man U vs Chelsea, ... </ul><br> <p>In the case of most sports, we have 3 levels in the tree. However, there are cases where we can have a different number.</p> <p>To identify whether an event is a leaf node in this tree, one can look at the bettable flag.</p> <p>Only leaf events can have markets, which in turn will have contracts.</p>  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEventsExample
    {
        public void main()
        {
            var apiInstance = new EventsApi();
            var id = new List<string>(); // List<string> | Event IDs to filter by (optional) 
            var inplayEnabled = true;  // bool? | True if trading will be open when the markets go live in-play (optional) 
            var state = new List<string>(); // List<string> | Event states to filter by (optional)  (default to ["new","upcoming","live"])
            var type = new List<string>(); // List<string> | Event types to filter by (optional) 
            var typeDomain = new List<string>(); // List<string> |  Allows filtering by 'domains' - a feature of the new, improved typing system for events.<br> The domain of an event denotes the category of events this event belongs to. In most cases this will be the sport (football, tennis, golf, etc) but for non-sports the domain could be politics, tv_and_entertainment, to mention some examples. If you want to use this, you might also want to opt into the new typing system (see `with_new_type`).              (optional) 
            var typeScope = new List<string>(); // List<string> |  Allows filtering by 'scopes' - a feature of the new, improved typing system for events.<br> The scope of an event denotes the kind of event you want, potential values include single_event (your typical football match, horse race, political event), outright (an event who's outcome spans multiple events), acca (an accumulator), etc.<br> If you want to use this, you might also want to opt into the new typing system (see `with_new_type`).              (optional) 
            var withNewType = true;  // bool? |  Enables a new, improved typing system for events.<br> If this flag is set to true, the format of the type field in the event response will change.<br> Users of the API are urged to make use of the new typing system, as the old typing system will be deprecated in the next version of the API. (optional)  (default to false)
            var parentId = new List<string>(); // List<string> | Filter by events with these parent IDs (optional) 
            var startDatetimeMin = 2013-10-20T19:20:30+01:00;  // DateTime? | When the event is scheduled to go live (optional) 
            var startDatetimeMax = 2013-10-20T19:20:30+01:00;  // DateTime? | When the event is scheduled to go live (optional) 
            var lastModifiedMin = 2013-10-20T19:20:30+01:00;  // DateTime? | The timestamp when any of the properties of the event was last modified (optional) 
            var lastModifiedMax = 2013-10-20T19:20:30+01:00;  // DateTime? | The timestamp when any of the properties of the event was last modified (optional) 
            var paginationLastDisplayOrder = 56;  // int? |  Display order for the last event of the previous page.<br> This parameter should be used in conjunction with sorting by display_order,... (optional) 
            var paginationLastStartDatetime = 2013-10-20T19:20:30+01:00;  // DateTime? |  Start datetime for the last event of the previous page.<br> This parameter should be used in conjunction with sorting by start_datetime (optional) 
            var paginationLastId = paginationLastId_example;  // string |  The last event id from the previous page, so we can retrieve the subsequent events.<br> This should be used in conjunction with sorting by id (optional) 
            var paginationLastName = paginationLastName_example;  // string |  The name of the last event from the previous page, so we can retrieve the subsequent events.<br> This should be used in conjunction with sorting by name (optional) 
            var sort = sort_example;  // string |  The sorting order for the resulting events.<br> It should be used in conjunction with pagination parameters.<br> The default and recommended sorting order and pagination is by event id.<br> The links to the next page returned on every request help clients navigate through all the relevant events  (optional)  (default to id)
            var limit = 56;  // int? | The number of events to retrieve in the API call (optional)  (default to 20)
            var includeHidden = true;  // bool? | Choose to include in the response events that are not visible on the website. Hidden events may not be displayed for a varied number of reasons (for example the start date is too far away). Betting is not available for hidden events. (optional)  (default to false)
            var jurisdiction = jurisdiction_example;  // string | Jurisdiction of user (optional) 

            try
            {
                // Retrieve events that are available on Smarkets to bet on.
                Events result = apiInstance.GetEvents(id, inplayEnabled, state, type, typeDomain, typeScope, withNewType, parentId, startDatetimeMin, startDatetimeMax, lastModifiedMin, lastModifiedMax, paginationLastDisplayOrder, paginationLastStartDatetime, paginationLastId, paginationLastName, sort, limit, includeHidden, jurisdiction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.GetEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;string&gt;**](string.md)| Event IDs to filter by | [optional] 
 **inplayEnabled** | **bool?**| True if trading will be open when the markets go live in-play | [optional] 
 **state** | [**List&lt;string&gt;**](string.md)| Event states to filter by | [optional] [default to [&quot;new&quot;,&quot;upcoming&quot;,&quot;live&quot;]]
 **type** | [**List&lt;string&gt;**](string.md)| Event types to filter by | [optional] 
 **typeDomain** | [**List&lt;string&gt;**](string.md)|  Allows filtering by &#x27;domains&#x27; - a feature of the new, improved typing system for events.&lt;br&gt; The domain of an event denotes the category of events this event belongs to. In most cases this will be the sport (football, tennis, golf, etc) but for non-sports the domain could be politics, tv_and_entertainment, to mention some examples. If you want to use this, you might also want to opt into the new typing system (see &#x60;with_new_type&#x60;).              | [optional] 
 **typeScope** | [**List&lt;string&gt;**](string.md)|  Allows filtering by &#x27;scopes&#x27; - a feature of the new, improved typing system for events.&lt;br&gt; The scope of an event denotes the kind of event you want, potential values include single_event (your typical football match, horse race, political event), outright (an event who&#x27;s outcome spans multiple events), acca (an accumulator), etc.&lt;br&gt; If you want to use this, you might also want to opt into the new typing system (see &#x60;with_new_type&#x60;).              | [optional] 
 **withNewType** | **bool?**|  Enables a new, improved typing system for events.&lt;br&gt; If this flag is set to true, the format of the type field in the event response will change.&lt;br&gt; Users of the API are urged to make use of the new typing system, as the old typing system will be deprecated in the next version of the API. | [optional] [default to false]
 **parentId** | [**List&lt;string&gt;**](string.md)| Filter by events with these parent IDs | [optional] 
 **startDatetimeMin** | **DateTime?**| When the event is scheduled to go live | [optional] 
 **startDatetimeMax** | **DateTime?**| When the event is scheduled to go live | [optional] 
 **lastModifiedMin** | **DateTime?**| The timestamp when any of the properties of the event was last modified | [optional] 
 **lastModifiedMax** | **DateTime?**| The timestamp when any of the properties of the event was last modified | [optional] 
 **paginationLastDisplayOrder** | **int?**|  Display order for the last event of the previous page.&lt;br&gt; This parameter should be used in conjunction with sorting by display_order,... | [optional] 
 **paginationLastStartDatetime** | **DateTime?**|  Start datetime for the last event of the previous page.&lt;br&gt; This parameter should be used in conjunction with sorting by start_datetime | [optional] 
 **paginationLastId** | **string**|  The last event id from the previous page, so we can retrieve the subsequent events.&lt;br&gt; This should be used in conjunction with sorting by id | [optional] 
 **paginationLastName** | **string**|  The name of the last event from the previous page, so we can retrieve the subsequent events.&lt;br&gt; This should be used in conjunction with sorting by name | [optional] 
 **sort** | **string**|  The sorting order for the resulting events.&lt;br&gt; It should be used in conjunction with pagination parameters.&lt;br&gt; The default and recommended sorting order and pagination is by event id.&lt;br&gt; The links to the next page returned on every request help clients navigate through all the relevant events  | [optional] [default to id]
 **limit** | **int?**| The number of events to retrieve in the API call | [optional] [default to 20]
 **includeHidden** | **bool?**| Choose to include in the response events that are not visible on the website. Hidden events may not be displayed for a varied number of reasons (for example the start date is too far away). Betting is not available for hidden events. | [optional] [default to false]
 **jurisdiction** | **string**| Jurisdiction of user | [optional] 

### Return type

[**Events**](Events.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="geteventsbyids"></a>
# **GetEventsByIds**
> Events GetEventsByIds (List<int?> eventIds, bool? withNewType = null, bool? includeHidden = null, string jurisdiction = null)

Retrieve events by their event ids.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEventsByIdsExample
    {
        public void main()
        {
            var apiInstance = new EventsApi();
            var eventIds = new List<int?>(); // List<int?> | Event IDs to filter by<br>maxItems:300
            var withNewType = true;  // bool? |  Enables a new, improved typing system for events.<br> If this flag is set to true, the format of the type field in the event response will change.<br> Users of the API are urged to make use of the new typing system, as the old typing system will be deprecated in the next version of the API. (optional)  (default to false)
            var includeHidden = true;  // bool? | Choose to include in the response events that are not visible on the website. Hidden events may not be displayed for a varied number of reasons (for example the start date is too far away). Betting is not available for hidden events. (optional)  (default to true)
            var jurisdiction = jurisdiction_example;  // string | Jurisdiction of user (optional) 

            try
            {
                // Retrieve events by their event ids.
                Events result = apiInstance.GetEventsByIds(eventIds, withNewType, includeHidden, jurisdiction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.GetEventsByIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventIds** | [**List&lt;int?&gt;**](int?.md)| Event IDs to filter by&lt;br&gt;maxItems:300 | 
 **withNewType** | **bool?**|  Enables a new, improved typing system for events.&lt;br&gt; If this flag is set to true, the format of the type field in the event response will change.&lt;br&gt; Users of the API are urged to make use of the new typing system, as the old typing system will be deprecated in the next version of the API. | [optional] [default to false]
 **includeHidden** | **bool?**| Choose to include in the response events that are not visible on the website. Hidden events may not be displayed for a varied number of reasons (for example the start date is too far away). Betting is not available for hidden events. | [optional] [default to true]
 **jurisdiction** | **string**| Jurisdiction of user | [optional] 

### Return type

[**Events**](Events.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getleaguetable"></a>
# **GetLeagueTable**
> Dictionary<string, Object> GetLeagueTable (int? eventId)

     Given a smarkets competition id returns the league tables for it.

## Description Args:     event_id (int): The event id of the competition Returns:     JSONResponse: Returns a dictionary of the competitions present for that node   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLeagueTableExample
    {
        public void main()
        {
            var apiInstance = new EventsApi();
            var eventId = 56;  // int? | 

            try
            {
                //      Given a smarkets competition id returns the league tables for it.
                Dictionary&lt;string, Object&gt; result = apiInstance.GetLeagueTable(eventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.GetLeagueTable: " + e.Message );
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

**Dictionary<string, Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstatsmultipleevents"></a>
# **GetStatsMultipleEvents**
> MultipleEventStats GetStatsMultipleEvents (List<int?> eventIds)

Retrieve stats for multiple events.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStatsMultipleEventsExample
    {
        public void main()
        {
            var apiInstance = new EventsApi();
            var eventIds = new List<int?>(); // List<int?> | maxItems:300

            try
            {
                // Retrieve stats for multiple events.
                MultipleEventStats result = apiInstance.GetStatsMultipleEvents(eventIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.GetStatsMultipleEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventIds** | [**List&lt;int?&gt;**](int?.md)| maxItems:300 | 

### Return type

[**MultipleEventStats**](MultipleEventStats.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
