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
  public class ProxyCreatePayment {
    /// <summary>
    ///  The unique account ID for the customer that the payment is for. **Character limit**: 32 **Values**: a valid [account ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account) 
    /// </summary>
    /// <value> The unique account ID for the customer that the payment is for. **Character limit**: 32 **Values**: a valid [account ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account) </value>
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
    ///  The amount of the payment. **Character limit**: 16 **Values**: a valid currency value 
    /// </summary>
    /// <value> The amount of the payment. **Character limit**: 16 **Values**: a valid currency value </value>
    [DataMember(Name="Amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Amount")]
    public double? Amount { get; set; }

    /// <summary>
    ///  The amount of the payment to apply to a credit balance. This field is required in a create() call when the `AppliedInvoiceAmount` field value is null. **Character limit**: 16 **Values**: a valid currency value 
    /// </summary>
    /// <value> The amount of the payment to apply to a credit balance. This field is required in a create() call when the `AppliedInvoiceAmount` field value is null. **Character limit**: 16 **Values**: a valid currency value </value>
    [DataMember(Name="AppliedCreditBalanceAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AppliedCreditBalanceAmount")]
    public double? AppliedCreditBalanceAmount { get; set; }

    /// <summary>
    ///  The authorization transaction ID from the payment gateway. Use this field for electronic payments, such as credit cards. **Character limit**: 50 **Values**: a string of 50 characters or fewer 
    /// </summary>
    /// <value> The authorization transaction ID from the payment gateway. Use this field for electronic payments, such as credit cards. **Character limit**: 50 **Values**: a string of 50 characters or fewer </value>
    [DataMember(Name="AuthTransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthTransactionId")]
    public string AuthTransactionId { get; set; }

    /// <summary>
    ///  Additional information related to the payment. **Character limit**: 255 **Values**: a string of 255 characters or fewer 
    /// </summary>
    /// <value> Additional information related to the payment. **Character limit**: 255 **Values**: a string of 255 characters or fewer </value>
    [DataMember(Name="Comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Comment")]
    public string Comment { get; set; }

    /// <summary>
    ///  The date when the payment takes effect. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_Format_and_Datetimes_in_Zuora) 
    /// </summary>
    /// <value> The date when the payment takes effect. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_Format_and_Datetimes_in_Zuora) </value>
    [DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveDate")]
    public DateTime? EffectiveDate { get; set; }

    /// <summary>
    ///  Name of the [gateway](/C_Zuora_User_Guides/A_Billing_and_Payments/M_Payment_Gateways) instance that processes the payment. When creating a Payment, this must be a valid gateway instance name and this gateway must support the specific payment method. If not specified, the default gateway on the Account will be used. 
    /// </summary>
    /// <value> Name of the [gateway](/C_Zuora_User_Guides/A_Billing_and_Payments/M_Payment_Gateways) instance that processes the payment. When creating a Payment, this must be a valid gateway instance name and this gateway must support the specific payment method. If not specified, the default gateway on the Account will be used. </value>
    [DataMember(Name="Gateway", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Gateway")]
    public string Gateway { get; set; }

    /// <summary>
    ///  A merchant-specified natural key value that can be passed to the electronic payment gateway when a payment is created. If not specified, the PaymentNumber will be passed in instead. **Character limit**: 70 **Values**: a string of 70 characters or fewer 
    /// </summary>
    /// <value> A merchant-specified natural key value that can be passed to the electronic payment gateway when a payment is created. If not specified, the PaymentNumber will be passed in instead. **Character limit**: 70 **Values**: a string of 70 characters or fewer </value>
    [DataMember(Name="GatewayOrderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GatewayOrderId")]
    public string GatewayOrderId { get; set; }

    /// <summary>
    ///  The message returned from the payment gateway for the payment. This message is gateway-dependent. **Character limit**: 500 **Values**: automatically generated 
    /// </summary>
    /// <value> The message returned from the payment gateway for the payment. This message is gateway-dependent. **Character limit**: 500 **Values**: automatically generated </value>
    [DataMember(Name="GatewayResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GatewayResponse")]
    public string GatewayResponse { get; set; }

    /// <summary>
    ///  The code returned from the payment gateway for the payment. This code is gateway-dependent. **Character limit**: 20 **Values**: automatically generated 
    /// </summary>
    /// <value> The code returned from the payment gateway for the payment. This code is gateway-dependent. **Character limit**: 20 **Values**: automatically generated </value>
    [DataMember(Name="GatewayResponseCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GatewayResponseCode")]
    public string GatewayResponseCode { get; set; }

    /// <summary>
    ///  The status of the payment in the gateway; use for reconciliation. **Character limit**: 19 **Values**: automatically generated 
    /// </summary>
    /// <value> The status of the payment in the gateway; use for reconciliation. **Character limit**: 19 **Values**: automatically generated </value>
    [DataMember(Name="GatewayState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GatewayState")]
    public string GatewayState { get; set; }

    /// <summary>
    ///  The ID of the payment method used for the payment. Required for Create. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the payment method used for the payment. Required for Create. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="PaymentMethodId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentMethodId")]
    public string PaymentMethodId { get; set; }

    /// <summary>
    ///  The unique identification number of a payment. For example: P-00000028. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The unique identification number of a payment. For example: P-00000028. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="PaymentNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentNumber")]
    public string PaymentNumber { get; set; }

    /// <summary>
    ///  The transaction ID returned by the payment gateway. Use this field to reconcile payments between your gateway and Z-Payments. **Character limit**: 60 **Values**: a string of 60 characters or fewer 
    /// </summary>
    /// <value> The transaction ID returned by the payment gateway. Use this field to reconcile payments between your gateway and Z-Payments. **Character limit**: 60 **Values**: a string of 60 characters or fewer </value>
    [DataMember(Name="ReferenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReferenceId")]
    public string ReferenceId { get; set; }

    /// <summary>
    ///  [A payment gateway-specific field that maps to Zuora for the gateways, Orbital, Vantiv and Verifi](https://knowledgecenter.zuora.com/CB_Billing/M_Payment_Gateways/Supported_Payment_Gateways/Verifi_Global_Payment_Gateway#Soft_Descriptors_(Optional)). **Character limit**: 35 **Values**: `[SDMerchantName]*[SDProductionInfo]` 
    /// </summary>
    /// <value> [A payment gateway-specific field that maps to Zuora for the gateways, Orbital, Vantiv and Verifi](https://knowledgecenter.zuora.com/CB_Billing/M_Payment_Gateways/Supported_Payment_Gateways/Verifi_Global_Payment_Gateway#Soft_Descriptors_(Optional)). **Character limit**: 35 **Values**: `[SDMerchantName]*[SDProductionInfo]` </value>
    [DataMember(Name="SoftDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SoftDescriptor")]
    public string SoftDescriptor { get; set; }

    /// <summary>
    ///  [A payment gateway-specific field that maps to Zuora for the gateways, Orbital, Vantiv and Verifi](https://knowledgecenter.zuora.com/CB_Billing/M_Payment_Gateways/Supported_Payment_Gateways/Verifi_Global_Payment_Gateway#Soft_Descriptors_(Optional)). **Character limit**: 20 **Values**: `[SDPhone]` 
    /// </summary>
    /// <value> [A payment gateway-specific field that maps to Zuora for the gateways, Orbital, Vantiv and Verifi](https://knowledgecenter.zuora.com/CB_Billing/M_Payment_Gateways/Supported_Payment_Gateways/Verifi_Global_Payment_Gateway#Soft_Descriptors_(Optional)). **Character limit**: 20 **Values**: `[SDPhone]` </value>
    [DataMember(Name="SoftDescriptorPhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SoftDescriptorPhone")]
    public string SoftDescriptorPhone { get; set; }

    /// <summary>
    ///  The status of the payment in Zuora. The value depends on the type of payment. **Character limit**: 11 **Values**: one of the following:  -  Electronic payments: `Processed`, `Error`, `Voided`  -  External payments: `Processed`, `Canceled`  See [Troubleshooting Payment Runs](https://knowledgecenter.zuora.com/CB_Billing/K_Payment_Operations/CA_Payment_Runs/Troubleshooting_Payment_Runs) for more information. * Update of status can change value from `Processed` to `Canceled` when the payment type is external. 
    /// </summary>
    /// <value> The status of the payment in Zuora. The value depends on the type of payment. **Character limit**: 11 **Values**: one of the following:  -  Electronic payments: `Processed`, `Error`, `Voided`  -  External payments: `Processed`, `Canceled`  See [Troubleshooting Payment Runs](https://knowledgecenter.zuora.com/CB_Billing/K_Payment_Operations/CA_Payment_Runs/Troubleshooting_Payment_Runs) for more information. * Update of status can change value from `Processed` to `Canceled` when the payment type is external. </value>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    ///  Indicates if the payment is external or electronic. **Character limit**: 10 **Values**: `External`, `Electronic` 
    /// </summary>
    /// <value> Indicates if the payment is external or electronic. **Character limit**: 10 **Values**: `External`, `Electronic` </value>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyCreatePayment {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  AppliedCreditBalanceAmount: ").Append(AppliedCreditBalanceAmount).Append("\n");
      sb.Append("  AuthTransactionId: ").Append(AuthTransactionId).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
      sb.Append("  Gateway: ").Append(Gateway).Append("\n");
      sb.Append("  GatewayOrderId: ").Append(GatewayOrderId).Append("\n");
      sb.Append("  GatewayResponse: ").Append(GatewayResponse).Append("\n");
      sb.Append("  GatewayResponseCode: ").Append(GatewayResponseCode).Append("\n");
      sb.Append("  GatewayState: ").Append(GatewayState).Append("\n");
      sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
      sb.Append("  PaymentNumber: ").Append(PaymentNumber).Append("\n");
      sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
      sb.Append("  SoftDescriptor: ").Append(SoftDescriptor).Append("\n");
      sb.Append("  SoftDescriptorPhone: ").Append(SoftDescriptorPhone).Append("\n");
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
