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
  public class PUTSubscriptionResumeResponseType {
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
    /// The date when subscription resumption takes effect, as yyyy-mm-dd. 
    /// </summary>
    /// <value>The date when subscription resumption takes effect, as yyyy-mm-dd. </value>
    [DataMember(Name="resumeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resumeDate")]
    public DateTime? ResumeDate { get; set; }

    /// <summary>
    /// The subscription ID. 
    /// </summary>
    /// <value>The subscription ID. </value>
    [DataMember(Name="subscriptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionId")]
    public string SubscriptionId { get; set; }

    /// <summary>
    /// Returns `true` if the request was processed successfully. 
    /// </summary>
    /// <value>Returns `true` if the request was processed successfully. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// The date when the new subscription term ends, as yyyy-mm-dd. 
    /// </summary>
    /// <value>The date when the new subscription term ends, as yyyy-mm-dd. </value>
    [DataMember(Name="termEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "termEndDate")]
    public DateTime? TermEndDate { get; set; }

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
      sb.Append("class PUTSubscriptionResumeResponseType {\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  PaidAmount: ").Append(PaidAmount).Append("\n");
      sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
      sb.Append("  ResumeDate: ").Append(ResumeDate).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  TermEndDate: ").Append(TermEndDate).Append("\n");
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
