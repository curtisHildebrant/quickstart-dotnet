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
  public class POSTSubscriptionCancellationResponseType {
    /// <summary>
    /// The date that the subscription was canceled. 
    /// </summary>
    /// <value>The date that the subscription was canceled. </value>
    [DataMember(Name="cancelledDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancelledDate")]
    public DateTime? CancelledDate { get; set; }

    /// <summary>
    /// ID of the invoice, if one is generated. 
    /// </summary>
    /// <value>ID of the invoice, if one is generated. </value>
    [DataMember(Name="invoiceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceId")]
    public string InvoiceId { get; set; }

    /// <summary>
    /// Amount paid. 
    /// </summary>
    /// <value>Amount paid. </value>
    [DataMember(Name="paidAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paidAmount")]
    public string PaidAmount { get; set; }

    /// <summary>
    /// ID of the payment, if a payment is collected. 
    /// </summary>
    /// <value>ID of the payment, if a payment is collected. </value>
    [DataMember(Name="paymentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentId")]
    public string PaymentId { get; set; }

    /// <summary>
    /// Internal process ID to assist Zuora support.
    /// </summary>
    /// <value>Internal process ID to assist Zuora support.</value>
    [DataMember(Name="processId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processId")]
    public string ProcessId { get; set; }

    /// <summary>
    /// Information on one or more reasons for a failed result.
    /// </summary>
    /// <value>Information on one or more reasons for a failed result.</value>
    [DataMember(Name="reasons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reasons")]
    public List<ErrorCodeType> Reasons { get; set; }

    /// <summary>
    /// The subscription ID. 
    /// </summary>
    /// <value>The subscription ID. </value>
    [DataMember(Name="subscriptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionId")]
    public string SubscriptionId { get; set; }

    /// <summary>
    /// Returns `true` if successful, otherwise `false`. 
    /// </summary>
    /// <value>Returns `true` if successful, otherwise `false`. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// Change in the subscription monthly recurring revenue as a result of the update. 
    /// </summary>
    /// <value>Change in the subscription monthly recurring revenue as a result of the update. </value>
    [DataMember(Name="totalDeltaMrr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalDeltaMrr")]
    public string TotalDeltaMrr { get; set; }

    /// <summary>
    /// Change in the total contracted value of the subscription as a result of the update. 
    /// </summary>
    /// <value>Change in the total contracted value of the subscription as a result of the update. </value>
    [DataMember(Name="totalDeltaTcv", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalDeltaTcv")]
    public string TotalDeltaTcv { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTSubscriptionCancellationResponseType {\n");
      sb.Append("  CancelledDate: ").Append(CancelledDate).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  PaidAmount: ").Append(PaidAmount).Append("\n");
      sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
      sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
      sb.Append("  Reasons: ").Append(Reasons).Append("\n");
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
