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
  public class GETJournalEntryDetailTypeWithoutSuccess {
    /// <summary>
    /// Name of the accounting period that the journal entry belongs to. 
    /// </summary>
    /// <value>Name of the accounting period that the journal entry belongs to. </value>
    [DataMember(Name="accountingPeriodName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingPeriodName")]
    public string AccountingPeriodName { get; set; }

    /// <summary>
    /// Returns true if the journal entry is aggregating currencies. That is, if the journal entry was created when the [Aggregate transactions with different currencies during a JournalRun](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/C_Configure_accounting_rules#Aggregate_transactions_with_different_currencies_during_a_Journal_Run) setting was configured to \"Yes\". Otherwise, returns `false`. 
    /// </summary>
    /// <value>Returns true if the journal entry is aggregating currencies. That is, if the journal entry was created when the [Aggregate transactions with different currencies during a JournalRun](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/C_Configure_accounting_rules#Aggregate_transactions_with_different_currencies_during_a_Journal_Run) setting was configured to \"Yes\". Otherwise, returns `false`. </value>
    [DataMember(Name="aggregateCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aggregateCurrency")]
    public bool? AggregateCurrency { get; set; }

    /// <summary>
    /// Currency used. 
    /// </summary>
    /// <value>Currency used. </value>
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
    /// Home currency used. 
    /// </summary>
    /// <value>Home currency used. </value>
    [DataMember(Name="homeCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "homeCurrency")]
    public string HomeCurrency { get; set; }

    /// <summary>
    /// Date of the journal entry. 
    /// </summary>
    /// <value>Date of the journal entry. </value>
    [DataMember(Name="journalEntryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "journalEntryDate")]
    public DateTime? JournalEntryDate { get; set; }

    /// <summary>
    /// Key name that represents the list of journal entry items. 
    /// </summary>
    /// <value>Key name that represents the list of journal entry items. </value>
    [DataMember(Name="journalEntryItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "journalEntryItems")]
    public List<GETJournalEntryItemType> JournalEntryItems { get; set; }

    /// <summary>
    /// Additional information about this record. Character limit: 2,000 
    /// </summary>
    /// <value>Additional information about this record. Character limit: 2,000 </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// Journal entry number in the format JE-00000001. 
    /// </summary>
    /// <value>Journal entry number in the format JE-00000001. </value>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public string Number { get; set; }

    /// <summary>
    /// List of segments that apply to the summary journal entry. 
    /// </summary>
    /// <value>List of segments that apply to the summary journal entry. </value>
    [DataMember(Name="segments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segments")]
    public List<GETJournalEntrySegmentType> Segments { get; set; }

    /// <summary>
    /// Status of journal entry. An enum with the values`Created` or `Cancelled`. 
    /// </summary>
    /// <value>Status of journal entry. An enum with the values`Created` or `Cancelled`. </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// End date of time period included in the journal entry. 
    /// </summary>
    /// <value>End date of time period included in the journal entry. </value>
    [DataMember(Name="timePeriodEnd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timePeriodEnd")]
    public DateTime? TimePeriodEnd { get; set; }

    /// <summary>
    /// Start date of time period included in the journal entry. 
    /// </summary>
    /// <value>Start date of time period included in the journal entry. </value>
    [DataMember(Name="timePeriodStart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timePeriodStart")]
    public DateTime? TimePeriodStart { get; set; }

    /// <summary>
    /// Transaction type of the transactions included in the summary journal entry. 
    /// </summary>
    /// <value>Transaction type of the transactions included in the summary journal entry. </value>
    [DataMember(Name="transactionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionType")]
    public string TransactionType { get; set; }

    /// <summary>
    /// Date and time that transferredToAccounting was changed to `Yes`. This field is returned only when transferredToAccounting is `Yes`. Otherwise, this field is `null`. 
    /// </summary>
    /// <value>Date and time that transferredToAccounting was changed to `Yes`. This field is returned only when transferredToAccounting is `Yes`. Otherwise, this field is `null`. </value>
    [DataMember(Name="transferDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transferDateTime")]
    public DateTime? TransferDateTime { get; set; }

    /// <summary>
    /// User ID of the person who changed transferredToAccounting to `Yes`. This field is returned only when transferredToAccounting is `Yes`. Otherwise, this field is `null`. 
    /// </summary>
    /// <value>User ID of the person who changed transferredToAccounting to `Yes`. This field is returned only when transferredToAccounting is `Yes`. Otherwise, this field is `null`. </value>
    [DataMember(Name="transferredBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transferredBy")]
    public string TransferredBy { get; set; }

    /// <summary>
    /// Status shows whether the journal entry has been transferred to an accounting system. The possible values are `No`, `Processing`, `Yes`, `Error`, `Ignore`. 
    /// </summary>
    /// <value>Status shows whether the journal entry has been transferred to an accounting system. The possible values are `No`, `Processing`, `Yes`, `Error`, `Ignore`. </value>
    [DataMember(Name="transferredToAccounting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transferredToAccounting")]
    public string TransferredToAccounting { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETJournalEntryDetailTypeWithoutSuccess {\n");
      sb.Append("  AccountingPeriodName: ").Append(AccountingPeriodName).Append("\n");
      sb.Append("  AggregateCurrency: ").Append(AggregateCurrency).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  HomeCurrency: ").Append(HomeCurrency).Append("\n");
      sb.Append("  JournalEntryDate: ").Append(JournalEntryDate).Append("\n");
      sb.Append("  JournalEntryItems: ").Append(JournalEntryItems).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  Segments: ").Append(Segments).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  TimePeriodEnd: ").Append(TimePeriodEnd).Append("\n");
      sb.Append("  TimePeriodStart: ").Append(TimePeriodStart).Append("\n");
      sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
      sb.Append("  TransferDateTime: ").Append(TransferDateTime).Append("\n");
      sb.Append("  TransferredBy: ").Append(TransferredBy).Append("\n");
      sb.Append("  TransferredToAccounting: ").Append(TransferredToAccounting).Append("\n");
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
