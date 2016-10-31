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
  public class SubscriptionData {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="RatePlanData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RatePlanData")]
    public List<RatePlanData> RatePlanData { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Subscription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Subscription")]
    public Subscription Subscription { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionData {\n");
      sb.Append("  RatePlanData: ").Append(RatePlanData).Append("\n");
      sb.Append("  Subscription: ").Append(Subscription).Append("\n");
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
