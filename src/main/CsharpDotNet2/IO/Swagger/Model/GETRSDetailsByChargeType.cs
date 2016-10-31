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
  public class GETRSDetailsByChargeType {
    /// <summary>
    /// Represents how revenue will be recognized over time.  This contains the details of a revenue schedule. If you do not specify the ｀pageSize｀ variable, the default number of revenue schedules returned per invocation is 8, and if there are more than 8 revenue schedules to be returned, the ｀nextPage｀ field will provide a hyperlink to view the next page(s) of revenue events. The order of revenue schedules is descending by the ｀updatedOn｀ field. 
    /// </summary>
    /// <value>Represents how revenue will be recognized over time.  This contains the details of a revenue schedule. If you do not specify the ｀pageSize｀ variable, the default number of revenue schedules returned per invocation is 8, and if there are more than 8 revenue schedules to be returned, the ｀nextPage｀ field will provide a hyperlink to view the next page(s) of revenue events. The order of revenue schedules is descending by the ｀updatedOn｀ field. </value>
    [DataMember(Name="revenueSchedules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueSchedules")]
    public List<GETRSDetailWithoutSuccessType> RevenueSchedules { get; set; }

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
      sb.Append("class GETRSDetailsByChargeType {\n");
      sb.Append("  RevenueSchedules: ").Append(RevenueSchedules).Append("\n");
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
