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
  public class POSTDecryptResponseType {
    /// <summary>
    /// The string of a list of the following items: Payment Pages 2.0 URL, tenant ID, timestamp,the Payment Page ID  The items are separated by '#', e.g., \"/apps/publichostedpagelite.do#12271#rvBp1AxBJwk6FrT7aqFuABIINiRbwJCc #1418848373103#2c92c0f948f899\" 
    /// </summary>
    /// <value>The string of a list of the following items: Payment Pages 2.0 URL, tenant ID, timestamp,the Payment Page ID  The items are separated by '#', e.g., \"/apps/publichostedpagelite.do#12271#rvBp1AxBJwk6FrT7aqFuABIINiRbwJCc #1418848373103#2c92c0f948f899\" </value>
    [DataMember(Name="decryptedSignature", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "decryptedSignature")]
    public string DecryptedSignature { get; set; }

    /// <summary>
    /// The public key passed in as a request parameter. 
    /// </summary>
    /// <value>The public key passed in as a request parameter. </value>
    [DataMember(Name="publicKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publicKey")]
    public string PublicKey { get; set; }

    /// <summary>
    /// The signature passed in as a request parameter. 
    /// </summary>
    /// <value>The signature passed in as a request parameter. </value>
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTDecryptResponseType {\n");
      sb.Append("  DecryptedSignature: ").Append(DecryptedSignature).Append("\n");
      sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
      sb.Append("  Signature: ").Append(Signature).Append("\n");
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
