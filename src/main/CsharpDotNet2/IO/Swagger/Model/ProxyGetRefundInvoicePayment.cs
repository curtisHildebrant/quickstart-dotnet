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
  public class ProxyGetRefundInvoicePayment {
    /// <summary>
    ///  The ID of the Zuora user who created the RefundInvoicePayment object. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the Zuora user who created the RefundInvoicePayment object. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  The date when the RefundInvoicePayment object was created. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the RefundInvoicePayment object was created. **Character limit**: 29 **Values**: automatically generated </value>
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
    ///  The unique ID of the invoice associated with this refund invoice payment. **Character limit**: 32 **Values**: a valid invoice ID 
    /// </summary>
    /// <value> The unique ID of the invoice associated with this refund invoice payment. **Character limit**: 32 **Values**: a valid invoice ID </value>
    [DataMember(Name="InvoiceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceId")]
    public string InvoiceId { get; set; }

    /// <summary>
    ///  The ID of the [`InvoicePayment.Id`](https://knowledgecenter.zuora.com/BC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/InvoicePayment#Id) 
    /// </summary>
    /// <value> The ID of the [`InvoicePayment.Id`](https://knowledgecenter.zuora.com/BC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/InvoicePayment#Id) </value>
    [DataMember(Name="InvoicePaymentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoicePaymentId")]
    public string InvoicePaymentId { get; set; }

    /// <summary>
    /// Specifies the amount of a refund applied against a payment. **Character limit**: 16 **Values**: automatically generated 
    /// </summary>
    /// <value>Specifies the amount of a refund applied against a payment. **Character limit**: 16 **Values**: automatically generated </value>
    [DataMember(Name="RefundAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefundAmount")]
    public double? RefundAmount { get; set; }

    /// <summary>
    ///  The ID of the [Refund object](https://knowledgecenter.zuora.com/BC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Refund) that created the refund. **Character limit**: 32 **Values**: inherited from `Refund.Id` 
    /// </summary>
    /// <value> The ID of the [Refund object](https://knowledgecenter.zuora.com/BC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Refund) that created the refund. **Character limit**: 32 **Values**: inherited from `Refund.Id` </value>
    [DataMember(Name="RefundId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefundId")]
    public string RefundId { get; set; }

    /// <summary>
    ///  The ID of the last user to update the object. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the last user to update the object. **Character limit**: 32 **Values**: automatically generated </value>
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetRefundInvoicePayment {\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  InvoicePaymentId: ").Append(InvoicePaymentId).Append("\n");
      sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
      sb.Append("  RefundId: ").Append(RefundId).Append("\n");
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
