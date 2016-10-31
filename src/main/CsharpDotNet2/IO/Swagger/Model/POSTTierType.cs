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
  public class POSTTierType {
    /// <summary>
    /// End number of a range of units for the tier. 
    /// </summary>
    /// <value>End number of a range of units for the tier. </value>
    [DataMember(Name="endingUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endingUnit")]
    public string EndingUnit { get; set; }

    /// <summary>
    /// Price of the tier if the charge is a flat fee, or the price of each unit in the tier if the charge model is tiered pricing. 
    /// </summary>
    /// <value>Price of the tier if the charge is a flat fee, or the price of each unit in the tier if the charge model is tiered pricing. </value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// Indicates if pricing is a flat fee or is per unit.  Values:  * `FlatFee` * `PerUnit` 
    /// </summary>
    /// <value>Indicates if pricing is a flat fee or is per unit.  Values:  * `FlatFee` * `PerUnit` </value>
    [DataMember(Name="priceFormat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceFormat")]
    public string PriceFormat { get; set; }

    /// <summary>
    /// Starting number of a range of units for the tier. 
    /// </summary>
    /// <value>Starting number of a range of units for the tier. </value>
    [DataMember(Name="startingUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startingUnit")]
    public string StartingUnit { get; set; }

    /// <summary>
    /// Unique number that identifies the tier that the price applies to. 
    /// </summary>
    /// <value>Unique number that identifies the tier that the price applies to. </value>
    [DataMember(Name="tier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tier")]
    public long? Tier { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTTierType {\n");
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
