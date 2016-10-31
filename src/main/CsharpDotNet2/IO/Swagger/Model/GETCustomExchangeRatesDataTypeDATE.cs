using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for exchange rate information on a given date. The field name is the date in &#x60;yyyy-mm-dd&#x60; format, for example, 2016-01-15. 
  /// </summary>
  [DataContract]
  public class GETCustomExchangeRatesDataTypeDATE {
    /// <summary>
    /// The exchange rate on the **providerExchangeRateDate**. The field name is the ISO currency code of the currency, for example, `EUR`.  There may be more than one currency returned for a given **providerExchangeRateDate**. If the rate for a certain currency is not available on the **providerExchangeRateDate**, the currency is not returned in the response. 
    /// </summary>
    /// <value>The exchange rate on the **providerExchangeRateDate**. The field name is the ISO currency code of the currency, for example, `EUR`.  There may be more than one currency returned for a given **providerExchangeRateDate**. If the rate for a certain currency is not available on the **providerExchangeRateDate**, the currency is not returned in the response. </value>
    [DataMember(Name="CURRENCY", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CURRENCY")]
    public string CURRENCY { get; set; }

    /// <summary>
    /// The date of the exchange rate used. The date is in `yyyy-mm-dd` format.  Corresponds to the value specified in the Provider Exchange Rate Date column in the Import Foreign Exchange Rates template when you uploaded the rates through the Mass Updater. 
    /// </summary>
    /// <value>The date of the exchange rate used. The date is in `yyyy-mm-dd` format.  Corresponds to the value specified in the Provider Exchange Rate Date column in the Import Foreign Exchange Rates template when you uploaded the rates through the Mass Updater. </value>
    [DataMember(Name="providerExchangeRateDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerExchangeRateDate")]
    public DateTime? ProviderExchangeRateDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETCustomExchangeRatesDataTypeDATE {\n");
      sb.Append("  CURRENCY: ").Append(CURRENCY).Append("\n");
      sb.Append("  ProviderExchangeRateDate: ").Append(ProviderExchangeRateDate).Append("\n");
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
