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
  public class ProxyCreateInvoicePayment {
    /// <summary>
    ///  The amount of the payment. **Character limit**: 16 **Values**: a valid currency amount 
    /// </summary>
    /// <value> The amount of the payment. **Character limit**: 16 **Values**: a valid currency amount </value>
    [DataMember(Name="Amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Amount")]
    public double? Amount { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyCreateInvoicePayment {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
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
