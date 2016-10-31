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
  public class POSTSubscriptionType {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CpqBundleJsonId__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CpqBundleJsonId__QT")]
    public string CpqBundleJsonIdQT { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="OpportunityCloseDate__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OpportunityCloseDate__QT")]
    public string OpportunityCloseDateQT { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="OpportunityName__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OpportunityName__QT")]
    public string OpportunityNameQT { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="QuoteBusinessType__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteBusinessType__QT")]
    public string QuoteBusinessTypeQT { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="QuoteNumber__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteNumber__QT")]
    public string QuoteNumberQT { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="QuoteType__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteType__QT")]
    public string QuoteTypeQT { get; set; }

    /// <summary>
    /// Customer account number or ID 
    /// </summary>
    /// <value>Customer account number or ID </value>
    [DataMember(Name="accountKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountKey")]
    public string AccountKey { get; set; }

    /// <summary>
    /// Applies a credit balance to an invoice.  If the value is `true`, the credit balance is applied to the invoice. If the value is `false`, no action is taken.  **Prerequisite:** `invoice` must be `true`.   **Note:** If you are using the field `invoiceCollect` rather than the field invoice, the `invoiceCollect` value must be `true`.  To view the credit balance adjustment, retrieve the details of the invoice using the [Get Invoices](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Transactions/GET_invoices) method. 
    /// </summary>
    /// <value>Applies a credit balance to an invoice.  If the value is `true`, the credit balance is applied to the invoice. If the value is `false`, no action is taken.  **Prerequisite:** `invoice` must be `true`.   **Note:** If you are using the field `invoiceCollect` rather than the field invoice, the `invoiceCollect` value must be `true`.  To view the credit balance adjustment, retrieve the details of the invoice using the [Get Invoices](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Transactions/GET_invoices) method. </value>
    [DataMember(Name="applyCreditBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applyCreditBalance")]
    public bool? ApplyCreditBalance { get; set; }

    /// <summary>
    /// If `true`, this subscription automatically renews at the end of the subscription term. Default is `false`. 
    /// </summary>
    /// <value>If `true`, this subscription automatically renews at the end of the subscription term. Default is `false`. </value>
    [DataMember(Name="autoRenew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoRenew")]
    public bool? AutoRenew { get; set; }

    /// <summary>
    /// Collects an automatic payment for a subscription. The collection generated in this operation is only for this subscription, not for the entire customer account. If the value is `true`, the automatic payment is collected. If the value is `false`, no action is taken.  The default value is `true`.  **Prerequisite:** The invoice field must be `true`.   **Note:** This field is in Zuora REST API version control. Supported minor versions are 196.0 or later. To use this field in the method, you must set the `zuora-version` field to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. 
    /// </summary>
    /// <value>Collects an automatic payment for a subscription. The collection generated in this operation is only for this subscription, not for the entire customer account. If the value is `true`, the automatic payment is collected. If the value is `false`, no action is taken.  The default value is `true`.  **Prerequisite:** The invoice field must be `true`.   **Note:** This field is in Zuora REST API version control. Supported minor versions are 196.0 or later. To use this field in the method, you must set the `zuora-version` field to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. </value>
    [DataMember(Name="collect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collect")]
    public bool? Collect { get; set; }

    /// <summary>
    /// Effective contract date for this subscription, as yyyy-mm-dd 
    /// </summary>
    /// <value>Effective contract date for this subscription, as yyyy-mm-dd </value>
    [DataMember(Name="contractEffectiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractEffectiveDate")]
    public DateTime? ContractEffectiveDate { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// The date on which the services or products within a subscription have been accepted by the customer, as yyyy-mm-dd.  Default value is dependent on the value of other fields. See **Notes** section for more details. 
    /// </summary>
    /// <value>The date on which the services or products within a subscription have been accepted by the customer, as yyyy-mm-dd.  Default value is dependent on the value of other fields. See **Notes** section for more details. </value>
    [DataMember(Name="customerAcceptanceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customerAcceptanceDate")]
    public DateTime? CustomerAcceptanceDate { get; set; }

    /// <summary>
    /// The length of the period for the first subscription term. Default is `0`. If `termType` is `TERMED`, then this field is required, and the value must be greater than `0`. If `termType` is `EVERGREEN`, this field is ignored. 
    /// </summary>
    /// <value>The length of the period for the first subscription term. Default is `0`. If `termType` is `TERMED`, then this field is required, and the value must be greater than `0`. If `termType` is `EVERGREEN`, this field is ignored. </value>
    [DataMember(Name="initialTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initialTerm")]
    public long? InitialTerm { get; set; }

    /// <summary>
    /// The period type for the first subscription term.  This field is used with the `InitialTerm` field to specify the initial subscription term.  Values are:  * `Month` (default) * `Year` * `Day` * `Week` 
    /// </summary>
    /// <value>The period type for the first subscription term.  This field is used with the `InitialTerm` field to specify the initial subscription term.  Values are:  * `Month` (default) * `Year` * `Day` * `Week` </value>
    [DataMember(Name="initialTermPeriodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initialTermPeriodType")]
    public string InitialTermPeriodType { get; set; }

    /// <summary>
    /// Creates an invoice for a subscription. The invoice generated in this operation is only for this subscription, not for the entire customer account.  If the value is `true`, an invoice is created. If the value is `false`, no action is taken. The default value is `true`.   This field is in Zuora REST API version control. Supported minor versions are `196.0` or later. To use this field in the method, you must set the zuora-version parameter to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. 
    /// </summary>
    /// <value>Creates an invoice for a subscription. The invoice generated in this operation is only for this subscription, not for the entire customer account.  If the value is `true`, an invoice is created. If the value is `false`, no action is taken. The default value is `true`.   This field is in Zuora REST API version control. Supported minor versions are `196.0` or later. To use this field in the method, you must set the zuora-version parameter to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. </value>
    [DataMember(Name="invoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice")]
    public bool? Invoice { get; set; }

    /// <summary>
    /// **Note:** This field has been replaced by the invoice field and the collect field. invoiceCollect is available only for backward compatibility.  If `true` (default), an invoice is generated and payment collected automatically during the subscription process. If `false`, no invoicing or payment takes place. The invoice generated in this operation is only for this subscription, not for the entire customer account.  This field is in Zuora REST API version control. Supported minor versions are `186.0`, `187.0`, `188.0`, `189.0`, and `196.0`. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. 
    /// </summary>
    /// <value>**Note:** This field has been replaced by the invoice field and the collect field. invoiceCollect is available only for backward compatibility.  If `true` (default), an invoice is generated and payment collected automatically during the subscription process. If `false`, no invoicing or payment takes place. The invoice generated in this operation is only for this subscription, not for the entire customer account.  This field is in Zuora REST API version control. Supported minor versions are `186.0`, `187.0`, `188.0`, `189.0`, and `196.0`. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. </value>
    [DataMember(Name="invoiceCollect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceCollect")]
    public bool? InvoiceCollect { get; set; }

    /// <summary>
    /// Invoice owner account number or ID.  **Note:** This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/). 
    /// </summary>
    /// <value>Invoice owner account number or ID.  **Note:** This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/). </value>
    [DataMember(Name="invoiceOwnerAccountKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceOwnerAccountKey")]
    public string InvoiceOwnerAccountKey { get; set; }

    /// <summary>
    /// Separates a single subscription from other subscriptions and invoices the charge independently.   If the value is `true`, the subscription is billed separately from other subscriptions. If the value is `false`, the subscription is included with other subscriptions in the account invoice.  The default value is `false`.  Prerequisite: The default subscription setting Enable Subscriptions to be Invoiced Separately must be set to Yes. 
    /// </summary>
    /// <value>Separates a single subscription from other subscriptions and invoices the charge independently.   If the value is `true`, the subscription is billed separately from other subscriptions. If the value is `false`, the subscription is included with other subscriptions in the account invoice.  The default value is `false`.  Prerequisite: The default subscription setting Enable Subscriptions to be Invoiced Separately must be set to Yes. </value>
    [DataMember(Name="invoiceSeparately", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceSeparately")]
    public bool? InvoiceSeparately { get; set; }

    /// <summary>
    /// Date through which to calculate charges if an invoice is generated, as yyyy-mm-dd. Default is current date. 
    /// </summary>
    /// <value>Date through which to calculate charges if an invoice is generated, as yyyy-mm-dd. Default is current date. </value>
    [DataMember(Name="invoiceTargetDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceTargetDate")]
    public DateTime? InvoiceTargetDate { get; set; }

    /// <summary>
    /// String of up to 500 characters. 
    /// </summary>
    /// <value>String of up to 500 characters. </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// Specifies whether a termed subscription will remain termed or change to evergreen when it is renewed.  Values:  * `RENEW_WITH_SPECIFIC_TERM` (default) * `RENEW_TO_EVERGREEN` 
    /// </summary>
    /// <value>Specifies whether a termed subscription will remain termed or change to evergreen when it is renewed.  Values:  * `RENEW_WITH_SPECIFIC_TERM` (default) * `RENEW_TO_EVERGREEN` </value>
    [DataMember(Name="renewalSetting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewalSetting")]
    public string RenewalSetting { get; set; }

    /// <summary>
    /// The length of the period for the subscription renewal term. Default is `0`. 
    /// </summary>
    /// <value>The length of the period for the subscription renewal term. Default is `0`. </value>
    [DataMember(Name="renewalTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewalTerm")]
    public long? RenewalTerm { get; set; }

    /// <summary>
    /// The period type for the subscription renewal term.  This field is used with the `renewalTerm` field to specify the subscription renewal term.  Values are:  * `Month` (default) * `Year` * `Day` * `Week` 
    /// </summary>
    /// <value>The period type for the subscription renewal term.  This field is used with the `renewalTerm` field to specify the subscription renewal term.  Values are:  * `Month` (default) * `Year` * `Day` * `Week` </value>
    [DataMember(Name="renewalTermPeriodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewalTermPeriodType")]
    public string RenewalTermPeriodType { get; set; }

    /// <summary>
    /// The date on which the services or products within a subscription have been activated and access has been provided to the customer, as yyyy-mm-dd.  Default value is dependent on the value of other fields. See **Notes** section for more details. 
    /// </summary>
    /// <value>The date on which the services or products within a subscription have been activated and access has been provided to the customer, as yyyy-mm-dd.  Default value is dependent on the value of other fields. See **Notes** section for more details. </value>
    [DataMember(Name="serviceActivationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceActivationDate")]
    public DateTime? ServiceActivationDate { get; set; }

    /// <summary>
    /// Container for one or more rate plans for this subscription. 
    /// </summary>
    /// <value>Container for one or more rate plans for this subscription. </value>
    [DataMember(Name="subscribeToRatePlans", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscribeToRatePlans")]
    public List<POSTSrpCreateType> SubscribeToRatePlans { get; set; }

    /// <summary>
    /// Subscription Number. The value can be up to 1000 characters.  If you do not specify a subscription number when creating a subscription, Zuora will generate a subscription number automatically.  If the account is created successfully, the subscription number is returned in the `subscriptionNumber` response field. 
    /// </summary>
    /// <value>Subscription Number. The value can be up to 1000 characters.  If you do not specify a subscription number when creating a subscription, Zuora will generate a subscription number automatically.  If the account is created successfully, the subscription number is returned in the `subscriptionNumber` response field. </value>
    [DataMember(Name="subscriptionNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionNumber")]
    public string SubscriptionNumber { get; set; }

    /// <summary>
    /// The date on which the subscription term begins, as yyyy-mm-dd. If this is a renewal subscription, this date is different from the subscription start date. 
    /// </summary>
    /// <value>The date on which the subscription term begins, as yyyy-mm-dd. If this is a renewal subscription, this date is different from the subscription start date. </value>
    [DataMember(Name="termStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "termStartDate")]
    public DateTime? TermStartDate { get; set; }

    /// <summary>
    /// Possible values are: `TERMED`, `EVERGREEN`. 
    /// </summary>
    /// <value>Possible values are: `TERMED`, `EVERGREEN`. </value>
    [DataMember(Name="termType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "termType")]
    public string TermType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTSubscriptionType {\n");
      sb.Append("  CpqBundleJsonIdQT: ").Append(CpqBundleJsonIdQT).Append("\n");
      sb.Append("  OpportunityCloseDateQT: ").Append(OpportunityCloseDateQT).Append("\n");
      sb.Append("  OpportunityNameQT: ").Append(OpportunityNameQT).Append("\n");
      sb.Append("  QuoteBusinessTypeQT: ").Append(QuoteBusinessTypeQT).Append("\n");
      sb.Append("  QuoteNumberQT: ").Append(QuoteNumberQT).Append("\n");
      sb.Append("  QuoteTypeQT: ").Append(QuoteTypeQT).Append("\n");
      sb.Append("  AccountKey: ").Append(AccountKey).Append("\n");
      sb.Append("  ApplyCreditBalance: ").Append(ApplyCreditBalance).Append("\n");
      sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
      sb.Append("  Collect: ").Append(Collect).Append("\n");
      sb.Append("  ContractEffectiveDate: ").Append(ContractEffectiveDate).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  CustomerAcceptanceDate: ").Append(CustomerAcceptanceDate).Append("\n");
      sb.Append("  InitialTerm: ").Append(InitialTerm).Append("\n");
      sb.Append("  InitialTermPeriodType: ").Append(InitialTermPeriodType).Append("\n");
      sb.Append("  Invoice: ").Append(Invoice).Append("\n");
      sb.Append("  InvoiceCollect: ").Append(InvoiceCollect).Append("\n");
      sb.Append("  InvoiceOwnerAccountKey: ").Append(InvoiceOwnerAccountKey).Append("\n");
      sb.Append("  InvoiceSeparately: ").Append(InvoiceSeparately).Append("\n");
      sb.Append("  InvoiceTargetDate: ").Append(InvoiceTargetDate).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  RenewalSetting: ").Append(RenewalSetting).Append("\n");
      sb.Append("  RenewalTerm: ").Append(RenewalTerm).Append("\n");
      sb.Append("  RenewalTermPeriodType: ").Append(RenewalTermPeriodType).Append("\n");
      sb.Append("  ServiceActivationDate: ").Append(ServiceActivationDate).Append("\n");
      sb.Append("  SubscribeToRatePlans: ").Append(SubscribeToRatePlans).Append("\n");
      sb.Append("  SubscriptionNumber: ").Append(SubscriptionNumber).Append("\n");
      sb.Append("  TermStartDate: ").Append(TermStartDate).Append("\n");
      sb.Append("  TermType: ").Append(TermType).Append("\n");
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
