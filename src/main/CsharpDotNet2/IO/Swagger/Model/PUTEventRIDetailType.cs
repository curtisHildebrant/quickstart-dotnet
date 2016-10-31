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
  public class PUTEventRIDetailType {
    /// <summary>
    /// Revenue items are listed in ascending order by the accounting period start date.  Include at least one custom field. 
    /// </summary>
    /// <value>Revenue items are listed in ascending order by the accounting period start date.  Include at least one custom field. </value>
    [DataMember(Name="revenueItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueItems")]
    public List<EventRevenueItemType> RevenueItems { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PUTEventRIDetailType {\n");
      sb.Append("  RevenueItems: ").Append(RevenueItems).Append("\n");
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
