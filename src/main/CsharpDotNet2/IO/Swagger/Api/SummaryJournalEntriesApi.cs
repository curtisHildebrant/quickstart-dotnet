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
    public interface ISummaryJournalEntriesApi
    {
        /// <summary>
        /// Delete summary journal entry This reference describes how to delete a summary journal entry using the REST API.  You must have the \&quot;Delete Cancelled Journal Entry\&quot; [Z-Finance user permission](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/Administrator_Settings/User_Roles/Z-Finance_Roles) enabled to delete summary journal entries.  A summary journal entry must be canceled before it can be deleted. 
        /// </summary>
        /// <param name="jeNumber">Journal entry number in the format JE-00000001.</param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType DELETESummaryJournalEntry (string jeNumber);
        /// <summary>
        /// Get all summary journal entries in a journal run  This REST API reference describes how to retrieve information about all summary journal entries in a journal run. 
        /// </summary>
        /// <param name="jrNumber">Journal run number.</param>
        /// <returns>GETJournalEntriesInJournalRunType</returns>
        GETJournalEntriesInJournalRunType GETJournalEntriesInJournalRun (string jrNumber);
        /// <summary>
        /// Get summary journal entry This REST API reference describes how to get information about a summary journal entry by its journal entry number. 
        /// </summary>
        /// <param name="jeNumber"></param>
        /// <returns>GETJournalEntryDetailType</returns>
        GETJournalEntryDetailType GETJournalEntryDetail (string jeNumber);
        /// <summary>
        /// Create summary journal entry This REST API reference describes how to manually create a summary journal entry. Request and response field descriptions and sample code are provided. ## Requirements 1.The sum of debits must equal the sum of credits in the summary journal entry.  2.The following applies only if you use foreign currency conversion:   * If you have configured [Aggregate transactions with different currencies during a Journal Run](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/C_Configure_accounting_rules#Aggregate_transactions_with_different_currencies_during_a_Journal_Run) to \&quot;Yes\&quot;, the value of the **currency** field must be the same as your tenant&#39;s home currency. That is, you must create journal entries using your home currency.   * All journal entries in an accounting period must either all be aggregated or all be unaggregated. You cannot have a mix of aggregated and unaggregated journal entries in the same accounting period.  See [Foreign Currency Conversion for Summary Journal Entries](https://knowledgecenter.zuora.com/CC_Finance/Foreign_Currency_Conversion/Foreign_Currency_Conversion_for_Summary_Journal_Entries) for more information about currency aggregation. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns>POSTJournalEntryResponseType</returns>
        POSTJournalEntryResponseType POSTJournalEntry (POSTJournalEntryType request);
        /// <summary>
        /// Update basic information of a summary journal entry  This REST API reference describes how to update the basic information of a summary journal entry. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="jeNumber">Journal entry number in the format JE-00000001.</param>
        /// <param name="request"></param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType PUTBasicSummaryJournalEntry (string jeNumber, PUTBasicSummaryJournalEntryType request);
        /// <summary>
        /// Cancel summary journal entry  This reference describes how to cancel a summary journal entry using the REST API.  You must have the \&quot;Cancel Journal Entry\&quot; [Z-Finance user permission](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/Administrator_Settings/User_Roles/Z-Finance_Roles) enabled to cancel summary journal entries.  A summary journal entry cannot be canceled if its Transferred to Accounting status is \&quot;Yes\&quot; or \&quot;Processing\&quot;. 
        /// </summary>
        /// <param name="jeNumber">Journal entry number in the format JE-00000001.</param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType PUTSummaryJournalEntry (string jeNumber);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SummaryJournalEntriesApi : ISummaryJournalEntriesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryJournalEntriesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SummaryJournalEntriesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryJournalEntriesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SummaryJournalEntriesApi(String basePath)
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
        /// Delete summary journal entry This reference describes how to delete a summary journal entry using the REST API.  You must have the \&quot;Delete Cancelled Journal Entry\&quot; [Z-Finance user permission](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/Administrator_Settings/User_Roles/Z-Finance_Roles) enabled to delete summary journal entries.  A summary journal entry must be canceled before it can be deleted. 
        /// </summary>
        /// <param name="jeNumber">Journal entry number in the format JE-00000001.</param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType DELETESummaryJournalEntry (string jeNumber)
        {
            
            // verify the required parameter 'jeNumber' is set
            if (jeNumber == null) throw new ApiException(400, "Missing required parameter 'jeNumber' when calling DELETESummaryJournalEntry");
            
    
            var path = "/journal-entries/{je-number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "je-number" + "}", ApiClient.ParameterToString(jeNumber));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DELETESummaryJournalEntry: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETESummaryJournalEntry: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// Get all summary journal entries in a journal run  This REST API reference describes how to retrieve information about all summary journal entries in a journal run. 
        /// </summary>
        /// <param name="jrNumber">Journal run number.</param> 
        /// <returns>GETJournalEntriesInJournalRunType</returns>            
        public GETJournalEntriesInJournalRunType GETJournalEntriesInJournalRun (string jrNumber)
        {
            
            // verify the required parameter 'jrNumber' is set
            if (jrNumber == null) throw new ApiException(400, "Missing required parameter 'jrNumber' when calling GETJournalEntriesInJournalRun");
            
    
            var path = "/journal-entries/journal-runs/{jr-number}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETJournalEntriesInJournalRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETJournalEntriesInJournalRun: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETJournalEntriesInJournalRunType) ApiClient.Deserialize(response.Content, typeof(GETJournalEntriesInJournalRunType), response.Headers);
        }
    
        /// <summary>
        /// Get summary journal entry This REST API reference describes how to get information about a summary journal entry by its journal entry number. 
        /// </summary>
        /// <param name="jeNumber"></param> 
        /// <returns>GETJournalEntryDetailType</returns>            
        public GETJournalEntryDetailType GETJournalEntryDetail (string jeNumber)
        {
            
            // verify the required parameter 'jeNumber' is set
            if (jeNumber == null) throw new ApiException(400, "Missing required parameter 'jeNumber' when calling GETJournalEntryDetail");
            
    
            var path = "/journal-entries/{je-number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "je-number" + "}", ApiClient.ParameterToString(jeNumber));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETJournalEntryDetail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETJournalEntryDetail: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETJournalEntryDetailType) ApiClient.Deserialize(response.Content, typeof(GETJournalEntryDetailType), response.Headers);
        }
    
        /// <summary>
        /// Create summary journal entry This REST API reference describes how to manually create a summary journal entry. Request and response field descriptions and sample code are provided. ## Requirements 1.The sum of debits must equal the sum of credits in the summary journal entry.  2.The following applies only if you use foreign currency conversion:   * If you have configured [Aggregate transactions with different currencies during a Journal Run](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/C_Configure_accounting_rules#Aggregate_transactions_with_different_currencies_during_a_Journal_Run) to \&quot;Yes\&quot;, the value of the **currency** field must be the same as your tenant&#39;s home currency. That is, you must create journal entries using your home currency.   * All journal entries in an accounting period must either all be aggregated or all be unaggregated. You cannot have a mix of aggregated and unaggregated journal entries in the same accounting period.  See [Foreign Currency Conversion for Summary Journal Entries](https://knowledgecenter.zuora.com/CC_Finance/Foreign_Currency_Conversion/Foreign_Currency_Conversion_for_Summary_Journal_Entries) for more information about currency aggregation. 
        /// </summary>
        /// <param name="request"></param> 
        /// <returns>POSTJournalEntryResponseType</returns>            
        public POSTJournalEntryResponseType POSTJournalEntry (POSTJournalEntryType request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTJournalEntry");
            
    
            var path = "/journal-entries";
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTJournalEntry: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTJournalEntry: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTJournalEntryResponseType) ApiClient.Deserialize(response.Content, typeof(POSTJournalEntryResponseType), response.Headers);
        }
    
        /// <summary>
        /// Update basic information of a summary journal entry  This REST API reference describes how to update the basic information of a summary journal entry. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="jeNumber">Journal entry number in the format JE-00000001.</param> 
        /// <param name="request"></param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType PUTBasicSummaryJournalEntry (string jeNumber, PUTBasicSummaryJournalEntryType request)
        {
            
            // verify the required parameter 'jeNumber' is set
            if (jeNumber == null) throw new ApiException(400, "Missing required parameter 'jeNumber' when calling PUTBasicSummaryJournalEntry");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling PUTBasicSummaryJournalEntry");
            
    
            var path = "/journal-entries/{je-number}/basic-information";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "je-number" + "}", ApiClient.ParameterToString(jeNumber));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTBasicSummaryJournalEntry: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTBasicSummaryJournalEntry: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// Cancel summary journal entry  This reference describes how to cancel a summary journal entry using the REST API.  You must have the \&quot;Cancel Journal Entry\&quot; [Z-Finance user permission](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/Administrator_Settings/User_Roles/Z-Finance_Roles) enabled to cancel summary journal entries.  A summary journal entry cannot be canceled if its Transferred to Accounting status is \&quot;Yes\&quot; or \&quot;Processing\&quot;. 
        /// </summary>
        /// <param name="jeNumber">Journal entry number in the format JE-00000001.</param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType PUTSummaryJournalEntry (string jeNumber)
        {
            
            // verify the required parameter 'jeNumber' is set
            if (jeNumber == null) throw new ApiException(400, "Missing required parameter 'jeNumber' when calling PUTSummaryJournalEntry");
            
    
            var path = "/journal-entries/{je-number}/cancel";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "je-number" + "}", ApiClient.ParameterToString(jeNumber));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTSummaryJournalEntry: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTSummaryJournalEntry: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
    }
}
