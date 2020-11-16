# IO.Swagger.Model.RecentTrade
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContractId** | **string** | This ID uniquely identifies the contract | 
**MarketId** | **string** | This ID uniquely identifies the market | 
**Price** | **int?** |  This price is in percentage basis points.&lt;br&gt; Example: 5000 &#x3D; 50% &lt;br&gt; To convert it to decimal odds, just divide 10000 by it&lt;br&gt; Example: 10000 / 5000 &#x3D; 2.0 (decimal odds).&lt;br&gt; This price has to conform to a valid tick on the exchange; an invalid price error will be returned if it does not. | 
**Quantity** | **int?** |      Quantity is the sum of the total pot (back+lay) in case the order is matched&lt;br&gt;     The units are 1/100 of a UK penny.&lt;br&gt;     Example: Quantity 1 &#x3D; 0.0001 GBP&lt;br&gt;     To convert it to back stake, just multiply by the price and divide by 100000000&lt;br&gt;     Example: 100000 (quantity) * 5000 (price) / 100000000 &#x3D; 5 GBP back stake | 
**Side** | **string** |  side can either be:&lt;ul&gt; &lt;li&gt;buy: backing a contract &lt;li&gt;sell: laying a contract &lt;/ul&gt; | 
**Timestamp** | **DateTime?** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

