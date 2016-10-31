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
  public class ProxyGetFeature {
    /// <summary>
    ///  Internal Zuora ID of the user who created the feature **Character limit**: 32 
    /// </summary>
    /// <value> Internal Zuora ID of the user who created the feature **Character limit**: 32 </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  Date and time when the feature was created **Character limit**: 29 
    /// </summary>
    /// <value> Date and time when the feature was created **Character limit**: 29 </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    ///  Description of the feature **Character limit**: 1000 
    /// </summary>
    /// <value> Description of the feature **Character limit**: 1000 </value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    ///  Unique code of the feature **Character limit**: 255 
    /// </summary>
    /// <value> Unique code of the feature **Character limit**: 255 </value>
    [DataMember(Name="FeatureCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FeatureCode")]
    public string FeatureCode { get; set; }

    /// <summary>
    /// Object identifier.
    /// </summary>
    /// <value>Object identifier.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    ///  Name of the feature **Character limit**: 255 
    /// </summary>
    /// <value> Name of the feature **Character limit**: 255 </value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    ///  Status of the feature, Active or Inactive **Character limit**: 8 
    /// </summary>
    /// <value> Status of the feature, Active or Inactive **Character limit**: 8 </value>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    ///  Internal Zuora ID of the user who last updated the feature **Character limit**: 32 
    /// </summary>
    /// <value> Internal Zuora ID of the user who last updated the feature **Character limit**: 32 </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    ///  Date and time when the feature was last updated **Character limit**: 29 
    /// </summary>
    /// <value> Date and time when the feature was last updated **Character limit**: 29 </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetFeature {\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  FeatureCode: ").Append(FeatureCode).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
