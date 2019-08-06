/* 
 * Prepaidforge API
 *
 * The public api for prepaidforge
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PrepaidforgeSDK.Client;
using PrepaidforgeSDK.Model;

namespace PrepaidforgeSDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductsStocksApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves all products
        /// </remarks>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Product&gt;</returns>
        List<Product> FindAllProducts ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves all products
        /// </remarks>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Product&gt;</returns>
        ApiResponse<List<Product>> FindAllProductsWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Find Stocks
        /// </remarks>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stockRequest"> (optional)</param>
        /// <returns>List&lt;SimpleStockPojo&gt;</returns>
        List<SimpleStockPojo> FindAllStocks (StockRequest stockRequest = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Find Stocks
        /// </remarks>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stockRequest"> (optional)</param>
        /// <returns>ApiResponse of List&lt;SimpleStockPojo&gt;</returns>
        ApiResponse<List<SimpleStockPojo>> FindAllStocksWithHttpInfo (StockRequest stockRequest = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves all products
        /// </remarks>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Product&gt;</returns>
        System.Threading.Tasks.Task<List<Product>> FindAllProductsAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves all products
        /// </remarks>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Product&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Product>>> FindAllProductsAsyncWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Find Stocks
        /// </remarks>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stockRequest"> (optional)</param>
        /// <returns>Task of List&lt;SimpleStockPojo&gt;</returns>
        System.Threading.Tasks.Task<List<SimpleStockPojo>> FindAllStocksAsync (StockRequest stockRequest = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Find Stocks
        /// </remarks>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stockRequest"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;SimpleStockPojo&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SimpleStockPojo>>> FindAllStocksAsyncWithHttpInfo (StockRequest stockRequest = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProductsStocksApi : IProductsStocksApi
    {
        private PrepaidforgeSDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsStocksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductsStocksApi(String basePath)
        {
            this.Configuration = new PrepaidforgeSDK.Client.Configuration { BasePath = basePath };

            ExceptionFactory = PrepaidforgeSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsStocksApi"/> class
        /// </summary>
        /// <returns></returns>
        public ProductsStocksApi()
        {
            this.Configuration = PrepaidforgeSDK.Client.Configuration.Default;

            ExceptionFactory = PrepaidforgeSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsStocksApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductsStocksApi(PrepaidforgeSDK.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = PrepaidforgeSDK.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = PrepaidforgeSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public PrepaidforgeSDK.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public PrepaidforgeSDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  Retrieves all products
        /// </summary>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Product&gt;</returns>
        public List<Product> FindAllProducts ()
        {
             ApiResponse<List<Product>> localVarResponse = FindAllProductsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves all products
        /// </summary>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Product&gt;</returns>
        public ApiResponse< List<Product> > FindAllProductsWithHttpInfo ()
        {

            var localVarPath = "/1.0/findAllProducts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FindAllProducts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Product>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<Product>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Product>)));
        }

        /// <summary>
        ///  Retrieves all products
        /// </summary>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Product&gt;</returns>
        public async System.Threading.Tasks.Task<List<Product>> FindAllProductsAsync ()
        {
             ApiResponse<List<Product>> localVarResponse = await FindAllProductsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Retrieves all products
        /// </summary>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Product&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Product>>> FindAllProductsAsyncWithHttpInfo ()
        {

            var localVarPath = "/1.0/findAllProducts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FindAllProducts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Product>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<Product>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Product>)));
        }

        /// <summary>
        ///  Find Stocks
        /// </summary>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stockRequest"> (optional)</param>
        /// <returns>List&lt;SimpleStockPojo&gt;</returns>
        public List<SimpleStockPojo> FindAllStocks (StockRequest stockRequest = null)
        {
             ApiResponse<List<SimpleStockPojo>> localVarResponse = FindAllStocksWithHttpInfo(stockRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Find Stocks
        /// </summary>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stockRequest"> (optional)</param>
        /// <returns>ApiResponse of List&lt;SimpleStockPojo&gt;</returns>
        public ApiResponse< List<SimpleStockPojo> > FindAllStocksWithHttpInfo (StockRequest stockRequest = null)
        {

            var localVarPath = "/1.0/findStocks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stockRequest != null && stockRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(stockRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = stockRequest; // byte array
            }

            // authentication (PrepaidforgeAPIToken) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-PrepaidForge-Api-Token")))
            {
                localVarHeaderParams["X-PrepaidForge-Api-Token"] = this.Configuration.GetApiKeyWithPrefix("X-PrepaidForge-Api-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FindAllStocks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SimpleStockPojo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<SimpleStockPojo>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SimpleStockPojo>)));
        }

        /// <summary>
        ///  Find Stocks
        /// </summary>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stockRequest"> (optional)</param>
        /// <returns>Task of List&lt;SimpleStockPojo&gt;</returns>
        public async System.Threading.Tasks.Task<List<SimpleStockPojo>> FindAllStocksAsync (StockRequest stockRequest = null)
        {
             ApiResponse<List<SimpleStockPojo>> localVarResponse = await FindAllStocksAsyncWithHttpInfo(stockRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Find Stocks
        /// </summary>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stockRequest"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;SimpleStockPojo&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SimpleStockPojo>>> FindAllStocksAsyncWithHttpInfo (StockRequest stockRequest = null)
        {

            var localVarPath = "/1.0/findStocks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stockRequest != null && stockRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(stockRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = stockRequest; // byte array
            }

            // authentication (PrepaidforgeAPIToken) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-PrepaidForge-Api-Token")))
            {
                localVarHeaderParams["X-PrepaidForge-Api-Token"] = this.Configuration.GetApiKeyWithPrefix("X-PrepaidForge-Api-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FindAllStocks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SimpleStockPojo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<SimpleStockPojo>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SimpleStockPojo>)));
        }

    }
}
