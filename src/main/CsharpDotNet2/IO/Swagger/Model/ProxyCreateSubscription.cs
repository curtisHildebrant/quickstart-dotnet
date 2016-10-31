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
  public class ProxyCreateSubscription {
    /// <summary>
    ///  This field can be updated when **Status** is `Draft`. The ID of the [a valid account ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account) 
    /// </summary>
    /// <value> This field can be updated when **Status** is `Draft`. The ID of the [a valid account ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account) </value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public string AccountId { get; set; }

    /// <summary>
    ///  This field can be updated when **Status** is `Draft`. Indicates if the subscription automatically renews at the end of the term. **Values**: `true`, `false` 
    /// </summary>
    /// <value> This field can be updated when **Status** is `Draft`. Indicates if the subscription automatically renews at the end of the term. **Values**: `true`, `false` </value>
    [DataMember(Name="AutoRenew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AutoRenew")]
    public bool? AutoRenew { get; set; }

    /// <summary>
    ///  The date of the [Amendment object](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Amendment) that canceled the subscription. **Values**: inherited from `Amendment.EffectiveDate` 
    /// </summary>
    /// <value> The date of the [Amendment object](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Amendment) that canceled the subscription. **Values**: inherited from `Amendment.EffectiveDate` </value>
    [DataMember(Name="CancelledDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CancelledDate")]
    public DateTime? CancelledDate { get; set; }

    /// <summary>
    ///  The date when the customer accepts the contract. This field can be updated when **Status** is `Draft`. **Note**: The service activation date is only required if the [Require Service Activation of Orders?](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Require_Service_Activation_of_Orders.3F) Setting is set to `Yes`. If this setting is set to `Yes`:  - If ContractAcceptanceDate field is required, you must set this field, ContractAcceptanceDate, and ContractEffectiveDate fields in the subscribe call to activate a subscription. - If ContractAcceptanceDate field is not required, you must set both this field and the ContractEffectiveDate field in the subscribe call to activate a subscription. If you only set a valid date in the ContractEffectiveDate field, the subscribe call still returns success, but the subscription is in `DRAT` status. 
    /// </summary>
    /// <value> The date when the customer accepts the contract. This field can be updated when **Status** is `Draft`. **Note**: The service activation date is only required if the [Require Service Activation of Orders?](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Require_Service_Activation_of_Orders.3F) Setting is set to `Yes`. If this setting is set to `Yes`:  - If ContractAcceptanceDate field is required, you must set this field, ContractAcceptanceDate, and ContractEffectiveDate fields in the subscribe call to activate a subscription. - If ContractAcceptanceDate field is not required, you must set both this field and the ContractEffectiveDate field in the subscribe call to activate a subscription. If you only set a valid date in the ContractEffectiveDate field, the subscribe call still returns success, but the subscription is in `DRAT` status. </value>
    [DataMember(Name="ContractAcceptanceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContractAcceptanceDate")]
    public DateTime? ContractAcceptanceDate { get; set; }

    /// <summary>
    ///  The date when the contract takes effect. This field can be updated when **Status** is `Draft`. **Note**: This field is required in the subscribe call. If you set the value of this field to null and both the ServiceActivationDate and ContractAcceptanceDate fields are not required, the subscribe call still returns success, but the new subscription is in `DRAFT` status. To activate the subscription, you must set a valid date to this field. 
    /// </summary>
    /// <value> The date when the contract takes effect. This field can be updated when **Status** is `Draft`. **Note**: This field is required in the subscribe call. If you set the value of this field to null and both the ServiceActivationDate and ContractAcceptanceDate fields are not required, the subscribe call still returns success, but the new subscription is in `DRAFT` status. To activate the subscription, you must set a valid date to this field. </value>
    [DataMember(Name="ContractEffectiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContractEffectiveDate")]
    public DateTime? ContractEffectiveDate { get; set; }

    /// <summary>
    ///  The Bundle product structures from Zuora Quotes if you utilize Bundling in Salesforce. Do not change the value in this field. **Character limit**: 32 **Values**: N/A 
    /// </summary>
    /// <value> The Bundle product structures from Zuora Quotes if you utilize Bundling in Salesforce. Do not change the value in this field. **Character limit**: 32 **Values**: N/A </value>
    [DataMember(Name="CpqBundleJsonId__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CpqBundleJsonId__QT")]
    public string CpqBundleJsonIdQT { get; set; }

    /// <summary>
    ///  The period type for the current subscription term. This field is used with the CurrentTerm field to specify the current subscription term. **Values**:  - `Month` (default) - `Year` - `Day` - `Week` 
    /// </summary>
    /// <value> The period type for the current subscription term. This field is used with the CurrentTerm field to specify the current subscription term. **Values**:  - `Month` (default) - `Year` - `Day` - `Week` </value>
    [DataMember(Name="CurrentTermPeriodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CurrentTermPeriodType")]
    public string CurrentTermPeriodType { get; set; }

    /// <summary>
    ///  The length of the period for the first subscription term. This field can be updated when Status is `Draft`. If you use the subscribe() call, this field is required. **Required**: If TermType is Termed **Character limit**: 20 **Values**: any valid number. The default value is 0. 
    /// </summary>
    /// <value> The length of the period for the first subscription term. This field can be updated when Status is `Draft`. If you use the subscribe() call, this field is required. **Required**: If TermType is Termed **Character limit**: 20 **Values**: any valid number. The default value is 0. </value>
    [DataMember(Name="InitialTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InitialTerm")]
    public int? InitialTerm { get; set; }

    /// <summary>
    ///  The period type for the first subscription term. **Values**:  - `Month` (default) - `Year` - `Day` - `Week` **Note**:  - This field can be updated when Status is `Draft`. - This field is used with the InitialTerm field to specify the initial subscription term. 
    /// </summary>
    /// <value> The period type for the first subscription term. **Values**:  - `Month` (default) - `Year` - `Day` - `Week` **Note**:  - This field can be updated when Status is `Draft`. - This field is used with the InitialTerm field to specify the initial subscription term. </value>
    [DataMember(Name="InitialTermPeriodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InitialTermPeriodType")]
    public string InitialTermPeriodType { get; set; }

    /// <summary>
    ///  This field can be updated when **Status** is `Draft`. The [a valid account ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account) 
    /// </summary>
    /// <value> This field can be updated when **Status** is `Draft`. The [a valid account ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account) </value>
    [DataMember(Name="InvoiceOwnerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceOwnerId")]
    public string InvoiceOwnerId { get; set; }

    /// <summary>
    ///  Determines if the subscription is invoiced separately. If `TRUE`, then all charges for this subscription are collected into the subscription's own invoice. **V****alues**: `TRUE`, `FALSE `(default) 
    /// </summary>
    /// <value> Determines if the subscription is invoiced separately. If `TRUE`, then all charges for this subscription are collected into the subscription's own invoice. **V****alues**: `TRUE`, `FALSE `(default) </value>
    [DataMember(Name="IsInvoiceSeparate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsInvoiceSeparate")]
    public bool? IsInvoiceSeparate { get; set; }

    /// <summary>
    ///  The unique identifier of the subscription. If you don't specify a value, then Zuora generates a name automatically. Whether auto-generated or manually specified, the subscription name must be unique. Otherwise an error will occur. In WSDL 69+, you can change this value only when the subscription is in `Draft` status. Once the subscription is activated, you can't change this value, nor can you use this value for a different subscription. **Character limit**: 100 **Values**: one of the following:  - leave null to automatically generate - a string of 100 characters or fewer 
    /// </summary>
    /// <value> The unique identifier of the subscription. If you don't specify a value, then Zuora generates a name automatically. Whether auto-generated or manually specified, the subscription name must be unique. Otherwise an error will occur. In WSDL 69+, you can change this value only when the subscription is in `Draft` status. Once the subscription is activated, you can't change this value, nor can you use this value for a different subscription. **Character limit**: 100 **Values**: one of the following:  - leave null to automatically generate - a string of 100 characters or fewer </value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    ///  Use this field to record comments about the subscription. **Character limit**: 500 **Values**: a string of 500 characters or fewer 
    /// </summary>
    /// <value> Use this field to record comments about the subscription. **Character limit**: 500 **Values**: a string of 500 characters or fewer </value>
    [DataMember(Name="Notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Notes")]
    public string Notes { get; set; }

    /// <summary>
    ///  The closing date of the Opportunity. This field is used in Zuora Reporting Data Sources to report on Subscription metrics. If the subscription was originated from Zuora Quotes, the value is populated with the value from Zuora Quotes. **Character limit**: **Values**: populated by Zuora Quotes 
    /// </summary>
    /// <value> The closing date of the Opportunity. This field is used in Zuora Reporting Data Sources to report on Subscription metrics. If the subscription was originated from Zuora Quotes, the value is populated with the value from Zuora Quotes. **Character limit**: **Values**: populated by Zuora Quotes </value>
    [DataMember(Name="OpportunityCloseDate__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OpportunityCloseDate__QT")]
    public DateTime? OpportunityCloseDateQT { get; set; }

    /// <summary>
    ///  The unique identifier of the Opportunity. This field is used in the Zuora Reporting Data Sources to report on Subscription metrics. If the subscription was originated from Zuora Quotes, the value is populated with the value from Zuora Quotes. **Character limit**: 100 **Values**: populated by Zuora Quotes 
    /// </summary>
    /// <value> The unique identifier of the Opportunity. This field is used in the Zuora Reporting Data Sources to report on Subscription metrics. If the subscription was originated from Zuora Quotes, the value is populated with the value from Zuora Quotes. **Character limit**: 100 **Values**: populated by Zuora Quotes </value>
    [DataMember(Name="OpportunityName__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OpportunityName__QT")]
    public string OpportunityNameQT { get; set; }

    /// <summary>
    ///  The specific identifier for the type of business transaction the Quote represents such as New, Upsell, Downsell, Renewal or Churn. This field is used in the Zuora Reporting Data Sources to report on Subscription metrics. If the subscription was originated from Zuora Quotes, the value is populated with the value from Zuora Quotes. **Character limit**: 32 **Values**: populated by Zuora Quotes 
    /// </summary>
    /// <value> The specific identifier for the type of business transaction the Quote represents such as New, Upsell, Downsell, Renewal or Churn. This field is used in the Zuora Reporting Data Sources to report on Subscription metrics. If the subscription was originated from Zuora Quotes, the value is populated with the value from Zuora Quotes. **Character limit**: 32 **Values**: populated by Zuora Quotes </value>
    [DataMember(Name="QuoteBusinessType__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteBusinessType__QT")]
    public string QuoteBusinessTypeQT { get; set; }

    /// <summary>
    ///  The unique identifier of the Quote. This field is used in the Zuora Reporting Data Sources to report on Subscription metrics. If the subscription was originated from Zuora Quotes, the value is populated with the value from Zuora Quotes. **Character limit**: 32 **Values**: populated by Zuora Quotes 
    /// </summary>
    /// <value> The unique identifier of the Quote. This field is used in the Zuora Reporting Data Sources to report on Subscription metrics. If the subscription was originated from Zuora Quotes, the value is populated with the value from Zuora Quotes. **Character limit**: 32 **Values**: populated by Zuora Quotes </value>
    [DataMember(Name="QuoteNumber__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteNumber__QT")]
    public string QuoteNumberQT { get; set; }

    /// <summary>
    ///  The Quote type that represents the subscription lifecycle stage such as New, Amendment, Renew or Cancel. This field is used in the Zuora Reporting Data Sources to report on Subscription metrics. If the subscription was originated from Zuora Quotes, the value is populated with the value from Zuora Quotes. **Character limit**: 32 **Values**: populated by Zuora Quotes 
    /// </summary>
    /// <value> The Quote type that represents the subscription lifecycle stage such as New, Amendment, Renew or Cancel. This field is used in the Zuora Reporting Data Sources to report on Subscription metrics. If the subscription was originated from Zuora Quotes, the value is populated with the value from Zuora Quotes. **Character limit**: 32 **Values**: populated by Zuora Quotes </value>
    [DataMember(Name="QuoteType__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteType__QT")]
    public string QuoteTypeQT { get; set; }

    /// <summary>
    ///  This field can be updated when **Status** is `Draft`. Specifies whether a termed subscription will remain termed or change to evergreen when it is renewed. **Required**: If TermType is Termed **Values**: `RENEW_WITH_SPECIFIC_TERM `(default), `RENEW_TO_EVERGREEN` 
    /// </summary>
    /// <value> This field can be updated when **Status** is `Draft`. Specifies whether a termed subscription will remain termed or change to evergreen when it is renewed. **Required**: If TermType is Termed **Values**: `RENEW_WITH_SPECIFIC_TERM `(default), `RENEW_TO_EVERGREEN` </value>
    [DataMember(Name="RenewalSetting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RenewalSetting")]
    public string RenewalSetting { get; set; }

    /// <summary>
    ///  The length of the period for the subscription renewal term. This field can be updated when **Status** is `Draft`. If you use the subscribe() call, this field is required. **Required**: If TermType is Termed. **Character limit**: 20 **Values**: one of the following:  - leave null to default to `0` - any number 
    /// </summary>
    /// <value> The length of the period for the subscription renewal term. This field can be updated when **Status** is `Draft`. If you use the subscribe() call, this field is required. **Required**: If TermType is Termed. **Character limit**: 20 **Values**: one of the following:  - leave null to default to `0` - any number </value>
    [DataMember(Name="RenewalTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RenewalTerm")]
    public int? RenewalTerm { get; set; }

    /// <summary>
    ///  The period type for the subscription renewal term. **Values**:  - `Month` (default) - `Year` - `Day` - `Week` **Note**:  - This field is used with the RenewalTerm field to specify the subscription renewal term. - This field can be updated when Status is `Draft`. 
    /// </summary>
    /// <value> The period type for the subscription renewal term. **Values**:  - `Month` (default) - `Year` - `Day` - `Week` **Note**:  - This field is used with the RenewalTerm field to specify the subscription renewal term. - This field can be updated when Status is `Draft`. </value>
    [DataMember(Name="RenewalTermPeriodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RenewalTermPeriodType")]
    public string RenewalTermPeriodType { get; set; }

    /// <summary>
    ///  The date when the subscription is activated. This field can be updated when **Status** is `Draft`. **Character limit**: 29 **Note**: The service activation date is only required if the [Require Service Activation of Orders?](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Require_Service_Activation_of_Orders.3F) Setting is set to `Yes`. If this setting is set to `Yes`:  - If ContractAcceptanceDate field is required, you must set this field, ContractAcceptanceDate, and ContractEffectiveDate fields in the subscribe call to activate a subscription. - If ContractAcceptanceDate field is not required, you must set both this field and the ContractEffectiveDate field in the subscribe call to activate a subscription. If you only set a valid date in the ContractEffectiveDate field, the subscribe call still returns success, but the subscription is in `DRAT` status. 
    /// </summary>
    /// <value> The date when the subscription is activated. This field can be updated when **Status** is `Draft`. **Character limit**: 29 **Note**: The service activation date is only required if the [Require Service Activation of Orders?](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Require_Service_Activation_of_Orders.3F) Setting is set to `Yes`. If this setting is set to `Yes`:  - If ContractAcceptanceDate field is required, you must set this field, ContractAcceptanceDate, and ContractEffectiveDate fields in the subscribe call to activate a subscription. - If ContractAcceptanceDate field is not required, you must set both this field and the ContractEffectiveDate field in the subscribe call to activate a subscription. If you only set a valid date in the ContractEffectiveDate field, the subscribe call still returns success, but the subscription is in `DRAT` status. </value>
    [DataMember(Name="ServiceActivationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceActivationDate")]
    public DateTime? ServiceActivationDate { get; set; }

    /// <summary>
    ///  The status of the subscription. **Character limit**: 17 **Values**: automatically generated **Possible values**: one of the following:  - `Draft` - `PendingActivation` - `PendingAcceptance` - `Active` - `Cancelled` - `Expired` - `Suspended` (This value is in **Limited Availability**.) 
    /// </summary>
    /// <value> The status of the subscription. **Character limit**: 17 **Values**: automatically generated **Possible values**: one of the following:  - `Draft` - `PendingActivation` - `PendingAcceptance` - `Active` - `Cancelled` - `Expired` - `Suspended` (This value is in **Limited Availability**.) </value>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    ///  This field can be updated when **Status** is `Draft`. The date when the subscription term begins. If this is a renewal subscription, then this date is different from the subscription start date. **Character limit**: 29 **Version notes**: -- 
    /// </summary>
    /// <value> This field can be updated when **Status** is `Draft`. The date when the subscription term begins. If this is a renewal subscription, then this date is different from the subscription start date. **Character limit**: 29 **Version notes**: -- </value>
    [DataMember(Name="TermStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TermStartDate")]
    public DateTime? TermStartDate { get; set; }

    /// <summary>
    ///  This field can be updated when **Status** is `Draft`. Indicates if a subscription is [termed or evergreen](https://knowledgecenter.zuora.com/BC_Subscription_Management/Subscriptions#Termed_and_Evergreen_Subscriptions). A termed subscription has a specific end date and requires manual renewal. An evergreen subscription doesn't have an end date and doesn't need renewal. This field can be updated when the subscription status is Draft. **Character limit**: 9 **Values**: `TERMED`, `EVERGREEN` 
    /// </summary>
    /// <value> This field can be updated when **Status** is `Draft`. Indicates if a subscription is [termed or evergreen](https://knowledgecenter.zuora.com/BC_Subscription_Management/Subscriptions#Termed_and_Evergreen_Subscriptions). A termed subscription has a specific end date and requires manual renewal. An evergreen subscription doesn't have an end date and doesn't need renewal. This field can be updated when the subscription status is Draft. **Character limit**: 9 **Values**: `TERMED`, `EVERGREEN` </value>
    [DataMember(Name="TermType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TermType")]
    public string TermType { get; set; }

    /// <summary>
    ///  The version number of the subscription. **Values**: automatically generated 
    /// </summary>
    /// <value> The version number of the subscription. **Values**: automatically generated </value>
    [DataMember(Name="Version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Version")]
    public int? Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyCreateSubscription {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
      sb.Append("  CancelledDate: ").Append(CancelledDate).Append("\n");
      sb.Append("  ContractAcceptanceDate: ").Append(ContractAcceptanceDate).Append("\n");
      sb.Append("  ContractEffectiveDate: ").Append(ContractEffectiveDate).Append("\n");
      sb.Append("  CpqBundleJsonIdQT: ").Append(CpqBundleJsonIdQT).Append("\n");
      sb.Append("  CurrentTermPeriodType: ").Append(CurrentTermPeriodType).Append("\n");
      sb.Append("  InitialTerm: ").Append(InitialTerm).Append("\n");
      sb.Append("  InitialTermPeriodType: ").Append(InitialTermPeriodType).Append("\n");
      sb.Append("  InvoiceOwnerId: ").Append(InvoiceOwnerId).Append("\n");
      sb.Append("  IsInvoiceSeparate: ").Append(IsInvoiceSeparate).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  OpportunityCloseDateQT: ").Append(OpportunityCloseDateQT).Append("\n");
      sb.Append("  OpportunityNameQT: ").Append(OpportunityNameQT).Append("\n");
      sb.Append("  QuoteBusinessTypeQT: ").Append(QuoteBusinessTypeQT).Append("\n");
      sb.Append("  QuoteNumberQT: ").Append(QuoteNumberQT).Append("\n");
      sb.Append("  QuoteTypeQT: ").Append(QuoteTypeQT).Append("\n");
      sb.Append("  RenewalSetting: ").Append(RenewalSetting).Append("\n");
      sb.Append("  RenewalTerm: ").Append(RenewalTerm).Append("\n");
      sb.Append("  RenewalTermPeriodType: ").Append(RenewalTermPeriodType).Append("\n");
      sb.Append("  ServiceActivationDate: ").Append(ServiceActivationDate).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  TermStartDate: ").Append(TermStartDate).Append("\n");
      sb.Append("  TermType: ").Append(TermType).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
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
