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
  public class PUTRenewSubscriptionResponseType {
    /// <summary>
    /// Invoice ID, if one is generated. 
    /// </summary>
    /// <value>Invoice ID, if one is generated. </value>
    [DataMember(Name="invoiceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceId")]
    public string InvoiceId { get; set; }

    /// <summary>
    /// Payment amount, if payment is collected. 
    /// </summary>
    /// <value>Payment amount, if payment is collected. </value>
    [DataMember(Name="paidAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paidAmount")]
    public string PaidAmount { get; set; }

    /// <summary>
    /// Payment ID, if payment is collected. 
    /// </summary>
    /// <value>Payment ID, if payment is collected. </value>
    [DataMember(Name="paymentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentId")]
    public string PaymentId { get; set; }

    /// <summary>
    /// Returns `true` if the request was processed successfully. 
    /// </summary>
    /// <value>Returns `true` if the request was processed successfully. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// Date the new subscription term ends, as yyyy-mm-dd. 
    /// </summary>
    /// <value>Date the new subscription term ends, as yyyy-mm-dd. </value>
    [DataMember(Name="termEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "termEndDate")]
    public DateTime? TermEndDate { get; set; }

    /// <summary>
    /// Date the new subscription term begins, as yyyy-mm-dd. 
    /// </summary>
    /// <value>Date the new subscription term begins, as yyyy-mm-dd. </value>
    [DataMember(Name="termStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "termStartDate")]
    public DateTime? TermStartDate { get; set; }

    /// <summary>
    /// Change in the subscription monthly recurring revenue as a result of the update. For a renewal, this is the MRR of the subscription in the new term. 
    /// </summary>
    /// <value>Change in the subscription monthly recurring revenue as a result of the update. For a renewal, this is the MRR of the subscription in the new term. </value>
    [DataMember(Name="totalDeltaMrr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalDeltaMrr")]
    public string TotalDeltaMrr { get; set; }

    /// <summary>
    /// Change in the total contracted value of the subscription as a result of the update. For a renewal, this is the TCV of the subscription in the new term. 
    /// </summary>
    /// <value>Change in the total contracted value of the subscription as a result of the update. For a renewal, this is the TCV of the subscription in the new term. </value>
    [DataMember(Name="totalDeltaTcv", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalDeltaTcv")]
    public string TotalDeltaTcv { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PUTRenewSubscriptionResponseType {\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  PaidAmount: ").Append(PaidAmount).Append("\n");
      sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  TermEndDate: ").Append(TermEndDate).Append("\n");
      sb.Append("  TermStartDate: ").Append(TermStartDate).Append("\n");
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
