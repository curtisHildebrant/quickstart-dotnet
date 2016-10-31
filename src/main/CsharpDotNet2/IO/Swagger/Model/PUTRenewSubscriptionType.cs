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
  public class PUTRenewSubscriptionType {
    /// <summary>
    /// The closing date of the Opportunity. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The closing date of the Opportunity. This field is populated when the subscription originates from Zuora Quotes.  This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="OpportunityCloseDate_QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OpportunityCloseDate_QT")]
    public string OpportunityCloseDateQT { get; set; }

    /// <summary>
    /// The unique identifier of the Opportunity. This field is populated when the subscription originates from Zuora Quotes.            This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The unique identifier of the Opportunity. This field is populated when the subscription originates from Zuora Quotes.            This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="OpportunityName_QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OpportunityName_QT")]
    public string OpportunityNameQT { get; set; }

    /// <summary>
    /// The specific identifier for the type of business transaction the Quote represents such as New, Upsell, Downsell, Renewal, or Churn. This field is populated when the subscription originates from Zuora Quotes.            This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The specific identifier for the type of business transaction the Quote represents such as New, Upsell, Downsell, Renewal, or Churn. This field is populated when the subscription originates from Zuora Quotes.            This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="QuoteBusinessType_QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteBusinessType_QT")]
    public string QuoteBusinessTypeQT { get; set; }

    /// <summary>
    /// The unique identifier of the Quote. This field is populated when the subscription originates from Zuora Quotes.            This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The unique identifier of the Quote. This field is populated when the subscription originates from Zuora Quotes.            This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="QuoteNumber_QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteNumber_QT")]
    public string QuoteNumberQT { get; set; }

    /// <summary>
    /// The Quote type that represents the subscription lifecycle stage such as New, Amendment, Renew or Cancel. This field is populated when the subscription originates from Zuora Quotes.            This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. 
    /// </summary>
    /// <value>The Quote type that represents the subscription lifecycle stage such as New, Amendment, Renew or Cancel. This field is populated when the subscription originates from Zuora Quotes.            This field is used only for reporting subscription metrics.   See [Subscription Data Source](https://knowledgecenter.zuora.com/CD_Reporting/Data_Exports/Z_Data_Source_Reference/Subscription_Data_Source) for more information. </value>
    [DataMember(Name="QuoteType_QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteType_QT")]
    public string QuoteTypeQT { get; set; }

    /// <summary>
    /// Applies a credit balance to an invoice.  If the value is `true`, the credit balance is applied to the invoice. If the value is `false`, no action is taken.  **Prerequisite:** `invoice` must be `true`.   **Note:** If you are using the field `invoiceCollect` rather than the field `invoice`, the `invoiceCollect` value must be `true`.  To view the credit balance adjustment, retrieve the details of the invoice using the Get Invoices method. 
    /// </summary>
    /// <value>Applies a credit balance to an invoice.  If the value is `true`, the credit balance is applied to the invoice. If the value is `false`, no action is taken.  **Prerequisite:** `invoice` must be `true`.   **Note:** If you are using the field `invoiceCollect` rather than the field `invoice`, the `invoiceCollect` value must be `true`.  To view the credit balance adjustment, retrieve the details of the invoice using the Get Invoices method. </value>
    [DataMember(Name="applyCreditBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applyCreditBalance")]
    public bool? ApplyCreditBalance { get; set; }

    /// <summary>
    /// Collects an automatic payment for a subscription. The collection generated in this operation is only for this subscription, not for the entire customer account.  If the value is `true`, the automatic payment is collected. If the value is `false`, no action is taken.  The default value is `false`.  **Prerequisite:** `invoice` must be `true`.   **Note:** This field is in Zuora REST API version control. Supported minor versions are 196.0 or later. To use this field in the method, you must set the `zuora-version` field to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. 
    /// </summary>
    /// <value>Collects an automatic payment for a subscription. The collection generated in this operation is only for this subscription, not for the entire customer account.  If the value is `true`, the automatic payment is collected. If the value is `false`, no action is taken.  The default value is `false`.  **Prerequisite:** `invoice` must be `true`.   **Note:** This field is in Zuora REST API version control. Supported minor versions are 196.0 or later. To use this field in the method, you must set the `zuora-version` field to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. </value>
    [DataMember(Name="collect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collect")]
    public string Collect { get; set; }

    /// <summary>
    /// Creates an invoice for a subscription. The invoice generated in this operation is only for this subscription, not for the entire customer account.  If the value is `true`, an invoice is created. If the value is `false`, no action is taken.  The default value is `false`.   **Note:** This field is in Zuora REST API version control. Supported minor versions are 196.0 or later. To use this field in the method, you must set the `zuora-version` field to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. 
    /// </summary>
    /// <value>Creates an invoice for a subscription. The invoice generated in this operation is only for this subscription, not for the entire customer account.  If the value is `true`, an invoice is created. If the value is `false`, no action is taken.  The default value is `false`.   **Note:** This field is in Zuora REST API version control. Supported minor versions are 196.0 or later. To use this field in the method, you must set the `zuora-version` field to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. </value>
    [DataMember(Name="invoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice")]
    public string Invoice { get; set; }

    /// <summary>
    /// **Note:** This field has been replaced by the invoice field and the collect field. invoiceCollect is available only for backward compatibility.  If `true` (default), an invoice is generated and payment collected automatically during the subscription process. If `false`, no invoicing or payment takes place. The invoice generated in this operation is only for this subscription, not for the entire customer account.  This field is in Zuora REST API version control. Supported minor versions are `186.0`, `187.0`, `188.0`, `189.0`, and `196.0`. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. 
    /// </summary>
    /// <value>**Note:** This field has been replaced by the invoice field and the collect field. invoiceCollect is available only for backward compatibility.  If `true` (default), an invoice is generated and payment collected automatically during the subscription process. If `false`, no invoicing or payment takes place. The invoice generated in this operation is only for this subscription, not for the entire customer account.  This field is in Zuora REST API version control. Supported minor versions are `186.0`, `187.0`, `188.0`, `189.0`, and `196.0`. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. </value>
    [DataMember(Name="invoiceCollect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceCollect")]
    public bool? InvoiceCollect { get; set; }

    /// <summary>
    /// Date through which to calculate charges if generating an invoice, in yyyy-mm-dd format. Default is current date. 
    /// </summary>
    /// <value>Date through which to calculate charges if generating an invoice, in yyyy-mm-dd format. Default is current date. </value>
    [DataMember(Name="invoiceTargetDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceTargetDate")]
    public DateTime? InvoiceTargetDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PUTRenewSubscriptionType {\n");
      sb.Append("  OpportunityCloseDateQT: ").Append(OpportunityCloseDateQT).Append("\n");
      sb.Append("  OpportunityNameQT: ").Append(OpportunityNameQT).Append("\n");
      sb.Append("  QuoteBusinessTypeQT: ").Append(QuoteBusinessTypeQT).Append("\n");
      sb.Append("  QuoteNumberQT: ").Append(QuoteNumberQT).Append("\n");
      sb.Append("  QuoteTypeQT: ").Append(QuoteTypeQT).Append("\n");
      sb.Append("  ApplyCreditBalance: ").Append(ApplyCreditBalance).Append("\n");
      sb.Append("  Collect: ").Append(Collect).Append("\n");
      sb.Append("  Invoice: ").Append(Invoice).Append("\n");
      sb.Append("  InvoiceCollect: ").Append(InvoiceCollect).Append("\n");
      sb.Append("  InvoiceTargetDate: ").Append(InvoiceTargetDate).Append("\n");
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
