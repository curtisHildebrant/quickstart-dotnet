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
  public class SubscribeInvoiceProcessingOptions {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="InvoiceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceDate")]
    public DateTime? InvoiceDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="InvoiceProcessingScope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceProcessingScope")]
    public string InvoiceProcessingScope { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="InvoiceTargetDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceTargetDate")]
    public DateTime? InvoiceTargetDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscribeInvoiceProcessingOptions {\n");
      sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
      sb.Append("  InvoiceProcessingScope: ").Append(InvoiceProcessingScope).Append("\n");
      sb.Append("  InvoiceTargetDate: ").Append(InvoiceTargetDate).Append("\n");
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
