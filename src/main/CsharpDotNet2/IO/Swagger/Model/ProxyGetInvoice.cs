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
  public class ProxyGetInvoice {
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
    ///  The sum of all charges and taxes associated with the invoice. **Character limit**: 16 **Values**: automatically generated 
    /// </summary>
    /// <value> The sum of all charges and taxes associated with the invoice. **Character limit**: 16 **Values**: automatically generated </value>
    [DataMember(Name="Amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Amount")]
    public double? Amount { get; set; }

    /// <summary>
    ///  The sum of all charges associated with the invoice. Taxes are excluded from this value. **Character limit**: 16 **Values**: automatically generated 
    /// </summary>
    /// <value> The sum of all charges associated with the invoice. Taxes are excluded from this value. **Character limit**: 16 **Values**: automatically generated </value>
    [DataMember(Name="AmountWithoutTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AmountWithoutTax")]
    public double? AmountWithoutTax { get; set; }

    /// <summary>
    ///  The remaining balance of the invoice after all payments, adjustments, and refunds are applied. **Character limit**: 16 **Values**: automatically generated 
    /// </summary>
    /// <value> The remaining balance of the invoice after all payments, adjustments, and refunds are applied. **Character limit**: 16 **Values**: automatically generated </value>
    [DataMember(Name="Balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Balance")]
    public double? Balance { get; set; }

    /// <summary>
    ///  Required 
    /// </summary>
    /// <value> Required </value>
    [DataMember(Name="Body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Body")]
    public string Body { get; set; }

    /// <summary>
    ///  Additional information related to the invoice that a Zuora user added to the invoice. **Character limit**: 255 **Values:** a string of 255 characters or fewer 
    /// </summary>
    /// <value> Additional information related to the invoice that a Zuora user added to the invoice. **Character limit**: 255 **Values:** a string of 255 characters or fewer </value>
    [DataMember(Name="Comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Comments")]
    public string Comments { get; set; }

    /// <summary>
    ///  The user ID of the person who created the invoice. If a bill run generated the invoice, then the value is the user ID of person who created the bill run. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The user ID of the person who created the invoice. If a bill run generated the invoice, then the value is the user ID of person who created the bill run. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  The date when the invoice was generated. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the invoice was generated. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    ///  The currency amount of the adjustment applied to the customer's credit balance. **Character limit**: 16 **Values**: a valid currency amount This field is only available if the [Zuora Global Support](http://support.zuora.com/) to enable this feature.   
    /// </summary>
    /// <value> The currency amount of the adjustment applied to the customer's credit balance. **Character limit**: 16 **Values**: a valid currency amount This field is only available if the [Zuora Global Support](http://support.zuora.com/) to enable this feature.   </value>
    [DataMember(Name="CreditBalanceAdjustmentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditBalanceAdjustmentAmount")]
    public double? CreditBalanceAdjustmentAmount { get; set; }

    /// <summary>
    ///  The date by which the payment for this invoice is due. **Character limit**: 29 **Version notes**: -- 
    /// </summary>
    /// <value> The date by which the payment for this invoice is due. **Character limit**: 29 **Version notes**: -- </value>
    [DataMember(Name="DueDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DueDate")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Object identifier.
    /// </summary>
    /// <value>Object identifier.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

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
    ///  The unique identification number for the invoice. This number is returned as a string. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The unique identification number for the invoice. This number is returned as a string. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="InvoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceNumber")]
    public string InvoiceNumber { get; set; }

    /// <summary>
    ///  The date when the invoice was last emailed. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the invoice was last emailed. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="LastEmailSentDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastEmailSentDate")]
    public DateTime? LastEmailSentDate { get; set; }

    /// <summary>
    ///  The amount of payments applied to the invoice. **Character limit**: 16 **Value**s: automatically generated 
    /// </summary>
    /// <value> The amount of payments applied to the invoice. **Character limit**: 16 **Value**s: automatically generated </value>
    [DataMember(Name="PaymentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentAmount")]
    public double? PaymentAmount { get; set; }

    /// <summary>
    ///  The user ID of the person who moved the invoice to Posted status. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The user ID of the person who moved the invoice to Posted status. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="PostedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PostedBy")]
    public string PostedBy { get; set; }

    /// <summary>
    ///  The date when the invoice was posted. **Character limit:** 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the invoice was posted. **Character limit:** 29 **Values**: automatically generated </value>
    [DataMember(Name="PostedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PostedDate")]
    public DateTime? PostedDate { get; set; }

    /// <summary>
    ///  Specifies the amount of a refund that was applied against an earlier payment on the invoice. **Character limit**: 16 **Values**: automatically generated 
    /// </summary>
    /// <value> Specifies the amount of a refund that was applied against an earlier payment on the invoice. **Character limit**: 16 **Values**: automatically generated </value>
    [DataMember(Name="RefundAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefundAmount")]
    public double? RefundAmount { get; set; }

    /// <summary>
    ///  The status of the invoice in the system. This status is not the status of the payment of the invoice, just the status of the invoice itself. **Character limit**: 8 **Values**: one of the following:  -  Draft (default, automatically set upon invoice creation)  -  Posted  -  Canceled  
    /// </summary>
    /// <value> The status of the invoice in the system. This status is not the status of the payment of the invoice, just the status of the invoice itself. **Character limit**: 8 **Values**: one of the following:  -  Draft (default, automatically set upon invoice creation)  -  Posted  -  Canceled  </value>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

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
    ///  Specifies whether or not the invoice was transferred to an external accounting system, such as NetSuite. **Character limit**: 10 **Values**: Processing, Yes, Error, Ignore 
    /// </summary>
    /// <value> Specifies whether or not the invoice was transferred to an external accounting system, such as NetSuite. **Character limit**: 10 **Values**: Processing, Yes, Error, Ignore </value>
    [DataMember(Name="TransferredToAccounting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransferredToAccounting")]
    public string TransferredToAccounting { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    ///  The date when the invoice was last updated. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the invoice was last updated. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetInvoice {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AdjustmentAmount: ").Append(AdjustmentAmount).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  AmountWithoutTax: ").Append(AmountWithoutTax).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreditBalanceAdjustmentAmount: ").Append(CreditBalanceAdjustmentAmount).Append("\n");
      sb.Append("  DueDate: ").Append(DueDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IncludesOneTime: ").Append(IncludesOneTime).Append("\n");
      sb.Append("  IncludesRecurring: ").Append(IncludesRecurring).Append("\n");
      sb.Append("  IncludesUsage: ").Append(IncludesUsage).Append("\n");
      sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
      sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
      sb.Append("  LastEmailSentDate: ").Append(LastEmailSentDate).Append("\n");
      sb.Append("  PaymentAmount: ").Append(PaymentAmount).Append("\n");
      sb.Append("  PostedBy: ").Append(PostedBy).Append("\n");
      sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
      sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
      sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
      sb.Append("  TaxExemptAmount: ").Append(TaxExemptAmount).Append("\n");
      sb.Append("  TransferredToAccounting: ").Append(TransferredToAccounting).Append("\n");
      sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
