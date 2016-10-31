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
  public class GETRevenueEventDetailsType {
    /// <summary>
    /// Represents a change to a revenue schedule, such as posting an invoice or distributing revenue. 
    /// </summary>
    /// <value>Represents a change to a revenue schedule, such as posting an invoice or distributing revenue. </value>
    [DataMember(Name="revenueEventDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueEventDetails")]
    public List<GETRevenueEventDetailWithoutSuccessType> RevenueEventDetails { get; set; }

    /// <summary>
    /// Returns `true` if the request was processed successfully. 
    /// </summary>
    /// <value>Returns `true` if the request was processed successfully. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETRevenueEventDetailsType {\n");
      sb.Append("  RevenueEventDetails: ").Append(RevenueEventDetails).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
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
