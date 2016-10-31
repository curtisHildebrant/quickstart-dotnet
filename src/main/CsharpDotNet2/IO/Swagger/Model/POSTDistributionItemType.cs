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
  public class POSTDistributionItemType {
    /// <summary>
    /// Name of the accounting period. The open-ended accounting period is named `Open-Ended`.   The accounting period must be open. 
    /// </summary>
    /// <value>Name of the accounting period. The open-ended accounting period is named `Open-Ended`.   The accounting period must be open. </value>
    [DataMember(Name="accountingPeriodName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingPeriodName")]
    public string AccountingPeriodName { get; set; }

    /// <summary>
    /// Amount of revenue you want to distribute into the accounting period.  The value must be formatted based on the currency, for example, `JPY 30` or `USD 30.15`. If the value is formatted incorrectly, the following error message is returned: `Allocation amount with wrong decimal places.` 
    /// </summary>
    /// <value>Amount of revenue you want to distribute into the accounting period.  The value must be formatted based on the currency, for example, `JPY 30` or `USD 30.15`. If the value is formatted incorrectly, the following error message is returned: `Allocation amount with wrong decimal places.` </value>
    [DataMember(Name="newAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "newAmount")]
    public string NewAmount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTDistributionItemType {\n");
      sb.Append("  AccountingPeriodName: ").Append(AccountingPeriodName).Append("\n");
      sb.Append("  NewAmount: ").Append(NewAmount).Append("\n");
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
