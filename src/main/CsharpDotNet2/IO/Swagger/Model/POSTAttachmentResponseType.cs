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
  public class POSTAttachmentResponseType {
    /// <summary>
    /// Id to identify the attached file. 
    /// </summary>
    /// <value>Id to identify the attached file. </value>
    [DataMember(Name="fileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileId")]
    public string FileId { get; set; }

    /// <summary>
    /// Attachment id. 
    /// </summary>
    /// <value>Attachment id. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

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
      sb.Append("class POSTAttachmentResponseType {\n");
      sb.Append("  FileId: ").Append(FileId).Append("\n");
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
