# IO.Swagger.Model.StatementEvent1
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FullSlug** | **string** | The URL slug for the event page | 
**Name** | **string** | The name of the event | 
**ParentId** | **string** | This ID uniquely identifies the parent of the event | 
**Slug** | **string** | An easier way to identify the event | 
**State** | **string** |  Event state can have the following values: &lt;ul&gt; &lt;li&gt;upcoming: the event is now open for betting &lt;li&gt;live: the event is now live in-play &lt;li&gt;ended: the event has ended and its markets should be settled &lt;li&gt;settled: the event has ended and its markets should be settled &lt;li&gt;cancelled: the event was cancelled and didn&#x27;t take place &lt;li&gt;suspended: the event was suspended and during play time &lt;/ul&gt;      | 
**Type** | [**OneOfstatementEvent1Type**](OneOfstatementEvent1Type.md) | The type of the event, for instance, the name of the sport&lt;br&gt; | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

