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
  public class GETJournalEntrySegmentType {
    /// <summary>
    /// Name of segment. 
    /// </summary>
    /// <value>Name of segment. </value>
    [DataMember(Name="segmentName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segmentName")]
    public string SegmentName { get; set; }

    /// <summary>
    /// Value of segment in this summary journal entry. 
    /// </summary>
    /// <value>Value of segment in this summary journal entry. </value>
    [DataMember(Name="segmentValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segmentValue")]
    public string SegmentValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETJournalEntrySegmentType {\n");
      sb.Append("  SegmentName: ").Append(SegmentName).Append("\n");
      sb.Append("  SegmentValue: ").Append(SegmentValue).Append("\n");
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
