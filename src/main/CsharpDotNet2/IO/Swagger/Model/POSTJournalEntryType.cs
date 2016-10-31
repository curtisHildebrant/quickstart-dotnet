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
  public class POSTJournalEntryType {
    /// <summary>
    /// Name of the accounting period. The open-ended accounting period is named `Open-Ended`.  
    /// </summary>
    /// <value>Name of the accounting period. The open-ended accounting period is named `Open-Ended`.  </value>
    [DataMember(Name="accountingPeriodName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingPeriodName")]
    public string AccountingPeriodName { get; set; }

    /// <summary>
    /// The type of currency used.   Currency must be active in **Z-Billing Settings > Customize Currencies.** 
    /// </summary>
    /// <value>The type of currency used.   Currency must be active in **Z-Billing Settings > Customize Currencies.** </value>
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
    public List<POSTJournalEntryItemType> JournalEntryItems { get; set; }

    /// <summary>
    /// The number associated with the revenue event.  Character limit: 2,000 
    /// </summary>
    /// <value>The number associated with the revenue event.  Character limit: 2,000 </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// List of segments that apply to the summary journal entry. 
    /// </summary>
    /// <value>List of segments that apply to the summary journal entry. </value>
    [DataMember(Name="segments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segments")]
    public List<POSTJournalEntrySegmentType> Segments { get; set; }

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
      sb.Append("class POSTJournalEntryType {\n");
      sb.Append("  AccountingPeriodName: ").Append(AccountingPeriodName).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  JournalEntryDate: ").Append(JournalEntryDate).Append("\n");
      sb.Append("  JournalEntryItems: ").Append(JournalEntryItems).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  Segments: ").Append(Segments).Append("\n");
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
