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
  public class PUTBasicSummaryJournalEntryType {
    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Key name that represents the list of journal entry items. 
    /// </summary>
    /// <value>Key name that represents the list of journal entry items. </value>
    [DataMember(Name="journalEntryItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "journalEntryItems")]
    public List<PUTJournalEntryItemType> JournalEntryItems { get; set; }

    /// <summary>
    /// Additional information about this record.  ***Character limit:*** 2,000 
    /// </summary>
    /// <value>Additional information about this record.  ***Character limit:*** 2,000 </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// Status shows whether the journal entry has been transferred to an accounting system. The possible values are `No`, `Processing`, `Yes`, `Error`, `Ignore`.    This field cannot be changed after the summary journal entry has been canceled.    **Note:** The Z-Finance ***Override Transferred to Accounting*** permission is required to change `transferredToAccounting` from `Yes` to any other value. See [Z-Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles) for more information. 
    /// </summary>
    /// <value>Status shows whether the journal entry has been transferred to an accounting system. The possible values are `No`, `Processing`, `Yes`, `Error`, `Ignore`.    This field cannot be changed after the summary journal entry has been canceled.    **Note:** The Z-Finance ***Override Transferred to Accounting*** permission is required to change `transferredToAccounting` from `Yes` to any other value. See [Z-Finance Roles](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/f_Finance_Roles) for more information. </value>
    [DataMember(Name="transferredToAccounting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transferredToAccounting")]
    public string TransferredToAccounting { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PUTBasicSummaryJournalEntryType {\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  JournalEntryItems: ").Append(JournalEntryItems).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
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
