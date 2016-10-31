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
    public interface IMassUpdaterApi
    {
        /// <summary>
        /// Get mass action result This reference describes how to get information about the result of a mass action through the REST API. See [Mass Updater](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater) for more information about mass actions. 
        /// </summary>
        /// <param name="bulkKey">String of 32 characters that identifies a mass action. You get the bulk-key after [performing a mass action](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Mass_Updater/A_Perform_Mass_Action) through the REST API. </param>
        /// <returns>GETMassUpdateType</returns>
        GETMassUpdateType GETMassUpdate (string bulkKey);
        /// <summary>
        /// Perform mass action This reference describes how to perform a mass action through the REST API. See [Mass Updater](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater) for more information about performing mass actions.  Using this API method, you send a multipart/form-data request containing a &#x60;.csv&#x60; file with data about the mass action you want to perform. Zuora returns a key and then asynchronously processes the mass action. You can use the key to get details about the result of the mass action. 
        /// </summary>
        /// <param name="contentType">Must be multipart/form-data. </param>
        /// <param name="request"></param>
        /// <returns>POSTMassUpdateResponseType</returns>
        POSTMassUpdateResponseType POSTMassUpdate (string contentType, POSTMassUpdateType request);
        /// <summary>
        /// Stop mass action This reference describes how to stop a mass action through the REST API. You can stop a mass action when its status is Pending or Processing. After you have stopped a mass action, you can get the [mass action result](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Mass_Updater/B_Get_Mass_Action_Result) to see details of the mass action.  - If you stop a mass action when its status is Pending, no response file is generated because no records have been processed.  - If you stop a mass action when its status is Processing, a response file is generated. You can check the response file to see which records have been processed and which have not. In the response file, the **Success** column has the value &#x60;Y&#x60; (successful) or &#x60;N&#x60; (failed) for processed records, and a blank value for unprocessed records.  Records that have already been processed when a mass action is stopped are not rolled back. 
        /// </summary>
        /// <param name="bulkKey">String of 32 characters that identifies a mass action. You get the bulk-key after [performing a mass action](https://knowledgecenter.zuora.com/BC_Developers/REST_API/B_REST_API_reference/Mass_Updater/A_Perform_Mass_Action) through the REST API. </param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType PUTMassUpdater (string bulkKey);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MassUpdaterApi : IMassUpdaterApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MassUpdaterApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MassUpdaterApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MassUpdaterApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MassUpdaterApi(String basePath)
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
        /// Get mass action result This reference describes how to get information about the result of a mass action through the REST API. See [Mass Updater](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater) for more information about mass actions. 
        /// </summary>
        /// <param name="bulkKey">String of 32 characters that identifies a mass action. You get the bulk-key after [performing a mass action](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Mass_Updater/A_Perform_Mass_Action) through the REST API. </param> 
        /// <returns>GETMassUpdateType</returns>            
        public GETMassUpdateType GETMassUpdate (string bulkKey)
        {
            
            // verify the required parameter 'bulkKey' is set
            if (bulkKey == null) throw new ApiException(400, "Missing required parameter 'bulkKey' when calling GETMassUpdate");
            
    
            var path = "/bulk/{bulk-key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "bulk-key" + "}", ApiClient.ParameterToString(bulkKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETMassUpdate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETMassUpdate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETMassUpdateType) ApiClient.Deserialize(response.Content, typeof(GETMassUpdateType), response.Headers);
        }
    
        /// <summary>
        /// Perform mass action This reference describes how to perform a mass action through the REST API. See [Mass Updater](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater) for more information about performing mass actions.  Using this API method, you send a multipart/form-data request containing a &#x60;.csv&#x60; file with data about the mass action you want to perform. Zuora returns a key and then asynchronously processes the mass action. You can use the key to get details about the result of the mass action. 
        /// </summary>
        /// <param name="contentType">Must be multipart/form-data. </param> 
        /// <param name="request"></param> 
        /// <returns>POSTMassUpdateResponseType</returns>            
        public POSTMassUpdateResponseType POSTMassUpdate (string contentType, POSTMassUpdateType request)
        {
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling POSTMassUpdate");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTMassUpdate");
            
    
            var path = "/bulk";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                        postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTMassUpdate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTMassUpdate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTMassUpdateResponseType) ApiClient.Deserialize(response.Content, typeof(POSTMassUpdateResponseType), response.Headers);
        }
    
        /// <summary>
        /// Stop mass action This reference describes how to stop a mass action through the REST API. You can stop a mass action when its status is Pending or Processing. After you have stopped a mass action, you can get the [mass action result](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Mass_Updater/B_Get_Mass_Action_Result) to see details of the mass action.  - If you stop a mass action when its status is Pending, no response file is generated because no records have been processed.  - If you stop a mass action when its status is Processing, a response file is generated. You can check the response file to see which records have been processed and which have not. In the response file, the **Success** column has the value &#x60;Y&#x60; (successful) or &#x60;N&#x60; (failed) for processed records, and a blank value for unprocessed records.  Records that have already been processed when a mass action is stopped are not rolled back. 
        /// </summary>
        /// <param name="bulkKey">String of 32 characters that identifies a mass action. You get the bulk-key after [performing a mass action](https://knowledgecenter.zuora.com/BC_Developers/REST_API/B_REST_API_reference/Mass_Updater/A_Perform_Mass_Action) through the REST API. </param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType PUTMassUpdater (string bulkKey)
        {
            
            // verify the required parameter 'bulkKey' is set
            if (bulkKey == null) throw new ApiException(400, "Missing required parameter 'bulkKey' when calling PUTMassUpdater");
            
    
            var path = "/bulk/{bulk-key}/stop";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "bulk-key" + "}", ApiClient.ParameterToString(bulkKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTMassUpdater: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTMassUpdater: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
    }
}
