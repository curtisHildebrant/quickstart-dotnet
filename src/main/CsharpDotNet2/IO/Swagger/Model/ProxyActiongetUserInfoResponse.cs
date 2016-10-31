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
  public class ProxyActiongetUserInfoResponse {
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
    [DataMember(Name="TenantName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TenantName")]
    public string TenantName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="UserEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserEmail")]
    public string UserEmail { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="UserFullName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserFullName")]
    public string UserFullName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="UserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserId")]
    public string UserId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyActiongetUserInfoResponse {\n");
      sb.Append("  TenantId: ").Append(TenantId).Append("\n");
      sb.Append("  TenantName: ").Append(TenantName).Append("\n");
      sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
      sb.Append("  UserFullName: ").Append(UserFullName).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
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
