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
  public class InvoiceItem {
    /// <summary>
    ///  The accounting code for the item's charge. Accounting codes group transactions that contain similar accounting attributes. **Character limit**: 100 **Values**: inherited from `RatePlanCharge.AccountingCode` 
    /// </summary>
    /// <value> The accounting code for the item's charge. Accounting codes group transactions that contain similar accounting attributes. **Character limit**: 100 **Values**: inherited from `RatePlanCharge.AccountingCode` </value>
    [DataMember(Name="AccountingCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountingCode")]
    public string AccountingCode { get; set; }

    /// <summary>
    ///  Associates a discount invoice item to a specific invoice item. **Character limit**: 32 **Values**: inherited from the ID of the charge that a discount applies to 
    /// </summary>
    /// <value> Associates a discount invoice item to a specific invoice item. **Character limit**: 32 **Values**: inherited from the ID of the charge that a discount applies to </value>
    [DataMember(Name="AppliedToInvoiceItemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AppliedToInvoiceItemId")]
    public string AppliedToInvoiceItemId { get; set; }

    /// <summary>
    ///  The amount being charged for the invoice item. This amount doesn't include taxes regardless if the charge's tax mode is inclusive or exclusive. **Character limit**: **Values**: automatically calculated from multiple fields in multiple objects 
    /// </summary>
    /// <value> The amount being charged for the invoice item. This amount doesn't include taxes regardless if the charge's tax mode is inclusive or exclusive. **Character limit**: **Values**: automatically calculated from multiple fields in multiple objects </value>
    [DataMember(Name="ChargeAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeAmount")]
    public double? ChargeAmount { get; set; }

    /// <summary>
    ///  The date when the Invoice Item is created . **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the Invoice Item is created . **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="ChargeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeDate")]
    public DateTime? ChargeDate { get; set; }

    /// <summary>
    ///  A description of the invoice item's charge. **Character limit**: 500 **Values**: inherited from `RatePlanCharge.Description` 
    /// </summary>
    /// <value> A description of the invoice item's charge. **Character limit**: 500 **Values**: inherited from `RatePlanCharge.Description` </value>
    [DataMember(Name="ChargeDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeDescription")]
    public string ChargeDescription { get; set; }

    /// <summary>
    ///  The ID of the rate plan charge that is associated with this invoice item upon object creation. **Character limit**: 32 **Values**: inherited from `RatePlanCharge.Id` 
    /// </summary>
    /// <value> The ID of the rate plan charge that is associated with this invoice item upon object creation. **Character limit**: 32 **Values**: inherited from `RatePlanCharge.Id` </value>
    [DataMember(Name="ChargeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeId")]
    public string ChargeId { get; set; }

    /// <summary>
    ///  The name of the invoice item's charge. **Character limi**t: 50 **Values: **inherited from `RatePlanCharge.Name` 
    /// </summary>
    /// <value> The name of the invoice item's charge. **Character limi**t: 50 **Values: **inherited from `RatePlanCharge.Name` </value>
    [DataMember(Name="ChargeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeName")]
    public string ChargeName { get; set; }

    /// <summary>
    ///  The unique identifier of the invoice item's charge. **Character limit:** 50 **Values:** inherited from `RatePlanCharge.ChargeNumber` 
    /// </summary>
    /// <value> The unique identifier of the invoice item's charge. **Character limit:** 50 **Values:** inherited from `RatePlanCharge.ChargeNumber` </value>
    [DataMember(Name="ChargeNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeNumber")]
    public string ChargeNumber { get; set; }

    /// <summary>
    ///  Specifies the type of charge. **Character limit**: 9 **Values**: one of the following:  - `OneTime` - `Recurring` - `Usage` 
    /// </summary>
    /// <value> Specifies the type of charge. **Character limit**: 9 **Values**: one of the following:  - `OneTime` - `Recurring` - `Usage` </value>
    [DataMember(Name="ChargeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeType")]
    public string ChargeType { get; set; }

    /// <summary>
    ///  The user ID of the person who created the invoice item. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The user ID of the person who created the invoice item. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  The date the invoice item was created. **Character limit:** 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date the invoice item was created. **Character limit:** 29 **Values**: automatically generated </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    ///  The ID of this object. Upon creation, the ID of this object is `InvoiceItemId`. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of this object. Upon creation, the ID of this object is `InvoiceItemId`. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="IntegrationId__NS", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IntegrationId__NS")]
    public string IntegrationIdNS { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="IntegrationStatus__NS", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IntegrationStatus__NS")]
    public string IntegrationStatusNS { get; set; }

    /// <summary>
    ///  The ID of the invoice that's associated with this invoice item. **Character limit**: 32 **Values**: inherited from `Invoice.Id` 
    /// </summary>
    /// <value> The ID of the invoice that's associated with this invoice item. **Character limit**: 32 **Values**: inherited from `Invoice.Id` </value>
    [DataMember(Name="InvoiceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceId")]
    public string InvoiceId { get; set; }

    /// <summary>
    ///  Identifies the kind of charge where 0 is a charge, 1 is a discount, 2 is a prepayment, and 3 is a tax. The returned value is text not decimal on data sources. **Character limit**: **Values: **  - 0: charge - 1: discount - 2: prepayment - 3: tax 
    /// </summary>
    /// <value> Identifies the kind of charge where 0 is a charge, 1 is a discount, 2 is a prepayment, and 3 is a tax. The returned value is text not decimal on data sources. **Character limit**: **Values: **  - 0: charge - 1: discount - 2: prepayment - 3: tax </value>
    [DataMember(Name="ProcessingType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProcessingType")]
    public double? ProcessingType { get; set; }

    /// <summary>
    ///  A description of the product associated with this invoice item. **Character limit**: 500 **Values**: inherited from `Product.Description` 
    /// </summary>
    /// <value> A description of the product associated with this invoice item. **Character limit**: 500 **Values**: inherited from `Product.Description` </value>
    [DataMember(Name="ProductDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductDescription")]
    public string ProductDescription { get; set; }

    /// <summary>
    ///  The ID of the product associated with this invoice item. **Character limit**: 32 **Values**: inherited from `Product.Id` 
    /// </summary>
    /// <value> The ID of the product associated with this invoice item. **Character limit**: 32 **Values**: inherited from `Product.Id` </value>
    [DataMember(Name="ProductId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductId")]
    public string ProductId { get; set; }

    /// <summary>
    ///  The name of the product associated with this invoice item. **Character limit**: 255 **Values: **inherited from `Product.Name` 
    /// </summary>
    /// <value> The name of the product associated with this invoice item. **Character limit**: 255 **Values: **inherited from `Product.Name` </value>
    [DataMember(Name="ProductName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductName")]
    public string ProductName { get; set; }

    /// <summary>
    ///  The ID of the rate plan charge that's associated with this invoice item. **Character limit**: 32 **Values**: inherited from `ProductRatePlanCharge.Id` You cannot `query()` for this field. Only the s`ubscribe()` preview and the `amend()` preview calls will return the value of this field in the response.
    /// </summary>
    /// <value> The ID of the rate plan charge that's associated with this invoice item. **Character limit**: 32 **Values**: inherited from `ProductRatePlanCharge.Id` You cannot `query()` for this field. Only the s`ubscribe()` preview and the `amend()` preview calls will return the value of this field in the response.</value>
    [DataMember(Name="ProductRatePlanChargeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductRatePlanChargeId")]
    public string ProductRatePlanChargeId { get; set; }

    /// <summary>
    ///  The number of units for this invoice item. **Values**: inherited from `RatePlanCharge.Quantity` 
    /// </summary>
    /// <value> The number of units for this invoice item. **Values**: inherited from `RatePlanCharge.Quantity` </value>
    [DataMember(Name="Quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Quantity")]
    public double? Quantity { get; set; }

    /// <summary>
    ///  The ID of the rate plan charge that's associated with this invoice item. **Character limit**: 32 **Values**: inherited from `RatePlanCharge.Id` 
    /// </summary>
    /// <value> The ID of the rate plan charge that's associated with this invoice item. **Character limit**: 32 **Values**: inherited from `RatePlanCharge.Id` </value>
    [DataMember(Name="RatePlanChargeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RatePlanChargeId")]
    public string RatePlanChargeId { get; set; }

    /// <summary>
    ///  Associates this invoice item with a specific revenue recognition code. **Character limit**: 32 **Values**: inherited from `ProductRatePlanCharge.RevRecCode` 
    /// </summary>
    /// <value> Associates this invoice item with a specific revenue recognition code. **Character limit**: 32 **Values**: inherited from `ProductRatePlanCharge.RevRecCode` </value>
    [DataMember(Name="RevRecCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RevRecCode")]
    public string RevRecCode { get; set; }

    /// <summary>
    ///  The date when revenue recognition is triggered. **Character limit**: 29 **Values**: generated from `InvoiceItem.RevRecTriggerCondition` 
    /// </summary>
    /// <value> The date when revenue recognition is triggered. **Character limit**: 29 **Values**: generated from `InvoiceItem.RevRecTriggerCondition` </value>
    [DataMember(Name="RevRecStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RevRecStartDate")]
    public DateTime? RevRecStartDate { get; set; }

    /// <summary>
    ///  Specifies when revenue recognition begins based on a triggering event. **Character limit**: **Values**: inherited from `[ProductRatePlanCharge](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/ProductRatePlanCharge).RevRecTriggerCondition` 
    /// </summary>
    /// <value> Specifies when revenue recognition begins based on a triggering event. **Character limit**: **Values**: inherited from `[ProductRatePlanCharge](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/ProductRatePlanCharge).RevRecTriggerCondition` </value>
    [DataMember(Name="RevRecTriggerCondition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RevRecTriggerCondition")]
    public string RevRecTriggerCondition { get; set; }

    /// <summary>
    ///  The unique SKU for the product associated with this invoice item. **Character limit**: 255 **Values**: inherited from `Product.SKU` 
    /// </summary>
    /// <value> The unique SKU for the product associated with this invoice item. **Character limit**: 255 **Values**: inherited from `Product.SKU` </value>
    [DataMember(Name="SKU", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SKU")]
    public string SKU { get; set; }

    /// <summary>
    ///  The end date of the service period associated with this invoice item. Service ends one second before the date in this value. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The end date of the service period associated with this invoice item. Service ends one second before the date in this value. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="ServiceEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceEndDate")]
    public DateTime? ServiceEndDate { get; set; }

    /// <summary>
    ///  The start date of the service period associated with this invoice item. If the associated charge is a one-time fee, then this date is the date of that charge. **Character limit:** 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The start date of the service period associated with this invoice item. If the associated charge is a one-time fee, then this date is the date of that charge. **Character limit:** 29 **Values**: automatically generated </value>
    [DataMember(Name="ServiceStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceStartDate")]
    public DateTime? ServiceStartDate { get; set; }

    /// <summary>
    ///  The ID of the subscription associated with the invoice item. **Character limit**: 32 **Values**: inherited from `Subscription.Id` 
    /// </summary>
    /// <value> The ID of the subscription associated with the invoice item. **Character limit**: 32 **Values**: inherited from `Subscription.Id` </value>
    [DataMember(Name="SubscriptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubscriptionId")]
    public string SubscriptionId { get; set; }

    /// <summary>
    ///  The number of the subscription associated with the invoice item. **Character limit**: **Values**: 
    /// </summary>
    /// <value> The number of the subscription associated with the invoice item. **Character limit**: **Values**: </value>
    [DataMember(Name="SubscriptionNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubscriptionNumber")]
    public string SubscriptionNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="SyncDate__NS", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncDate__NS")]
    public string SyncDateNS { get; set; }

    /// <summary>
    ///  The amount of tax applied to the invoice item's charge. **Character limit**: **Values**: calculated from multiple fields in the ProductRatePlanCharge object 
    /// </summary>
    /// <value> The amount of tax applied to the invoice item's charge. **Character limit**: **Values**: calculated from multiple fields in the ProductRatePlanCharge object </value>
    [DataMember(Name="TaxAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    ///  Specifies the tax code for taxation rules. **Character limit**: 6 **Values**: inherited from `ProductRatePlanCharge.TaxCode` 
    /// </summary>
    /// <value> Specifies the tax code for taxation rules. **Character limit**: 6 **Values**: inherited from `ProductRatePlanCharge.TaxCode` </value>
    [DataMember(Name="TaxCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxCode")]
    public string TaxCode { get; set; }

    /// <summary>
    ///  The amount of the invoice item's charge that's tax exempt. **Character limit**: **Values**: calculated from multiple fields in the ProductRatePlanCharge object 
    /// </summary>
    /// <value> The amount of the invoice item's charge that's tax exempt. **Character limit**: **Values**: calculated from multiple fields in the ProductRatePlanCharge object </value>
    [DataMember(Name="TaxExemptAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxExemptAmount")]
    public double? TaxExemptAmount { get; set; }

    /// <summary>
    ///  The tax mode of the invoice item. **Character limit**: 12 **Values**: `TaxExclusive`, `TaxInclusive` 
    /// </summary>
    /// <value> The tax mode of the invoice item. **Character limit**: 12 **Values**: `TaxExclusive`, `TaxInclusive` </value>
    [DataMember(Name="TaxMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxMode")]
    public string TaxMode { get; set; }

    /// <summary>
    ///  Specifies the units to measure usage. Units of measure are configured in the web-based UI: **Z-Billing > Settings** **Character limit**: **Values**: inherited from `ProductRatePlanCharge.UOM` 
    /// </summary>
    /// <value> Specifies the units to measure usage. Units of measure are configured in the web-based UI: **Z-Billing > Settings** **Character limit**: **Values**: inherited from `ProductRatePlanCharge.UOM` </value>
    [DataMember(Name="UOM", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UOM")]
    public string UOM { get; set; }

    /// <summary>
    ///  The per-unit price of the invoice item. **Character limit**: **Values**: calculated from multiple fields in ProductRatePlanCharge and ProductRatePlanChargeTier objets 
    /// </summary>
    /// <value> The per-unit price of the invoice item. **Character limit**: **Values**: calculated from multiple fields in ProductRatePlanCharge and ProductRatePlanChargeTier objets </value>
    [DataMember(Name="UnitPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UnitPrice")]
    public double? UnitPrice { get; set; }

    /// <summary>
    ///  The ID of the user who last updated the invoice item. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the user who last updated the invoice item. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    ///  The date when the invoice item was last updated. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the invoice item was last updated. **Character limit**: 29 **Values**: automatically generated </value>
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
      sb.Append("class InvoiceItem {\n");
      sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
      sb.Append("  AppliedToInvoiceItemId: ").Append(AppliedToInvoiceItemId).Append("\n");
      sb.Append("  ChargeAmount: ").Append(ChargeAmount).Append("\n");
      sb.Append("  ChargeDate: ").Append(ChargeDate).Append("\n");
      sb.Append("  ChargeDescription: ").Append(ChargeDescription).Append("\n");
      sb.Append("  ChargeId: ").Append(ChargeId).Append("\n");
      sb.Append("  ChargeName: ").Append(ChargeName).Append("\n");
      sb.Append("  ChargeNumber: ").Append(ChargeNumber).Append("\n");
      sb.Append("  ChargeType: ").Append(ChargeType).Append("\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IntegrationIdNS: ").Append(IntegrationIdNS).Append("\n");
      sb.Append("  IntegrationStatusNS: ").Append(IntegrationStatusNS).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  ProcessingType: ").Append(ProcessingType).Append("\n");
      sb.Append("  ProductDescription: ").Append(ProductDescription).Append("\n");
      sb.Append("  ProductId: ").Append(ProductId).Append("\n");
      sb.Append("  ProductName: ").Append(ProductName).Append("\n");
      sb.Append("  ProductRatePlanChargeId: ").Append(ProductRatePlanChargeId).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  RatePlanChargeId: ").Append(RatePlanChargeId).Append("\n");
      sb.Append("  RevRecCode: ").Append(RevRecCode).Append("\n");
      sb.Append("  RevRecStartDate: ").Append(RevRecStartDate).Append("\n");
      sb.Append("  RevRecTriggerCondition: ").Append(RevRecTriggerCondition).Append("\n");
      sb.Append("  SKU: ").Append(SKU).Append("\n");
      sb.Append("  ServiceEndDate: ").Append(ServiceEndDate).Append("\n");
      sb.Append("  ServiceStartDate: ").Append(ServiceStartDate).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
      sb.Append("  SubscriptionNumber: ").Append(SubscriptionNumber).Append("\n");
      sb.Append("  SyncDateNS: ").Append(SyncDateNS).Append("\n");
      sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
      sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
      sb.Append("  TaxExemptAmount: ").Append(TaxExemptAmount).Append("\n");
      sb.Append("  TaxMode: ").Append(TaxMode).Append("\n");
      sb.Append("  UOM: ").Append(UOM).Append("\n");
      sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
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
