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
  public class GETAccountSummaryPaymentType {
    /// <summary>
    /// Effective date as `yyyy-mm-dd`. 
    /// </summary>
    /// <value>Effective date as `yyyy-mm-dd`. </value>
    [DataMember(Name="effectiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effectiveDate")]
    public DateTime? EffectiveDate { get; set; }

    /// <summary>
    /// Payment ID. 
    /// </summary>
    /// <value>Payment ID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Container for paid invoices for this subscription. 
    /// </summary>
    /// <value>Container for paid invoices for this subscription. </value>
    [DataMember(Name="paidInvoices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paidInvoices")]
    public List<GETAccountSummaryPaymentInvoiceType> PaidInvoices { get; set; }

    /// <summary>
    /// Payment number. 
    /// </summary>
    /// <value>Payment number. </value>
    [DataMember(Name="paymentNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentNumber")]
    public string PaymentNumber { get; set; }

    /// <summary>
    /// Payment type; possible values are: `External`, `Electronic`. 
    /// </summary>
    /// <value>Payment type; possible values are: `External`, `Electronic`. </value>
    [DataMember(Name="paymentType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentType")]
    public string PaymentType { get; set; }

    /// <summary>
    /// Payment status. Possible values are: `Draft`, `Processing`, `Processed`, `Error`, `Voided`, `Canceled`, `Posted`. 
    /// </summary>
    /// <value>Payment status. Possible values are: `Draft`, `Processing`, `Processed`, `Error`, `Voided`, `Canceled`, `Posted`. </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountSummaryPaymentType {\n");
      sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  PaidInvoices: ").Append(PaidInvoices).Append("\n");
      sb.Append("  PaymentNumber: ").Append(PaymentNumber).Append("\n");
      sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
