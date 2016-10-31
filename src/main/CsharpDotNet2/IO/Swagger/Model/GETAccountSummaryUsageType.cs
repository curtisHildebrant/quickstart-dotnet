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
  public class GETAccountSummaryUsageType {
    /// <summary>
    /// Number of units used. 
    /// </summary>
    /// <value>Number of units used. </value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public string Quantity { get; set; }

    /// <summary>
    /// The start date of a usage period as `yyyy-mm`. Zuora uses this field value to determine the usage date. 
    /// </summary>
    /// <value>The start date of a usage period as `yyyy-mm`. Zuora uses this field value to determine the usage date. </value>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Unit by which consumption is measured, as configured in the Billing Settings section of the web-based UI. 
    /// </summary>
    /// <value>Unit by which consumption is measured, as configured in the Billing Settings section of the web-based UI. </value>
    [DataMember(Name="unitOfMeasure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitOfMeasure")]
    public string UnitOfMeasure { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountSummaryUsageType {\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
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
