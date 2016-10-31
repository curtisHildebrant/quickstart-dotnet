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
  public class GETAccountSummaryInvoiceType {
    /// <summary>
    /// Invoice amount before adjustments, discounts, and similar items. 
    /// </summary>
    /// <value>Invoice amount before adjustments, discounts, and similar items. </value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// Balance due on the invoice. 
    /// </summary>
    /// <value>Balance due on the invoice. </value>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public string Balance { get; set; }

    /// <summary>
    /// Due date as `yyyy-mm-dd`. 
    /// </summary>
    /// <value>Due date as `yyyy-mm-dd`. </value>
    [DataMember(Name="dueDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dueDate")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Invoice ID. 
    /// </summary>
    /// <value>Invoice ID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Invoice date as `yyyy-mm-dd`. 
    /// </summary>
    /// <value>Invoice date as `yyyy-mm-dd`. </value>
    [DataMember(Name="invoiceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceDate")]
    public DateTime? InvoiceDate { get; set; }

    /// <summary>
    /// Invoice number. 
    /// </summary>
    /// <value>Invoice number. </value>
    [DataMember(Name="invoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceNumber")]
    public string InvoiceNumber { get; set; }

    /// <summary>
    /// Invoice status - not the payment status of the invoice, just the status of the invoice itself. Possible values are: `Posted`, `Draft`, `Canceled`, `Error`. 
    /// </summary>
    /// <value>Invoice status - not the payment status of the invoice, just the status of the invoice itself. Possible values are: `Posted`, `Draft`, `Canceled`, `Error`. </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountSummaryInvoiceType {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  DueDate: ").Append(DueDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
      sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
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
