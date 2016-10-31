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
    public interface IChargeRevenueSummariesApi
    {
        /// <summary>
        /// Get charge summary details by CRS number This REST API reference describes how to retrieve the details of a charge revenue summary by specifying the charge revenue summary number. The response includes all revenue items associated with the charge revenue summary. 
        /// </summary>
        /// <param name="crsNumber">The charge revenue summary number. </param>
        /// <returns>GETChargeRSDetailType</returns>
        GETChargeRSDetailType GETCRSByCRSNumber (string crsNumber);
        /// <summary>
        /// Get charge summary details by charge ID This REST API reference describes how to retrieve the details of a charge revenue summary by specifying the subscription charge ID. This response retrieves all revenue items associated with a charge revenue summary. 
        /// </summary>
        /// <param name="chargeKey">ID of the subscription rate plan charge; for example, 402892793e173340013e173b81000012. </param>
        /// <returns>GETChargeRSDetailType</returns>
        GETChargeRSDetailType GETCRSByChargeID (string chargeKey);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ChargeRevenueSummariesApi : IChargeRevenueSummariesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeRevenueSummariesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ChargeRevenueSummariesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeRevenueSummariesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ChargeRevenueSummariesApi(String basePath)
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
        /// Get charge summary details by CRS number This REST API reference describes how to retrieve the details of a charge revenue summary by specifying the charge revenue summary number. The response includes all revenue items associated with the charge revenue summary. 
        /// </summary>
        /// <param name="crsNumber">The charge revenue summary number. </param> 
        /// <returns>GETChargeRSDetailType</returns>            
        public GETChargeRSDetailType GETCRSByCRSNumber (string crsNumber)
        {
            
            // verify the required parameter 'crsNumber' is set
            if (crsNumber == null) throw new ApiException(400, "Missing required parameter 'crsNumber' when calling GETCRSByCRSNumber");
            
    
            var path = "/charge-revenue-summaries/{crs-number}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETCRSByCRSNumber: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETCRSByCRSNumber: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETChargeRSDetailType) ApiClient.Deserialize(response.Content, typeof(GETChargeRSDetailType), response.Headers);
        }
    
        /// <summary>
        /// Get charge summary details by charge ID This REST API reference describes how to retrieve the details of a charge revenue summary by specifying the subscription charge ID. This response retrieves all revenue items associated with a charge revenue summary. 
        /// </summary>
        /// <param name="chargeKey">ID of the subscription rate plan charge; for example, 402892793e173340013e173b81000012. </param> 
        /// <returns>GETChargeRSDetailType</returns>            
        public GETChargeRSDetailType GETCRSByChargeID (string chargeKey)
        {
            
            // verify the required parameter 'chargeKey' is set
            if (chargeKey == null) throw new ApiException(400, "Missing required parameter 'chargeKey' when calling GETCRSByChargeID");
            
    
            var path = "/charge-revenue-summaries/subscription-charges/{charge-key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "charge-key" + "}", ApiClient.ParameterToString(chargeKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETCRSByChargeID: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETCRSByChargeID: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETChargeRSDetailType) ApiClient.Deserialize(response.Content, typeof(GETChargeRSDetailType), response.Headers);
        }
    
    }
}
