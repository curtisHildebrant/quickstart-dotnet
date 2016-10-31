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
  public class GETSubscriptionTypeWithSuccess {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CpqBundleJsonId__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CpqBundleJsonId__QT")]
    public string CpqBundleJsonIdQT { get; set; }

    /// <summary>
    /// The closing date of the Opportunity. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The closing date of the Opportunity. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="OpportunityCloseDate__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OpportunityCloseDate__QT")]
    public string OpportunityCloseDateQT { get; set; }

    /// <summary>
    /// The unique identifier of the Opportunity. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The unique identifier of the Opportunity. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="OpportunityName__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OpportunityName__QT")]
    public string OpportunityNameQT { get; set; }

    /// <summary>
    /// The specific identifier for the type of business transaction the Quote represents such as New, Upsell, Downsell, Renewal, or Churn. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The specific identifier for the type of business transaction the Quote represents such as New, Upsell, Downsell, Renewal, or Churn. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="QuoteBusinessType__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteBusinessType__QT")]
    public string QuoteBusinessTypeQT { get; set; }

    /// <summary>
    /// The unique identifier of the Quote. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.  See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The unique identifier of the Quote. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.  See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="QuoteNumber__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteNumber__QT")]
    public string QuoteNumberQT { get; set; }

    /// <summary>
    /// The Quote type that represents the subscription lifecycle stage such as New, Amendment, Renew or Cancel. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The Quote type that represents the subscription lifecycle stage such as New, Amendment, Renew or Cancel. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="QuoteType__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteType__QT")]
    public string QuoteTypeQT { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public string AccountId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="accountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="accountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// If `true`, the subscription automatically renews at the end of the term. Default is `false`. 
    /// </summary>
    /// <value>If `true`, the subscription automatically renews at the end of the term. Default is `false`. </value>
    [DataMember(Name="autoRenew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoRenew")]
    public bool? AutoRenew { get; set; }

    /// <summary>
    /// Effective contract date for this subscription, as yyyy-mm-dd. 
    /// </summary>
    /// <value>Effective contract date for this subscription, as yyyy-mm-dd. </value>
    [DataMember(Name="contractEffectiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractEffectiveDate")]
    public DateTime? ContractEffectiveDate { get; set; }

    /// <summary>
    /// Monthly recurring revenue of the subscription. 
    /// </summary>
    /// <value>Monthly recurring revenue of the subscription. </value>
    [DataMember(Name="contractedMrr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractedMrr")]
    public string ContractedMrr { get; set; }

    /// <summary>
    /// The length of the period for the current subscription term. 
    /// </summary>
    /// <value>The length of the period for the current subscription term. </value>
    [DataMember(Name="currentTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentTerm")]
    public long? CurrentTerm { get; set; }

    /// <summary>
    /// The period type for the current subscription term.  Values are:  * `Month` (default) * `Year` * `Day` * `Week` 
    /// </summary>
    /// <value>The period type for the current subscription term.  Values are:  * `Month` (default) * `Year` * `Day` * `Week` </value>
    [DataMember(Name="currentTermPeriodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentTermPeriodType")]
    public string CurrentTermPeriodType { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// The date on which the services or products within a subscription have been accepted by the customer, as yyyy-mm-dd. 
    /// </summary>
    /// <value>The date on which the services or products within a subscription have been accepted by the customer, as yyyy-mm-dd. </value>
    [DataMember(Name="customerAcceptanceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customerAcceptanceDate")]
    public DateTime? CustomerAcceptanceDate { get; set; }

    /// <summary>
    /// Subscription ID. 
    /// </summary>
    /// <value>Subscription ID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The length of the period for the first subscription term. 
    /// </summary>
    /// <value>The length of the period for the first subscription term. </value>
    [DataMember(Name="initialTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initialTerm")]
    public long? InitialTerm { get; set; }

    /// <summary>
    /// The period type for the first subscription term.  Values are:  * `Month` (default) * `Year` * `Day` * `Week` 
    /// </summary>
    /// <value>The period type for the first subscription term.  Values are:  * `Month` (default) * `Year` * `Day` * `Week` </value>
    [DataMember(Name="initialTermPeriodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initialTermPeriodType")]
    public string InitialTermPeriodType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="invoiceOwnerAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceOwnerAccountId")]
    public string InvoiceOwnerAccountId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="invoiceOwnerAccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceOwnerAccountName")]
    public string InvoiceOwnerAccountName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="invoiceOwnerAccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceOwnerAccountNumber")]
    public string InvoiceOwnerAccountNumber { get; set; }

    /// <summary>
    /// Separates a single subscription from other subscriptions and creates an invoice for the subscription.   If the value is `true`, the subscription is billed separately from other subscriptions. If the value is `false`, the subscription is included with other subscriptions in the account invoice. 
    /// </summary>
    /// <value>Separates a single subscription from other subscriptions and creates an invoice for the subscription.   If the value is `true`, the subscription is billed separately from other subscriptions. If the value is `false`, the subscription is included with other subscriptions in the account invoice. </value>
    [DataMember(Name="invoiceSeparately", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceSeparately")]
    public string InvoiceSeparately { get; set; }

    /// <summary>
    /// A string of up to 65,535 characters. 
    /// </summary>
    /// <value>A string of up to 65,535 characters. </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// Internal process ID to assist Zuora support.
    /// </summary>
    /// <value>Internal process ID to assist Zuora support.</value>
    [DataMember(Name="processId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processId")]
    public string ProcessId { get; set; }

    /// <summary>
    /// Container for rate plans. 
    /// </summary>
    /// <value>Container for rate plans. </value>
    [DataMember(Name="ratePlans", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratePlans")]
    public List<GETSubscriptionRatePlanType> RatePlans { get; set; }

    /// <summary>
    /// Information on one or more reasons for a failed result.
    /// </summary>
    /// <value>Information on one or more reasons for a failed result.</value>
    [DataMember(Name="reasons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reasons")]
    public List<ErrorCodeType> Reasons { get; set; }

    /// <summary>
    /// Specifies whether a termed subscription will remain `TERMED` or change to `EVERGREEN` when it is renewed.   Values are:  * `RENEW_WITH_SPECIFIC_TERM` (default) * `RENEW_TO_EVERGREEN` 
    /// </summary>
    /// <value>Specifies whether a termed subscription will remain `TERMED` or change to `EVERGREEN` when it is renewed.   Values are:  * `RENEW_WITH_SPECIFIC_TERM` (default) * `RENEW_TO_EVERGREEN` </value>
    [DataMember(Name="renewalSetting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewalSetting")]
    public string RenewalSetting { get; set; }

    /// <summary>
    /// The length of the period for the subscription renewal term. 
    /// </summary>
    /// <value>The length of the period for the subscription renewal term. </value>
    [DataMember(Name="renewalTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewalTerm")]
    public long? RenewalTerm { get; set; }

    /// <summary>
    /// The period type for the subscription renewal term.  Values are:  * `Month` (default) * `Year` * `Day` * `Week` 
    /// </summary>
    /// <value>The period type for the subscription renewal term.  Values are:  * `Month` (default) * `Year` * `Day` * `Week` </value>
    [DataMember(Name="renewalTermPeriodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewalTermPeriodType")]
    public string RenewalTermPeriodType { get; set; }

    /// <summary>
    /// The date on which the services or products within a subscription have been activated and access has been provided to the customer, as yyyy-mm-dd 
    /// </summary>
    /// <value>The date on which the services or products within a subscription have been activated and access has been provided to the customer, as yyyy-mm-dd </value>
    [DataMember(Name="serviceActivationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceActivationDate")]
    public DateTime? ServiceActivationDate { get; set; }

    /// <summary>
    /// Subscription status; possible values are:  * `Draft` * `PendingActivation` * `PendingAcceptance` * `Active` * `Cancelled` * `Suspended` (This value is in Limited Availability.) 
    /// </summary>
    /// <value>Subscription status; possible values are:  * `Draft` * `PendingActivation` * `PendingAcceptance` * `Active` * `Cancelled` * `Suspended` (This value is in Limited Availability.) </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="subscriptionNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionNumber")]
    public string SubscriptionNumber { get; set; }

    /// <summary>
    /// Date the subscription becomes effective. 
    /// </summary>
    /// <value>Date the subscription becomes effective. </value>
    [DataMember(Name="subscriptionStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionStartDate")]
    public DateTime? SubscriptionStartDate { get; set; }

    /// <summary>
    /// Returns `true` if successful, otherwise `false. 
    /// </summary>
    /// <value>Returns `true` if successful, otherwise `false. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// Date the subscription term ends. If the subscription is evergreen, this is null or is the cancellation date (if one has been set). 
    /// </summary>
    /// <value>Date the subscription term ends. If the subscription is evergreen, this is null or is the cancellation date (if one has been set). </value>
    [DataMember(Name="termEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "termEndDate")]
    public DateTime? TermEndDate { get; set; }

    /// <summary>
    /// Date the subscription term begins. If this is a renewal subscription, this date is different from the subscription start date. 
    /// </summary>
    /// <value>Date the subscription term begins. If this is a renewal subscription, this date is different from the subscription start date. </value>
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
    /// Total contracted value of the subscription. 
    /// </summary>
    /// <value>Total contracted value of the subscription. </value>
    [DataMember(Name="totalContractedValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalContractedValue")]
    public string TotalContractedValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETSubscriptionTypeWithSuccess {\n");
      sb.Append("  CpqBundleJsonIdQT: ").Append(CpqBundleJsonIdQT).Append("\n");
      sb.Append("  OpportunityCloseDateQT: ").Append(OpportunityCloseDateQT).Append("\n");
      sb.Append("  OpportunityNameQT: ").Append(OpportunityNameQT).Append("\n");
      sb.Append("  QuoteBusinessTypeQT: ").Append(QuoteBusinessTypeQT).Append("\n");
      sb.Append("  QuoteNumberQT: ").Append(QuoteNumberQT).Append("\n");
      sb.Append("  QuoteTypeQT: ").Append(QuoteTypeQT).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
      sb.Append("  ContractEffectiveDate: ").Append(ContractEffectiveDate).Append("\n");
      sb.Append("  ContractedMrr: ").Append(ContractedMrr).Append("\n");
      sb.Append("  CurrentTerm: ").Append(CurrentTerm).Append("\n");
      sb.Append("  CurrentTermPeriodType: ").Append(CurrentTermPeriodType).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  CustomerAcceptanceDate: ").Append(CustomerAcceptanceDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InitialTerm: ").Append(InitialTerm).Append("\n");
      sb.Append("  InitialTermPeriodType: ").Append(InitialTermPeriodType).Append("\n");
      sb.Append("  InvoiceOwnerAccountId: ").Append(InvoiceOwnerAccountId).Append("\n");
      sb.Append("  InvoiceOwnerAccountName: ").Append(InvoiceOwnerAccountName).Append("\n");
      sb.Append("  InvoiceOwnerAccountNumber: ").Append(InvoiceOwnerAccountNumber).Append("\n");
      sb.Append("  InvoiceSeparately: ").Append(InvoiceSeparately).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
      sb.Append("  RatePlans: ").Append(RatePlans).Append("\n");
      sb.Append("  Reasons: ").Append(Reasons).Append("\n");
      sb.Append("  RenewalSetting: ").Append(RenewalSetting).Append("\n");
      sb.Append("  RenewalTerm: ").Append(RenewalTerm).Append("\n");
      sb.Append("  RenewalTermPeriodType: ").Append(RenewalTermPeriodType).Append("\n");
      sb.Append("  ServiceActivationDate: ").Append(ServiceActivationDate).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  SubscriptionNumber: ").Append(SubscriptionNumber).Append("\n");
      sb.Append("  SubscriptionStartDate: ").Append(SubscriptionStartDate).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  TermEndDate: ").Append(TermEndDate).Append("\n");
      sb.Append("  TermStartDate: ").Append(TermStartDate).Append("\n");
      sb.Append("  TermType: ").Append(TermType).Append("\n");
      sb.Append("  TotalContractedValue: ").Append(TotalContractedValue).Append("\n");
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
