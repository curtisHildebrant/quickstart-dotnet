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
    public interface IUsageApi
    {
        /// <summary>
        /// Get usage This REST API reference describes how to retrieve usage details for an account. Usage data is returned in reverse chronological order. 
        /// </summary>
        /// <param name="accountKey">Account number or account ID.</param>
        /// <returns>GETUsageWrapper</returns>
        GETUsageWrapper GETUsage (string accountKey);
        /// <summary>
        /// Post usage  This REST API reference describes how to post or import usage data for one or more accounts in the CSV  format. There are no path or query parameters. The data is uploade using the HTTP multipart/form-data POST method and applied to the user&#39;s tenant.   ## How this REST API Call Works The content of the upload file must follow the [format](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Usage/1_POST_usage#Upload_File_Format) used by the UI import tool. It must be a comma-separated (CSV) file with a corresponding .csv extension. The file size must not exceed 4MB. Click [here](https://knowledgecenter.zuora.com/@api/deki/files/4105/UsageFileFormat.csv) to download the usage file template.  At the completion of the upload, before actually processing the file contents, theAPI returns a response containing the byte count of the received file and a URL for checking the status of the import process.  Of the five possible results displayed at that URL Pending, Processing, Completed, Canceled, and Failed) only a Completed status indicates that the import was successful.  The operation is atomic; if any record fails, the file is rejected.  In that case, the entire import is rolled back and all stored data is returned to its original state.  To view the actual import status, enter the resulting status URL from the checkImportStatus response using a tool such as POSTMAN.This additional step provides more information about why the import may have failed.  To manage the information after a successful upload, use the web-based UI.  ## Upload File Format The upload file uses the following headings:  | Heading         | Description   | Required | |-----------------|--------|----------| | ACCOUNT_ID      | Enter the account number, e.g., the default account number, such as A00000001, or your custom account number.,Although this field is labeled as Account_Id, it is not the actual Account ID nor Account Name.  | Yes      | | UOM             | Enter the unit of measure. This must match the UOM for the usage that is set up in **Z-Billing Settings &gt; Customize Units of Measure**. | Yes      | | QTY             | Enter the quantity.  | Yes      | | STARTDATE       | Enter the start date of the usage.,This date determines the invoice item service period the associated usage is billed to. Date format is based on locale of the current user. Default date format: &#x60;MM/DD/YYYY&#x60; | Yes      | | ENDDATE         | Enter the end date of the usage.,This is not used in calculations for usage billing and is optional. Date format is based on locale of the current user. Default date format: &#x60;MM/DD/YYYY&#x60;    | Yes      | | SUBSCRIPTION_ID | Enter the subscription number or subscription name. If you created the subscription in the Zuora application, Zuora created a number automatically in a format similar to A-S00000001. If you do not provide a value for this field, the associated usage will be added to all subscriptions for the specified Account that use this Unit Of Measure. If your Accounts can have multiple subscriptions and you do not want double or triple counting of usage, you must specify the Subscription or Charge ID in each usage record.  | Yes      | | CHARGE_ID       | Enter the charge number (not the charge name). You can see the charge ID, e.g., C-00000001, when you add your rate plan to your subscription and view your individual charges. See [Adding Products and Rate Plans](https://knowledgecenter.zuora.com/BC_Subscription_Management/Subscriptions/B_Creating_Subscriptions/Adding_Products_and_Rate_Plans) for additional information. If your Accounts can have multiple subscriptions and you do not want double or triple counting of usage, you must specify the specific Subscription or Charge ID in each usage record. This field is related to the Charge Number on the subscription rate plan.                       | Yes      | | DESCRIPTION     | Enter a description for the charge. | No       | 
        /// </summary>
        /// <param name="contentType">Must be set to \&quot;multipart/form-data\&quot;. </param>
        /// <returns>POSTUsageResponseType</returns>
        POSTUsageResponseType POSTUsage (string contentType);
        /// <summary>
        /// CRUD: Delete Usage 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <returns>ProxyDeleteResponse</returns>
        ProxyDeleteResponse ProxyDELETEUsage (string id);
        /// <summary>
        /// CRUD: Retrieve Usage 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="fields">Object fields to return</param>
        /// <returns>ProxyGetUsage</returns>
        ProxyGetUsage ProxyGETUsage (string id, string fields);
        /// <summary>
        /// CRUD: Create Usage 
        /// </summary>
        /// <param name="createRequest"></param>
        /// <returns>ProxyCreateOrModifyResponse</returns>
        ProxyCreateOrModifyResponse ProxyPOSTUsage (ProxyCreateUsage createRequest);
        /// <summary>
        /// CRUD: Update Usage 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="modifyRequest"></param>
        /// <returns>ProxyCreateOrModifyResponse</returns>
        ProxyCreateOrModifyResponse ProxyPUTUsage (string id, ProxyModifyUsage modifyRequest);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsageApi : IUsageApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsageApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsageApi(String basePath)
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
        /// Get usage This REST API reference describes how to retrieve usage details for an account. Usage data is returned in reverse chronological order. 
        /// </summary>
        /// <param name="accountKey">Account number or account ID.</param> 
        /// <returns>GETUsageWrapper</returns>            
        public GETUsageWrapper GETUsage (string accountKey)
        {
            
            // verify the required parameter 'accountKey' is set
            if (accountKey == null) throw new ApiException(400, "Missing required parameter 'accountKey' when calling GETUsage");
            
    
            var path = "/usage/accounts/{account-key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "account-key" + "}", ApiClient.ParameterToString(accountKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETUsage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETUsage: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETUsageWrapper) ApiClient.Deserialize(response.Content, typeof(GETUsageWrapper), response.Headers);
        }
    
        /// <summary>
        /// Post usage  This REST API reference describes how to post or import usage data for one or more accounts in the CSV  format. There are no path or query parameters. The data is uploade using the HTTP multipart/form-data POST method and applied to the user&#39;s tenant.   ## How this REST API Call Works The content of the upload file must follow the [format](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Usage/1_POST_usage#Upload_File_Format) used by the UI import tool. It must be a comma-separated (CSV) file with a corresponding .csv extension. The file size must not exceed 4MB. Click [here](https://knowledgecenter.zuora.com/@api/deki/files/4105/UsageFileFormat.csv) to download the usage file template.  At the completion of the upload, before actually processing the file contents, theAPI returns a response containing the byte count of the received file and a URL for checking the status of the import process.  Of the five possible results displayed at that URL Pending, Processing, Completed, Canceled, and Failed) only a Completed status indicates that the import was successful.  The operation is atomic; if any record fails, the file is rejected.  In that case, the entire import is rolled back and all stored data is returned to its original state.  To view the actual import status, enter the resulting status URL from the checkImportStatus response using a tool such as POSTMAN.This additional step provides more information about why the import may have failed.  To manage the information after a successful upload, use the web-based UI.  ## Upload File Format The upload file uses the following headings:  | Heading         | Description   | Required | |-----------------|--------|----------| | ACCOUNT_ID      | Enter the account number, e.g., the default account number, such as A00000001, or your custom account number.,Although this field is labeled as Account_Id, it is not the actual Account ID nor Account Name.  | Yes      | | UOM             | Enter the unit of measure. This must match the UOM for the usage that is set up in **Z-Billing Settings &gt; Customize Units of Measure**. | Yes      | | QTY             | Enter the quantity.  | Yes      | | STARTDATE       | Enter the start date of the usage.,This date determines the invoice item service period the associated usage is billed to. Date format is based on locale of the current user. Default date format: &#x60;MM/DD/YYYY&#x60; | Yes      | | ENDDATE         | Enter the end date of the usage.,This is not used in calculations for usage billing and is optional. Date format is based on locale of the current user. Default date format: &#x60;MM/DD/YYYY&#x60;    | Yes      | | SUBSCRIPTION_ID | Enter the subscription number or subscription name. If you created the subscription in the Zuora application, Zuora created a number automatically in a format similar to A-S00000001. If you do not provide a value for this field, the associated usage will be added to all subscriptions for the specified Account that use this Unit Of Measure. If your Accounts can have multiple subscriptions and you do not want double or triple counting of usage, you must specify the Subscription or Charge ID in each usage record.  | Yes      | | CHARGE_ID       | Enter the charge number (not the charge name). You can see the charge ID, e.g., C-00000001, when you add your rate plan to your subscription and view your individual charges. See [Adding Products and Rate Plans](https://knowledgecenter.zuora.com/BC_Subscription_Management/Subscriptions/B_Creating_Subscriptions/Adding_Products_and_Rate_Plans) for additional information. If your Accounts can have multiple subscriptions and you do not want double or triple counting of usage, you must specify the specific Subscription or Charge ID in each usage record. This field is related to the Charge Number on the subscription rate plan.                       | Yes      | | DESCRIPTION     | Enter a description for the charge. | No       | 
        /// </summary>
        /// <param name="contentType">Must be set to \&quot;multipart/form-data\&quot;. </param> 
        /// <returns>POSTUsageResponseType</returns>            
        public POSTUsageResponseType POSTUsage (string contentType)
        {
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling POSTUsage");
            
    
            var path = "/usage";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTUsage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTUsage: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTUsageResponseType) ApiClient.Deserialize(response.Content, typeof(POSTUsageResponseType), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Delete Usage 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <returns>ProxyDeleteResponse</returns>            
        public ProxyDeleteResponse ProxyDELETEUsage (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyDELETEUsage");
            
    
            var path = "/object/usage/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETEUsage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETEUsage: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyDeleteResponse) ApiClient.Deserialize(response.Content, typeof(ProxyDeleteResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Retrieve Usage 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="fields">Object fields to return</param> 
        /// <returns>ProxyGetUsage</returns>            
        public ProxyGetUsage ProxyGETUsage (string id, string fields)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyGETUsage");
            
    
            var path = "/object/usage/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETUsage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETUsage: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyGetUsage) ApiClient.Deserialize(response.Content, typeof(ProxyGetUsage), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Create Usage 
        /// </summary>
        /// <param name="createRequest"></param> 
        /// <returns>ProxyCreateOrModifyResponse</returns>            
        public ProxyCreateOrModifyResponse ProxyPOSTUsage (ProxyCreateUsage createRequest)
        {
            
            // verify the required parameter 'createRequest' is set
            if (createRequest == null) throw new ApiException(400, "Missing required parameter 'createRequest' when calling ProxyPOSTUsage");
            
    
            var path = "/object/usage";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPOSTUsage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPOSTUsage: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyCreateOrModifyResponse) ApiClient.Deserialize(response.Content, typeof(ProxyCreateOrModifyResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Update Usage 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="modifyRequest"></param> 
        /// <returns>ProxyCreateOrModifyResponse</returns>            
        public ProxyCreateOrModifyResponse ProxyPUTUsage (string id, ProxyModifyUsage modifyRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyPUTUsage");
            
            // verify the required parameter 'modifyRequest' is set
            if (modifyRequest == null) throw new ApiException(400, "Missing required parameter 'modifyRequest' when calling ProxyPUTUsage");
            
    
            var path = "/object/usage/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPUTUsage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPUTUsage: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyCreateOrModifyResponse) ApiClient.Deserialize(response.Content, typeof(ProxyCreateOrModifyResponse), response.Headers);
        }
    
    }
}
