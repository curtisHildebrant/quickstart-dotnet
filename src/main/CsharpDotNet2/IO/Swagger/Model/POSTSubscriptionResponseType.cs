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
  public class POSTSubscriptionResponseType {
    /// <summary>
    /// Monthly recurring revenue of the subscription. 
    /// </summary>
    /// <value>Monthly recurring revenue of the subscription. </value>
    [DataMember(Name="contractedMrr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractedMrr")]
    public string ContractedMrr { get; set; }

    /// <summary>
    /// Invoice ID, if an invoice is generated during the subscription process. 
    /// </summary>
    /// <value>Invoice ID, if an invoice is generated during the subscription process. </value>
    [DataMember(Name="invoiceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceId")]
    public string InvoiceId { get; set; }

    /// <summary>
    /// Payment amount, if a payment is collected. 
    /// </summary>
    /// <value>Payment amount, if a payment is collected. </value>
    [DataMember(Name="paidAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paidAmount")]
    public string PaidAmount { get; set; }

    /// <summary>
    /// Payment ID, if a payment is collected. 
    /// </summary>
    /// <value>Payment ID, if a payment is collected. </value>
    [DataMember(Name="paymentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentId")]
    public string PaymentId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="subscriptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionId")]
    public string SubscriptionId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="subscriptionNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionNumber")]
    public string SubscriptionNumber { get; set; }

    /// <summary>
    /// Returns `true` if the request was processed successfully. 
    /// </summary>
    /// <value>Returns `true` if the request was processed successfully. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// Total contracted value of the subscription. 
    /// </summary>
    /// <value>Total contracted value of the subscription. </value>
    [DataMember(Name="totalContractedValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalContractedValue")]
    public string TotalContractedValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTSubscriptionResponseType {\n");
      sb.Append("  ContractedMrr: ").Append(ContractedMrr).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  PaidAmount: ").Append(PaidAmount).Append("\n");
      sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
      sb.Append("  SubscriptionNumber: ").Append(SubscriptionNumber).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  TotalContractedValue: ").Append(TotalContractedValue).Append("\n");
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
