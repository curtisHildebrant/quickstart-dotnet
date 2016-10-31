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
  public class PUTAllocateManuallyType {
    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Label of the revenue event type. Revenue event type labels can be duplicated. You can configure your revenue event type labels by navigating to **Settings > Z-Finance Settings > Configure Revenue Event Types** in the Zuora UI. The default revenue event types are: * Invoice Posted * Invoice Item Adjustment Created * Invoice Canceled * Invoice Item Adjustment Canceled * Revenue Distributed  You can create revenue event types from **Finance Settings > Revenue Event Types**. 
    /// </summary>
    /// <value>Label of the revenue event type. Revenue event type labels can be duplicated. You can configure your revenue event type labels by navigating to **Settings > Z-Finance Settings > Configure Revenue Event Types** in the Zuora UI. The default revenue event types are: * Invoice Posted * Invoice Item Adjustment Created * Invoice Canceled * Invoice Item Adjustment Canceled * Revenue Distributed  You can create revenue event types from **Finance Settings > Revenue Event Types**. </value>
    [DataMember(Name="eventType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventType")]
    public string EventType { get; set; }

    /// <summary>
    /// System ID of the revenue event type. Each eventType has a unique system ID. You can configure your revenue event type system IDs by navigating to **Settings > Z-Finance Settings > Configure Revenue Event Types** in the Zuora UI.  Cannot be duplicated. 
    /// </summary>
    /// <value>System ID of the revenue event type. Each eventType has a unique system ID. You can configure your revenue event type system IDs by navigating to **Settings > Z-Finance Settings > Configure Revenue Event Types** in the Zuora UI.  Cannot be duplicated. </value>
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
    /// An array of revenue distributions. Represents how you want to distribute revenue for this revenue schedule. You can distribute revenue into a maximum of 250 accounting periods with one revenue schedule. 
    /// </summary>
    /// <value>An array of revenue distributions. Represents how you want to distribute revenue for this revenue schedule. You can distribute revenue into a maximum of 250 accounting periods with one revenue schedule. </value>
    [DataMember(Name="revenueDistributions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueDistributions")]
    public List<POSTDistributionItemType> RevenueDistributions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PUTAllocateManuallyType {\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  EventType: ").Append(EventType).Append("\n");
      sb.Append("  EventTypeSystemId: ").Append(EventTypeSystemId).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  RevenueDistributions: ").Append(RevenueDistributions).Append("\n");
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
