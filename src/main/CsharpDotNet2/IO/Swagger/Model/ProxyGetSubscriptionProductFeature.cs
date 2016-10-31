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
  public class ProxyGetSubscriptionProductFeature {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  Date and time when the product feature was added to the subscription. **Character limit**: 29 **Values**: 
    /// </summary>
    /// <value> Date and time when the product feature was added to the subscription. **Character limit**: 29 **Values**: </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    ///  Description of the subscription product feature. **Character limit**: 500 **Values**: 
    /// </summary>
    /// <value> Description of the subscription product feature. **Character limit**: 500 **Values**: </value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    ///  Unique code of the feature. **Character limit**: 255 **Values**: 
    /// </summary>
    /// <value> Unique code of the feature. **Character limit**: 255 **Values**: </value>
    [DataMember(Name="FeatureCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FeatureCode")]
    public string FeatureCode { get; set; }

    /// <summary>
    ///  Internal Zuora ID of the feature. **Character limit**: 32 **Values**: 
    /// </summary>
    /// <value> Internal Zuora ID of the feature. **Character limit**: 32 **Values**: </value>
    [DataMember(Name="FeatureId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FeatureId")]
    public string FeatureId { get; set; }

    /// <summary>
    /// Object identifier.
    /// </summary>
    /// <value>Object identifier.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    ///  Name of the feature. **Character limit**: 255 **Values**: 
    /// </summary>
    /// <value> Name of the feature. **Character limit**: 255 **Values**: </value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    ///  Id of the product rate plan to which the feature belongs. **Character limit**: 32 **Values**: 
    /// </summary>
    /// <value> Id of the product rate plan to which the feature belongs. **Character limit**: 32 **Values**: </value>
    [DataMember(Name="RatePlanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RatePlanId")]
    public string RatePlanId { get; set; }

    /// <summary>
    ///  Internal Zuora ID of the user who last updated the subscription product feature. **Character limit**: 32 **Values**: 
    /// </summary>
    /// <value> Internal Zuora ID of the user who last updated the subscription product feature. **Character limit**: 32 **Values**: </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    ///  Date and time when the subscription product feature was last updated. **Character limit**: 29 **Values**: 
    /// </summary>
    /// <value> Date and time when the subscription product feature was last updated. **Character limit**: 29 **Values**: </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetSubscriptionProductFeature {\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  FeatureCode: ").Append(FeatureCode).Append("\n");
      sb.Append("  FeatureId: ").Append(FeatureId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  RatePlanId: ").Append(RatePlanId).Append("\n");
      sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
