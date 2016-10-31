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
  public class GETAttachmentResponseType {
    /// <summary>
    /// Zuora user id who added this attachment to the object. 
    /// </summary>
    /// <value>Zuora user id who added this attachment to the object. </value>
    [DataMember(Name="createdBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdBy")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// Date and time when the attachment was added to the object. 
    /// </summary>
    /// <value>Date and time when the attachment was added to the object. </value>
    [DataMember(Name="createdOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdOn")]
    public DateTime? CreatedOn { get; set; }

    /// <summary>
    /// Description of the attachment. 
    /// </summary>
    /// <value>Description of the attachment. </value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// File type. 
    /// </summary>
    /// <value>File type. </value>
    [DataMember(Name="fileContentType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileContentType")]
    public string FileContentType { get; set; }

    /// <summary>
    /// File id of the attached file. 
    /// </summary>
    /// <value>File id of the attached file. </value>
    [DataMember(Name="fileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileId")]
    public string FileId { get; set; }

    /// <summary>
    /// Attachment file name. 
    /// </summary>
    /// <value>Attachment file name. </value>
    [DataMember(Name="fileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileName")]
    public string FileName { get; set; }

    /// <summary>
    /// Id of this attachment. 
    /// </summary>
    /// <value>Id of this attachment. </value>
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
    /// Zuora user id who last updated the attachment. 
    /// </summary>
    /// <value>Zuora user id who last updated the attachment. </value>
    [DataMember(Name="updatedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedBy")]
    public string UpdatedBy { get; set; }

    /// <summary>
    /// Date and time when the attachment was last updated. 
    /// </summary>
    /// <value>Date and time when the attachment was last updated. </value>
    [DataMember(Name="updatedOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedOn")]
    public DateTime? UpdatedOn { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAttachmentResponseType {\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
      sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  FileContentType: ").Append(FileContentType).Append("\n");
      sb.Append("  FileId: ").Append(FileId).Append("\n");
      sb.Append("  FileName: ").Append(FileName).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
      sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
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
