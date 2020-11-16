# IO.Swagger.Model.StatementEvent2
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContractSelections** | **List&lt;int?&gt;** |  These particular contracts are not related to markets in the same way that most contracts are related to markets.&lt;br&gt; The contract_selections field is only set for accumulator markets and it refers to the contract IDs that the acca is made up of, an example:&lt;br&gt; &lt;br&gt; M1 (Winner market in Man Utd - Liverpool) &lt;ul&gt; &lt;li&gt;M1-C1 (Man Utd) &lt;li&gt;M1-C2 (Draw) &lt;li&gt;M1-C3 (Liverpool) &lt;/ul&gt; &lt;/ul&gt; M2 (Winner market in Arsenal - Chelsea) &lt;ul&gt; &lt;li&gt;M2-C1 (Arsenal) &lt;li&gt;M2-C2 (Draw) &lt;li&gt;M2-C3 (Chelsea) &lt;/ul&gt; &lt;br&gt; Now an accumulator market is created:&lt;br&gt; M3 (Man Utd and Arsenal both to win on 23rd of February) &lt;ul&gt; &lt;li&gt;M3-C1 (Yes) &lt;li&gt;M3-C2 (No) &lt;/ul&gt; &lt;br&gt; In this case, M3 will have two contracts (M3-C1 and M3-C2) but contract_selections will be M1-C1 (Man Utd) and M2-C1 (Arsenal).&lt;br&gt; | 
**MarketType** | [**AccountActivityResponseMarketType**](AccountActivityResponseMarketType.md) |  | 
**Name** | **string** |  Name of the market. This field is for display purposes and should not be used to identify the market.&lt;br&gt; The market_type field should be used instead. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

