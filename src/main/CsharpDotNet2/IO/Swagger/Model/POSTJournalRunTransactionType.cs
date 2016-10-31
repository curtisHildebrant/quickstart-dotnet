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
  public class POSTJournalRunTransactionType {
    /// <summary>
    /// Transaction type.   The transaction types are: * Invoice Item * Taxation Item * Invoice Item Adjustment (Invoice) * Invoice Item Adjustment (Tax) * Invoice Adjustment (Invoice Adjustment is deprecated on Production. Zuora recommends that you use the Invoice Item Adjustment instead.) * Electronic Payment * External Payment * Electronic Refund * External Refund * Electronic Credit Balance Payment * External Credit Balance Payment * Electronic Credit Balance Refund * External Credit Balance Refund * Credit Balance Adjustment (Applied from Credit Balance) * Credit Balance Adjustment (Transferred to Credit Balance) * Revenue Event Item  To include all transaction types, pass in \"All\". 
    /// </summary>
    /// <value>Transaction type.   The transaction types are: * Invoice Item * Taxation Item * Invoice Item Adjustment (Invoice) * Invoice Item Adjustment (Tax) * Invoice Adjustment (Invoice Adjustment is deprecated on Production. Zuora recommends that you use the Invoice Item Adjustment instead.) * Electronic Payment * External Payment * Electronic Refund * External Refund * Electronic Credit Balance Payment * External Credit Balance Payment * Electronic Credit Balance Refund * External Credit Balance Refund * Credit Balance Adjustment (Applied from Credit Balance) * Credit Balance Adjustment (Transferred to Credit Balance) * Revenue Event Item  To include all transaction types, pass in \"All\". </value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTJournalRunTransactionType {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
