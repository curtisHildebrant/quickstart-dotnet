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
  public class POSTScCreateType {
    /// <summary>
    /// Specifies the type of charges that you want a specific discount to apply to.  Values:  * `ONETIME` * `RECURRING` * `USAGE` * `ONETIMERECURRING` * `ONETIMEUSAGE` * `RECURRINGUSAGE` * `ONETIMERECURRINGUSAGE` 
    /// </summary>
    /// <value>Specifies the type of charges that you want a specific discount to apply to.  Values:  * `ONETIME` * `RECURRING` * `USAGE` * `ONETIMERECURRING` * `ONETIMEUSAGE` * `RECURRINGUSAGE` * `ONETIMERECURRINGUSAGE` </value>
    [DataMember(Name="applyDiscountTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applyDiscountTo")]
    public string ApplyDiscountTo { get; set; }

    /// <summary>
    /// Sets the bill cycle day (BCD) for the charge. The BCD determines which day of the month the customer is billed.  Values: `1`-`31` 
    /// </summary>
    /// <value>Sets the bill cycle day (BCD) for the charge. The BCD determines which day of the month the customer is billed.  Values: `1`-`31` </value>
    [DataMember(Name="billCycleDay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billCycleDay")]
    public string BillCycleDay { get; set; }

    /// <summary>
    /// Specifies how to determine the billing day for the charge. When this field is set to `SpecificDayOfMonth`, set the `BillCycleDay` field. When this field is set to `SpecificDayOfWeek`, set the `weeklyBillCycleDay` field.  Values:  * `DefaultFromCustomer` * `SpecificDayOfMonth` * `SubscriptionStartDay` * `ChargeTriggerDay` * `SpecificDayOfWeek` 
    /// </summary>
    /// <value>Specifies how to determine the billing day for the charge. When this field is set to `SpecificDayOfMonth`, set the `BillCycleDay` field. When this field is set to `SpecificDayOfWeek`, set the `weeklyBillCycleDay` field.  Values:  * `DefaultFromCustomer` * `SpecificDayOfMonth` * `SubscriptionStartDay` * `ChargeTriggerDay` * `SpecificDayOfWeek` </value>
    [DataMember(Name="billCycleType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billCycleType")]
    public string BillCycleType { get; set; }

    /// <summary>
    /// Billing period for the charge. The start day of the billing period is also called the bill cycle day (BCD).  Values:  * `Month` * `Quarter` * `Semi_Annual` * `Annual` * `Eighteen_Months` * `Two_Years` * `Three_Years` * `Five_Years` * `Specific_Months` * `Subscription_Term` * `Week` * `Specific_Weeks` 
    /// </summary>
    /// <value>Billing period for the charge. The start day of the billing period is also called the bill cycle day (BCD).  Values:  * `Month` * `Quarter` * `Semi_Annual` * `Annual` * `Eighteen_Months` * `Two_Years` * `Three_Years` * `Five_Years` * `Specific_Months` * `Subscription_Term` * `Week` * `Specific_Weeks` </value>
    [DataMember(Name="billingPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingPeriod")]
    public string BillingPeriod { get; set; }

    /// <summary>
    /// Aligns charges within the same subscription if multiple charges begin on different dates.  Values:  * `AlignToCharge` * `AlignToSubscriptionStart` * `AlignToTermStart` 
    /// </summary>
    /// <value>Aligns charges within the same subscription if multiple charges begin on different dates.  Values:  * `AlignToCharge` * `AlignToSubscriptionStart` * `AlignToTermStart` </value>
    [DataMember(Name="billingPeriodAlignment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingPeriodAlignment")]
    public string BillingPeriodAlignment { get; set; }

    /// <summary>
    /// Billing timing for the charge for recurring charge types. Not avaliable for one time, usage, and discount charges.  Values:  * `IN_ADVANCE` (default) * `IN_ARREARS` 
    /// </summary>
    /// <value>Billing timing for the charge for recurring charge types. Not avaliable for one time, usage, and discount charges.  Values:  * `IN_ADVANCE` (default) * `IN_ARREARS` </value>
    [DataMember(Name="billingTiming", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingTiming")]
    public string BillingTiming { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Description of the charge. 
    /// </summary>
    /// <value>Description of the charge. </value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Specifies the amount of fixed-amount discount. 
    /// </summary>
    /// <value>Specifies the amount of fixed-amount discount. </value>
    [DataMember(Name="discountAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discountAmount")]
    public string DiscountAmount { get; set; }

    /// <summary>
    /// Specifies if the discount applies to the product rate plan only, the entire subscription, or to any activity in the account.  Values:  * `rateplan` * `subscription` * `account` 
    /// </summary>
    /// <value>Specifies if the discount applies to the product rate plan only, the entire subscription, or to any activity in the account.  Values:  * `rateplan` * `subscription` * `account` </value>
    [DataMember(Name="discountLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discountLevel")]
    public string DiscountLevel { get; set; }

    /// <summary>
    /// Percentage of discount for a percentage discount.  
    /// </summary>
    /// <value>Percentage of discount for a percentage discount.  </value>
    [DataMember(Name="discountPercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discountPercentage")]
    public string DiscountPercentage { get; set; }

    /// <summary>
    /// Defines when the charge ends after the charge trigger date. If the subscription ends before the charge end date, the charge ends when the subscription ends. But if the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge will end on the charge end date.  Values:  * `Subscription_End` * `Fixed_Period` * `Specific_End_Date` 
    /// </summary>
    /// <value>Defines when the charge ends after the charge trigger date. If the subscription ends before the charge end date, the charge ends when the subscription ends. But if the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge will end on the charge end date.  Values:  * `Subscription_End` * `Fixed_Period` * `Specific_End_Date` </value>
    [DataMember(Name="endDateCondition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDateCondition")]
    public string EndDateCondition { get; set; }

    /// <summary>
    /// Specifies the number of units in the base set of units for this charge. Must be >=`0`. 
    /// </summary>
    /// <value>Specifies the number of units in the base set of units for this charge. Must be >=`0`. </value>
    [DataMember(Name="includedUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includedUnits")]
    public string IncludedUnits { get; set; }

    /// <summary>
    /// The list price base for the product rate plan charge.  Values:  * `Per_Billing_Period` * `Per_Month` * `Per_Week` 
    /// </summary>
    /// <value>The list price base for the product rate plan charge.  Values:  * `Per_Billing_Period` * `Per_Month` * `Per_Week` </value>
    [DataMember(Name="listPriceBase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "listPriceBase")]
    public string ListPriceBase { get; set; }

    /// <summary>
    /// Unique number that identifies the charge. Max 50 characters. System-generated if not provided. 
    /// </summary>
    /// <value>Unique number that identifies the charge. Max 50 characters. System-generated if not provided. </value>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public string Number { get; set; }

    /// <summary>
    /// Specifies the number of periods to use when calculating charges in an overage smoothing charge model. 
    /// </summary>
    /// <value>Specifies the number of periods to use when calculating charges in an overage smoothing charge model. </value>
    [DataMember(Name="numberOfPeriods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfPeriods")]
    public long? NumberOfPeriods { get; set; }

    /// <summary>
    /// Price for units over the allowed amount. 
    /// </summary>
    /// <value>Price for units over the allowed amount. </value>
    [DataMember(Name="overagePrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overagePrice")]
    public string OveragePrice { get; set; }

    /// <summary>
    /// Determines whether to credit the customer with unused units of usage.  Values:  * `NoCredit` * `CreditBySpecificRate` 
    /// </summary>
    /// <value>Determines whether to credit the customer with unused units of usage.  Values:  * `NoCredit` * `CreditBySpecificRate` </value>
    [DataMember(Name="overageUnusedUnitsCreditOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overageUnusedUnitsCreditOption")]
    public string OverageUnusedUnitsCreditOption { get; set; }

    /// <summary>
    /// Price for units in the subscription rate plan. 
    /// </summary>
    /// <value>Price for units in the subscription rate plan. </value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// Applies an automatic price change when a termed subscription is renewed. The Billing Admin setting **Enable Automatic Price Change When Subscriptions are Renewed?** must be set to Yes to use this field. See [Define Default Subscription Settings](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings) for more information on setting this option.  Values:  * `NoChange` (default) * `SpecificPercentageValue` * `UseLatestProductCatalogPricing` 
    /// </summary>
    /// <value>Applies an automatic price change when a termed subscription is renewed. The Billing Admin setting **Enable Automatic Price Change When Subscriptions are Renewed?** must be set to Yes to use this field. See [Define Default Subscription Settings](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings) for more information on setting this option.  Values:  * `NoChange` (default) * `SpecificPercentageValue` * `UseLatestProductCatalogPricing` </value>
    [DataMember(Name="priceChangeOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceChangeOption")]
    public string PriceChangeOption { get; set; }

    /// <summary>
    /// Specifies the percentage to increase or decrease the price of a termed subscription's renewal. Required if you set the `PriceChangeOption` field to `SpecificPercentageValue`.   Value must be a decimal between `-100` and `100`. 
    /// </summary>
    /// <value>Specifies the percentage to increase or decrease the price of a termed subscription's renewal. Required if you set the `PriceChangeOption` field to `SpecificPercentageValue`.   Value must be a decimal between `-100` and `100`. </value>
    [DataMember(Name="priceIncreasePercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceIncreasePercentage")]
    public string PriceIncreasePercentage { get; set; }

    /// <summary>
    /// ID of a product rate-plan charge for this subscription. 
    /// </summary>
    /// <value>ID of a product rate-plan charge for this subscription. </value>
    [DataMember(Name="productRatePlanChargeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productRatePlanChargeId")]
    public string ProductRatePlanChargeId { get; set; }

    /// <summary>
    /// Number of units. Must be a decimal >=`0`. 
    /// </summary>
    /// <value>Number of units. Must be a decimal >=`0`. </value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public string Quantity { get; set; }

    /// <summary>
    /// Specifies a rating group based on which usage records are rated. See [Usages Rating by Group](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/Usage/Usage_Rating_by_Group) for more information.  **Note:** This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  Values:  * `ByBillingPeriod` (default): The rating is based on all the usages in a billing period.        * `ByUsageStartDate`: The rating is based on all the usages on the same usage start date.  * `ByUsageRecord`: The rating is based on each usage record. * `ByUsageUpload`: The rating is based on all the usages in a uploaded usage file (.xls or .csv).  **Note:**  The `ByBillingPeriod` value can be applied for all charge models. The `ByUsageStartDate`, `ByUsageRecord`, and `ByUsageUpload` values can only be applied for per unit, volume pricing, and tiered pricing charge models. Use this field only for Usage charges. One-Time Charges and Recurring Charges return `NULL`. 
    /// </summary>
    /// <value>Specifies a rating group based on which usage records are rated. See [Usages Rating by Group](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/Usage/Usage_Rating_by_Group) for more information.  **Note:** This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  Values:  * `ByBillingPeriod` (default): The rating is based on all the usages in a billing period.        * `ByUsageStartDate`: The rating is based on all the usages on the same usage start date.  * `ByUsageRecord`: The rating is based on each usage record. * `ByUsageUpload`: The rating is based on all the usages in a uploaded usage file (.xls or .csv).  **Note:**  The `ByBillingPeriod` value can be applied for all charge models. The `ByUsageStartDate`, `ByUsageRecord`, and `ByUsageUpload` values can only be applied for per unit, volume pricing, and tiered pricing charge models. Use this field only for Usage charges. One-Time Charges and Recurring Charges return `NULL`. </value>
    [DataMember(Name="ratingGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratingGroup")]
    public string RatingGroup { get; set; }

    /// <summary>
    /// Specifies the number of month or week for the charges billing period. Required if you set the value of the `billingPeriod` field to `Specific_Months` or `Specific_Weeks`. 
    /// </summary>
    /// <value>Specifies the number of month or week for the charges billing period. Required if you set the value of the `billingPeriod` field to `Specific_Months` or `Specific_Weeks`. </value>
    [DataMember(Name="specificBillingPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "specificBillingPeriod")]
    public long? SpecificBillingPeriod { get; set; }

    /// <summary>
    /// Defines when the charge ends after the charge trigger date.  **note:**  * This field is only applicable when the `endDateCondition` field is set to `Specific_End_Date`.  * If the subscription ends before the specific end date, the charge ends when the subscription ends. But if the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge will end on the specific end date. 
    /// </summary>
    /// <value>Defines when the charge ends after the charge trigger date.  **note:**  * This field is only applicable when the `endDateCondition` field is set to `Specific_End_Date`.  * If the subscription ends before the specific end date, the charge ends when the subscription ends. But if the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge will end on the specific end date. </value>
    [DataMember(Name="specificEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "specificEndDate")]
    public DateTime? SpecificEndDate { get; set; }

    /// <summary>
    /// Container for Volume, Tiered, or Tiered with Overage charge models. Supports the following charge types:  * One-time * Recurring * Usage-based 
    /// </summary>
    /// <value>Container for Volume, Tiered, or Tiered with Overage charge models. Supports the following charge types:  * One-time * Recurring * Usage-based </value>
    [DataMember(Name="tiers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tiers")]
    public List<POSTTierType> Tiers { get; set; }

    /// <summary>
    /// Specifies when to start billing the customer for the charge. Required if the `triggerEvent` field is set to `USD`. 
    /// </summary>
    /// <value>Specifies when to start billing the customer for the charge. Required if the `triggerEvent` field is set to `USD`. </value>
    [DataMember(Name="triggerDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerDate")]
    public DateTime? TriggerDate { get; set; }

    /// <summary>
    /// Specifies when to start billing the customer for the charge.  Values:  * `UCE` * `USA` * `UCA` * `USD` 
    /// </summary>
    /// <value>Specifies when to start billing the customer for the charge.  Values:  * `UCE` * `USA` * `UCA` * `USD` </value>
    [DataMember(Name="triggerEvent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerEvent")]
    public string TriggerEvent { get; set; }

    /// <summary>
    /// Specifies the rate to credit a customer for unused units of usage. This field applies only for overage charge models when the `OverageUnusedUnitsCreditOption` field is set to `CreditBySpecificRate`. 
    /// </summary>
    /// <value>Specifies the rate to credit a customer for unused units of usage. This field applies only for overage charge models when the `OverageUnusedUnitsCreditOption` field is set to `CreditBySpecificRate`. </value>
    [DataMember(Name="unusedUnitsCreditRates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unusedUnitsCreditRates")]
    public string UnusedUnitsCreditRates { get; set; }

    /// <summary>
    /// Specifies the length of the period during which the charge is active. If this period ends before the subscription ends, the charge ends when this period ends.  **Note:** You must use this field together with the `upToPeriodsType` field to specify the time period.  * This field is applicable only when the `endDateCondition` field is set to `Fixed_Period`.  * If the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge end date will change accordingly up to the original period end. 
    /// </summary>
    /// <value>Specifies the length of the period during which the charge is active. If this period ends before the subscription ends, the charge ends when this period ends.  **Note:** You must use this field together with the `upToPeriodsType` field to specify the time period.  * This field is applicable only when the `endDateCondition` field is set to `Fixed_Period`.  * If the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge end date will change accordingly up to the original period end. </value>
    [DataMember(Name="upToPeriods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upToPeriods")]
    public long? UpToPeriods { get; set; }

    /// <summary>
    ///  The period type used to define when the charge ends.   Values:  * `Billing_Periods` * `Days` * `Weeks` * `Months` * `Years`  You must use this field together with the `upToPeriods` field to specify the time period.  This field is applicable only when the `endDateCondition` field is set to `Fixed_Period`.  
    /// </summary>
    /// <value> The period type used to define when the charge ends.   Values:  * `Billing_Periods` * `Days` * `Weeks` * `Months` * `Years`  You must use this field together with the `upToPeriods` field to specify the time period.  This field is applicable only when the `endDateCondition` field is set to `Fixed_Period`.  </value>
    [DataMember(Name="upToPeriodsType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upToPeriodsType")]
    public string UpToPeriodsType { get; set; }

    /// <summary>
    /// Specifies which day of the week is the bill cycle day (BCD) for the charge.   Values:  * `Sunday` * `Monday` * `Tuesday` * `Wednesday` * `Thursday` * `Friday` * `Saturday` 
    /// </summary>
    /// <value>Specifies which day of the week is the bill cycle day (BCD) for the charge.   Values:  * `Sunday` * `Monday` * `Tuesday` * `Wednesday` * `Thursday` * `Friday` * `Saturday` </value>
    [DataMember(Name="weeklyBillCycleDay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weeklyBillCycleDay")]
    public string WeeklyBillCycleDay { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTScCreateType {\n");
      sb.Append("  ApplyDiscountTo: ").Append(ApplyDiscountTo).Append("\n");
      sb.Append("  BillCycleDay: ").Append(BillCycleDay).Append("\n");
      sb.Append("  BillCycleType: ").Append(BillCycleType).Append("\n");
      sb.Append("  BillingPeriod: ").Append(BillingPeriod).Append("\n");
      sb.Append("  BillingPeriodAlignment: ").Append(BillingPeriodAlignment).Append("\n");
      sb.Append("  BillingTiming: ").Append(BillingTiming).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
      sb.Append("  DiscountLevel: ").Append(DiscountLevel).Append("\n");
      sb.Append("  DiscountPercentage: ").Append(DiscountPercentage).Append("\n");
      sb.Append("  EndDateCondition: ").Append(EndDateCondition).Append("\n");
      sb.Append("  IncludedUnits: ").Append(IncludedUnits).Append("\n");
      sb.Append("  ListPriceBase: ").Append(ListPriceBase).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  NumberOfPeriods: ").Append(NumberOfPeriods).Append("\n");
      sb.Append("  OveragePrice: ").Append(OveragePrice).Append("\n");
      sb.Append("  OverageUnusedUnitsCreditOption: ").Append(OverageUnusedUnitsCreditOption).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  PriceChangeOption: ").Append(PriceChangeOption).Append("\n");
      sb.Append("  PriceIncreasePercentage: ").Append(PriceIncreasePercentage).Append("\n");
      sb.Append("  ProductRatePlanChargeId: ").Append(ProductRatePlanChargeId).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  RatingGroup: ").Append(RatingGroup).Append("\n");
      sb.Append("  SpecificBillingPeriod: ").Append(SpecificBillingPeriod).Append("\n");
      sb.Append("  SpecificEndDate: ").Append(SpecificEndDate).Append("\n");
      sb.Append("  Tiers: ").Append(Tiers).Append("\n");
      sb.Append("  TriggerDate: ").Append(TriggerDate).Append("\n");
      sb.Append("  TriggerEvent: ").Append(TriggerEvent).Append("\n");
      sb.Append("  UnusedUnitsCreditRates: ").Append(UnusedUnitsCreditRates).Append("\n");
      sb.Append("  UpToPeriods: ").Append(UpToPeriods).Append("\n");
      sb.Append("  UpToPeriodsType: ").Append(UpToPeriodsType).Append("\n");
      sb.Append("  WeeklyBillCycleDay: ").Append(WeeklyBillCycleDay).Append("\n");
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
