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
  public class GETInvoicesInvoiceItemType {
    /// <summary>
    /// The amount of the charge. This amount doesn't include taxes regardless if the charge's tax mode is inclusive or exclusive. 
    /// </summary>
    /// <value>The amount of the charge. This amount doesn't include taxes regardless if the charge's tax mode is inclusive or exclusive. </value>
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
    /// ID of the charge. 
    /// </summary>
    /// <value>ID of the charge. </value>
    [DataMember(Name="chargeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeId")]
    public string ChargeId { get; set; }

    /// <summary>
    /// Name of the charge. 
    /// </summary>
    /// <value>Name of the charge. </value>
    [DataMember(Name="chargeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeName")]
    public string ChargeName { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Item ID. 
    /// </summary>
    /// <value>Item ID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Name of the product associated with this item. 
    /// </summary>
    /// <value>Name of the product associated with this item. </value>
    [DataMember(Name="productName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productName")]
    public string ProductName { get; set; }

    /// <summary>
    /// Quantity of this item, in the configured unit of measure for the charge. 
    /// </summary>
    /// <value>Quantity of this item, in the configured unit of measure for the charge. </value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public string Quantity { get; set; }

    /// <summary>
    /// End date of the service period for this item, i.e., the last day of the service period, as _yyyy-mm-dd_. 
    /// </summary>
    /// <value>End date of the service period for this item, i.e., the last day of the service period, as _yyyy-mm-dd_. </value>
    [DataMember(Name="serviceEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceEndDate")]
    public DateTime? ServiceEndDate { get; set; }

    /// <summary>
    /// Start date of the service period for this item, as _yyyy-mm-dd_. For a one-time fee item, the date of the charge. 
    /// </summary>
    /// <value>Start date of the service period for this item, as _yyyy-mm-dd_. For a one-time fee item, the date of the charge. </value>
    [DataMember(Name="serviceStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceStartDate")]
    public DateTime? ServiceStartDate { get; set; }

    /// <summary>
    /// ID of the subscription for this item. 
    /// </summary>
    /// <value>ID of the subscription for this item. </value>
    [DataMember(Name="subscriptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionId")]
    public string SubscriptionId { get; set; }

    /// <summary>
    /// Name of the subscription for this item. 
    /// </summary>
    /// <value>Name of the subscription for this item. </value>
    [DataMember(Name="subscriptionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionName")]
    public string SubscriptionName { get; set; }

    /// <summary>
    /// Returns `true` if the request was processed successfully. 
    /// </summary>
    /// <value>Returns `true` if the request was processed successfully. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// Tax applied to the charge. 
    /// </summary>
    /// <value>Tax applied to the charge. </value>
    [DataMember(Name="taxAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxAmount")]
    public string TaxAmount { get; set; }

    /// <summary>
    /// Unit used to measure consumption, as configured in the web-based UI at **Z-Billing > Settings**. 
    /// </summary>
    /// <value>Unit used to measure consumption, as configured in the web-based UI at **Z-Billing > Settings**. </value>
    [DataMember(Name="unitOfMeasure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitOfMeasure")]
    public string UnitOfMeasure { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETInvoicesInvoiceItemType {\n");
      sb.Append("  ChargeAmount: ").Append(ChargeAmount).Append("\n");
      sb.Append("  ChargeDescription: ").Append(ChargeDescription).Append("\n");
      sb.Append("  ChargeId: ").Append(ChargeId).Append("\n");
      sb.Append("  ChargeName: ").Append(ChargeName).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ProductName: ").Append(ProductName).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  ServiceEndDate: ").Append(ServiceEndDate).Append("\n");
      sb.Append("  ServiceStartDate: ").Append(ServiceStartDate).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
      sb.Append("  SubscriptionName: ").Append(SubscriptionName).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
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
