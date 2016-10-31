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
  public class POSTRevenueScheduleByChargeType {
    /// <summary>
    /// The revenue schedule amount, which is the sum of all revenue items. This field cannot be null and must be formatted based on the currency, such as `JPY 30` or `USD 30.15`. Test out the currency to ensure you are using the proper formatting otherwise, the response will fail and this error message is returned: `Allocation amount with wrong decimal places.` 
    /// </summary>
    /// <value>The revenue schedule amount, which is the sum of all revenue items. This field cannot be null and must be formatted based on the currency, such as `JPY 30` or `USD 30.15`. Test out the currency to ensure you are using the proper formatting otherwise, the response will fail and this error message is returned: `Allocation amount with wrong decimal places.` </value>
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
    /// Additional information about this record.  Character Limit: 2,000 
    /// </summary>
    /// <value>Additional information about this record.  Character Limit: 2,000 </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// When overriding accounting codes from a charge, `recognizedRevenueAccountingCode` and `deferredRevenue AccountingCode` must be in the request body and can have empty value.  `True` or `False`. A `false` value will be used if this field is empty in the request body. 
    /// </summary>
    /// <value>When overriding accounting codes from a charge, `recognizedRevenueAccountingCode` and `deferredRevenue AccountingCode` must be in the request body and can have empty value.  `True` or `False`. A `false` value will be used if this field is empty in the request body. </value>
    [DataMember(Name="overrideChargeAccountingCodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overrideChargeAccountingCodes")]
    public bool? OverrideChargeAccountingCodes { get; set; }

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
    /// Reference ID is used only in the custom unlimited rule to create a revenue schedule. In this scenario, the revenue schedule is not linked to an invoice item or invoice item adjustment.  Character Limit: 60 
    /// </summary>
    /// <value>Reference ID is used only in the custom unlimited rule to create a revenue schedule. In this scenario, the revenue schedule is not linked to an invoice item or invoice item adjustment.  Character Limit: 60 </value>
    [DataMember(Name="referenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceId")]
    public string ReferenceId { get; set; }

    /// <summary>
    /// An array of revenue distributions. Represents how you want to distribute revenue for this revenue schedule. You can distribute revenue into a maximum of 250 accounting periods with one revenue schedule.  The sum of the newAmount fields must be equal to the amount field. 
    /// </summary>
    /// <value>An array of revenue distributions. Represents how you want to distribute revenue for this revenue schedule. You can distribute revenue into a maximum of 250 accounting periods with one revenue schedule.  The sum of the newAmount fields must be equal to the amount field. </value>
    [DataMember(Name="revenueDistributions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueDistributions")]
    public List<POSTDistributionItemType> RevenueDistributions { get; set; }

    /// <summary>
    /// Gets or Sets RevenueEvent
    /// </summary>
    [DataMember(Name="revenueEvent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueEvent")]
    public POSTRevenueScheduleByChargeTypeRevenueEvent RevenueEvent { get; set; }

    /// <summary>
    /// The effective date of the revenue schedule. For example, the revenue schedule date for bookings-based revenue recognition is typically set to the order date or contract date.  The date cannot be in a closed accounting period. The date must be in the `YYYY-MM-DD` format. 
    /// </summary>
    /// <value>The effective date of the revenue schedule. For example, the revenue schedule date for bookings-based revenue recognition is typically set to the order date or contract date.  The date cannot be in a closed accounting period. The date must be in the `YYYY-MM-DD` format. </value>
    [DataMember(Name="revenueScheduleDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueScheduleDate")]
    public DateTime? RevenueScheduleDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTRevenueScheduleByChargeType {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  DeferredRevenueAccountingCode: ").Append(DeferredRevenueAccountingCode).Append("\n");
      sb.Append("  DeferredRevenueAccountingCodeType: ").Append(DeferredRevenueAccountingCodeType).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  OverrideChargeAccountingCodes: ").Append(OverrideChargeAccountingCodes).Append("\n");
      sb.Append("  RecognizedRevenueAccountingCode: ").Append(RecognizedRevenueAccountingCode).Append("\n");
      sb.Append("  RecognizedRevenueAccountingCodeType: ").Append(RecognizedRevenueAccountingCodeType).Append("\n");
      sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
      sb.Append("  RevenueDistributions: ").Append(RevenueDistributions).Append("\n");
      sb.Append("  RevenueEvent: ").Append(RevenueEvent).Append("\n");
      sb.Append("  RevenueScheduleDate: ").Append(RevenueScheduleDate).Append("\n");
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
