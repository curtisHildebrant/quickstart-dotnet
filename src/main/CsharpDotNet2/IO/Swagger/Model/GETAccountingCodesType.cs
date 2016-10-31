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
  public class GETAccountingCodesType {
    /// <summary>
    /// An array of all the accounting codes in your chart of accounts. Each accounting code has the following fields. 
    /// </summary>
    /// <value>An array of all the accounting codes in your chart of accounts. Each accounting code has the following fields. </value>
    [DataMember(Name="accountingCodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingCodes")]
    public List<GETAccountingCodeItemWithoutSuccessType> AccountingCodes { get; set; }

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
      sb.Append("class GETAccountingCodesType {\n");
      sb.Append("  AccountingCodes: ").Append(AccountingCodes).Append("\n");
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
