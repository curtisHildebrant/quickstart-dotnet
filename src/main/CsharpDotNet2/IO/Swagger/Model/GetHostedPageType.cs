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
  public class GetHostedPageType {
    /// <summary>
    /// Page ID of the Payment Page that Zuora assigns when it is created. 
    /// </summary>
    /// <value>Page ID of the Payment Page that Zuora assigns when it is created. </value>
    [DataMember(Name="pageId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageId")]
    public string PageId { get; set; }

    /// <summary>
    /// Name of the Payment Page that specified during the page configuration. 
    /// </summary>
    /// <value>Name of the Payment Page that specified during the page configuration. </value>
    [DataMember(Name="pageName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageName")]
    public string PageName { get; set; }

    /// <summary>
    /// Payment method type of this Payment Page, e.g. 'Credit Card', 'ACH', or 'Bank Transfer'. 
    /// </summary>
    /// <value>Payment method type of this Payment Page, e.g. 'Credit Card', 'ACH', or 'Bank Transfer'. </value>
    [DataMember(Name="pageType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageType")]
    public string PageType { get; set; }

    /// <summary>
    /// Version of the Payment Page. 1 for Payment Pages 1.0 or 2 for Payment Pages 2.0. 
    /// </summary>
    /// <value>Version of the Payment Page. 1 for Payment Pages 1.0 or 2 for Payment Pages 2.0. </value>
    [DataMember(Name="pageVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageVersion")]
    public string PageVersion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetHostedPageType {\n");
      sb.Append("  PageId: ").Append(PageId).Append("\n");
      sb.Append("  PageName: ").Append(PageName).Append("\n");
      sb.Append("  PageType: ").Append(PageType).Append("\n");
      sb.Append("  PageVersion: ").Append(PageVersion).Append("\n");
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
