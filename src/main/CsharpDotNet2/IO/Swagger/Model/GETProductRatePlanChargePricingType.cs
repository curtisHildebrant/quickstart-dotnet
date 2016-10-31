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
  public class GETProductRatePlanChargePricingType {
    /// <summary>
    /// Currency used by the charge model. For example: USD or EUR 
    /// </summary>
    /// <value>Currency used by the charge model. For example: USD or EUR </value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Value subtracted from price in currency specified. Used only when the charge model is DiscountFixedAmount. 
    /// </summary>
    /// <value>Value subtracted from price in currency specified. Used only when the charge model is DiscountFixedAmount. </value>
    [DataMember(Name="discountAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discountAmount")]
    public string DiscountAmount { get; set; }

    /// <summary>
    /// Percent discount applied to the price. Used only when the charge model is DiscountPercentage. 
    /// </summary>
    /// <value>Percent discount applied to the price. Used only when the charge model is DiscountPercentage. </value>
    [DataMember(Name="discountPercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discountPercentage")]
    public string DiscountPercentage { get; set; }

    /// <summary>
    /// Specifies the number of units in the base set of units when the charge model is Overage. 
    /// </summary>
    /// <value>Specifies the number of units in the base set of units when the charge model is Overage. </value>
    [DataMember(Name="includedUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includedUnits")]
    public string IncludedUnits { get; set; }

    /// <summary>
    /// Price per unit when base set of units is exceeded. Used only when charge model is Overage or Tiered with Overage. 
    /// </summary>
    /// <value>Price per unit when base set of units is exceeded. Used only when charge model is Overage or Tiered with Overage. </value>
    [DataMember(Name="overagePrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overagePrice")]
    public string OveragePrice { get; set; }

    /// <summary>
    /// The decimal value that applies when the charge model is not tiered 
    /// </summary>
    /// <value>The decimal value that applies when the charge model is not tiered </value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// Container for one or many defined tier ranges with distinct pricing.  Applies when model is `Tiered`, `TieredWithOverage`, or `Volume` 
    /// </summary>
    /// <value>Container for one or many defined tier ranges with distinct pricing.  Applies when model is `Tiered`, `TieredWithOverage`, or `Volume` </value>
    [DataMember(Name="tiers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tiers")]
    public List<GETProductRatePlanChargePricingTierType> Tiers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETProductRatePlanChargePricingType {\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
      sb.Append("  DiscountPercentage: ").Append(DiscountPercentage).Append("\n");
      sb.Append("  IncludedUnits: ").Append(IncludedUnits).Append("\n");
      sb.Append("  OveragePrice: ").Append(OveragePrice).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  Tiers: ").Append(Tiers).Append("\n");
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
