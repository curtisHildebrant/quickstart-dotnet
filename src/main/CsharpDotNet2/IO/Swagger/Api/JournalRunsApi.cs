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
    public interface IJournalRunsApi
    {
        /// <summary>
        /// Delete journal run This reference describes how to delete a journal run using the REST API.                         You can only delete journal runs that have already been canceled. See [Cancel Journal Run](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Journal_Runs/Cancel_Journal_Run) for more information.                         You must have the \&quot;Delete Cancelled Journal Run\&quot; [Z-Finance user permission](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles) enabled to delete journal runs. 
        /// </summary>
        /// <param name="jrNumber">Journal run number. Must be a valid journal run number in the format &#x60;JR-00000001&#x60;. </param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType DELETEJournalRun (string jrNumber);
        /// <summary>
        /// Get journal run This REST API reference describes how to get information about a journal run. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="jrNumber">Journal run number. Must be a valid journal run number in the format &#x60;JR-00000001&#x60;. </param>
        /// <returns>GETJournalRunType</returns>
        GETJournalRunType GETJournalRun (string jrNumber);
        /// <summary>
        /// Create journal run This REST API reference describes how to create a journal run. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns>POSTJournalRunResponseType</returns>
        POSTJournalRunResponseType POSTJournalRun (POSTJournalRunType request);
        /// <summary>
        /// Cancel journal run This reference describes how to cancel a journal run using the REST API.            The summary journal entries in the journal run are canceled asynchronously. See the \&quot;Example\&quot; section below for details.            You must have the \&quot;Cancel Journal Run\&quot; [Z-Finance user permission](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/Administrator_Settings/User_Roles/Z-Finance_Roles) enabled to cancel journal runs.  ## Notes When you cancel a journal run, the summary journal entries associated with that journal run are canceled asynchronously. A response of &#x60;{ \&quot;success\&quot;: true }&#x60; means only that the specified journal run has a status of \&quot;Pending\&quot;, \&quot;Error\&quot;, or \&quot;Completed\&quot; and therefore can be canceled, but does not mean that the whole journal run was successfully canceled.  For example, let&#39;s say you want to cancel journal run JR-00000075. The journal run status is \&quot;Completed\&quot; and it contains ten journal entries. One of the journal entries has its Transferred to Accounting status set to \&quot;Yes\&quot;, meaning that the entry cannot be canceled. The workflow might go as follows: 1. You make an API call to cancel the journal run. 2. The journal run status is \&quot;Completed\&quot;, so you receive a response of &#x60;{ \&quot;success\&quot;: true }&#x60;. 3. Zuora begins asynchronously canceling journal entries associated with the journal run. The journal entry whose Transferred to Accounting status is \&quot;Yes\&quot; fails to be canceled. The cancelation process continues, and the other journal entries are successfully canceled. 4. The journal run status remains as \&quot;Completed\&quot;. The status does not change to \&quot;Canceled\&quot; because the journal run still contains a journey entry that is not canceled. 
        /// </summary>
        /// <param name="jrNumber">Journal run number. Must be a valid journal run number in the format JR-00000001.  You can only cancel a journal run whose status is \&quot;Pending\&quot;, \&quot;Error\&quot;, or \&quot;Completed\&quot;. </param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType PUTJournalRun (string jrNumber);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class JournalRunsApi : IJournalRunsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JournalRunsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public JournalRunsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JournalRunsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public JournalRunsApi(String basePath)
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
        /// Delete journal run This reference describes how to delete a journal run using the REST API.                         You can only delete journal runs that have already been canceled. See [Cancel Journal Run](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Journal_Runs/Cancel_Journal_Run) for more information.                         You must have the \&quot;Delete Cancelled Journal Run\&quot; [Z-Finance user permission](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles) enabled to delete journal runs. 
        /// </summary>
        /// <param name="jrNumber">Journal run number. Must be a valid journal run number in the format &#x60;JR-00000001&#x60;. </param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType DELETEJournalRun (string jrNumber)
        {
            
            // verify the required parameter 'jrNumber' is set
            if (jrNumber == null) throw new ApiException(400, "Missing required parameter 'jrNumber' when calling DELETEJournalRun");
            
    
            var path = "/journal-runs/{jr-number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "jr-number" + "}", ApiClient.ParameterToString(jrNumber));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEJournalRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEJournalRun: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// Get journal run This REST API reference describes how to get information about a journal run. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="jrNumber">Journal run number. Must be a valid journal run number in the format &#x60;JR-00000001&#x60;. </param> 
        /// <returns>GETJournalRunType</returns>            
        public GETJournalRunType GETJournalRun (string jrNumber)
        {
            
            // verify the required parameter 'jrNumber' is set
            if (jrNumber == null) throw new ApiException(400, "Missing required parameter 'jrNumber' when calling GETJournalRun");
            
    
            var path = "/journal-runs/{jr-number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "jr-number" + "}", ApiClient.ParameterToString(jrNumber));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETJournalRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETJournalRun: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETJournalRunType) ApiClient.Deserialize(response.Content, typeof(GETJournalRunType), response.Headers);
        }
    
        /// <summary>
        /// Create journal run This REST API reference describes how to create a journal run. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="request"></param> 
        /// <returns>POSTJournalRunResponseType</returns>            
        public POSTJournalRunResponseType POSTJournalRun (POSTJournalRunType request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTJournalRun");
            
    
            var path = "/journal-runs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTJournalRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTJournalRun: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTJournalRunResponseType) ApiClient.Deserialize(response.Content, typeof(POSTJournalRunResponseType), response.Headers);
        }
    
        /// <summary>
        /// Cancel journal run This reference describes how to cancel a journal run using the REST API.            The summary journal entries in the journal run are canceled asynchronously. See the \&quot;Example\&quot; section below for details.            You must have the \&quot;Cancel Journal Run\&quot; [Z-Finance user permission](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/Administrator_Settings/User_Roles/Z-Finance_Roles) enabled to cancel journal runs.  ## Notes When you cancel a journal run, the summary journal entries associated with that journal run are canceled asynchronously. A response of &#x60;{ \&quot;success\&quot;: true }&#x60; means only that the specified journal run has a status of \&quot;Pending\&quot;, \&quot;Error\&quot;, or \&quot;Completed\&quot; and therefore can be canceled, but does not mean that the whole journal run was successfully canceled.  For example, let&#39;s say you want to cancel journal run JR-00000075. The journal run status is \&quot;Completed\&quot; and it contains ten journal entries. One of the journal entries has its Transferred to Accounting status set to \&quot;Yes\&quot;, meaning that the entry cannot be canceled. The workflow might go as follows: 1. You make an API call to cancel the journal run. 2. The journal run status is \&quot;Completed\&quot;, so you receive a response of &#x60;{ \&quot;success\&quot;: true }&#x60;. 3. Zuora begins asynchronously canceling journal entries associated with the journal run. The journal entry whose Transferred to Accounting status is \&quot;Yes\&quot; fails to be canceled. The cancelation process continues, and the other journal entries are successfully canceled. 4. The journal run status remains as \&quot;Completed\&quot;. The status does not change to \&quot;Canceled\&quot; because the journal run still contains a journey entry that is not canceled. 
        /// </summary>
        /// <param name="jrNumber">Journal run number. Must be a valid journal run number in the format JR-00000001.  You can only cancel a journal run whose status is \&quot;Pending\&quot;, \&quot;Error\&quot;, or \&quot;Completed\&quot;. </param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType PUTJournalRun (string jrNumber)
        {
            
            // verify the required parameter 'jrNumber' is set
            if (jrNumber == null) throw new ApiException(400, "Missing required parameter 'jrNumber' when calling PUTJournalRun");
            
    
            var path = "/journal-runs/{jr-number}/cancel";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "jr-number" + "}", ApiClient.ParameterToString(jrNumber));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTJournalRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTJournalRun: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
    }
}
