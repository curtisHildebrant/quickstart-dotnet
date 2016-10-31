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
  public class RatePlanChargeTier {
    /// <summary>
    /// The ID of the Zuora user who created the RatePlanChargeTier object. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value>The ID of the Zuora user who created the RatePlanChargeTier object. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  The date when the RatePlanChargeTier object was created. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the RatePlanChargeTier object was created. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    ///  The end number of a range of units for the tier. **Character limit**: 16 **Values**: any positive decimal value 
    /// </summary>
    /// <value> The end number of a range of units for the tier. **Character limit**: 16 **Values**: any positive decimal value </value>
    [DataMember(Name="EndingUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EndingUnit")]
    public double? EndingUnit { get; set; }

    /// <summary>
    ///  The ID of this object. Upon creation, the ID of this object is `RatePlanChargeTierId`. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of this object. Upon creation, the ID of this object is `RatePlanChargeTierId`. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    ///  Indicates if the price is an overage price. An overage occurs when usage surpasses the last defined tier. This field is applicable only to tier pricing and volume pricing models. **Values**: true, false 
    /// </summary>
    /// <value> Indicates if the price is an overage price. An overage occurs when usage surpasses the last defined tier. This field is applicable only to tier pricing and volume pricing models. **Values**: true, false </value>
    [DataMember(Name="IsOveragePrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsOveragePrice")]
    public bool? IsOveragePrice { get; set; }

    /// <summary>
    ///  The price of the tier if the charge is a flat fee, or the price of each unit in the tier if the change model is tiered pricing. **Character limit**: 16 **Values**: any positive decimal value 
    /// </summary>
    /// <value> The price of the tier if the charge is a flat fee, or the price of each unit in the tier if the change model is tiered pricing. **Character limit**: 16 **Values**: any positive decimal value </value>
    [DataMember(Name="Price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Price")]
    public double? Price { get; set; }

    /// <summary>
    ///  Indicates if the price is a flat fee or is per unit. **Character limit**: 8 **Values**: `Flat Fee`, `Per Unit` 
    /// </summary>
    /// <value> Indicates if the price is a flat fee or is per unit. **Character limit**: 8 **Values**: `Flat Fee`, `Per Unit` </value>
    [DataMember(Name="PriceFormat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceFormat")]
    public string PriceFormat { get; set; }

    /// <summary>
    ///  The ID of the subscription or amendment rate plan charge associated with this tier. You can't create an unassociated tier. **Character limit**: 32 **Values**: inherited from [`RatePlanCharge.Id`](https://knowledgecenter.zuora.com/BC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/RatePlanCharge#Id) 
    /// </summary>
    /// <value> The ID of the subscription or amendment rate plan charge associated with this tier. You can't create an unassociated tier. **Character limit**: 32 **Values**: inherited from [`RatePlanCharge.Id`](https://knowledgecenter.zuora.com/BC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/RatePlanCharge#Id) </value>
    [DataMember(Name="RatePlanChargeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RatePlanChargeId")]
    public string RatePlanChargeId { get; set; }

    /// <summary>
    ///  The start number of a range of units for the tier. **Character limit**: 16 **Values**: any positive decimal value 
    /// </summary>
    /// <value> The start number of a range of units for the tier. **Character limit**: 16 **Values**: any positive decimal value </value>
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
    /// The ID of the last user to update the object. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value>The ID of the last user to update the object. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    ///  The date when the object was last updated. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the object was last updated. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="fieldsToNull", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldsToNull")]
    public string FieldsToNull { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RatePlanChargeTier {\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  EndingUnit: ").Append(EndingUnit).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IsOveragePrice: ").Append(IsOveragePrice).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  PriceFormat: ").Append(PriceFormat).Append("\n");
      sb.Append("  RatePlanChargeId: ").Append(RatePlanChargeId).Append("\n");
      sb.Append("  StartingUnit: ").Append(StartingUnit).Append("\n");
      sb.Append("  Tier: ").Append(Tier).Append("\n");
      sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
      sb.Append("  FieldsToNull: ").Append(FieldsToNull).Append("\n");
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
