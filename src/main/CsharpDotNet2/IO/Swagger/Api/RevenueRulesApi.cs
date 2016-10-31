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
    public interface IRevenueRulesApi
    {
        /// <summary>
        /// Get the rule associated with a charge This REST API reference describes how to get the revenue recognition rule associated with a subscription charge by specifying the charge ID. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="chargeKey">ID of the subscription rate plan charge; for example, 402892793e173340013e173b81000012.</param>
        /// <returns>GETRevenueRecognitionRuleAssociationType</returns>
        GETRevenueRecognitionRuleAssociationType GETRevenueRecognitionRuleAssociation (string chargeKey);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RevenueRulesApi : IRevenueRulesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RevenueRulesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RevenueRulesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RevenueRulesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RevenueRulesApi(String basePath)
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
        /// Get the rule associated with a charge This REST API reference describes how to get the revenue recognition rule associated with a subscription charge by specifying the charge ID. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="chargeKey">ID of the subscription rate plan charge; for example, 402892793e173340013e173b81000012.</param> 
        /// <returns>GETRevenueRecognitionRuleAssociationType</returns>            
        public GETRevenueRecognitionRuleAssociationType GETRevenueRecognitionRuleAssociation (string chargeKey)
        {
            
            // verify the required parameter 'chargeKey' is set
            if (chargeKey == null) throw new ApiException(400, "Missing required parameter 'chargeKey' when calling GETRevenueRecognitionRuleAssociation");
            
    
            var path = "/revenue-recognition-rules/subscription-charges/{charge-key}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETRevenueRecognitionRuleAssociation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETRevenueRecognitionRuleAssociation: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETRevenueRecognitionRuleAssociationType) ApiClient.Deserialize(response.Content, typeof(GETRevenueRecognitionRuleAssociationType), response.Headers);
        }
    
    }
}
