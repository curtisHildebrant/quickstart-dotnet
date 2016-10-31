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
  public class SaveResult {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Errors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Errors")]
    public List<Error> Errors { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Success")]
    public bool? Success { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SaveResult {\n");
      sb.Append("  Errors: ").Append(Errors).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
