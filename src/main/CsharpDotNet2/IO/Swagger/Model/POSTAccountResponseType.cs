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
  public class POSTAccountResponseType {
    /// <summary>
    /// Auto-generated account ID. 
    /// </summary>
    /// <value>Auto-generated account ID. </value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public string AccountId { get; set; }

    /// <summary>
    /// Account number. 
    /// </summary>
    /// <value>Account number. </value>
    [DataMember(Name="accountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Contracted [monthly recurring revenue](https://knowledgecenter.zuora.com/BC_Subscription_Management/Customer_Accounts/A_How_to_Manage_Customer_Accounts/E_Key_Metrics/A_Monthly_Recurring_Revenue) of the subscription. 
    /// </summary>
    /// <value>Contracted [monthly recurring revenue](https://knowledgecenter.zuora.com/BC_Subscription_Management/Customer_Accounts/A_How_to_Manage_Customer_Accounts/E_Key_Metrics/A_Monthly_Recurring_Revenue) of the subscription. </value>
    [DataMember(Name="contractedMrr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractedMrr")]
    public string ContractedMrr { get; set; }

    /// <summary>
    /// ID of the invoice generated at account creation, if applicable. 
    /// </summary>
    /// <value>ID of the invoice generated at account creation, if applicable. </value>
    [DataMember(Name="invoiceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceId")]
    public string InvoiceId { get; set; }

    /// <summary>
    /// Amount collected on the invoice generated at account creation, if applicable. 
    /// </summary>
    /// <value>Amount collected on the invoice generated at account creation, if applicable. </value>
    [DataMember(Name="paidAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paidAmount")]
    public string PaidAmount { get; set; }

    /// <summary>
    /// ID of the payment collected on the invoice generated at account creation, if applicable. 
    /// </summary>
    /// <value>ID of the payment collected on the invoice generated at account creation, if applicable. </value>
    [DataMember(Name="paymentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentId")]
    public string PaymentId { get; set; }

    /// <summary>
    /// ID of the payment method that was set up at account creation, which automatically becomes the default payment method for this account. 
    /// </summary>
    /// <value>ID of the payment method that was set up at account creation, which automatically becomes the default payment method for this account. </value>
    [DataMember(Name="paymentMethodId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethodId")]
    public string PaymentMethodId { get; set; }

    /// <summary>
    /// Internal process ID to assist Zuora support.
    /// </summary>
    /// <value>Internal process ID to assist Zuora support.</value>
    [DataMember(Name="processId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processId")]
    public string ProcessId { get; set; }

    /// <summary>
    /// Information on one or more reasons for a failed result.
    /// </summary>
    /// <value>Information on one or more reasons for a failed result.</value>
    [DataMember(Name="reasons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reasons")]
    public List<ErrorCodeType> Reasons { get; set; }

    /// <summary>
    /// ID of the subscription that was set up at account creation, if applicable. 
    /// </summary>
    /// <value>ID of the subscription that was set up at account creation, if applicable. </value>
    [DataMember(Name="subscriptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionId")]
    public string SubscriptionId { get; set; }

    /// <summary>
    /// Number of the subscription that was set up at account creation, if applicable. 
    /// </summary>
    /// <value>Number of the subscription that was set up at account creation, if applicable. </value>
    [DataMember(Name="subscriptionNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionNumber")]
    public string SubscriptionNumber { get; set; }

    /// <summary>
    /// Returns `true` if successful, otherwise `false`. 
    /// </summary>
    /// <value>Returns `true` if successful, otherwise `false`. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// [Total contracted value](https://knowledgecenter.zuora.com/P_Glossary) of the subscription. 
    /// </summary>
    /// <value>[Total contracted value](https://knowledgecenter.zuora.com/P_Glossary) of the subscription. </value>
    [DataMember(Name="totalContractedValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalContractedValue")]
    public string TotalContractedValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTAccountResponseType {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  ContractedMrr: ").Append(ContractedMrr).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  PaidAmount: ").Append(PaidAmount).Append("\n");
      sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
      sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
      sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
      sb.Append("  Reasons: ").Append(Reasons).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
      sb.Append("  SubscriptionNumber: ").Append(SubscriptionNumber).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
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
