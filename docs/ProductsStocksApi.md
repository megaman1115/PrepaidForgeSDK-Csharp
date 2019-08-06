# PrepaidforgeSDK.Api.ProductsStocksApi

All URIs are relative to *http://localhost:8080/api-1.0-SNAPSHOT/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FindAllProducts**](ProductsStocksApi.md#findallproducts) | **GET** /1.0/findAllProducts | 
[**FindAllStocks**](ProductsStocksApi.md#findallstocks) | **POST** /1.0/findStocks | 



## FindAllProducts

> List&lt;Product&gt; FindAllProducts ()



Retrieves all products

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PrepaidforgeSDK.Api;
using PrepaidforgeSDK.Client;
using PrepaidforgeSDK.Model;

namespace Example
{
    public class FindAllProductsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8080/api-1.0-SNAPSHOT/v1";
            var apiInstance = new ProductsStocksApi(Configuration.Default);

            try
            {
                List<Product> result = apiInstance.FindAllProducts();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProductsStocksApi.FindAllProducts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**List&lt;Product&gt;**](Product.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | default response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## FindAllStocks

> List&lt;SimpleStockPojo&gt; FindAllStocks (StockRequest stockRequest = null)



Find Stocks

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PrepaidforgeSDK.Api;
using PrepaidforgeSDK.Client;
using PrepaidforgeSDK.Model;

namespace Example
{
    public class FindAllStocksExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8080/api-1.0-SNAPSHOT/v1";
            // Configure API key authorization: PrepaidforgeAPIToken
            Configuration.Default.AddApiKey("X-PrepaidForge-Api-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-PrepaidForge-Api-Token", "Bearer");

            var apiInstance = new ProductsStocksApi(Configuration.Default);
            var stockRequest = new StockRequest(); // StockRequest |  (optional) 

            try
            {
                List<SimpleStockPojo> result = apiInstance.FindAllStocks(stockRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProductsStocksApi.FindAllStocks: " + e.Message );
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
 **stockRequest** | [**StockRequest**](StockRequest.md)|  | [optional] 

### Return type

[**List&lt;SimpleStockPojo&gt;**](SimpleStockPojo.md)

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

