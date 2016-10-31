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
    public interface IRefundTransactionLogsApi
    {
        /// <summary>
        /// CRUD: Delete RefundTransactionLog 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <returns>ProxyDeleteResponse</returns>
        ProxyDeleteResponse ProxyDELETERefundTransactionLog (string id);
        /// <summary>
        /// CRUD: Retrieve RefundTransactionLog 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="fields">Object fields to return</param>
        /// <returns>ProxyGetRefundTransactionLog</returns>
        ProxyGetRefundTransactionLog ProxyGETRefundTransactionLog (string id, string fields);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RefundTransactionLogsApi : IRefundTransactionLogsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundTransactionLogsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RefundTransactionLogsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundTransactionLogsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RefundTransactionLogsApi(String basePath)
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
        /// CRUD: Delete RefundTransactionLog 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <returns>ProxyDeleteResponse</returns>            
        public ProxyDeleteResponse ProxyDELETERefundTransactionLog (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyDELETERefundTransactionLog");
            
    
            var path = "/object/refund-transaction-log/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETERefundTransactionLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETERefundTransactionLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyDeleteResponse) ApiClient.Deserialize(response.Content, typeof(ProxyDeleteResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Retrieve RefundTransactionLog 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="fields">Object fields to return</param> 
        /// <returns>ProxyGetRefundTransactionLog</returns>            
        public ProxyGetRefundTransactionLog ProxyGETRefundTransactionLog (string id, string fields)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyGETRefundTransactionLog");
            
    
            var path = "/object/refund-transaction-log/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETRefundTransactionLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETRefundTransactionLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyGetRefundTransactionLog) ApiClient.Deserialize(response.Content, typeof(ProxyGetRefundTransactionLog), response.Headers);
        }
    
    }
}
