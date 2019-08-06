# PrepaidforgeSDK.Api.UserApi

All URIs are relative to *http://localhost:8080/api-1.0-SNAPSHOT/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SignInWithApi**](UserApi.md#signinwithapi) | **POST** /1.0/signInWithApi | 



## SignInWithApi

> ApiSignInResponse SignInWithApi (MerchantSignInRequest merchantSignInRequest = null)



Sign in link for api users

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PrepaidforgeSDK.Api;
using PrepaidforgeSDK.Client;
using PrepaidforgeSDK.Model;

namespace Example
{
    public class SignInWithApiExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8080/api-1.0-SNAPSHOT/v1";
            var apiInstance = new UserApi(Configuration.Default);
            var merchantSignInRequest = new MerchantSignInRequest(); // MerchantSignInRequest |  (optional) 

            try
            {
                ApiSignInResponse result = apiInstance.SignInWithApi(merchantSignInRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.SignInWithApi: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantSignInRequest** | [**MerchantSignInRequest**](MerchantSignInRequest.md)|  | [optional] 

### Return type

[**ApiSignInResponse**](ApiSignInResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | default response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

