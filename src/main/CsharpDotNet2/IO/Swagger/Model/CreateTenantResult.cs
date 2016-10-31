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
  public class CreateTenantResult {
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
    [DataMember(Name="Success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="TenantId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TenantId")]
    public string TenantId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="UserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserId")]
    public string UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateTenantResult {\n");
      sb.Append("  Errors: ").Append(Errors).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  TenantId: ").Append(TenantId).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
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
