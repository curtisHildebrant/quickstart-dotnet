using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHMACSignaturesApi
    {
        /// <summary>
        /// Return HMAC signatures This REST API reference describes how to return unique signature and token values that used to process a [CORS enabled API call](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics/G_CORS_REST). 
        /// </summary>
        /// <param name="request"></param>
        /// <returns>POSTHMACSignatureResponseType</returns>
        POSTHMACSignatureResponseType POSTHMACSignature (POSTHMACSignatureType request);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class HMACSignaturesApi : IHMACSignaturesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HMACSignaturesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public HMACSignaturesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HMACSignaturesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HMACSignaturesApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Return HMAC signatures This REST API reference describes how to return unique signature and token values that used to process a [CORS enabled API call](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics/G_CORS_REST). 
        /// </summary>
        /// <param name="request"></param> 
        /// <returns>POSTHMACSignatureResponseType</returns>            
        public POSTHMACSignatureResponseType POSTHMACSignature (POSTHMACSignatureType request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTHMACSignature");
            
    
            var path = "/hmac-signatures";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTHMACSignature: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTHMACSignature: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTHMACSignatureResponseType) ApiClient.Deserialize(response.Content, typeof(POSTHMACSignatureResponseType), response.Headers);
        }
    
    }
}
