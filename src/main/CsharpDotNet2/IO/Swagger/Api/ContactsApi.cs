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
    public interface IContactsApi
    {
        /// <summary>
        /// CRUD: Delete Contact 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <returns>ProxyDeleteResponse</returns>
        ProxyDeleteResponse ProxyDELETEContact (string id);
        /// <summary>
        /// CRUD: Retrieve Contact 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="fields">Object fields to return</param>
        /// <returns>ProxyGetContact</returns>
        ProxyGetContact ProxyGETContact (string id, string fields);
        /// <summary>
        /// CRUD: Create Contact 
        /// </summary>
        /// <param name="createRequest"></param>
        /// <returns>ProxyCreateOrModifyResponse</returns>
        ProxyCreateOrModifyResponse ProxyPOSTContact (ProxyCreateContact createRequest);
        /// <summary>
        /// CRUD: Update Contact 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="modifyRequest"></param>
        /// <returns>ProxyCreateOrModifyResponse</returns>
        ProxyCreateOrModifyResponse ProxyPUTContact (string id, ProxyModifyContact modifyRequest);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContactsApi : IContactsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ContactsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContactsApi(String basePath)
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
        /// CRUD: Delete Contact 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <returns>ProxyDeleteResponse</returns>            
        public ProxyDeleteResponse ProxyDELETEContact (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyDELETEContact");
            
    
            var path = "/object/contact/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETEContact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETEContact: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyDeleteResponse) ApiClient.Deserialize(response.Content, typeof(ProxyDeleteResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Retrieve Contact 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="fields">Object fields to return</param> 
        /// <returns>ProxyGetContact</returns>            
        public ProxyGetContact ProxyGETContact (string id, string fields)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyGETContact");
            
    
            var path = "/object/contact/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETContact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETContact: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyGetContact) ApiClient.Deserialize(response.Content, typeof(ProxyGetContact), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Create Contact 
        /// </summary>
        /// <param name="createRequest"></param> 
        /// <returns>ProxyCreateOrModifyResponse</returns>            
        public ProxyCreateOrModifyResponse ProxyPOSTContact (ProxyCreateContact createRequest)
        {
            
            // verify the required parameter 'createRequest' is set
            if (createRequest == null) throw new ApiException(400, "Missing required parameter 'createRequest' when calling ProxyPOSTContact");
            
    
            var path = "/object/contact";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPOSTContact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPOSTContact: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyCreateOrModifyResponse) ApiClient.Deserialize(response.Content, typeof(ProxyCreateOrModifyResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Update Contact 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="modifyRequest"></param> 
        /// <returns>ProxyCreateOrModifyResponse</returns>            
        public ProxyCreateOrModifyResponse ProxyPUTContact (string id, ProxyModifyContact modifyRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyPUTContact");
            
            // verify the required parameter 'modifyRequest' is set
            if (modifyRequest == null) throw new ApiException(400, "Missing required parameter 'modifyRequest' when calling ProxyPUTContact");
            
    
            var path = "/object/contact/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPUTContact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPUTContact: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyCreateOrModifyResponse) ApiClient.Deserialize(response.Content, typeof(ProxyCreateOrModifyResponse), response.Headers);
        }
    
    }
}
