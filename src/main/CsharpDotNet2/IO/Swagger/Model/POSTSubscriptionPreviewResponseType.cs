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
  public class POSTSubscriptionPreviewResponseType {
    /// <summary>
    /// Invoice amount. 
    /// </summary>
    /// <value>Invoice amount. </value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// Invoice amount minus tax. 
    /// </summary>
    /// <value>Invoice amount minus tax. </value>
    [DataMember(Name="amountWithoutTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountWithoutTax")]
    public string AmountWithoutTax { get; set; }

    /// <summary>
    /// Gets or Sets ChargeMetrics
    /// </summary>
    [DataMember(Name="chargeMetrics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeMetrics")]
    public POSTSubscriptionPreviewResponseTypeChargeMetrics ChargeMetrics { get; set; }

    /// <summary>
    /// Monthly recurring revenue of the subscription. 
    /// </summary>
    /// <value>Monthly recurring revenue of the subscription. </value>
    [DataMember(Name="contractedMrr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractedMrr")]
    public string ContractedMrr { get; set; }

    /// <summary>
    /// Container for invoice items. 
    /// </summary>
    /// <value>Container for invoice items. </value>
    [DataMember(Name="invoiceItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceItems")]
    public List<POSTSubscriptionPreviewInvoiceItemsType> InvoiceItems { get; set; }

    /// <summary>
    /// Date through which charges are calculated on the invoice, as yyyy-mm-dd. 
    /// </summary>
    /// <value>Date through which charges are calculated on the invoice, as yyyy-mm-dd. </value>
    [DataMember(Name="invoiceTargetDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceTargetDate")]
    public DateTime? InvoiceTargetDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="previewChargeMetricsResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previewChargeMetricsResponse")]
    public string PreviewChargeMetricsResponse { get; set; }

    /// <summary>
    /// Returns `true` if the request was processed successfully. 
    /// </summary>
    /// <value>Returns `true` if the request was processed successfully. </value>
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
      sb.Append("class POSTSubscriptionPreviewResponseType {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  AmountWithoutTax: ").Append(AmountWithoutTax).Append("\n");
      sb.Append("  ChargeMetrics: ").Append(ChargeMetrics).Append("\n");
      sb.Append("  ContractedMrr: ").Append(ContractedMrr).Append("\n");
      sb.Append("  InvoiceItems: ").Append(InvoiceItems).Append("\n");
      sb.Append("  InvoiceTargetDate: ").Append(InvoiceTargetDate).Append("\n");
      sb.Append("  PreviewChargeMetricsResponse: ").Append(PreviewChargeMetricsResponse).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
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
