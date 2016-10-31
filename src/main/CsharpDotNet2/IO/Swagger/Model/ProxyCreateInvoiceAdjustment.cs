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
  public class ProxyCreateInvoiceAdjustment {
    /// <summary>
    ///  The ID of the account that owns the invoice. **Character limit**: 32 **Values**: inherited from `[Account](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account).ID` for the invoice owner 
    /// </summary>
    /// <value> The ID of the account that owns the invoice. **Character limit**: 32 **Values**: inherited from `[Account](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account).ID` for the invoice owner </value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public string AccountId { get; set; }

    /// <summary>
    ///  The [Chart of Accounts](/CA_Billing_and_Payments/C_Billing_and_Payments_Settings/U_Configure_Accounting_Codes/D_Set_Up_Chart_of_Accounts) and is active 
    /// </summary>
    /// <value> The [Chart of Accounts](/CA_Billing_and_Payments/C_Billing_and_Payments_Settings/U_Configure_Accounting_Codes/D_Set_Up_Chart_of_Accounts) and is active </value>
    [DataMember(Name="AccountingCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountingCode")]
    public string AccountingCode { get; set; }

    /// <summary>
    ///  The date when the invoice adjustment is applied. This date must be the same as the invoice's date or later. **Character limit**: 29 **Values**: Leave null to automatically generate the current date 
    /// </summary>
    /// <value> The date when the invoice adjustment is applied. This date must be the same as the invoice's date or later. **Character limit**: 29 **Values**: Leave null to automatically generate the current date </value>
    [DataMember(Name="AdjustmentDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdjustmentDate")]
    public DateTime? AdjustmentDate { get; set; }

    /// <summary>
    ///  A unique string to identify an individual invoice adjustment. **Character limit**: 255 **Values**: automatically generated 
    /// </summary>
    /// <value> A unique string to identify an individual invoice adjustment. **Character limit**: 255 **Values**: automatically generated </value>
    [DataMember(Name="AdjustmentNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdjustmentNumber")]
    public string AdjustmentNumber { get; set; }

    /// <summary>
    ///  The amount of the invoice adjustment. **Character limit**: 16 **Values**: a valid currency amount 
    /// </summary>
    /// <value> The amount of the invoice adjustment. **Character limit**: 16 **Values**: a valid currency amount </value>
    [DataMember(Name="Amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Amount")]
    public double? Amount { get; set; }

    /// <summary>
    ///  Use this field to record comments about the invoice adjustment. **Character limit**: 255 **Values**: a string of 255 characters or fewer 
    /// </summary>
    /// <value> Use this field to record comments about the invoice adjustment. **Character limit**: 255 **Values**: a string of 255 characters or fewer </value>
    [DataMember(Name="Comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Comments")]
    public string Comments { get; set; }

    /// <summary>
    ///  The name of the account that owns the associated invoice. **Character limit**: 50 **Values**: inherited from `[Account](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account).Name` 
    /// </summary>
    /// <value> The name of the account that owns the associated invoice. **Character limit**: 50 **Values**: inherited from `[Account](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account).Name` </value>
    [DataMember(Name="CustomerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerName")]
    public string CustomerName { get; set; }

    /// <summary>
    ///  The unique account number of the customer's account. **Character limit**: 70 **Values**: inherited from `[Account](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account).AccountNumber` 
    /// </summary>
    /// <value> The unique account number of the customer's account. **Character limit**: 70 **Values**: inherited from `[Account](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account).AccountNumber` </value>
    [DataMember(Name="CustomerNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerNumber")]
    public string CustomerNumber { get; set; }

    /// <summary>
    ///  The amount that changes the balance of the associated invoice. **Character limit**: 16 **Values**: automatically calculated 
    /// </summary>
    /// <value> The amount that changes the balance of the associated invoice. **Character limit**: 16 **Values**: automatically calculated </value>
    [DataMember(Name="ImpactAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ImpactAmount")]
    public double? ImpactAmount { get; set; }

    /// <summary>
    ///  The ID of the invoice associated with the adjustment. This field is required if you don't specify a value for the `InvoiceNumber` field. **Character limit**: 32 **Values**: [a valid invoice ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Invoice) 
    /// </summary>
    /// <value> The ID of the invoice associated with the adjustment. This field is required if you don't specify a value for the `InvoiceNumber` field. **Character limit**: 32 **Values**: [a valid invoice ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Invoice) </value>
    [DataMember(Name="InvoiceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceId")]
    public string InvoiceId { get; set; }

    /// <summary>
    ///  The unique identification number for the associated invoice. This field is required if you don't specify a value for the `InvoiceId` field. **Character limit**: 32 **Values**: [a valid invoice number](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Invoice) 
    /// </summary>
    /// <value> The unique identification number for the associated invoice. This field is required if you don't specify a value for the `InvoiceId` field. **Character limit**: 32 **Values**: [a valid invoice number](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Invoice) </value>
    [DataMember(Name="InvoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceNumber")]
    public string InvoiceNumber { get; set; }

    /// <summary>
    ///  A code identifying the reason for the transaction. Must be an existing reason code or empty. If you do not specify a value, Zuora uses the default reason code. **Character limit**: 32 **V****alues**: a valid [reason code](/C_Zuora_User_Guides/A_Billing_and_Payments/R_Reason_Codes_for_Payment_Operations) 
    /// </summary>
    /// <value> A code identifying the reason for the transaction. Must be an existing reason code or empty. If you do not specify a value, Zuora uses the default reason code. **Character limit**: 32 **V****alues**: a valid [reason code](/C_Zuora_User_Guides/A_Billing_and_Payments/R_Reason_Codes_for_Payment_Operations) </value>
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
    ///  The status of the invoice adjustment. This field is required in `query()` calls, but is automatically generated in other calls. **Character limit**: 9 **Values**: `Canceled`, `Processed` 
    /// </summary>
    /// <value> The status of the invoice adjustment. This field is required in `query()` calls, but is automatically generated in other calls. **Character limit**: 9 **Values**: `Canceled`, `Processed` </value>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    ///  Indicates whether the adjustment credits or debits the invoice amount. **Character limit**: 6 **Values**: `Credit`, `Charge` 
    /// </summary>
    /// <value> Indicates whether the adjustment credits or debits the invoice amount. **Character limit**: 6 **Values**: `Credit`, `Charge` </value>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyCreateInvoiceAdjustment {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
      sb.Append("  AdjustmentDate: ").Append(AdjustmentDate).Append("\n");
      sb.Append("  AdjustmentNumber: ").Append(AdjustmentNumber).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
      sb.Append("  CustomerNumber: ").Append(CustomerNumber).Append("\n");
      sb.Append("  ImpactAmount: ").Append(ImpactAmount).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
      sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
      sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
