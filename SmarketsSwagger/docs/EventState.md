# IO.Swagger.Model.EventState
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActualEndDatetime** | **DateTime?** | When the event actually ended | [optional] 
**ActualStartDatetime** | **DateTime?** | When the event actually went live | [optional] 
**Aggregate** | **List&lt;int?&gt;** |  The score of the first leg in an aggregate.&lt;br&gt; The first value corresponds to the score of the team playing&lt;br&gt; as the home team in the first leg and second value to the away team. | [optional] 
**Clock** | [**EventStatesClock**](EventStatesClock.md) |  | [optional] 
**HasLeagueTable** | **bool?** | Shows whether there is league table information linked to this event | [optional] 
**Hidden** | **bool?** | True if the event is hidden from the Smarkets website | 
**Id** | **string** | This ID uniquely identifies an event | 
**Info** | **Object** | Additional information about the state of this event | [optional] 
**InstantMatch** | **bool?** |  Will instant match be enabled for this event. &lt;br&gt; For more information about this feature read this &lt;a href&#x3D;\&quot;https://help.smarkets.com/hc/en-gb/articles/212106249-Instant-Match\&quot;&gt;help article&lt;/a&gt;      | 
**MatchPeriod** | **string** | The current period of the match | [optional] 
**ProbablePitcher** | [**EventStatesProbablePitcher**](EventStatesProbablePitcher.md) |  | [optional] 
**ProviderMetadata** | **Object** | Additional metadata from our events provider | 
**Reversed** | **bool?** | True if the event name is written in the form &lt;Away Team&gt; at &lt;Home Team&gt; | [optional] 
**Scores** | [**AnyOfeventStateScores**](AnyOfeventStateScores.md) | football, point based, set based, cricket, part based, golf, rugby | 
**ShowFlags** | **bool?** | display the country flag for the both competitors using the country code | [optional] 
**State** | **string** |  Event state can have the following values: &lt;ul&gt; &lt;li&gt;upcoming: the event is now open for betting &lt;li&gt;live: the event is now live in-play &lt;li&gt;ended: the event has ended and its markets should be settled &lt;li&gt;settled: the event has ended and its markets should be settled &lt;li&gt;cancelled: the event was cancelled and didn&#x27;t take place &lt;li&gt;suspended: the event was suspended and during play time &lt;/ul&gt;      | 
**TennisServer** | **string** | In case of a tennis match, this indicates who is serving, otherwise it&#x27;s null | 
**Visualization** | **bool?** | Is visualization enabled for this event | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

