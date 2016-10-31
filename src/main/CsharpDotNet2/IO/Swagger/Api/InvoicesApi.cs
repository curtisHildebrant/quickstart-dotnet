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
    public interface IInvoicesApi
    {
        /// <summary>
        /// CRUD: Delete Invoice 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <returns>ProxyDeleteResponse</returns>
        ProxyDeleteResponse ProxyDELETEInvoice (string id);
        /// <summary>
        /// CRUD: Retrieve Invoice 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="fields">Object fields to return</param>
        /// <returns>ProxyGetInvoice</returns>
        ProxyGetInvoice ProxyGETInvoice (string id, string fields);
        /// <summary>
        /// CRUD: Create Invoice 
        /// </summary>
        /// <param name="createRequest"></param>
        /// <returns>ProxyCreateOrModifyResponse</returns>
        ProxyCreateOrModifyResponse ProxyPOSTInvoice (ProxyCreateInvoice createRequest);
        /// <summary>
        /// CRUD: Update Invoice 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="modifyRequest"></param>
        /// <returns>ProxyCreateOrModifyResponse</returns>
        ProxyCreateOrModifyResponse ProxyPUTInvoice (string id, ProxyModifyInvoice modifyRequest);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InvoicesApi : IInvoicesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public InvoicesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InvoicesApi(String basePath)
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
        /// CRUD: Delete Invoice 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <returns>ProxyDeleteResponse</returns>            
        public ProxyDeleteResponse ProxyDELETEInvoice (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyDELETEInvoice");
            
    
            var path = "/object/invoice/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETEInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETEInvoice: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyDeleteResponse) ApiClient.Deserialize(response.Content, typeof(ProxyDeleteResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Retrieve Invoice 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="fields">Object fields to return</param> 
        /// <returns>ProxyGetInvoice</returns>            
        public ProxyGetInvoice ProxyGETInvoice (string id, string fields)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyGETInvoice");
            
    
            var path = "/object/invoice/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETInvoice: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyGetInvoice) ApiClient.Deserialize(response.Content, typeof(ProxyGetInvoice), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Create Invoice 
        /// </summary>
        /// <param name="createRequest"></param> 
        /// <returns>ProxyCreateOrModifyResponse</returns>            
        public ProxyCreateOrModifyResponse ProxyPOSTInvoice (ProxyCreateInvoice createRequest)
        {
            
            // verify the required parameter 'createRequest' is set
            if (createRequest == null) throw new ApiException(400, "Missing required parameter 'createRequest' when calling ProxyPOSTInvoice");
            
    
            var path = "/object/invoice";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPOSTInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPOSTInvoice: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyCreateOrModifyResponse) ApiClient.Deserialize(response.Content, typeof(ProxyCreateOrModifyResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Update Invoice 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="modifyRequest"></param> 
        /// <returns>ProxyCreateOrModifyResponse</returns>            
        public ProxyCreateOrModifyResponse ProxyPUTInvoice (string id, ProxyModifyInvoice modifyRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyPUTInvoice");
            
            // verify the required parameter 'modifyRequest' is set
            if (modifyRequest == null) throw new ApiException(400, "Missing required parameter 'modifyRequest' when calling ProxyPUTInvoice");
            
    
            var path = "/object/invoice/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPUTInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPUTInvoice: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyCreateOrModifyResponse) ApiClient.Deserialize(response.Content, typeof(ProxyCreateOrModifyResponse), response.Headers);
        }
    
    }
}
