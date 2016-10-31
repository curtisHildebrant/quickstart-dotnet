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
  public class ProxyGetInvoicePayment {
    /// <summary>
    ///  The amount of the payment. **Character limit**: 16 **Values**: a valid currency amount 
    /// </summary>
    /// <value> The amount of the payment. **Character limit**: 16 **Values**: a valid currency amount </value>
    [DataMember(Name="Amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Amount")]
    public double? Amount { get; set; }

    /// <summary>
    ///  The user ID of the person who created the invoice payment. **Character limit**: 32 **V****alues**: automatically generated 
    /// </summary>
    /// <value> The user ID of the person who created the invoice payment. **Character limit**: 32 **V****alues**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  The date when the invoice payment was generated. **Character limit**: 29 **V****alues**: automatically generated 
    /// </summary>
    /// <value> The date when the invoice payment was generated. **Character limit**: 29 **V****alues**: automatically generated </value>
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
    ///  The unique ID of the invoice associated with this invoice payment. **Character limit**: 32 **Values**: a valid invoice ID 
    /// </summary>
    /// <value> The unique ID of the invoice associated with this invoice payment. **Character limit**: 32 **Values**: a valid invoice ID </value>
    [DataMember(Name="InvoiceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceId")]
    public string InvoiceId { get; set; }

    /// <summary>
    ///  The unique ID of the payment associated with this invoice payment. **Character limit**: 32 **V****alues**: a valid payment ID 
    /// </summary>
    /// <value> The unique ID of the payment associated with this invoice payment. **Character limit**: 32 **V****alues**: a valid payment ID </value>
    [DataMember(Name="PaymentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentId")]
    public string PaymentId { get; set; }

    /// <summary>
    /// Specifies the amount of a refund applied against this InvoicePayment. **Character limit**: 16 **Values**: automatically generated 
    /// </summary>
    /// <value>Specifies the amount of a refund applied against this InvoicePayment. **Character limit**: 16 **Values**: automatically generated </value>
    [DataMember(Name="RefundAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefundAmount")]
    public double? RefundAmount { get; set; }

    /// <summary>
    ///  The ID of the user who last updated the invoice payment. **Character limit**: 32 **V****alues**: automatically generated 
    /// </summary>
    /// <value> The ID of the user who last updated the invoice payment. **Character limit**: 32 **V****alues**: automatically generated </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    ///  The date when the invoice payment was last updated. **Character limit**: 29 **V****alues**: automatically generated 
    /// </summary>
    /// <value> The date when the invoice payment was last updated. **Character limit**: 29 **V****alues**: automatically generated </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetInvoicePayment {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
      sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
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
