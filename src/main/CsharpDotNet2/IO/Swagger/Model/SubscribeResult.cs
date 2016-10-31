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
  public class SubscribeResult {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public string AccountId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="AccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountNumber")]
    public string AccountNumber { get; set; }

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
    [DataMember(Name="InvoiceData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceData")]
    public List<InvoiceData> InvoiceData { get; set; }

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
    [DataMember(Name="InvoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceNumber")]
    public string InvoiceNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="InvoiceResult", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceResult")]
    public InvoiceResult InvoiceResult { get; set; }

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
    [DataMember(Name="SubscriptionNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubscriptionNumber")]
    public string SubscriptionNumber { get; set; }

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
    [DataMember(Name="TotalMrr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalMrr")]
    public double? TotalMrr { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="TotalTcv", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalTcv")]
    public double? TotalTcv { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscribeResult {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  ChargeMetricsData: ").Append(ChargeMetricsData).Append("\n");
      sb.Append("  Errors: ").Append(Errors).Append("\n");
      sb.Append("  GatewayResponse: ").Append(GatewayResponse).Append("\n");
      sb.Append("  GatewayResponseCode: ").Append(GatewayResponseCode).Append("\n");
      sb.Append("  InvoiceData: ").Append(InvoiceData).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
      sb.Append("  InvoiceResult: ").Append(InvoiceResult).Append("\n");
      sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
      sb.Append("  PaymentTransactionNumber: ").Append(PaymentTransactionNumber).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
      sb.Append("  SubscriptionNumber: ").Append(SubscriptionNumber).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  TotalMrr: ").Append(TotalMrr).Append("\n");
      sb.Append("  TotalTcv: ").Append(TotalTcv).Append("\n");
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
