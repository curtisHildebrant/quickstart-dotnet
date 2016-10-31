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
  public class ProxyGetTaxationItem {
    /// <summary>
    ///  The [Chart of Accounts](/CB_Billing/W_Billing_and_Payments_Settings/V_Configure_Accounting_Codes/D_Set_Up_Chart_of_Accounts) 
    /// </summary>
    /// <value> The [Chart of Accounts](/CB_Billing/W_Billing_and_Payments_Settings/V_Configure_Accounting_Codes/D_Set_Up_Chart_of_Accounts) </value>
    [DataMember(Name="AccountingCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountingCode")]
    public string AccountingCode { get; set; }

    /// <summary>
    ///  The ID of the user who created the taxation item. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the user who created the taxation item. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  The date when the payment was created in the Zuora system. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the payment was created in the Zuora system. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    ///  The amount of taxes or VAT for which the customer has an exemption. **Character limit**: 16 **Values**: a decimal value 
    /// </summary>
    /// <value> The amount of taxes or VAT for which the customer has an exemption. **Character limit**: 16 **Values**: a decimal value </value>
    [DataMember(Name="ExemptAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExemptAmount")]
    public double? ExemptAmount { get; set; }

    /// <summary>
    /// Object identifier.
    /// </summary>
    /// <value>Object identifier.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    ///  The ID of the specific invoice item that the taxation information applies to. **Character limit**: 32 **Values**: a valid [invoice item ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/InvoiceItem) 
    /// </summary>
    /// <value> The ID of the specific invoice item that the taxation information applies to. **Character limit**: 32 **Values**: a valid [invoice item ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/InvoiceItem) </value>
    [DataMember(Name="InvoiceItemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceItemId")]
    public string InvoiceItemId { get; set; }

    /// <summary>
    ///  The jurisdiction that applies the tax or VAT. This value is typically a state, province, county, or city. **Character limit**: 32 **Values**: a string of 32 characterrs or fewer 
    /// </summary>
    /// <value> The jurisdiction that applies the tax or VAT. This value is typically a state, province, county, or city. **Character limit**: 32 **Values**: a string of 32 characterrs or fewer </value>
    [DataMember(Name="Jurisdiction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Jurisdiction")]
    public string Jurisdiction { get; set; }

    /// <summary>
    ///  The identifier for the location based on the value of the `TaxCode` field. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The identifier for the location based on the value of the `TaxCode` field. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="LocationCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LocationCode")]
    public string LocationCode { get; set; }

    /// <summary>
    ///  The name of the tax rate, such as sales tax or GST. This name is displayed on invoices. **Character limit**: 128 **Values**: a string of 128 characters or fewer 
    /// </summary>
    /// <value> The name of the tax rate, such as sales tax or GST. This name is displayed on invoices. **Character limit**: 128 **Values**: a string of 128 characters or fewer </value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    ///  The amount of the tax applied to the charge. **Character limit**: 16 **Values**: a decimal value 
    /// </summary>
    /// <value> The amount of the tax applied to the charge. **Character limit**: 16 **Values**: a decimal value </value>
    [DataMember(Name="TaxAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    ///  The tax code identifies which tax rules and tax rates to apply to a specific charge. **Character limit**: 32 **Values**: a string of 32 characters or fewer 
    /// </summary>
    /// <value> The tax code identifies which tax rules and tax rates to apply to a specific charge. **Character limit**: 32 **Values**: a string of 32 characters or fewer </value>
    [DataMember(Name="TaxCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxCode")]
    public string TaxCode { get; set; }

    /// <summary>
    ///  The description for the tax code. **Character limit**: 255 **Values**: a string of 255 characters or fewer 
    /// </summary>
    /// <value> The description for the tax code. **Character limit**: 255 **Values**: a string of 255 characters or fewer </value>
    [DataMember(Name="TaxCodeDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxCodeDescription")]
    public string TaxCodeDescription { get; set; }

    /// <summary>
    ///  The date that the tax is applied to the charge. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_and_dateTime_Format) 
    /// </summary>
    /// <value> The date that the tax is applied to the charge. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_and_dateTime_Format) </value>
    [DataMember(Name="TaxDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxDate")]
    public DateTime? TaxDate { get; set; }

    /// <summary>
    ///  The tax rate applied to the charge. **Character limit**: 16 **Values**: a valid decimal value 
    /// </summary>
    /// <value> The tax rate applied to the charge. **Character limit**: 16 **Values**: a valid decimal value </value>
    [DataMember(Name="TaxRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxRate")]
    public double? TaxRate { get; set; }

    /// <summary>
    ///  The description of the tax rate. **Character limit**: 255 **Values**: a string of 255 characters or fewer 
    /// </summary>
    /// <value> The description of the tax rate. **Character limit**: 255 **Values**: a string of 255 characters or fewer </value>
    [DataMember(Name="TaxRateDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxRateDescription")]
    public string TaxRateDescription { get; set; }

    /// <summary>
    ///  The type of the tax rate applied to the charge. **Character limit**: 10 **Values**: `Percentage`, `FlatFee` 
    /// </summary>
    /// <value> The type of the tax rate applied to the charge. **Character limit**: 10 **Values**: `Percentage`, `FlatFee` </value>
    [DataMember(Name="TaxRateType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxRateType")]
    public string TaxRateType { get; set; }

    /// <summary>
    ///  The ID of the user who last updated the taxation item. **Character limit**: **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the user who last updated the taxation item. **Character limit**: **Values**: automatically generated </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    /// The date when the taxation item was last updated. **Character limit**: **Values**: automatically generated 
    /// </summary>
    /// <value>The date when the taxation item was last updated. **Character limit**: **Values**: automatically generated </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetTaxationItem {\n");
      sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  ExemptAmount: ").Append(ExemptAmount).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InvoiceItemId: ").Append(InvoiceItemId).Append("\n");
      sb.Append("  Jurisdiction: ").Append(Jurisdiction).Append("\n");
      sb.Append("  LocationCode: ").Append(LocationCode).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
      sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
      sb.Append("  TaxCodeDescription: ").Append(TaxCodeDescription).Append("\n");
      sb.Append("  TaxDate: ").Append(TaxDate).Append("\n");
      sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
      sb.Append("  TaxRateDescription: ").Append(TaxRateDescription).Append("\n");
      sb.Append("  TaxRateType: ").Append(TaxRateType).Append("\n");
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
