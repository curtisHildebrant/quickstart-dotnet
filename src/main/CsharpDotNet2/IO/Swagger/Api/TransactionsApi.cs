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
    public interface ITransactionsApi
    {
        /// <summary>
        /// Get invoices Retrieves invoices for a specified account.  Invoices are returned in reverse chronological order by **updatedDate**. 
        /// </summary>
        /// <param name="accountKey">Account number or account ID. </param>
        /// <returns>GETInvoiceFileWrapper</returns>
        GETInvoiceFileWrapper GETInvoice (string accountKey);
        /// <summary>
        /// Get payments Retrieves payments for a specified account. Payments are returned in reverse chronological order by **updatedDate**. 
        /// </summary>
        /// <param name="accountKey">Account number or account ID.</param>
        /// <returns>GETPaymentsType</returns>
        GETPaymentsType GETPayments (string accountKey);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TransactionsApi : ITransactionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TransactionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionsApi(String basePath)
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
        /// Get invoices Retrieves invoices for a specified account.  Invoices are returned in reverse chronological order by **updatedDate**. 
        /// </summary>
        /// <param name="accountKey">Account number or account ID. </param> 
        /// <returns>GETInvoiceFileWrapper</returns>            
        public GETInvoiceFileWrapper GETInvoice (string accountKey)
        {
            
            // verify the required parameter 'accountKey' is set
            if (accountKey == null) throw new ApiException(400, "Missing required parameter 'accountKey' when calling GETInvoice");
            
    
            var path = "/transactions/invoices/accounts/{account-key}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETInvoice: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETInvoiceFileWrapper) ApiClient.Deserialize(response.Content, typeof(GETInvoiceFileWrapper), response.Headers);
        }
    
        /// <summary>
        /// Get payments Retrieves payments for a specified account. Payments are returned in reverse chronological order by **updatedDate**. 
        /// </summary>
        /// <param name="accountKey">Account number or account ID.</param> 
        /// <returns>GETPaymentsType</returns>            
        public GETPaymentsType GETPayments (string accountKey)
        {
            
            // verify the required parameter 'accountKey' is set
            if (accountKey == null) throw new ApiException(400, "Missing required parameter 'accountKey' when calling GETPayments");
            
    
            var path = "/transactions/payments/accounts/{account-key}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETPayments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETPayments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETPaymentsType) ApiClient.Deserialize(response.Content, typeof(GETPaymentsType), response.Headers);
        }
    
    }
}
