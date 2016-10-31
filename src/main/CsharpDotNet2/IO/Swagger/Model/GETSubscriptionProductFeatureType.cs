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
  public class GETSubscriptionProductFeatureType {
    /// <summary>
    /// Feature description. 
    /// </summary>
    /// <value>Feature description. </value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Feature code, up to 255 characters long. 
    /// </summary>
    /// <value>Feature code, up to 255 characters long. </value>
    [DataMember(Name="featureCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureCode")]
    public string FeatureCode { get; set; }

    /// <summary>
    /// SubscriptionProductFeature ID. 
    /// </summary>
    /// <value>SubscriptionProductFeature ID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Feature name, up to 255 characters long. 
    /// </summary>
    /// <value>Feature name, up to 255 characters long. </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETSubscriptionProductFeatureType {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  FeatureCode: ").Append(FeatureCode).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
