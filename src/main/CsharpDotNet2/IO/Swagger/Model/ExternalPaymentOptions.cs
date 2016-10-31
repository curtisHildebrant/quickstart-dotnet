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
  public class ExternalPaymentOptions {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Amount")]
    public double? Amount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveDate")]
    public DateTime? EffectiveDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="GatewayOrderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GatewayOrderId")]
    public string GatewayOrderId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PaymentMethodId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentMethodId")]
    public string PaymentMethodId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="ReferenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReferenceId")]
    public string ReferenceId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExternalPaymentOptions {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
      sb.Append("  GatewayOrderId: ").Append(GatewayOrderId).Append("\n");
      sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
      sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
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
