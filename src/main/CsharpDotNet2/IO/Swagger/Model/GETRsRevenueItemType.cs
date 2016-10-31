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
  public class GETRsRevenueItemType {
    /// <summary>
    /// The accounting period end date. The accounting period end date of the open-ended accounting period is null. 
    /// </summary>
    /// <value>The accounting period end date. The accounting period end date of the open-ended accounting period is null. </value>
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
    /// The amount of the revenue item. 
    /// </summary>
    /// <value>The amount of the revenue item. </value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// The type of currency used. 
    /// </summary>
    /// <value>The type of currency used. </value>
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
    /// The accounting code for deferred revenue, such as Monthly Recurring Liability. Required only when `overrideChargeAccountingCodes` is `true`. Otherwise this value is ignored. 
    /// </summary>
    /// <value>The accounting code for deferred revenue, such as Monthly Recurring Liability. Required only when `overrideChargeAccountingCodes` is `true`. Otherwise this value is ignored. </value>
    [DataMember(Name="deferredRevenueAccountingCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deferredRevenueAccountingCode")]
    public string DeferredRevenueAccountingCode { get; set; }

    /// <summary>
    /// The type associated with the deferred revenue accounting code, such as Deferred Revenue. Required only when `overrideChargeAccountingCodes` is `true`. Otherwise this value is ignored. 
    /// </summary>
    /// <value>The type associated with the deferred revenue accounting code, such as Deferred Revenue. Required only when `overrideChargeAccountingCodes` is `true`. Otherwise this value is ignored. </value>
    [DataMember(Name="deferredRevenueAccountingCodeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deferredRevenueAccountingCodeType")]
    public string DeferredRevenueAccountingCodeType { get; set; }

    /// <summary>
    /// Indicates if the accounting period is closed or open. 
    /// </summary>
    /// <value>Indicates if the accounting period is closed or open. </value>
    [DataMember(Name="isAccountingPeriodClosed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAccountingPeriodClosed")]
    public bool? IsAccountingPeriodClosed { get; set; }

    /// <summary>
    /// The accounting code for recognized revenue, such as Monthly Recurring Charges or Overage Charges. Required only when `overrideChargeAccountingCodes` is `true`. Otherwise the value is ignored. 
    /// </summary>
    /// <value>The accounting code for recognized revenue, such as Monthly Recurring Charges or Overage Charges. Required only when `overrideChargeAccountingCodes` is `true`. Otherwise the value is ignored. </value>
    [DataMember(Name="recognizedRevenueAccountingCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recognizedRevenueAccountingCode")]
    public string RecognizedRevenueAccountingCode { get; set; }

    /// <summary>
    /// The type associated with the recognized revenue accounting code, such as Sales Revenue or Sales Discount. Required only when `overrideChargeAccountingCodes` is `true`. Otherwise this value is ignored. 
    /// </summary>
    /// <value>The type associated with the recognized revenue accounting code, such as Sales Revenue or Sales Discount. Required only when `overrideChargeAccountingCodes` is `true`. Otherwise this value is ignored. </value>
    [DataMember(Name="recognizedRevenueAccountingCodeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recognizedRevenueAccountingCodeType")]
    public string RecognizedRevenueAccountingCodeType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETRsRevenueItemType {\n");
      sb.Append("  AccountingPeriodEndDate: ").Append(AccountingPeriodEndDate).Append("\n");
      sb.Append("  AccountingPeriodName: ").Append(AccountingPeriodName).Append("\n");
      sb.Append("  AccountingPeriodStartDate: ").Append(AccountingPeriodStartDate).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  DeferredRevenueAccountingCode: ").Append(DeferredRevenueAccountingCode).Append("\n");
      sb.Append("  DeferredRevenueAccountingCodeType: ").Append(DeferredRevenueAccountingCodeType).Append("\n");
      sb.Append("  IsAccountingPeriodClosed: ").Append(IsAccountingPeriodClosed).Append("\n");
      sb.Append("  RecognizedRevenueAccountingCode: ").Append(RecognizedRevenueAccountingCode).Append("\n");
      sb.Append("  RecognizedRevenueAccountingCodeType: ").Append(RecognizedRevenueAccountingCodeType).Append("\n");
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
