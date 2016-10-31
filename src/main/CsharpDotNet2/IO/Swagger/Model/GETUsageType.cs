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
  public class GETUsageType {
    /// <summary>
    /// Customer account ID. 
    /// </summary>
    /// <value>Customer account ID. </value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public string AccountId { get; set; }

    /// <summary>
    /// Customer account name. 
    /// </summary>
    /// <value>Customer account name. </value>
    [DataMember(Name="accountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Customer account number. 
    /// </summary>
    /// <value>Customer account number. </value>
    [DataMember(Name="accountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Number of the rate-plan charge that pays for this usage. 
    /// </summary>
    /// <value>Number of the rate-plan charge that pays for this usage. </value>
    [DataMember(Name="chargeNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeNumber")]
    public string ChargeNumber { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Unique ID for the usage item. 
    /// </summary>
    /// <value>Unique ID for the usage item. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Number of units used. 
    /// </summary>
    /// <value>Number of units used. </value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public string Quantity { get; set; }

    /// <summary>
    /// Source of the usage data. Possible values are: `Import`, `API`. 
    /// </summary>
    /// <value>Source of the usage data. Possible values are: `Import`, `API`. </value>
    [DataMember(Name="sourceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceName")]
    public string SourceName { get; set; }

    /// <summary>
    /// Start date of the time period in which usage is tracked. Zuora uses this field value to determine the usage date. 
    /// </summary>
    /// <value>Start date of the time period in which usage is tracked. Zuora uses this field value to determine the usage date. </value>
    [DataMember(Name="startDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDateTime")]
    public DateTime? StartDateTime { get; set; }

    /// <summary>
    /// Possible values are: `Importing`, `Pending`, `Processed`. 
    /// </summary>
    /// <value>Possible values are: `Importing`, `Pending`, `Processed`. </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Date when usage was submitted. 
    /// </summary>
    /// <value>Date when usage was submitted. </value>
    [DataMember(Name="submissionDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "submissionDateTime")]
    public DateTime? SubmissionDateTime { get; set; }

    /// <summary>
    /// Number of the subscription covering this usage. 
    /// </summary>
    /// <value>Number of the subscription covering this usage. </value>
    [DataMember(Name="subscriptionNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionNumber")]
    public string SubscriptionNumber { get; set; }

    /// <summary>
    /// Unit used to measure consumption, as configured in the web-based UI at **Z-Billing > Settings**. 
    /// </summary>
    /// <value>Unit used to measure consumption, as configured in the web-based UI at **Z-Billing > Settings**. </value>
    [DataMember(Name="unitOfMeasure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitOfMeasure")]
    public string UnitOfMeasure { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETUsageType {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  ChargeNumber: ").Append(ChargeNumber).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  SourceName: ").Append(SourceName).Append("\n");
      sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  SubmissionDateTime: ").Append(SubmissionDateTime).Append("\n");
      sb.Append("  SubscriptionNumber: ").Append(SubscriptionNumber).Append("\n");
      sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
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
