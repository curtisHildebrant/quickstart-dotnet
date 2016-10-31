using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGetFilesApi
    {
        /// <summary>
        /// Get files Retrieve a file by specifying its file ID. You can retrieve accounting period reports, such as the Revenue Detail report, as well as other files such as invoice PDFs.  ## Example  &#x60;&#x60;&#x60;curl curl -i -k -H \&quot;apiAccessKeyId:$USER_NAME\&quot; -H \&quot;apiSecretAccessKey:$PASSWORD\&quot; -H \&quot;Accept:application/pdf\&quot; -X GET https://apisandbox-api.zuora.com/rest/v1/files/2c92c08c55534cf00155581fb474314d -o /Users/jsmith/Downloads/invoiceFile1.pdf &#x60;&#x60;&#x60; The invoice PDF is downloaded to /Users/jsmith/Downloads and named invoiceFile1.pdf.  ## File Size Limitation The maximum export file size is 2047MB. If you have large data requests that go over this limit, you will get the following 403 HTTP response code from Zuora.  &#x60;&lt;security:max-object-size&gt;2047MB&lt;/security:max-object-size&gt;&#x60;  Submit a request at [Zuora Global Support](https://zuora.zendesk.com/agent/) if you require additional assistance.  We can work with you to determine if large file optimization is an option for you. 
        /// </summary>
        /// <param name="fileId">The Zuora ID of the file you want to retrieve.  See [Get Accounting Period](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Accounting_Periods/Get_Accounting_Period) for getting file IDs of accounting period reports, such as the Revenue Detail report. </param>
        /// <returns></returns>
        void GETFiles (string fileId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GetFilesApi : IGetFilesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public GetFilesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GetFilesApi(String basePath)
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
        /// Get files Retrieve a file by specifying its file ID. You can retrieve accounting period reports, such as the Revenue Detail report, as well as other files such as invoice PDFs.  ## Example  &#x60;&#x60;&#x60;curl curl -i -k -H \&quot;apiAccessKeyId:$USER_NAME\&quot; -H \&quot;apiSecretAccessKey:$PASSWORD\&quot; -H \&quot;Accept:application/pdf\&quot; -X GET https://apisandbox-api.zuora.com/rest/v1/files/2c92c08c55534cf00155581fb474314d -o /Users/jsmith/Downloads/invoiceFile1.pdf &#x60;&#x60;&#x60; The invoice PDF is downloaded to /Users/jsmith/Downloads and named invoiceFile1.pdf.  ## File Size Limitation The maximum export file size is 2047MB. If you have large data requests that go over this limit, you will get the following 403 HTTP response code from Zuora.  &#x60;&lt;security:max-object-size&gt;2047MB&lt;/security:max-object-size&gt;&#x60;  Submit a request at [Zuora Global Support](https://zuora.zendesk.com/agent/) if you require additional assistance.  We can work with you to determine if large file optimization is an option for you. 
        /// </summary>
        /// <param name="fileId">The Zuora ID of the file you want to retrieve.  See [Get Accounting Period](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Accounting_Periods/Get_Accounting_Period) for getting file IDs of accounting period reports, such as the Revenue Detail report. </param> 
        /// <returns></returns>            
        public void GETFiles (string fileId)
        {
            
            // verify the required parameter 'fileId' is set
            if (fileId == null) throw new ApiException(400, "Missing required parameter 'fileId' when calling GETFiles");
            
    
            var path = "/files/{file-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "file-id" + "}", ApiClient.ParameterToString(fileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETFiles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETFiles: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
