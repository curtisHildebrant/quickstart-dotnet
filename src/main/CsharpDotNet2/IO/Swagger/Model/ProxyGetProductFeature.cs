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
  public class ProxyGetProductFeature {
    /// <summary>
    /// The ID of the Zuora user who created the Account object. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value>The ID of the Zuora user who created the Account object. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    /// The date when the Account object was created. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value>The date when the Account object was created. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    ///  Internal Zuora ID of the product feature. This field is not editable. **Character limit**: 32 **Values**: a string of 32 characters or fewer 
    /// </summary>
    /// <value> Internal Zuora ID of the product feature. This field is not editable. **Character limit**: 32 **Values**: a string of 32 characters or fewer </value>
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
    ///  Id of the product to which the feature belongs. This field is not editable. **Character limit**: 32 **Values**: a string of 32 characters or fewer 
    /// </summary>
    /// <value> Id of the product to which the feature belongs. This field is not editable. **Character limit**: 32 **Values**: a string of 32 characters or fewer </value>
    [DataMember(Name="ProductId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductId")]
    public string ProductId { get; set; }

    /// <summary>
    /// The ID of the user who last updated the account. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value>The ID of the user who last updated the account. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    /// The date when the account was last updated. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value>The date when the account was last updated. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetProductFeature {\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  FeatureId: ").Append(FeatureId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ProductId: ").Append(ProductId).Append("\n");
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
