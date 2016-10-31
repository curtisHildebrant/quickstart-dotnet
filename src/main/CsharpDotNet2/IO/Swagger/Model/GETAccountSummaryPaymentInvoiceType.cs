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
  public class GETAccountSummaryPaymentInvoiceType {
    /// <summary>
    /// Amount of payment applied to the invoice. 
    /// </summary>
    /// <value>Amount of payment applied to the invoice. </value>
    [DataMember(Name="appliedPaymentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appliedPaymentAmount")]
    public string AppliedPaymentAmount { get; set; }

    /// <summary>
    /// Invoice ID. 
    /// </summary>
    /// <value>Invoice ID. </value>
    [DataMember(Name="invoiceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceId")]
    public string InvoiceId { get; set; }

    /// <summary>
    /// Invoice number. 
    /// </summary>
    /// <value>Invoice number. </value>
    [DataMember(Name="invoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceNumber")]
    public string InvoiceNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountSummaryPaymentInvoiceType {\n");
      sb.Append("  AppliedPaymentAmount: ").Append(AppliedPaymentAmount).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
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
