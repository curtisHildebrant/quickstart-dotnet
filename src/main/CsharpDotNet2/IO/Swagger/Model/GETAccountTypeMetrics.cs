using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for [account metrics](https://knowledgecenter.zuora.com/BC_Subscription_Management/Customer_Accounts/A_How_to_Manage_Customer_Accounts/E_Key_Metrics). 
  /// </summary>
  [DataContract]
  public class GETAccountTypeMetrics {
    /// <summary>
    /// The customer's total invoice balance minus credit balance. 
    /// </summary>
    /// <value>The customer's total invoice balance minus credit balance. </value>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public string Balance { get; set; }

    /// <summary>
    /// Future expected MRR that accounts for future upgrades, downgrades, upsells and cancellations. 
    /// </summary>
    /// <value>Future expected MRR that accounts for future upgrades, downgrades, upsells and cancellations. </value>
    [DataMember(Name="contractedMrr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractedMrr")]
    public string ContractedMrr { get; set; }

    /// <summary>
    /// Current credit balance. 
    /// </summary>
    /// <value>Current credit balance. </value>
    [DataMember(Name="creditBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creditBalance")]
    public string CreditBalance { get; set; }

    /// <summary>
    /// Total of all open invoices. 
    /// </summary>
    /// <value>Total of all open invoices. </value>
    [DataMember(Name="totalInvoiceBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalInvoiceBalance")]
    public string TotalInvoiceBalance { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountTypeMetrics {\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  ContractedMrr: ").Append(ContractedMrr).Append("\n");
      sb.Append("  CreditBalance: ").Append(CreditBalance).Append("\n");
      sb.Append("  TotalInvoiceBalance: ").Append(TotalInvoiceBalance).Append("\n");
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
