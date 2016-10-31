using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for subscription information, used if creating a subscription for the new account at the time of account creation. 
  /// </summary>
  [DataContract]
  public class POSTAccountTypeSubscription {
    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="CpqBundleJsonId__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CpqBundleJsonId__QT")]
    public string CpqBundleJsonIdQT { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="OpportunityCloseDate__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OpportunityCloseDate__QT")]
    public string OpportunityCloseDateQT { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="OpportunityName__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OpportunityName__QT")]
    public string OpportunityNameQT { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="QuoteBusinessType__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteBusinessType__QT")]
    public string QuoteBusinessTypeQT { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="QuoteNumber__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteNumber__QT")]
    public string QuoteNumberQT { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="QuoteType__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteType__QT")]
    public string QuoteTypeQT { get; set; }

    /// <summary>
    /// If `true`, auto-renew is enabled. Default is `false`. 
    /// </summary>
    /// <value>If `true`, auto-renew is enabled. Default is `false`. </value>
    [DataMember(Name="autoRenew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoRenew")]
    public bool? AutoRenew { get; set; }

    /// <summary>
    /// Effective contract date for this subscription, as `yyyy-mm-dd`. 
    /// </summary>
    /// <value>Effective contract date for this subscription, as `yyyy-mm-dd`. </value>
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
    /// The date on which the services or products within a subscription have been accepted by the customer, as `yyyy-mm-dd`.  Default value is dependent on the value of other fields. See Notes section for more details. 
    /// </summary>
    /// <value>The date on which the services or products within a subscription have been accepted by the customer, as `yyyy-mm-dd`.  Default value is dependent on the value of other fields. See Notes section for more details. </value>
    [DataMember(Name="customerAcceptanceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customerAcceptanceDate")]
    public DateTime? CustomerAcceptanceDate { get; set; }

    /// <summary>
    /// Duration of the initial subscription term in whole months.  Default is 0.  
    /// </summary>
    /// <value>Duration of the initial subscription term in whole months.  Default is 0.  </value>
    [DataMember(Name="initialTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initialTerm")]
    public long? InitialTerm { get; set; }

    /// <summary>
    /// Invoice owner account number or ID.  **Note:** This feature is in Limited Availability. If you wish to have access to the feature, submit a request at [Zuora Global Support](https://support.zuora.com).  
    /// </summary>
    /// <value>Invoice owner account number or ID.  **Note:** This feature is in Limited Availability. If you wish to have access to the feature, submit a request at [Zuora Global Support](https://support.zuora.com).  </value>
    [DataMember(Name="invoiceOwnerAccountKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceOwnerAccountKey")]
    public string InvoiceOwnerAccountKey { get; set; }

    /// <summary>
    /// Separates a single subscription from other subscriptions and invoices the charge independently.   If the value is `true`, the subscription is billed separately from other subscriptions. If the value is `false`, the subscription is included with other subscriptions in the account invoice. The default value is `false`.  Prerequisite: The default subscription setting `Enable Subscriptions to be Invoiced Separately` must be set to `Yes`. 
    /// </summary>
    /// <value>Separates a single subscription from other subscriptions and invoices the charge independently.   If the value is `true`, the subscription is billed separately from other subscriptions. If the value is `false`, the subscription is included with other subscriptions in the account invoice. The default value is `false`.  Prerequisite: The default subscription setting `Enable Subscriptions to be Invoiced Separately` must be set to `Yes`. </value>
    [DataMember(Name="invoiceSeparately", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceSeparately")]
    public bool? InvoiceSeparately { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// Duration of the renewal term in whole months. Default is 0. 
    /// </summary>
    /// <value>Duration of the renewal term in whole months. Default is 0. </value>
    [DataMember(Name="renewalTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewalTerm")]
    public long? RenewalTerm { get; set; }

    /// <summary>
    /// The date on which the services or products within a subscription have been activated and access has been provided to the customer, as `yyyy-mm-dd`.  Default value is dependent on the value of other fields. See Notes section for more details. 
    /// </summary>
    /// <value>The date on which the services or products within a subscription have been activated and access has been provided to the customer, as `yyyy-mm-dd`.  Default value is dependent on the value of other fields. See Notes section for more details. </value>
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
    /// Subscription Number. The value can be up to 1000 characters.  If you do not specify a subscription number when creating a subscription for the new account, Zuora will generate a subscription number automatically.  If the account is created successfully, the subscription number is returned in the `subscriptionNumber` response field. 
    /// </summary>
    /// <value>Subscription Number. The value can be up to 1000 characters.  If you do not specify a subscription number when creating a subscription for the new account, Zuora will generate a subscription number automatically.  If the account is created successfully, the subscription number is returned in the `subscriptionNumber` response field. </value>
    [DataMember(Name="subscriptionNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionNumber")]
    public string SubscriptionNumber { get; set; }

    /// <summary>
    /// The date on which the subscription term begins, as `yyyy-mm-dd`. If this is a renewal subscription, this date is different from the subscription start date. 
    /// </summary>
    /// <value>The date on which the subscription term begins, as `yyyy-mm-dd`. If this is a renewal subscription, this date is different from the subscription start date. </value>
    [DataMember(Name="termStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "termStartDate")]
    public DateTime? TermStartDate { get; set; }

    /// <summary>
    /// Possible values are: `TERMED`, `EVERGREEN`. See [Subscriptions](https://knowledgecenter.zuora.com/BC_Subscription_Management/Subscriptions) for more information. 
    /// </summary>
    /// <value>Possible values are: `TERMED`, `EVERGREEN`. See [Subscriptions](https://knowledgecenter.zuora.com/BC_Subscription_Management/Subscriptions) for more information. </value>
    [DataMember(Name="termType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "termType")]
    public string TermType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTAccountTypeSubscription {\n");
      sb.Append("  CpqBundleJsonIdQT: ").Append(CpqBundleJsonIdQT).Append("\n");
      sb.Append("  OpportunityCloseDateQT: ").Append(OpportunityCloseDateQT).Append("\n");
      sb.Append("  OpportunityNameQT: ").Append(OpportunityNameQT).Append("\n");
      sb.Append("  QuoteBusinessTypeQT: ").Append(QuoteBusinessTypeQT).Append("\n");
      sb.Append("  QuoteNumberQT: ").Append(QuoteNumberQT).Append("\n");
      sb.Append("  QuoteTypeQT: ").Append(QuoteTypeQT).Append("\n");
      sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
      sb.Append("  ContractEffectiveDate: ").Append(ContractEffectiveDate).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  CustomerAcceptanceDate: ").Append(CustomerAcceptanceDate).Append("\n");
      sb.Append("  InitialTerm: ").Append(InitialTerm).Append("\n");
      sb.Append("  InvoiceOwnerAccountKey: ").Append(InvoiceOwnerAccountKey).Append("\n");
      sb.Append("  InvoiceSeparately: ").Append(InvoiceSeparately).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  RenewalTerm: ").Append(RenewalTerm).Append("\n");
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
