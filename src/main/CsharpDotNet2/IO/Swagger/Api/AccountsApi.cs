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
    public interface IAccountsApi
    {
        /// <summary>
        /// Get account This REST API reference describes how to retrieve basic information about a customer account.  This REST call is a quick retrieval that doesn&#39;t include the account&#39;s subscriptions, invoices, payments, or usage details. Use the [Get account summary](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Accounts/3_GET_account_summary) to get more detailed information about an account. 
        /// </summary>
        /// <param name="accountKey">Account number or account ID.</param>
        /// <returns>GETAccountType</returns>
        GETAccountType GETAccount (string accountKey);
        /// <summary>
        /// Get account summary This REST API reference describes how to retrieve detailed information about the specified customer account.  The response includes everything retrieved with the [Get basic account information](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Accounts/2_Get_account_basics) call, plus a summary of the account&#39;s subscriptions, invoices, payments, and usage for the last six months.  ## Notes  Returns only the six most recent subscriptions based on the subscription updatedDate. Within those subscriptions, there may be many rate plans and many rate plan charges. These items are subject to the maximum limit on the array size. See [REST API basics](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information on concurrent request limits. 
        /// </summary>
        /// <param name="accountKey">Account number or account ID.</param>
        /// <returns>GETAccountSummaryType</returns>
        GETAccountSummaryType GETAccountSummary (string accountKey);
        /// <summary>
        /// Create account This REST API reference describes how to create a customer account with a credit-card payment method, a bill-to contact, and an optional sold-to contact. Request and response field descriptions and sample code are provided. Use this method to optionally create a subscription, invoice for that subscription, and collect payment through the default payment method. The transaction is atomic; if any part fails for any reason, the entire transaction is rolled back.  This API call is CORS Enabled, so you can use client-side Javascript to invoke the call. For more information, visit the [Zuora CORS REST](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics/G_CORS_REST) page.  ## Notes 1. The account is created in active status.   2. The request must provide either a **creditCard** structure or the **hpmCreditCardPaymentMethodId** field (but not both). The one provided becomes the default payment method for this account. If the credit card information is declined or can&#39;t be verified, then the account is not created. 3. Customer accounts created with this call are automatically be set to Auto Pay. 4. If either the **workEmail** or **personalEmail** are specified, then the account&#39;s email delivery preference is automatically set to &#x60;true&#x60;. (In that case, emails go to the **workEmail** address, if it exists, or else the **personalEmail**.) If neither field is specified, the email delivery preference is automatically set to &#x60;false&#x60;.  ## Defaults for customerAcceptanceDate and serviceActivationDate Default values for **customerAcceptanceDate** and **serviceActivationDate** are set as follows.  |        | serviceActivationDate(SA) specified          | serviceActivationDate (SA) NOT specified  | | ------------- |:-------------:| -----:| | customerAcceptanceDate (CA) specified      | SA uses value in the request call; CA uses value in the request call| CA uses value in the request call;SA uses CE as default | | customerAcceptanceDate (CA) NOT specified      | SA uses value in the request call; CA uses SA as default |   SA and CA use CE as default | 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="zuoraVersion">The minor version of the Zuora REST API. You only need to set this parameter if you use the __collect__ or __invoice__ fields. See [REST API Basics](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information.</param>
        /// <returns>POSTAccountResponseType</returns>
        POSTAccountResponseType POSTAccount (POSTAccountType request, string zuoraVersion);
        /// <summary>
        /// Update account This REST API reference describes how to update a customer account by specifying the account-key.  ## Notes 1. Only the fields to be changed should be specified.  Any field that&#39;s not included in the request body will not be changed. 2. If an empty field is submitted with this call, the corresponding field in the account is emptied. 3. Email addresses: If no email addresses are specified, no change is made to the email addresses on file or to the email delivery preference. If either the **personalEmail** or **workEmail** is specified (or both), the system updates the corresponding email address(es) on file and the email delivery preference is set to &#x60;true&#x60;. (In that case, emails go to the **workEmail** address, if it exists, or else the **personalEmail**.) On the other hand, if as a result of this call both of the email addresses for the account are empty, the email delivery preference is set to &#x60;false&#x60;. 4. The bill-to and sold-to contacts are separate data entities; updating either one does not update the other. 
        /// </summary>
        /// <param name="accountKey">Account number or account ID.</param>
        /// <param name="request"></param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType PUTAccount (string accountKey, PUTAccountType request);
        /// <summary>
        /// CRUD: Delete Account 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <returns>ProxyDeleteResponse</returns>
        ProxyDeleteResponse ProxyDELETEAccount (string id);
        /// <summary>
        /// CRUD: Retrieve Account 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="fields">Object fields to return</param>
        /// <returns>ProxyGetAccount</returns>
        ProxyGetAccount ProxyGETAccount (string id, string fields);
        /// <summary>
        /// CRUD: Create Account 
        /// </summary>
        /// <param name="createRequest"></param>
        /// <returns>ProxyCreateOrModifyResponse</returns>
        ProxyCreateOrModifyResponse ProxyPOSTAccount (ProxyCreateAccount createRequest);
        /// <summary>
        /// CRUD: Update Account 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="modifyRequest"></param>
        /// <returns>ProxyCreateOrModifyResponse</returns>
        ProxyCreateOrModifyResponse ProxyPUTAccount (string id, ProxyModifyAccount modifyRequest);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountsApi : IAccountsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccountsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi(String basePath)
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
        /// Get account This REST API reference describes how to retrieve basic information about a customer account.  This REST call is a quick retrieval that doesn&#39;t include the account&#39;s subscriptions, invoices, payments, or usage details. Use the [Get account summary](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Accounts/3_GET_account_summary) to get more detailed information about an account. 
        /// </summary>
        /// <param name="accountKey">Account number or account ID.</param> 
        /// <returns>GETAccountType</returns>            
        public GETAccountType GETAccount (string accountKey)
        {
            
            // verify the required parameter 'accountKey' is set
            if (accountKey == null) throw new ApiException(400, "Missing required parameter 'accountKey' when calling GETAccount");
            
    
            var path = "/accounts/{account-key}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETAccountType) ApiClient.Deserialize(response.Content, typeof(GETAccountType), response.Headers);
        }
    
        /// <summary>
        /// Get account summary This REST API reference describes how to retrieve detailed information about the specified customer account.  The response includes everything retrieved with the [Get basic account information](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Accounts/2_Get_account_basics) call, plus a summary of the account&#39;s subscriptions, invoices, payments, and usage for the last six months.  ## Notes  Returns only the six most recent subscriptions based on the subscription updatedDate. Within those subscriptions, there may be many rate plans and many rate plan charges. These items are subject to the maximum limit on the array size. See [REST API basics](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information on concurrent request limits. 
        /// </summary>
        /// <param name="accountKey">Account number or account ID.</param> 
        /// <returns>GETAccountSummaryType</returns>            
        public GETAccountSummaryType GETAccountSummary (string accountKey)
        {
            
            // verify the required parameter 'accountKey' is set
            if (accountKey == null) throw new ApiException(400, "Missing required parameter 'accountKey' when calling GETAccountSummary");
            
    
            var path = "/accounts/{account-key}/Summary";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccountSummary: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccountSummary: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETAccountSummaryType) ApiClient.Deserialize(response.Content, typeof(GETAccountSummaryType), response.Headers);
        }
    
        /// <summary>
        /// Create account This REST API reference describes how to create a customer account with a credit-card payment method, a bill-to contact, and an optional sold-to contact. Request and response field descriptions and sample code are provided. Use this method to optionally create a subscription, invoice for that subscription, and collect payment through the default payment method. The transaction is atomic; if any part fails for any reason, the entire transaction is rolled back.  This API call is CORS Enabled, so you can use client-side Javascript to invoke the call. For more information, visit the [Zuora CORS REST](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics/G_CORS_REST) page.  ## Notes 1. The account is created in active status.   2. The request must provide either a **creditCard** structure or the **hpmCreditCardPaymentMethodId** field (but not both). The one provided becomes the default payment method for this account. If the credit card information is declined or can&#39;t be verified, then the account is not created. 3. Customer accounts created with this call are automatically be set to Auto Pay. 4. If either the **workEmail** or **personalEmail** are specified, then the account&#39;s email delivery preference is automatically set to &#x60;true&#x60;. (In that case, emails go to the **workEmail** address, if it exists, or else the **personalEmail**.) If neither field is specified, the email delivery preference is automatically set to &#x60;false&#x60;.  ## Defaults for customerAcceptanceDate and serviceActivationDate Default values for **customerAcceptanceDate** and **serviceActivationDate** are set as follows.  |        | serviceActivationDate(SA) specified          | serviceActivationDate (SA) NOT specified  | | ------------- |:-------------:| -----:| | customerAcceptanceDate (CA) specified      | SA uses value in the request call; CA uses value in the request call| CA uses value in the request call;SA uses CE as default | | customerAcceptanceDate (CA) NOT specified      | SA uses value in the request call; CA uses SA as default |   SA and CA use CE as default | 
        /// </summary>
        /// <param name="request"></param> 
        /// <param name="zuoraVersion">The minor version of the Zuora REST API. You only need to set this parameter if you use the __collect__ or __invoice__ fields. See [REST API Basics](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information.</param> 
        /// <returns>POSTAccountResponseType</returns>            
        public POSTAccountResponseType POSTAccount (POSTAccountType request, string zuoraVersion)
        {
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTAccount");
            
    
            var path = "/accounts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (zuoraVersion != null) headerParams.Add("zuora-version", ApiClient.ParameterToString(zuoraVersion)); // header parameter
                        postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTAccountResponseType) ApiClient.Deserialize(response.Content, typeof(POSTAccountResponseType), response.Headers);
        }
    
        /// <summary>
        /// Update account This REST API reference describes how to update a customer account by specifying the account-key.  ## Notes 1. Only the fields to be changed should be specified.  Any field that&#39;s not included in the request body will not be changed. 2. If an empty field is submitted with this call, the corresponding field in the account is emptied. 3. Email addresses: If no email addresses are specified, no change is made to the email addresses on file or to the email delivery preference. If either the **personalEmail** or **workEmail** is specified (or both), the system updates the corresponding email address(es) on file and the email delivery preference is set to &#x60;true&#x60;. (In that case, emails go to the **workEmail** address, if it exists, or else the **personalEmail**.) On the other hand, if as a result of this call both of the email addresses for the account are empty, the email delivery preference is set to &#x60;false&#x60;. 4. The bill-to and sold-to contacts are separate data entities; updating either one does not update the other. 
        /// </summary>
        /// <param name="accountKey">Account number or account ID.</param> 
        /// <param name="request"></param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType PUTAccount (string accountKey, PUTAccountType request)
        {
            
            // verify the required parameter 'accountKey' is set
            if (accountKey == null) throw new ApiException(400, "Missing required parameter 'accountKey' when calling PUTAccount");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling PUTAccount");
            
    
            var path = "/accounts/{account-key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "account-key" + "}", ApiClient.ParameterToString(accountKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Delete Account 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <returns>ProxyDeleteResponse</returns>            
        public ProxyDeleteResponse ProxyDELETEAccount (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyDELETEAccount");
            
    
            var path = "/object/account/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETEAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETEAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyDeleteResponse) ApiClient.Deserialize(response.Content, typeof(ProxyDeleteResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Retrieve Account 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="fields">Object fields to return</param> 
        /// <returns>ProxyGetAccount</returns>            
        public ProxyGetAccount ProxyGETAccount (string id, string fields)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyGETAccount");
            
    
            var path = "/object/account/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyGetAccount) ApiClient.Deserialize(response.Content, typeof(ProxyGetAccount), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Create Account 
        /// </summary>
        /// <param name="createRequest"></param> 
        /// <returns>ProxyCreateOrModifyResponse</returns>            
        public ProxyCreateOrModifyResponse ProxyPOSTAccount (ProxyCreateAccount createRequest)
        {
            
            // verify the required parameter 'createRequest' is set
            if (createRequest == null) throw new ApiException(400, "Missing required parameter 'createRequest' when calling ProxyPOSTAccount");
            
    
            var path = "/object/account";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPOSTAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPOSTAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyCreateOrModifyResponse) ApiClient.Deserialize(response.Content, typeof(ProxyCreateOrModifyResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Update Account 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="modifyRequest"></param> 
        /// <returns>ProxyCreateOrModifyResponse</returns>            
        public ProxyCreateOrModifyResponse ProxyPUTAccount (string id, ProxyModifyAccount modifyRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyPUTAccount");
            
            // verify the required parameter 'modifyRequest' is set
            if (modifyRequest == null) throw new ApiException(400, "Missing required parameter 'modifyRequest' when calling ProxyPUTAccount");
            
    
            var path = "/object/account/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPUTAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPUTAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyCreateOrModifyResponse) ApiClient.Deserialize(response.Content, typeof(ProxyCreateOrModifyResponse), response.Headers);
        }
    
    }
}
