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
  public class ProxyCreateAccountingCode {
    /// <summary>
    ///  The account name in general ledger (GL) that corresponds to accounting code. **Character limit**: 255 **Z-Finance Required:** Yes 
    /// </summary>
    /// <value> The account name in general ledger (GL) that corresponds to accounting code. **Character limit**: 255 **Z-Finance Required:** Yes </value>
    [DataMember(Name="GLAccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GLAccountName")]
    public string GLAccountName { get; set; }

    /// <summary>
    ///  The account number in the GL that corresponds to the accounting code. **Character limit**: 50 **Z-Finance Required:** Yes 
    /// </summary>
    /// <value> The account number in the GL that corresponds to the accounting code. **Character limit**: 50 **Z-Finance Required:** Yes </value>
    [DataMember(Name="GLAccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GLAccountNumber")]
    public string GLAccountNumber { get; set; }

    /// <summary>
    ///  The name of the accounting code. **Character limit**: 100 **Z-Finance Required:** No 
    /// </summary>
    /// <value> The name of the accounting code. **Character limit**: 100 **Z-Finance Required:** No </value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    ///  Any note about the accounting code. **Character limit:** 2000 **Z-Finance Required**: No 
    /// </summary>
    /// <value> Any note about the accounting code. **Character limit:** 2000 **Z-Finance Required**: No </value>
    [DataMember(Name="Notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Notes")]
    public string Notes { get; set; }

    /// <summary>
    ///  The accounting code type. Possible values:  - AccountsReceivable - Cash - OtherAssets - CustomerCashOnAccount - DeferredRevenue - SalesTaxPayable - OtherLiabilities - SalesRevenue - SalesDiscounts - OtherRevenue - OtherEquity - BadDebt - OtherExpenses **Character limit**: N/A **Z-Finance Required:** No 
    /// </summary>
    /// <value> The accounting code type. Possible values:  - AccountsReceivable - Cash - OtherAssets - CustomerCashOnAccount - DeferredRevenue - SalesTaxPayable - OtherLiabilities - SalesRevenue - SalesDiscounts - OtherRevenue - OtherEquity - BadDebt - OtherExpenses **Character limit**: N/A **Z-Finance Required:** No </value>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyCreateAccountingCode {\n");
      sb.Append("  GLAccountName: ").Append(GLAccountName).Append("\n");
      sb.Append("  GLAccountNumber: ").Append(GLAccountNumber).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
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
