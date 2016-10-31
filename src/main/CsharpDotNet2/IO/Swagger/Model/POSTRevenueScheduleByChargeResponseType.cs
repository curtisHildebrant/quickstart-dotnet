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
  public class POSTRevenueScheduleByChargeResponseType {
    /// <summary>
    /// Revenue schedule number. The revenue schedule number is always prefixed with \"RS\", for example, \"RS-00000001\". 
    /// </summary>
    /// <value>Revenue schedule number. The revenue schedule number is always prefixed with \"RS\", for example, \"RS-00000001\". </value>
    [DataMember(Name="revenueScheduleNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueScheduleNumber")]
    public string RevenueScheduleNumber { get; set; }

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
      sb.Append("class POSTRevenueScheduleByChargeResponseType {\n");
      sb.Append("  RevenueScheduleNumber: ").Append(RevenueScheduleNumber).Append("\n");
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
