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
  public class AmendRequest {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="AmendOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AmendOptions")]
    public AmendOptions AmendOptions { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Amendments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Amendments")]
    public List<Amendment> Amendments { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PreviewOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PreviewOptions")]
    public PreviewOptions PreviewOptions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AmendRequest {\n");
      sb.Append("  AmendOptions: ").Append(AmendOptions).Append("\n");
      sb.Append("  Amendments: ").Append(Amendments).Append("\n");
      sb.Append("  PreviewOptions: ").Append(PreviewOptions).Append("\n");
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
