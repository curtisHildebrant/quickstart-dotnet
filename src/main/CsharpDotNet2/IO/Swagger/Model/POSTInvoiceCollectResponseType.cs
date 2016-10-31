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
  public class POSTInvoiceCollectResponseType {
    /// <summary>
    /// Payment amount applied. 
    /// </summary>
    /// <value>Payment amount applied. </value>
    [DataMember(Name="amountCollected", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountCollected")]
    public string AmountCollected { get; set; }

    /// <summary>
    /// Information on one or more invoices associated with this operation: 
    /// </summary>
    /// <value>Information on one or more invoices associated with this operation: </value>
    [DataMember(Name="invoices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoices")]
    public List<POSTInvoiceCollectInvoicesType> Invoices { get; set; }

    /// <summary>
    /// Payment ID. 
    /// </summary>
    /// <value>Payment ID. </value>
    [DataMember(Name="paymentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentId")]
    public string PaymentId { get; set; }

    /// <summary>
    /// Returns `true` if the request was processed successfully. 
    /// </summary>
    /// <value>Returns `true` if the request was processed successfully. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTInvoiceCollectResponseType {\n");
      sb.Append("  AmountCollected: ").Append(AmountCollected).Append("\n");
      sb.Append("  Invoices: ").Append(Invoices).Append("\n");
      sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
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
