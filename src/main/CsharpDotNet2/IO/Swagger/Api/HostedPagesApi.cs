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
    public interface IHostedPagesApi
    {
        /// <summary>
        /// Return hosted pages The hostedpages call returns the Payment Pages configuration metadata, specifically, page ID, page version, payment method type.  The following are the version-specific and general REST requests for Payment Pages:  * The request for Payment Pages 1.0 configuration information: &#x60;GET &lt;BaseURL&gt;/hostedpages?version&#x3D;1&#x60; * The request for Payment Pages 2.0 configuration information: &#x60;GET &lt;BaseURL&gt;/hostedpages?version&#x3D;2&#x60; * The request for all versions of Payment Pages configuration information: &#x60;GET &lt;BaseURL&gt;/hostedpages&#x60;  ## Notes If you do not have the corresponding tenant setting enabled, e.g., the request &#x60;version&#x60; parameter set to 2 with the Payment Pages 2.0 setting disabled, you will receive an error. 
        /// </summary>
        /// <param name="versionNumber">Version of the Payment Pages for which you want to retrieve the configuration information. Specify 1 for Payment Pages 1.0 or 2 for Payment Pages 2.0. If omitted, information for all versions of Payment Pages are returned.  The response also depends on your tenant settings for Payment Pages 1.0 and Payment Pages 2.0. For example, if only the tenant setting for Payment Pages 2.0 is enabled, the response will only contain information for Payment Pages 2.0 forms even when this parameter is omitted. </param>
        /// <returns>GetHostedPagesType</returns>
        GetHostedPagesType GetHostedPages (string versionNumber);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class HostedPagesApi : IHostedPagesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HostedPagesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public HostedPagesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HostedPagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HostedPagesApi(String basePath)
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
        /// Return hosted pages The hostedpages call returns the Payment Pages configuration metadata, specifically, page ID, page version, payment method type.  The following are the version-specific and general REST requests for Payment Pages:  * The request for Payment Pages 1.0 configuration information: &#x60;GET &lt;BaseURL&gt;/hostedpages?version&#x3D;1&#x60; * The request for Payment Pages 2.0 configuration information: &#x60;GET &lt;BaseURL&gt;/hostedpages?version&#x3D;2&#x60; * The request for all versions of Payment Pages configuration information: &#x60;GET &lt;BaseURL&gt;/hostedpages&#x60;  ## Notes If you do not have the corresponding tenant setting enabled, e.g., the request &#x60;version&#x60; parameter set to 2 with the Payment Pages 2.0 setting disabled, you will receive an error. 
        /// </summary>
        /// <param name="versionNumber">Version of the Payment Pages for which you want to retrieve the configuration information. Specify 1 for Payment Pages 1.0 or 2 for Payment Pages 2.0. If omitted, information for all versions of Payment Pages are returned.  The response also depends on your tenant settings for Payment Pages 1.0 and Payment Pages 2.0. For example, if only the tenant setting for Payment Pages 2.0 is enabled, the response will only contain information for Payment Pages 2.0 forms even when this parameter is omitted. </param> 
        /// <returns>GetHostedPagesType</returns>            
        public GetHostedPagesType GetHostedPages (string versionNumber)
        {
            
    
            var path = "/hostedpages";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (versionNumber != null) queryParams.Add("versionNumber", ApiClient.ParameterToString(versionNumber)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHostedPages: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHostedPages: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetHostedPagesType) ApiClient.Deserialize(response.Content, typeof(GetHostedPagesType), response.Headers);
        }
    
    }
}
