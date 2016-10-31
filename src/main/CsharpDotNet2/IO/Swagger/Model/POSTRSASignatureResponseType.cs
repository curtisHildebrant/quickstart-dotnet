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
  public class POSTRSASignatureResponseType {
    /// <summary>
    /// Public key generated for this Payment Page. 
    /// </summary>
    /// <value>Public key generated for this Payment Page. </value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// Digital signature generated for this Payment Page. 
    /// </summary>
    /// <value>Digital signature generated for this Payment Page. </value>
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
    /// ID of the Zuora tenant. 
    /// </summary>
    /// <value>ID of the Zuora tenant. </value>
    [DataMember(Name="tenantId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tenantId")]
    public string TenantId { get; set; }

    /// <summary>
    /// Token generated for this Payment Page. 
    /// </summary>
    /// <value>Token generated for this Payment Page. </value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTRSASignatureResponseType {\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  Signature: ").Append(Signature).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
