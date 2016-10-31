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
  public class InvoiceData {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Invoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Invoice")]
    public Invoice Invoice { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="InvoiceItem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceItem")]
    public List<InvoiceItem> InvoiceItem { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InvoiceData {\n");
      sb.Append("  Invoice: ").Append(Invoice).Append("\n");
      sb.Append("  InvoiceItem: ").Append(InvoiceItem).Append("\n");
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
