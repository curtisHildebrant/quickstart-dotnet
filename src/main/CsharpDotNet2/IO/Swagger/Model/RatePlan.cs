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
  public class RatePlan {
    /// <summary>
    ///  The ID of the amendment associated with the rate plan. This field only applies to amendment rate plans. **Character limit**: 32 **Values**: a valid amendment ID 
    /// </summary>
    /// <value> The ID of the amendment associated with the rate plan. This field only applies to amendment rate plans. **Character limit**: 32 **Values**: a valid amendment ID </value>
    [DataMember(Name="AmendmentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AmendmentId")]
    public string AmendmentId { get; set; }

    /// <summary>
    /// The ID of the subscription rate plan modified by the amendment. This field only applies to amendment rate plans. **Character limit**: 32 **Values**: a valid rate plan ID 
    /// </summary>
    /// <value>The ID of the subscription rate plan modified by the amendment. This field only applies to amendment rate plans. **Character limit**: 32 **Values**: a valid rate plan ID </value>
    [DataMember(Name="AmendmentSubscriptionRatePlanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AmendmentSubscriptionRatePlanId")]
    public string AmendmentSubscriptionRatePlanId { get; set; }

    /// <summary>
    /// The type of amendment associated with the rate plan. This field only applies to amendment rate plans. **Character limit**: 18 **Values**: inherited from `Amendment.Type` 
    /// </summary>
    /// <value>The type of amendment associated with the rate plan. This field only applies to amendment rate plans. **Character limit**: 18 **Values**: inherited from `Amendment.Type` </value>
    [DataMember(Name="AmendmentType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AmendmentType")]
    public string AmendmentType { get; set; }

    /// <summary>
    /// The ID of the Zuora user who created the RatePlan object. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value>The ID of the Zuora user who created the RatePlan object. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    /// The date when the `RatePlan` object was last updated. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value>The date when the `RatePlan` object was last updated. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The ID of this object. Upon creation, the ID of this object is `RatePlanId`. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value>The ID of this object. Upon creation, the ID of this object is `RatePlanId`. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// The name of the rate plan. Leave this null in a subscribe() call to to inherited the `ProductRatePlan.Name` field value. **Character limit**: 100 **Values**: a string of 100 characters or fewer or inherited from ProductRatePlan.Name 
    /// </summary>
    /// <value>The name of the rate plan. Leave this null in a subscribe() call to to inherited the `ProductRatePlan.Name` field value. **Character limit**: 100 **Values**: a string of 100 characters or fewer or inherited from ProductRatePlan.Name </value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// The ID of the associated product rate plan. **Character limit**: 32 **Values**: a valid product rate plan ID 
    /// </summary>
    /// <value>The ID of the associated product rate plan. **Character limit**: 32 **Values**: a valid product rate plan ID </value>
    [DataMember(Name="ProductRatePlanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductRatePlanId")]
    public string ProductRatePlanId { get; set; }

    /// <summary>
    /// The ID of the subscription that the rate plan belongs to. **Character limit**: 32 **Values**: a valid subscription ID 
    /// </summary>
    /// <value>The ID of the subscription that the rate plan belongs to. **Character limit**: 32 **Values**: a valid subscription ID </value>
    [DataMember(Name="SubscriptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubscriptionId")]
    public string SubscriptionId { get; set; }

    /// <summary>
    ///  The ID of the user who last updated the rate plan. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the user who last updated the rate plan. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    ///  The date when the rate plan was last updated. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the rate plan was last updated. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="fieldsToNull", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldsToNull")]
    public string FieldsToNull { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RatePlan {\n");
      sb.Append("  AmendmentId: ").Append(AmendmentId).Append("\n");
      sb.Append("  AmendmentSubscriptionRatePlanId: ").Append(AmendmentSubscriptionRatePlanId).Append("\n");
      sb.Append("  AmendmentType: ").Append(AmendmentType).Append("\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ProductRatePlanId: ").Append(ProductRatePlanId).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
      sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
      sb.Append("  FieldsToNull: ").Append(FieldsToNull).Append("\n");
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
