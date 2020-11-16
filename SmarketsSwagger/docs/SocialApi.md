# IO.Swagger.Api.SocialApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateComment**](SocialApi.md#createcomment) | **POST** /v3/social/comments/ | Create a new comment.
[**CreateMember**](SocialApi.md#createmember) | **POST** /v3/social/members/ | Create a new social member.
[**CreateReaction**](SocialApi.md#createreaction) | **POST** /v3/social/comments/{comment_id}/reactions/{emoji_id}/ | Add a reaction to a comment.
[**DeleteComment**](SocialApi.md#deletecomment) | **DELETE** /v3/social/comments/{comment_id}/ | Delete a comment.
[**DeleteMemberRelationship**](SocialApi.md#deletememberrelationship) | **DELETE** /v3/social/members/{from_member_id}/relationships/target_id/{to_member_id}/ | Delete the current one-way relationship from between the two members.
[**DeleteReaction**](SocialApi.md#deletereaction) | **DELETE** /v3/social/comments/{comment_id}/reactions/{emoji_id}/ | Remove a reaction to a comment.
[**GetComments**](SocialApi.md#getcomments) | **GET** /v3/social/comments/ | Get a list of top-level comments.
[**GetCurrentMember**](SocialApi.md#getcurrentmember) | **GET** /v3/social/members/current/ | Get the current member logged in.
[**GetFollowers**](SocialApi.md#getfollowers) | **GET** /v3/social/members/{member_id}/followers/ | Get the ids following the specified member.
[**GetFollowing**](SocialApi.md#getfollowing) | **GET** /v3/social/members/{member_id}/following/ | Get the ids the specified member is following.
[**GetMemberActivity**](SocialApi.md#getmemberactivity) | **GET** /v3/social/activity/ | 
[**GetMemberRelationships**](SocialApi.md#getmemberrelationships) | **GET** /v3/social/members/relationships/ | Get members that share the relationship specified.
[**GetMembers**](SocialApi.md#getmembers) | **GET** /v3/social/members/{member_ids}/ | Get a list of social members by id.
[**GetMembersBetStats**](SocialApi.md#getmembersbetstats) | **GET** /v3/social/members/{member_ids}/bet_stats/ | Get the bet stats for a list of members.
[**GetUnreadActivityCount**](SocialApi.md#getunreadactivitycount) | **GET** /v3/social/activity/unread/ | 
[**SearchMembers**](SocialApi.md#searchmembers) | **GET** /v3/social/members/ | Retrieve members based on filters.
[**SetActivityRead**](SocialApi.md#setactivityread) | **PATCH** /v3/social/activity/read/ | 
[**UpdateMember**](SocialApi.md#updatemember) | **PATCH** /v3/social/members/ | Update member data.
[**UpdateMemberPhoto**](SocialApi.md#updatememberphoto) | **PUT** /v3/social/members/photo/ | Update the member&#x27;s photo.
[**UploadSharedImage**](SocialApi.md#uploadsharedimage) | **PUT** /v3/social/images/ | Upload an image.
[**UpsertRelationship**](SocialApi.md#upsertrelationship) | **PUT** /v3/social/members/relationships/ | Upsert the member&#x27;s relationship to the targeted member.

<a name="createcomment"></a>
# **CreateComment**
> PostCommentResponse CreateComment (PostCommentsRequest body = null)

Create a new comment.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCommentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();
            var body = new PostCommentsRequest(); // PostCommentsRequest | JSON Request object (optional) 

            try
            {
                // Create a new comment.
                PostCommentResponse result = apiInstance.CreateComment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.CreateComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostCommentsRequest**](PostCommentsRequest.md)| JSON Request object | [optional] 

### Return type

[**PostCommentResponse**](PostCommentResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createmember"></a>
# **CreateMember**
> CreateSocialMemberResponse CreateMember (CreateSocialMemberRequest body = null)

Create a new social member.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateMemberExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();
            var body = new CreateSocialMemberRequest(); // CreateSocialMemberRequest | JSON Request object (optional) 

            try
            {
                // Create a new social member.
                CreateSocialMemberResponse result = apiInstance.CreateMember(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.CreateMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateSocialMemberRequest**](CreateSocialMemberRequest.md)| JSON Request object | [optional] 

### Return type

[**CreateSocialMemberResponse**](CreateSocialMemberResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createreaction"></a>
# **CreateReaction**
> Object CreateReaction (int? commentId, int? emojiId)

Add a reaction to a comment.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateReactionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();
            var commentId = 56;  // int? | 
            var emojiId = 56;  // int? | 

            try
            {
                // Add a reaction to a comment.
                Object result = apiInstance.CreateReaction(commentId, emojiId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.CreateReaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commentId** | **int?**|  | 
 **emojiId** | **int?**|  | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecomment"></a>
# **DeleteComment**
> Object DeleteComment (int? commentId)

Delete a comment.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCommentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();
            var commentId = 56;  // int? | 

            try
            {
                // Delete a comment.
                Object result = apiInstance.DeleteComment(commentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.DeleteComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commentId** | **int?**|  | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletememberrelationship"></a>
# **DeleteMemberRelationship**
> Object DeleteMemberRelationship (int? fromMemberId, int? toMemberId)

Delete the current one-way relationship from between the two members.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteMemberRelationshipExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();
            var fromMemberId = 56;  // int? | 
            var toMemberId = 56;  // int? | 

            try
            {
                // Delete the current one-way relationship from between the two members.
                Object result = apiInstance.DeleteMemberRelationship(fromMemberId, toMemberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.DeleteMemberRelationship: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fromMemberId** | **int?**|  | 
 **toMemberId** | **int?**|  | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletereaction"></a>
# **DeleteReaction**
> Object DeleteReaction (int? commentId, int? emojiId)

Remove a reaction to a comment.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteReactionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();
            var commentId = 56;  // int? | 
            var emojiId = 56;  // int? | 

            try
            {
                // Remove a reaction to a comment.
                Object result = apiInstance.DeleteReaction(commentId, emojiId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.DeleteReaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commentId** | **int?**|  | 
 **emojiId** | **int?**|  | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcomments"></a>
# **GetComments**
> GetCommentsReponse GetComments (List<int?> commentIds = null, List<string> eventIds = null, List<int?> memberIds = null, List<int?> parentCommentIds = null, string typeFilter = null, bool? includeReplies = null, int? limit = null, int? paginationLastId = null, string paginationLastCreated = null)

Get a list of top-level comments.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCommentsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();
            var commentIds = new List<int?>(); // List<int?> |  (optional) 
            var eventIds = new List<string>(); // List<string> | Event IDs to filter by (optional) 
            var memberIds = new List<int?>(); // List<int?> |  (optional) 
            var parentCommentIds = new List<int?>(); // List<int?> |  (optional) 
            var typeFilter = typeFilter_example;  // string |  (optional) 
            var includeReplies = true;  // bool? |  (optional) 
            var limit = 56;  // int? |  (optional)  (default to 50)
            var paginationLastId = 56;  // int? |  (optional) 
            var paginationLastCreated = paginationLastCreated_example;  // string |  (optional) 

            try
            {
                // Get a list of top-level comments.
                GetCommentsReponse result = apiInstance.GetComments(commentIds, eventIds, memberIds, parentCommentIds, typeFilter, includeReplies, limit, paginationLastId, paginationLastCreated);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.GetComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commentIds** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **eventIds** | [**List&lt;string&gt;**](string.md)| Event IDs to filter by | [optional] 
 **memberIds** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **parentCommentIds** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **typeFilter** | **string**|  | [optional] 
 **includeReplies** | **bool?**|  | [optional] 
 **limit** | **int?**|  | [optional] [default to 50]
 **paginationLastId** | **int?**|  | [optional] 
 **paginationLastCreated** | **string**|  | [optional] 

### Return type

[**GetCommentsReponse**](GetCommentsReponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcurrentmember"></a>
# **GetCurrentMember**
> GetSocialMemberResponse GetCurrentMember ()

Get the current member logged in.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCurrentMemberExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();

            try
            {
                // Get the current member logged in.
                GetSocialMemberResponse result = apiInstance.GetCurrentMember();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.GetCurrentMember: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetSocialMemberResponse**](GetSocialMemberResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getfollowers"></a>
# **GetFollowers**
> GetFollowersResponse GetFollowers (int? memberId)

Get the ids following the specified member.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFollowersExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();
            var memberId = 56;  // int? | 

            try
            {
                // Get the ids following the specified member.
                GetFollowersResponse result = apiInstance.GetFollowers(memberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.GetFollowers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberId** | **int?**|  | 

### Return type

[**GetFollowersResponse**](GetFollowersResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getfollowing"></a>
# **GetFollowing**
> GetFollowingResponse GetFollowing (int? memberId)

Get the ids the specified member is following.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFollowingExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();
            var memberId = 56;  // int? | 

            try
            {
                // Get the ids the specified member is following.
                GetFollowingResponse result = apiInstance.GetFollowing(memberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.GetFollowing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberId** | **int?**|  | 

### Return type

[**GetFollowingResponse**](GetFollowingResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmemberactivity"></a>
# **GetMemberActivity**
> GetActivityResponse GetMemberActivity (int? lastId = null, bool? seen = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMemberActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();
            var lastId = 56;  // int? |  (optional) 
            var seen = true;  // bool? |  (optional) 

            try
            {
                GetActivityResponse result = apiInstance.GetMemberActivity(lastId, seen);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.GetMemberActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lastId** | **int?**|  | [optional] 
 **seen** | **bool?**|  | [optional] 

### Return type

[**GetActivityResponse**](GetActivityResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmemberrelationships"></a>
# **GetMemberRelationships**
> GetSocialMemberRelationshipResponse GetMemberRelationships (List<string> fields = null)

Get members that share the relationship specified.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMemberRelationshipsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();
            var fields = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Get members that share the relationship specified.
                GetSocialMemberRelationshipResponse result = apiInstance.GetMemberRelationships(fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.GetMemberRelationships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**GetSocialMemberRelationshipResponse**](GetSocialMemberRelationshipResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmembers"></a>
# **GetMembers**
> GetSocialMemberResponse GetMembers (List<int?> memberIds)

Get a list of social members by id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMembersExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();
            var memberIds = new List<int?>(); // List<int?> | maxItems:300

            try
            {
                // Get a list of social members by id.
                GetSocialMemberResponse result = apiInstance.GetMembers(memberIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.GetMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberIds** | [**List&lt;int?&gt;**](int?.md)| maxItems:300 | 

### Return type

[**GetSocialMemberResponse**](GetSocialMemberResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmembersbetstats"></a>
# **GetMembersBetStats**
> InlineResponse20064 GetMembersBetStats (List<int?> memberIds)

Get the bet stats for a list of members.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMembersBetStatsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();
            var memberIds = new List<int?>(); // List<int?> | 

            try
            {
                // Get the bet stats for a list of members.
                InlineResponse20064 result = apiInstance.GetMembersBetStats(memberIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.GetMembersBetStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberIds** | [**List&lt;int?&gt;**](int?.md)|  | 

### Return type

[**InlineResponse20064**](InlineResponse20064.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getunreadactivitycount"></a>
# **GetUnreadActivityCount**
> GetUnreadActivityCountResponse GetUnreadActivityCount ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUnreadActivityCountExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();

            try
            {
                GetUnreadActivityCountResponse result = apiInstance.GetUnreadActivityCount();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.GetUnreadActivityCount: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetUnreadActivityCountResponse**](GetUnreadActivityCountResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="searchmembers"></a>
# **SearchMembers**
> GetSocialMemberResponse SearchMembers (string displayName = null, string username = null, int? limit = null, int? paginationLastId = null)

Retrieve members based on filters.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchMembersExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();
            var displayName = displayName_example;  // string |  (optional) 
            var username = username_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional)  (default to 50)
            var paginationLastId = 56;  // int? |  (optional) 

            try
            {
                // Retrieve members based on filters.
                GetSocialMemberResponse result = apiInstance.SearchMembers(displayName, username, limit, paginationLastId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.SearchMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **displayName** | **string**|  | [optional] 
 **username** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] [default to 50]
 **paginationLastId** | **int?**|  | [optional] 

### Return type

[**GetSocialMemberResponse**](GetSocialMemberResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="setactivityread"></a>
# **SetActivityRead**
> Object SetActivityRead (SetActivityReadRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetActivityReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();
            var body = new SetActivityReadRequest(); // SetActivityReadRequest | JSON Request object (optional) 

            try
            {
                Object result = apiInstance.SetActivityRead(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.SetActivityRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SetActivityReadRequest**](SetActivityReadRequest.md)| JSON Request object | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatemember"></a>
# **UpdateMember**
> GetSocialMemberResponse UpdateMember (UpdateMemberRequest body = null)

Update member data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateMemberExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();
            var body = new UpdateMemberRequest(); // UpdateMemberRequest | JSON Request object (optional) 

            try
            {
                // Update member data.
                GetSocialMemberResponse result = apiInstance.UpdateMember(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.UpdateMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateMemberRequest**](UpdateMemberRequest.md)| JSON Request object | [optional] 

### Return type

[**GetSocialMemberResponse**](GetSocialMemberResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatememberphoto"></a>
# **UpdateMemberPhoto**
> GetSocialMemberResponse UpdateMemberPhoto ()

Update the member's photo.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateMemberPhotoExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();

            try
            {
                // Update the member's photo.
                GetSocialMemberResponse result = apiInstance.UpdateMemberPhoto();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.UpdateMemberPhoto: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetSocialMemberResponse**](GetSocialMemberResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="uploadsharedimage"></a>
# **UploadSharedImage**
> SetImageResponse UploadSharedImage ()

Upload an image.

 ##  Rate limits Maximum 5 requests per 60 seconds<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadSharedImageExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();

            try
            {
                // Upload an image.
                SetImageResponse result = apiInstance.UploadSharedImage();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.UploadSharedImage: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SetImageResponse**](SetImageResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="upsertrelationship"></a>
# **UpsertRelationship**
> UpsertRelationshipResponse UpsertRelationship (UpsertRelationshipRequest body = null)

Upsert the member's relationship to the targeted member.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpsertRelationshipExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SocialApi();
            var body = new UpsertRelationshipRequest(); // UpsertRelationshipRequest | JSON Request object (optional) 

            try
            {
                // Upsert the member's relationship to the targeted member.
                UpsertRelationshipResponse result = apiInstance.UpsertRelationship(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.UpsertRelationship: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpsertRelationshipRequest**](UpsertRelationshipRequest.md)| JSON Request object | [optional] 

### Return type

[**UpsertRelationshipResponse**](UpsertRelationshipResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
