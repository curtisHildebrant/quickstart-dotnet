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
  public class GETCatalogType {
    /// <summary>
    /// Internal process ID to assist Zuora support.
    /// </summary>
    /// <value>Internal process ID to assist Zuora support.</value>
    [DataMember(Name="processId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processId")]
    public string ProcessId { get; set; }

    /// <summary>
    /// Container for one or more products: 
    /// </summary>
    /// <value>Container for one or more products: </value>
    [DataMember(Name="products", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "products")]
    public List<GETProductType> Products { get; set; }

    /// <summary>
    /// Information on one or more reasons for a failed result.
    /// </summary>
    /// <value>Information on one or more reasons for a failed result.</value>
    [DataMember(Name="reasons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reasons")]
    public List<ErrorCodeType> Reasons { get; set; }

    /// <summary>
    /// Returns `true` if successful, otherwise `false`. 
    /// </summary>
    /// <value>Returns `true` if successful, otherwise `false`. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETCatalogType {\n");
      sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
      sb.Append("  Products: ").Append(Products).Append("\n");
      sb.Append("  Reasons: ").Append(Reasons).Append("\n");
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
