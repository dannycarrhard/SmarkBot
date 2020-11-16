# IO.Swagger.Model.Contract
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompetitorId** | **int?** | The Smarkets competitor model id | [optional] 
**ContractType** | [**ContractsResponseContractType**](ContractsResponseContractType.md) |  | [optional] 
**Created** | **DateTime?** | When was the contract created in the Smarkets exchange | 
**DisplayOrder** | **int?** | Smarkets will display the contracts sorted by these values, in descending order | [optional] 
**Hidden** | **bool?** | Hidden contracts aren&#x27;t displayed in our website | [optional] 
**Id** | **string** | This ID uniquely identifies the contract | 
**Info** | [**ContractsResponseInfo**](ContractsResponseInfo.md) |  | [optional] 
**MarketId** | **string** | This ID uniquely identifies the market | 
**Modified** | **DateTime?** | The datetime of the last modification made by Smarkets to the&lt;br&gt; contract properties | 
**Name** | **string** | Name for the contract, as displayed in our website.&lt;br&gt; Examples can be team names, horse names or other winning outcomes for each market.&lt;br&gt; It should not be used to identify the contract.&lt;br&gt; The contract_type field should be used instead. | 
**OutcomeTimestamp** | **DateTime?** | If the contract has settled, this will have the settlement datetime, null otherwise | 
**ReductionFactor** | **string** |  | [optional] 
**Slug** | **string** | Slug concisely represents the contract.&lt;br&gt; It should not be used to identify the contract.&lt;br&gt; The contract_type field should be used instead. | 
**StateOrOutcome** | **string** |  state_or_outcome can have the following values: &lt;ul&gt; &lt;li&gt;new: The contract was just created and is still not available for betting &lt;li&gt;open: open for betting &lt;li&gt;live: open and trading live in-play &lt;li&gt;halted: Trading on this contract has halted &lt;li&gt;winner: settled as winner. &lt;li&gt;loser:  settled as loser. &lt;li&gt;deadheat: settled as a deadheat - a tie with other contract. &lt;li&gt;reduced: withdrawn and a reduction factor was applied. &lt;li&gt;voided: no longer available for betting &lt;li&gt;unavailable: not currently available for betting &lt;/ul&gt;      | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

