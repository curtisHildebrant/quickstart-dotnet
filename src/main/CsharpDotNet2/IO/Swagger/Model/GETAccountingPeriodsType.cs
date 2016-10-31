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
  public class GETAccountingPeriodsType {
    /// <summary>
    /// An array of all accounting periods on your tenant. The accounting periods are returned in ascending order of start date; that is, the latest period is returned first. 
    /// </summary>
    /// <value>An array of all accounting periods on your tenant. The accounting periods are returned in ascending order of start date; that is, the latest period is returned first. </value>
    [DataMember(Name="accountingPeriods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingPeriods")]
    public List<GETAccountingPeriodWithoutSuccessType> AccountingPeriods { get; set; }

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
      sb.Append("class GETAccountingPeriodsType {\n");
      sb.Append("  AccountingPeriods: ").Append(AccountingPeriods).Append("\n");
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
