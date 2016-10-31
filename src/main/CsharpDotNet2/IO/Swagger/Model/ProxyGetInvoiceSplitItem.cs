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
  public class ProxyGetInvoiceSplitItem {
    /// <summary>
    ///  The ID of the Zuora user who created the InvoiceSplitItem object. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the Zuora user who created the InvoiceSplitItem object. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  The date when the InvoiceSplitItem was created. **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the InvoiceSplitItem was created. **Values**: automatically generated </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Object identifier.
    /// </summary>
    /// <value>Object identifier.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    ///  The generation date of the new split invoice. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_Format_and_Datetimes_in_Zuora) 
    /// </summary>
    /// <value> The generation date of the new split invoice. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_Format_and_Datetimes_in_Zuora) </value>
    [DataMember(Name="InvoiceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceDate")]
    public DateTime? InvoiceDate { get; set; }

    /// <summary>
    ///  The new invoice after the split. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The new invoice after the split. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="InvoiceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceId")]
    public string InvoiceId { get; set; }

    /// <summary>
    ///  The ID of the invoice split associated with the individual invoice split item. **Character limit**: 32 **Values**: [a valid invoice split ID](https://knowledgecenter.zuora.com/BC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/InvoiceSplit) 
    /// </summary>
    /// <value> The ID of the invoice split associated with the individual invoice split item. **Character limit**: 32 **Values**: [a valid invoice split ID](https://knowledgecenter.zuora.com/BC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/InvoiceSplit) </value>
    [DataMember(Name="InvoiceSplitId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceSplitId")]
    public string InvoiceSplitId { get; set; }

    /// <summary>
    ///  Indicates when the customer pays the split invoice. **Values**: [a valid, active payment term defined in the web-based UI administrative settings](/CB_Billing/W_Billing_and_Payments_Settings/K_Define_Payment_Terms) 
    /// </summary>
    /// <value> Indicates when the customer pays the split invoice. **Values**: [a valid, active payment term defined in the web-based UI administrative settings](/CB_Billing/W_Billing_and_Payments_Settings/K_Define_Payment_Terms) </value>
    [DataMember(Name="PaymentTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentTerm")]
    public string PaymentTerm { get; set; }

    /// <summary>
    ///  Specifies the percentage of the original invoice that you want to be the balance of the split invoice. The total of the SplitPercentage field values for all of the InvoiceSplitItem objects in an InvoiceSplit object must equal 100. **Values**:  - If you're using WSDL 73.0 or earlier: a whole number between 1 and 100 - If you're using WSDL 74.0 or later: a decimal number with up to nine decimal places between 0.000000001 and 100, for example, `25` or `33.34` 
    /// </summary>
    /// <value> Specifies the percentage of the original invoice that you want to be the balance of the split invoice. The total of the SplitPercentage field values for all of the InvoiceSplitItem objects in an InvoiceSplit object must equal 100. **Values**:  - If you're using WSDL 73.0 or earlier: a whole number between 1 and 100 - If you're using WSDL 74.0 or later: a decimal number with up to nine decimal places between 0.000000001 and 100, for example, `25` or `33.34` </value>
    [DataMember(Name="SplitPercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SplitPercentage")]
    public double? SplitPercentage { get; set; }

    /// <summary>
    ///  The ID of the Zuora user who last updated the invoice split. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the Zuora user who last updated the invoice split. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    ///  The date when the invoice split was last updated. **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the invoice split was last updated. **Values**: automatically generated </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetInvoiceSplitItem {\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  InvoiceSplitId: ").Append(InvoiceSplitId).Append("\n");
      sb.Append("  PaymentTerm: ").Append(PaymentTerm).Append("\n");
      sb.Append("  SplitPercentage: ").Append(SplitPercentage).Append("\n");
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
