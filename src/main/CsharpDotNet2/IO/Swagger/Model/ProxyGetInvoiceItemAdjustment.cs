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
  public class ProxyGetInvoiceItemAdjustment {
    /// <summary>
    ///  The ID of the account that owns the invoice. **Values**: inherited from `Account.ID` for the invoice owner 
    /// </summary>
    /// <value> The ID of the account that owns the invoice. **Values**: inherited from `Account.ID` for the invoice owner </value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public string AccountId { get; set; }

    /// <summary>
    ///  The accounting code for the invoice item. Accounting codes group transactions that contain similar accounting attributes. **Character limit**: 100 **Values**: inherited from `InvoiceItem.AccountingCode` 
    /// </summary>
    /// <value> The accounting code for the invoice item. Accounting codes group transactions that contain similar accounting attributes. **Character limit**: 100 **Values**: inherited from `InvoiceItem.AccountingCode` </value>
    [DataMember(Name="AccountingCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountingCode")]
    public string AccountingCode { get; set; }

    /// <summary>
    ///  The date when the invoice item adjustment is applied. This date must be the same as the invoice's date or later. **Character limit**: 29 **Values**: a valid date and time value 
    /// </summary>
    /// <value> The date when the invoice item adjustment is applied. This date must be the same as the invoice's date or later. **Character limit**: 29 **Values**: a valid date and time value </value>
    [DataMember(Name="AdjustmentDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdjustmentDate")]
    public DateTime? AdjustmentDate { get; set; }

    /// <summary>
    ///  A unique string to identify an individual invoice item adjustment. **Character limit**: 255 **Values**: automatically generated 
    /// </summary>
    /// <value> A unique string to identify an individual invoice item adjustment. **Character limit**: 255 **Values**: automatically generated </value>
    [DataMember(Name="AdjustmentNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdjustmentNumber")]
    public string AdjustmentNumber { get; set; }

    /// <summary>
    ///  The amount of the invoice item adjustment. The value of Amount must be positive. Use the required parameter Type to either credit or charge (debit) this amount on the invoice. **Character limit**: 16 **Values**: a valid currency amount 
    /// </summary>
    /// <value> The amount of the invoice item adjustment. The value of Amount must be positive. Use the required parameter Type to either credit or charge (debit) this amount on the invoice. **Character limit**: 16 **Values**: a valid currency amount </value>
    [DataMember(Name="Amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Amount")]
    public double? Amount { get; set; }

    /// <summary>
    ///  The ID of the Zuora user who canceled the invoice item adjustment. Zuora generates this read-only field only if the adjustment is canceled. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the Zuora user who canceled the invoice item adjustment. Zuora generates this read-only field only if the adjustment is canceled. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CancelledById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CancelledById")]
    public string CancelledById { get; set; }

    /// <summary>
    ///  The date when the invoice item adjustment is canceled. Zuora generates this read-only field if this adjustment is canceled. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the invoice item adjustment is canceled. Zuora generates this read-only field if this adjustment is canceled. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="CancelledDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CancelledDate")]
    public DateTime? CancelledDate { get; set; }

    /// <summary>
    ///  Use this field to record comments about the invoice item adjustment. **Character limit**: 255 **Values**: a string of 255 characters or fewer 
    /// </summary>
    /// <value> Use this field to record comments about the invoice item adjustment. **Character limit**: 255 **Values**: a string of 255 characters or fewer </value>
    [DataMember(Name="Comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Comment")]
    public string Comment { get; set; }

    /// <summary>
    ///  The user ID of the person who created the invoice item. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The user ID of the person who created the invoice item. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  The date the invoice item was created. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date the invoice item was created. **Character limit**: 29 **Values**: automatically generated </value>
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
    ///  The ID of the invoice associated with the adjustment. The adjustment invoice item is in this invoice. This field is optional if you specify a value for the `InvoiceNumber` field. **Character limit**: 3 **Values**: a valid invoice ID 
    /// </summary>
    /// <value> The ID of the invoice associated with the adjustment. The adjustment invoice item is in this invoice. This field is optional if you specify a value for the `InvoiceNumber` field. **Character limit**: 3 **Values**: a valid invoice ID </value>
    [DataMember(Name="InvoiceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceId")]
    public string InvoiceId { get; set; }

    /// <summary>
    ///  The name of the invoice item's charge. This field is required in `query()` calls, but is inherited in other calls. **Character limit**: 255 **Values**: inherited from `InvoiceItem.ChargeName` 
    /// </summary>
    /// <value> The name of the invoice item's charge. This field is required in `query()` calls, but is inherited in other calls. **Character limit**: 255 **Values**: inherited from `InvoiceItem.ChargeName` </value>
    [DataMember(Name="InvoiceItemName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceItemName")]
    public string InvoiceItemName { get; set; }

    /// <summary>
    ///  The unique identification number for the invoice that contains the invoice item. This field is optional if you specify a value for the `InvoiceId` field. **Character limit**: 32 **Values**: a valid invoice number 
    /// </summary>
    /// <value> The unique identification number for the invoice that contains the invoice item. This field is optional if you specify a value for the `InvoiceId` field. **Character limit**: 32 **Values**: a valid invoice number </value>
    [DataMember(Name="InvoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceNumber")]
    public string InvoiceNumber { get; set; }

    /// <summary>
    ///  A code identifying the reason for the transaction. Must be an existing reason code or empty. If you do not specify a value, Zuora uses the default reason code. **Character limit**: 32 **V****alues**: a valid reason code 
    /// </summary>
    /// <value> A code identifying the reason for the transaction. Must be an existing reason code or empty. If you do not specify a value, Zuora uses the default reason code. **Character limit**: 32 **V****alues**: a valid reason code </value>
    [DataMember(Name="ReasonCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonCode")]
    public string ReasonCode { get; set; }

    /// <summary>
    ///  A code to reference an object external to Zuora. For example, you can use this field to reference a case number in an external system. **Character limit**: 60 **Values**: a string of 60 characters or fewer 
    /// </summary>
    /// <value> A code to reference an object external to Zuora. For example, you can use this field to reference a case number in an external system. **Character limit**: 60 **Values**: a string of 60 characters or fewer </value>
    [DataMember(Name="ReferenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReferenceId")]
    public string ReferenceId { get; set; }

    /// <summary>
    ///  The end date of the service period associated with the invoice item. Service ends one second before the date in this value. This field is required in query() calls, but is inherited in other calls. **Character limit**: 29 **Values**: inherited from `InvoiceItem.ServiceEndDate` 
    /// </summary>
    /// <value> The end date of the service period associated with the invoice item. Service ends one second before the date in this value. This field is required in query() calls, but is inherited in other calls. **Character limit**: 29 **Values**: inherited from `InvoiceItem.ServiceEndDate` </value>
    [DataMember(Name="ServiceEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceEndDate")]
    public DateTime? ServiceEndDate { get; set; }

    /// <summary>
    ///  The start date of the service period associated with the invoice item. Service ends one second before the date in this value. This field is required in `query()` calls, but is inherited in other calls. **Character limit**: 29 **Values**: inherited from `InvoiceItem.ServiceStartDate` 
    /// </summary>
    /// <value> The start date of the service period associated with the invoice item. Service ends one second before the date in this value. This field is required in `query()` calls, but is inherited in other calls. **Character limit**: 29 **Values**: inherited from `InvoiceItem.ServiceStartDate` </value>
    [DataMember(Name="ServiceStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceStartDate")]
    public DateTime? ServiceStartDate { get; set; }

    /// <summary>
    ///  The ID of the item specified in the SourceType field. **Character limit**: 32 **Values**: a valid invoice item ID or taxation item ID 
    /// </summary>
    /// <value> The ID of the item specified in the SourceType field. **Character limit**: 32 **Values**: a valid invoice item ID or taxation item ID </value>
    [DataMember(Name="SourceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SourceId")]
    public string SourceId { get; set; }

    /// <summary>
    ///  The type of adjustment. **Character limit**: 13 **Values**: InvoiceDetail, Tax 
    /// </summary>
    /// <value> The type of adjustment. **Character limit**: 13 **Values**: InvoiceDetail, Tax </value>
    [DataMember(Name="SourceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SourceType")]
    public string SourceType { get; set; }

    /// <summary>
    ///  The status of the invoice item adjustment. This field is required in `query()` calls, but is automatically generated in other calls. **Character limit**: 9 **Values**: Canceled, Processed 
    /// </summary>
    /// <value> The status of the invoice item adjustment. This field is required in `query()` calls, but is automatically generated in other calls. **Character limit**: 9 **Values**: Canceled, Processed </value>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    ///  Indicates the status of the adjustment's transfer to an external accounting system, such as NetSuite. **Character limit**: 10 **Values**: Processing, Yes, Error, Ignore 
    /// </summary>
    /// <value> Indicates the status of the adjustment's transfer to an external accounting system, such as NetSuite. **Character limit**: 10 **Values**: Processing, Yes, Error, Ignore </value>
    [DataMember(Name="TransferredToAccounting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransferredToAccounting")]
    public string TransferredToAccounting { get; set; }

    /// <summary>
    ///  Query Filter 
    /// </summary>
    /// <value> Query Filter </value>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }

    /// <summary>
    ///  The ID of the user who last updated the invoice item. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the user who last updated the invoice item. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    ///  The date when the invoice item was last updated. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the invoice item was last updated. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetInvoiceItemAdjustment {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
      sb.Append("  AdjustmentDate: ").Append(AdjustmentDate).Append("\n");
      sb.Append("  AdjustmentNumber: ").Append(AdjustmentNumber).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  CancelledById: ").Append(CancelledById).Append("\n");
      sb.Append("  CancelledDate: ").Append(CancelledDate).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  InvoiceItemName: ").Append(InvoiceItemName).Append("\n");
      sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
      sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
      sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
      sb.Append("  ServiceEndDate: ").Append(ServiceEndDate).Append("\n");
      sb.Append("  ServiceStartDate: ").Append(ServiceStartDate).Append("\n");
      sb.Append("  SourceId: ").Append(SourceId).Append("\n");
      sb.Append("  SourceType: ").Append(SourceType).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
