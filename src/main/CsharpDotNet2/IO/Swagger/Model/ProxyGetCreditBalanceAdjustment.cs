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
  public class ProxyGetCreditBalanceAdjustment {
    /// <summary>
    ///  The account ID of the credit balance's account. Zuora generates this value from the source transaction. **Character limit**: 32 **V****alues**: automatically generated from:  - CreditBalanceAdjustment.SourceTransactionId or - CreditBalanceAdjustment.SourceTransactionNumber 
    /// </summary>
    /// <value> The account ID of the credit balance's account. Zuora generates this value from the source transaction. **Character limit**: 32 **V****alues**: automatically generated from:  - CreditBalanceAdjustment.SourceTransactionId or - CreditBalanceAdjustment.SourceTransactionNumber </value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public string AccountId { get; set; }

    /// <summary>
    ///  The [Chart of Accounts](/CB_Billing/W_Billing_and_Payments_Settings/V_Configure_Accounting_Codes/D_Set_Up_Chart_of_Accounts) 
    /// </summary>
    /// <value> The [Chart of Accounts](/CB_Billing/W_Billing_and_Payments_Settings/V_Configure_Accounting_Codes/D_Set_Up_Chart_of_Accounts) </value>
    [DataMember(Name="AccountingCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountingCode")]
    public string AccountingCode { get; set; }

    /// <summary>
    ///  The date when the credit balance adjustment is applied. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the credit balance adjustment is applied. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="AdjustmentDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdjustmentDate")]
    public DateTime? AdjustmentDate { get; set; }

    /// <summary>
    ///  The amount of the adjustment. **Character limit**: 16 **Values**: a valid currency amount 
    /// </summary>
    /// <value> The amount of the adjustment. **Character limit**: 16 **Values**: a valid currency amount </value>
    [DataMember(Name="Amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Amount")]
    public double? Amount { get; set; }

    /// <summary>
    ///  The date when the credit balance adjustment was canceled. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the credit balance adjustment was canceled. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="CancelledOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CancelledOn")]
    public DateTime? CancelledOn { get; set; }

    /// <summary>
    ///  Use this field to record comments about the credit balance adjustment. **Character limit**: 255 **Values**: a string of 255 characters or fewer 
    /// </summary>
    /// <value> Use this field to record comments about the credit balance adjustment. **Character limit**: 255 **Values**: a string of 255 characters or fewer </value>
    [DataMember(Name="Comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Comment")]
    public string Comment { get; set; }

    /// <summary>
    ///  The user ID of the person who created the credit balance adjustment. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The user ID of the person who created the credit balance adjustment. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  The date when the credit balance adjustmentwas generated. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the credit balance adjustmentwas generated. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Object identifier.
    /// </summary>
    /// <value>Object identifier.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="IntegrationId__NS", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IntegrationId__NS")]
    public string IntegrationIdNS { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="IntegrationStatus__NS", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IntegrationStatus__NS")]
    public string IntegrationStatusNS { get; set; }

    /// <summary>
    ///  A unique identifier for the credit balance adjustment. Zuora generates this number in the format, <em>CBA-xxxxxxxx</em>, such as CBA-00375919. **Character limit**: 255 **Values**: automatically generated 
    /// </summary>
    /// <value> A unique identifier for the credit balance adjustment. Zuora generates this number in the format, <em>CBA-xxxxxxxx</em>, such as CBA-00375919. **Character limit**: 255 **Values**: automatically generated </value>
    [DataMember(Name="Number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Number")]
    public string Number { get; set; }

    /// <summary>
    ///  A code identifying the reason for the transaction. Must be an existing reason code or empty. If you do not specify a value, Zuora uses the default reason code. **Character limit**: 32 **V****alues**: a valid [reason code](/CB_Billing/K_Payment_Operations/Reason_Codes_for_Payment_Operations) 
    /// </summary>
    /// <value> A code identifying the reason for the transaction. Must be an existing reason code or empty. If you do not specify a value, Zuora uses the default reason code. **Character limit**: 32 **V****alues**: a valid [reason code](/CB_Billing/K_Payment_Operations/Reason_Codes_for_Payment_Operations) </value>
    [DataMember(Name="ReasonCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonCode")]
    public string ReasonCode { get; set; }

    /// <summary>
    ///  The ID of the payment that the credit balance adjustment is for. **Character limit**: 32 **Values**: a string of 60 characters or fewer 
    /// </summary>
    /// <value> The ID of the payment that the credit balance adjustment is for. **Character limit**: 32 **Values**: a string of 60 characters or fewer </value>
    [DataMember(Name="ReferenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReferenceId")]
    public string ReferenceId { get; set; }

    /// <summary>
    ///  The ID of the object that the credit balance adjustment is applied to. You must specify a value for either the `SourceTransactionId` field or the `SourceTransactionNumber` field. **Character limit**: 32 **Values**: one of the following:  - InvoiceId - PaymentId - RefundId 
    /// </summary>
    /// <value> The ID of the object that the credit balance adjustment is applied to. You must specify a value for either the `SourceTransactionId` field or the `SourceTransactionNumber` field. **Character limit**: 32 **Values**: one of the following:  - InvoiceId - PaymentId - RefundId </value>
    [DataMember(Name="SourceTransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SourceTransactionId")]
    public string SourceTransactionId { get; set; }

    /// <summary>
    ///  The number of the object that the credit balance adjustment is applied to. You must specify a value for either the `SourceTransactionId` field or the `SourceTransactionNumber` field. **Character limit**: 50 **Values**: one of the following:  - InvoiceNumber - PaymentNumber - RefundNumber 
    /// </summary>
    /// <value> The number of the object that the credit balance adjustment is applied to. You must specify a value for either the `SourceTransactionId` field or the `SourceTransactionNumber` field. **Character limit**: 50 **Values**: one of the following:  - InvoiceNumber - PaymentNumber - RefundNumber </value>
    [DataMember(Name="SourceTransactionNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SourceTransactionNumber")]
    public string SourceTransactionNumber { get; set; }

    /// <summary>
    ///  The source of the credit balance adjustment. **Character limit**: **Values**: automatically generated; one of the following:  - Invoice - Payment - Refund 
    /// </summary>
    /// <value> The source of the credit balance adjustment. **Character limit**: **Values**: automatically generated; one of the following:  - Invoice - Payment - Refund </value>
    [DataMember(Name="SourceTransactionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SourceTransactionType")]
    public string SourceTransactionType { get; set; }

    /// <summary>
    ///  The status of the credit balance adjustment. **Character limit**: 9 **Values**: automatically generated; one of the following:  - Processed - Canceled 
    /// </summary>
    /// <value> The status of the credit balance adjustment. **Character limit**: 9 **Values**: automatically generated; one of the following:  - Processed - Canceled </value>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="SyncDate__NS", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncDate__NS")]
    public string SyncDateNS { get; set; }

    /// <summary>
    ///  Indicates the status of the credit balance adjustment's transfer to an external accounting system, such as NetSuite. **Character limit**: **Values**: one of the following:  - Processing - Yes - Error - Ignore 
    /// </summary>
    /// <value> Indicates the status of the credit balance adjustment's transfer to an external accounting system, such as NetSuite. **Character limit**: **Values**: one of the following:  - Processing - Yes - Error - Ignore </value>
    [DataMember(Name="TransferredToAccounting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransferredToAccounting")]
    public string TransferredToAccounting { get; set; }

    /// <summary>
    /// Create Query Filter
    /// </summary>
    /// <value>Create Query Filter</value>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }

    /// <summary>
    ///  The ID of the user who last updated the credit balance adjustment. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the user who last updated the credit balance adjustment. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    ///  The date when the credit balance adjustment was last updated. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the credit balance adjustment was last updated. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetCreditBalanceAdjustment {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
      sb.Append("  AdjustmentDate: ").Append(AdjustmentDate).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  CancelledOn: ").Append(CancelledOn).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IntegrationIdNS: ").Append(IntegrationIdNS).Append("\n");
      sb.Append("  IntegrationStatusNS: ").Append(IntegrationStatusNS).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
      sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
      sb.Append("  SourceTransactionId: ").Append(SourceTransactionId).Append("\n");
      sb.Append("  SourceTransactionNumber: ").Append(SourceTransactionNumber).Append("\n");
      sb.Append("  SourceTransactionType: ").Append(SourceTransactionType).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  SyncDateNS: ").Append(SyncDateNS).Append("\n");
      sb.Append("  TransferredToAccounting: ").Append(TransferredToAccounting).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
