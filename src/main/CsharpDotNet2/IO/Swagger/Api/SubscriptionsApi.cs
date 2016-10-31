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
    public interface ISubscriptionsApi
    {
        /// <summary>
        /// Get subscriptions by key This REST API reference describes how to retrieve detailed information about a specified subscription in the latest version. 
        /// </summary>
        /// <param name="subscriptionKey">Possible values are:   * a subscription number   * a subscription ID </param>
        /// <param name="chargeDetail"> The segmented rate plan charges. When an amendment results in a change to a charge, Zuora creates a segmented rate plan charge. Use this field to track segment charges.  Possible values are:   * __last-segment__: (Default) The last rate plan charge on the subscription. The last rate plan charge is the last one in the order of time on the subscription rather than the most recent changed charge on the subscription.  * __current-segment__: The segmented charge that is active on today’s date (effectiveStartDate &lt;&#x3D; today’s date &lt; effectiveEndDate).    * __all-segments__: All the segmented charges.   * __specific-segment&amp;as-of-date&#x3D;date__: The segmented charge that is active on a date you specified (effectiveStartDate &lt;&#x3D; specific date &lt; effectiveEndDate). The format of the date is yyyy-mm-dd. </param>
        /// <returns>GETSubscriptionTypeWithSuccess</returns>
        GETSubscriptionTypeWithSuccess GETOneSubscription (string subscriptionKey, string chargeDetail);
        /// <summary>
        /// Get subscriptions by account Retrieves all subscriptions associated with the specified account. Zuora only returns the latest version of the subscriptions.  Subscription data is returned in reverse chronological order based on &#x60;updatedDate&#x60;. 
        /// </summary>
        /// <param name="accountKey"> Possible values are: * an account number * an account ID </param>
        /// <param name="chargeDetail">The segmented rate plan charges.  When an amendment results in a change to a charge, Zuora creates a segmented rate plan charge. Use this field to track segment charges.  Possible values are:  * &#x60;last-segment&#x60;: (Default) The last rate plan charge on the subscription. The last rate plan charge is the last one in the order of time on the subscription rather than the most recent updated charge on the subscription. * &#x60;current-segment&#x60;: The segmented charge that is active on today’s date (**effectiveStartDate** &lt;&#x3D; today’s date &lt; **effectiveEndDate**). * &#x60;all-segments&#x60;: All the segmented charges. * &#x60;specific-segment&amp;as-of-date&#x3D;date&#x60;: The segmented charge that is active on a date you specified (**effectiveStartDate** &lt;&#x3D; specific date &lt; **effectiveEndDate**). The format of the date is yyyy-mm-dd. </param>
        /// <returns>GETSubscriptionWrapper</returns>
        GETSubscriptionWrapper GETSubscription (string accountKey, string chargeDetail);
        /// <summary>
        /// Create subscription This REST API reference describes how to create a new subscription for an existing customer account.  ## Notes If invoiceCollect is &#x60;true&#x60;, the call will not return success &#x3D; &#x60;true&#x60; unless the subscription, invoice, and payment are all successful.  Default values for **customerAcceptanceDate** and **serviceActivationDate** are set as follows.  |        | serviceActivationDate(SA) specified          | serviceActivationDate (SA) NOT specified  | | ------------- |:-------------:| -----:| | customerAcceptanceDate (CA) specified| SA uses value in the request call; CA uses value in the request call| CA uses value in the request call;SA uses CE as default | | customerAcceptanceDate (CA) NOT specified      | SA uses value in the request call; CA uses SA as default |   SA and CA use CE as default | 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="zuoraVersion">The minor version of the Zuora REST API. You only need to set this parameter if you use the __collect__ or __invoice__ field. See [REST API Basics](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information.</param>
        /// <returns>POSTSubscriptionResponseType</returns>
        POSTSubscriptionResponseType POSTSubscription (POSTSubscriptionType request, string zuoraVersion);
        /// <summary>
        /// Cancel subscription This REST API reference describes how to cancel an active subscription. 
        /// </summary>
        /// <param name="subscriptionKey">Subscription number or ID. Subscription status must be &#x60;Active&#x60;.</param>
        /// <param name="request"></param>
        /// <param name="zuoraVersion">The minor version of the Zuora REST API. You only need to set this parameter if you use the __collect__ or __invoice__ field. See [REST API Basics](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information.</param>
        /// <returns>POSTSubscriptionCancellationResponseType</returns>
        POSTSubscriptionCancellationResponseType POSTSubscriptionCancellation (string subscriptionKey, POSTSubscriptionCancellationType request, string zuoraVersion);
        /// <summary>
        /// Preview subscription The REST API reference describes how to create a new subscription in preview mode. This call does not require a valid customer account. It can be used to show potential new customers a preview of a subscription with complete details and charges before creating an account, or to let existing customers preview a subscription with all charges before committing.  ## Notes Default values for **customerAcceptanceDate** and **serviceActivationDate** are set as follows.  |        | serviceActivationDate (SA) specified          | serviceActivationDate (SA) NOT specified  | | ------------- |:-------------:| -----:| | customerAcceptanceDate (CA) specified      | SA uses value in the request call; CA uses value in the request call| CA uses value in the request call;SA uses CE as default | | customerAcceptanceDate (CA) NOT specified      | SA uses value in the request call; CA uses SA as default |   SA and CA use CE as default | 
        /// </summary>
        /// <param name="request"></param>
        /// <returns>POSTSubscriptionPreviewResponseType</returns>
        POSTSubscriptionPreviewResponseType POSTSubscriptionPreview (POSTSubscriptionPreviewType request);
        /// <summary>
        /// Renew subscription Renews a termed subscription using existing renewal terms. 
        /// </summary>
        /// <param name="subscriptionKey">Subscription number or ID</param>
        /// <param name="request"></param>
        /// <param name="zuoraVersion">The minor version of the Zuora REST API. You only need to set this parameter if you use the __collect__ or __invoice__ field. See [REST API Basics](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information.</param>
        /// <returns>PUTRenewSubscriptionResponseType</returns>
        PUTRenewSubscriptionResponseType PUTRenewSubscription (string subscriptionKey, PUTRenewSubscriptionType request, string zuoraVersion);
        /// <summary>
        /// Update subscription Use this call to make the following kinds of changes to a subscription:   * Add a note   * Change the renewal term or auto-renewal flag   * Change the term length or change between evergreen and termed   * Add a new product rate plan   * Remove an existing subscription rate plan   * Change the quantity or price of an existing subscription rate plan  ## Notes * The Update Subscription call creates a new subscription, which has the old subscription number but a new subscription ID.  The old subscription is canceled but remains in the system. * In one request, this call can make:   * Up to 9 combined add, update, and remove changes   * No more than 1 change to terms &amp; conditions * Updates are performed in the following sequence:   1. First change the notes on the existing subscription, if requested.   2. Then change the terms and conditions, if requested.   3. Then perform the remaining amendments based upon the effective dates specified. If multiple amendments have the same contract-effective dates, then execute adds before updates, and updates before removes. * The update operation is atomic. If any of the updates fails, the entire operation is rolled back.  ## Override a Tiered Price There are two ways you override a tiered price:  * Override a specific tier number For example: &#x60;tiers[{tier:1,price:8},{tier:2,price:6}]&#x60;  * Override the entire tier structure For example:  &#x60;tiers[{tier:1,price:8,startingUnit:1,endingUnit:100,priceFormat:\&quot;FlatFee\&quot;}, {tier:2,price:6,startingUnit:101,priceFormat:\&quot;FlatFee\&quot;}]&#x60;  If you just override a specific tier, do not include the &#x60;startingUnit&#x60; field in the request. 
        /// </summary>
        /// <param name="subscriptionKey">Subscription number or ID.</param>
        /// <param name="request"></param>
        /// <param name="zuoraVersion">The minor version of the Zuora REST API. You only need to set this parameter if you use the __collect__ or __invoice__ field. See [REST API Basics](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information.</param>
        /// <returns>PUTSubscriptionResponseType</returns>
        PUTSubscriptionResponseType PUTSubscription (string subscriptionKey, PUTSubscriptionType request, string zuoraVersion);
        /// <summary>
        /// Resume subscription This REST API reference describes how to resume a suspended subscription.   This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://suport.zuora.com).  
        /// </summary>
        /// <param name="subscriptionKey">Subscription number or ID. Subscription status must be Active.</param>
        /// <param name="request"></param>
        /// <param name="zuoraVersion">The minor version of the Zuora REST API. You only need to set this parameter if you use the __collect__ or __invoice__ field. See [REST API Basics](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information.</param>
        /// <returns>PUTSubscriptionResumeResponseType</returns>
        PUTSubscriptionResumeResponseType PUTSubscriptionResume (string subscriptionKey, PUTSubscriptionResumeType request, string zuoraVersion);
        /// <summary>
        /// Suspend subscription This REST API reference describes how to suspend an active subscription.   This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://suport.zuora.com). 
        /// </summary>
        /// <param name="subscriptionKey">Subscription number or ID. Subscription status must be Active.</param>
        /// <param name="request"></param>
        /// <param name="zuoraVersion">The minor version of the Zuora REST API. You only need to set this parameter if you use the __collect__ or __invoice__ field. See [REST API Basics](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information.</param>
        /// <returns>PUTSubscriptionSuspendResponseType</returns>
        PUTSubscriptionSuspendResponseType PUTSubscriptionSuspend (string subscriptionKey, PUTSubscriptionSuspendType request, string zuoraVersion);
        /// <summary>
        /// CRUD: Delete Subscription 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <returns>ProxyDeleteResponse</returns>
        ProxyDeleteResponse ProxyDELETESubscription (string id);
        /// <summary>
        /// CRUD: Retrieve Subscription 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="fields">Object fields to return</param>
        /// <returns>ProxyGetSubscription</returns>
        ProxyGetSubscription ProxyGETSubscription (string id, string fields);
        /// <summary>
        /// CRUD: Create Subscription 
        /// </summary>
        /// <param name="createRequest"></param>
        /// <returns>ProxyCreateOrModifyResponse</returns>
        ProxyCreateOrModifyResponse ProxyPOSTSubscription (ProxyCreateSubscription createRequest);
        /// <summary>
        /// CRUD: Update Subscription 
        /// </summary>
        /// <param name="id">Object id</param>
        /// <param name="modifyRequest"></param>
        /// <returns>ProxyCreateOrModifyResponse</returns>
        ProxyCreateOrModifyResponse ProxyPUTSubscription (string id, ProxyModifySubscription modifyRequest);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SubscriptionsApi : ISubscriptionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SubscriptionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SubscriptionsApi(String basePath)
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
        /// Get subscriptions by key This REST API reference describes how to retrieve detailed information about a specified subscription in the latest version. 
        /// </summary>
        /// <param name="subscriptionKey">Possible values are:   * a subscription number   * a subscription ID </param> 
        /// <param name="chargeDetail"> The segmented rate plan charges. When an amendment results in a change to a charge, Zuora creates a segmented rate plan charge. Use this field to track segment charges.  Possible values are:   * __last-segment__: (Default) The last rate plan charge on the subscription. The last rate plan charge is the last one in the order of time on the subscription rather than the most recent changed charge on the subscription.  * __current-segment__: The segmented charge that is active on today’s date (effectiveStartDate &lt;&#x3D; today’s date &lt; effectiveEndDate).    * __all-segments__: All the segmented charges.   * __specific-segment&amp;as-of-date&#x3D;date__: The segmented charge that is active on a date you specified (effectiveStartDate &lt;&#x3D; specific date &lt; effectiveEndDate). The format of the date is yyyy-mm-dd. </param> 
        /// <returns>GETSubscriptionTypeWithSuccess</returns>            
        public GETSubscriptionTypeWithSuccess GETOneSubscription (string subscriptionKey, string chargeDetail)
        {
            
            // verify the required parameter 'subscriptionKey' is set
            if (subscriptionKey == null) throw new ApiException(400, "Missing required parameter 'subscriptionKey' when calling GETOneSubscription");
            
    
            var path = "/subscriptions/{subscription-key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "subscription-key" + "}", ApiClient.ParameterToString(subscriptionKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (chargeDetail != null) queryParams.Add("charge-detail", ApiClient.ParameterToString(chargeDetail)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETOneSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETOneSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETSubscriptionTypeWithSuccess) ApiClient.Deserialize(response.Content, typeof(GETSubscriptionTypeWithSuccess), response.Headers);
        }
    
        /// <summary>
        /// Get subscriptions by account Retrieves all subscriptions associated with the specified account. Zuora only returns the latest version of the subscriptions.  Subscription data is returned in reverse chronological order based on &#x60;updatedDate&#x60;. 
        /// </summary>
        /// <param name="accountKey"> Possible values are: * an account number * an account ID </param> 
        /// <param name="chargeDetail">The segmented rate plan charges.  When an amendment results in a change to a charge, Zuora creates a segmented rate plan charge. Use this field to track segment charges.  Possible values are:  * &#x60;last-segment&#x60;: (Default) The last rate plan charge on the subscription. The last rate plan charge is the last one in the order of time on the subscription rather than the most recent updated charge on the subscription. * &#x60;current-segment&#x60;: The segmented charge that is active on today’s date (**effectiveStartDate** &lt;&#x3D; today’s date &lt; **effectiveEndDate**). * &#x60;all-segments&#x60;: All the segmented charges. * &#x60;specific-segment&amp;as-of-date&#x3D;date&#x60;: The segmented charge that is active on a date you specified (**effectiveStartDate** &lt;&#x3D; specific date &lt; **effectiveEndDate**). The format of the date is yyyy-mm-dd. </param> 
        /// <returns>GETSubscriptionWrapper</returns>            
        public GETSubscriptionWrapper GETSubscription (string accountKey, string chargeDetail)
        {
            
            // verify the required parameter 'accountKey' is set
            if (accountKey == null) throw new ApiException(400, "Missing required parameter 'accountKey' when calling GETSubscription");
            
    
            var path = "/subscriptions/accounts/{account-key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "account-key" + "}", ApiClient.ParameterToString(accountKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (chargeDetail != null) queryParams.Add("charge-detail", ApiClient.ParameterToString(chargeDetail)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETSubscriptionWrapper) ApiClient.Deserialize(response.Content, typeof(GETSubscriptionWrapper), response.Headers);
        }
    
        /// <summary>
        /// Create subscription This REST API reference describes how to create a new subscription for an existing customer account.  ## Notes If invoiceCollect is &#x60;true&#x60;, the call will not return success &#x3D; &#x60;true&#x60; unless the subscription, invoice, and payment are all successful.  Default values for **customerAcceptanceDate** and **serviceActivationDate** are set as follows.  |        | serviceActivationDate(SA) specified          | serviceActivationDate (SA) NOT specified  | | ------------- |:-------------:| -----:| | customerAcceptanceDate (CA) specified| SA uses value in the request call; CA uses value in the request call| CA uses value in the request call;SA uses CE as default | | customerAcceptanceDate (CA) NOT specified      | SA uses value in the request call; CA uses SA as default |   SA and CA use CE as default | 
        /// </summary>
        /// <param name="request"></param> 
        /// <param name="zuoraVersion">The minor version of the Zuora REST API. You only need to set this parameter if you use the __collect__ or __invoice__ field. See [REST API Basics](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information.</param> 
        /// <returns>POSTSubscriptionResponseType</returns>            
        public POSTSubscriptionResponseType POSTSubscription (POSTSubscriptionType request, string zuoraVersion)
        {
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTSubscription");
            
    
            var path = "/subscriptions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (zuoraVersion != null) headerParams.Add("zuora-version", ApiClient.ParameterToString(zuoraVersion)); // header parameter
                        postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTSubscriptionResponseType) ApiClient.Deserialize(response.Content, typeof(POSTSubscriptionResponseType), response.Headers);
        }
    
        /// <summary>
        /// Cancel subscription This REST API reference describes how to cancel an active subscription. 
        /// </summary>
        /// <param name="subscriptionKey">Subscription number or ID. Subscription status must be &#x60;Active&#x60;.</param> 
        /// <param name="request"></param> 
        /// <param name="zuoraVersion">The minor version of the Zuora REST API. You only need to set this parameter if you use the __collect__ or __invoice__ field. See [REST API Basics](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information.</param> 
        /// <returns>POSTSubscriptionCancellationResponseType</returns>            
        public POSTSubscriptionCancellationResponseType POSTSubscriptionCancellation (string subscriptionKey, POSTSubscriptionCancellationType request, string zuoraVersion)
        {
            
            // verify the required parameter 'subscriptionKey' is set
            if (subscriptionKey == null) throw new ApiException(400, "Missing required parameter 'subscriptionKey' when calling POSTSubscriptionCancellation");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTSubscriptionCancellation");
            
    
            var path = "/subscriptions/{subscription-key}/cancel";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "subscription-key" + "}", ApiClient.ParameterToString(subscriptionKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (zuoraVersion != null) headerParams.Add("zuora-version", ApiClient.ParameterToString(zuoraVersion)); // header parameter
                        postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionCancellation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionCancellation: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTSubscriptionCancellationResponseType) ApiClient.Deserialize(response.Content, typeof(POSTSubscriptionCancellationResponseType), response.Headers);
        }
    
        /// <summary>
        /// Preview subscription The REST API reference describes how to create a new subscription in preview mode. This call does not require a valid customer account. It can be used to show potential new customers a preview of a subscription with complete details and charges before creating an account, or to let existing customers preview a subscription with all charges before committing.  ## Notes Default values for **customerAcceptanceDate** and **serviceActivationDate** are set as follows.  |        | serviceActivationDate (SA) specified          | serviceActivationDate (SA) NOT specified  | | ------------- |:-------------:| -----:| | customerAcceptanceDate (CA) specified      | SA uses value in the request call; CA uses value in the request call| CA uses value in the request call;SA uses CE as default | | customerAcceptanceDate (CA) NOT specified      | SA uses value in the request call; CA uses SA as default |   SA and CA use CE as default | 
        /// </summary>
        /// <param name="request"></param> 
        /// <returns>POSTSubscriptionPreviewResponseType</returns>            
        public POSTSubscriptionPreviewResponseType POSTSubscriptionPreview (POSTSubscriptionPreviewType request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling POSTSubscriptionPreview");
            
    
            var path = "/subscriptions/preview";
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionPreview: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionPreview: " + response.ErrorMessage, response.ErrorMessage);
    
            return (POSTSubscriptionPreviewResponseType) ApiClient.Deserialize(response.Content, typeof(POSTSubscriptionPreviewResponseType), response.Headers);
        }
    
        /// <summary>
        /// Renew subscription Renews a termed subscription using existing renewal terms. 
        /// </summary>
        /// <param name="subscriptionKey">Subscription number or ID</param> 
        /// <param name="request"></param> 
        /// <param name="zuoraVersion">The minor version of the Zuora REST API. You only need to set this parameter if you use the __collect__ or __invoice__ field. See [REST API Basics](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information.</param> 
        /// <returns>PUTRenewSubscriptionResponseType</returns>            
        public PUTRenewSubscriptionResponseType PUTRenewSubscription (string subscriptionKey, PUTRenewSubscriptionType request, string zuoraVersion)
        {
            
            // verify the required parameter 'subscriptionKey' is set
            if (subscriptionKey == null) throw new ApiException(400, "Missing required parameter 'subscriptionKey' when calling PUTRenewSubscription");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling PUTRenewSubscription");
            
    
            var path = "/subscriptions/{subscription-key}/renew";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "subscription-key" + "}", ApiClient.ParameterToString(subscriptionKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (zuoraVersion != null) headerParams.Add("zuora-version", ApiClient.ParameterToString(zuoraVersion)); // header parameter
                        postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTRenewSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTRenewSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PUTRenewSubscriptionResponseType) ApiClient.Deserialize(response.Content, typeof(PUTRenewSubscriptionResponseType), response.Headers);
        }
    
        /// <summary>
        /// Update subscription Use this call to make the following kinds of changes to a subscription:   * Add a note   * Change the renewal term or auto-renewal flag   * Change the term length or change between evergreen and termed   * Add a new product rate plan   * Remove an existing subscription rate plan   * Change the quantity or price of an existing subscription rate plan  ## Notes * The Update Subscription call creates a new subscription, which has the old subscription number but a new subscription ID.  The old subscription is canceled but remains in the system. * In one request, this call can make:   * Up to 9 combined add, update, and remove changes   * No more than 1 change to terms &amp; conditions * Updates are performed in the following sequence:   1. First change the notes on the existing subscription, if requested.   2. Then change the terms and conditions, if requested.   3. Then perform the remaining amendments based upon the effective dates specified. If multiple amendments have the same contract-effective dates, then execute adds before updates, and updates before removes. * The update operation is atomic. If any of the updates fails, the entire operation is rolled back.  ## Override a Tiered Price There are two ways you override a tiered price:  * Override a specific tier number For example: &#x60;tiers[{tier:1,price:8},{tier:2,price:6}]&#x60;  * Override the entire tier structure For example:  &#x60;tiers[{tier:1,price:8,startingUnit:1,endingUnit:100,priceFormat:\&quot;FlatFee\&quot;}, {tier:2,price:6,startingUnit:101,priceFormat:\&quot;FlatFee\&quot;}]&#x60;  If you just override a specific tier, do not include the &#x60;startingUnit&#x60; field in the request. 
        /// </summary>
        /// <param name="subscriptionKey">Subscription number or ID.</param> 
        /// <param name="request"></param> 
        /// <param name="zuoraVersion">The minor version of the Zuora REST API. You only need to set this parameter if you use the __collect__ or __invoice__ field. See [REST API Basics](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information.</param> 
        /// <returns>PUTSubscriptionResponseType</returns>            
        public PUTSubscriptionResponseType PUTSubscription (string subscriptionKey, PUTSubscriptionType request, string zuoraVersion)
        {
            
            // verify the required parameter 'subscriptionKey' is set
            if (subscriptionKey == null) throw new ApiException(400, "Missing required parameter 'subscriptionKey' when calling PUTSubscription");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling PUTSubscription");
            
    
            var path = "/subscriptions/{subscription-key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "subscription-key" + "}", ApiClient.ParameterToString(subscriptionKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (zuoraVersion != null) headerParams.Add("zuora-version", ApiClient.ParameterToString(zuoraVersion)); // header parameter
                        postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PUTSubscriptionResponseType) ApiClient.Deserialize(response.Content, typeof(PUTSubscriptionResponseType), response.Headers);
        }
    
        /// <summary>
        /// Resume subscription This REST API reference describes how to resume a suspended subscription.   This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://suport.zuora.com).  
        /// </summary>
        /// <param name="subscriptionKey">Subscription number or ID. Subscription status must be Active.</param> 
        /// <param name="request"></param> 
        /// <param name="zuoraVersion">The minor version of the Zuora REST API. You only need to set this parameter if you use the __collect__ or __invoice__ field. See [REST API Basics](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information.</param> 
        /// <returns>PUTSubscriptionResumeResponseType</returns>            
        public PUTSubscriptionResumeResponseType PUTSubscriptionResume (string subscriptionKey, PUTSubscriptionResumeType request, string zuoraVersion)
        {
            
            // verify the required parameter 'subscriptionKey' is set
            if (subscriptionKey == null) throw new ApiException(400, "Missing required parameter 'subscriptionKey' when calling PUTSubscriptionResume");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling PUTSubscriptionResume");
            
    
            var path = "/subscriptions/{subscription-key}/resume";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "subscription-key" + "}", ApiClient.ParameterToString(subscriptionKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (zuoraVersion != null) headerParams.Add("zuora-version", ApiClient.ParameterToString(zuoraVersion)); // header parameter
                        postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTSubscriptionResume: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTSubscriptionResume: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PUTSubscriptionResumeResponseType) ApiClient.Deserialize(response.Content, typeof(PUTSubscriptionResumeResponseType), response.Headers);
        }
    
        /// <summary>
        /// Suspend subscription This REST API reference describes how to suspend an active subscription.   This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://suport.zuora.com). 
        /// </summary>
        /// <param name="subscriptionKey">Subscription number or ID. Subscription status must be Active.</param> 
        /// <param name="request"></param> 
        /// <param name="zuoraVersion">The minor version of the Zuora REST API. You only need to set this parameter if you use the __collect__ or __invoice__ field. See [REST API Basics](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information.</param> 
        /// <returns>PUTSubscriptionSuspendResponseType</returns>            
        public PUTSubscriptionSuspendResponseType PUTSubscriptionSuspend (string subscriptionKey, PUTSubscriptionSuspendType request, string zuoraVersion)
        {
            
            // verify the required parameter 'subscriptionKey' is set
            if (subscriptionKey == null) throw new ApiException(400, "Missing required parameter 'subscriptionKey' when calling PUTSubscriptionSuspend");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling PUTSubscriptionSuspend");
            
    
            var path = "/subscriptions/{subscription-key}/suspend";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "subscription-key" + "}", ApiClient.ParameterToString(subscriptionKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (zuoraVersion != null) headerParams.Add("zuora-version", ApiClient.ParameterToString(zuoraVersion)); // header parameter
                        postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTSubscriptionSuspend: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTSubscriptionSuspend: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PUTSubscriptionSuspendResponseType) ApiClient.Deserialize(response.Content, typeof(PUTSubscriptionSuspendResponseType), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Delete Subscription 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <returns>ProxyDeleteResponse</returns>            
        public ProxyDeleteResponse ProxyDELETESubscription (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyDELETESubscription");
            
    
            var path = "/object/subscription/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETESubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyDELETESubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyDeleteResponse) ApiClient.Deserialize(response.Content, typeof(ProxyDeleteResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Retrieve Subscription 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="fields">Object fields to return</param> 
        /// <returns>ProxyGetSubscription</returns>            
        public ProxyGetSubscription ProxyGETSubscription (string id, string fields)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyGETSubscription");
            
    
            var path = "/object/subscription/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyGETSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyGetSubscription) ApiClient.Deserialize(response.Content, typeof(ProxyGetSubscription), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Create Subscription 
        /// </summary>
        /// <param name="createRequest"></param> 
        /// <returns>ProxyCreateOrModifyResponse</returns>            
        public ProxyCreateOrModifyResponse ProxyPOSTSubscription (ProxyCreateSubscription createRequest)
        {
            
            // verify the required parameter 'createRequest' is set
            if (createRequest == null) throw new ApiException(400, "Missing required parameter 'createRequest' when calling ProxyPOSTSubscription");
            
    
            var path = "/object/subscription";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(createRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPOSTSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPOSTSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyCreateOrModifyResponse) ApiClient.Deserialize(response.Content, typeof(ProxyCreateOrModifyResponse), response.Headers);
        }
    
        /// <summary>
        /// CRUD: Update Subscription 
        /// </summary>
        /// <param name="id">Object id</param> 
        /// <param name="modifyRequest"></param> 
        /// <returns>ProxyCreateOrModifyResponse</returns>            
        public ProxyCreateOrModifyResponse ProxyPUTSubscription (string id, ProxyModifySubscription modifyRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProxyPUTSubscription");
            
            // verify the required parameter 'modifyRequest' is set
            if (modifyRequest == null) throw new ApiException(400, "Missing required parameter 'modifyRequest' when calling ProxyPUTSubscription");
            
    
            var path = "/object/subscription/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(modifyRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPUTSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProxyPUTSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProxyCreateOrModifyResponse) ApiClient.Deserialize(response.Content, typeof(ProxyCreateOrModifyResponse), response.Headers);
        }
    
    }
}
