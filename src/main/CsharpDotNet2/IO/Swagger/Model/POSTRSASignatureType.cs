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
  public class POSTRSASignatureType {
    /// <summary>
    /// The type of the request. Set it to POST. 
    /// </summary>
    /// <value>The type of the request. Set it to POST. </value>
    [DataMember(Name="method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "method")]
    public string Method { get; set; }

    /// <summary>
    /// The page id of your Payment Pages 2.0 form. Click **Show Page Id** next to the Payment Page name in the Hosted Page List to retrieve the page id. 
    /// </summary>
    /// <value>The page id of your Payment Pages 2.0 form. Click **Show Page Id** next to the Payment Page name in the Hosted Page List to retrieve the page id. </value>
    [DataMember(Name="pageId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageId")]
    public string PageId { get; set; }

    /// <summary>
    /// The URL that the Payment Page will be served from. Set it to:  * https://www.zuora.com/apps/PublicHostedPageLite.do if you are on the production environment. * https://apisandbox.zuora.com/apps/PublicHostedPageLite.do if you are on the API Sandbox environmentdbox.zuora.com/apps/PublicHostedPageLite.do if you are on the API Sandbox environment. 
    /// </summary>
    /// <value>The URL that the Payment Page will be served from. Set it to:  * https://www.zuora.com/apps/PublicHostedPageLite.do if you are on the production environment. * https://apisandbox.zuora.com/apps/PublicHostedPageLite.do if you are on the API Sandbox environmentdbox.zuora.com/apps/PublicHostedPageLite.do if you are on the API Sandbox environment. </value>
    [DataMember(Name="uri", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uri")]
    public string Uri { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTRSASignatureType {\n");
      sb.Append("  Method: ").Append(Method).Append("\n");
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
