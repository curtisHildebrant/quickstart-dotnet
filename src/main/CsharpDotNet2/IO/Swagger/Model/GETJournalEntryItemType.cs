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
  public class GETJournalEntryItemType {
    /// <summary>
    /// Name of the accounting code. 
    /// </summary>
    /// <value>Name of the accounting code. </value>
    [DataMember(Name="accountingCodeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingCodeName")]
    public string AccountingCodeName { get; set; }

    /// <summary>
    /// Accounting code type. The accounting code types are:  * `AccountsReceivable` *  `Cash` *  `OtherAssets` *  `CustomerCashOnAccount ` * `DeferredRevenue` * `SalesTaxPayable` * `OtherLiabilities` * `SalesRevenue` * `SalesDiscounts` * `OtherRevenue`  * `OtherEquity` * `BadDebt`   * `OtherExpenses` 
    /// </summary>
    /// <value>Accounting code type. The accounting code types are:  * `AccountsReceivable` *  `Cash` *  `OtherAssets` *  `CustomerCashOnAccount ` * `DeferredRevenue` * `SalesTaxPayable` * `OtherLiabilities` * `SalesRevenue` * `SalesDiscounts` * `OtherRevenue`  * `OtherEquity` * `BadDebt`   * `OtherExpenses` </value>
    [DataMember(Name="accountingCodeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingCodeType")]
    public string AccountingCodeType { get; set; }

    /// <summary>
    /// Journal entry item amount in transaction currency. 
    /// </summary>
    /// <value>Journal entry item amount in transaction currency. </value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// The account number in the general ledger (GL) that corresponds to the accounting code. 
    /// </summary>
    /// <value>The account number in the general ledger (GL) that corresponds to the accounting code. </value>
    [DataMember(Name="glAccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "glAccountName")]
    public string GlAccountName { get; set; }

    /// <summary>
    /// The account name in the general ledger (GL) that corresponds to the accounting code. 
    /// </summary>
    /// <value>The account name in the general ledger (GL) that corresponds to the accounting code. </value>
    [DataMember(Name="glAccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "glAccountNumber")]
    public string GlAccountNumber { get; set; }

    /// <summary>
    /// Journal entry item amount in home currency. 
    /// </summary>
    /// <value>Journal entry item amount in home currency. </value>
    [DataMember(Name="homeCurrencyAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "homeCurrencyAmount")]
    public string HomeCurrencyAmount { get; set; }

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
      sb.Append("class GETJournalEntryItemType {\n");
      sb.Append("  AccountingCodeName: ").Append(AccountingCodeName).Append("\n");
      sb.Append("  AccountingCodeType: ").Append(AccountingCodeType).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  GlAccountName: ").Append(GlAccountName).Append("\n");
      sb.Append("  GlAccountNumber: ").Append(GlAccountNumber).Append("\n");
      sb.Append("  HomeCurrencyAmount: ").Append(HomeCurrencyAmount).Append("\n");
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
