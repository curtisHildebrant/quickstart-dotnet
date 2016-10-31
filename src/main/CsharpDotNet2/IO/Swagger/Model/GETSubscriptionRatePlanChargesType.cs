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
  public class GETSubscriptionRatePlanChargesType {
    /// <summary>
    /// Specifies the type of charges a specific discount applies to.   This field is only used when applied to a discount charge model. If you are not using a discount charge model, the value is null.  Possible values:  * `RECURRING` * `USAGE` * `ONETIMERECURRING` * `ONETIMEUSAGE` * `RECURRINGUSAGE` * `ONETIMERECURRINGUSAGE` 
    /// </summary>
    /// <value>Specifies the type of charges a specific discount applies to.   This field is only used when applied to a discount charge model. If you are not using a discount charge model, the value is null.  Possible values:  * `RECURRING` * `USAGE` * `ONETIMERECURRING` * `ONETIMEUSAGE` * `RECURRINGUSAGE` * `ONETIMERECURRINGUSAGE` </value>
    [DataMember(Name="applyDiscountTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applyDiscountTo")]
    public string ApplyDiscountTo { get; set; }

    /// <summary>
    /// Billing cycle day (BCD), which is when bill runs generate invoices for charges associated with the product rate plan charge or the account.    Values:  * `DefaultFromCustomer` * `SpecificDayofMonth(#)` * `SubscriptionStartDay` * `ChargeTriggerDay` * `SpecificDayOfWeek/dayofweek`: in which dayofweek is the day in the week you define your billing periods to start.  In the response data, a day-of-the-month value (`1`-`31`) appears in place of the hash sign above (\"#\"). If this value exceeds the number of days in a particular month, the last day of the month is used as the BCD. 
    /// </summary>
    /// <value>Billing cycle day (BCD), which is when bill runs generate invoices for charges associated with the product rate plan charge or the account.    Values:  * `DefaultFromCustomer` * `SpecificDayofMonth(#)` * `SubscriptionStartDay` * `ChargeTriggerDay` * `SpecificDayOfWeek/dayofweek`: in which dayofweek is the day in the week you define your billing periods to start.  In the response data, a day-of-the-month value (`1`-`31`) appears in place of the hash sign above (\"#\"). If this value exceeds the number of days in a particular month, the last day of the month is used as the BCD. </value>
    [DataMember(Name="billingDay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingDay")]
    public string BillingDay { get; set; }

    /// <summary>
    /// Allows billing period to be overridden on the rate plan charge. 
    /// </summary>
    /// <value>Allows billing period to be overridden on the rate plan charge. </value>
    [DataMember(Name="billingPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingPeriod")]
    public string BillingPeriod { get; set; }

    /// <summary>
    /// Possible values:  * `AlignToCharge` * `AlignToSubscriptionStart` * `AlignToTermStart` 
    /// </summary>
    /// <value>Possible values:  * `AlignToCharge` * `AlignToSubscriptionStart` * `AlignToTermStart` </value>
    [DataMember(Name="billingPeriodAlignment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingPeriodAlignment")]
    public string BillingPeriodAlignment { get; set; }

    /// <summary>
    /// The billing timing for the charge. This field is only used if the `ratePlanChargeType` value is `Recurring`.  Possible values are:  * `In Advance` * `In Arrears`  **Note:** This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/). 
    /// </summary>
    /// <value>The billing timing for the charge. This field is only used if the `ratePlanChargeType` value is `Recurring`.  Possible values are:  * `In Advance` * `In Arrears`  **Note:** This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/). </value>
    [DataMember(Name="billingTiming", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingTiming")]
    public string BillingTiming { get; set; }

    /// <summary>
    /// The date through which a customer has been billed for the charge. 
    /// </summary>
    /// <value>The date through which a customer has been billed for the charge. </value>
    [DataMember(Name="chargedThroughDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargedThroughDate")]
    public DateTime? ChargedThroughDate { get; set; }

    /// <summary>
    /// Currency used by the account. For example, `USD` or `EUR`. 
    /// </summary>
    /// <value>Currency used by the account. For example, `USD` or `EUR`. </value>
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
    /// Description of the rate plan charge. 
    /// </summary>
    /// <value>Description of the rate plan charge. </value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The amount of the discount. 
    /// </summary>
    /// <value>The amount of the discount. </value>
    [DataMember(Name="discountAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discountAmount")]
    public string DiscountAmount { get; set; }

    /// <summary>
    /// The level of the discount. Values: `RatePlan`, `Subscription`, `Account`. 
    /// </summary>
    /// <value>The level of the discount. Values: `RatePlan`, `Subscription`, `Account`. </value>
    [DataMember(Name="discountLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discountLevel")]
    public string DiscountLevel { get; set; }

    /// <summary>
    /// The amount of the discount as a percentage. 
    /// </summary>
    /// <value>The amount of the discount as a percentage. </value>
    [DataMember(Name="discountPercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discountPercentage")]
    public string DiscountPercentage { get; set; }

    /// <summary>
    /// The change (delta) of monthly recurring charge exists when the change in monthly recurring revenue caused by an amendment or a new subscription. 
    /// </summary>
    /// <value>The change (delta) of monthly recurring charge exists when the change in monthly recurring revenue caused by an amendment or a new subscription. </value>
    [DataMember(Name="dmrc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dmrc")]
    public string Dmrc { get; set; }

    /// <summary>
    /// A value of `true` indicates that an invoice for a charge segment has been completed. A value of `false` indicates that an invoice has not bee completed for the charge segment. 
    /// </summary>
    /// <value>A value of `true` indicates that an invoice for a charge segment has been completed. A value of `false` indicates that an invoice has not bee completed for the charge segment. </value>
    [DataMember(Name="done", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "done")]
    public bool? Done { get; set; }

    /// <summary>
    /// After an amendment or an AutomatedPriceChange event, `dtcv` displays the change (delta) for the total contract value (TCV) amount for this charge, compared with its previous value with recurring charge types. 
    /// </summary>
    /// <value>After an amendment or an AutomatedPriceChange event, `dtcv` displays the change (delta) for the total contract value (TCV) amount for this charge, compared with its previous value with recurring charge types. </value>
    [DataMember(Name="dtcv", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dtcv")]
    public string Dtcv { get; set; }

    /// <summary>
    /// The effective end date of the rate plan charge. 
    /// </summary>
    /// <value>The effective end date of the rate plan charge. </value>
    [DataMember(Name="effectiveEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effectiveEndDate")]
    public DateTime? EffectiveEndDate { get; set; }

    /// <summary>
    /// The effective start date of the rate plan charge. 
    /// </summary>
    /// <value>The effective start date of the rate plan charge. </value>
    [DataMember(Name="effectiveStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effectiveStartDate")]
    public DateTime? EffectiveStartDate { get; set; }

    /// <summary>
    /// Defines when the charge ends after the charge trigger date.  If the subscription ends before the charge end date, the charge ends when the subscription ends. But if the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge will end on the charge end date.  Values:  * `Subscription_End` * `Fixed_Period` * `Specific_End_Date` 
    /// </summary>
    /// <value>Defines when the charge ends after the charge trigger date.  If the subscription ends before the charge end date, the charge ends when the subscription ends. But if the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge will end on the charge end date.  Values:  * `Subscription_End` * `Fixed_Period` * `Specific_End_Date` </value>
    [DataMember(Name="endDateCondition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDateCondition")]
    public string EndDateCondition { get; set; }

    /// <summary>
    /// Rate plan charge ID. 
    /// </summary>
    /// <value>Rate plan charge ID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Specifies the number of units in the base set of units. 
    /// </summary>
    /// <value>Specifies the number of units in the base set of units. </value>
    [DataMember(Name="includedUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includedUnits")]
    public string IncludedUnits { get; set; }

    /// <summary>
    /// List price base; possible values are:  * `Per_Billing_Period` * `Per_Month` * `Per_Week` 
    /// </summary>
    /// <value>List price base; possible values are:  * `Per_Billing_Period` * `Per_Month` * `Per_Week` </value>
    [DataMember(Name="listPriceBase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "listPriceBase")]
    public string ListPriceBase { get; set; }

    /// <summary>
    /// Charge model; possible values are:  * `FlatFee` * `PerUnit` * `Overage` * `Volume` * `Tiered` * `TieredWithOverage` * `DiscountFixedAmount` * `DiscountPercentage` 
    /// </summary>
    /// <value>Charge model; possible values are:  * `FlatFee` * `PerUnit` * `Overage` * `Volume` * `Tiered` * `TieredWithOverage` * `DiscountFixedAmount` * `DiscountPercentage` </value>
    [DataMember(Name="model", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "model")]
    public string Model { get; set; }

    /// <summary>
    /// Monthly recurring revenue of the rate plan charge. 
    /// </summary>
    /// <value>Monthly recurring revenue of the rate plan charge. </value>
    [DataMember(Name="mrr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mrr")]
    public string Mrr { get; set; }

    /// <summary>
    /// Charge name. 
    /// </summary>
    /// <value>Charge name. </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Charge number. 
    /// </summary>
    /// <value>Charge number. </value>
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
    /// The original ID of the rate plan charge. 
    /// </summary>
    /// <value>The original ID of the rate plan charge. </value>
    [DataMember(Name="originalChargeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalChargeId")]
    public string OriginalChargeId { get; set; }

    /// <summary>
    /// Determines when to calculate overage charges. 
    /// </summary>
    /// <value>Determines when to calculate overage charges. </value>
    [DataMember(Name="overageCalculationOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overageCalculationOption")]
    public string OverageCalculationOption { get; set; }

    /// <summary>
    /// The price for units over the allowed amount. 
    /// </summary>
    /// <value>The price for units over the allowed amount. </value>
    [DataMember(Name="overagePrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overagePrice")]
    public string OveragePrice { get; set; }

    /// <summary>
    /// Determines whether to credit the customer with unused units of usage. 
    /// </summary>
    /// <value>Determines whether to credit the customer with unused units of usage. </value>
    [DataMember(Name="overageUnusedUnitsCreditOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overageUnusedUnitsCreditOption")]
    public string OverageUnusedUnitsCreditOption { get; set; }

    /// <summary>
    /// The price associated with the rate plan charge expressed as a decimal. 
    /// </summary>
    /// <value>The price associated with the rate plan charge expressed as a decimal. </value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// When the following is true:  1. AutomatedPriceChange setting is on  2. Charge type is not one-time  3. Charge model is not discount percentage  Then an automatic price change can have a value for when a termed subscription is renewed.   Values (one of the following):  * `NoChange` (default) * `SpecificPercentageValue` * `UseLatestProductCatalogPricing` 
    /// </summary>
    /// <value>When the following is true:  1. AutomatedPriceChange setting is on  2. Charge type is not one-time  3. Charge model is not discount percentage  Then an automatic price change can have a value for when a termed subscription is renewed.   Values (one of the following):  * `NoChange` (default) * `SpecificPercentageValue` * `UseLatestProductCatalogPricing` </value>
    [DataMember(Name="priceChangeOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceChangeOption")]
    public string PriceChangeOption { get; set; }

    /// <summary>
    /// A planned future price increase amount as a percentage. 
    /// </summary>
    /// <value>A planned future price increase amount as a percentage. </value>
    [DataMember(Name="priceIncreasePercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceIncreasePercentage")]
    public string PriceIncreasePercentage { get; set; }

    /// <summary>
    /// Concise description of rate plan charge model. 
    /// </summary>
    /// <value>Concise description of rate plan charge model. </value>
    [DataMember(Name="pricingSummary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pricingSummary")]
    public string PricingSummary { get; set; }

    /// <summary>
    /// The date until when charges have been processed. When billing in arrears, such as usage, this field value is the the same as the `ChargedThroughDate` value. This date is the earliest date when a charge can be amended. 
    /// </summary>
    /// <value>The date until when charges have been processed. When billing in arrears, such as usage, this field value is the the same as the `ChargedThroughDate` value. This date is the earliest date when a charge can be amended. </value>
    [DataMember(Name="processedThroughDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processedThroughDate")]
    public DateTime? ProcessedThroughDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="productRatePlanChargeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productRatePlanChargeId")]
    public string ProductRatePlanChargeId { get; set; }

    /// <summary>
    /// The quantity of units, such as the number of authors in a hosted wiki service. Valid for all charge models except for Flat Fee pricing. 
    /// </summary>
    /// <value>The quantity of units, such as the number of authors in a hosted wiki service. Valid for all charge models except for Flat Fee pricing. </value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public string Quantity { get; set; }

    /// <summary>
    /// Specifies a rating group based on which usage records are rated.   Possible values are:  * `ByBillingPeriod` (default) * `ByUsageStartDate` * `ByUsageRecord` * `ByUsageUpload`  **Note:** This field is only used for per unit, volume pricing, and tiered pricing charge models. Use this field only for Usage charges. One-Time Charges and Recurring Charges return `NULL`.  **Note:** This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/). 
    /// </summary>
    /// <value>Specifies a rating group based on which usage records are rated.   Possible values are:  * `ByBillingPeriod` (default) * `ByUsageStartDate` * `ByUsageRecord` * `ByUsageUpload`  **Note:** This field is only used for per unit, volume pricing, and tiered pricing charge models. Use this field only for Usage charges. One-Time Charges and Recurring Charges return `NULL`.  **Note:** This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/). </value>
    [DataMember(Name="ratingGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratingGroup")]
    public string RatingGroup { get; set; }

    /// <summary>
    /// The identifying number of the subscription rate plan segment. Segments are numbered sequentially, starting with 1. 
    /// </summary>
    /// <value>The identifying number of the subscription rate plan segment. Segments are numbered sequentially, starting with 1. </value>
    [DataMember(Name="segment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segment")]
    public DateTime? Segment { get; set; }

    /// <summary>
    /// Specifies when revenue recognition begins. When charge model is `Overage` or `TieredWithOverage`, `smoothingModel` will be one of the following values:  * `ContractEffectiveDate` * `ServiceActivationDate` * `CustomerAcceptanceDate` 
    /// </summary>
    /// <value>Specifies when revenue recognition begins. When charge model is `Overage` or `TieredWithOverage`, `smoothingModel` will be one of the following values:  * `ContractEffectiveDate` * `ServiceActivationDate` * `CustomerAcceptanceDate` </value>
    [DataMember(Name="smoothingModel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "smoothingModel")]
    public string SmoothingModel { get; set; }

    /// <summary>
    /// Customizes the number of month or week for the charges billing period. This field is required if you set the value of the `BillingPeriod` field to `Specific_Months` or `Specific_Weeks`. 
    /// </summary>
    /// <value>Customizes the number of month or week for the charges billing period. This field is required if you set the value of the `BillingPeriod` field to `Specific_Months` or `Specific_Weeks`. </value>
    [DataMember(Name="specificBillingPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "specificBillingPeriod")]
    public long? SpecificBillingPeriod { get; set; }

    /// <summary>
    /// The specific date on which the charge ends. If the subscription ends before the specific end date, the charge ends when the subscription ends. But if the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge will end on the specific end date. 
    /// </summary>
    /// <value>The specific date on which the charge ends. If the subscription ends before the specific end date, the charge ends when the subscription ends. But if the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge will end on the specific end date. </value>
    [DataMember(Name="specificEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "specificEndDate")]
    public DateTime? SpecificEndDate { get; set; }

    /// <summary>
    /// The total contract value. 
    /// </summary>
    /// <value>The total contract value. </value>
    [DataMember(Name="tcv", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tcv")]
    public string Tcv { get; set; }

    /// <summary>
    /// One or many defined ranges with distinct pricing. 
    /// </summary>
    /// <value>One or many defined ranges with distinct pricing. </value>
    [DataMember(Name="tiers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tiers")]
    public List<GETTierType> Tiers { get; set; }

    /// <summary>
    /// The date that the rate plan charge will be triggered. 
    /// </summary>
    /// <value>The date that the rate plan charge will be triggered. </value>
    [DataMember(Name="triggerDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerDate")]
    public DateTime? TriggerDate { get; set; }

    /// <summary>
    /// The event that will cause the rate plan charge to be triggered.  Possible values:   * `ContractEffective` * `ServiceActivation` * `CustomerAcceptance` * `SpecificDate` 
    /// </summary>
    /// <value>The event that will cause the rate plan charge to be triggered.  Possible values:   * `ContractEffective` * `ServiceActivation` * `CustomerAcceptance` * `SpecificDate` </value>
    [DataMember(Name="triggerEvent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerEvent")]
    public string TriggerEvent { get; set; }

    /// <summary>
    /// Charge type. Possible values are: `OneTime`, `Recurring`, `Usage`. 
    /// </summary>
    /// <value>Charge type. Possible values are: `OneTime`, `Recurring`, `Usage`. </value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Specifies the rate to credit a customer for unused units of usage. This field is applicable only for overage charge models when the  `OverageUnusedUnitsCreditOption` field value is `CreditBySpecificRate`. 
    /// </summary>
    /// <value>Specifies the rate to credit a customer for unused units of usage. This field is applicable only for overage charge models when the  `OverageUnusedUnitsCreditOption` field value is `CreditBySpecificRate`. </value>
    [DataMember(Name="unusedUnitsCreditRates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unusedUnitsCreditRates")]
    public string UnusedUnitsCreditRates { get; set; }

    /// <summary>
    /// Specifies the units to measure usage.  
    /// </summary>
    /// <value>Specifies the units to measure usage.  </value>
    [DataMember(Name="uom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uom")]
    public string Uom { get; set; }

    /// <summary>
    /// Specifies the length of the period during which the charge is active. If this period ends before the subscription ends, the charge ends when this period ends.  If the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge end date will change accordingly up to the original period end. 
    /// </summary>
    /// <value>Specifies the length of the period during which the charge is active. If this period ends before the subscription ends, the charge ends when this period ends.  If the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge end date will change accordingly up to the original period end. </value>
    [DataMember(Name="upToPeriods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upToPeriods")]
    public string UpToPeriods { get; set; }

    /// <summary>
    /// The period type used to define when the charge ends.   Values:  * `Billing_Periods` * `Days` * `Weeks` * `Months` * `Years` 
    /// </summary>
    /// <value>The period type used to define when the charge ends.   Values:  * `Billing_Periods` * `Days` * `Weeks` * `Months` * `Years` </value>
    [DataMember(Name="upToPeriodsType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upToPeriodsType")]
    public string UpToPeriodsType { get; set; }

    /// <summary>
    /// Determines how Zuora processes usage records for per-unit usage charges.  
    /// </summary>
    /// <value>Determines how Zuora processes usage records for per-unit usage charges.  </value>
    [DataMember(Name="usageRecordRatingOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usageRecordRatingOption")]
    public string UsageRecordRatingOption { get; set; }

    /// <summary>
    /// Rate plan charge revision number. 
    /// </summary>
    /// <value>Rate plan charge revision number. </value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public long? Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETSubscriptionRatePlanChargesType {\n");
      sb.Append("  ApplyDiscountTo: ").Append(ApplyDiscountTo).Append("\n");
      sb.Append("  BillingDay: ").Append(BillingDay).Append("\n");
      sb.Append("  BillingPeriod: ").Append(BillingPeriod).Append("\n");
      sb.Append("  BillingPeriodAlignment: ").Append(BillingPeriodAlignment).Append("\n");
      sb.Append("  BillingTiming: ").Append(BillingTiming).Append("\n");
      sb.Append("  ChargedThroughDate: ").Append(ChargedThroughDate).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
      sb.Append("  DiscountLevel: ").Append(DiscountLevel).Append("\n");
      sb.Append("  DiscountPercentage: ").Append(DiscountPercentage).Append("\n");
      sb.Append("  Dmrc: ").Append(Dmrc).Append("\n");
      sb.Append("  Done: ").Append(Done).Append("\n");
      sb.Append("  Dtcv: ").Append(Dtcv).Append("\n");
      sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
      sb.Append("  EffectiveStartDate: ").Append(EffectiveStartDate).Append("\n");
      sb.Append("  EndDateCondition: ").Append(EndDateCondition).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IncludedUnits: ").Append(IncludedUnits).Append("\n");
      sb.Append("  ListPriceBase: ").Append(ListPriceBase).Append("\n");
      sb.Append("  Model: ").Append(Model).Append("\n");
      sb.Append("  Mrr: ").Append(Mrr).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  NumberOfPeriods: ").Append(NumberOfPeriods).Append("\n");
      sb.Append("  OriginalChargeId: ").Append(OriginalChargeId).Append("\n");
      sb.Append("  OverageCalculationOption: ").Append(OverageCalculationOption).Append("\n");
      sb.Append("  OveragePrice: ").Append(OveragePrice).Append("\n");
      sb.Append("  OverageUnusedUnitsCreditOption: ").Append(OverageUnusedUnitsCreditOption).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  PriceChangeOption: ").Append(PriceChangeOption).Append("\n");
      sb.Append("  PriceIncreasePercentage: ").Append(PriceIncreasePercentage).Append("\n");
      sb.Append("  PricingSummary: ").Append(PricingSummary).Append("\n");
      sb.Append("  ProcessedThroughDate: ").Append(ProcessedThroughDate).Append("\n");
      sb.Append("  ProductRatePlanChargeId: ").Append(ProductRatePlanChargeId).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  RatingGroup: ").Append(RatingGroup).Append("\n");
      sb.Append("  Segment: ").Append(Segment).Append("\n");
      sb.Append("  SmoothingModel: ").Append(SmoothingModel).Append("\n");
      sb.Append("  SpecificBillingPeriod: ").Append(SpecificBillingPeriod).Append("\n");
      sb.Append("  SpecificEndDate: ").Append(SpecificEndDate).Append("\n");
      sb.Append("  Tcv: ").Append(Tcv).Append("\n");
      sb.Append("  Tiers: ").Append(Tiers).Append("\n");
      sb.Append("  TriggerDate: ").Append(TriggerDate).Append("\n");
      sb.Append("  TriggerEvent: ").Append(TriggerEvent).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  UnusedUnitsCreditRates: ").Append(UnusedUnitsCreditRates).Append("\n");
      sb.Append("  Uom: ").Append(Uom).Append("\n");
      sb.Append("  UpToPeriods: ").Append(UpToPeriods).Append("\n");
      sb.Append("  UpToPeriodsType: ").Append(UpToPeriodsType).Append("\n");
      sb.Append("  UsageRecordRatingOption: ").Append(UsageRecordRatingOption).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
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
