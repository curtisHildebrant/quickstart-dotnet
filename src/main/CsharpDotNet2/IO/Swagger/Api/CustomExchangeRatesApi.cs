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
    public interface ICustomExchangeRatesApi
    {
        /// <summary>
        /// Get custom foreign currency exchange rates This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).   This reference describes how to query custom foreign exchange rates from Zuora. You can use this API method to query exchange rates only if you use a custom exchange rate provider and upload rates with the [Import Foreign Exchange Rates](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater/Import_Foreign_Exchange_Rates) mass action. If you want to get exchange rates for the default exchange rate provider, Oanda, see [Foreign Currency Conversion for Data Source Exports](https://knowledgecenter.zuora.com/CC_Finance/Foreign_Currency_Conversion/Foreign_Currency_Conversion_for_Data_Source_Exports).  For more information about currency conversion in Zuora, see [Foreign Currency Conversion](https://knowledgecenter.zuora.com/CC_Finance/Foreign_Currency_Conversion). 
        /// </summary>
        /// <param name="currency">The target currency. The exchange rates in the response are calculated in relation to the target currency.  The value must be a three-letter currency code, for example, USD. See [ISO Currency Codes](https://knowledgecenter.zuora.com/BC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/D_Currencies_and_Their_3-Letter_Codes) for a full list of currency codes. </param>
        /// <param name="startDate">Start date of the date range for which you want to get exchange rates.  The date must be in yyyy-mm-dd format, for example, 2016-01-15. The start date cannot be later than the end date. </param>
        /// <param name="endDate">End date of the date range for which you want to get exchange rates.  The date must be in yyyy-mm-dd format, for example, 2016-01-16. The end date can be a maximum of 90 days after the start date. </param>
        /// <returns>GETCustomExchangeRatesType</returns>
        GETCustomExchangeRatesType GETCustomExchangeRates (string currency, string startDate, string endDate);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CustomExchangeRatesApi : ICustomExchangeRatesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomExchangeRatesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CustomExchangeRatesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomExchangeRatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomExchangeRatesApi(String basePath)
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
        /// Get custom foreign currency exchange rates This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).   This reference describes how to query custom foreign exchange rates from Zuora. You can use this API method to query exchange rates only if you use a custom exchange rate provider and upload rates with the [Import Foreign Exchange Rates](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater/Import_Foreign_Exchange_Rates) mass action. If you want to get exchange rates for the default exchange rate provider, Oanda, see [Foreign Currency Conversion for Data Source Exports](https://knowledgecenter.zuora.com/CC_Finance/Foreign_Currency_Conversion/Foreign_Currency_Conversion_for_Data_Source_Exports).  For more information about currency conversion in Zuora, see [Foreign Currency Conversion](https://knowledgecenter.zuora.com/CC_Finance/Foreign_Currency_Conversion). 
        /// </summary>
        /// <param name="currency">The target currency. The exchange rates in the response are calculated in relation to the target currency.  The value must be a three-letter currency code, for example, USD. See [ISO Currency Codes](https://knowledgecenter.zuora.com/BC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/D_Currencies_and_Their_3-Letter_Codes) for a full list of currency codes. </param> 
        /// <param name="startDate">Start date of the date range for which you want to get exchange rates.  The date must be in yyyy-mm-dd format, for example, 2016-01-15. The start date cannot be later than the end date. </param> 
        /// <param name="endDate">End date of the date range for which you want to get exchange rates.  The date must be in yyyy-mm-dd format, for example, 2016-01-16. The end date can be a maximum of 90 days after the start date. </param> 
        /// <returns>GETCustomExchangeRatesType</returns>            
        public GETCustomExchangeRatesType GETCustomExchangeRates (string currency, string startDate, string endDate)
        {
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling GETCustomExchangeRates");
            
            // verify the required parameter 'startDate' is set
            if (startDate == null) throw new ApiException(400, "Missing required parameter 'startDate' when calling GETCustomExchangeRates");
            
            // verify the required parameter 'endDate' is set
            if (endDate == null) throw new ApiException(400, "Missing required parameter 'endDate' when calling GETCustomExchangeRates");
            
    
            var path = "/custom-exchange-rates/{currency}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "currency" + "}", ApiClient.ParameterToString(currency));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETCustomExchangeRates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETCustomExchangeRates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GETCustomExchangeRatesType) ApiClient.Deserialize(response.Content, typeof(GETCustomExchangeRatesType), response.Headers);
        }
    
    }
}
