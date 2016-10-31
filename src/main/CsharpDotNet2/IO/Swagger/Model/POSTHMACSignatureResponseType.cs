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
  public class POSTHMACSignatureResponseType {
    /// <summary>
    /// Contains a keyed-hash message authentication code (HMAC) e.g. `ZmI0ZjE2ZTMxMWY1YjA0ZTc4MTg1ZDhlYWRkMTEwNDE3M2RiMzNiNQ==<` 
    /// </summary>
    /// <value>Contains a keyed-hash message authentication code (HMAC) e.g. `ZmI0ZjE2ZTMxMWY1YjA0ZTc4MTg1ZDhlYWRkMTEwNDE3M2RiMzNiNQ==<` </value>
    [DataMember(Name="signature", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signature")]
    public string Signature { get; set; }

    /// <summary>
    /// Returns `true` if the request was processed successfully. 
    /// </summary>
    /// <value>Returns `true` if the request was processed successfully. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// cContains a token code. e.g. `gCH6gYqQffQCsFKSLuxyagXsuXcIK0uf` 
    /// </summary>
    /// <value>cContains a token code. e.g. `gCH6gYqQffQCsFKSLuxyagXsuXcIK0uf` </value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTHMACSignatureResponseType {\n");
      sb.Append("  Signature: ").Append(Signature).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
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
