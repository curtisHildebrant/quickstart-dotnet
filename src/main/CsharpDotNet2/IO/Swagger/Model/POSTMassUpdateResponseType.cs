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
  public class POSTMassUpdateResponseType {
    /// <summary>
    /// String of 32 characters that identifies the mass action. The bulkKey is generated before the mass action is processed. You can use the bulkKey to [Get the Mass Action Result](https://knowledgecenter.zuora.com/BC_Developers/REST_API/B_REST_API_reference/Mass_Updater/B_Get_Mass_Action_Result). 
    /// </summary>
    /// <value>String of 32 characters that identifies the mass action. The bulkKey is generated before the mass action is processed. You can use the bulkKey to [Get the Mass Action Result](https://knowledgecenter.zuora.com/BC_Developers/REST_API/B_REST_API_reference/Mass_Updater/B_Get_Mass_Action_Result). </value>
    [DataMember(Name="bulkKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bulkKey")]
    public string BulkKey { get; set; }

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
      sb.Append("class POSTMassUpdateResponseType {\n");
      sb.Append("  BulkKey: ").Append(BulkKey).Append("\n");
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
