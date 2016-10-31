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
  public class AmendResult {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="AmendmentIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AmendmentIds")]
    public string AmendmentIds { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="ChargeMetricsData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeMetricsData")]
    public ChargeMetricsData ChargeMetricsData { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Errors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Errors")]
    public List<Error> Errors { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="GatewayResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GatewayResponse")]
    public string GatewayResponse { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="GatewayResponseCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GatewayResponseCode")]
    public string GatewayResponseCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="InvoiceDatas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceDatas")]
    public List<InvoiceData> InvoiceDatas { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="InvoiceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceId")]
    public string InvoiceId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PaymentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentId")]
    public string PaymentId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PaymentTransactionNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentTransactionNumber")]
    public string PaymentTransactionNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="SubscriptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubscriptionId")]
    public string SubscriptionId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="TotalDeltaMrr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalDeltaMrr")]
    public double? TotalDeltaMrr { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="TotalDeltaTcv", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalDeltaTcv")]
    public double? TotalDeltaTcv { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AmendResult {\n");
      sb.Append("  AmendmentIds: ").Append(AmendmentIds).Append("\n");
      sb.Append("  ChargeMetricsData: ").Append(ChargeMetricsData).Append("\n");
      sb.Append("  Errors: ").Append(Errors).Append("\n");
      sb.Append("  GatewayResponse: ").Append(GatewayResponse).Append("\n");
      sb.Append("  GatewayResponseCode: ").Append(GatewayResponseCode).Append("\n");
      sb.Append("  InvoiceDatas: ").Append(InvoiceDatas).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
      sb.Append("  PaymentTransactionNumber: ").Append(PaymentTransactionNumber).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  TotalDeltaMrr: ").Append(TotalDeltaMrr).Append("\n");
      sb.Append("  TotalDeltaTcv: ").Append(TotalDeltaTcv).Append("\n");
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
