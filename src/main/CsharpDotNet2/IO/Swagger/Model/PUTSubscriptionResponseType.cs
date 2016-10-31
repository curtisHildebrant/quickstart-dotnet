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
  public class PUTSubscriptionResponseType {
    /// <summary>
    /// Invoice amount. Preview mode only. 
    /// </summary>
    /// <value>Invoice amount. Preview mode only. </value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// Invoice amount minus tax. Preview mode only. 
    /// </summary>
    /// <value>Invoice amount minus tax. Preview mode only. </value>
    [DataMember(Name="amountWithoutTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountWithoutTax")]
    public string AmountWithoutTax { get; set; }

    /// <summary>
    /// Gets or Sets ChargeMetrics
    /// </summary>
    [DataMember(Name="chargeMetrics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeMetrics")]
    public PUTSubscriptionResponseTypeChargeMetrics ChargeMetrics { get; set; }

    /// <summary>
    /// Invoice ID, if an invoice is generated during the update. 
    /// </summary>
    /// <value>Invoice ID, if an invoice is generated during the update. </value>
    [DataMember(Name="invoiceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceId")]
    public string InvoiceId { get; set; }

    /// <summary>
    /// Container for invoice items. 
    /// </summary>
    /// <value>Container for invoice items. </value>
    [DataMember(Name="invoiceItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceItems")]
    public List<PUTSubscriptionPreviewInvoiceItemsType> InvoiceItems { get; set; }

    /// <summary>
    /// Date through which charges are calculated on the invoice, as yyyy-mm-dd. Preview mode only. 
    /// </summary>
    /// <value>Date through which charges are calculated on the invoice, as yyyy-mm-dd. Preview mode only. </value>
    [DataMember(Name="invoiceTargetDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceTargetDate")]
    public DateTime? InvoiceTargetDate { get; set; }

    /// <summary>
    /// Payment amount, if a payment is collected 
    /// </summary>
    /// <value>Payment amount, if a payment is collected </value>
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
    [DataMember(Name="previewChargeMetricsResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previewChargeMetricsResponse")]
    public string PreviewChargeMetricsResponse { get; set; }

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
    /// The ID of the resulting new subscription. 
    /// </summary>
    /// <value>The ID of the resulting new subscription. </value>
    [DataMember(Name="subscriptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionId")]
    public string SubscriptionId { get; set; }

    /// <summary>
    /// Returns `true` if successful, otherwise `false. 
    /// </summary>
    /// <value>Returns `true` if successful, otherwise `false. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// Tax amount on the invoice. 
    /// </summary>
    /// <value>Tax amount on the invoice. </value>
    [DataMember(Name="taxAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxAmount")]
    public string TaxAmount { get; set; }

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
      sb.Append("class PUTSubscriptionResponseType {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  AmountWithoutTax: ").Append(AmountWithoutTax).Append("\n");
      sb.Append("  ChargeMetrics: ").Append(ChargeMetrics).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  InvoiceItems: ").Append(InvoiceItems).Append("\n");
      sb.Append("  InvoiceTargetDate: ").Append(InvoiceTargetDate).Append("\n");
      sb.Append("  PaidAmount: ").Append(PaidAmount).Append("\n");
      sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
      sb.Append("  PreviewChargeMetricsResponse: ").Append(PreviewChargeMetricsResponse).Append("\n");
      sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
      sb.Append("  Reasons: ").Append(Reasons).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
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
