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
    public interface IRevenueItemsApi
    {
        /// <summary>
        /// Get revenue items by revenue event number This REST API reference describes how to get the details of each revenue item in a revenue event by specifying the revenue event number. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="eventNumber">The number associated with the revenue event.</param>
        /// <returns>GETRevenueItemsType</returns>
        GETRevenueItemsType GETRevenueItemsByChargeRevenueEventNumber (string eventNumber);
        /// <summary>
        /// Get revenue items by charge revenue summary number This REST API reference describes how to get the details for each revenue item in a charge revenue summary by specifying the charge revenue summary number. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="crsNumber">The charge revenue summary number.</param>
        /// <returns>GETRevenueItemsType</returns>
        GETRevenueItemsType GETRevenueItemsByChargeRevenueSummaryNumber (string crsNumber);
        /// <summary>
        /// Get revenue items by revenue schedule This REST API reference describes how to get the details for each revenue items in a revenue schedule by specifying the revenue schedule number. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="rsNumber">Revenue schedule number. The revenue schedule number is always prefixed with \&quot;RS\&quot;, for example, \&quot;RS-00000001\&quot;.</param>
        /// <returns>GETRsRevenueItemsType</returns>
        GETRsRevenueItemsType GETRevenueItemsByRevenueSchedule (string rsNumber);
        /// <summary>
        /// Update custom fields on revenue items by revenue event number This REST API reference describes how to update custom fields on revenue items by specifying the revenue event number. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="eventNumber">The number associated with the revenue event.</param>
        /// <param name="request"></param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType PUTCustomFieldsonRevenueItemsByRevenueEvent (string eventNumber, PUTEventRIDetailType request);
        /// <summary>
        /// Update custom fields on revenue items by revenue schedule number This REST API reference describes how to update custom fields on revenue Items by specifying the revenue schedule number. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="rsNumber">Revenue schedule number. The revenue schedule number is always prefixed with \&quot;RS\&quot;, for example, \&quot;RS-00000001\&quot;.</param>
        /// <param name="request"></param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType PUTCustomFieldsonRevenueItemsByRevenueSchedule (string rsNumber, PUTScheduleRIDetailType request);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RevenueItemsApi : IRevenueItemsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RevenueItemsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RevenueItemsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RevenueItemsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RevenueItemsApi(String basePath)
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
        /// Get revenue items by revenue event number This REST API reference describes how to get the details of each revenue item in a revenue event by specifying the revenue event number. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="eventNumber">The number associated with the revenue event.</param> 
        /// <returns>GETRevenueItemsType</returns>            
        public GETRevenueItemsType GETRevenueItemsByChargeRevenueEventNumber (string eventNumber)
        {
            
            // verify the required parameter 'eventNumber' is set
            if (eventNumber == null) throw new ApiException(400, "Missing required parameter 'eventNumber' when calling GETRevenueItemsByChargeRevenueEventNumber");
            
    
            var path = "/revenue-items/revenue-events/{event-number}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETRevenueItemsByChargeRevenueEventNumber: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETRevenueItemsByChargeRevenueEventNumber: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETRevenueItemsType) ApiClient.Deserialize(response.Content, typeof(GETRevenueItemsType), response.Headers);
        }
    
        /// <summary>
        /// Get revenue items by charge revenue summary number This REST API reference describes how to get the details for each revenue item in a charge revenue summary by specifying the charge revenue summary number. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="crsNumber">The charge revenue summary number.</param> 
        /// <returns>GETRevenueItemsType</returns>            
        public GETRevenueItemsType GETRevenueItemsByChargeRevenueSummaryNumber (string crsNumber)
        {
            
            // verify the required parameter 'crsNumber' is set
            if (crsNumber == null) throw new ApiException(400, "Missing required parameter 'crsNumber' when calling GETRevenueItemsByChargeRevenueSummaryNumber");
            
    
            var path = "/revenue-items/charge-revenue-summaries/{crs-number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "crs-number" + "}", ApiClient.ParameterToString(crsNumber));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETRevenueItemsByChargeRevenueSummaryNumber: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETRevenueItemsByChargeRevenueSummaryNumber: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETRevenueItemsType) ApiClient.Deserialize(response.Content, typeof(GETRevenueItemsType), response.Headers);
        }
    
        /// <summary>
        /// Get revenue items by revenue schedule This REST API reference describes how to get the details for each revenue items in a revenue schedule by specifying the revenue schedule number. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="rsNumber">Revenue schedule number. The revenue schedule number is always prefixed with \&quot;RS\&quot;, for example, \&quot;RS-00000001\&quot;.</param> 
        /// <returns>GETRsRevenueItemsType</returns>            
        public GETRsRevenueItemsType GETRevenueItemsByRevenueSchedule (string rsNumber)
        {
            
            // verify the required parameter 'rsNumber' is set
            if (rsNumber == null) throw new ApiException(400, "Missing required parameter 'rsNumber' when calling GETRevenueItemsByRevenueSchedule");
            
    
            var path = "/revenue-items/revenue-schedules/{rs-number}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETRevenueItemsByRevenueSchedule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETRevenueItemsByRevenueSchedule: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETRsRevenueItemsType) ApiClient.Deserialize(response.Content, typeof(GETRsRevenueItemsType), response.Headers);
        }
    
        /// <summary>
        /// Update custom fields on revenue items by revenue event number This REST API reference describes how to update custom fields on revenue items by specifying the revenue event number. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="eventNumber">The number associated with the revenue event.</param> 
        /// <param name="request"></param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType PUTCustomFieldsonRevenueItemsByRevenueEvent (string eventNumber, PUTEventRIDetailType request)
        {
            
            // verify the required parameter 'eventNumber' is set
            if (eventNumber == null) throw new ApiException(400, "Missing required parameter 'eventNumber' when calling PUTCustomFieldsonRevenueItemsByRevenueEvent");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling PUTCustomFieldsonRevenueItemsByRevenueEvent");
            
    
            var path = "/revenue-items/revenue-events/{event-number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "event-number" + "}", ApiClient.ParameterToString(eventNumber));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTCustomFieldsonRevenueItemsByRevenueEvent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTCustomFieldsonRevenueItemsByRevenueEvent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// Update custom fields on revenue items by revenue schedule number This REST API reference describes how to update custom fields on revenue Items by specifying the revenue schedule number. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="rsNumber">Revenue schedule number. The revenue schedule number is always prefixed with \&quot;RS\&quot;, for example, \&quot;RS-00000001\&quot;.</param> 
        /// <param name="request"></param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType PUTCustomFieldsonRevenueItemsByRevenueSchedule (string rsNumber, PUTScheduleRIDetailType request)
        {
            
            // verify the required parameter 'rsNumber' is set
            if (rsNumber == null) throw new ApiException(400, "Missing required parameter 'rsNumber' when calling PUTCustomFieldsonRevenueItemsByRevenueSchedule");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling PUTCustomFieldsonRevenueItemsByRevenueSchedule");
            
    
            var path = "/revenue-items/revenue-schedules/{rs-number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "rs-number" + "}", ApiClient.ParameterToString(rsNumber));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTCustomFieldsonRevenueItemsByRevenueSchedule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTCustomFieldsonRevenueItemsByRevenueSchedule: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
    }
}
