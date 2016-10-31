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
  public class ProxyGetRefund {
    /// <summary>
    ///  The ID of the [account](/BC_Developers/SOAP_API/E_SOAP_API_Objects/Account) associated with this refund. Specify a value for this field only if you're creating an electronic non-referenced refund. Don't specify a value for any other type of refund; Zuora associates the refund automatically with the account from the associated payment. **Character limit**: 32 **Values**: a valid account ID 
    /// </summary>
    /// <value> The ID of the [account](/BC_Developers/SOAP_API/E_SOAP_API_Objects/Account) associated with this refund. Specify a value for this field only if you're creating an electronic non-referenced refund. Don't specify a value for any other type of refund; Zuora associates the refund automatically with the account from the associated payment. **Character limit**: 32 **Values**: a valid account ID </value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public string AccountId { get; set; }

    /// <summary>
    ///  The accounting code for the payment or invoice line item that the refund applies to. If there is no accounting code, then this value is null. Accounting codes group transactions that contain similar accounting attributes. **Character limit**: 50 **Values**: automatically generated 
    /// </summary>
    /// <value> The accounting code for the payment or invoice line item that the refund applies to. If there is no accounting code, then this value is null. Accounting codes group transactions that contain similar accounting attributes. **Character limit**: 50 **Values**: automatically generated </value>
    [DataMember(Name="AccountingCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountingCode")]
    public string AccountingCode { get; set; }

    /// <summary>
    ///  The amount of the refund. The amount can't exceed the amount of the associated payment. If the original payment was applied to a single invoice, then you can create a partial refund. However, if the payment was applies to multiple invoices, then you can only make a partial refund through the web-based UI, not through the API. **Character limit**: 16 **Values**: a valid currency amount 
    /// </summary>
    /// <value> The amount of the refund. The amount can't exceed the amount of the associated payment. If the original payment was applied to a single invoice, then you can create a partial refund. However, if the payment was applies to multiple invoices, then you can only make a partial refund through the web-based UI, not through the API. **Character limit**: 16 **Values**: a valid currency amount </value>
    [DataMember(Name="Amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Amount")]
    public double? Amount { get; set; }

    /// <summary>
    ///  The date the refund was cancelled. **Values**: automatically generated 
    /// </summary>
    /// <value> The date the refund was cancelled. **Values**: automatically generated </value>
    [DataMember(Name="CancelledOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CancelledOn")]
    public DateTime? CancelledOn { get; set; }

    /// <summary>
    ///  Use this field to record comments about the refund. **Character limit**: 255 **Values**: a string of 255 characters or fewer 
    /// </summary>
    /// <value> Use this field to record comments about the refund. **Character limit**: 255 **Values**: a string of 255 characters or fewer </value>
    [DataMember(Name="Comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Comment")]
    public string Comment { get; set; }

    /// <summary>
    ///  The ID of the Zuora user who created the `Refund` object. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the Zuora user who created the `Refund` object. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  The date when the `Refund` object was created. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the `Refund` object was created. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    ///  The gateway that processed the original payment. Zuora uses this same gateway for the corresponding refund. If this payment gateway is no longer active, then the electronic refund fails. A gateway is an online service provider that connects an online shopping cart to a payment processor. **Values**: automatically inherited from the `Payment` object 
    /// </summary>
    /// <value> The gateway that processed the original payment. Zuora uses this same gateway for the corresponding refund. If this payment gateway is no longer active, then the electronic refund fails. A gateway is an online service provider that connects an online shopping cart to a payment processor. **Values**: automatically inherited from the `Payment` object </value>
    [DataMember(Name="Gateway", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Gateway")]
    public string Gateway { get; set; }

    /// <summary>
    ///  The message returned from the payment gateway for the refund. This message is gateway-dependent. **Character limit**: 500 **Values**: automatically generated 
    /// </summary>
    /// <value> The message returned from the payment gateway for the refund. This message is gateway-dependent. **Character limit**: 500 **Values**: automatically generated </value>
    [DataMember(Name="GatewayResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GatewayResponse")]
    public string GatewayResponse { get; set; }

    /// <summary>
    ///  The code returned from the payment gateway for the payment. This code is gateway-dependent. **Character limit**: 20 **System****Values**: automatically generated 
    /// </summary>
    /// <value> The code returned from the payment gateway for the payment. This code is gateway-dependent. **Character limit**: 20 **System****Values**: automatically generated </value>
    [DataMember(Name="GatewayResponseCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GatewayResponseCode")]
    public string GatewayResponseCode { get; set; }

    /// <summary>
    ///  The status of the payment in the gateway. **Character limit**: 19 **Values**: automatically generated 
    /// </summary>
    /// <value> The status of the payment in the gateway. **Character limit**: 19 **Values**: automatically generated </value>
    [DataMember(Name="GatewayState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GatewayState")]
    public string GatewayState { get; set; }

    /// <summary>
    /// Object identifier.
    /// </summary>
    /// <value>Object identifier.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    ///  The date when a payment was marked and waiting for batch submission to the payment process. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when a payment was marked and waiting for batch submission to the payment process. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="MarkedForSubmissionOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MarkedForSubmissionOn")]
    public DateTime? MarkedForSubmissionOn { get; set; }

    /// <summary>
    ///  Indicates how an external refund was issued to a customer. This field is required for an external refund. You can issue an external refund on an electronic payment. **Character limit**: 30 **Values**:  - `ACH` - `Cash` - `Check` - `CreditCard` - `Other` - `PayPal` - `WireTransfer` - `DebitCard` - `CreditCardReferenceTransaction` 
    /// </summary>
    /// <value> Indicates how an external refund was issued to a customer. This field is required for an external refund. You can issue an external refund on an electronic payment. **Character limit**: 30 **Values**:  - `ACH` - `Cash` - `Check` - `CreditCard` - `Other` - `PayPal` - `WireTransfer` - `DebitCard` - `CreditCardReferenceTransaction` </value>
    [DataMember(Name="MethodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MethodType")]
    public string MethodType { get; set; }

    /// <summary>
    ///  The unique ID of the payment method that the customer used to make the payment. Specify a value for this field only if you're creating an electronic non-referenced refund. **Character limit**: 32 **V****alues**: a valid payment method ID 
    /// </summary>
    /// <value> The unique ID of the payment method that the customer used to make the payment. Specify a value for this field only if you're creating an electronic non-referenced refund. **Character limit**: 32 **V****alues**: a valid payment method ID </value>
    [DataMember(Name="PaymentMethodId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentMethodId")]
    public string PaymentMethodId { get; set; }

    /// <summary>
    ///  The unique ID of the payment method snapshot which is a copy of the particular Payment Method used in a transaction. **Character limit**: 32 **V****alues**: a valid payment method snapshot ID 
    /// </summary>
    /// <value> The unique ID of the payment method snapshot which is a copy of the particular Payment Method used in a transaction. **Character limit**: 32 **V****alues**: a valid payment method snapshot ID </value>
    [DataMember(Name="PaymentMethodSnapshotId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentMethodSnapshotId")]
    public string PaymentMethodSnapshotId { get; set; }

    /// <summary>
    ///  A code identifying the reason for the transaction. Must be an existing reason code or empty. If you do not specify a value, Zuora uses the default reason code. **Character limit**: 32 **V****alues**: a valid reason code 
    /// </summary>
    /// <value> A code identifying the reason for the transaction. Must be an existing reason code or empty. If you do not specify a value, Zuora uses the default reason code. **Character limit**: 32 **V****alues**: a valid reason code </value>
    [DataMember(Name="ReasonCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonCode")]
    public string ReasonCode { get; set; }

    /// <summary>
    ///  The transaction ID returned by the payment gateway for an electronic refund. Use this field to reconcile refunds between your gateway and Z-Payments. **Character limit**: 60 **Values**: a string of 60 characters or fewer 
    /// </summary>
    /// <value> The transaction ID returned by the payment gateway for an electronic refund. Use this field to reconcile refunds between your gateway and Z-Payments. **Character limit**: 60 **Values**: a string of 60 characters or fewer </value>
    [DataMember(Name="ReferenceID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReferenceID")]
    public string ReferenceID { get; set; }

    /// <summary>
    ///  The date of the refund. The date of the refund cannot be before the payment date. Specify this field only for external refunds. Zuora automatically generates this field for electronic refunds. **Character limit**: 29 **Values**: a valid date and time value 
    /// </summary>
    /// <value> The date of the refund. The date of the refund cannot be before the payment date. Specify this field only for external refunds. Zuora automatically generates this field for electronic refunds. **Character limit**: 29 **Values**: a valid date and time value </value>
    [DataMember(Name="RefundDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefundDate")]
    public DateTime? RefundDate { get; set; }

    /// <summary>
    ///  The unique identifier of the refund. **Character limit**: 50 **Values**: automatically generated 
    /// </summary>
    /// <value> The unique identifier of the refund. **Character limit**: 50 **Values**: automatically generated </value>
    [DataMember(Name="RefundNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefundNumber")]
    public string RefundNumber { get; set; }

    /// <summary>
    ///  The date and time when the refund was issued. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date and time when the refund was issued. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="RefundTransactionTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefundTransactionTime")]
    public DateTime? RefundTransactionTime { get; set; }

    /// <summary>
    ///  The transaction ID returned by the payment gateway if there is an additional transaction for the payment. Use this field to reconcile payments between your gateway and Z-Payments. **Character limit**: 60 **Values**: a string of 60 characters or fewer 
    /// </summary>
    /// <value> The transaction ID returned by the payment gateway if there is an additional transaction for the payment. Use this field to reconcile payments between your gateway and Z-Payments. **Character limit**: 60 **Values**: a string of 60 characters or fewer </value>
    [DataMember(Name="SecondRefundReferenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SecondRefundReferenceId")]
    public string SecondRefundReferenceId { get; set; }

    /// <summary>
    ///  The date when the payment was settled in the payment processor. This field is used by the Spectrum gateway only and not applicable to other gateways. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the payment was settled in the payment processor. This field is used by the Spectrum gateway only and not applicable to other gateways. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="SettledOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SettledOn")]
    public DateTime? SettledOn { get; set; }

    /// <summary>
    ///  A payment gateway-specific field that maps Zuora to other gateways . **Character limit**: 35 **Values**:  - 3-byte company identifier &quot;*&quot; 18-byte descriptor - 7-byte company identifier &quot;*&quot; 14-byte descriptor - 12-byte company identifier &quot;*&quot; 9-byte descriptor 
    /// </summary>
    /// <value> A payment gateway-specific field that maps Zuora to other gateways . **Character limit**: 35 **Values**:  - 3-byte company identifier &quot;*&quot; 18-byte descriptor - 7-byte company identifier &quot;*&quot; 14-byte descriptor - 12-byte company identifier &quot;*&quot; 9-byte descriptor </value>
    [DataMember(Name="SoftDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SoftDescriptor")]
    public string SoftDescriptor { get; set; }

    /// <summary>
    ///  A payment gateway-specific field that maps Zuora to other gateways . **Character limit**: 20 **Values**:  - Customer service phone number formatted as: `NNN-NNN-NNNN` or `NNN-AAAAAAA` - URL (non-e-Commerce): Transactions sent with a URL do not qualify for the best interchange rate - Email address 
    /// </summary>
    /// <value> A payment gateway-specific field that maps Zuora to other gateways . **Character limit**: 20 **Values**:  - Customer service phone number formatted as: `NNN-NNN-NNNN` or `NNN-AAAAAAA` - URL (non-e-Commerce): Transactions sent with a URL do not qualify for the best interchange rate - Email address </value>
    [DataMember(Name="SoftDescriptorPhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SoftDescriptorPhone")]
    public string SoftDescriptorPhone { get; set; }

    /// <summary>
    ///  Specifies whether the refund is a refund payment or a credit balance. This field is required when creating an non-referenced refund. If you creating an non-referenced refund, then set this value to `CreditBalance`. **Character limit**: 13 **Values**:  - `Payment` - `CreditBalance` 
    /// </summary>
    /// <value> Specifies whether the refund is a refund payment or a credit balance. This field is required when creating an non-referenced refund. If you creating an non-referenced refund, then set this value to `CreditBalance`. **Character limit**: 13 **Values**:  - `Payment` - `CreditBalance` </value>
    [DataMember(Name="SourceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SourceType")]
    public string SourceType { get; set; }

    /// <summary>
    ///  The status of the refund. **Character limit**: 10 **Values**: automatically generated:  - `Canceled` - `Error` - `Processed` - `Processing` 
    /// </summary>
    /// <value> The status of the refund. **Character limit**: 10 **Values**: automatically generated:  - `Canceled` - `Error` - `Processed` - `Processing` </value>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    ///  The date when the payment was submitted. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the payment was submitted. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="SubmittedOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubmittedOn")]
    public DateTime? SubmittedOn { get; set; }

    /// <summary>
    ///  Specifies whether or not the object has been transferred to an external accounting system. Use this field for integrations with accounting systems such as NetSuite. **Character limit**: 10 **Values**: automatically generated:  - `Processing` - `Yes` - `Error` - `Ignore` 
    /// </summary>
    /// <value> Specifies whether or not the object has been transferred to an external accounting system. Use this field for integrations with accounting systems such as NetSuite. **Character limit**: 10 **Values**: automatically generated:  - `Processing` - `Yes` - `Error` - `Ignore` </value>
    [DataMember(Name="TransferredToAccounting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransferredToAccounting")]
    public string TransferredToAccounting { get; set; }

    /// <summary>
    ///  Specifies if the refund is electronic or external. **Character limit**: 10 **Values**:  - `Electronic` - External 
    /// </summary>
    /// <value> Specifies if the refund is electronic or external. **Character limit**: 10 **Values**:  - `Electronic` - External </value>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }

    /// <summary>
    ///  The ID of the last user to update the object. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the last user to update the object. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    ///  The date when the object was last updated. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the object was last updated. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetRefund {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  CancelledOn: ").Append(CancelledOn).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Gateway: ").Append(Gateway).Append("\n");
      sb.Append("  GatewayResponse: ").Append(GatewayResponse).Append("\n");
      sb.Append("  GatewayResponseCode: ").Append(GatewayResponseCode).Append("\n");
      sb.Append("  GatewayState: ").Append(GatewayState).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  MarkedForSubmissionOn: ").Append(MarkedForSubmissionOn).Append("\n");
      sb.Append("  MethodType: ").Append(MethodType).Append("\n");
      sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
      sb.Append("  PaymentMethodSnapshotId: ").Append(PaymentMethodSnapshotId).Append("\n");
      sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
      sb.Append("  ReferenceID: ").Append(ReferenceID).Append("\n");
      sb.Append("  RefundDate: ").Append(RefundDate).Append("\n");
      sb.Append("  RefundNumber: ").Append(RefundNumber).Append("\n");
      sb.Append("  RefundTransactionTime: ").Append(RefundTransactionTime).Append("\n");
      sb.Append("  SecondRefundReferenceId: ").Append(SecondRefundReferenceId).Append("\n");
      sb.Append("  SettledOn: ").Append(SettledOn).Append("\n");
      sb.Append("  SoftDescriptor: ").Append(SoftDescriptor).Append("\n");
      sb.Append("  SoftDescriptorPhone: ").Append(SoftDescriptorPhone).Append("\n");
      sb.Append("  SourceType: ").Append(SourceType).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  SubmittedOn: ").Append(SubmittedOn).Append("\n");
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
