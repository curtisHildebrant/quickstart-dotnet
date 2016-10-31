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
  public class GETInvoiceFileType {
    /// <summary>
    /// ID of the invoice PDF file. This is the ID for the file object and different from the file handle id in the pdfFileUrl field. To open a file, you need to use the file handle ID. 
    /// </summary>
    /// <value>ID of the invoice PDF file. This is the ID for the file object and different from the file handle id in the pdfFileUrl field. To open a file, you need to use the file handle ID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// REST URL for the invoice PDF file. Click the URL to open the invoice PDF file. 
    /// </summary>
    /// <value>REST URL for the invoice PDF file. Click the URL to open the invoice PDF file. </value>
    [DataMember(Name="pdfFileUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pdfFileUrl")]
    public string PdfFileUrl { get; set; }

    /// <summary>
    /// Version number of the invoice PDF file 
    /// </summary>
    /// <value>Version number of the invoice PDF file </value>
    [DataMember(Name="versionNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionNumber")]
    public long? VersionNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETInvoiceFileType {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  PdfFileUrl: ").Append(PdfFileUrl).Append("\n");
      sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
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
