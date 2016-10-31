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
  public class GETTierType {
    /// <summary>
    /// Decimal defining end of tier range. 
    /// </summary>
    /// <value>Decimal defining end of tier range. </value>
    [DataMember(Name="endingUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endingUnit")]
    public string EndingUnit { get; set; }

    /// <summary>
    /// The decimal value of the tiered charge model. If the charge model is not a tiered type then this price field will be null and the `price` field directly under the `productRatePlanCharges` applies. 
    /// </summary>
    /// <value>The decimal value of the tiered charge model. If the charge model is not a tiered type then this price field will be null and the `price` field directly under the `productRatePlanCharges` applies. </value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// Tier price format. Allowed values: `flat fee`, `per unit`. 
    /// </summary>
    /// <value>Tier price format. Allowed values: `flat fee`, `per unit`. </value>
    [DataMember(Name="priceFormat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceFormat")]
    public string PriceFormat { get; set; }

    /// <summary>
    /// Decimal defining start of tier range. 
    /// </summary>
    /// <value>Decimal defining start of tier range. </value>
    [DataMember(Name="startingUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startingUnit")]
    public string StartingUnit { get; set; }

    /// <summary>
    /// Unique number of the tier. 
    /// </summary>
    /// <value>Unique number of the tier. </value>
    [DataMember(Name="tier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tier")]
    public long? Tier { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETTierType {\n");
      sb.Append("  EndingUnit: ").Append(EndingUnit).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  PriceFormat: ").Append(PriceFormat).Append("\n");
      sb.Append("  StartingUnit: ").Append(StartingUnit).Append("\n");
      sb.Append("  Tier: ").Append(Tier).Append("\n");
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
