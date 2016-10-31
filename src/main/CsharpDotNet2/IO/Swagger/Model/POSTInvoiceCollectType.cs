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
  public class POSTInvoiceCollectType {
    /// <summary>
    /// Customer account ID or account number. 
    /// </summary>
    /// <value>Customer account ID or account number. </value>
    [DataMember(Name="accountKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountKey")]
    public string AccountKey { get; set; }

    /// <summary>
    /// The invoice date that should appear on the invoice being generated, in `yyyy-mm-dd` format. If `invoiceId` is not specified and this value is omitted, the current date is used by default. 
    /// </summary>
    /// <value>The invoice date that should appear on the invoice being generated, in `yyyy-mm-dd` format. If `invoiceId` is not specified and this value is omitted, the current date is used by default. </value>
    [DataMember(Name="invoiceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceDate")]
    public DateTime? InvoiceDate { get; set; }

    /// <summary>
    /// The ID of an existing invoice for which to collect payment using the account's default payment method. If this value is specified, no new invoice is generated, and both `invoiceDate` and `invoiceTargetDate` are ignored. 
    /// </summary>
    /// <value>The ID of an existing invoice for which to collect payment using the account's default payment method. If this value is specified, no new invoice is generated, and both `invoiceDate` and `invoiceTargetDate` are ignored. </value>
    [DataMember(Name="invoiceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceId")]
    public string InvoiceId { get; set; }

    /// <summary>
    /// The date, in `yyyy-mm-dd` format, through which charges on this account will be processed when generating a new invoice.If `invoiceId` is not specified and this value is omitted, the current date is used by default. 
    /// </summary>
    /// <value>The date, in `yyyy-mm-dd` format, through which charges on this account will be processed when generating a new invoice.If `invoiceId` is not specified and this value is omitted, the current date is used by default. </value>
    [DataMember(Name="invoiceTargetDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceTargetDate")]
    public DateTime? InvoiceTargetDate { get; set; }

    /// <summary>
    /// The name of the gateway that will be used for the payment. Must be a valid gateway name and the gateway must support the specific payment method. If a value is not specified, the default gateway on the Account will be used. 
    /// </summary>
    /// <value>The name of the gateway that will be used for the payment. Must be a valid gateway name and the gateway must support the specific payment method. If a value is not specified, the default gateway on the Account will be used. </value>
    [DataMember(Name="paymentGateway", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentGateway")]
    public string PaymentGateway { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTInvoiceCollectType {\n");
      sb.Append("  AccountKey: ").Append(AccountKey).Append("\n");
      sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  InvoiceTargetDate: ").Append(InvoiceTargetDate).Append("\n");
      sb.Append("  PaymentGateway: ").Append(PaymentGateway).Append("\n");
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
