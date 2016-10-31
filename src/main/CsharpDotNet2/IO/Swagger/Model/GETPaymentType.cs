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
  public class GETPaymentType {
    /// <summary>
    /// Customer account ID. 
    /// </summary>
    /// <value>Customer account ID. </value>
    [DataMember(Name="accountID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountID")]
    public string AccountID { get; set; }

    /// <summary>
    /// Customer account name. 
    /// </summary>
    /// <value>Customer account name. </value>
    [DataMember(Name="accountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Customer account number. 
    /// </summary>
    /// <value>Customer account number. </value>
    [DataMember(Name="accountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Payment amount. 
    /// </summary>
    /// <value>Payment amount. </value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Effective payment date as _yyyy-mm-dd_. 
    /// </summary>
    /// <value>Effective payment date as _yyyy-mm-dd_. </value>
    [DataMember(Name="effectiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effectiveDate")]
    public DateTime? EffectiveDate { get; set; }

    /// <summary>
    /// Transaction ID from payment gateway. 
    /// </summary>
    /// <value>Transaction ID from payment gateway. </value>
    [DataMember(Name="gatewayTransactionNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gatewayTransactionNumber")]
    public string GatewayTransactionNumber { get; set; }

    /// <summary>
    /// PaymentID. 
    /// </summary>
    /// <value>PaymentID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Information about one or more invoices to which this payment was applied: 
    /// </summary>
    /// <value>Information about one or more invoices to which this payment was applied: </value>
    [DataMember(Name="paidInvoices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paidInvoices")]
    public List<GETPaidInvoicesType> PaidInvoices { get; set; }

    /// <summary>
    /// Payment method. 
    /// </summary>
    /// <value>Payment method. </value>
    [DataMember(Name="paymentMethodID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethodID")]
    public string PaymentMethodID { get; set; }

    /// <summary>
    /// Unique payment number. 
    /// </summary>
    /// <value>Unique payment number. </value>
    [DataMember(Name="paymentNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentNumber")]
    public string PaymentNumber { get; set; }

    /// <summary>
    /// Possible values are: `Draft`, `Processing`, `Processed`, `Error`, `Voided`, `Canceled`, `Posted. 
    /// </summary>
    /// <value>Possible values are: `Draft`, `Processing`, `Processed`, `Error`, `Voided`, `Canceled`, `Posted. </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Possible values are: `External`, `Electronic`. 
    /// </summary>
    /// <value>Possible values are: `External`, `Electronic`. </value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETPaymentType {\n");
      sb.Append("  AccountID: ").Append(AccountID).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
      sb.Append("  GatewayTransactionNumber: ").Append(GatewayTransactionNumber).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  PaidInvoices: ").Append(PaidInvoices).Append("\n");
      sb.Append("  PaymentMethodID: ").Append(PaymentMethodID).Append("\n");
      sb.Append("  PaymentNumber: ").Append(PaymentNumber).Append("\n");
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
