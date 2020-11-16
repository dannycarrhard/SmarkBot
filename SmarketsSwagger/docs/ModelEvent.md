# IO.Swagger.Model.ModelEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BetAllowed** | **bool?** | Determines whether bets are allowed in the given jurisdiction | [optional] 
**Bettable** | **bool?** | This needs to be True for events to be open for trading | [optional] 
**ChartTimePeriod** | **string** | A string to be used by frontend to show/default selectable chart time periods | [optional] 
**Created** | **DateTime?** | When was the event created in the Smarkets exchange | 
**Description** | **string** | Additional description for this event | 
**DisplayOrder** | **int?** | On Smarkets listings pages, events will be sorted according to these numbers, in descending order | [optional] 
**EndDate** | **DateTime?** | When the event is scheduled to end | 
**FullSlug** | **string** | The URL slug for the event page | 
**Hidden** | **bool?** | True if the event is hidden from the Smarkets website | 
**Id** | **string** | This ID uniquely identifies an event | 
**InplayEnabled** | **bool?** | True if trading will be open when the markets go live in-play | [optional] 
**Modified** | **DateTime?** | The datetime of the last modification made by Smarkets to the event properties | 
**Name** | **string** | The name of the event | 
**ParentId** | **string** | This ID uniquely identifies the parent of the event | 
**SeoDescription** | **string** | Additional description for this event used for SEO | [optional] 
**ShortName** | **string** | A shorter version of the name of the event | 
**Slug** | **string** | An easier way to identify the event | 
**SpecialRules** | **string** | Special rules to be defined for this market | [optional] 
**StartDate** | **DateTime?** | In what day the event will go live, This can be useful for events that still have an unknown start_datetime | 
**StartDatetime** | **DateTime?** | When the event is scheduled to go live | 
**State** | **string** |  Event state can have the following values: &lt;ul&gt; &lt;li&gt;upcoming: the event is now open for betting &lt;li&gt;live: the event is now live in-play &lt;li&gt;ended: the event has ended and its markets should be settled &lt;li&gt;settled: the event has ended and its markets should be settled &lt;li&gt;cancelled: the event was cancelled and didn&#x27;t take place &lt;li&gt;suspended: the event was suspended and during play time &lt;/ul&gt;      | 
**Type** | [**OneOfEventType**](OneOfEventType.md) | The type of the event, for instance, the name of the sport&lt;br&gt; | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

