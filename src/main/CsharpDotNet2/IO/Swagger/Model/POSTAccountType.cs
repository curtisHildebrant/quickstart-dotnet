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
  public class POSTAccountType {
    /// <summary>
    /// A unique account number, up to 50 characters that do not begin with the default account number prefix.  If no account number is specified, one is generated. 
    /// </summary>
    /// <value>A unique account number, up to 50 characters that do not begin with the default account number prefix.  If no account number is specified, one is generated. </value>
    [DataMember(Name="accountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Applies a credit balance to an invoice.   If the value is `true`, the credit balance is applied to the invoice. If the value is `false`, no action is taken.  Prerequisite: `invoice` must be `true`.   **Note:** If you are using the field `invoiceCollect` rather than the field `invoice`, the `invoiceCollect` value must be `true`.  To view the credit balance adjustment, retrieve the details of the invoice using the Get Invoices method. 
    /// </summary>
    /// <value>Applies a credit balance to an invoice.   If the value is `true`, the credit balance is applied to the invoice. If the value is `false`, no action is taken.  Prerequisite: `invoice` must be `true`.   **Note:** If you are using the field `invoiceCollect` rather than the field `invoice`, the `invoiceCollect` value must be `true`.  To view the credit balance adjustment, retrieve the details of the invoice using the Get Invoices method. </value>
    [DataMember(Name="applyCreditBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applyCreditBalance")]
    public bool? ApplyCreditBalance { get; set; }

    /// <summary>
    /// Specifies whether future payments are to be automatically billed when they are due. Possible values are: `true`, `false`. 
    /// </summary>
    /// <value>Specifies whether future payments are to be automatically billed when they are due. Possible values are: `true`, `false`. </value>
    [DataMember(Name="autoPay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoPay")]
    public bool? AutoPay { get; set; }

    /// <summary>
    /// The alias name given to a batch. A string of 50 characters or less. 
    /// </summary>
    /// <value>The alias name given to a batch. A string of 50 characters or less. </value>
    [DataMember(Name="batch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "batch")]
    public string Batch { get; set; }

    /// <summary>
    /// The account's bill cycle day (BCD), when bill runs generate invoices for the account.  Specify any day of the month (1-31, where 31 = end-of-month), or 0 for auto-set.  Required if no subscription will be created.   Optional if a subscription is created and defaults to the day-of-the-month of the subscription's `contractEffectiveDate`. 
    /// </summary>
    /// <value>The account's bill cycle day (BCD), when bill runs generate invoices for the account.  Specify any day of the month (1-31, where 31 = end-of-month), or 0 for auto-set.  Required if no subscription will be created.   Optional if a subscription is created and defaults to the day-of-the-month of the subscription's `contractEffectiveDate`. </value>
    [DataMember(Name="billCycleDay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billCycleDay")]
    public long? BillCycleDay { get; set; }

    /// <summary>
    /// Gets or Sets BillToContact
    /// </summary>
    [DataMember(Name="billToContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billToContact")]
    public POSTAccountTypeBillToContact BillToContact { get; set; }

    /// <summary>
    /// Collects an automatic payment for a subscription. The collection generated in this operation is only for this subscription, not for the entire customer account.  If the value is `true`, the automatic payment is collected. If the value is `false`, no action is taken.  The default value is `true`.  Prerequisite: invoice must be `true`.   **Note:** This field is in Zuora REST API version control. Supported minor versions are 196.0 or later. To use this field in the method, you must set the `zuora-version` parameter to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information. 
    /// </summary>
    /// <value>Collects an automatic payment for a subscription. The collection generated in this operation is only for this subscription, not for the entire customer account.  If the value is `true`, the automatic payment is collected. If the value is `false`, no action is taken.  The default value is `true`.  Prerequisite: invoice must be `true`.   **Note:** This field is in Zuora REST API version control. Supported minor versions are 196.0 or later. To use this field in the method, you must set the `zuora-version` parameter to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information. </value>
    [DataMember(Name="collect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collect")]
    public string Collect { get; set; }

    /// <summary>
    /// The ID of a [communication profile](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Communication_Profile).  
    /// </summary>
    /// <value>The ID of a [communication profile](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Communication_Profile).  </value>
    [DataMember(Name="communicationProfileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "communicationProfileId")]
    public string CommunicationProfileId { get; set; }

    /// <summary>
    /// Gets or Sets CreditCard
    /// </summary>
    [DataMember(Name="creditCard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creditCard")]
    public POSTAccountTypeCreditCard CreditCard { get; set; }

    /// <summary>
    /// CRM account ID for the account, up to 100 characters. 
    /// </summary>
    /// <value>CRM account ID for the account, up to 100 characters. </value>
    [DataMember(Name="crmId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "crmId")]
    public string CrmId { get; set; }

    /// <summary>
    /// A currency as defined in [Billing Settings in the Zuora UI](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Customize_Currencies). 
    /// </summary>
    /// <value>A currency as defined in [Billing Settings in the Zuora UI](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Customize_Currencies). </value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// The ID of the HPM credit card payment method associated with this account. You must provide either this field or the `creditCard` structure, but not both.  **Note:** Non-credit card payment methods are not supported. 
    /// </summary>
    /// <value>The ID of the HPM credit card payment method associated with this account. You must provide either this field or the `creditCard` structure, but not both.  **Note:** Non-credit card payment methods are not supported. </value>
    [DataMember(Name="hpmCreditCardPaymentMethodId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hpmCreditCardPaymentMethodId")]
    public string HpmCreditCardPaymentMethodId { get; set; }

    /// <summary>
    /// Creates an invoice for a subscription. The invoice generated in this operation is only for this subscription, not for the entire customer account.  If the value is `true`, an invoice is created. If the value is `false`, no action is taken.  The default value is `true`.   **Note:** This field is in Zuora REST API version control. Supported minor versions are 196.0 or later. To use this field in the method, you must set the `zuora-version` parameter to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information. 
    /// </summary>
    /// <value>Creates an invoice for a subscription. The invoice generated in this operation is only for this subscription, not for the entire customer account.  If the value is `true`, an invoice is created. If the value is `false`, no action is taken.  The default value is `true`.   **Note:** This field is in Zuora REST API version control. Supported minor versions are 196.0 or later. To use this field in the method, you must set the `zuora-version` parameter to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information. </value>
    [DataMember(Name="invoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice")]
    public string Invoice { get; set; }

    /// <summary>
    /// **Note:** This field has been replaced by the `invoice` field and the `collect` field. `invoiceCollect` is available only for backward compatibility.  If `true` (default), and a subscription is created, an invoice is generated at account creation time and payment is immediately collected using the account's default payment method.  This field is in Zuora REST API version control. Supported minor versions are 186.0, 187.0, 188.0, 189.0, and 196.0. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information. 
    /// </summary>
    /// <value>**Note:** This field has been replaced by the `invoice` field and the `collect` field. `invoiceCollect` is available only for backward compatibility.  If `true` (default), and a subscription is created, an invoice is generated at account creation time and payment is immediately collected using the account's default payment method.  This field is in Zuora REST API version control. Supported minor versions are 186.0, 187.0, 188.0, 189.0, and 196.0. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics) for more information. </value>
    [DataMember(Name="invoiceCollect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceCollect")]
    public bool? InvoiceCollect { get; set; }

    /// <summary>
    /// If `invoiceCollect` is true, the target date for the invoice (that is, the date through which charges should be calculated). In `yyyy-mm-dd` format; defaults to the current date. 
    /// </summary>
    /// <value>If `invoiceCollect` is true, the target date for the invoice (that is, the date through which charges should be calculated). In `yyyy-mm-dd` format; defaults to the current date. </value>
    [DataMember(Name="invoiceTargetDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceTargetDate")]
    public DateTime? InvoiceTargetDate { get; set; }

    /// <summary>
    /// Invoice template ID, configured in [Billing Settings in the Zuora UI](https://knowledgecenter.zuora.com/CB_Billing/IA_Invoices/Creating_a_Custom_Invoice_Template). 
    /// </summary>
    /// <value>Invoice template ID, configured in [Billing Settings in the Zuora UI](https://knowledgecenter.zuora.com/CB_Billing/IA_Invoices/Creating_a_Custom_Invoice_Template). </value>
    [DataMember(Name="invoiceTemplateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceTemplateId")]
    public string InvoiceTemplateId { get; set; }

    /// <summary>
    /// Account name, up to 255 characters. 
    /// </summary>
    /// <value>Account name, up to 255 characters. </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A string of up to 65,535 characters. 
    /// </summary>
    /// <value>A string of up to 65,535 characters. </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// The name of the payment gateway instance. If null or left unassigned, the Account will use the Default Gateway. 
    /// </summary>
    /// <value>The name of the payment gateway instance. If null or left unassigned, the Account will use the Default Gateway. </value>
    [DataMember(Name="paymentGateway", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentGateway")]
    public string PaymentGateway { get; set; }

    /// <summary>
    /// Payment terms for this account. Possible values are: `Due Upon Receipt`, `Net 30`, `Net 60`, `Net 90`. 
    /// </summary>
    /// <value>Payment terms for this account. Possible values are: `Due Upon Receipt`, `Net 30`, `Net 60`, `Net 90`. </value>
    [DataMember(Name="paymentTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentTerm")]
    public string PaymentTerm { get; set; }

    /// <summary>
    /// Gets or Sets SoldToContact
    /// </summary>
    [DataMember(Name="soldToContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "soldToContact")]
    public POSTAccountTypeSoldToContact SoldToContact { get; set; }

    /// <summary>
    /// Gets or Sets Subscription
    /// </summary>
    [DataMember(Name="subscription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription")]
    public POSTAccountTypeSubscription Subscription { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="tagging", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tagging")]
    public string Tagging { get; set; }

    /// <summary>
    /// Gets or Sets TaxInfo
    /// </summary>
    [DataMember(Name="taxInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxInfo")]
    public POSTAccountTypeTaxInfo TaxInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTAccountType {\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  ApplyCreditBalance: ").Append(ApplyCreditBalance).Append("\n");
      sb.Append("  AutoPay: ").Append(AutoPay).Append("\n");
      sb.Append("  Batch: ").Append(Batch).Append("\n");
      sb.Append("  BillCycleDay: ").Append(BillCycleDay).Append("\n");
      sb.Append("  BillToContact: ").Append(BillToContact).Append("\n");
      sb.Append("  Collect: ").Append(Collect).Append("\n");
      sb.Append("  CommunicationProfileId: ").Append(CommunicationProfileId).Append("\n");
      sb.Append("  CreditCard: ").Append(CreditCard).Append("\n");
      sb.Append("  CrmId: ").Append(CrmId).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  HpmCreditCardPaymentMethodId: ").Append(HpmCreditCardPaymentMethodId).Append("\n");
      sb.Append("  Invoice: ").Append(Invoice).Append("\n");
      sb.Append("  InvoiceCollect: ").Append(InvoiceCollect).Append("\n");
      sb.Append("  InvoiceTargetDate: ").Append(InvoiceTargetDate).Append("\n");
      sb.Append("  InvoiceTemplateId: ").Append(InvoiceTemplateId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  PaymentGateway: ").Append(PaymentGateway).Append("\n");
      sb.Append("  PaymentTerm: ").Append(PaymentTerm).Append("\n");
      sb.Append("  SoldToContact: ").Append(SoldToContact).Append("\n");
      sb.Append("  Subscription: ").Append(Subscription).Append("\n");
      sb.Append("  Tagging: ").Append(Tagging).Append("\n");
      sb.Append("  TaxInfo: ").Append(TaxInfo).Append("\n");
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
