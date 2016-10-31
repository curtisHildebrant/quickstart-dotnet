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
    public interface IRSASignaturesApi
    {
        /// <summary>
        /// Decrypt RSA signature  The REST API used in Payment Pages 2.0 are CORS (Cross-Origin Resource Sharing) enabled and therefore requires a digital signature. You use rsa_signatures to generate the required digital signature and token for a Payment Pages 2.0 form, and then you use the decrypt REST service to decrypt the signature to validate the signature and key.  This REST service should be used only when you implement Payment Pages 2.0.  
        /// </summary>
        /// <param name="request"></param>
        /// <returns>POSTDecryptResponseType</returns>
        POSTDecryptResponseType POSTDecryptResponse (POSTDecryptionType request);
        /// <summary>
        /// Generate RSA signature  The REST API used in Payment Pages 2.0 are CORS (Cross-Origin Resource Sharing) enabled and therefore requires a digital signature. The POST rsa_signatures call generates and returns the required digital signature and token for a Payment Pages 2.0 form. You need to pass the generated signature to your client for it to access Payment Pages 2.0.     This REST service should be used only when you implement Payment Pages 2.0.  
        /// </summary>
        /// <param name="request"></param>
        /// <returns>POSTRSASignatureResponseType</returns>
        POSTRSASignatureResponseType POSTRSASignature (POSTRSASignatureType request);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RSASignaturesApi : IRSASignaturesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RSASignaturesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RSASignaturesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RSASignaturesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RSASignaturesApi(String basePath)
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
        /// Decrypt RSA signature  The REST API used in Payment Pages 2.0 are CORS (Cross-Origin Resource Sharing) enabled and therefore requires a digital signature. You use rsa_signatures to generate the required digital signature and token for a Payment Pages 2.0 form, and then you use the decrypt REST service to decrypt the signature to validate the signature and key.  This REST service should be used only when you implement Payment Pages 2.0.  
        /// </summary>
        /// <param name="request"></param> 
        /// <returns>POSTDecryptResponseType</returns>            
        public POSTDecryptResponseType POSTDecryptResponse (POSTDecryptionType request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTDecryptResponse");
            
    
            var path = "/rsa-signatures/decrypt";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTDecryptResponse: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTDecryptResponse: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTDecryptResponseType) ApiClient.Deserialize(response.Content, typeof(POSTDecryptResponseType), response.Headers);
        }
    
        /// <summary>
        /// Generate RSA signature  The REST API used in Payment Pages 2.0 are CORS (Cross-Origin Resource Sharing) enabled and therefore requires a digital signature. The POST rsa_signatures call generates and returns the required digital signature and token for a Payment Pages 2.0 form. You need to pass the generated signature to your client for it to access Payment Pages 2.0.     This REST service should be used only when you implement Payment Pages 2.0.  
        /// </summary>
        /// <param name="request"></param> 
        /// <returns>POSTRSASignatureResponseType</returns>            
        public POSTRSASignatureResponseType POSTRSASignature (POSTRSASignatureType request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTRSASignature");
            
    
            var path = "/rsa-signatures";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTRSASignature: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTRSASignature: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTRSASignatureResponseType) ApiClient.Deserialize(response.Content, typeof(POSTRSASignatureResponseType), response.Headers);
        }
    
    }
}
