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
    public interface IRevenueSchedulesApi
    {
        /// <summary>
        /// Delete revenue schedule This REST API reference describes how to delete a revenue schedule by specifying its revenue schedule number ## Prerequisites You must have the Delete Custom Revenue Schedule [Z-Finance permission](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/Administrator_Settings/User_Roles/Z-Finance_Roles#Z-Finance_Permissions). 
        /// </summary>
        /// <param name="rsNumber"> Revenue schedule number of the revenue schedule you want to delete, for example, RS-00000256. To be deleted, the revenue schedule: * Must be using a custom unlimited recognition rule. * Cannot have any revenue in a closed accounting period. * Cannot be included in a summary journal entry. * Cannot have a revenue schedule date in a closed accounting period. </param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType DELETERS (string rsNumber);
        /// <summary>
        /// Get revenue schedule details This REST API reference describes how to get the details of a revenue schedule by specifying the revenue schedule number. Request and response field descriptions and sample code are provided.
        /// </summary>
        /// <param name="rsNumber">Revenue schedule number. The revenue schedule number is always prefixed with \&quot;RS\&quot;, for example, \&quot;RS-00000001\&quot;. </param>
        /// <returns>GETRSDetailType</returns>
        GETRSDetailType GETRSDetail (string rsNumber);
        /// <summary>
        /// Get revenue schedule by subscription charge This REST API reference describes how to get the revenue schedule details by specifying subscription charge ID. Request and response field descriptions and sample code are provided
        /// </summary>
        /// <param name="chargeKey">ID of the subscription rate plan charge; for example, 402892793e173340013e173b81000012.</param>
        /// <returns>GETRSDetailsByChargeType</returns>
        GETRSDetailsByChargeType GETRSDetailsByCharge (string chargeKey);
        /// <summary>
        /// Get a revenue schedule by invoice item ID This REST API reference describes how to get the details of a revenue schedule by specifying the invoice item ID.
        /// </summary>
        /// <param name="invoiceItemId">A valid Invoice Item ID.</param>
        /// <returns>GETRSDetailType</returns>
        GETRSDetailType GETRSbyInvoiceItem (string invoiceItemId);
        /// <summary>
        /// Get a revenue schedule by invoice item adjustment This REST API reference describes how to get the details of a revenue schedule by specifying a valid invoice item adjustment identifier. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="invoiceItemAdjId">ID or number of the Invoice Item Adjustment, for example, e20b07fd416dcfcf0141c81164fd0a72.</param>
        /// <returns>GETRSDetailType</returns>
        GETRSDetailType GETRSbyInvoiceItemAdjustment (string invoiceItemAdjId);
        /// <summary>
        /// Create a revenue schedule for an Invoice Item Adjustment (distribute by date range) This REST API reference describes how to create a revenue schedule for an Invoice Item Adjustment and distribute the revenue by specifying the recognition start and end dates.
        /// </summary>
        /// <param name="invoiceItemAdjKey">ID or number of the Invoice Item Adjustment, for example, e20b07fd416dcfcf0141c81164fd0a72. If the specified Invoice Item Adjustment is already associated with a revenue schedule, the call will fail. </param>
        /// <param name="request"></param>
        /// <returns>POSTRevenueScheduleByTransactionResponseType</returns>
        POSTRevenueScheduleByTransactionResponseType POSTRSforInvoiceItemAdjustmentDistributeByDateRange (string invoiceItemAdjKey, POSTRevenueScheduleByDateRangeType request);
        /// <summary>
        /// Create a revenue schedule for an Invoice Item Adjustment (manual distribution) This REST API reference describes how to create a revenue schedule for an Invoice Item Adjustment and manually distribute the revenue.
        /// </summary>
        /// <param name="invoiceItemAdjKey">ID or number of the Invoice Item Adjustment, for example, e20b07fd416dcfcf0141c81164fd0a72. If the specified Invoice Item Adjustment is already associated with a revenue schedule, the call will fail. </param>
        /// <param name="request"></param>
        /// <returns>POSTRevenueScheduleByTransactionResponseType</returns>
        POSTRevenueScheduleByTransactionResponseType POSTRSforInvoiceItemAdjustmentManualDistribution (string invoiceItemAdjKey, POSTRevenueScheduleByTransactionType request);
        /// <summary>
        /// Create a revenue schedule for an Invoice Item (distribute by date range) This REST API reference describes how to create a revenue schedule for an Invoice Item and distribute the revenue by specifying the recognition start and end dates.
        /// </summary>
        /// <param name="invoiceItemId">ID of the Invoice Item, for example, e20b07fd416dcfcf0141c81164fd0a75. If the specified Invoice Item is already associated with a revenue schedule, the call will fail. </param>
        /// <param name="request"></param>
        /// <returns>POSTRevenueScheduleByTransactionResponseType</returns>
        POSTRevenueScheduleByTransactionResponseType POSTRSforInvoiceItemDistributeByDateRange (string invoiceItemId, POSTRevenueScheduleByDateRangeType request);
        /// <summary>
        /// Create a revenue schedule for an Invoice Item (manual distribution) This REST API reference describes how to create a revenue schedule for an Invoice Item and manually distribute the revenue.
        /// </summary>
        /// <param name="invoiceItemId">ID of the Invoice Item, for example, e20b07fd416dcfcf0141c81164fd0a75. If the specified Invoice Item is already associated with a revenue schedule, the call will fail. </param>
        /// <param name="request"></param>
        /// <returns>POSTRevenueScheduleByTransactionResponseType</returns>
        POSTRevenueScheduleByTransactionResponseType POSTRSforInvoiceItemManualDistribution (string invoiceItemId, POSTRevenueScheduleByTransactionType request);
        /// <summary>
        /// Create a revenue schedule on a subscription charge This REST API reference describes how to create a revenue schedule by specifying the subscription charge. This method is for custom unlimited revenue recognition only.
        /// </summary>
        /// <param name="chargeKey">ID of the subscription rate plan charge; for example, 402892793e173340013e173b81000012.</param>
        /// <param name="request"></param>
        /// <returns>POSTRevenueScheduleByChargeResponseType</returns>
        POSTRevenueScheduleByChargeResponseType POSTRevenueScheduleByChargeResponse (string chargeKey, POSTRevenueScheduleByChargeType request);
        /// <summary>
        /// Update revenue schedule basic information This REST API reference describes how to get basic information of a revenue schedule by specifying the revenue schedule number. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="rsNumber">Revenue schedule number. The revenue schedule number is always prefixed with \&quot;RS\&quot;, for example, \&quot;RS-00000001\&quot;. </param>
        /// <param name="request"></param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType PUTRSBasicInfo (string rsNumber, PUTRSBasicInfoType request);
        /// <summary>
        /// Distribute revenue across accounting periods This REST API reference describes how to distribute revenue by specifying the revenue schedule number. Request and response field descriptions and sample code are provided.
        /// </summary>
        /// <param name="rsNumber">Revenue schedule number. The revenue schedule number is always prefixed with \&quot;RS\&quot;, for example, \&quot;RS-00000001\&quot;. </param>
        /// <param name="request"></param>
        /// <returns>PUTRevenueScheduleResponseType</returns>
        PUTRevenueScheduleResponseType PUTRevenueAcrossAP (string rsNumber, PUTAllocateManuallyType request);
        /// <summary>
        /// Distribute revenue by recognition start and end dates This REST API reference describes how to distribute revenue by specifying the recognition start and end dates. Request and response field descriptions and sample code are provided.
        /// </summary>
        /// <param name="rsNumber">Revenue schedule number. Specify the revenue schedule whose revenue you want to distribute.    The revenue schedule number is always prefixed with \&quot;RS\&quot;, for example, \&quot;RS-00000001\&quot;. </param>
        /// <param name="request"></param>
        /// <returns>PUTRevenueScheduleResponseType</returns>
        PUTRevenueScheduleResponseType PUTRevenueByRecognitionStartandEndDates (string rsNumber, PUTRSTermType request);
        /// <summary>
        /// Distribute revenue on a specific date This REST API reference describes how to distribute revenue on a specific recognition date. Request and response field descriptions and sample code are provided.
        /// </summary>
        /// <param name="rsNumber">Revenue schedule number. The revenue schedule number is always prefixed with \&quot;RS\&quot;, for example, \&quot;RS-00000001\&quot;. </param>
        /// <param name="request"></param>
        /// <returns>PUTRevenueScheduleResponseType</returns>
        PUTRevenueScheduleResponseType PUTRevenueSpecificDate (string rsNumber, PUTSpecificDateAllocationType request);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RevenueSchedulesApi : IRevenueSchedulesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RevenueSchedulesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RevenueSchedulesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RevenueSchedulesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RevenueSchedulesApi(String basePath)
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
        /// Delete revenue schedule This REST API reference describes how to delete a revenue schedule by specifying its revenue schedule number ## Prerequisites You must have the Delete Custom Revenue Schedule [Z-Finance permission](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/Administrator_Settings/User_Roles/Z-Finance_Roles#Z-Finance_Permissions). 
        /// </summary>
        /// <param name="rsNumber"> Revenue schedule number of the revenue schedule you want to delete, for example, RS-00000256. To be deleted, the revenue schedule: * Must be using a custom unlimited recognition rule. * Cannot have any revenue in a closed accounting period. * Cannot be included in a summary journal entry. * Cannot have a revenue schedule date in a closed accounting period. </param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType DELETERS (string rsNumber)
        {
            
            // verify the required parameter 'rsNumber' is set
            if (rsNumber == null) throw new ApiException(400, "Missing required parameter 'rsNumber' when calling DELETERS");
            
    
            var path = "/revenue-schedules/{rs-number}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETERS: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETERS: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// Get revenue schedule details This REST API reference describes how to get the details of a revenue schedule by specifying the revenue schedule number. Request and response field descriptions and sample code are provided.
        /// </summary>
        /// <param name="rsNumber">Revenue schedule number. The revenue schedule number is always prefixed with \&quot;RS\&quot;, for example, \&quot;RS-00000001\&quot;. </param> 
        /// <returns>GETRSDetailType</returns>            
        public GETRSDetailType GETRSDetail (string rsNumber)
        {
            
            // verify the required parameter 'rsNumber' is set
            if (rsNumber == null) throw new ApiException(400, "Missing required parameter 'rsNumber' when calling GETRSDetail");
            
    
            var path = "/revenue-schedules/{rs-number}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETRSDetail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETRSDetail: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETRSDetailType) ApiClient.Deserialize(response.Content, typeof(GETRSDetailType), response.Headers);
        }
    
        /// <summary>
        /// Get revenue schedule by subscription charge This REST API reference describes how to get the revenue schedule details by specifying subscription charge ID. Request and response field descriptions and sample code are provided
        /// </summary>
        /// <param name="chargeKey">ID of the subscription rate plan charge; for example, 402892793e173340013e173b81000012.</param> 
        /// <returns>GETRSDetailsByChargeType</returns>            
        public GETRSDetailsByChargeType GETRSDetailsByCharge (string chargeKey)
        {
            
            // verify the required parameter 'chargeKey' is set
            if (chargeKey == null) throw new ApiException(400, "Missing required parameter 'chargeKey' when calling GETRSDetailsByCharge");
            
    
            var path = "/revenue-schedules/subscription-charges/{charge-key}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETRSDetailsByCharge: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETRSDetailsByCharge: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETRSDetailsByChargeType) ApiClient.Deserialize(response.Content, typeof(GETRSDetailsByChargeType), response.Headers);
        }
    
        /// <summary>
        /// Get a revenue schedule by invoice item ID This REST API reference describes how to get the details of a revenue schedule by specifying the invoice item ID.
        /// </summary>
        /// <param name="invoiceItemId">A valid Invoice Item ID.</param> 
        /// <returns>GETRSDetailType</returns>            
        public GETRSDetailType GETRSbyInvoiceItem (string invoiceItemId)
        {
            
            // verify the required parameter 'invoiceItemId' is set
            if (invoiceItemId == null) throw new ApiException(400, "Missing required parameter 'invoiceItemId' when calling GETRSbyInvoiceItem");
            
    
            var path = "/revenue-schedules/invoice-items/{invoice-item-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "invoice-item-id" + "}", ApiClient.ParameterToString(invoiceItemId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETRSbyInvoiceItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETRSbyInvoiceItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETRSDetailType) ApiClient.Deserialize(response.Content, typeof(GETRSDetailType), response.Headers);
        }
    
        /// <summary>
        /// Get a revenue schedule by invoice item adjustment This REST API reference describes how to get the details of a revenue schedule by specifying a valid invoice item adjustment identifier. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="invoiceItemAdjId">ID or number of the Invoice Item Adjustment, for example, e20b07fd416dcfcf0141c81164fd0a72.</param> 
        /// <returns>GETRSDetailType</returns>            
        public GETRSDetailType GETRSbyInvoiceItemAdjustment (string invoiceItemAdjId)
        {
            
            // verify the required parameter 'invoiceItemAdjId' is set
            if (invoiceItemAdjId == null) throw new ApiException(400, "Missing required parameter 'invoiceItemAdjId' when calling GETRSbyInvoiceItemAdjustment");
            
    
            var path = "/revenue-schedules/invoice-item-adjustments/{invoice-item-adj-id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "invoice-item-adj-id" + "}", ApiClient.ParameterToString(invoiceItemAdjId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETRSbyInvoiceItemAdjustment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETRSbyInvoiceItemAdjustment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETRSDetailType) ApiClient.Deserialize(response.Content, typeof(GETRSDetailType), response.Headers);
        }
    
        /// <summary>
        /// Create a revenue schedule for an Invoice Item Adjustment (distribute by date range) This REST API reference describes how to create a revenue schedule for an Invoice Item Adjustment and distribute the revenue by specifying the recognition start and end dates.
        /// </summary>
        /// <param name="invoiceItemAdjKey">ID or number of the Invoice Item Adjustment, for example, e20b07fd416dcfcf0141c81164fd0a72. If the specified Invoice Item Adjustment is already associated with a revenue schedule, the call will fail. </param> 
        /// <param name="request"></param> 
        /// <returns>POSTRevenueScheduleByTransactionResponseType</returns>            
        public POSTRevenueScheduleByTransactionResponseType POSTRSforInvoiceItemAdjustmentDistributeByDateRange (string invoiceItemAdjKey, POSTRevenueScheduleByDateRangeType request)
        {
            
            // verify the required parameter 'invoiceItemAdjKey' is set
            if (invoiceItemAdjKey == null) throw new ApiException(400, "Missing required parameter 'invoiceItemAdjKey' when calling POSTRSforInvoiceItemAdjustmentDistributeByDateRange");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTRSforInvoiceItemAdjustmentDistributeByDateRange");
            
    
            var path = "/revenue-schedules/invoice-item-adjustments/{invoice-item-adj-key}/distribute-revenue-with-date-range";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "invoice-item-adj-key" + "}", ApiClient.ParameterToString(invoiceItemAdjKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTRSforInvoiceItemAdjustmentDistributeByDateRange: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTRSforInvoiceItemAdjustmentDistributeByDateRange: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTRevenueScheduleByTransactionResponseType) ApiClient.Deserialize(response.Content, typeof(POSTRevenueScheduleByTransactionResponseType), response.Headers);
        }
    
        /// <summary>
        /// Create a revenue schedule for an Invoice Item Adjustment (manual distribution) This REST API reference describes how to create a revenue schedule for an Invoice Item Adjustment and manually distribute the revenue.
        /// </summary>
        /// <param name="invoiceItemAdjKey">ID or number of the Invoice Item Adjustment, for example, e20b07fd416dcfcf0141c81164fd0a72. If the specified Invoice Item Adjustment is already associated with a revenue schedule, the call will fail. </param> 
        /// <param name="request"></param> 
        /// <returns>POSTRevenueScheduleByTransactionResponseType</returns>            
        public POSTRevenueScheduleByTransactionResponseType POSTRSforInvoiceItemAdjustmentManualDistribution (string invoiceItemAdjKey, POSTRevenueScheduleByTransactionType request)
        {
            
            // verify the required parameter 'invoiceItemAdjKey' is set
            if (invoiceItemAdjKey == null) throw new ApiException(400, "Missing required parameter 'invoiceItemAdjKey' when calling POSTRSforInvoiceItemAdjustmentManualDistribution");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTRSforInvoiceItemAdjustmentManualDistribution");
            
    
            var path = "/revenue-schedules/invoice-item-adjustments/{invoice-item-adj-key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "invoice-item-adj-key" + "}", ApiClient.ParameterToString(invoiceItemAdjKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTRSforInvoiceItemAdjustmentManualDistribution: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTRSforInvoiceItemAdjustmentManualDistribution: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTRevenueScheduleByTransactionResponseType) ApiClient.Deserialize(response.Content, typeof(POSTRevenueScheduleByTransactionResponseType), response.Headers);
        }
    
        /// <summary>
        /// Create a revenue schedule for an Invoice Item (distribute by date range) This REST API reference describes how to create a revenue schedule for an Invoice Item and distribute the revenue by specifying the recognition start and end dates.
        /// </summary>
        /// <param name="invoiceItemId">ID of the Invoice Item, for example, e20b07fd416dcfcf0141c81164fd0a75. If the specified Invoice Item is already associated with a revenue schedule, the call will fail. </param> 
        /// <param name="request"></param> 
        /// <returns>POSTRevenueScheduleByTransactionResponseType</returns>            
        public POSTRevenueScheduleByTransactionResponseType POSTRSforInvoiceItemDistributeByDateRange (string invoiceItemId, POSTRevenueScheduleByDateRangeType request)
        {
            
            // verify the required parameter 'invoiceItemId' is set
            if (invoiceItemId == null) throw new ApiException(400, "Missing required parameter 'invoiceItemId' when calling POSTRSforInvoiceItemDistributeByDateRange");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTRSforInvoiceItemDistributeByDateRange");
            
    
            var path = "/revenue-schedules/invoice-items/{invoice-item-id}/distribute-revenue-with-date-range";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "invoice-item-id" + "}", ApiClient.ParameterToString(invoiceItemId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTRSforInvoiceItemDistributeByDateRange: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTRSforInvoiceItemDistributeByDateRange: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTRevenueScheduleByTransactionResponseType) ApiClient.Deserialize(response.Content, typeof(POSTRevenueScheduleByTransactionResponseType), response.Headers);
        }
    
        /// <summary>
        /// Create a revenue schedule for an Invoice Item (manual distribution) This REST API reference describes how to create a revenue schedule for an Invoice Item and manually distribute the revenue.
        /// </summary>
        /// <param name="invoiceItemId">ID of the Invoice Item, for example, e20b07fd416dcfcf0141c81164fd0a75. If the specified Invoice Item is already associated with a revenue schedule, the call will fail. </param> 
        /// <param name="request"></param> 
        /// <returns>POSTRevenueScheduleByTransactionResponseType</returns>            
        public POSTRevenueScheduleByTransactionResponseType POSTRSforInvoiceItemManualDistribution (string invoiceItemId, POSTRevenueScheduleByTransactionType request)
        {
            
            // verify the required parameter 'invoiceItemId' is set
            if (invoiceItemId == null) throw new ApiException(400, "Missing required parameter 'invoiceItemId' when calling POSTRSforInvoiceItemManualDistribution");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTRSforInvoiceItemManualDistribution");
            
    
            var path = "/revenue-schedules/invoice-items/{invoice-item-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "invoice-item-id" + "}", ApiClient.ParameterToString(invoiceItemId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTRSforInvoiceItemManualDistribution: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTRSforInvoiceItemManualDistribution: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTRevenueScheduleByTransactionResponseType) ApiClient.Deserialize(response.Content, typeof(POSTRevenueScheduleByTransactionResponseType), response.Headers);
        }
    
        /// <summary>
        /// Create a revenue schedule on a subscription charge This REST API reference describes how to create a revenue schedule by specifying the subscription charge. This method is for custom unlimited revenue recognition only.
        /// </summary>
        /// <param name="chargeKey">ID of the subscription rate plan charge; for example, 402892793e173340013e173b81000012.</param> 
        /// <param name="request"></param> 
        /// <returns>POSTRevenueScheduleByChargeResponseType</returns>            
        public POSTRevenueScheduleByChargeResponseType POSTRevenueScheduleByChargeResponse (string chargeKey, POSTRevenueScheduleByChargeType request)
        {
            
            // verify the required parameter 'chargeKey' is set
            if (chargeKey == null) throw new ApiException(400, "Missing required parameter 'chargeKey' when calling POSTRevenueScheduleByChargeResponse");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTRevenueScheduleByChargeResponse");
            
    
            var path = "/revenue-schedules/subscription-charges/{charge-key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "charge-key" + "}", ApiClient.ParameterToString(chargeKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTRevenueScheduleByChargeResponse: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTRevenueScheduleByChargeResponse: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTRevenueScheduleByChargeResponseType) ApiClient.Deserialize(response.Content, typeof(POSTRevenueScheduleByChargeResponseType), response.Headers);
        }
    
        /// <summary>
        /// Update revenue schedule basic information This REST API reference describes how to get basic information of a revenue schedule by specifying the revenue schedule number. Request and response field descriptions and sample code are provided. 
        /// </summary>
        /// <param name="rsNumber">Revenue schedule number. The revenue schedule number is always prefixed with \&quot;RS\&quot;, for example, \&quot;RS-00000001\&quot;. </param> 
        /// <param name="request"></param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType PUTRSBasicInfo (string rsNumber, PUTRSBasicInfoType request)
        {
            
            // verify the required parameter 'rsNumber' is set
            if (rsNumber == null) throw new ApiException(400, "Missing required parameter 'rsNumber' when calling PUTRSBasicInfo");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling PUTRSBasicInfo");
            
    
            var path = "/revenue-schedules/{rs-number}/basic-information";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTRSBasicInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTRSBasicInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// Distribute revenue across accounting periods This REST API reference describes how to distribute revenue by specifying the revenue schedule number. Request and response field descriptions and sample code are provided.
        /// </summary>
        /// <param name="rsNumber">Revenue schedule number. The revenue schedule number is always prefixed with \&quot;RS\&quot;, for example, \&quot;RS-00000001\&quot;. </param> 
        /// <param name="request"></param> 
        /// <returns>PUTRevenueScheduleResponseType</returns>            
        public PUTRevenueScheduleResponseType PUTRevenueAcrossAP (string rsNumber, PUTAllocateManuallyType request)
        {
            
            // verify the required parameter 'rsNumber' is set
            if (rsNumber == null) throw new ApiException(400, "Missing required parameter 'rsNumber' when calling PUTRevenueAcrossAP");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling PUTRevenueAcrossAP");
            
    
            var path = "/revenue-schedules/{rs-number}/distribute-revenue-across-accounting-periods";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTRevenueAcrossAP: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTRevenueAcrossAP: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PUTRevenueScheduleResponseType) ApiClient.Deserialize(response.Content, typeof(PUTRevenueScheduleResponseType), response.Headers);
        }
    
        /// <summary>
        /// Distribute revenue by recognition start and end dates This REST API reference describes how to distribute revenue by specifying the recognition start and end dates. Request and response field descriptions and sample code are provided.
        /// </summary>
        /// <param name="rsNumber">Revenue schedule number. Specify the revenue schedule whose revenue you want to distribute.    The revenue schedule number is always prefixed with \&quot;RS\&quot;, for example, \&quot;RS-00000001\&quot;. </param> 
        /// <param name="request"></param> 
        /// <returns>PUTRevenueScheduleResponseType</returns>            
        public PUTRevenueScheduleResponseType PUTRevenueByRecognitionStartandEndDates (string rsNumber, PUTRSTermType request)
        {
            
            // verify the required parameter 'rsNumber' is set
            if (rsNumber == null) throw new ApiException(400, "Missing required parameter 'rsNumber' when calling PUTRevenueByRecognitionStartandEndDates");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling PUTRevenueByRecognitionStartandEndDates");
            
    
            var path = "/revenue-schedules/{rs-number}/distribute-revenue-with-date-range";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTRevenueByRecognitionStartandEndDates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTRevenueByRecognitionStartandEndDates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PUTRevenueScheduleResponseType) ApiClient.Deserialize(response.Content, typeof(PUTRevenueScheduleResponseType), response.Headers);
        }
    
        /// <summary>
        /// Distribute revenue on a specific date This REST API reference describes how to distribute revenue on a specific recognition date. Request and response field descriptions and sample code are provided.
        /// </summary>
        /// <param name="rsNumber">Revenue schedule number. The revenue schedule number is always prefixed with \&quot;RS\&quot;, for example, \&quot;RS-00000001\&quot;. </param> 
        /// <param name="request"></param> 
        /// <returns>PUTRevenueScheduleResponseType</returns>            
        public PUTRevenueScheduleResponseType PUTRevenueSpecificDate (string rsNumber, PUTSpecificDateAllocationType request)
        {
            
            // verify the required parameter 'rsNumber' is set
            if (rsNumber == null) throw new ApiException(400, "Missing required parameter 'rsNumber' when calling PUTRevenueSpecificDate");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling PUTRevenueSpecificDate");
            
    
            var path = "/revenue-schedules/{rs-number}/distribute-revenue-on-specific-date";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTRevenueSpecificDate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTRevenueSpecificDate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PUTRevenueScheduleResponseType) ApiClient.Deserialize(response.Content, typeof(PUTRevenueScheduleResponseType), response.Headers);
        }
    
    }
}
