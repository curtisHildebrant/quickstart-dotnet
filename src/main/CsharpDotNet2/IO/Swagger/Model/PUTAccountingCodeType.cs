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
  public class PUTAccountingCodeType {
    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Name of the account in your general ledger.  Field only available if you have Z-Finance enabled. Maximum of 255 characters. 
    /// </summary>
    /// <value>Name of the account in your general ledger.  Field only available if you have Z-Finance enabled. Maximum of 255 characters. </value>
    [DataMember(Name="glAccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "glAccountName")]
    public string GlAccountName { get; set; }

    /// <summary>
    /// Account number in your general ledger.  Field only available if you have Z-Finance enabled. Maximum of 255 characters. 
    /// </summary>
    /// <value>Account number in your general ledger.  Field only available if you have Z-Finance enabled. Maximum of 255 characters. </value>
    [DataMember(Name="glAccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "glAccountNumber")]
    public string GlAccountNumber { get; set; }

    /// <summary>
    /// Name of the accounting code.  Accounting code name must be unique. Maximum of 100 characters. 
    /// </summary>
    /// <value>Name of the accounting code.  Accounting code name must be unique. Maximum of 100 characters. </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Maximum of 2,000 characters. 
    /// </summary>
    /// <value>Maximum of 2,000 characters. </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// Accounting code type.   Valid values are as follows: * `AccountsReceivable` * `Cash` * `OtherAssets` * `CustomerCashOnAccount` * `DeferredRevenue` * `SalesTaxPayable` * `OtherLiabilities` * `SalesRevenue` * `SalesDiscounts` * `OtherRevenue` * `OtherEquity` * `BadDebt` * `OtherExpenses`            You cannot change the type of an accounting code from `AccountsReceivable` to a different type. 
    /// </summary>
    /// <value>Accounting code type.   Valid values are as follows: * `AccountsReceivable` * `Cash` * `OtherAssets` * `CustomerCashOnAccount` * `DeferredRevenue` * `SalesTaxPayable` * `OtherLiabilities` * `SalesRevenue` * `SalesDiscounts` * `OtherRevenue` * `OtherEquity` * `BadDebt` * `OtherExpenses`            You cannot change the type of an accounting code from `AccountsReceivable` to a different type. </value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PUTAccountingCodeType {\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  GlAccountName: ").Append(GlAccountName).Append("\n");
      sb.Append("  GlAccountNumber: ").Append(GlAccountNumber).Append("\n");
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
