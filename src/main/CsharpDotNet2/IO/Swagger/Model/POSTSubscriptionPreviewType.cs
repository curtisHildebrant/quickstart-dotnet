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
  public class POSTSubscriptionPreviewType {
    /// <summary>
    /// The closing date of the Opportunity. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The closing date of the Opportunity. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="OpportunityCloseDate_QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OpportunityCloseDate_QT")]
    public string OpportunityCloseDateQT { get; set; }

    /// <summary>
    /// The unique identifier of the Opportunity. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The unique identifier of the Opportunity. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="OpportunityName_QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OpportunityName_QT")]
    public string OpportunityNameQT { get; set; }

    /// <summary>
    /// The specific identifier for the type of business transaction the Quote represents such as New, Upsell, Downsell, Renewal, or Churn. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The specific identifier for the type of business transaction the Quote represents such as New, Upsell, Downsell, Renewal, or Churn. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="QuoteBusinessType_QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteBusinessType_QT")]
    public string QuoteBusinessTypeQT { get; set; }

    /// <summary>
    /// The unique identifier of the Quote. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The unique identifier of the Quote. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="QuoteNumber_QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteNumber_QT")]
    public string QuoteNumberQT { get; set; }

    /// <summary>
    /// The Quote type that represents the subscription lifecycle stage such as New, Amendment, Renew or Cancel. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The Quote type that represents the subscription lifecycle stage such as New, Amendment, Renew or Cancel. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="QuoteType_QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteType_QT")]
    public string QuoteTypeQT { get; set; }

    /// <summary>
    ///  Customer account number or ID.  You must specify the account information either in this field or in the `previewAccountInfo` field with the following conditions:           * If you already have a customer account, specify the account number or ID in this field. * If you do not have a customer account, provide account information in the `previewAccountInfo` field. 
    /// </summary>
    /// <value> Customer account number or ID.  You must specify the account information either in this field or in the `previewAccountInfo` field with the following conditions:           * If you already have a customer account, specify the account number or ID in this field. * If you do not have a customer account, provide account information in the `previewAccountInfo` field. </value>
    [DataMember(Name="accountKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountKey")]
    public string AccountKey { get; set; }

    /// <summary>
    /// Effective contract date for this subscription, as yyyy-mm-dd. 
    /// </summary>
    /// <value>Effective contract date for this subscription, as yyyy-mm-dd. </value>
    [DataMember(Name="contractEffectiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractEffectiveDate")]
    public DateTime? ContractEffectiveDate { get; set; }

    /// <summary>
    /// The date on which the services or products within a subscription have been accepted by the customer, as yyyy-mm-dd.  Default value is dependent on the value of other fields. See **Notes** section for more details. 
    /// </summary>
    /// <value>The date on which the services or products within a subscription have been accepted by the customer, as yyyy-mm-dd.  Default value is dependent on the value of other fields. See **Notes** section for more details. </value>
    [DataMember(Name="customerAcceptanceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customerAcceptanceDate")]
    public DateTime? CustomerAcceptanceDate { get; set; }

    /// <summary>
    /// Specifies whether to include draft invoice items in subscription previews.  Values:   * `true` (default). Includes draft invoice items in amendment previews.  * `false`. Excludes draft invoice items in amendment previews. 
    /// </summary>
    /// <value>Specifies whether to include draft invoice items in subscription previews.  Values:   * `true` (default). Includes draft invoice items in amendment previews.  * `false`. Excludes draft invoice items in amendment previews. </value>
    [DataMember(Name="includeExistingDraftInvoiceItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeExistingDraftInvoiceItems")]
    public bool? IncludeExistingDraftInvoiceItems { get; set; }

    /// <summary>
    /// Duration of the first term of the subscription, in whole months. Default is `0`. If `termType` is `TERMED`, then this field is required, and the value must be greater than `0`. If `termType` is `EVERGREEN`, this field is ignored. 
    /// </summary>
    /// <value>Duration of the first term of the subscription, in whole months. Default is `0`. If `termType` is `TERMED`, then this field is required, and the value must be greater than `0`. If `termType` is `EVERGREEN`, this field is ignored. </value>
    [DataMember(Name="initialTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initialTerm")]
    public long? InitialTerm { get; set; }

    /// <summary>
    /// The period type of the initial term.   Supported values are:  * `Month` * `Year` * `Day` * `Week` 
    /// </summary>
    /// <value>The period type of the initial term.   Supported values are:  * `Month` * `Year` * `Day` * `Week` </value>
    [DataMember(Name="initialTermPeriodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initialTermPeriodType")]
    public string InitialTermPeriodType { get; set; }

    /// <summary>
    /// Invoice owner account number or ID.  **Note:** This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/). 
    /// </summary>
    /// <value>Invoice owner account number or ID.  **Note:** This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/). </value>
    [DataMember(Name="invoiceOwnerAccountKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceOwnerAccountKey")]
    public string InvoiceOwnerAccountKey { get; set; }

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
    /// <value>String of up to 500 characters.</value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// Gets or Sets PreviewAccountInfo
    /// </summary>
    [DataMember(Name="previewAccountInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previewAccountInfo")]
    public POSTSubscriptionPreviewTypePreviewAccountInfo PreviewAccountInfo { get; set; }

    /// <summary>
    /// The type of preview you will receive. The possible values are `invoiceItem`, `chargeMetrics`, or `InvoiceItemChargeMetrics`. The default is `invoiceItem`. 
    /// </summary>
    /// <value>The type of preview you will receive. The possible values are `invoiceItem`, `chargeMetrics`, or `InvoiceItemChargeMetrics`. The default is `invoiceItem`. </value>
    [DataMember(Name="previewType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previewType")]
    public string PreviewType { get; set; }

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
      sb.Append("class POSTSubscriptionPreviewType {\n");
      sb.Append("  OpportunityCloseDateQT: ").Append(OpportunityCloseDateQT).Append("\n");
      sb.Append("  OpportunityNameQT: ").Append(OpportunityNameQT).Append("\n");
      sb.Append("  QuoteBusinessTypeQT: ").Append(QuoteBusinessTypeQT).Append("\n");
      sb.Append("  QuoteNumberQT: ").Append(QuoteNumberQT).Append("\n");
      sb.Append("  QuoteTypeQT: ").Append(QuoteTypeQT).Append("\n");
      sb.Append("  AccountKey: ").Append(AccountKey).Append("\n");
      sb.Append("  ContractEffectiveDate: ").Append(ContractEffectiveDate).Append("\n");
      sb.Append("  CustomerAcceptanceDate: ").Append(CustomerAcceptanceDate).Append("\n");
      sb.Append("  IncludeExistingDraftInvoiceItems: ").Append(IncludeExistingDraftInvoiceItems).Append("\n");
      sb.Append("  InitialTerm: ").Append(InitialTerm).Append("\n");
      sb.Append("  InitialTermPeriodType: ").Append(InitialTermPeriodType).Append("\n");
      sb.Append("  InvoiceOwnerAccountKey: ").Append(InvoiceOwnerAccountKey).Append("\n");
      sb.Append("  InvoiceTargetDate: ").Append(InvoiceTargetDate).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  PreviewAccountInfo: ").Append(PreviewAccountInfo).Append("\n");
      sb.Append("  PreviewType: ").Append(PreviewType).Append("\n");
      sb.Append("  ServiceActivationDate: ").Append(ServiceActivationDate).Append("\n");
      sb.Append("  SubscribeToRatePlans: ").Append(SubscribeToRatePlans).Append("\n");
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
