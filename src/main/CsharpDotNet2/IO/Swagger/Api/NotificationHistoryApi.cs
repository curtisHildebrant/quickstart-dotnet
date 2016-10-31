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
    public interface INotificationHistoryApi
    {
        /// <summary>
        /// Get callout notification histories This REST API reference describes how to get a notification history for callouts.  See [Notifications and Callouts](https://knowledgecenter.zuora.com/BB_Introducing_Z_Business/Notifications) and [Create and Edit Notifications](https://knowledgecenter.zuora.com/BB_Introducing_Z_Business/Notifications/C_Create_Notifications) for more information. 
        /// </summary>
        /// <param name="endTime">The final date and time of records to be returned. Defaults to now. Use format yyyy-MM-ddTHH:mm:ss.</param>
        /// <param name="startTime">The initial date and time of records to be returned. Defaults to (end time - 1 day). Use format yyyy-MM-ddTHH:mm:ss.</param>
        /// <param name="objectId">The ID of an object that triggered a callout notification.</param>
        /// <param name="failedOnly">If &#x60;true&#x60;, only return failed records. If &#x60;false&#x60;, return all records in the given date range. The default value is &#x60;true&#x60;.</param>
        /// <param name="eventCategory">Category of records to be returned by [event category](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Notification_History/Z_Event_Categories).</param>
        /// <param name="includeResponseContent"></param>
        /// <returns>GETCalloutHistoryVOsType</returns>
        GETCalloutHistoryVOsType GETCalloutHistoryVOs (DateTime? endTime, DateTime? startTime, string objectId, bool? failedOnly, string eventCategory, bool? includeResponseContent);
        /// <summary>
        /// Get email notification histories This REST API reference describes how to get a notification history for notification emails.  See [Notifications and Callouts](https://knowledgecenter.zuora.com/BB_Introducing_Z_Business/Notifications) and [Create and Edit Notifications](https://knowledgecenter.zuora.com/BB_Introducing_Z_Business/Notifications/C_Create_Notifications) for more information.  ## Notes Request parameters and their values may be appended with a \&quot;?\&quot; following the HTTPS GET request.  Additional request parameter are separated by \&quot;&amp;\&quot;.   For example:  &#x60;GET https://api.zuora.com/rest/v1/notification-history/email?startTime&#x3D;2015-01-12T00:00:00&amp;endTime&#x3D;2015-01-15T00:00:00&amp;failedOnly&#x3D;false&amp;eventCategory&#x3D;1000&amp;pageSize&#x3D;1&#x60; 
        /// </summary>
        /// <param name="endTime">The end date and time of records to be returned. Defaults to now. Use format yyyy-MM-ddTHH:mm:ss. The maximum date range (endTime - startTime) is three days.</param>
        /// <param name="startTime">The initial date and time of records to be returned. Defaults to (end time - 1 day). Use format yyyy-MM-ddTHH:mm:ss. The maximum date range (endTime - startTime) is three days.</param>
        /// <param name="objectId">The Id of an object that triggered an email notification.</param>
        /// <param name="failedOnly">If &#x60;true&#x60;, only returns failed records. When &#x60;false&#x60;, returns all records in the given date range. Defaults to &#x60;true&#x60; when not specified.</param>
        /// <param name="eventCategory">Category of records to be returned by [event category](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Notification_History/Z_Event_Categories).</param>
        /// <returns>GETEmailHistoryVOsType</returns>
        GETEmailHistoryVOsType GETEmailHistoryVOs (DateTime? endTime, DateTime? startTime, string objectId, bool? failedOnly, string eventCategory);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class NotificationHistoryApi : INotificationHistoryApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationHistoryApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public NotificationHistoryApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationHistoryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificationHistoryApi(String basePath)
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
        /// Get callout notification histories This REST API reference describes how to get a notification history for callouts.  See [Notifications and Callouts](https://knowledgecenter.zuora.com/BB_Introducing_Z_Business/Notifications) and [Create and Edit Notifications](https://knowledgecenter.zuora.com/BB_Introducing_Z_Business/Notifications/C_Create_Notifications) for more information. 
        /// </summary>
        /// <param name="endTime">The final date and time of records to be returned. Defaults to now. Use format yyyy-MM-ddTHH:mm:ss.</param> 
        /// <param name="startTime">The initial date and time of records to be returned. Defaults to (end time - 1 day). Use format yyyy-MM-ddTHH:mm:ss.</param> 
        /// <param name="objectId">The ID of an object that triggered a callout notification.</param> 
        /// <param name="failedOnly">If &#x60;true&#x60;, only return failed records. If &#x60;false&#x60;, return all records in the given date range. The default value is &#x60;true&#x60;.</param> 
        /// <param name="eventCategory">Category of records to be returned by [event category](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Notification_History/Z_Event_Categories).</param> 
        /// <param name="includeResponseContent"></param> 
        /// <returns>GETCalloutHistoryVOsType</returns>            
        public GETCalloutHistoryVOsType GETCalloutHistoryVOs (DateTime? endTime, DateTime? startTime, string objectId, bool? failedOnly, string eventCategory, bool? includeResponseContent)
        {
            
    
            var path = "/notification-history/callout";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (endTime != null) queryParams.Add("endTime", ApiClient.ParameterToString(endTime)); // query parameter
 if (startTime != null) queryParams.Add("startTime", ApiClient.ParameterToString(startTime)); // query parameter
 if (objectId != null) queryParams.Add("objectId", ApiClient.ParameterToString(objectId)); // query parameter
 if (failedOnly != null) queryParams.Add("failedOnly", ApiClient.ParameterToString(failedOnly)); // query parameter
 if (eventCategory != null) queryParams.Add("eventCategory", ApiClient.ParameterToString(eventCategory)); // query parameter
 if (includeResponseContent != null) queryParams.Add("includeResponseContent", ApiClient.ParameterToString(includeResponseContent)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETCalloutHistoryVOs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETCalloutHistoryVOs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETCalloutHistoryVOsType) ApiClient.Deserialize(response.Content, typeof(GETCalloutHistoryVOsType), response.Headers);
        }
    
        /// <summary>
        /// Get email notification histories This REST API reference describes how to get a notification history for notification emails.  See [Notifications and Callouts](https://knowledgecenter.zuora.com/BB_Introducing_Z_Business/Notifications) and [Create and Edit Notifications](https://knowledgecenter.zuora.com/BB_Introducing_Z_Business/Notifications/C_Create_Notifications) for more information.  ## Notes Request parameters and their values may be appended with a \&quot;?\&quot; following the HTTPS GET request.  Additional request parameter are separated by \&quot;&amp;\&quot;.   For example:  &#x60;GET https://api.zuora.com/rest/v1/notification-history/email?startTime&#x3D;2015-01-12T00:00:00&amp;endTime&#x3D;2015-01-15T00:00:00&amp;failedOnly&#x3D;false&amp;eventCategory&#x3D;1000&amp;pageSize&#x3D;1&#x60; 
        /// </summary>
        /// <param name="endTime">The end date and time of records to be returned. Defaults to now. Use format yyyy-MM-ddTHH:mm:ss. The maximum date range (endTime - startTime) is three days.</param> 
        /// <param name="startTime">The initial date and time of records to be returned. Defaults to (end time - 1 day). Use format yyyy-MM-ddTHH:mm:ss. The maximum date range (endTime - startTime) is three days.</param> 
        /// <param name="objectId">The Id of an object that triggered an email notification.</param> 
        /// <param name="failedOnly">If &#x60;true&#x60;, only returns failed records. When &#x60;false&#x60;, returns all records in the given date range. Defaults to &#x60;true&#x60; when not specified.</param> 
        /// <param name="eventCategory">Category of records to be returned by [event category](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Notification_History/Z_Event_Categories).</param> 
        /// <returns>GETEmailHistoryVOsType</returns>            
        public GETEmailHistoryVOsType GETEmailHistoryVOs (DateTime? endTime, DateTime? startTime, string objectId, bool? failedOnly, string eventCategory)
        {
            
    
            var path = "/notification-history/email";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (endTime != null) queryParams.Add("endTime", ApiClient.ParameterToString(endTime)); // query parameter
 if (startTime != null) queryParams.Add("startTime", ApiClient.ParameterToString(startTime)); // query parameter
 if (objectId != null) queryParams.Add("objectId", ApiClient.ParameterToString(objectId)); // query parameter
 if (failedOnly != null) queryParams.Add("failedOnly", ApiClient.ParameterToString(failedOnly)); // query parameter
 if (eventCategory != null) queryParams.Add("eventCategory", ApiClient.ParameterToString(eventCategory)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETEmailHistoryVOs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETEmailHistoryVOs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETEmailHistoryVOsType) ApiClient.Deserialize(response.Content, typeof(GETEmailHistoryVOsType), response.Headers);
        }
    
    }
}
