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
    public interface IAccountingCodesApi
    {
        /// <summary>
        /// Delete accounting code This reference describes how to [delete an accounting code](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/G_Chart_of_Accounts/A_Set_Up_Chart_of_Accounts#Delete_an_Accounting_Code) through the REST API. ## Prerequisites If you have Z-Finance enabled on your tenant, then you must have the Z-Finance Delete Unused Accounting Code permission. See [Z-Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles). ## Limitations You can only delete accounting codes that have never been associated with any transactions. An accounting code must be deactivated before you can delete it. 
        /// </summary>
        /// <param name="acId">ID of the accounting code you want to delete.</param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType DELETEAccountingCode (string acId);
        /// <summary>
        /// Query an accounting code This reference describes how to query an accounting code through the REST API.
        /// </summary>
        /// <param name="acId">ID of the accounting code you want to query.</param>
        /// <returns>GETAccountingCodeItemType</returns>
        GETAccountingCodeItemType GETAccountingCodeItem (string acId);
        /// <summary>
        /// Get all accounting codes This reference describes how to query all accounting codes in your chart of accounts through the REST API.
        /// </summary>
        /// <returns>GETAccountingCodesType</returns>
        GETAccountingCodesType GETAccountingCodes ();
        /// <summary>
        /// Create accounting code This reference describes how to create a new accounting code through the REST API.  The accounting code will be active as soon as it has been created.  ## Prerequisites   If you have Z-Finance enabled on your tenant, you must have the Z-Finance Create Accounting Code permission. See [Z-Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles). 
        /// </summary>
        /// <param name="request"></param>
        /// <returns>POSTAccountingCodeResponseType</returns>
        POSTAccountingCodeResponseType POSTAccountingCode (POSTAccountingCodeType request);
        /// <summary>
        /// Update an accounting code This reference describes how to update an existing accounting code through the REST API. ## Prerequisites   If you have Z-Finance enabled on your tenant, you must have the Z-Finance Manage Accounting Code permission. See [Z-Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles). ## Limitations You can only update accounting codes that are not already associated with any transactions. 
        /// </summary>
        /// <param name="acId">ID of the accounting code you want to update.</param>
        /// <param name="request"></param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType PUTAccountingCode (string acId, PUTAccountingCodeType request);
        /// <summary>
        /// Activate accounting code This reference describes how to [activate an accounting code](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/G_Chart_of_Accounts/A_Set_Up_Chart_of_Accounts#Activate_or_Deactivate_an_Accounting_Code) through the REST API.  Prerequisites ------------- If you have Z-Finance enabled on your tenant, you must have the Z-Finance Manage Accounting Code permission. See [Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles). 
        /// </summary>
        /// <param name="acId">ID of the accounting code you want to activate.</param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType PUTActivateAccountingCode (string acId);
        /// <summary>
        /// Deactivate accounting code This reference describes how to [deactivate an accounting code](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/G_Chart_of_Accounts/A_Set_Up_Chart_of_Accounts#Activate_or_Deactivate_an_Accounting_Code) through the REST API.  ## Prerequisites If you have Z-Finance enabled on your tenant, you must have the Z-Finance Manage Accounting Code permission. See [Z-Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles). ## Limitations You can only deactivate accounting codes that are not associated with any transactions.  You cannot disable accounting codes of type AccountsReceivable. 
        /// </summary>
        /// <param name="acId">ID of the accounting code you want to deactivate.</param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType PUTDeactivateAccountingCode (string acId);
        /// <summary>
        /// CRUD: Delete AccountingCode 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <returns>ProxyDeleteResponse</returns>
        ProxyDeleteResponse ProxyDELETEAccountingCode (string id);
        /// <summary>
        /// CRUD: Retrieve AccountingCode 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="fields">Object fields to return</param>
        /// <returns>ProxyGetAccountingCode</returns>
        ProxyGetAccountingCode ProxyGETAccountingCode (string id, string fields);
        /// <summary>
        /// CRUD: Create AccountingCode 
        /// </summary>
        /// <param name="createRequest"></param>
        /// <returns>ProxyCreateOrModifyResponse</returns>
        ProxyCreateOrModifyResponse ProxyPOSTAccountingCode (ProxyCreateAccountingCode createRequest);
        /// <summary>
        /// CRUD: Update AccountingCode 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="modifyRequest"></param>
        /// <returns>ProxyCreateOrModifyResponse</returns>
        ProxyCreateOrModifyResponse ProxyPUTAccountingCode (string id, ProxyModifyAccountingCode modifyRequest);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountingCodesApi : IAccountingCodesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingCodesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccountingCodesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingCodesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountingCodesApi(String basePath)
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
        /// Delete accounting code This reference describes how to [delete an accounting code](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/G_Chart_of_Accounts/A_Set_Up_Chart_of_Accounts#Delete_an_Accounting_Code) through the REST API. ## Prerequisites If you have Z-Finance enabled on your tenant, then you must have the Z-Finance Delete Unused Accounting Code permission. See [Z-Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles). ## Limitations You can only delete accounting codes that have never been associated with any transactions. An accounting code must be deactivated before you can delete it. 
        /// </summary>
        /// <param name="acId">ID of the accounting code you want to delete.</param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType DELETEAccountingCode (string acId)
        {
            
            // verify the required parameter 'acId' is set
            if (acId == null) throw new ApiException(400, "Missing required parameter 'acId' when calling DELETEAccountingCode");
            
    
            var path = "/accounting-codes/{ac-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ac-id" + "}", ApiClient.ParameterToString(acId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEAccountingCode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEAccountingCode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// Query an accounting code This reference describes how to query an accounting code through the REST API.
        /// </summary>
        /// <param name="acId">ID of the accounting code you want to query.</param> 
        /// <returns>GETAccountingCodeItemType</returns>            
        public GETAccountingCodeItemType GETAccountingCodeItem (string acId)
        {
            
            // verify the required parameter 'acId' is set
            if (acId == null) throw new ApiException(400, "Missing required parameter 'acId' when calling GETAccountingCodeItem");
            
    
            var path = "/accounting-codes/{ac-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ac-id" + "}", ApiClient.ParameterToString(acId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccountingCodeItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccountingCodeItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETAccountingCodeItemType) ApiClient.Deserialize(response.Content, typeof(GETAccountingCodeItemType), response.Headers);
        }
    
        /// <summary>
        /// Get all accounting codes This reference describes how to query all accounting codes in your chart of accounts through the REST API.
        /// </summary>
        /// <returns>GETAccountingCodesType</returns>            
        public GETAccountingCodesType GETAccountingCodes ()
        {
            
    
            var path = "/accounting-codes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccountingCodes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccountingCodes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETAccountingCodesType) ApiClient.Deserialize(response.Content, typeof(GETAccountingCodesType), response.Headers);
        }
    
        /// <summary>
        /// Create accounting code This reference describes how to create a new accounting code through the REST API.  The accounting code will be active as soon as it has been created.  ## Prerequisites   If you have Z-Finance enabled on your tenant, you must have the Z-Finance Create Accounting Code permission. See [Z-Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles). 
        /// </summary>
        /// <param name="request"></param> 
        /// <returns>POSTAccountingCodeResponseType</returns>            
        public POSTAccountingCodeResponseType POSTAccountingCode (POSTAccountingCodeType request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTAccountingCode");
            
    
            var path = "/accounting-codes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTAccountingCode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTAccountingCode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTAccountingCodeResponseType) ApiClient.Deserialize(response.Content, typeof(POSTAccountingCodeResponseType), response.Headers);
        }
    
        /// <summary>
        /// Update an accounting code This reference describes how to update an existing accounting code through the REST API. ## Prerequisites   If you have Z-Finance enabled on your tenant, you must have the Z-Finance Manage Accounting Code permission. See [Z-Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles). ## Limitations You can only update accounting codes that are not already associated with any transactions. 
        /// </summary>
        /// <param name="acId">ID of the accounting code you want to update.</param> 
        /// <param name="request"></param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType PUTAccountingCode (string acId, PUTAccountingCodeType request)
        {
            
            // verify the required parameter 'acId' is set
            if (acId == null) throw new ApiException(400, "Missing required parameter 'acId' when calling PUTAccountingCode");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling PUTAccountingCode");
            
    
            var path = "/accounting-codes/{ac-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ac-id" + "}", ApiClient.ParameterToString(acId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTAccountingCode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTAccountingCode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// Activate accounting code This reference describes how to [activate an accounting code](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/G_Chart_of_Accounts/A_Set_Up_Chart_of_Accounts#Activate_or_Deactivate_an_Accounting_Code) through the REST API.  Prerequisites ------------- If you have Z-Finance enabled on your tenant, you must have the Z-Finance Manage Accounting Code permission. See [Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles). 
        /// </summary>
        /// <param name="acId">ID of the accounting code you want to activate.</param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType PUTActivateAccountingCode (string acId)
        {
            
            // verify the required parameter 'acId' is set
            if (acId == null) throw new ApiException(400, "Missing required parameter 'acId' when calling PUTActivateAccountingCode");
            
    
            var path = "/accounting-codes/{ac-id}/activate";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ac-id" + "}", ApiClient.ParameterToString(acId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTActivateAccountingCode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTActivateAccountingCode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// Deactivate accounting code This reference describes how to [deactivate an accounting code](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/G_Chart_of_Accounts/A_Set_Up_Chart_of_Accounts#Activate_or_Deactivate_an_Accounting_Code) through the REST API.  ## Prerequisites If you have Z-Finance enabled on your tenant, you must have the Z-Finance Manage Accounting Code permission. See [Z-Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles). ## Limitations You can only deactivate accounting codes that are not associated with any transactions.  You cannot disable accounting codes of type AccountsReceivable. 
        /// </summary>
        /// <param name="acId">ID of the accounting code you want to deactivate.</param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType PUTDeactivateAccountingCode (string acId)
        {
            
            // verify the required parameter 'acId' is set
            if (acId == null) throw new ApiException(400, "Missing required parameter 'acId' when calling PUTDeactivateAccountingCode");
            
    
            var path = "/accounting-codes/{ac-id}/deactivate";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ac-id" + "}", ApiClient.ParameterToString(acId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTDeactivateAccountingCode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTDeactivateAccountingCode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Delete AccountingCode 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <returns>ProxyDeleteResponse</returns>            
        public ProxyDeleteResponse ProxyDELETEAccountingCode (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyDELETEAccountingCode");
            
    
            var path = "/object/accounting-code/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETEAccountingCode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETEAccountingCode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyDeleteResponse) ApiClient.Deserialize(response.Content, typeof(ProxyDeleteResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Retrieve AccountingCode 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="fields">Object fields to return</param> 
        /// <returns>ProxyGetAccountingCode</returns>            
        public ProxyGetAccountingCode ProxyGETAccountingCode (string id, string fields)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyGETAccountingCode");
            
    
            var path = "/object/accounting-code/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETAccountingCode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETAccountingCode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyGetAccountingCode) ApiClient.Deserialize(response.Content, typeof(ProxyGetAccountingCode), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Create AccountingCode 
        /// </summary>
        /// <param name="createRequest"></param> 
        /// <returns>ProxyCreateOrModifyResponse</returns>            
        public ProxyCreateOrModifyResponse ProxyPOSTAccountingCode (ProxyCreateAccountingCode createRequest)
        {
            
            // verify the required parameter 'createRequest' is set
            if (createRequest == null) throw new ApiException(400, "Missing required parameter 'createRequest' when calling ProxyPOSTAccountingCode");
            
    
            var path = "/object/accounting-code";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPOSTAccountingCode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPOSTAccountingCode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyCreateOrModifyResponse) ApiClient.Deserialize(response.Content, typeof(ProxyCreateOrModifyResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Update AccountingCode 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="modifyRequest"></param> 
        /// <returns>ProxyCreateOrModifyResponse</returns>            
        public ProxyCreateOrModifyResponse ProxyPUTAccountingCode (string id, ProxyModifyAccountingCode modifyRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyPUTAccountingCode");
            
            // verify the required parameter 'modifyRequest' is set
            if (modifyRequest == null) throw new ApiException(400, "Missing required parameter 'modifyRequest' when calling ProxyPUTAccountingCode");
            
    
            var path = "/object/accounting-code/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPUTAccountingCode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPUTAccountingCode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyCreateOrModifyResponse) ApiClient.Deserialize(response.Content, typeof(ProxyCreateOrModifyResponse), response.Headers);
        }
    
    }
}
