using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for charge metrics. 
  /// </summary>
  [DataContract]
  public class PUTSubscriptionResponseTypeChargeMetrics {
    /// <summary>
    /// Change in total contract value. 
    /// </summary>
    /// <value>Change in total contract value. </value>
    [DataMember(Name="dmrr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dmrr")]
    public string Dmrr { get; set; }

    /// <summary>
    /// Change in monthly recurring revenue. 
    /// </summary>
    /// <value>Change in monthly recurring revenue. </value>
    [DataMember(Name="dtcv", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dtcv")]
    public string Dtcv { get; set; }

    /// <summary>
    /// Monthly recurring revenue. 
    /// </summary>
    /// <value>Monthly recurring revenue. </value>
    [DataMember(Name="mrr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mrr")]
    public string Mrr { get; set; }

    /// <summary>
    /// The charge number of the subscription. Only available for update subscription. 
    /// </summary>
    /// <value>The charge number of the subscription. Only available for update subscription. </value>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public string Number { get; set; }

    /// <summary>
    /// The origin rate plan ID. Only available for update subscription. 
    /// </summary>
    /// <value>The origin rate plan ID. Only available for update subscription. </value>
    [DataMember(Name="originRatePlanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originRatePlanId")]
    public string OriginRatePlanId { get; set; }

    /// <summary>
    /// The original rate plan charge ID. Only available for update subscription. 
    /// </summary>
    /// <value>The original rate plan charge ID. Only available for update subscription. </value>
    [DataMember(Name="originalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalId")]
    public string OriginalId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="productRatePlanChargeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productRatePlanChargeId")]
    public string ProductRatePlanChargeId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="productRatePlanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productRatePlanId")]
    public string ProductRatePlanId { get; set; }

    /// <summary>
    /// Total contract value. 
    /// </summary>
    /// <value>Total contract value. </value>
    [DataMember(Name="tcv", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tcv")]
    public string Tcv { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PUTSubscriptionResponseTypeChargeMetrics {\n");
      sb.Append("  Dmrr: ").Append(Dmrr).Append("\n");
      sb.Append("  Dtcv: ").Append(Dtcv).Append("\n");
      sb.Append("  Mrr: ").Append(Mrr).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  OriginRatePlanId: ").Append(OriginRatePlanId).Append("\n");
      sb.Append("  OriginalId: ").Append(OriginalId).Append("\n");
      sb.Append("  ProductRatePlanChargeId: ").Append(ProductRatePlanChargeId).Append("\n");
      sb.Append("  ProductRatePlanId: ").Append(ProductRatePlanId).Append("\n");
      sb.Append("  Tcv: ").Append(Tcv).Append("\n");
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
