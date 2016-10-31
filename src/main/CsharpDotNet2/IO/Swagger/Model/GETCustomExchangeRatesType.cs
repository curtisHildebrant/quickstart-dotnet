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
  public class GETCustomExchangeRatesType {
    /// <summary>
    /// - If `true`, the exchange rate in the response is an inverse exchange rate. - If `false`, the exchange rate in the response is not an inverse exchange rate. The value is determined by the **Use inverse rate** checkbox in your Z-Finance [Manage Currency Conversion](https://knowledgecenter.zuora.com/CC_Finance/Foreign_Currency_Conversion#How_to_Enable_Foreign_Currency_Conversion) settings. 
    /// </summary>
    /// <value>- If `true`, the exchange rate in the response is an inverse exchange rate. - If `false`, the exchange rate in the response is not an inverse exchange rate. The value is determined by the **Use inverse rate** checkbox in your Z-Finance [Manage Currency Conversion](https://knowledgecenter.zuora.com/CC_Finance/Foreign_Currency_Conversion#How_to_Enable_Foreign_Currency_Conversion) settings. </value>
    [DataMember(Name="inverse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inverse")]
    public bool? Inverse { get; set; }

    /// <summary>
    /// Container for exchange rate data. Contains a set of fields that provide exchange rate data for each day between the specified `startDate` and `endDate` (inclusive).  
    /// </summary>
    /// <value>Container for exchange rate data. Contains a set of fields that provide exchange rate data for each day between the specified `startDate` and `endDate` (inclusive).  </value>
    [DataMember(Name="rates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rates")]
    public List<GETCustomExchangeRatesDataType> Rates { get; set; }

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
      sb.Append("class GETCustomExchangeRatesType {\n");
      sb.Append("  Inverse: ").Append(Inverse).Append("\n");
      sb.Append("  Rates: ").Append(Rates).Append("\n");
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
