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
  public class POSTJournalRunType {
    /// <summary>
    /// Name of the accounting period.  This field determines the target start and end dates of the journal run.  Required if you don't include 'targetStartDate' and 'targetEndDate'. 
    /// </summary>
    /// <value>Name of the accounting period.  This field determines the target start and end dates of the journal run.  Required if you don't include 'targetStartDate' and 'targetEndDate'. </value>
    [DataMember(Name="accountingPeriodName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingPeriodName")]
    public string AccountingPeriodName { get; set; }

    /// <summary>
    /// Date of the journal entry. 
    /// </summary>
    /// <value>Date of the journal entry. </value>
    [DataMember(Name="journalEntryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "journalEntryDate")]
    public DateTime? JournalEntryDate { get; set; }

    /// <summary>
    /// The target end date of the journal run.  If you include 'accountingPeriodName', the 'targetEndDate' must be empty or the same as the end date of the accounting period specified in 'accountingPeriodName'. 
    /// </summary>
    /// <value>The target end date of the journal run.  If you include 'accountingPeriodName', the 'targetEndDate' must be empty or the same as the end date of the accounting period specified in 'accountingPeriodName'. </value>
    [DataMember(Name="targetEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetEndDate")]
    public DateTime? TargetEndDate { get; set; }

    /// <summary>
    /// The target start date of the journal run.  Required if you include targetEndDate.  If you include 'accountingPeriodName', the 'targetStartDate' must be empty or the same as the start date of the accounting period specified in 'accountingPeriodName'. 
    /// </summary>
    /// <value>The target start date of the journal run.  Required if you include targetEndDate.  If you include 'accountingPeriodName', the 'targetStartDate' must be empty or the same as the start date of the accounting period specified in 'accountingPeriodName'. </value>
    [DataMember(Name="targetStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetStartDate")]
    public DateTime? TargetStartDate { get; set; }

    /// <summary>
    /// Transaction types included in the journal run.  You can include one or more transaction types. 
    /// </summary>
    /// <value>Transaction types included in the journal run.  You can include one or more transaction types. </value>
    [DataMember(Name="transactionTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionTypes")]
    public List<POSTJournalRunTransactionType> TransactionTypes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTJournalRunType {\n");
      sb.Append("  AccountingPeriodName: ").Append(AccountingPeriodName).Append("\n");
      sb.Append("  JournalEntryDate: ").Append(JournalEntryDate).Append("\n");
      sb.Append("  TargetEndDate: ").Append(TargetEndDate).Append("\n");
      sb.Append("  TargetStartDate: ").Append(TargetStartDate).Append("\n");
      sb.Append("  TransactionTypes: ").Append(TransactionTypes).Append("\n");
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
