using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for basic information about the account. 
  /// </summary>
  [DataContract]
  public class GETAccountSummaryTypeBasicInfo {
    /// <summary>
    /// Account number. 
    /// </summary>
    /// <value>Account number. </value>
    [DataMember(Name="accountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Current outstanding balance. 
    /// </summary>
    /// <value>Current outstanding balance. </value>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public string Balance { get; set; }

    /// <summary>
    /// The alias name given to a batch. A string of 50 characters or less. 
    /// </summary>
    /// <value>The alias name given to a batch. A string of 50 characters or less. </value>
    [DataMember(Name="batch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "batch")]
    public string Batch { get; set; }

    /// <summary>
    /// Billing cycle day (BCD), the day of the month when a bill run generates invoices for the account. 
    /// </summary>
    /// <value>Billing cycle day (BCD), the day of the month when a bill run generates invoices for the account. </value>
    [DataMember(Name="billCycleDay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billCycleDay")]
    public string BillCycleDay { get; set; }

    /// <summary>
    /// A currency value. See [Customize Currencies](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Customize_Currencies) for more information. 
    /// </summary>
    /// <value>A currency value. See [Customize Currencies](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Customize_Currencies) for more information. </value>
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
    /// Gets or Sets DefaultPaymentMethod
    /// </summary>
    [DataMember(Name="defaultPaymentMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultPaymentMethod")]
    public GETAccountSummaryTypeBasicInfoDefaultPaymentMethod DefaultPaymentMethod { get; set; }

    /// <summary>
    /// Account ID. 
    /// </summary>
    /// <value>Account ID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Date of the most recent invoice for the account; null if no invoice has ever been generated. 
    /// </summary>
    /// <value>Date of the most recent invoice for the account; null if no invoice has ever been generated. </value>
    [DataMember(Name="lastInvoiceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastInvoiceDate")]
    public DateTime? LastInvoiceDate { get; set; }

    /// <summary>
    /// Amount of the most recent payment collected for the account; null if no payment has ever been collected. 
    /// </summary>
    /// <value>Amount of the most recent payment collected for the account; null if no payment has ever been collected. </value>
    [DataMember(Name="lastPaymentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastPaymentAmount")]
    public string LastPaymentAmount { get; set; }

    /// <summary>
    /// Date of the most recent payment collected for the account. Null if no payment has ever been collected. 
    /// </summary>
    /// <value>Date of the most recent payment collected for the account. Null if no payment has ever been collected. </value>
    [DataMember(Name="lastPaymentDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastPaymentDate")]
    public DateTime? LastPaymentDate { get; set; }

    /// <summary>
    /// Account name. 
    /// </summary>
    /// <value>Account name. </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Account status; possible values are: `Active`, `Draft`, `Canceled`. 
    /// </summary>
    /// <value>Account status; possible values are: `Active`, `Draft`, `Canceled`. </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public string Tags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountSummaryTypeBasicInfo {\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  Batch: ").Append(Batch).Append("\n");
      sb.Append("  BillCycleDay: ").Append(BillCycleDay).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  DefaultPaymentMethod: ").Append(DefaultPaymentMethod).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastInvoiceDate: ").Append(LastInvoiceDate).Append("\n");
      sb.Append("  LastPaymentAmount: ").Append(LastPaymentAmount).Append("\n");
      sb.Append("  LastPaymentDate: ").Append(LastPaymentDate).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
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
