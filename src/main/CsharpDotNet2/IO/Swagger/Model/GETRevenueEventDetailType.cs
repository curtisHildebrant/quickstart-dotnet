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
  public class GETRevenueEventDetailType {
    /// <summary>
    /// An account ID. 
    /// </summary>
    /// <value>An account ID. </value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public string AccountId { get; set; }

    /// <summary>
    /// The date when the record was created in YYYY-MM-DD HH:MM:SS format. 
    /// </summary>
    /// <value>The date when the record was created in YYYY-MM-DD HH:MM:SS format. </value>
    [DataMember(Name="createdOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdOn")]
    public DateTime? CreatedOn { get; set; }

    /// <summary>
    /// The type of currency used.  
    /// </summary>
    /// <value>The type of currency used.  </value>
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
    /// Label of the revenue event type. Revenue event type labels can be duplicated. You can configure your revenue event type labels by navigating to **Settings > Z-Finance Settings > Configure Revenue Event Types** in the Zuora UI. The default revenue event types are:    * Invoice Posted   * Invoice Item Adjustment Created   * Invoice Canceled   * Invoice Item Adjustment Canceled   * Revenue Distributed 
    /// </summary>
    /// <value>Label of the revenue event type. Revenue event type labels can be duplicated. You can configure your revenue event type labels by navigating to **Settings > Z-Finance Settings > Configure Revenue Event Types** in the Zuora UI. The default revenue event types are:    * Invoice Posted   * Invoice Item Adjustment Created   * Invoice Canceled   * Invoice Item Adjustment Canceled   * Revenue Distributed </value>
    [DataMember(Name="eventType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventType")]
    public string EventType { get; set; }

    /// <summary>
    /// Additional information about this record. 
    /// </summary>
    /// <value>Additional information about this record. </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// The revenue event number created when a revenue event occurs. 
    /// </summary>
    /// <value>The revenue event number created when a revenue event occurs. </value>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public string Number { get; set; }

    /// <summary>
    /// The end date of a recognition period in YYYY-MM-DD format.   The maximum difference of the recognitionStart and recognitionEnd date fields is equal to 250 multiplied by the length of an accounting period. 
    /// </summary>
    /// <value>The end date of a recognition period in YYYY-MM-DD format.   The maximum difference of the recognitionStart and recognitionEnd date fields is equal to 250 multiplied by the length of an accounting period. </value>
    [DataMember(Name="recognitionEnd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recognitionEnd")]
    public DateTime? RecognitionEnd { get; set; }

    /// <summary>
    /// The start date of a recognition period in YYYY-MM-DD format. 
    /// </summary>
    /// <value>The start date of a recognition period in YYYY-MM-DD format. </value>
    [DataMember(Name="recognitionStart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recognitionStart")]
    public DateTime? RecognitionStart { get; set; }

    /// <summary>
    /// Revenue items are listed in ascending order by the accounting period start date. 
    /// </summary>
    /// <value>Revenue items are listed in ascending order by the accounting period start date. </value>
    [DataMember(Name="revenueItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueItems")]
    public List<GETRevenueItemType> RevenueItems { get; set; }

    /// <summary>
    /// The original subscription charge ID. 
    /// </summary>
    /// <value>The original subscription charge ID. </value>
    [DataMember(Name="subscriptionChargeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionChargeId")]
    public string SubscriptionChargeId { get; set; }

    /// <summary>
    /// The original subscription ID. 
    /// </summary>
    /// <value>The original subscription ID. </value>
    [DataMember(Name="subscriptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionId")]
    public string SubscriptionId { get; set; }

    /// <summary>
    /// Returns `true` if the request was processed successfully. 
    /// </summary>
    /// <value>Returns `true` if the request was processed successfully. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETRevenueEventDetailType {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  EventType: ").Append(EventType).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  RecognitionEnd: ").Append(RecognitionEnd).Append("\n");
      sb.Append("  RecognitionStart: ").Append(RecognitionStart).Append("\n");
      sb.Append("  RevenueItems: ").Append(RevenueItems).Append("\n");
      sb.Append("  SubscriptionChargeId: ").Append(SubscriptionChargeId).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
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
