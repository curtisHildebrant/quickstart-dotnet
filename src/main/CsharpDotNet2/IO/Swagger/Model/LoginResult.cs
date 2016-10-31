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
  public class LoginResult {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="ServerUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServerUrl")]
    public string ServerUrl { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Session", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Session")]
    public string Session { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LoginResult {\n");
      sb.Append("  ServerUrl: ").Append(ServerUrl).Append("\n");
      sb.Append("  Session: ").Append(Session).Append("\n");
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
