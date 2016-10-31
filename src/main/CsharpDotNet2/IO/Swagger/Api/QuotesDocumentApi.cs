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
    public interface IQuotesDocumentApi
    {
        /// <summary>
        /// Generate quotes document The &#x60;document&#x60; call generates a quote document and returns the generated document URL. You can directly access the generated quote file through the returned URL.  The &#x60;document&#x60; call should be only used from Zuora Quotes.   ## File Size Limitation  The maximum export file size is 2047MB. If you have large data requests that go over this limit, you will get the following 403 HTTP response code from Zuora: &#x60;security:max-object-size&gt;2047MB&lt;/security:max-object-size&gt;&#x60;  Submit a request at [Zuora Global Support](http://support.zuora.com/) if you require additional assistance.  We can work with you to determine if large file optimization is an option for you. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns>POSTQuoteDocResponseType</returns>
        POSTQuoteDocResponseType POSTQuoteDoc (POSTQuoteDocType request);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class QuotesDocumentApi : IQuotesDocumentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotesDocumentApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public QuotesDocumentApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotesDocumentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public QuotesDocumentApi(String basePath)
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
        /// Generate quotes document The &#x60;document&#x60; call generates a quote document and returns the generated document URL. You can directly access the generated quote file through the returned URL.  The &#x60;document&#x60; call should be only used from Zuora Quotes.   ## File Size Limitation  The maximum export file size is 2047MB. If you have large data requests that go over this limit, you will get the following 403 HTTP response code from Zuora: &#x60;security:max-object-size&gt;2047MB&lt;/security:max-object-size&gt;&#x60;  Submit a request at [Zuora Global Support](http://support.zuora.com/) if you require additional assistance.  We can work with you to determine if large file optimization is an option for you. 
        /// </summary>
        /// <param name="request"></param> 
        /// <returns>POSTQuoteDocResponseType</returns>            
        public POSTQuoteDocResponseType POSTQuoteDoc (POSTQuoteDocType request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTQuoteDoc");
            
    
            var path = "/quotes/document";
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTQuoteDoc: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTQuoteDoc: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTQuoteDocResponseType) ApiClient.Deserialize(response.Content, typeof(POSTQuoteDocResponseType), response.Headers);
        }
    
    }
}
