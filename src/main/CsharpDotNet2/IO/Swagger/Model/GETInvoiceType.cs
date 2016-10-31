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
  public class GETInvoiceType {
    /// <summary>
    /// Customer account ID. 
    /// </summary>
    /// <value>Customer account ID. </value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public string AccountId { get; set; }

    /// <summary>
    /// Customer account name. 
    /// </summary>
    /// <value>Customer account name. </value>
    [DataMember(Name="accountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Customer account number. 
    /// </summary>
    /// <value>Customer account number. </value>
    [DataMember(Name="accountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Amount of the invoice before adjustments, discounts, and similar items. 
    /// </summary>
    /// <value>Amount of the invoice before adjustments, discounts, and similar items. </value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// Balance remaining due on the invoice (after adjustments, discounts, etc.) 
    /// </summary>
    /// <value>Balance remaining due on the invoice (after adjustments, discounts, etc.) </value>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public string Balance { get; set; }

    /// <summary>
    /// The REST URL of the invoice PDF file. 
    /// </summary>
    /// <value>The REST URL of the invoice PDF file. </value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// User ID of the person who created the invoice. If a bill run generated the invoice, then this is the user ID of person who created the bill run. 
    /// </summary>
    /// <value>User ID of the person who created the invoice. If a bill run generated the invoice, then this is the user ID of person who created the bill run. </value>
    [DataMember(Name="createdBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdBy")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="creditBalanceAdjustmentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creditBalanceAdjustmentAmount")]
    public string CreditBalanceAdjustmentAmount { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Payment due date as _yyyy-mm-dd_. 
    /// </summary>
    /// <value>Payment due date as _yyyy-mm-dd_. </value>
    [DataMember(Name="dueDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dueDate")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Invoice ID. 
    /// </summary>
    /// <value>Invoice ID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Invoice date as _yyyy-mm-dd_ 
    /// </summary>
    /// <value>Invoice date as _yyyy-mm-dd_ </value>
    [DataMember(Name="invoiceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceDate")]
    public DateTime? InvoiceDate { get; set; }

    /// <summary>
    /// Information about the invoice PDF file: 
    /// </summary>
    /// <value>Information about the invoice PDF file: </value>
    [DataMember(Name="invoiceFiles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceFiles")]
    public List<GETInvoiceFileType> InvoiceFiles { get; set; }

    /// <summary>
    /// Information on one or more items on this invoice: 
    /// </summary>
    /// <value>Information on one or more items on this invoice: </value>
    [DataMember(Name="invoiceItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceItems")]
    public List<GETInvoicesInvoiceItemType> InvoiceItems { get; set; }

    /// <summary>
    /// Unique invoice ID, returned as a string. 
    /// </summary>
    /// <value>Unique invoice ID, returned as a string. </value>
    [DataMember(Name="invoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceNumber")]
    public string InvoiceNumber { get; set; }

    /// <summary>
    /// Date through which charges on this invoice are calculated, as _yyyy-mm-dd_. 
    /// </summary>
    /// <value>Date through which charges on this invoice are calculated, as _yyyy-mm-dd_. </value>
    [DataMember(Name="invoiceTargetDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceTargetDate")]
    public DateTime? InvoiceTargetDate { get; set; }

    /// <summary>
    /// Status of the invoice in the system - not the payment status, but the status of the invoice itself. Possible values are: `Posted`, `Draft`, `Canceled`, `Error`. 
    /// </summary>
    /// <value>Status of the invoice in the system - not the payment status, but the status of the invoice itself. Possible values are: `Posted`, `Draft`, `Canceled`, `Error`. </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETInvoiceType {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
      sb.Append("  CreditBalanceAdjustmentAmount: ").Append(CreditBalanceAdjustmentAmount).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  DueDate: ").Append(DueDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
      sb.Append("  InvoiceFiles: ").Append(InvoiceFiles).Append("\n");
      sb.Append("  InvoiceItems: ").Append(InvoiceItems).Append("\n");
      sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
      sb.Append("  InvoiceTargetDate: ").Append(InvoiceTargetDate).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
