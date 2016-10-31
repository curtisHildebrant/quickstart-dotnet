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
  public class PUTSubscriptionType {
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
    /// The specific identifier for the type of business transaction the Quote represents such as `New`, `Upsell`, `Downsell`, `Renewal`, or `Churn`. This field is populated when the subscription originates from Zuora Quotes.            This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The specific identifier for the type of business transaction the Quote represents such as `New`, `Upsell`, `Downsell`, `Renewal`, or `Churn`. This field is populated when the subscription originates from Zuora Quotes.            This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="QuoteBusinessType__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteBusinessType__QT")]
    public string QuoteBusinessTypeQT { get; set; }

    /// <summary>
    /// The unique identifier of the Quote. This field is populated when the subscription originates from Zuora Quotes.            This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The unique identifier of the Quote. This field is populated when the subscription originates from Zuora Quotes.            This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="QuoteNumber__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteNumber__QT")]
    public string QuoteNumberQT { get; set; }

    /// <summary>
    /// The Quote type that represents the subscription lifecycle stage such as `New`, `Amendment`, `Renew`, or `Cancel`. This field is populated when the subscription originates from Zuora Quotes.            This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The Quote type that represents the subscription lifecycle stage such as `New`, `Amendment`, `Renew`, or `Cancel`. This field is populated when the subscription originates from Zuora Quotes.            This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="QuoteType__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteType__QT")]
    public string QuoteTypeQT { get; set; }

    /// <summary>
    /// Container for adding one or more rate plans. 
    /// </summary>
    /// <value>Container for adding one or more rate plans. </value>
    [DataMember(Name="add", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add")]
    public List<PUTSrpAddType> Add { get; set; }

    /// <summary>
    /// Applies a credit balance to an invoice.  If the value is `true`, the credit balance is applied to the invoice. If the value is `false`, no action is taken.  **Prerequisite:** `invoice` must be true.   **Note:** If you are using the field `invoiceCollect` rather than the field `invoice`, the `invoiceCollect` value must be true.  To view the credit balance adjustment, retrieve the details of the invoice using the Get Invoices method. 
    /// </summary>
    /// <value>Applies a credit balance to an invoice.  If the value is `true`, the credit balance is applied to the invoice. If the value is `false`, no action is taken.  **Prerequisite:** `invoice` must be true.   **Note:** If you are using the field `invoiceCollect` rather than the field `invoice`, the `invoiceCollect` value must be true.  To view the credit balance adjustment, retrieve the details of the invoice using the Get Invoices method. </value>
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
    /// The length of the period for the current subscription term. If `termType` is `TERMED`, this field is required and must be greater than `0`. If `termType` is `EVERGREEN`, this value is ignored. Default is `0`. 
    /// </summary>
    /// <value>The length of the period for the current subscription term. If `termType` is `TERMED`, this field is required and must be greater than `0`. If `termType` is `EVERGREEN`, this value is ignored. Default is `0`. </value>
    [DataMember(Name="currentTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentTerm")]
    public long? CurrentTerm { get; set; }

    /// <summary>
    /// The period type for the current subscription term.  This field is used with the `CurrentTerm` field to specify the current subscription term.  Values are:  * `Month` (default) * `Year` * `Day` * `Week` 
    /// </summary>
    /// <value>The period type for the current subscription term.  This field is used with the `CurrentTerm` field to specify the current subscription term.  Values are:  * `Month` (default) * `Year` * `Day` * `Week` </value>
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
    /// Specifies whether to include draft invoice items in amendment previews.  Values:   * `true` (default). Includes draft invoice items in amendment previews.  * `false`. Excludes draft invoice items in amendment previews. 
    /// </summary>
    /// <value>Specifies whether to include draft invoice items in amendment previews.  Values:   * `true` (default). Includes draft invoice items in amendment previews.  * `false`. Excludes draft invoice items in amendment previews. </value>
    [DataMember(Name="includeExistingDraftInvoiceItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeExistingDraftInvoiceItems")]
    public bool? IncludeExistingDraftInvoiceItems { get; set; }

    /// <summary>
    /// Creates an invoice for a subscription. The invoice generated in this operation is only for this subscription, not for the entire customer account.  If the value is `true`, an invoice is created. If the value is `false`, no action is taken.  The default value is `false`.   This field is in Zuora REST API version control. Supported minor versions are 196.0 or later. To use this field in the method, you must set the `zuora-version` parameter to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. 
    /// </summary>
    /// <value>Creates an invoice for a subscription. The invoice generated in this operation is only for this subscription, not for the entire customer account.  If the value is `true`, an invoice is created. If the value is `false`, no action is taken.  The default value is `false`.   This field is in Zuora REST API version control. Supported minor versions are 196.0 or later. To use this field in the method, you must set the `zuora-version` parameter to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. </value>
    [DataMember(Name="invoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice")]
    public bool? Invoice { get; set; }

    /// <summary>
    /// **Note:** This field has been replaced by the `invoice` field and the `collect` field. `invoiceCollect` is available only for backward compatibility.  If `true`, an invoice is generated and payment collected automatically during the subscription process. If `false` (default), no invoicing or payment takes place.  The invoice generated in this operation is only for this subscription, not for the entire customer account.  This field is in Zuora REST API version control. Supported minor versions are 186.0, 187.0, 188.0, 189.0, and 196.0. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. 
    /// </summary>
    /// <value>**Note:** This field has been replaced by the `invoice` field and the `collect` field. `invoiceCollect` is available only for backward compatibility.  If `true`, an invoice is generated and payment collected automatically during the subscription process. If `false` (default), no invoicing or payment takes place.  The invoice generated in this operation is only for this subscription, not for the entire customer account.  This field is in Zuora REST API version control. Supported minor versions are 186.0, 187.0, 188.0, 189.0, and 196.0. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. </value>
    [DataMember(Name="invoiceCollect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceCollect")]
    public bool? InvoiceCollect { get; set; }

    /// <summary>
    /// Separates a single subscription from other subscriptions and invoices the charge independently.   If the value is `true`, the subscription is billed separately from other subscriptions. If the value is `false`, the subscription is included with other subscriptions in the account invoice.  The default value is `false`. Prerequisite: The default subscription setting Enable Subscriptions to be Invoiced Separately must be set to Yes. 
    /// </summary>
    /// <value>Separates a single subscription from other subscriptions and invoices the charge independently.   If the value is `true`, the subscription is billed separately from other subscriptions. If the value is `false`, the subscription is included with other subscriptions in the account invoice.  The default value is `false`. Prerequisite: The default subscription setting Enable Subscriptions to be Invoiced Separately must be set to Yes. </value>
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
    /// If `true` the update is made in preview mode. The default setting is `false`. 
    /// </summary>
    /// <value>If `true` the update is made in preview mode. The default setting is `false`. </value>
    [DataMember(Name="preview", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "preview")]
    public bool? Preview { get; set; }

    /// <summary>
    ///  The type of preview you will receive. The possible values are `InvoiceItem`, `ChargeMetrics`, or `InvoiceItemChargeMetrics`. The default is `InvoiceItem`. 
    /// </summary>
    /// <value> The type of preview you will receive. The possible values are `InvoiceItem`, `ChargeMetrics`, or `InvoiceItemChargeMetrics`. The default is `InvoiceItem`. </value>
    [DataMember(Name="previewType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previewType")]
    public string PreviewType { get; set; }

    /// <summary>
    /// Container for removing one or more rate plans. 
    /// </summary>
    /// <value>Container for removing one or more rate plans. </value>
    [DataMember(Name="remove", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remove")]
    public List<PUTSrpRemoveType> Remove { get; set; }

    /// <summary>
    /// Specifies whether a termed subscription will remain `TERMED` or change to `EVERGREEN` when it is renewed.   Values are:  * `RENEW_WITH_SPECIFIC_TERM` (default) * `RENEW_TO_EVERGREEN` 
    /// </summary>
    /// <value>Specifies whether a termed subscription will remain `TERMED` or change to `EVERGREEN` when it is renewed.   Values are:  * `RENEW_WITH_SPECIFIC_TERM` (default) * `RENEW_TO_EVERGREEN` </value>
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
    ///  The period type for the subscription renewal term.  This field is used with the `renewalTerm` field to specify the subscription renewal term.  Values are:  * `Month` (default) * `Year` * `Day` * `Week` 
    /// </summary>
    /// <value> The period type for the subscription renewal term.  This field is used with the `renewalTerm` field to specify the subscription renewal term.  Values are:  * `Month` (default) * `Year` * `Day` * `Week` </value>
    [DataMember(Name="renewalTermPeriodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewalTermPeriodType")]
    public string RenewalTermPeriodType { get; set; }

    /// <summary>
    /// Date the subscription term begins, as yyyy-mm-dd. If this is a renewal subscription, this date is different from the subscription start date.  
    /// </summary>
    /// <value>Date the subscription term begins, as yyyy-mm-dd. If this is a renewal subscription, this date is different from the subscription start date.  </value>
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
    /// Container for updating one or more rate plans. 
    /// </summary>
    /// <value>Container for updating one or more rate plans. </value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public List<PUTSrpUpdateType> Update { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PUTSubscriptionType {\n");
      sb.Append("  CpqBundleJsonIdQT: ").Append(CpqBundleJsonIdQT).Append("\n");
      sb.Append("  OpportunityCloseDateQT: ").Append(OpportunityCloseDateQT).Append("\n");
      sb.Append("  OpportunityNameQT: ").Append(OpportunityNameQT).Append("\n");
      sb.Append("  QuoteBusinessTypeQT: ").Append(QuoteBusinessTypeQT).Append("\n");
      sb.Append("  QuoteNumberQT: ").Append(QuoteNumberQT).Append("\n");
      sb.Append("  QuoteTypeQT: ").Append(QuoteTypeQT).Append("\n");
      sb.Append("  Add: ").Append(Add).Append("\n");
      sb.Append("  ApplyCreditBalance: ").Append(ApplyCreditBalance).Append("\n");
      sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
      sb.Append("  CurrentTerm: ").Append(CurrentTerm).Append("\n");
      sb.Append("  CurrentTermPeriodType: ").Append(CurrentTermPeriodType).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  IncludeExistingDraftInvoiceItems: ").Append(IncludeExistingDraftInvoiceItems).Append("\n");
      sb.Append("  Invoice: ").Append(Invoice).Append("\n");
      sb.Append("  InvoiceCollect: ").Append(InvoiceCollect).Append("\n");
      sb.Append("  InvoiceSeparately: ").Append(InvoiceSeparately).Append("\n");
      sb.Append("  InvoiceTargetDate: ").Append(InvoiceTargetDate).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  Preview: ").Append(Preview).Append("\n");
      sb.Append("  PreviewType: ").Append(PreviewType).Append("\n");
      sb.Append("  Remove: ").Append(Remove).Append("\n");
      sb.Append("  RenewalSetting: ").Append(RenewalSetting).Append("\n");
      sb.Append("  RenewalTerm: ").Append(RenewalTerm).Append("\n");
      sb.Append("  RenewalTermPeriodType: ").Append(RenewalTermPeriodType).Append("\n");
      sb.Append("  TermStartDate: ").Append(TermStartDate).Append("\n");
      sb.Append("  TermType: ").Append(TermType).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
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
