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
  public class RatePlanData {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="RatePlan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RatePlan")]
    public RatePlan RatePlan { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="RatePlanChargeData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RatePlanChargeData")]
    public List<RatePlanChargeData> RatePlanChargeData { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="SubscriptionProductFeatureList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubscriptionProductFeatureList")]
    public SubscriptionProductFeatureList SubscriptionProductFeatureList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RatePlanData {\n");
      sb.Append("  RatePlan: ").Append(RatePlan).Append("\n");
      sb.Append("  RatePlanChargeData: ").Append(RatePlanChargeData).Append("\n");
      sb.Append("  SubscriptionProductFeatureList: ").Append(SubscriptionProductFeatureList).Append("\n");
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
