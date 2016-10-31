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
    public interface IRevenueEventsApi
    {
        /// <summary>
        /// Get revenue events for a revenue schedule  This REST API reference describes how to get all revenue events in a revenue schedule by specifying the revenue schedule number. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="rsNumber">Revenue schedule number. The revenue schedule number is always prefixed with \&quot;RS\&quot;, for example, \&quot;RS-00000001\&quot;.</param>
        /// <returns>GETRevenueEventDetailsType</returns>
        GETRevenueEventDetailsType GETRevenueEventDetails (string rsNumber);
        /// <summary>
        /// Get revenue event details  This REST API reference describes how to get revenue event details by specifying the revenue event number. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="eventNumber">The number associated with the revenue event.</param>
        /// <returns>GETRevenueEventDetailType</returns>
        GETRevenueEventDetailType GETRevenueEventDetails_1 (string eventNumber);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RevenueEventsApi : IRevenueEventsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RevenueEventsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RevenueEventsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RevenueEventsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RevenueEventsApi(String basePath)
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
        /// Get revenue events for a revenue schedule  This REST API reference describes how to get all revenue events in a revenue schedule by specifying the revenue schedule number. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="rsNumber">Revenue schedule number. The revenue schedule number is always prefixed with \&quot;RS\&quot;, for example, \&quot;RS-00000001\&quot;.</param> 
        /// <returns>GETRevenueEventDetailsType</returns>            
        public GETRevenueEventDetailsType GETRevenueEventDetails (string rsNumber)
        {
            
            // verify the required parameter 'rsNumber' is set
            if (rsNumber == null) throw new ApiException(400, "Missing required parameter 'rsNumber' when calling GETRevenueEventDetails");
            
    
            var path = "/revenue-events/revenue-schedules/{rs-number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "rs-number" + "}", ApiClient.ParameterToString(rsNumber));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETRevenueEventDetails: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETRevenueEventDetails: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETRevenueEventDetailsType) ApiClient.Deserialize(response.Content, typeof(GETRevenueEventDetailsType), response.Headers);
        }
    
        /// <summary>
        /// Get revenue event details  This REST API reference describes how to get revenue event details by specifying the revenue event number. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="eventNumber">The number associated with the revenue event.</param> 
        /// <returns>GETRevenueEventDetailType</returns>            
        public GETRevenueEventDetailType GETRevenueEventDetails_1 (string eventNumber)
        {
            
            // verify the required parameter 'eventNumber' is set
            if (eventNumber == null) throw new ApiException(400, "Missing required parameter 'eventNumber' when calling GETRevenueEventDetails_1");
            
    
            var path = "/revenue-events/{event-number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "event-number" + "}", ApiClient.ParameterToString(eventNumber));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETRevenueEventDetails_1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETRevenueEventDetails_1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETRevenueEventDetailType) ApiClient.Deserialize(response.Content, typeof(GETRevenueEventDetailType), response.Headers);
        }
    
    }
}
