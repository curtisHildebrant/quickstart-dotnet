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
  public class GETJournalRunType {
    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="aggregateCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aggregateCurrency")]
    public bool? AggregateCurrency { get; set; }

    /// <summary>
    /// Date and time the journal run was executed. 
    /// </summary>
    /// <value>Date and time the journal run was executed. </value>
    [DataMember(Name="executedOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "executedOn")]
    public DateTime? ExecutedOn { get; set; }

    /// <summary>
    /// Date of the journal entry. 
    /// </summary>
    /// <value>Date of the journal entry. </value>
    [DataMember(Name="journalEntryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "journalEntryDate")]
    public DateTime? JournalEntryDate { get; set; }

    /// <summary>
    /// Journal run number. 
    /// </summary>
    /// <value>Journal run number. </value>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public string Number { get; set; }

    /// <summary>
    /// Name of GL segmentation rule used in the journal run. 
    /// </summary>
    /// <value>Name of GL segmentation rule used in the journal run. </value>
    [DataMember(Name="segmentationRuleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segmentationRuleName")]
    public string SegmentationRuleName { get; set; }

    /// <summary>
    /// Status of the journal run.   The possible values are: * Pending * Processing * Completed * Error * CancelInprogress * Cancelled * DeleteInprogress 
    /// </summary>
    /// <value>Status of the journal run.   The possible values are: * Pending * Processing * Completed * Error * CancelInprogress * Cancelled * DeleteInprogress </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Returns `true` if the request was processed successfully. 
    /// </summary>
    /// <value>Returns `true` if the request was processed successfully. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// The target end date of the journal run. 
    /// </summary>
    /// <value>The target end date of the journal run. </value>
    [DataMember(Name="targetEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetEndDate")]
    public DateTime? TargetEndDate { get; set; }

    /// <summary>
    /// The target start date of the journal run. 
    /// </summary>
    /// <value>The target start date of the journal run. </value>
    [DataMember(Name="targetStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetStartDate")]
    public DateTime? TargetStartDate { get; set; }

    /// <summary>
    /// Total number of journal entries in the journal run. 
    /// </summary>
    /// <value>Total number of journal entries in the journal run. </value>
    [DataMember(Name="totalJournalEntryCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalJournalEntryCount")]
    public long? TotalJournalEntryCount { get; set; }

    /// <summary>
    /// Transaction types included in the journal run. 
    /// </summary>
    /// <value>Transaction types included in the journal run. </value>
    [DataMember(Name="transactionTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionTypes")]
    public List<GETJournalRunTransactionType> TransactionTypes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETJournalRunType {\n");
      sb.Append("  AggregateCurrency: ").Append(AggregateCurrency).Append("\n");
      sb.Append("  ExecutedOn: ").Append(ExecutedOn).Append("\n");
      sb.Append("  JournalEntryDate: ").Append(JournalEntryDate).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  SegmentationRuleName: ").Append(SegmentationRuleName).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  TargetEndDate: ").Append(TargetEndDate).Append("\n");
      sb.Append("  TargetStartDate: ").Append(TargetStartDate).Append("\n");
      sb.Append("  TotalJournalEntryCount: ").Append(TotalJournalEntryCount).Append("\n");
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
