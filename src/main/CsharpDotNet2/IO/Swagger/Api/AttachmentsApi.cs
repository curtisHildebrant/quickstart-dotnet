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
    public interface IAttachmentsApi
    {
        /// <summary>
        /// Delete attachments Use the Delete Attachment REST request to delete an attachment from a Zuora object.
        /// </summary>
        /// <param name="attachmentId">Id of the attachment to be deleted.</param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType DELETEAttachments (string attachmentId);
        /// <summary>
        /// View attachments Use the View Attachment REST request to retrieve information about an attachment document.
        /// </summary>
        /// <param name="attachmentId">Id of the attachment you want to view.</param>
        /// <returns>GETAttachmentResponseType</returns>
        GETAttachmentResponseType GETAttachments (string attachmentId);
        /// <summary>
        /// View attachments list Use the View Attachment REST request to get a list of attachments on an account, an invoice, or a subscription.
        /// </summary>
        /// <param name="objectType"> Specify one of the following: * Account  * Subscription  * Invoice </param>
        /// <param name="objectKey">Id of the attachment. This id is included in the response from the Add Attachment request.</param>
        /// <returns>GETAttachmentsResponseType</returns>
        GETAttachmentsResponseType GETAttachmentsResponse (string objectType, string objectKey);
        /// <summary>
        /// Add attachments Use the Add Attachment REST request with a multipart/form-data to attach a document file to an Account, a Subscription, or an Invoice.
        /// </summary>
        /// <param name="associatedObjectType">Specify one of the following values: Account, Subscription, or Invoice. </param>
        /// <param name="associatedObjectKey">For the Subscription type, specify the Subscription Number. An attachment is tied tied to the Subscription Number and thus viewable with every subscription version.  For Account and Invoice, specify the id. </param>
        /// <param name="request"></param>
        /// <param name="description">Description of the attachment document. </param>
        /// <returns>POSTAttachmentResponseType</returns>
        POSTAttachmentResponseType POSTAttachments (string associatedObjectType, string associatedObjectKey, POSTAttachmentType request, string description);
        /// <summary>
        /// Edit attachments Use the Edit Attachment REST request to make changes to the descriptive fields of an attachment, such as the description and the file name. You cannot change the actual content of the attached file in Zuora. If you need to change the actual content, you need to delete the attachment and add the updated file as a new attachment.
        /// </summary>
        /// <param name="attachmentId">Id of the attachment to be updated.</param>
        /// <param name="request"></param>
        /// <returns>CommonResponseType</returns>
        CommonResponseType PUTAttachments (string attachmentId, PUTAttachmentType request);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AttachmentsApi : IAttachmentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AttachmentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AttachmentsApi(String basePath)
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
        /// Delete attachments Use the Delete Attachment REST request to delete an attachment from a Zuora object.
        /// </summary>
        /// <param name="attachmentId">Id of the attachment to be deleted.</param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType DELETEAttachments (string attachmentId)
        {
            
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null) throw new ApiException(400, "Missing required parameter 'attachmentId' when calling DELETEAttachments");
            
    
            var path = "/attachments/{attachment-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "attachment-id" + "}", ApiClient.ParameterToString(attachmentId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEAttachments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEAttachments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
        /// <summary>
        /// View attachments Use the View Attachment REST request to retrieve information about an attachment document.
        /// </summary>
        /// <param name="attachmentId">Id of the attachment you want to view.</param> 
        /// <returns>GETAttachmentResponseType</returns>            
        public GETAttachmentResponseType GETAttachments (string attachmentId)
        {
            
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null) throw new ApiException(400, "Missing required parameter 'attachmentId' when calling GETAttachments");
            
    
            var path = "/attachments/{attachment-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "attachment-id" + "}", ApiClient.ParameterToString(attachmentId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETAttachments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAttachments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETAttachmentResponseType) ApiClient.Deserialize(response.Content, typeof(GETAttachmentResponseType), response.Headers);
        }
    
        /// <summary>
        /// View attachments list Use the View Attachment REST request to get a list of attachments on an account, an invoice, or a subscription.
        /// </summary>
        /// <param name="objectType"> Specify one of the following: * Account  * Subscription  * Invoice </param> 
        /// <param name="objectKey">Id of the attachment. This id is included in the response from the Add Attachment request.</param> 
        /// <returns>GETAttachmentsResponseType</returns>            
        public GETAttachmentsResponseType GETAttachmentsResponse (string objectType, string objectKey)
        {
            
            // verify the required parameter 'objectType' is set
            if (objectType == null) throw new ApiException(400, "Missing required parameter 'objectType' when calling GETAttachmentsResponse");
            
            // verify the required parameter 'objectKey' is set
            if (objectKey == null) throw new ApiException(400, "Missing required parameter 'objectKey' when calling GETAttachmentsResponse");
            
    
            var path = "/attachments/{object-type}/{object-key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "object-type" + "}", ApiClient.ParameterToString(objectType));
