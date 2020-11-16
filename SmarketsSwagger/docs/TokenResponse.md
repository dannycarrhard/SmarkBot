# IO.Swagger.Model.TokenResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Factor** | **string** |  Next factor for authentication to complete, used in multi factor authentication: &lt;ul&gt; &lt;li&gt;complete: Login is complete and there is no further factor required. &lt;li&gt;totp: Login is incomplete and needs the totp code. &lt;li&gt;nemid: Login is incomplete and needs nemid confirmation.&lt;li&gt; &lt;/ul&gt;      | [optional] 
**Params** | **Object** | Parameters for Danish Login | [optional] 
**Stop** | **DateTime?** |  This datetime specifies when the token will expire if not renewed.&lt;br&gt; Any authenticated API call will automatically renew the token for another 30min&lt;br&gt;      | 
**Token** | **string** |  This session token can be used to make authenticated requests to Smarkets.&lt;br&gt; We will resolve the who the user is based on this.&lt;br&gt; Account information, orders, up-to-date prices are examples that will require it to be sent.      | 
**Verify** | **bool?** | True if further verification is required | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

