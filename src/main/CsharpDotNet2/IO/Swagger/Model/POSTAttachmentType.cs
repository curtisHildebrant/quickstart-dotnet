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
  public class POSTAttachmentType {
    /// <summary>
    /// The file to be attached. Must be multipart/form-data. The maximum file size is 4 MB. Files with the following extensions are not supported: .exe, .sh, .dmg, .pkg, .cmd, .bat 
    /// </summary>
    /// <value>The file to be attached. Must be multipart/form-data. The maximum file size is 4 MB. Files with the following extensions are not supported: .exe, .sh, .dmg, .pkg, .cmd, .bat </value>
    [DataMember(Name="file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "file")]
    public string File { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTAttachmentType {\n");
      sb.Append("  File: ").Append(File).Append("\n");
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
