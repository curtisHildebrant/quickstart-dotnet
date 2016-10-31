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
  public class POSTRevenueScheduleByDateRangeType {
    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// How you want to distribute the revenue. The distribution types are:  * Daily Distribution: Distributes revenue evenly across each day between the recognitionStart and recognitionEnd dates. * Monthly Distribution (Back Load): Back loads the revenue so you distribute the monthly amount in the partial month at the end only. * Monthly Distribution (Front Load): Front loads the revenue so you distribute the monthly amount in the partial month at the beginning only. * Monthly Distribution (Proration by Days): Splits the revenue amount between the two partial months.  See [Components and Configuration Options](https://knowledgecenter.zuora.com/CC_Finance/Revenue_Recognition/Revenue_Rule_Models/C_Revenue_Rule_Model_Components#Distribution) for more information about Front Load, Back Load, and Proration by Days for Monthly Distribution.  **Note:** To use any of the Monthly Distribution options, you must have the \"Monthly recognition over time\" model enabled in **Settings > Z-Finance Settings > Manage Revenue Recognition Models**.  
    /// </summary>
    /// <value>How you want to distribute the revenue. The distribution types are:  * Daily Distribution: Distributes revenue evenly across each day between the recognitionStart and recognitionEnd dates. * Monthly Distribution (Back Load): Back loads the revenue so you distribute the monthly amount in the partial month at the end only. * Monthly Distribution (Front Load): Front loads the revenue so you distribute the monthly amount in the partial month at the beginning only. * Monthly Distribution (Proration by Days): Splits the revenue amount between the two partial months.  See [Components and Configuration Options](https://knowledgecenter.zuora.com/CC_Finance/Revenue_Recognition/Revenue_Rule_Models/C_Revenue_Rule_Model_Components#Distribution) for more information about Front Load, Back Load, and Proration by Days for Monthly Distribution.  **Note:** To use any of the Monthly Distribution options, you must have the \"Monthly recognition over time\" model enabled in **Settings > Z-Finance Settings > Manage Revenue Recognition Models**.  </value>
    [DataMember(Name="distributionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distributionType")]
    public string DistributionType { get; set; }

    /// <summary>
    /// Additional information about this record. 
    /// </summary>
    /// <value>Additional information about this record. </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// The end date of a recognition period in `YYYY-MM-DD` format.   The maximum difference of the `recognitionStart` and `recognitionEnd` date fields is equal to 250 multiplied by the length of an accounting period. 
    /// </summary>
    /// <value>The end date of a recognition period in `YYYY-MM-DD` format.   The maximum difference of the `recognitionStart` and `recognitionEnd` date fields is equal to 250 multiplied by the length of an accounting period. </value>
    [DataMember(Name="recognitionEnd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recognitionEnd")]
    public DateTime? RecognitionEnd { get; set; }

    /// <summary>
    /// The start date of a recognition period in `YYYY-MM-DD` format.  If there is a closed accounting period between the `recognitionStart` and `recognitionEnd` dates, the revenue that would be placed in the closed accounting period is instead placed in the next open accounting period. 
    /// </summary>
    /// <value>The start date of a recognition period in `YYYY-MM-DD` format.  If there is a closed accounting period between the `recognitionStart` and `recognitionEnd` dates, the revenue that would be placed in the closed accounting period is instead placed in the next open accounting period. </value>
    [DataMember(Name="recognitionStart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recognitionStart")]
    public DateTime? RecognitionStart { get; set; }

    /// <summary>
    /// Gets or Sets RevenueEvent
    /// </summary>
    [DataMember(Name="revenueEvent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueEvent")]
    public POSTRevenueScheduleByDateRangeTypeRevenueEvent RevenueEvent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTRevenueScheduleByDateRangeType {\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  DistributionType: ").Append(DistributionType).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  RecognitionEnd: ").Append(RecognitionEnd).Append("\n");
      sb.Append("  RecognitionStart: ").Append(RecognitionStart).Append("\n");
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
