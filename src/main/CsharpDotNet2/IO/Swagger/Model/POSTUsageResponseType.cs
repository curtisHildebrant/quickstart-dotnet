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
  public class POSTUsageResponseType {
    /// <summary>
    /// URL for checking the status of the import operation.  Possible status values at this URL are:`Pending`, `Processing`, `Completed`, `Canceled`, `Failed`.  Only a status of Completed indicates that the file contents were imported successfully. 
    /// </summary>
    /// <value>URL for checking the status of the import operation.  Possible status values at this URL are:`Pending`, `Processing`, `Completed`, `Canceled`, `Failed`.  Only a status of Completed indicates that the file contents were imported successfully. </value>
    [DataMember(Name="checkImportStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkImportStatus")]
    public string CheckImportStatus { get; set; }

    /// <summary>
    /// The size of the uploaded file in bytes. 
    /// </summary>
    /// <value>The size of the uploaded file in bytes. </value>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public long? Size { get; set; }

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
      sb.Append("class POSTUsageResponseType {\n");
      sb.Append("  CheckImportStatus: ").Append(CheckImportStatus).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
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
