# IO.Swagger.Model.AccountActivityTransaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **string** | Amount relative to the order | [optional] 
**BonusChange** | **string** | A change in the bonus balance | [optional] 
**Commission** | **string** | How much commission was charged | [optional] 
**ContractId** | **string** | This ID uniquely identifies the contract | [optional] 
**EventId** | **string** | This ID uniquely identifies an event | [optional] 
**Exposure** | **string** | Current exposure on the account | [optional] 
**Extra** | **string** | Additional information about this row | [optional] 
**Label** | **string** | Label is a user-defined string that will be stored in the order. It can be used to identify different trading strategies | [optional] 
**MarketId** | **string** | This ID uniquely identifies the market | [optional] 
**Money** | **string** | Balance of the account | [optional] 
**MoneyChange** | **string** | Change in the account&#x27;s balance | [optional] 
**OrderId** | **string** | This ID uniquely identifies an order | [optional] 
**Price** | **int?** |  This price is in percentage basis points.&lt;br&gt; Example: 5000 &#x3D; 50% &lt;br&gt; To convert it to decimal odds, just divide 10000 by it&lt;br&gt; Example: 10000 / 5000 &#x3D; 2.0 (decimal odds).&lt;br&gt; This price has to conform to a valid tick on the exchange; an invalid price error will be returned if it does not. | [optional] 
**Quantity** | **int?** |      Quantity is the sum of the total pot (back+lay) in case the order is matched&lt;br&gt;     The units are 1/100 of a UK penny.&lt;br&gt;     Example: Quantity 1 &#x3D; 0.0001 GBP&lt;br&gt;     To convert it to back stake, just multiply by the price and divide by 100000000&lt;br&gt;     Example: 100000 (quantity) * 5000 (price) / 100000000 &#x3D; 5 GBP back stake | [optional] 
**QuantityChange** | **int?** | Change in the quantity in GBP | [optional] 
**QuantityUserCurrency** | **int?** |      Quantity is the sum of the total pot (back+lay) in case the order is matched&lt;br&gt;     The units are 1/10000 * one unit of the user&#x27;s currency.&lt;br&gt;     Example: Quantity 1 &#x3D; 0.0001 GBP&lt;br&gt;     To convert it to back stake, just multiply by the price and divide by 100000000&lt;br&gt;     Example: 100000 (quantity) * 5000 (price) / 100000000 &#x3D; 5 GBP back stake | [optional] 
**QuantityUserCurrencyChange** | **int?** | Change in the quantity in user&#x27;s currency | [optional] 
**Seq** | **int?** | Sequence number for the statement row | [optional] 
**Side** | **string** |  side can either be:&lt;ul&gt; &lt;li&gt;buy: backing a contract &lt;li&gt;sell: laying a contract &lt;/ul&gt; | [optional] 
**Source** | **string** | The source of the account activity row is the trigger that generated the transaction to occur | [optional] 
**Subseq** | **int?** | Sub sequence number for the statement row | [optional] 
**Timestamp** | **DateTime?** | When this transaction took place | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

