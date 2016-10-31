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
    public interface IActionsApi
    {
        /// <summary>
        /// Action amend 
        /// </summary>
        /// <param name="amendRequest"></param>
        /// <returns>ProxyActionamendResponse</returns>
        ProxyActionamendResponse ProxyActionPOSTamend (ProxyActionamendRequest amendRequest);
        /// <summary>
        /// Action create 
        /// </summary>
        /// <param name="createRequest"></param>
        /// <returns>ProxyActioncreateResponse</returns>
        ProxyActioncreateResponse ProxyActionPOSTcreate (ProxyActioncreateRequest createRequest);
        /// <summary>
        /// Action createTenant 
        /// </summary>
        /// <param name="createTenantRequest"></param>
        /// <returns>ProxyActioncreateTenantResponse</returns>
        ProxyActioncreateTenantResponse ProxyActionPOSTcreateTenant (ProxyActioncreateTenantRequest createTenantRequest);
        /// <summary>
        /// Action delete 
        /// </summary>
        /// <param name="deleteRequest"></param>
        /// <returns>ProxyActiondeleteResponse</returns>
        ProxyActiondeleteResponse ProxyActionPOSTdelete (ProxyActiondeleteRequest deleteRequest);
        /// <summary>
        /// Action execute 
        /// </summary>
        /// <param name="executeRequest"></param>
        /// <returns>ProxyActionexecuteResponse</returns>
        ProxyActionexecuteResponse ProxyActionPOSTexecute (ProxyActionexecuteRequest executeRequest);
        /// <summary>
        /// Action generate 
        /// </summary>
        /// <param name="generateRequest"></param>
        /// <returns>ProxyActiongenerateResponse</returns>
        ProxyActiongenerateResponse ProxyActionPOSTgenerate (ProxyActiongenerateRequest generateRequest);
        /// <summary>
        /// Action getUserInfo 
        /// </summary>
        /// <returns>ProxyActiongetUserInfoResponse</returns>
        ProxyActiongetUserInfoResponse ProxyActionPOSTgetUserInfo ();
        /// <summary>
        /// Action login 
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns>ProxyActionloginResponse</returns>
        ProxyActionloginResponse ProxyActionPOSTlogin (ProxyActionloginRequest loginRequest);
        /// <summary>
        /// Action query 
        /// </summary>
        /// <param name="queryRequest"></param>
        /// <returns>ProxyActionqueryResponse</returns>
        ProxyActionqueryResponse ProxyActionPOSTquery (ProxyActionqueryRequest queryRequest);
        /// <summary>
        /// Action queryMore 
        /// </summary>
        /// <param name="queryMoreRequest"></param>
        /// <returns>ProxyActionqueryMoreResponse</returns>
        ProxyActionqueryMoreResponse ProxyActionPOSTqueryMore (ProxyActionqueryMoreRequest queryMoreRequest);
        /// <summary>
        /// Action rasd 
        /// </summary>
        /// <returns>ProxyActionrasdResponse</returns>
        ProxyActionrasdResponse ProxyActionPOSTrasd ();
        /// <summary>
        /// Action subscribe 
        /// </summary>
        /// <param name="subscribeRequest"></param>
        /// <returns>ProxyActionsubscribeResponse</returns>
        ProxyActionsubscribeResponse ProxyActionPOSTsubscribe (ProxyActionsubscribeRequest subscribeRequest);
        /// <summary>
        /// Action update 
        /// </summary>
        /// <param name="updateRequest"></param>
        /// <returns>ProxyActionupdateResponse</returns>
        ProxyActionupdateResponse ProxyActionPOSTupdate (ProxyActionupdateRequest updateRequest);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ActionsApi : IActionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ActionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ActionsApi(String basePath)
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
        /// Action amend 
        /// </summary>
        /// <param name="amendRequest"></param> 
        /// <returns>ProxyActionamendResponse</returns>            
        public ProxyActionamendResponse ProxyActionPOSTamend (ProxyActionamendRequest amendRequest)
        {
            
            // verify the required parameter 'amendRequest' is set
            if (amendRequest == null) throw new ApiException(400, "Missing required parameter 'amendRequest' when calling ProxyActionPOSTamend");
            
    
            var path = "/action/amend";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(amendRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTamend: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTamend: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyActionamendResponse) ApiClient.Deserialize(response.Content, typeof(ProxyActionamendResponse), response.Headers);
        }
    
        /// <summary>
        /// Action create 
        /// </summary>
        /// <param name="createRequest"></param> 
        /// <returns>ProxyActioncreateResponse</returns>            
        public ProxyActioncreateResponse ProxyActionPOSTcreate (ProxyActioncreateRequest createRequest)
        {
            
            // verify the required parameter 'createRequest' is set
            if (createRequest == null) throw new ApiException(400, "Missing required parameter 'createRequest' when calling ProxyActionPOSTcreate");
            
    
            var path = "/action/create";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTcreate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTcreate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyActioncreateResponse) ApiClient.Deserialize(response.Content, typeof(ProxyActioncreateResponse), response.Headers);
        }
    
        /// <summary>
        /// Action createTenant 
        /// </summary>
        /// <param name="createTenantRequest"></param> 
        /// <returns>ProxyActioncreateTenantResponse</returns>            
        public ProxyActioncreateTenantResponse ProxyActionPOSTcreateTenant (ProxyActioncreateTenantRequest createTenantRequest)
        {
            
            // verify the required parameter 'createTenantRequest' is set
            if (createTenantRequest == null) throw new ApiException(400, "Missing required parameter 'createTenantRequest' when calling ProxyActionPOSTcreateTenant");
            
    
            var path = "/action/createTenant";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(createTenantRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTcreateTenant: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTcreateTenant: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyActioncreateTenantResponse) ApiClient.Deserialize(response.Content, typeof(ProxyActioncreateTenantResponse), response.Headers);
        }
    
        /// <summary>
        /// Action delete 
        /// </summary>
        /// <param name="deleteRequest"></param> 
        /// <returns>ProxyActiondeleteResponse</returns>            
        public ProxyActiondeleteResponse ProxyActionPOSTdelete (ProxyActiondeleteRequest deleteRequest)
        {
            
            // verify the required parameter 'deleteRequest' is set
            if (deleteRequest == null) throw new ApiException(400, "Missing required parameter 'deleteRequest' when calling ProxyActionPOSTdelete");
            
    
            var path = "/action/delete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(deleteRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTdelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTdelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyActiondeleteResponse) ApiClient.Deserialize(response.Content, typeof(ProxyActiondeleteResponse), response.Headers);
        }
    
        /// <summary>
        /// Action execute 
        /// </summary>
        /// <param name="executeRequest"></param> 
        /// <returns>ProxyActionexecuteResponse</returns>            
        public ProxyActionexecuteResponse ProxyActionPOSTexecute (ProxyActionexecuteRequest executeRequest)
        {
            
            // verify the required parameter 'executeRequest' is set
            if (executeRequest == null) throw new ApiException(400, "Missing required parameter 'executeRequest' when calling ProxyActionPOSTexecute");
            
    
            var path = "/action/execute";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(executeRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTexecute: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTexecute: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyActionexecuteResponse) ApiClient.Deserialize(response.Content, typeof(ProxyActionexecuteResponse), response.Headers);
        }
    
        /// <summary>
        /// Action generate 
        /// </summary>
        /// <param name="generateRequest"></param> 
        /// <returns>ProxyActiongenerateResponse</returns>            
        public ProxyActiongenerateResponse ProxyActionPOSTgenerate (ProxyActiongenerateRequest generateRequest)
        {
            
            // verify the required parameter 'generateRequest' is set
            if (generateRequest == null) throw new ApiException(400, "Missing required parameter 'generateRequest' when calling ProxyActionPOSTgenerate");
            
    
            var path = "/action/generate";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(generateRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTgenerate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTgenerate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyActiongenerateResponse) ApiClient.Deserialize(response.Content, typeof(ProxyActiongenerateResponse), response.Headers);
        }
    
        /// <summary>
        /// Action getUserInfo 
        /// </summary>
        /// <returns>ProxyActiongetUserInfoResponse</returns>            
        public ProxyActiongetUserInfoResponse ProxyActionPOSTgetUserInfo ()
        {
            
    
            var path = "/action/getUserInfo";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTgetUserInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTgetUserInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyActiongetUserInfoResponse) ApiClient.Deserialize(response.Content, typeof(ProxyActiongetUserInfoResponse), response.Headers);
        }
    
        /// <summary>
        /// Action login 
        /// </summary>
        /// <param name="loginRequest"></param> 
        /// <returns>ProxyActionloginResponse</returns>            
        public ProxyActionloginResponse ProxyActionPOSTlogin (ProxyActionloginRequest loginRequest)
        {
            
            // verify the required parameter 'loginRequest' is set
            if (loginRequest == null) throw new ApiException(400, "Missing required parameter 'loginRequest' when calling ProxyActionPOSTlogin");
            
    
            var path = "/action/login";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(loginRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTlogin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTlogin: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyActionloginResponse) ApiClient.Deserialize(response.Content, typeof(ProxyActionloginResponse), response.Headers);
        }
    
        /// <summary>
        /// Action query 
        /// </summary>
        /// <param name="queryRequest"></param> 
        /// <returns>ProxyActionqueryResponse</returns>            
        public ProxyActionqueryResponse ProxyActionPOSTquery (ProxyActionqueryRequest queryRequest)
        {
            
            // verify the required parameter 'queryRequest' is set
            if (queryRequest == null) throw new ApiException(400, "Missing required parameter 'queryRequest' when calling ProxyActionPOSTquery");
            
    
            var path = "/action/query";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(queryRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTquery: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTquery: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyActionqueryResponse) ApiClient.Deserialize(response.Content, typeof(ProxyActionqueryResponse), response.Headers);
        }
    
        /// <summary>
        /// Action queryMore 
        /// </summary>
        /// <param name="queryMoreRequest"></param> 
        /// <returns>ProxyActionqueryMoreResponse</returns>            
        public ProxyActionqueryMoreResponse ProxyActionPOSTqueryMore (ProxyActionqueryMoreRequest queryMoreRequest)
        {
            
            // verify the required parameter 'queryMoreRequest' is set
            if (queryMoreRequest == null) throw new ApiException(400, "Missing required parameter 'queryMoreRequest' when calling ProxyActionPOSTqueryMore");
            
    
            var path = "/action/queryMore";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(queryMoreRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTqueryMore: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTqueryMore: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyActionqueryMoreResponse) ApiClient.Deserialize(response.Content, typeof(ProxyActionqueryMoreResponse), response.Headers);
        }
    
        /// <summary>
        /// Action rasd 
        /// </summary>
        /// <returns>ProxyActionrasdResponse</returns>            
        public ProxyActionrasdResponse ProxyActionPOSTrasd ()
        {
            
    
            var path = "/action/rasd";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTrasd: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTrasd: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyActionrasdResponse) ApiClient.Deserialize(response.Content, typeof(ProxyActionrasdResponse), response.Headers);
        }
    
        /// <summary>
        /// Action subscribe 
        /// </summary>
        /// <param name="subscribeRequest"></param> 
        /// <returns>ProxyActionsubscribeResponse</returns>            
        public ProxyActionsubscribeResponse ProxyActionPOSTsubscribe (ProxyActionsubscribeRequest subscribeRequest)
        {
            
            // verify the required parameter 'subscribeRequest' is set
            if (subscribeRequest == null) throw new ApiException(400, "Missing required parameter 'subscribeRequest' when calling ProxyActionPOSTsubscribe");
            
    
            var path = "/action/subscribe";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(subscribeRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTsubscribe: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTsubscribe: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyActionsubscribeResponse) ApiClient.Deserialize(response.Content, typeof(ProxyActionsubscribeResponse), response.Headers);
        }
    
        /// <summary>
        /// Action update 
        /// </summary>
        /// <param name="updateRequest"></param> 
        /// <returns>ProxyActionupdateResponse</returns>            
        public ProxyActionupdateResponse ProxyActionPOSTupdate (ProxyActionupdateRequest updateRequest)
        {
            
            // verify the required parameter 'updateRequest' is set
            if (updateRequest == null) throw new ApiException(400, "Missing required parameter 'updateRequest' when calling ProxyActionPOSTupdate");
            
    
            var path = "/action/update";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(updateRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTupdate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyActionPOSTupdate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyActionupdateResponse) ApiClient.Deserialize(response.Content, typeof(ProxyActionupdateResponse), response.Headers);
        }
    
    }
}
