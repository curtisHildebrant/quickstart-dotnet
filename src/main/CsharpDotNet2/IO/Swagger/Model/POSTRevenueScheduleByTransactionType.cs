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
  public class POSTRevenueScheduleByTransactionType {
    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Additional information about this record.  Character Limit: 2,000 
    /// </summary>
    /// <value>Additional information about this record.  Character Limit: 2,000 </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// An array of revenue distributions. Represents how you want to distribute revenue for this revenue schedule. You can distribute revenue into a maximum of 250 accounting periods with one revenue schedule.  The sum of newAmounts must equal the the Charge Amount of the specified Invoice Item. 
    /// </summary>
    /// <value>An array of revenue distributions. Represents how you want to distribute revenue for this revenue schedule. You can distribute revenue into a maximum of 250 accounting periods with one revenue schedule.  The sum of newAmounts must equal the the Charge Amount of the specified Invoice Item. </value>
    [DataMember(Name="revenueDistributions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueDistributions")]
    public List<POSTDistributionItemType> RevenueDistributions { get; set; }

    /// <summary>
    /// Gets or Sets RevenueEvent
    /// </summary>
    [DataMember(Name="revenueEvent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueEvent")]
    public POSTRevenueScheduleByTransactionTypeRevenueEvent RevenueEvent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTRevenueScheduleByTransactionType {\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  RevenueDistributions: ").Append(RevenueDistributions).Append("\n");
      sb.Append("  RevenueEvent: ").Append(RevenueEvent).Append("\n");
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
