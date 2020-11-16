# IO.Swagger.Model.Market
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BetDelay** | **int?** | How much is the bet delay for this market,\&quot; the interval between order placement and acceptance | 
**CashoutEnabled** | **bool?** |  Cashout enabled determines whether instant cashout is enabled for this market. If true, trading out of this market will cause the settlement result to be immediatelly reflected in the customer&#x27;s balance (before the final settlement of the market). | 
**Category** | **string** | Category of this market | [optional] 
**Complete** | **bool?** | Complete markets cannot have additional contracts added after market creation | 
**ContractSelections** | **List&lt;int?&gt;** |  These particular contracts are not related to markets in the same way that most contracts are related to markets.&lt;br&gt; The contract_selections field is only set for accumulator markets and it refers to the contract IDs that the acca is made up of, an example:&lt;br&gt; &lt;br&gt; M1 (Winner market in Man Utd - Liverpool) &lt;ul&gt; &lt;li&gt;M1-C1 (Man Utd) &lt;li&gt;M1-C2 (Draw) &lt;li&gt;M1-C3 (Liverpool) &lt;/ul&gt; &lt;/ul&gt; M2 (Winner market in Arsenal - Chelsea) &lt;ul&gt; &lt;li&gt;M2-C1 (Arsenal) &lt;li&gt;M2-C2 (Draw) &lt;li&gt;M2-C3 (Chelsea) &lt;/ul&gt; &lt;br&gt; Now an accumulator market is created:&lt;br&gt; M3 (Man Utd and Arsenal both to win on 23rd of February) &lt;ul&gt; &lt;li&gt;M3-C1 (Yes) &lt;li&gt;M3-C2 (No) &lt;/ul&gt; &lt;br&gt; In this case, M3 will have two contracts (M3-C1 and M3-C2) but contract_selections will be M1-C1 (Man Utd) and M2-C1 (Arsenal).&lt;br&gt; | [optional] 
**Created** | **DateTime?** | When was the market created in the Smarkets exchange | 
**Description** | **string** | A summary about this market | [optional] 
**DisplayOrder** | **int?** | Markets are sorted in the website according to these numbers in descending order | [optional] 
**DisplayType** | **string** |  The display type can be used by frontend to define how the odds of the contracts of&lt;br&gt; the market will appear on the website. | [default to DisplayTypeEnum.Default]
**EventId** | **string** | This ID uniquely identifies an event | 
**Hidden** | **bool?** | Hidden markets aren&#x27;t displayed in our website | 
**Id** | **string** | This ID uniquely identifies the market | 
**InplayEnabled** | **bool?** | True if trading will be open when the markets go live in-play | [optional] 
**MarketType** | [**AccountActivityResponseMarketType**](AccountActivityResponseMarketType.md) |  | 
**Modified** | **DateTime?** | The datetime of the last modification made by Smarkets to the market properties | 
**Name** | **string** |  Name of the market. This field is for display purposes and should not be used to identify the market.&lt;br&gt; The market_type field should be used instead. | 
**Slug** | **string** |  Slug concisely represents the market.&lt;br&gt; It should not be used to identify the market.&lt;br&gt; The market_type field should be used instead. | 
**State** | **string** |  Market state can have the following values:&lt;br&gt; -new: just created, still not open for trading&lt;br&gt; -open: open for trading not live in-play&lt;br&gt; -live: open for trading, live in-play&lt;br&gt; -halted: trading is halted temporarily, usually due to material events&lt;br&gt; -settled: traded has ceased and the market has settled&lt;br&gt; -voided: the market was voided and no winner was chosen&lt;br&gt; -unavailable: the maret is not available for betting | 
**WinnerCount** | **int?** |  How many winners will the market have.&lt;br&gt; Usually this number is 1, except for \&quot;To Place\&quot;, \&quot;Top x Finish\&quot; type markets      | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

