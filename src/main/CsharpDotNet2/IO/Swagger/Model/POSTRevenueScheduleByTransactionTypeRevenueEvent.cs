using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a change to a revenue schedule, such as posting an invoice or distributing revenue.  You must specify the &#x60;eventType&#x60; or the &#x60;eventTypeSystemID&#x60;, or both. If you have configured more than one revenue event type with the same label, you must specify the &#x60;eventTypeSystemId&#x60;. 
  /// </summary>
  [DataContract]
  public class POSTRevenueScheduleByTransactionTypeRevenueEvent {
    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Label of the revenue event type. Revenue event type labels can be duplicated. You can configure your revenue event type labels by navigating to **Settings > Z-Finance Settings > Configure Revenue Event Types** in the Zuora UI. The default revenue event types are: * Invoice Posted * Invoice Item Adjustment Created * Invoice Canceled * Invoice Item Adjustment Canceled * Revenue Distributed 
    /// </summary>
    /// <value>Label of the revenue event type. Revenue event type labels can be duplicated. You can configure your revenue event type labels by navigating to **Settings > Z-Finance Settings > Configure Revenue Event Types** in the Zuora UI. The default revenue event types are: * Invoice Posted * Invoice Item Adjustment Created * Invoice Canceled * Invoice Item Adjustment Canceled * Revenue Distributed </value>
    [DataMember(Name="eventType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventType")]
    public string EventType { get; set; }

    /// <summary>
    /// System ID of the revenue event type. Each eventType has a unique system ID. You can configure your revenue event type system IDs by navigating to **Settings > Z-Finance Settings > Configure Revenue Event Types** in the Zuora UI.  Required only if there is more than one revenue event type with the same label. 
    /// </summary>
    /// <value>System ID of the revenue event type. Each eventType has a unique system ID. You can configure your revenue event type system IDs by navigating to **Settings > Z-Finance Settings > Configure Revenue Event Types** in the Zuora UI.  Required only if there is more than one revenue event type with the same label. </value>
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTRevenueScheduleByTransactionTypeRevenueEvent {\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  EventType: ").Append(EventType).Append("\n");
      sb.Append("  EventTypeSystemId: ").Append(EventTypeSystemId).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
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
