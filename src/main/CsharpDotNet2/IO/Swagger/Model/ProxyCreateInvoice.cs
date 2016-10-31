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
  public class ProxyCreateInvoice {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public string AccountId { get; set; }

    /// <summary>
    ///  The amount of the invoice adjustments associated with the invoice. **Character limi**t: 16 **Values**: a valid currency amount 
    /// </summary>
    /// <value> The amount of the invoice adjustments associated with the invoice. **Character limi**t: 16 **Values**: a valid currency amount </value>
    [DataMember(Name="AdjustmentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdjustmentAmount")]
    public double? AdjustmentAmount { get; set; }

    /// <summary>
    ///  Required 
    /// </summary>
    /// <value> Required </value>
    [DataMember(Name="Body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Body")]
    public string Body { get; set; }

    /// <summary>
    ///  The currency amount of the adjustment applied to the customer's credit balance. **Character limit**: 16 **Values**: a valid currency amount This field is only available if the [Zuora Global Support](http://support.zuora.com/) to enable this feature.   
    /// </summary>
    /// <value> The currency amount of the adjustment applied to the customer's credit balance. **Character limit**: 16 **Values**: a valid currency amount This field is only available if the [Zuora Global Support](http://support.zuora.com/) to enable this feature.   </value>
    [DataMember(Name="CreditBalanceAdjustmentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditBalanceAdjustmentAmount")]
    public double? CreditBalanceAdjustmentAmount { get; set; }

    /// <summary>
    ///  Specifies whether the invoice includes one-time charges. You can use this field only with the `generate()` call for the Invoice object. **Character limit**: 5 **Values**: automatically generated from one of the following: `True` (default), `False` 
    /// </summary>
    /// <value> Specifies whether the invoice includes one-time charges. You can use this field only with the `generate()` call for the Invoice object. **Character limit**: 5 **Values**: automatically generated from one of the following: `True` (default), `False` </value>
    [DataMember(Name="IncludesOneTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IncludesOneTime")]
    public bool? IncludesOneTime { get; set; }

    /// <summary>
    ///  Specifies whether the invoice includes recurring charges. You can use this field only with the `generate() `call for the Invoice object. **Character limit**: 5 **Values**: automatically generated from one of the following: `True` (default), `False` 
    /// </summary>
    /// <value> Specifies whether the invoice includes recurring charges. You can use this field only with the `generate() `call for the Invoice object. **Character limit**: 5 **Values**: automatically generated from one of the following: `True` (default), `False` </value>
    [DataMember(Name="IncludesRecurring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IncludesRecurring")]
    public bool? IncludesRecurring { get; set; }

    /// <summary>
    ///  Specifies whether the invoice includes usage charges. You can use this field only with the `generate() `call for the Invoice object. **Character limit**: 5 **Values**: automatically generated from one of the following: `True `(default), `False` 
    /// </summary>
    /// <value> Specifies whether the invoice includes usage charges. You can use this field only with the `generate() `call for the Invoice object. **Character limit**: 5 **Values**: automatically generated from one of the following: `True `(default), `False` </value>
    [DataMember(Name="IncludesUsage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IncludesUsage")]
    public bool? IncludesUsage { get; set; }

    /// <summary>
    ///  Specifies the date on which to generate the invoice. **Character limit**: 29 **Version notes**: -- 
    /// </summary>
    /// <value> Specifies the date on which to generate the invoice. **Character limit**: 29 **Version notes**: -- </value>
    [DataMember(Name="InvoiceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceDate")]
    public DateTime? InvoiceDate { get; set; }

    /// <summary>
    ///  The amount of payments applied to the invoice. **Character limit**: 16 **Value**s: automatically generated 
    /// </summary>
    /// <value> The amount of payments applied to the invoice. **Character limit**: 16 **Value**s: automatically generated </value>
    [DataMember(Name="PaymentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentAmount")]
    public double? PaymentAmount { get; set; }

    /// <summary>
    ///  Specifies the amount of a refund that was applied against an earlier payment on the invoice. **Character limit**: 16 **Values**: automatically generated 
    /// </summary>
    /// <value> Specifies the amount of a refund that was applied against an earlier payment on the invoice. **Character limit**: 16 **Values**: automatically generated </value>
    [DataMember(Name="RefundAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefundAmount")]
    public double? RefundAmount { get; set; }

    /// <summary>
    ///  This date is used to determine which charges are to be billed. All charges that are to be billed on this date or prior will be included in this bill run. **Character limit**: 29 **Version notes**: -- 
    /// </summary>
    /// <value> This date is used to determine which charges are to be billed. All charges that are to be billed on this date or prior will be included in this bill run. **Character limit**: 29 **Version notes**: -- </value>
    [DataMember(Name="TargetDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TargetDate")]
    public DateTime? TargetDate { get; set; }

    /// <summary>
    ///  The total amount of the taxes applied to the invoice. **Character limit**: 16 **Values**: automatically generated 
    /// </summary>
    /// <value> The total amount of the taxes applied to the invoice. **Character limit**: 16 **Values**: automatically generated </value>
    [DataMember(Name="TaxAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    ///  The total amount of the invoice that is exempt from taxation. **Character limit**: 16 **Values**: automatically generated 
    /// </summary>
    /// <value> The total amount of the invoice that is exempt from taxation. **Character limit**: 16 **Values**: automatically generated </value>
    [DataMember(Name="TaxExemptAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxExemptAmount")]
    public double? TaxExemptAmount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyCreateInvoice {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AdjustmentAmount: ").Append(AdjustmentAmount).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  CreditBalanceAdjustmentAmount: ").Append(CreditBalanceAdjustmentAmount).Append("\n");
      sb.Append("  IncludesOneTime: ").Append(IncludesOneTime).Append("\n");
      sb.Append("  IncludesRecurring: ").Append(IncludesRecurring).Append("\n");
      sb.Append("  IncludesUsage: ").Append(IncludesUsage).Append("\n");
      sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
      sb.Append("  PaymentAmount: ").Append(PaymentAmount).Append("\n");
      sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
      sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
      sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
      sb.Append("  TaxExemptAmount: ").Append(TaxExemptAmount).Append("\n");
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
