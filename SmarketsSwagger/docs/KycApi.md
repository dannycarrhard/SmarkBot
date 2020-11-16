# IO.Swagger.Api.KycApi

All URIs are relative to *https://api.smarkets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDocumentProofsUnderReview**](KycApi.md#getdocumentproofsunderreview) | **GET** /v3/kyc_files/reviewing/ | Get KYC document proofs that member has submitted and are under review.
[**GetRequiredDocumentProofs**](KycApi.md#getrequireddocumentproofs) | **GET** /v3/kyc_files/required/ | Get KYC document proofs that member needs to submit.
[**GetUserRequirement**](KycApi.md#getuserrequirement) | **GET** /v3/kyc/requirements/ | Get additional information that user needs to provide.
[**IsFileCheckInProgress**](KycApi.md#isfilecheckinprogress) | **GET** /v3/kyc_files/check_in_progress/ | Check whether a document review for a particular member and document type is in progress.
[**KycFileUpload**](KycApi.md#kycfileupload) | **POST** /v3/kyc_files/ |      Upload file needed for KYC verification.
[**KycFileUploadV0**](KycApi.md#kycfileuploadv0) | **POST** /v0/users/kyc/file-upload/{token}/ | 
[**ValidateKycToken**](KycApi.md#validatekyctoken) | **POST** /v3/kyc_tokens/ | Validate the provided KYC token.
[**ValidateKycTokenV0**](KycApi.md#validatekyctokenv0) | **POST** /v0/users/kyc/kyc-token/ | 

<a name="getdocumentproofsunderreview"></a>
# **GetDocumentProofsUnderReview**
> InlineResponse20042 GetDocumentProofsUnderReview (string token = null)

Get KYC document proofs that member has submitted and are under review.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDocumentProofsUnderReviewExample
    {
        public void main()
        {
            var apiInstance = new KycApi();
            var token = token_example;  // string |  (optional) 

            try
            {
                // Get KYC document proofs that member has submitted and are under review.
                InlineResponse20042 result = apiInstance.GetDocumentProofsUnderReview(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KycApi.GetDocumentProofsUnderReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**|  | [optional] 

### Return type

[**InlineResponse20042**](InlineResponse20042.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrequireddocumentproofs"></a>
# **GetRequiredDocumentProofs**
> InlineResponse20041 GetRequiredDocumentProofs (string token = null)

Get KYC document proofs that member needs to submit.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRequiredDocumentProofsExample
    {
        public void main()
        {
            var apiInstance = new KycApi();
            var token = token_example;  // string |  (optional) 

            try
            {
                // Get KYC document proofs that member needs to submit.
                InlineResponse20041 result = apiInstance.GetRequiredDocumentProofs(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KycApi.GetRequiredDocumentProofs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**|  | [optional] 

### Return type

[**InlineResponse20041**](InlineResponse20041.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getuserrequirement"></a>
# **GetUserRequirement**
> InlineResponse20040 GetUserRequirement (string token = null)

Get additional information that user needs to provide.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserRequirementExample
    {
        public void main()
        {
            var apiInstance = new KycApi();
            var token = token_example;  // string |  (optional) 

            try
            {
                // Get additional information that user needs to provide.
                InlineResponse20040 result = apiInstance.GetUserRequirement(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KycApi.GetUserRequirement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**|  | [optional] 

### Return type

[**InlineResponse20040**](InlineResponse20040.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="isfilecheckinprogress"></a>
# **IsFileCheckInProgress**
> IsFileCheckInProgress IsFileCheckInProgress (string type = null, string token = null)

Check whether a document review for a particular member and document type is in progress.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IsFileCheckInProgressExample
    {
        public void main()
        {
            var apiInstance = new KycApi();
            var type = type_example;  // string |  (optional) 
            var token = token_example;  // string |  (optional) 

            try
            {
                // Check whether a document review for a particular member and document type is in progress.
                IsFileCheckInProgress result = apiInstance.IsFileCheckInProgress(type, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KycApi.IsFileCheckInProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**|  | [optional] 
 **token** | **string**|  | [optional] 

### Return type

[**IsFileCheckInProgress**](IsFileCheckInProgress.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="kycfileupload"></a>
# **KycFileUpload**
> FileUploadResultResponse KycFileUpload ()

     Upload file needed for KYC verification.

## Description Allowed extensions are pdf, png, jpg, or jpeg and maximum file size is 5MB.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class KycFileUploadExample
    {
        public void main()
        {
            var apiInstance = new KycApi();

            try
            {
                //      Upload file needed for KYC verification.
                FileUploadResultResponse result = apiInstance.KycFileUpload();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KycApi.KycFileUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**FileUploadResultResponse**](FileUploadResultResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="kycfileuploadv0"></a>
# **KycFileUploadV0**
> List<InlineResponse20030> KycFileUploadV0 (string token)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class KycFileUploadV0Example
    {
        public void main()
        {
            var apiInstance = new KycApi();
            var token = token_example;  // string | 

            try
            {
                List&lt;InlineResponse20030&gt; result = apiInstance.KycFileUploadV0(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KycApi.KycFileUploadV0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**|  | 

### Return type

[**List<InlineResponse20030>**](InlineResponse20030.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="validatekyctoken"></a>
# **ValidateKycToken**
> Object ValidateKycToken (Body30 body = null)

Validate the provided KYC token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ValidateKycTokenExample
    {
        public void main()
        {
            var apiInstance = new KycApi();
            var body = new Body30(); // Body30 | JSON Request object (optional) 

            try
            {
                // Validate the provided KYC token.
                Object result = apiInstance.ValidateKycToken(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KycApi.ValidateKycToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body30**](Body30.md)| JSON Request object | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="validatekyctokenv0"></a>
# **ValidateKycTokenV0**
> InlineResponse20026 ValidateKycTokenV0 (Body16 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ValidateKycTokenV0Example
    {
        public void main()
        {
            var apiInstance = new KycApi();
            var body = new Body16(); // Body16 | JSON Request object (optional) 

            try
            {
                InlineResponse20026 result = apiInstance.ValidateKycTokenV0(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KycApi.ValidateKycTokenV0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body16**](Body16.md)| JSON Request object | [optional] 

### Return type

[**InlineResponse20026**](InlineResponse20026.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
