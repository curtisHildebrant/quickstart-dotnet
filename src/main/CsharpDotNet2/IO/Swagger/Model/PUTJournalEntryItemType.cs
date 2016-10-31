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
  public class PUTJournalEntryItemType {
    /// <summary>
    /// Name of the accounting code.  If the Journal Entry Item has a blank accounting code, enter the empty string (“”).  
    /// </summary>
    /// <value>Name of the accounting code.  If the Journal Entry Item has a blank accounting code, enter the empty string (“”).  </value>
    [DataMember(Name="accountingCodeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingCodeName")]
    public string AccountingCodeName { get; set; }

    /// <summary>
    /// Accounting code type. The accounting code types are:   * `AccountsReceivable`   *  `Cash`   *  `OtherAssets`   *  `CustomerCashOnAccount `   * `DeferredRevenue`   * `SalesTaxPayable`   * `OtherLiabilities`   * `SalesRevenue`   * `SalesDiscounts`   * `OtherRevenue`    * `OtherEquity`   * `BadDebt`     * `OtherExpenses`        
    /// </summary>
    /// <value>Accounting code type. The accounting code types are:   * `AccountsReceivable`   *  `Cash`   *  `OtherAssets`   *  `CustomerCashOnAccount `   * `DeferredRevenue`   * `SalesTaxPayable`   * `OtherLiabilities`   * `SalesRevenue`   * `SalesDiscounts`   * `OtherRevenue`    * `OtherEquity`   * `BadDebt`     * `OtherExpenses`        </value>
    [DataMember(Name="accountingCodeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingCodeType")]
    public string AccountingCodeType { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Type of journal entry item. An enum with the value `Credit` or `Debit`. 
    /// </summary>
    /// <value>Type of journal entry item. An enum with the value `Credit` or `Debit`. </value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PUTJournalEntryItemType {\n");
      sb.Append("  AccountingCodeName: ").Append(AccountingCodeName).Append("\n");
      sb.Append("  AccountingCodeType: ").Append(AccountingCodeType).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
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
