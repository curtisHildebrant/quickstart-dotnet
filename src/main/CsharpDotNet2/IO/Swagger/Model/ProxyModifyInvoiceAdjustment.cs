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
  public class ProxyModifyInvoiceAdjustment {
    /// <summary>
    ///  A code identifying the reason for the transaction. Must be an existing reason code or empty. If you do not specify a value, Zuora uses the default reason code. **Character limit**: 32 **V****alues**: a valid [reason code](/C_Zuora_User_Guides/A_Billing_and_Payments/R_Reason_Codes_for_Payment_Operations) 
    /// </summary>
    /// <value> A code identifying the reason for the transaction. Must be an existing reason code or empty. If you do not specify a value, Zuora uses the default reason code. **Character limit**: 32 **V****alues**: a valid [reason code](/C_Zuora_User_Guides/A_Billing_and_Payments/R_Reason_Codes_for_Payment_Operations) </value>
    [DataMember(Name="ReasonCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonCode")]
    public string ReasonCode { get; set; }

    /// <summary>
    ///  The status of the invoice adjustment. This field is required in `query()` calls, but is automatically generated in other calls. **Character limit**: 9 **Values**: `Canceled`, `Processed` 
    /// </summary>
    /// <value> The status of the invoice adjustment. This field is required in `query()` calls, but is automatically generated in other calls. **Character limit**: 9 **Values**: `Canceled`, `Processed` </value>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    ///  Indicates the status of the adjustment's transfer to an external accounting system, such as NetSuite. **Character limit**: 10 **Values**: `Processing`, `Yes`, `Error`, `Ignore` 
    /// </summary>
    /// <value> Indicates the status of the adjustment's transfer to an external accounting system, such as NetSuite. **Character limit**: 10 **Values**: `Processing`, `Yes`, `Error`, `Ignore` </value>
    [DataMember(Name="TransferredToAccounting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransferredToAccounting")]
    public string TransferredToAccounting { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyModifyInvoiceAdjustment {\n");
      sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  TransferredToAccounting: ").Append(TransferredToAccounting).Append("\n");
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
