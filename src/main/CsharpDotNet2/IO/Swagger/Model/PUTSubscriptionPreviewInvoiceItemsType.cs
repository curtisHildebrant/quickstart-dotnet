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
  public class PUTSubscriptionPreviewInvoiceItemsType {
    /// <summary>
    /// The amount of the charge. This amount doesn't include taxes unless the charge's tax mode is inclusive. 
    /// </summary>
    /// <value>The amount of the charge. This amount doesn't include taxes unless the charge's tax mode is inclusive. </value>
    [DataMember(Name="chargeAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeAmount")]
    public string ChargeAmount { get; set; }

    /// <summary>
    /// Description of the charge. 
    /// </summary>
    /// <value>Description of the charge. </value>
    [DataMember(Name="chargeDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeDescription")]
    public string ChargeDescription { get; set; }

    /// <summary>
    /// Name of the charge 
    /// </summary>
    /// <value>Name of the charge </value>
    [DataMember(Name="chargeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeName")]
    public string ChargeName { get; set; }

    /// <summary>
    /// Name of the product associated with this item. 
    /// </summary>
    /// <value>Name of the product associated with this item. </value>
    [DataMember(Name="productName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productName")]
    public string ProductName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="productRatePlanChargeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productRatePlanChargeId")]
    public string ProductRatePlanChargeId { get; set; }

    /// <summary>
    /// Quantity of this item. 
    /// </summary>
    /// <value>Quantity of this item. </value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public string Quantity { get; set; }

    /// <summary>
    /// End date of the service period for this item, i.e., the last day of the period, as yyyy-mm-dd. 
    /// </summary>
    /// <value>End date of the service period for this item, i.e., the last day of the period, as yyyy-mm-dd. </value>
    [DataMember(Name="serviceEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceEndDate")]
    public DateTime? ServiceEndDate { get; set; }

    /// <summary>
    /// Service start date as yyyy-mm-dd. If the charge is a one-time fee, this is the date of that charge. 
    /// </summary>
    /// <value>Service start date as yyyy-mm-dd. If the charge is a one-time fee, this is the date of that charge. </value>
    [DataMember(Name="serviceStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceStartDate")]
    public DateTime? ServiceStartDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="unitOfMeasure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitOfMeasure")]
    public string UnitOfMeasure { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PUTSubscriptionPreviewInvoiceItemsType {\n");
      sb.Append("  ChargeAmount: ").Append(ChargeAmount).Append("\n");
      sb.Append("  ChargeDescription: ").Append(ChargeDescription).Append("\n");
      sb.Append("  ChargeName: ").Append(ChargeName).Append("\n");
      sb.Append("  ProductName: ").Append(ProductName).Append("\n");
      sb.Append("  ProductRatePlanChargeId: ").Append(ProductRatePlanChargeId).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  ServiceEndDate: ").Append(ServiceEndDate).Append("\n");
      sb.Append("  ServiceStartDate: ").Append(ServiceStartDate).Append("\n");
      sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
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
