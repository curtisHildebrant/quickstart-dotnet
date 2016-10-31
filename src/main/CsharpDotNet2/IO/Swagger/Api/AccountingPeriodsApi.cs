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
    public interface IAccountingPeriodsApi
    {
        /// <summary>
        /// Delete accounting period  Deletes an accounting period.  Prerequisites -------------   * You must have Zuora Finance enabled on your tenant.   * You must have the Delete Accounting Period user permission. See [Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles).   Limitations -----------  The accounting period to be deleted:  * Must be the most recent accounting period  * Must be an open accounting period  * Must have no revenue distributed into it  * Must not have any active journal entries  * Must not be the open-ended accounting period  * Must not be in the process of running a trial balance 
        /// </summary>
        /// <param name="apId">ID of the accounting period you want to delete.</param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType DELETEAccountingPeriod (string apId);
        /// <summary>
        /// Get accounting period Retrieves an accounting period. Prerequisites -------------  You must have Zuora Finance enabled on your tenant. 
        /// </summary>
        /// <param name="apId">ID of the accounting period you want to get.</param>
        /// <returns>GETAccountingPeriodType</returns>
        GETAccountingPeriodType GETAccountingPeriod (string apId);
        /// <summary>
        /// Get all accounting periods Retrieves all accounting periods on your tenant.
        /// </summary>
        /// <returns>GETAccountingPeriodsType</returns>
        GETAccountingPeriodsType GETAccountingPeriods ();
        /// <summary>
        /// Create accounting period Creates an accounting period. Prerequisites ------------- * You must have Zuora Finance enabled on your tenant. * You must have the Create Accounting Period user permission. See [Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/Z-Finance_Roles).  Limitations ----------- * When creating the first accounting period on your tenant, the start date must be equal to or earlier than the date of the earliest transaction on the tenant. * Start and end dates of accounting periods must be contiguous. For example, if one accounting period ends on January 31, the next period must start on February 1. * If you have the Revenue Recognition Package and have enabled the \&quot;Monthly recognition over time\&quot; revenue recognition model, the accounting period start date and end date must be on the first day and last day of the month, respectively. Note that the start and end dates do not necessarily have to be in the same month.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>POSTAccountingPeriodResponseType</returns>
        POSTAccountingPeriodResponseType POSTAccountingPeriod (POSTAccountingPeriodType request);
        /// <summary>
        /// Close accounting period Close an [accounting period](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods) by accounting period ID.  Prerequisites ------------- You must have Zuora Finance enabled on your tenant. You must have the Manage Close Process and Run Trial Balance user permissions. See [Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles). Limitations ----------- * The accounting period cannot already be closed. * The accounting period cannot be in the process of running a trial balance. * All earlier accounting periods must be closed. * There must be no required action items for the accounting period. See [Reconcile Transactions Before Closing an Accounting Period](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/G_Reconcile_transactions_before_closing_an_accounting_period) for more information.  Notes ----- When you close an accounting period in Zuora, a trial balance is automatically run for that period. A successful response means only that the accounting period is now closed, but does not mean that the trial balance has successfully completed.
        /// </summary>
        /// <param name="apId">ID of the accounting period you want to close.</param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType PUTCloseAccountingPeriod (string apId);
        /// <summary>
        /// Set accounting period to pending close Sets an accounting period to pending close.   Prerequisites -------------  * You must have Zuora Finance enabled on your tenant. * You must have the Manage Close Process and Run Trial Balance user permissions. See [Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles).              Limitations   -----------    * The accounting period cannot be closed or pending close.    * The accounting period cannot be in the process of running a trial balance.    * All earlier accounting periods must be closed.     Notes ----- When you set an accounting period to pending close in Zuora, a trial balance is automatically run for that period. A response of &#x60;{ \&quot;success\&quot;: true }&#x60;  means only that the accounting period status is now pending close, but does not mean that the trial balance has successfully completed. You can use the Get Accounting Period REST API call to view details about the outcome of the trial balance. 
        /// </summary>
        /// <param name="apId">ID of the accounting period you want to set to pending close.</param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType PUTPendingCloseAccountingPeriod (string apId);
        /// <summary>
        /// Re-open accounting period Re-opens an accounting period. See [Re-Open Accounting Periods](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/H_Reopen_accounting_periods) for more information. Prerequisites ------------- * You must have Zuora Finance enabled on your tenant. * You must have the Manage Close Process and Run Trial Balance user permissions. See [Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles).  Limitations ----------- * The accounting period must be closed or pending close. * You can only re-open an accounting period that is immediately previous to an open period. See [re-open an accounting period](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/H_Reopen_accounting_periods) for an example.
        /// </summary>
        /// <param name="apId">ID of the accounting period that you want to re-open.</param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType PUTReopenAccountingPeriod (string apId);
        /// <summary>
        /// Run trial balance Runs the trial balance for an accounting period. See [Run a Trial Balance](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/D_Run_a_trial_balance) for more information.  Prerequisites -------------  * You must have Zuora Finance enabled on your tenant.  * You must have the Manage Close Process and Run Trial Balance user permissions. See [Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles).             Limitations  -----------    * The accounting period must be open.    * The accounting period cannot already be in the process of running a trial balance.   Notes ----- The trial balance is run asynchronously. A response of &#x60;{ \&quot;success\&quot;: true }&#x60; means only that the trial balance has started processing, but does not mean that the trial balance has successfully completed. You can use the [Get Accounting Period](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Accounting_Periods/Get_Accounting_Period) REST API call to view details about the outcome of the trial balance. 
        /// </summary>
        /// <param name="apId">ID of the accounting period for which you want to run a trial balance.</param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType PUTRunTrialBalance (string apId);
        /// <summary>
        /// Update accounting period  Updates an accounting period.  Prerequisites -------------  * You must have Zuora Finance enabled on your tenant.  * You must have the Create Accounting Period user permission. See [Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles).  Limitations -----------  * You can update the start date of only the earliest accounting period on your tenant. You cannot update the start date of later periods.  * If you update the earliest accounting period, the start date must be equal to or earlier than the date of the earliest transaction on the tenant.  * Start and end dates of accounting periods must be contiguous. For example, if one accounting period ends on January 31, the next period must start on February 1.  * If you have the Revenue Recognition Package and have enabled the \&quot;Monthly recognition over time\&quot; revenue recognition model, the accounting period start date and end date must be on the first day and last day of the month, respectively. Note that the start and end dates do not necessarily have to be in the same month.  * You cannot update the start date or end date of an accounting period if:   * Any revenue has been distributed into the period.   * The period has any active journal entries. 
        /// </summary>
        /// <param name="apId">ID of the accounting period you want to update.</param>
        /// <param name="request"></param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType PUTUpdateAccountingPeriod (string apId, PUTAccountingPeriodType request);
        /// <summary>
        /// CRUD: Delete AccountingPeriod 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <returns>ProxyDeleteResponse</returns>
        ProxyDeleteResponse ProxyDELETEAccountingPeriod (string id);
        /// <summary>
        /// CRUD: Retrieve AccountingPeriod 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="fields">Object fields to return</param>
        /// <returns>ProxyGetAccountingPeriod</returns>
        ProxyGetAccountingPeriod ProxyGETAccountingPeriod (string id, string fields);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountingPeriodsApi : IAccountingPeriodsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingPeriodsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccountingPeriodsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingPeriodsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountingPeriodsApi(String basePath)
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
        /// Delete accounting period  Deletes an accounting period.  Prerequisites -------------   * You must have Zuora Finance enabled on your tenant.   * You must have the Delete Accounting Period user permission. See [Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles).   Limitations -----------  The accounting period to be deleted:  * Must be the most recent accounting period  * Must be an open accounting period  * Must have no revenue distributed into it  * Must not have any active journal entries  * Must not be the open-ended accounting period  * Must not be in the process of running a trial balance 
        /// </summary>
        /// <param name="apId">ID of the accounting period you want to delete.</param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType DELETEAccountingPeriod (string apId)
        {
            
            // verify the required parameter 'apId' is set
            if (apId == null) throw new ApiException(400, "Missing required parameter 'apId' when calling DELETEAccountingPeriod");
            
    
            var path = "/accounting-periods/{ap-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ap-id" + "}", ApiClient.ParameterToString(apId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEAccountingPeriod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEAccountingPeriod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// Get accounting period Retrieves an accounting period. Prerequisites -------------  You must have Zuora Finance enabled on your tenant. 
        /// </summary>
        /// <param name="apId">ID of the accounting period you want to get.</param> 
        /// <returns>GETAccountingPeriodType</returns>            
        public GETAccountingPeriodType GETAccountingPeriod (string apId)
        {
            
            // verify the required parameter 'apId' is set
            if (apId == null) throw new ApiException(400, "Missing required parameter 'apId' when calling GETAccountingPeriod");
            
    
            var path = "/accounting-periods/{ap-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ap-id" + "}", ApiClient.ParameterToString(apId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccountingPeriod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccountingPeriod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETAccountingPeriodType) ApiClient.Deserialize(response.Content, typeof(GETAccountingPeriodType), response.Headers);
        }
    
        /// <summary>
        /// Get all accounting periods Retrieves all accounting periods on your tenant.
        /// </summary>
        /// <returns>GETAccountingPeriodsType</returns>            
        public GETAccountingPeriodsType GETAccountingPeriods ()
        {
            
    
            var path = "/accounting-periods";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccountingPeriods: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccountingPeriods: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETAccountingPeriodsType) ApiClient.Deserialize(response.Content, typeof(GETAccountingPeriodsType), response.Headers);
        }
    
        /// <summary>
        /// Create accounting period Creates an accounting period. Prerequisites ------------- * You must have Zuora Finance enabled on your tenant. * You must have the Create Accounting Period user permission. See [Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/Z-Finance_Roles).  Limitations ----------- * When creating the first accounting period on your tenant, the start date must be equal to or earlier than the date of the earliest transaction on the tenant. * Start and end dates of accounting periods must be contiguous. For example, if one accounting period ends on January 31, the next period must start on February 1. * If you have the Revenue Recognition Package and have enabled the \&quot;Monthly recognition over time\&quot; revenue recognition model, the accounting period start date and end date must be on the first day and last day of the month, respectively. Note that the start and end dates do not necessarily have to be in the same month.
        /// </summary>
        /// <param name="request"></param> 
        /// <returns>POSTAccountingPeriodResponseType</returns>            
        public POSTAccountingPeriodResponseType POSTAccountingPeriod (POSTAccountingPeriodType request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTAccountingPeriod");
            
    
            var path = "/accounting-periods";
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTAccountingPeriod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTAccountingPeriod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTAccountingPeriodResponseType) ApiClient.Deserialize(response.Content, typeof(POSTAccountingPeriodResponseType), response.Headers);
        }
    
        /// <summary>
        /// Close accounting period Close an [accounting period](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods) by accounting period ID.  Prerequisites ------------- You must have Zuora Finance enabled on your tenant. You must have the Manage Close Process and Run Trial Balance user permissions. See [Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles). Limitations ----------- * The accounting period cannot already be closed. * The accounting period cannot be in the process of running a trial balance. * All earlier accounting periods must be closed. * There must be no required action items for the accounting period. See [Reconcile Transactions Before Closing an Accounting Period](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/G_Reconcile_transactions_before_closing_an_accounting_period) for more information.  Notes ----- When you close an accounting period in Zuora, a trial balance is automatically run for that period. A successful response means only that the accounting period is now closed, but does not mean that the trial balance has successfully completed.
        /// </summary>
        /// <param name="apId">ID of the accounting period you want to close.</param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType PUTCloseAccountingPeriod (string apId)
        {
            
            // verify the required parameter 'apId' is set
            if (apId == null) throw new ApiException(400, "Missing required parameter 'apId' when calling PUTCloseAccountingPeriod");
            
    
            var path = "/accounting-periods/{ap-id}/close";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ap-id" + "}", ApiClient.ParameterToString(apId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTCloseAccountingPeriod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTCloseAccountingPeriod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// Set accounting period to pending close Sets an accounting period to pending close.   Prerequisites -------------  * You must have Zuora Finance enabled on your tenant. * You must have the Manage Close Process and Run Trial Balance user permissions. See [Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles).              Limitations   -----------    * The accounting period cannot be closed or pending close.    * The accounting period cannot be in the process of running a trial balance.    * All earlier accounting periods must be closed.     Notes ----- When you set an accounting period to pending close in Zuora, a trial balance is automatically run for that period. A response of &#x60;{ \&quot;success\&quot;: true }&#x60;  means only that the accounting period status is now pending close, but does not mean that the trial balance has successfully completed. You can use the Get Accounting Period REST API call to view details about the outcome of the trial balance. 
        /// </summary>
        /// <param name="apId">ID of the accounting period you want to set to pending close.</param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType PUTPendingCloseAccountingPeriod (string apId)
        {
            
            // verify the required parameter 'apId' is set
            if (apId == null) throw new ApiException(400, "Missing required parameter 'apId' when calling PUTPendingCloseAccountingPeriod");
            
    
            var path = "/accounting-periods/{ap-id}/pending-close";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ap-id" + "}", ApiClient.ParameterToString(apId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTPendingCloseAccountingPeriod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTPendingCloseAccountingPeriod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// Re-open accounting period Re-opens an accounting period. See [Re-Open Accounting Periods](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/H_Reopen_accounting_periods) for more information. Prerequisites ------------- * You must have Zuora Finance enabled on your tenant. * You must have the Manage Close Process and Run Trial Balance user permissions. See [Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles).  Limitations ----------- * The accounting period must be closed or pending close. * You can only re-open an accounting period that is immediately previous to an open period. See [re-open an accounting period](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/H_Reopen_accounting_periods) for an example.
        /// </summary>
        /// <param name="apId">ID of the accounting period that you want to re-open.</param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType PUTReopenAccountingPeriod (string apId)
        {
            
            // verify the required parameter 'apId' is set
            if (apId == null) throw new ApiException(400, "Missing required parameter 'apId' when calling PUTReopenAccountingPeriod");
            
    
            var path = "/accounting-periods/{ap-id}/reopen";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ap-id" + "}", ApiClient.ParameterToString(apId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTReopenAccountingPeriod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTReopenAccountingPeriod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// Run trial balance Runs the trial balance for an accounting period. See [Run a Trial Balance](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/D_Run_a_trial_balance) for more information.  Prerequisites -------------  * You must have Zuora Finance enabled on your tenant.  * You must have the Manage Close Process and Run Trial Balance user permissions. See [Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles).             Limitations  -----------    * The accounting period must be open.    * The accounting period cannot already be in the process of running a trial balance.   Notes ----- The trial balance is run asynchronously. A response of &#x60;{ \&quot;success\&quot;: true }&#x60; means only that the trial balance has started processing, but does not mean that the trial balance has successfully completed. You can use the [Get Accounting Period](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Accounting_Periods/Get_Accounting_Period) REST API call to view details about the outcome of the trial balance. 
        /// </summary>
        /// <param name="apId">ID of the accounting period for which you want to run a trial balance.</param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType PUTRunTrialBalance (string apId)
        {
            
            // verify the required parameter 'apId' is set
            if (apId == null) throw new ApiException(400, "Missing required parameter 'apId' when calling PUTRunTrialBalance");
            
    
            var path = "/accounting-periods/{ap-id}/run-trial-balance";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ap-id" + "}", ApiClient.ParameterToString(apId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTRunTrialBalance: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTRunTrialBalance: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// Update accounting period  Updates an accounting period.  Prerequisites -------------  * You must have Zuora Finance enabled on your tenant.  * You must have the Create Accounting Period user permission. See [Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles).  Limitations -----------  * You can update the start date of only the earliest accounting period on your tenant. You cannot update the start date of later periods.  * If you update the earliest accounting period, the start date must be equal to or earlier than the date of the earliest transaction on the tenant.  * Start and end dates of accounting periods must be contiguous. For example, if one accounting period ends on January 31, the next period must start on February 1.  * If you have the Revenue Recognition Package and have enabled the \&quot;Monthly recognition over time\&quot; revenue recognition model, the accounting period start date and end date must be on the first day and last day of the month, respectively. Note that the start and end dates do not necessarily have to be in the same month.  * You cannot update the start date or end date of an accounting period if:   * Any revenue has been distributed into the period.   * The period has any active journal entries. 
        /// </summary>
        /// <param name="apId">ID of the accounting period you want to update.</param> 
        /// <param name="request"></param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType PUTUpdateAccountingPeriod (string apId, PUTAccountingPeriodType request)
        {
            
            // verify the required parameter 'apId' is set
            if (apId == null) throw new ApiException(400, "Missing required parameter 'apId' when calling PUTUpdateAccountingPeriod");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling PUTUpdateAccountingPeriod");
            
    
            var path = "/accounting-periods/{ap-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ap-id" + "}", ApiClient.ParameterToString(apId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTUpdateAccountingPeriod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTUpdateAccountingPeriod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Delete AccountingPeriod 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <returns>ProxyDeleteResponse</returns>            
        public ProxyDeleteResponse ProxyDELETEAccountingPeriod (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyDELETEAccountingPeriod");
            
    
            var path = "/object/accounting-period/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETEAccountingPeriod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETEAccountingPeriod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyDeleteResponse) ApiClient.Deserialize(response.Content, typeof(ProxyDeleteResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Retrieve AccountingPeriod 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="fields">Object fields to return</param> 
        /// <returns>ProxyGetAccountingPeriod</returns>            
        public ProxyGetAccountingPeriod ProxyGETAccountingPeriod (string id, string fields)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyGETAccountingPeriod");
            
    
            var path = "/object/accounting-period/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETAccountingPeriod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETAccountingPeriod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyGetAccountingPeriod) ApiClient.Deserialize(response.Content, typeof(ProxyGetAccountingPeriod), response.Headers);
        }
    
    }
}