path = path.Replace("{" + "object-key" + "}", ApiClient.ParameterToString(objectKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETAttachmentsResponse: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAttachmentsResponse: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETAttachmentsResponseType) ApiClient.Deserialize(response.Content, typeof(GETAttachmentsResponseType), response.Headers);
        }
    
        /// <summary>
        /// Add attachments Use the Add Attachment REST request with a multipart/form-data to attach a document file to an Account, a Subscription, or an Invoice.
        /// </summary>
        /// <param name="associatedObjectType">Specify one of the following values: Account, Subscription, or Invoice. </param> 
        /// <param name="associatedObjectKey">For the Subscription type, specify the Subscription Number. An attachment is tied tied to the Subscription Number and thus viewable with every subscription version.  For Account and Invoice, specify the id. </param> 
        /// <param name="request"></param> 
        /// <param name="description">Description of the attachment document. </param> 
        /// <returns>POSTAttachmentResponseType</returns>            
        public POSTAttachmentResponseType POSTAttachments (string associatedObjectType, string associatedObjectKey, POSTAttachmentType request, string description)
        {
            
            // verify the required parameter 'associatedObjectType' is set
            if (associatedObjectType == null) throw new ApiException(400, "Missing required parameter 'associatedObjectType' when calling POSTAttachments");
            
            // verify the required parameter 'associatedObjectKey' is set
            if (associatedObjectKey == null) throw new ApiException(400, "Missing required parameter 'associatedObjectKey' when calling POSTAttachments");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTAttachments");
            
    
            var path = "/attachments";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (description != null) queryParams.Add("description", ApiClient.ParameterToString(description)); // query parameter
 if (associatedObjectType != null) queryParams.Add("associatedObjectType", ApiClient.ParameterToString(associatedObjectType)); // query parameter
 if (associatedObjectKey != null) queryParams.Add("associatedObjectKey", ApiClient.ParameterToString(associatedObjectKey)); // query parameter
                                    postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTAttachments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTAttachments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTAttachmentResponseType) ApiClient.Deserialize(response.Content, typeof(POSTAttachmentResponseType), response.Headers);
        }
    
        /// <summary>
        /// Edit attachments Use the Edit Attachment REST request to make changes to the descriptive fields of an attachment, such as the description and the file name. You cannot change the actual content of the attached file in Zuora. If you need to change the actual content, you need to delete the attachment and add the updated file as a new attachment.
        /// </summary>
        /// <param name="attachmentId">Id of the attachment to be updated.</param> 
        /// <param name="request"></param> 
        /// <returns>CommonResponseType</returns>            
        public CommonResponseType PUTAttachments (string attachmentId, PUTAttachmentType request)
        {
            
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null) throw new ApiException(400, "Missing required parameter 'attachmentId' when calling PUTAttachments");
            
    
            var path = "/attachments/{attachment-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "attachment-id" + "}", ApiClient.ParameterToString(attachmentId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTAttachments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTAttachments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponseType) ApiClient.Deserialize(response.Content, typeof(CommonResponseType), response.Headers);
        }
    
    }
}
