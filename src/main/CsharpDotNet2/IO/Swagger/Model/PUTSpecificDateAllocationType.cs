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
  public class PUTSpecificDateAllocationType {
    /// <summary>
    /// The revenue schedule amount, which is the sum of all revenue items. This field cannot be null and must be formatted based on the currency, such as `JPY 30` or `USD 30.15`. Test out the currency to ensure you are using the proper formatting otherwise, the response will fail and this error message is returned: `Allocation amount with wrong decimal places.` 
    /// </summary>
    /// <value>The revenue schedule amount, which is the sum of all revenue items. This field cannot be null and must be formatted based on the currency, such as `JPY 30` or `USD 30.15`. Test out the currency to ensure you are using the proper formatting otherwise, the response will fail and this error message is returned: `Allocation amount with wrong decimal places.` </value>
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
    /// The recognition date on which to distribute revenue for milestone-based recognition.  Type: date in `YYYY-MM-DD` format. 
    /// </summary>
    /// <value>The recognition date on which to distribute revenue for milestone-based recognition.  Type: date in `YYYY-MM-DD` format. </value>
    [DataMember(Name="distributeOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distributeOn")]
    public DateTime? DistributeOn { get; set; }

    /// <summary>
    /// How to distribute the revenue for milestone-based recognition.  Possible values are: * specific date (delta fixed amount) * specific date (delta percent total) * specific date (delta percent undistributed) 
    /// </summary>
    /// <value>How to distribute the revenue for milestone-based recognition.  Possible values are: * specific date (delta fixed amount) * specific date (delta percent total) * specific date (delta percent undistributed) </value>
    [DataMember(Name="distributionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distributionType")]
    public string DistributionType { get; set; }

    /// <summary>
    /// Label of the revenue event type. Revenue event type labels can be duplicated. You can configure your revenue event type labels by navigating to **Settings > Z-Finance Settings > Configure Revenue Event Types** in the Zuora UI. The default revenue event types are: * Invoice Posted * Invoice Item Adjustment Created * Invoice Canceled * Invoice Item Adjustment Canceled * Revenue Distributed 
    /// </summary>
    /// <value>Label of the revenue event type. Revenue event type labels can be duplicated. You can configure your revenue event type labels by navigating to **Settings > Z-Finance Settings > Configure Revenue Event Types** in the Zuora UI. The default revenue event types are: * Invoice Posted * Invoice Item Adjustment Created * Invoice Canceled * Invoice Item Adjustment Canceled * Revenue Distributed </value>
    [DataMember(Name="eventType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventType")]
    public string EventType { get; set; }

    /// <summary>
    /// System ID of the revenue event type. Each eventType has a unique system ID. You can configure your revenue event type system IDs by navigating to **Settings > Z-Finance Settings > Configure Revenue Event Types** in the Zuora UI. 
    /// </summary>
    /// <value>System ID of the revenue event type. Each eventType has a unique system ID. You can configure your revenue event type system IDs by navigating to **Settings > Z-Finance Settings > Configure Revenue Event Types** in the Zuora UI. </value>
    [DataMember(Name="eventTypeSystemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventTypeSystemId")]
    public string EventTypeSystemId { get; set; }

    /// <summary>
    /// Additional information about this record. 
    /// </summary>
    /// <value>Additional information about this record. </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// Percentage of the total recognition amount or total undistributed to distribute.  Required if distributionType is either: * specific date (delta percent total) * specific date (delta percent undistributed) 
    /// </summary>
    /// <value>Percentage of the total recognition amount or total undistributed to distribute.  Required if distributionType is either: * specific date (delta percent total) * specific date (delta percent undistributed) </value>
    [DataMember(Name="percentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "percentage")]
    public string Percentage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PUTSpecificDateAllocationType {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  DistributeOn: ").Append(DistributeOn).Append("\n");
      sb.Append("  DistributionType: ").Append(DistributionType).Append("\n");
      sb.Append("  EventType: ").Append(EventType).Append("\n");
      sb.Append("  EventTypeSystemId: ").Append(EventTypeSystemId).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  Percentage: ").Append(Percentage).Append("\n");
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
