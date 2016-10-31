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
  public class QueryResult {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="done", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "done")]
    public bool? Done { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="queryLocator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "queryLocator")]
    public string QueryLocator { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="records", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "records")]
    public List<ZObject> Records { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public int? Size { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QueryResult {\n");
      sb.Append("  Done: ").Append(Done).Append("\n");
      sb.Append("  QueryLocator: ").Append(QueryLocator).Append("\n");
      sb.Append("  Records: ").Append(Records).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
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
