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
    public interface IConnectionsApi
    {
        /// <summary>
        /// Establish connection to Zuora REST API service Establishes a connection to the Zuora REST API service based on a valid user credentials.  This call authenticates the user and returns an API session cookie that&#39;s used to authorize subsequent calls to the REST API. A call to &#x60;connections&#x60; is a required first step before using the Zuora REST API to access data.  The credentials must belong to a user account that has permission to access the API service.  As noted elsewhere, it&#39;s strongly recommended that an account used for Zuora API activity is never used to log into the Zuora UI.  Once an account is used to log into the UI, it may be subject to periodic forced password changes, which may eventually lead to authentication failures when using the API. 
        /// </summary>
        /// <param name="apiAccessKeyId">Account username </param>
        /// <param name="apiSecretAccessKey">Account password </param>
        /// <param name="contentType">Must be set to \&quot;application/json\&quot; </param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType POSTConnections (string apiAccessKeyId, string apiSecretAccessKey, string contentType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConnectionsApi : IConnectionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ConnectionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectionsApi(String basePath)
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
        /// Establish connection to Zuora REST API service Establishes a connection to the Zuora REST API service based on a valid user credentials.  This call authenticates the user and returns an API session cookie that&#39;s used to authorize subsequent calls to the REST API. A call to &#x60;connections&#x60; is a required first step before using the Zuora REST API to access data.  The credentials must belong to a user account that has permission to access the API service.  As noted elsewhere, it&#39;s strongly recommended that an account used for Zuora API activity is never used to log into the Zuora UI.  Once an account is used to log into the UI, it may be subject to periodic forced password changes, which may eventually lead to authentication failures when using the API. 
        /// </summary>
        /// <param name="apiAccessKeyId">Account username </param> 
        /// <param name="apiSecretAccessKey">Account password </param> 
        /// <param name="contentType">Must be set to \&quot;application/json\&quot; </param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType POSTConnections (string apiAccessKeyId, string apiSecretAccessKey, string contentType)
        {
            
            // verify the required parameter 'apiAccessKeyId' is set
            if (apiAccessKeyId == null) throw new ApiException(400, "Missing required parameter 'apiAccessKeyId' when calling POSTConnections");
            
            // verify the required parameter 'apiSecretAccessKey' is set
            if (apiSecretAccessKey == null) throw new ApiException(400, "Missing required parameter 'apiSecretAccessKey' when calling POSTConnections");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling POSTConnections");
            
    
            var path = "/connections";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (apiAccessKeyId != null) headerParams.Add("apiAccessKeyId", ApiClient.ParameterToString(apiAccessKeyId)); // header parameter
 if (apiSecretAccessKey != null) headerParams.Add("apiSecretAccessKey", ApiClient.ParameterToString(apiSecretAccessKey)); // header parameter
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTConnections: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTConnections: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
    }
}
