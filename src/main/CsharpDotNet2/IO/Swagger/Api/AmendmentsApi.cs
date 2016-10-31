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
    public interface IAmendmentsApi
    {
        /// <summary>
        /// Get amendments by key Retrieves detailed information about the specified subscription amendment.
        /// </summary>
        /// <param name="amendmentKey">Can be the amendment ID or the amendment code.</param>
        /// <returns>GETAmendmentType</returns>
        GETAmendmentType GETAmendment (string amendmentKey);
        /// <summary>
        /// Get amendments by subscription ID Retrieves detailed information about the amendment with the specified subscription.
        /// </summary>
        /// <param name="subscriptionId">The ID of the subscription whose amendment changes you want to retrieve.</param>
        /// <returns>GETAmendmentType</returns>
        GETAmendmentType GETAmendmentsBySubscriptionID (string subscriptionId);
        /// <summary>
        /// CRUD: Delete Amendment 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <returns>ProxyDeleteResponse</returns>
        ProxyDeleteResponse ProxyDELETEAmendment (string id);
        /// <summary>
        /// CRUD: Retrieve Amendment 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="fields">Object fields to return</param>
        /// <returns>ProxyGetAmendment</returns>
        ProxyGetAmendment ProxyGETAmendment (string id, string fields);
        /// <summary>
        /// CRUD: Create Amendment 
        /// </summary>
        /// <param name="createRequest"></param>
        /// <returns>ProxyCreateOrModifyResponse</returns>
        ProxyCreateOrModifyResponse ProxyPOSTAmendment (ProxyCreateAmendment createRequest);
        /// <summary>
        /// CRUD: Update Amendment 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="modifyRequest"></param>
        /// <returns>ProxyCreateOrModifyResponse</returns>
        ProxyCreateOrModifyResponse ProxyPUTAmendment (string id, ProxyModifyAmendment modifyRequest);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AmendmentsApi : IAmendmentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmendmentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AmendmentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AmendmentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AmendmentsApi(String basePath)
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
        /// Get amendments by key Retrieves detailed information about the specified subscription amendment.
        /// </summary>
        /// <param name="amendmentKey">Can be the amendment ID or the amendment code.</param> 
        /// <returns>GETAmendmentType</returns>            
        public GETAmendmentType GETAmendment (string amendmentKey)
        {
            
            // verify the required parameter 'amendmentKey' is set
            if (amendmentKey == null) throw new ApiException(400, "Missing required parameter 'amendmentKey' when calling GETAmendment");
            
    
            var path = "/amendments/{amendment-key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "amendment-key" + "}", ApiClient.ParameterToString(amendmentKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAmendment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAmendment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETAmendmentType) ApiClient.Deserialize(response.Content, typeof(GETAmendmentType), response.Headers);
        }
    
        /// <summary>
        /// Get amendments by subscription ID Retrieves detailed information about the amendment with the specified subscription.
        /// </summary>
        /// <param name="subscriptionId">The ID of the subscription whose amendment changes you want to retrieve.</param> 
        /// <returns>GETAmendmentType</returns>            
        public GETAmendmentType GETAmendmentsBySubscriptionID (string subscriptionId)
        {
            
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null) throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling GETAmendmentsBySubscriptionID");
            
    
            var path = "/amendments/subscriptions/{subscription-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "subscription-id" + "}", ApiClient.ParameterToString(subscriptionId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAmendmentsBySubscriptionID: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAmendmentsBySubscriptionID: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETAmendmentType) ApiClient.Deserialize(response.Content, typeof(GETAmendmentType), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Delete Amendment 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <returns>ProxyDeleteResponse</returns>            
        public ProxyDeleteResponse ProxyDELETEAmendment (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyDELETEAmendment");
            
    
            var path = "/object/amendment/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETEAmendment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETEAmendment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyDeleteResponse) ApiClient.Deserialize(response.Content, typeof(ProxyDeleteResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Retrieve Amendment 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="fields">Object fields to return</param> 
        /// <returns>ProxyGetAmendment</returns>            
        public ProxyGetAmendment ProxyGETAmendment (string id, string fields)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyGETAmendment");
            
    
            var path = "/object/amendment/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETAmendment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETAmendment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyGetAmendment) ApiClient.Deserialize(response.Content, typeof(ProxyGetAmendment), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Create Amendment 
        /// </summary>
        /// <param name="createRequest"></param> 
        /// <returns>ProxyCreateOrModifyResponse</returns>            
        public ProxyCreateOrModifyResponse ProxyPOSTAmendment (ProxyCreateAmendment createRequest)
        {
            
            // verify the required parameter 'createRequest' is set
            if (createRequest == null) throw new ApiException(400, "Missing required parameter 'createRequest' when calling ProxyPOSTAmendment");
            
    
            var path = "/object/amendment";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(createRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPOSTAmendment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPOSTAmendment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyCreateOrModifyResponse) ApiClient.Deserialize(response.Content, typeof(ProxyCreateOrModifyResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Update Amendment 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="modifyRequest"></param> 
        /// <returns>ProxyCreateOrModifyResponse</returns>            
        public ProxyCreateOrModifyResponse ProxyPUTAmendment (string id, ProxyModifyAmendment modifyRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyPUTAmendment");
            
            // verify the required parameter 'modifyRequest' is set
            if (modifyRequest == null) throw new ApiException(400, "Missing required parameter 'modifyRequest' when calling ProxyPUTAmendment");
            
    
            var path = "/object/amendment/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(modifyRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPUTAmendment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPUTAmendment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyCreateOrModifyResponse) ApiClient.Deserialize(response.Content, typeof(ProxyCreateOrModifyResponse), response.Headers);
        }
    
    }
}
