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
    public interface IRatePlanChargeTiersApi
    {
        /// <summary>
        /// CRUD: Delete RatePlanChargeTier 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <returns>ProxyDeleteResponse</returns>
        ProxyDeleteResponse ProxyDELETERatePlanChargeTier (string id);
        /// <summary>
        /// CRUD: Retrieve RatePlanChargeTier 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="fields">Object fields to return</param>
        /// <returns>ProxyGetRatePlanChargeTier</returns>
        ProxyGetRatePlanChargeTier ProxyGETRatePlanChargeTier (string id, string fields);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RatePlanChargeTiersApi : IRatePlanChargeTiersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RatePlanChargeTiersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RatePlanChargeTiersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RatePlanChargeTiersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RatePlanChargeTiersApi(String basePath)
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
        /// CRUD: Delete RatePlanChargeTier 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <returns>ProxyDeleteResponse</returns>            
        public ProxyDeleteResponse ProxyDELETERatePlanChargeTier (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyDELETERatePlanChargeTier");
            
    
            var path = "/object/rate-plan-charge-tier/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETERatePlanChargeTier: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETERatePlanChargeTier: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyDeleteResponse) ApiClient.Deserialize(response.Content, typeof(ProxyDeleteResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Retrieve RatePlanChargeTier 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="fields">Object fields to return</param> 
        /// <returns>ProxyGetRatePlanChargeTier</returns>            
        public ProxyGetRatePlanChargeTier ProxyGETRatePlanChargeTier (string id, string fields)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyGETRatePlanChargeTier");
            
    
            var path = "/object/rate-plan-charge-tier/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETRatePlanChargeTier: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETRatePlanChargeTier: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyGetRatePlanChargeTier) ApiClient.Deserialize(response.Content, typeof(ProxyGetRatePlanChargeTier), response.Headers);
        }
    
    }
}
