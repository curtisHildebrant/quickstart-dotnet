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
  public class AmendOptions {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="ApplyCreditBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplyCreditBalance")]
    public bool? ApplyCreditBalance { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="ElectronicPaymentOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ElectronicPaymentOptions")]
    public ElectronicPaymentOptions ElectronicPaymentOptions { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="ExternalPaymentOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExternalPaymentOptions")]
    public ExternalPaymentOptions ExternalPaymentOptions { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="GenerateInvoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GenerateInvoice")]
    public bool? GenerateInvoice { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="InvoiceProcessingOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceProcessingOptions")]
    public InvoiceProcessingOptions InvoiceProcessingOptions { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="ProcessPayments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProcessPayments")]
    public bool? ProcessPayments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AmendOptions {\n");
      sb.Append("  ApplyCreditBalance: ").Append(ApplyCreditBalance).Append("\n");
      sb.Append("  ElectronicPaymentOptions: ").Append(ElectronicPaymentOptions).Append("\n");
      sb.Append("  ExternalPaymentOptions: ").Append(ExternalPaymentOptions).Append("\n");
      sb.Append("  GenerateInvoice: ").Append(GenerateInvoice).Append("\n");
      sb.Append("  InvoiceProcessingOptions: ").Append(InvoiceProcessingOptions).Append("\n");
      sb.Append("  ProcessPayments: ").Append(ProcessPayments).Append("\n");
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
