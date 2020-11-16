# IO.Swagger.Api.AccountActivityApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountActivityCsv**](AccountActivityApi.md#accountactivitycsv) | **GET** /v3/account_activity_csv/{start_datetime}/{end_datetime}/ |      Return the account activity between the two specified datetimes as a gzipped CSV.
[**GetActivity**](AccountActivityApi.md#getactivity) | **GET** /v3/accounts/activity/ | Retrieve statement information for your account.
[**GetStatementByEvent**](AccountActivityApi.md#getstatementbyevent) | **GET** /v3/statement_by_event/ | Retrieve statement information grouped by event.

<a name="accountactivitycsv"></a>
# **AccountActivityCsv**
> void AccountActivityCsv (DateTime? startDatetime, DateTime? endDatetime)

     Return the account activity between the two specified datetimes as a gzipped CSV.

## Description Start and end datetimes have to be separated by an hour, also these have to be exactly on the hour.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountActivityCsvExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountActivityApi();
            var startDatetime = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var endDatetime = 2013-10-20T19:20:30+01:00;  // DateTime? | 

            try
            {
                //      Return the account activity between the two specified datetimes as a gzipped CSV.
                apiInstance.AccountActivityCsv(startDatetime, endDatetime);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountActivityApi.AccountActivityCsv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDatetime** | **DateTime?**|  | 
 **endDatetime** | **DateTime?**|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getactivity"></a>
# **GetActivity**
> AccountActivityResponse GetActivity (DateTime? timestampMax = null, DateTime? timestampMin = null, int? limit = null, List<string> marketId = null, List<string> orderId = null, string paginationLastSeq = null, string paginationLastSubseq = null, string sort = null, List<string> source = null, bool? eventInfo = null)

Retrieve statement information for your account.

## Description This information should be used for accounting reconciliation.<br> This data is what is being used in <a href=\"https://smarkets.com/account/statement\">our statement page</a>  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountActivityApi();
            var timestampMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Maximum datetime for records (optional) 
            var timestampMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Minimum datetime for records (optional) 
            var limit = 56;  // int? | Maximum number of account activity rows to return on a single call (optional)  (default to 20)
            var marketId = new List<string>(); // List<string> | Market IDs to filter by (optional) 
            var orderId = new List<string>(); // List<string> | Order IDs to filter by (optional) 
            var paginationLastSeq = paginationLastSeq_example;  // string | Last sequence number of the previous page. This parameter should be used for paginated requests (optional) 
            var paginationLastSubseq = paginationLastSubseq_example;  // string | Last sub-sequence number of the previous page. This parameter should be used for paginated requests (optional) 
            var sort = sort_example;  // string |  How to sort the results. When making paginated requests, pagination_last_seq and pagination_last_subseq should be used with the values from the last record of the previous page (optional)  (default to -seq,-subseq)
            var source = new List<string>(); // List<string> | Account activity sources to filter by. (optional) 
            var eventInfo = true;  // bool? | Should response be enhanced with include event information (optional)  (default to false)

            try
            {
                // Retrieve statement information for your account.
                AccountActivityResponse result = apiInstance.GetActivity(timestampMax, timestampMin, limit, marketId, orderId, paginationLastSeq, paginationLastSubseq, sort, source, eventInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountActivityApi.GetActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timestampMax** | **DateTime?**| Maximum datetime for records | [optional] 
 **timestampMin** | **DateTime?**| Minimum datetime for records | [optional] 
 **limit** | **int?**| Maximum number of account activity rows to return on a single call | [optional] [default to 20]
 **marketId** | [**List&lt;string&gt;**](string.md)| Market IDs to filter by | [optional] 
 **orderId** | [**List&lt;string&gt;**](string.md)| Order IDs to filter by | [optional] 
 **paginationLastSeq** | **string**| Last sequence number of the previous page. This parameter should be used for paginated requests | [optional] 
 **paginationLastSubseq** | **string**| Last sub-sequence number of the previous page. This parameter should be used for paginated requests | [optional] 
 **sort** | **string**|  How to sort the results. When making paginated requests, pagination_last_seq and pagination_last_subseq should be used with the values from the last record of the previous page | [optional] [default to -seq,-subseq]
 **source** | [**List&lt;string&gt;**](string.md)| Account activity sources to filter by. | [optional] 
 **eventInfo** | **bool?**| Should response be enhanced with include event information | [optional] [default to false]

### Return type

[**AccountActivityResponse**](AccountActivityResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstatementbyevent"></a>
# **GetStatementByEvent**
> StatementByEventResponse GetStatementByEvent (DateTime? lastTimestampMax = null, DateTime? lastTimestampMin = null, int? limit = null, bool? eventInfo = null)

Retrieve statement information grouped by event.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStatementByEventExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountActivityApi();
            var lastTimestampMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Maximum last timestamp for records, defaults to the current datetime (optional) 
            var lastTimestampMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Minimum last timestamp for records, defaults to 1 month ago (optional) 
            var limit = 56;  // int? | Maximum number of account activity rows to return on a single call (optional)  (default to 20)
            var eventInfo = true;  // bool? | Should response be enhanced with include event information (optional)  (default to false)

            try
            {
                // Retrieve statement information grouped by event.
                StatementByEventResponse result = apiInstance.GetStatementByEvent(lastTimestampMax, lastTimestampMin, limit, eventInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountActivityApi.GetStatementByEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lastTimestampMax** | **DateTime?**| Maximum last timestamp for records, defaults to the current datetime | [optional] 
 **lastTimestampMin** | **DateTime?**| Minimum last timestamp for records, defaults to 1 month ago | [optional] 
 **limit** | **int?**| Maximum number of account activity rows to return on a single call | [optional] [default to 20]
 **eventInfo** | **bool?**| Should response be enhanced with include event information | [optional] [default to false]

### Return type

[**StatementByEventResponse**](StatementByEventResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
