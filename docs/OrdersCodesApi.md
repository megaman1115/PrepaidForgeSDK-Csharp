# PrepaidforgeSDK.Api.OrdersCodesApi

All URIs are relative to *http://localhost:8080/api-1.0-SNAPSHOT/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSingleOrder**](OrdersCodesApi.md#createsingleorder) | **POST** /1.0/createOrder | 
[**GetResponseOfSingleCodeRequest**](OrdersCodesApi.md#getresponseofsinglecoderequest) | **POST** /1.0/getResponseOfSingleCodeRequest | 



## CreateSingleOrder

> CodeDeliveryPojo CreateSingleOrder (SkuRequest skuRequest = null)



creates order

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PrepaidforgeSDK.Api;
using PrepaidforgeSDK.Client;
using PrepaidforgeSDK.Model;

namespace Example
{
    public class CreateSingleOrderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8080/api-1.0-SNAPSHOT/v1";
            // Configure API key authorization: PrepaidforgeAPIToken
            Configuration.Default.AddApiKey("X-PrepaidForge-Api-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-PrepaidForge-Api-Token", "Bearer");

            var apiInstance = new OrdersCodesApi(Configuration.Default);
            var skuRequest = new SkuRequest(); // SkuRequest |  (optional) 

            try
            {
                CodeDeliveryPojo result = apiInstance.CreateSingleOrder(skuRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrdersCodesApi.CreateSingleOrder: " + e.Message );
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
 **skuRequest** | [**SkuRequest**](SkuRequest.md)|  | [optional] 

### Return type

[**CodeDeliveryPojo**](CodeDeliveryPojo.md)

### Authorization

[PrepaidforgeAPIToken](../README.md#PrepaidforgeAPIToken)

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


## GetResponseOfSingleCodeRequest

> CodeDeliveryPojo GetResponseOfSingleCodeRequest (SkuRequest skuRequest = null)



Retrieve code using custom order reference

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PrepaidforgeSDK.Api;
using PrepaidforgeSDK.Client;
using PrepaidforgeSDK.Model;

namespace Example
{
    public class GetResponseOfSingleCodeRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8080/api-1.0-SNAPSHOT/v1";
            // Configure API key authorization: PrepaidforgeAPIToken
            Configuration.Default.AddApiKey("X-PrepaidForge-Api-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-PrepaidForge-Api-Token", "Bearer");

            var apiInstance = new OrdersCodesApi(Configuration.Default);
            var skuRequest = new SkuRequest(); // SkuRequest |  (optional) 

            try
            {
                CodeDeliveryPojo result = apiInstance.GetResponseOfSingleCodeRequest(skuRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrdersCodesApi.GetResponseOfSingleCodeRequest: " + e.Message );
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
 **skuRequest** | [**SkuRequest**](SkuRequest.md)|  | [optional] 

### Return type

[**CodeDeliveryPojo**](CodeDeliveryPojo.md)

### Authorization

[PrepaidforgeAPIToken](../README.md#PrepaidforgeAPIToken)

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

