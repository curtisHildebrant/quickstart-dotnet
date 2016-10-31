using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class POSTHMACSignatureType {
    /// <summary>
    /// Customer account number or ID.  Specifies this field only when creating signatures for [Create payment method](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Payment_methods/1_Create_payment_method). 
    /// </summary>
    /// <value>Customer account number or ID.  Specifies this field only when creating signatures for [Create payment method](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Payment_methods/1_Create_payment_method). </value>
    [DataMember(Name="accountKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountKey")]
    public string AccountKey { get; set; }

    /// <summary>
    /// Possible values are: 'GET', 'POST', 'PUT', 'DELETE', 'OPTIONS'. 
    /// </summary>
    /// <value>Possible values are: 'GET', 'POST', 'PUT', 'DELETE', 'OPTIONS'. </value>
    [DataMember(Name="method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "method")]
    public string Method { get; set; }

    /// <summary>
    /// Account name.  Specifies this field only when creating signatures for [Create account](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Accounts/1_Create_account). 
    /// </summary>
    /// <value>Account name.  Specifies this field only when creating signatures for [Create account](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Accounts/1_Create_account). </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The page id of your Payment Pages 2.0 form. Click **Show Page Id** next to the Payment Page name in the Hosted Page List to retrieve the page id.  Specifies this field only when creating signatures for [RSA Signatures](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/RSA_Signatures). 
    /// </summary>
    /// <value>The page id of your Payment Pages 2.0 form. Click **Show Page Id** next to the Payment Page name in the Hosted Page List to retrieve the page id.  Specifies this field only when creating signatures for [RSA Signatures](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/RSA_Signatures). </value>
    [DataMember(Name="pageId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageId")]
    public string PageId { get; set; }

    /// <summary>
    /// The URI of the API object the customer will make a CORS enabled call to. e.g. \"https://api.zuora.com/rest/v1/payment-methods/credit-cards\" 
    /// </summary>
    /// <value>The URI of the API object the customer will make a CORS enabled call to. e.g. \"https://api.zuora.com/rest/v1/payment-methods/credit-cards\" </value>
    [DataMember(Name="uri", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uri")]
    public string Uri { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTHMACSignatureType {\n");
      sb.Append("  AccountKey: ").Append(AccountKey).Append("\n");
      sb.Append("  Method: ").Append(Method).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PageId: ").Append(PageId).Append("\n");
      sb.Append("  Uri: ").Append(Uri).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
