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
    public interface IOperationsApi
    {
        /// <summary>
        /// Invoice and collect Generates invoices and collects payments for a specified account.  This method can generate invoices and collect payments on the invoices generated, or else simply collect payment on a specified existing invoice. The customer&#39;s default payment method is used, and the full amount due is collected. The operation depends on the parameters you specify  - To generate one or more new invoices for that customer and collect payment on the generated invoice(s), leave the **invoiceId** field empty.   - To collect payment on an existing invoice, specify the invoice ID.    The operation is atomic; if any part is unsuccessful, the entire operation is rolled back.   ## Notes  Timeouts may occur when using this method on an account that has an extremely high number of subscriptions. 
        /// </summary>
        /// <param name="request">Customer account ID or account number.</param>
        /// <returns>POSTInvoiceCollectResponseType</returns>
        POSTInvoiceCollectResponseType POSTTransactionInvoicePayment (POSTInvoiceCollectType request);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OperationsApi : IOperationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OperationsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OperationsApi(String basePath)
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
        /// Invoice and collect Generates invoices and collects payments for a specified account.  This method can generate invoices and collect payments on the invoices generated, or else simply collect payment on a specified existing invoice. The customer&#39;s default payment method is used, and the full amount due is collected. The operation depends on the parameters you specify  - To generate one or more new invoices for that customer and collect payment on the generated invoice(s), leave the **invoiceId** field empty.   - To collect payment on an existing invoice, specify the invoice ID.    The operation is atomic; if any part is unsuccessful, the entire operation is rolled back.   ## Notes  Timeouts may occur when using this method on an account that has an extremely high number of subscriptions. 
        /// </summary>
        /// <param name="request">Customer account ID or account number.</param> 
        /// <returns>POSTInvoiceCollectResponseType</returns>            
        public POSTInvoiceCollectResponseType POSTTransactionInvoicePayment (POSTInvoiceCollectType request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTTransactionInvoicePayment");
            
    
            var path = "/operations/invoice-collect";
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTTransactionInvoicePayment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTTransactionInvoicePayment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTInvoiceCollectResponseType) ApiClient.Deserialize(response.Content, typeof(POSTInvoiceCollectResponseType), response.Headers);
        }
    
    }
}
