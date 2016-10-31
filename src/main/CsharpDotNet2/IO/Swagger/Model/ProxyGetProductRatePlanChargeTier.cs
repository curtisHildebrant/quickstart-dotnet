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
  public class ProxyGetProductRatePlanChargeTier {
    /// <summary>
    /// The ID of the Zuora user who created the ProductRatePlanChargeTier object. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value>The ID of the Zuora user who created the ProductRatePlanChargeTier object. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    /// The date when the ProductRatePlanChargeTier object was created. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value>The date when the ProductRatePlanChargeTier object was created. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The code corresponding to the currency for the tier's price. **Character limit**: 3 **Values**: a valid currency code 
    /// </summary>
    /// <value>The code corresponding to the currency for the tier's price. **Character limit**: 3 **Values**: a valid currency code </value>
    [DataMember(Name="Currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Currency")]
    public string Currency { get; set; }

    /// <summary>
    /// The end number of a range of units for the tier. **Character limit**: 16 **Values**: any positive decimal value 
    /// </summary>
    /// <value>The end number of a range of units for the tier. **Character limit**: 16 **Values**: any positive decimal value </value>
    [DataMember(Name="EndingUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EndingUnit")]
    public double? EndingUnit { get; set; }

    /// <summary>
    /// Object identifier.
    /// </summary>
    /// <value>Object identifier.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    ///  The price of the tier if the charge is a flat fee, or the price of each unit in the tier if the charge model is tiered pricing. **Character limit**: 16 **Values**: a valid currency value 
    /// </summary>
    /// <value> The price of the tier if the charge is a flat fee, or the price of each unit in the tier if the charge model is tiered pricing. **Character limit**: 16 **Values**: a valid currency value </value>
    [DataMember(Name="Price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Price")]
    public double? Price { get; set; }

    /// <summary>
    /// Indicates if pricing is a flat fee or is per unit. This field is for tiered and volume pricing models only. **Character limit**: 8 **Values**: `FlatFee`, `PerUnit` **Note:** The values `Flat Fee` and `Per Unit` (with spaces) is valid for create or update calls. 
    /// </summary>
    /// <value>Indicates if pricing is a flat fee or is per unit. This field is for tiered and volume pricing models only. **Character limit**: 8 **Values**: `FlatFee`, `PerUnit` **Note:** The values `Flat Fee` and `Per Unit` (with spaces) is valid for create or update calls. </value>
    [DataMember(Name="PriceFormat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceFormat")]
    public string PriceFormat { get; set; }

    /// <summary>
    ///  The starting number of a range of units for the tier. **Character limit**: 16 **Values**: any positive decimal value 
    /// </summary>
    /// <value> The starting number of a range of units for the tier. **Character limit**: 16 **Values**: any positive decimal value </value>
    [DataMember(Name="StartingUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartingUnit")]
    public double? StartingUnit { get; set; }

    /// <summary>
    ///  A unique number that identifies the tier that the price applies to. **Character limit**: 20 **Values**: automatically generated 
    /// </summary>
    /// <value> A unique number that identifies the tier that the price applies to. **Character limit**: 20 **Values**: automatically generated </value>
    [DataMember(Name="Tier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Tier")]
    public int? Tier { get; set; }

    /// <summary>
    ///  The ID of the user who last updated the product rate plan charge tier. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the user who last updated the product rate plan charge tier. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    ///  The date when the product rate plan charge tier was last updated. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the product rate plan charge tier was last updated. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetProductRatePlanChargeTier {\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  EndingUnit: ").Append(EndingUnit).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  PriceFormat: ").Append(PriceFormat).Append("\n");
      sb.Append("  StartingUnit: ").Append(StartingUnit).Append("\n");
      sb.Append("  Tier: ").Append(Tier).Append("\n");
      sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
