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
    public interface ICatalogApi
    {
        /// <summary>
        /// Get product catalog This REST API reference describes how to retrieve the entire product catalog, including all products, features, and their corresponding rate plans, charges. Products are returned in reverse chronological order on the UpdatedDate field.   The REST API does not support the creation or updating of products, product rate plans and charges; these tasks can only be performed in the web-based UI or via the SOAP API.   With rate plans and rate plan charges, the REST API has a maximum array size. For details, see [Array Size](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Array_Size). 
        /// </summary>
        /// <returns>GETCatalogType</returns>
        GETCatalogType GETCatalog ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CatalogApi : ICatalogApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CatalogApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CatalogApi(String basePath)
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
        /// Get product catalog This REST API reference describes how to retrieve the entire product catalog, including all products, features, and their corresponding rate plans, charges. Products are returned in reverse chronological order on the UpdatedDate field.   The REST API does not support the creation or updating of products, product rate plans and charges; these tasks can only be performed in the web-based UI or via the SOAP API.   With rate plans and rate plan charges, the REST API has a maximum array size. For details, see [Array Size](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Array_Size). 
        /// </summary>
        /// <returns>GETCatalogType</returns>            
        public GETCatalogType GETCatalog ()
        {
            
    
            var path = "/catalog/products";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETCatalog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETCatalog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETCatalogType) ApiClient.Deserialize(response.Content, typeof(GETCatalogType), response.Headers);
        }
    
    }
}
