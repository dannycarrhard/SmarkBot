# IO.Swagger.Api.PromotionsApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMarketingWidget**](PromotionsApi.md#getmarketingwidget) | **GET** /v3/marketing-widget/ | Get data for frontend home page marketing widget, specifying which slides need to be displayed.
[**GetMarketingWidgetSlideDetails**](PromotionsApi.md#getmarketingwidgetslidedetails) | **GET** /v3/marketing-widget/slide-details/ | Get slides detail data for frontend home page marketing widget, specifying links on each slide.
[**GetMultiplePromotions**](PromotionsApi.md#getmultiplepromotions) | **GET** /v3/promotions/{promotion_ids}/ | Get multiple promotions info.
[**GetPromotion**](PromotionsApi.md#getpromotion) | **GET** /v3/promotions/{promotion_id}/ | Get the promotion information from marketing.
[**GetPromotionUsages**](PromotionsApi.md#getpromotionusages) | **GET** /v3/promotions/usage/ | Get the promotions that the authenticated user has and the logs for each time the promotion progressed.
[**GetRafBonusAmounts**](PromotionsApi.md#getrafbonusamounts) | **GET** /v3/promotions/raf-bonus/ | Get the current value of the refer a friend bonus in a number of different supported currencies.
[**GetReferredStats**](PromotionsApi.md#getreferredstats) | **GET** /v3/promotions/stats/ | Get stats for the promotions that the user has signed up for.
[**GetReferredStatsV0**](PromotionsApi.md#getreferredstatsv0) | **GET** /v0/promotions/stats/ | Get stats for the promotions that the user has signed up for.

<a name="getmarketingwidget"></a>
# **GetMarketingWidget**
> Widget GetMarketingWidget (bool? isMember = null)

Get data for frontend home page marketing widget, specifying which slides need to be displayed.

## Description The marketing widget on the home page displays several slides, according to user auth condition and media type.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMarketingWidgetExample
    {
        public void main()
        {
            var apiInstance = new PromotionsApi();
            var isMember = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Get data for frontend home page marketing widget, specifying which slides need to be displayed.
                Widget result = apiInstance.GetMarketingWidget(isMember);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromotionsApi.GetMarketingWidget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **isMember** | **bool?**|  | [optional] [default to true]

### Return type

[**Widget**](Widget.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmarketingwidgetslidedetails"></a>
# **GetMarketingWidgetSlideDetails**
> WidgetSlidesDetail GetMarketingWidgetSlideDetails ()

Get slides detail data for frontend home page marketing widget, specifying links on each slide.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMarketingWidgetSlideDetailsExample
    {
        public void main()
        {
            var apiInstance = new PromotionsApi();

            try
            {
                // Get slides detail data for frontend home page marketing widget, specifying links on each slide.
                WidgetSlidesDetail result = apiInstance.GetMarketingWidgetSlideDetails();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromotionsApi.GetMarketingWidgetSlideDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**WidgetSlidesDetail**](WidgetSlidesDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmultiplepromotions"></a>
# **GetMultiplePromotions**
> InlineResponse20062 GetMultiplePromotions (List<int?> promotionIds)

Get multiple promotions info.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMultiplePromotionsExample
    {
        public void main()
        {
            var apiInstance = new PromotionsApi();
            var promotionIds = new List<int?>(); // List<int?> | 

            try
            {
                // Get multiple promotions info.
                InlineResponse20062 result = apiInstance.GetMultiplePromotions(promotionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromotionsApi.GetMultiplePromotions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **promotionIds** | [**List&lt;int?&gt;**](int?.md)|  | 

### Return type

[**InlineResponse20062**](InlineResponse20062.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpromotion"></a>
# **GetPromotion**
> InlineResponse20063 GetPromotion (int? promotionId)

Get the promotion information from marketing.

## Description This is to be displayed on FE as part of an updated refer a friend page that includes all promotions.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPromotionExample
    {
        public void main()
        {
            var apiInstance = new PromotionsApi();
            var promotionId = 56;  // int? | 

            try
            {
                // Get the promotion information from marketing.
                InlineResponse20063 result = apiInstance.GetPromotion(promotionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromotionsApi.GetPromotion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **promotionId** | **int?**|  | 

### Return type

[**InlineResponse20063**](InlineResponse20063.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpromotionusages"></a>
# **GetPromotionUsages**
> InlineResponse20061 GetPromotionUsages ()

Get the promotions that the authenticated user has and the logs for each time the promotion progressed.

## Description This is to be displayed on FE as part of an updated refer a friend page that includes all promotions.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPromotionUsagesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PromotionsApi();

            try
            {
                // Get the promotions that the authenticated user has and the logs for each time the promotion progressed.
                InlineResponse20061 result = apiInstance.GetPromotionUsages();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromotionsApi.GetPromotionUsages: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20061**](InlineResponse20061.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrafbonusamounts"></a>
# **GetRafBonusAmounts**
> RafBonus GetRafBonusAmounts ()

Get the current value of the refer a friend bonus in a number of different supported currencies.

## Description For use in frontend so they dont need to redeploy if we update the RAF bonus.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRafBonusAmountsExample
    {
        public void main()
        {
            var apiInstance = new PromotionsApi();

            try
            {
                // Get the current value of the refer a friend bonus in a number of different supported currencies.
                RafBonus result = apiInstance.GetRafBonusAmounts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromotionsApi.GetRafBonusAmounts: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RafBonus**](RafBonus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getreferredstats"></a>
# **GetReferredStats**
> ReferAFriendResponse GetReferredStats ()

Get stats for the promotions that the user has signed up for.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetReferredStatsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PromotionsApi();

            try
            {
                // Get stats for the promotions that the user has signed up for.
                ReferAFriendResponse result = apiInstance.GetReferredStats();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromotionsApi.GetReferredStats: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ReferAFriendResponse**](ReferAFriendResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getreferredstatsv0"></a>
# **GetReferredStatsV0**
> InlineResponse20013 GetReferredStatsV0 ()

Get stats for the promotions that the user has signed up for.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetReferredStatsV0Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PromotionsApi();

            try
            {
                // Get stats for the promotions that the user has signed up for.
                InlineResponse20013 result = apiInstance.GetReferredStatsV0();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PromotionsApi.GetReferredStatsV0: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
