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
  public class PreviewOptions {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="EnablePreviewMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EnablePreviewMode")]
    public bool? EnablePreviewMode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="IncludeExistingDraftInvoiceItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IncludeExistingDraftInvoiceItems")]
    public bool? IncludeExistingDraftInvoiceItems { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="NumberOfPeriods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NumberOfPeriods")]
    public int? NumberOfPeriods { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PreviewThroughTermEnd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PreviewThroughTermEnd")]
    public bool? PreviewThroughTermEnd { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PreviewType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PreviewType")]
    public string PreviewType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PreviewOptions {\n");
      sb.Append("  EnablePreviewMode: ").Append(EnablePreviewMode).Append("\n");
      sb.Append("  IncludeExistingDraftInvoiceItems: ").Append(IncludeExistingDraftInvoiceItems).Append("\n");
      sb.Append("  NumberOfPeriods: ").Append(NumberOfPeriods).Append("\n");
      sb.Append("  PreviewThroughTermEnd: ").Append(PreviewThroughTermEnd).Append("\n");
      sb.Append("  PreviewType: ").Append(PreviewType).Append("\n");
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
