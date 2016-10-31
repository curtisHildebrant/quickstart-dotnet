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
  public class NewChargeMetrics {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="ChargeNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeNumber")]
    public string ChargeNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="DMRR", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DMRR")]
    public double? DMRR { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="DTCV", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DTCV")]
    public double? DTCV { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="MRR", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MRR")]
    public double? MRR { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="OriginalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OriginalId")]
    public string OriginalId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="OriginalRatePlanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OriginalRatePlanId")]
    public string OriginalRatePlanId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="ProductRatePlanChargeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductRatePlanChargeId")]
    public string ProductRatePlanChargeId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="ProductRatePlanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductRatePlanId")]
    public string ProductRatePlanId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="TCV", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TCV")]
    public double? TCV { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NewChargeMetrics {\n");
      sb.Append("  ChargeNumber: ").Append(ChargeNumber).Append("\n");
      sb.Append("  DMRR: ").Append(DMRR).Append("\n");
      sb.Append("  DTCV: ").Append(DTCV).Append("\n");
      sb.Append("  MRR: ").Append(MRR).Append("\n");
      sb.Append("  OriginalId: ").Append(OriginalId).Append("\n");
      sb.Append("  OriginalRatePlanId: ").Append(OriginalRatePlanId).Append("\n");
      sb.Append("  ProductRatePlanChargeId: ").Append(ProductRatePlanChargeId).Append("\n");
      sb.Append("  ProductRatePlanId: ").Append(ProductRatePlanId).Append("\n");
      sb.Append("  TCV: ").Append(TCV).Append("\n");
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
