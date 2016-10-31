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
  public class GETRevenueItemType {
    /// <summary>
    /// The accounting period end date. The accounting period end date of the open-ended accounting period is null.  
    /// </summary>
    /// <value>The accounting period end date. The accounting period end date of the open-ended accounting period is null.  </value>
    [DataMember(Name="accountingPeriodEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingPeriodEndDate")]
    public DateTime? AccountingPeriodEndDate { get; set; }

    /// <summary>
    /// Name of the accounting period. The open-ended accounting period is named `Open-Ended`.  
    /// </summary>
    /// <value>Name of the accounting period. The open-ended accounting period is named `Open-Ended`.  </value>
    [DataMember(Name="accountingPeriodName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingPeriodName")]
    public string AccountingPeriodName { get; set; }

    /// <summary>
    /// The accounting period start date. 
    /// </summary>
    /// <value>The accounting period start date. </value>
    [DataMember(Name="accountingPeriodStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingPeriodStartDate")]
    public DateTime? AccountingPeriodStartDate { get; set; }

    /// <summary>
    /// The revenue schedule amount, which is the sum of all revenue items. This field cannot be null and must be formatted based on the currency, such as *JPY 30* or *USD 30.15*. Test out the currency to ensure you are using the proper formatting otherwise, the response will fail and this error message is returned:  `Allocation amount with wrong decimal places.` 
    /// </summary>
    /// <value>The revenue schedule amount, which is the sum of all revenue items. This field cannot be null and must be formatted based on the currency, such as *JPY 30* or *USD 30.15*. Test out the currency to ensure you are using the proper formatting otherwise, the response will fail and this error message is returned:  `Allocation amount with wrong decimal places.` </value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// The type of currency used.  
    /// </summary>
    /// <value>The type of currency used.  </value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Indicates if the accounting period is closed or open.  
    /// </summary>
    /// <value>Indicates if the accounting period is closed or open.  </value>
    [DataMember(Name="isAccountingPeriodClosed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAccountingPeriodClosed")]
    public bool? IsAccountingPeriodClosed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETRevenueItemType {\n");
      sb.Append("  AccountingPeriodEndDate: ").Append(AccountingPeriodEndDate).Append("\n");
      sb.Append("  AccountingPeriodName: ").Append(AccountingPeriodName).Append("\n");
      sb.Append("  AccountingPeriodStartDate: ").Append(AccountingPeriodStartDate).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  IsAccountingPeriodClosed: ").Append(IsAccountingPeriodClosed).Append("\n");
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
