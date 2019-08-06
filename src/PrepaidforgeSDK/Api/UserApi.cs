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
    public interface IUserApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Sign in link for api users
        /// </remarks>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantSignInRequest"> (optional)</param>
        /// <returns>ApiSignInResponse</returns>
        ApiSignInResponse SignInWithApi (MerchantSignInRequest merchantSignInRequest = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Sign in link for api users
        /// </remarks>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantSignInRequest"> (optional)</param>
        /// <returns>ApiResponse of ApiSignInResponse</returns>
        ApiResponse<ApiSignInResponse> SignInWithApiWithHttpInfo (MerchantSignInRequest merchantSignInRequest = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Sign in link for api users
        /// </remarks>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantSignInRequest"> (optional)</param>
        /// <returns>Task of ApiSignInResponse</returns>
        System.Threading.Tasks.Task<ApiSignInResponse> SignInWithApiAsync (MerchantSignInRequest merchantSignInRequest = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Sign in link for api users
        /// </remarks>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantSignInRequest"> (optional)</param>
        /// <returns>Task of ApiResponse (ApiSignInResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiSignInResponse>> SignInWithApiAsyncWithHttpInfo (MerchantSignInRequest merchantSignInRequest = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserApi : IUserApi
    {
        private PrepaidforgeSDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(String basePath)
        {
            this.Configuration = new PrepaidforgeSDK.Client.Configuration { BasePath = basePath };

            ExceptionFactory = PrepaidforgeSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class
        /// </summary>
        /// <returns></returns>
        public UserApi()
        {
            this.Configuration = PrepaidforgeSDK.Client.Configuration.Default;

            ExceptionFactory = PrepaidforgeSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserApi(PrepaidforgeSDK.Client.Configuration configuration = null)
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
        ///  Sign in link for api users
        /// </summary>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantSignInRequest"> (optional)</param>
        /// <returns>ApiSignInResponse</returns>
        public ApiSignInResponse SignInWithApi (MerchantSignInRequest merchantSignInRequest = null)
        {
             ApiResponse<ApiSignInResponse> localVarResponse = SignInWithApiWithHttpInfo(merchantSignInRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Sign in link for api users
        /// </summary>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantSignInRequest"> (optional)</param>
        /// <returns>ApiResponse of ApiSignInResponse</returns>
        public ApiResponse< ApiSignInResponse > SignInWithApiWithHttpInfo (MerchantSignInRequest merchantSignInRequest = null)
        {

            var localVarPath = "/1.0/signInWithApi";
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

            if (merchantSignInRequest != null && merchantSignInRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(merchantSignInRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = merchantSignInRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SignInWithApi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiSignInResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ApiSignInResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiSignInResponse)));
        }

        /// <summary>
        ///  Sign in link for api users
        /// </summary>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantSignInRequest"> (optional)</param>
        /// <returns>Task of ApiSignInResponse</returns>
        public async System.Threading.Tasks.Task<ApiSignInResponse> SignInWithApiAsync (MerchantSignInRequest merchantSignInRequest = null)
        {
             ApiResponse<ApiSignInResponse> localVarResponse = await SignInWithApiAsyncWithHttpInfo(merchantSignInRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Sign in link for api users
        /// </summary>
        /// <exception cref="PrepaidforgeSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantSignInRequest"> (optional)</param>
        /// <returns>Task of ApiResponse (ApiSignInResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiSignInResponse>> SignInWithApiAsyncWithHttpInfo (MerchantSignInRequest merchantSignInRequest = null)
        {

            var localVarPath = "/1.0/signInWithApi";
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

            if (merchantSignInRequest != null && merchantSignInRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(merchantSignInRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = merchantSignInRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SignInWithApi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiSignInResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ApiSignInResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiSignInResponse)));
        }

    }
}
