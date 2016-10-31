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
    public interface IPaymentMethodsApi
    {
        /// <summary>
        /// Delete payment method Deletes a credit card payment method from the specified customer account.  If the specified payment method is the account&#39;s default payment method, the request will fail.  In that case, you must first designate a different payment method for that customer to be the default. 
        /// </summary>
        /// <param name="paymentMethodId">Unique identifier of a payment method. (Since this ID is unique, and linked to a customer account in the system, no customer identifier is needed.)</param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType DELETEPaymentMethods (string paymentMethodId);
        /// <summary>
        /// Get payment methods This REST API reference describes how to retrieve all credit card information for the specified customer account.   ## Notes The response includes details credit or debit cards for the specified customer account. Card numbers are masked, e.g., \&quot;************1234\&quot;. Cards are returned in reverse chronological order of last update.  You can send requests for bank transfer payment methods types. The response will not include bank transfer details.  The response only includes payment details on payment methods that are credit or debit cards. 
        /// </summary>
        /// <param name="accountKey">Account number or account ID.</param>
        /// <returns>GETPaymentMethodsType</returns>
        GETPaymentMethodsType GETPaymentMethods (string accountKey);
        /// <summary>
        /// Create payment method This REST API reference describes how to create a new credit card payment method for a customer account.  ## Notes  This API call is CORS Enabled. Use client-side JavaScript to invoke the call. See [Zuora CORS REST](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics/G_CORS_REST) for more information.  
        /// </summary>
        /// <param name="request"></param>
        /// <returns>POSTPaymentMethodResponseType</returns>
        POSTPaymentMethodResponseType POSTPaymentMethod (POSTPaymentMethodType request);
        /// <summary>
        /// Update payment method Updates an existing credit card payment method for the specified customer account. 
        /// </summary>
        /// <param name="paymentMethodId">Unique ID of the payment method to update.</param>
        /// <param name="request"></param>
        /// <returns>PUTPaymentMethodResponseType</returns>
        PUTPaymentMethodResponseType PUTPaymentMethods (string paymentMethodId, PUTPaymentMethodType request);
        /// <summary>
        /// CRUD: Delete PaymentMethod 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <returns>ProxyDeleteResponse</returns>
        ProxyDeleteResponse ProxyDELETEPaymentMethod (string id);
        /// <summary>
        /// CRUD: Retrieve PaymentMethod 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="fields">Object fields to return</param>
        /// <returns>ProxyGetPaymentMethod</returns>
        ProxyGetPaymentMethod ProxyGETPaymentMethod (string id, string fields);
        /// <summary>
        /// CRUD: Create PaymentMethod 
        /// </summary>
        /// <param name="createRequest"></param>
        /// <returns>ProxyCreateOrModifyResponse</returns>
        ProxyCreateOrModifyResponse ProxyPOSTPaymentMethod (ProxyCreatePaymentMethod createRequest);
        /// <summary>
        /// CRUD: Update PaymentMethod 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="modifyRequest"></param>
        /// <returns>ProxyCreateOrModifyResponse</returns>
        ProxyCreateOrModifyResponse ProxyPUTPaymentMethod (string id, ProxyModifyPaymentMethod modifyRequest);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentMethodsApi : IPaymentMethodsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PaymentMethodsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentMethodsApi(String basePath)
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
        /// Delete payment method Deletes a credit card payment method from the specified customer account.  If the specified payment method is the account&#39;s default payment method, the request will fail.  In that case, you must first designate a different payment method for that customer to be the default. 
        /// </summary>
        /// <param name="paymentMethodId">Unique identifier of a payment method. (Since this ID is unique, and linked to a customer account in the system, no customer identifier is needed.)</param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType DELETEPaymentMethods (string paymentMethodId)
        {
            
            // verify the required parameter 'paymentMethodId' is set
            if (paymentMethodId == null) throw new ApiException(400, "Missing required parameter 'paymentMethodId' when calling DELETEPaymentMethods");
            
    
            var path = "/payment-methods/{payment-method-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "payment-method-id" + "}", ApiClient.ParameterToString(paymentMethodId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEPaymentMethods: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEPaymentMethods: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// Get payment methods This REST API reference describes how to retrieve all credit card information for the specified customer account.   ## Notes The response includes details credit or debit cards for the specified customer account. Card numbers are masked, e.g., \&quot;************1234\&quot;. Cards are returned in reverse chronological order of last update.  You can send requests for bank transfer payment methods types. The response will not include bank transfer details.  The response only includes payment details on payment methods that are credit or debit cards. 
        /// </summary>
        /// <param name="accountKey">Account number or account ID.</param> 
        /// <returns>GETPaymentMethodsType</returns>            
        public GETPaymentMethodsType GETPaymentMethods (string accountKey)
        {
            
            // verify the required parameter 'accountKey' is set
            if (accountKey == null) throw new ApiException(400, "Missing required parameter 'accountKey' when calling GETPaymentMethods");
            
    
            var path = "/payment-methods/credit-cards/accounts/{account-key}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETPaymentMethods: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETPaymentMethods: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETPaymentMethodsType) ApiClient.Deserialize(response.Content, typeof(GETPaymentMethodsType), response.Headers);
        }
    
        /// <summary>
        /// Create payment method This REST API reference describes how to create a new credit card payment method for a customer account.  ## Notes  This API call is CORS Enabled. Use client-side JavaScript to invoke the call. See [Zuora CORS REST](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics/G_CORS_REST) for more information.  
        /// </summary>
        /// <param name="request"></param> 
        /// <returns>POSTPaymentMethodResponseType</returns>            
        public POSTPaymentMethodResponseType POSTPaymentMethod (POSTPaymentMethodType request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTPaymentMethod");
            
    
            var path = "/payment-methods/credit-cards";
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentMethod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentMethod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTPaymentMethodResponseType) ApiClient.Deserialize(response.Content, typeof(POSTPaymentMethodResponseType), response.Headers);
        }
    
        /// <summary>
        /// Update payment method Updates an existing credit card payment method for the specified customer account. 
        /// </summary>
        /// <param name="paymentMethodId">Unique ID of the payment method to update.</param> 
        /// <param name="request"></param> 
        /// <returns>PUTPaymentMethodResponseType</returns>            
        public PUTPaymentMethodResponseType PUTPaymentMethods (string paymentMethodId, PUTPaymentMethodType request)
        {
            
            // verify the required parameter 'paymentMethodId' is set
            if (paymentMethodId == null) throw new ApiException(400, "Missing required parameter 'paymentMethodId' when calling PUTPaymentMethods");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling PUTPaymentMethods");
            
    
            var path = "/payment-methods/credit-cards/{payment-method-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "payment-method-id" + "}", ApiClient.ParameterToString(paymentMethodId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTPaymentMethods: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTPaymentMethods: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PUTPaymentMethodResponseType) ApiClient.Deserialize(response.Content, typeof(PUTPaymentMethodResponseType), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Delete PaymentMethod 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <returns>ProxyDeleteResponse</returns>            
        public ProxyDeleteResponse ProxyDELETEPaymentMethod (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyDELETEPaymentMethod");
            
    
            var path = "/object/payment-method/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETEPaymentMethod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETEPaymentMethod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyDeleteResponse) ApiClient.Deserialize(response.Content, typeof(ProxyDeleteResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Retrieve PaymentMethod 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="fields">Object fields to return</param> 
        /// <returns>ProxyGetPaymentMethod</returns>            
        public ProxyGetPaymentMethod ProxyGETPaymentMethod (string id, string fields)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyGETPaymentMethod");
            
    
            var path = "/object/payment-method/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETPaymentMethod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETPaymentMethod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyGetPaymentMethod) ApiClient.Deserialize(response.Content, typeof(ProxyGetPaymentMethod), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Create PaymentMethod 
        /// </summary>
        /// <param name="createRequest"></param> 
        /// <returns>ProxyCreateOrModifyResponse</returns>            
        public ProxyCreateOrModifyResponse ProxyPOSTPaymentMethod (ProxyCreatePaymentMethod createRequest)
        {
            
            // verify the required parameter 'createRequest' is set
            if (createRequest == null) throw new ApiException(400, "Missing required parameter 'createRequest' when calling ProxyPOSTPaymentMethod");
            
    
            var path = "/object/payment-method";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPOSTPaymentMethod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPOSTPaymentMethod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyCreateOrModifyResponse) ApiClient.Deserialize(response.Content, typeof(ProxyCreateOrModifyResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Update PaymentMethod 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="modifyRequest"></param> 
        /// <returns>ProxyCreateOrModifyResponse</returns>            
        public ProxyCreateOrModifyResponse ProxyPUTPaymentMethod (string id, ProxyModifyPaymentMethod modifyRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyPUTPaymentMethod");
            
            // verify the required parameter 'modifyRequest' is set
            if (modifyRequest == null) throw new ApiException(400, "Missing required parameter 'modifyRequest' when calling ProxyPUTPaymentMethod");
            
    
            var path = "/object/payment-method/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPUTPaymentMethod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPUTPaymentMethod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyCreateOrModifyResponse) ApiClient.Deserialize(response.Content, typeof(ProxyCreateOrModifyResponse), response.Headers);
        }
    
    }
}
