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
  public class GETProductRatePlanChargeType {
    /// <summary>
    /// Specifies where (to what charge type) the discount will be applied. These field values are case-sensitive.  Permissible values: - RECURRING - USAGE - ONETIMERECURRING - ONETIMEUSAGE - RECURRINGUSAGE - ONETIMERECURRINGUSAGE 
    /// </summary>
    /// <value>Specifies where (to what charge type) the discount will be applied. These field values are case-sensitive.  Permissible values: - RECURRING - USAGE - ONETIMERECURRING - ONETIMEUSAGE - RECURRINGUSAGE - ONETIMERECURRINGUSAGE </value>
    [DataMember(Name="applyDiscountTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applyDiscountTo")]
    public string ApplyDiscountTo { get; set; }

    /// <summary>
    /// The [bill cycle day](https://knowledgecenter.zuora.com/CB_Billing/WA_Dates_in_Zuora/C_Customer_Account_Dates%3A_Bill_Cycle_Day) (BCD) for the charge. The BCD determines which day of the month or week the customer is billed. The BCD value in the account can override the BCD in this object. 
    /// </summary>
    /// <value>The [bill cycle day](https://knowledgecenter.zuora.com/CB_Billing/WA_Dates_in_Zuora/C_Customer_Account_Dates%3A_Bill_Cycle_Day) (BCD) for the charge. The BCD determines which day of the month or week the customer is billed. The BCD value in the account can override the BCD in this object. </value>
    [DataMember(Name="billingDay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingDay")]
    public string BillingDay { get; set; }

    /// <summary>
    /// The billing period for the charge. The start day of the billing period is also called the bill cycle day (BCD).  Values: - Month - Quarter - Annual - Semi-Annual - Specific Months - Week - Specific_Weeks 
    /// </summary>
    /// <value>The billing period for the charge. The start day of the billing period is also called the bill cycle day (BCD).  Values: - Month - Quarter - Annual - Semi-Annual - Specific Months - Week - Specific_Weeks </value>
    [DataMember(Name="billingPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingPeriod")]
    public string BillingPeriod { get; set; }

    /// <summary>
    /// Aligns charges within the same subscription if multiple charges begin on different dates.  Possible values: - AlignToCharge - AlignToSubscriptionStart - AlignToTermStart 
    /// </summary>
    /// <value>Aligns charges within the same subscription if multiple charges begin on different dates.  Possible values: - AlignToCharge - AlignToSubscriptionStart - AlignToTermStart </value>
    [DataMember(Name="billingPeriodAlignment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingPeriodAlignment")]
    public string BillingPeriodAlignment { get; set; }

    /// <summary>
    /// The billing timing for the charge. You can choose to bill for charges in advance or in arrears.  Values: - In Advance - In Arrears  **Note:** This feature is in Limited Availability. If you wish to have access to the feature, submit a request at [Zuora Global Support](https://support.zuora.com).  
    /// </summary>
    /// <value>The billing timing for the charge. You can choose to bill for charges in advance or in arrears.  Values: - In Advance - In Arrears  **Note:** This feature is in Limited Availability. If you wish to have access to the feature, submit a request at [Zuora Global Support](https://support.zuora.com).  </value>
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
    /// The default quantity of units.  This field is required if you use a per-unit charge model. 
    /// </summary>
    /// <value>The default quantity of units.  This field is required if you use a per-unit charge model. </value>
    [DataMember(Name="defaultQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultQuantity")]
    public string DefaultQuantity { get; set; }

    /// <summary>
    /// Usually a brief line item summary of the Rate Plan Charge. 
    /// </summary>
    /// <value>Usually a brief line item summary of the Rate Plan Charge. </value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The level of the discount.   Values: - RatePlan - Subscription - Account 
    /// </summary>
    /// <value>The level of the discount.   Values: - RatePlan - Subscription - Account </value>
    [DataMember(Name="discountLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discountLevel")]
    public string DiscountLevel { get; set; }

    /// <summary>
    /// Defines when the charge ends after the charge trigger date. If the subscription ends before the charge end date, the charge ends when the subscription ends. But if the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge will end on the charge end date.  Values: - Subscription_End - Fixed_Period 
    /// </summary>
    /// <value>Defines when the charge ends after the charge trigger date. If the subscription ends before the charge end date, the charge ends when the subscription ends. But if the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge will end on the charge end date.  Values: - Subscription_End - Fixed_Period </value>
    [DataMember(Name="endDateCondition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDateCondition")]
    public string EndDateCondition { get; set; }

    /// <summary>
    /// Gets or Sets FinanceInformation
    /// </summary>
    [DataMember(Name="financeInformation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "financeInformation")]
    public GETProductRatePlanChargeTypeFinanceInformation FinanceInformation { get; set; }

    /// <summary>
    /// Unique product rate-plan charge ID. 
    /// </summary>
    /// <value>Unique product rate-plan charge ID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Specifies the number of units in the base set of units when the charge model is Overage. 
    /// </summary>
    /// <value>Specifies the number of units in the base set of units when the charge model is Overage. </value>
    [DataMember(Name="includedUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includedUnits")]
    public string IncludedUnits { get; set; }

    /// <summary>
    /// The list price base for the product rate plan charge.  Values: - Month - Billing Period - Per_Week 
    /// </summary>
    /// <value>The list price base for the product rate plan charge.  Values: - Month - Billing Period - Per_Week </value>
    [DataMember(Name="listPriceBase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "listPriceBase")]
    public string ListPriceBase { get; set; }

    /// <summary>
    /// Specifies the maximum number of units for this charge. Use this field and the `minQuantity` field to create a range of units allowed in a product rate plan charge. 
    /// </summary>
    /// <value>Specifies the maximum number of units for this charge. Use this field and the `minQuantity` field to create a range of units allowed in a product rate plan charge. </value>
    [DataMember(Name="maxQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxQuantity")]
    public string MaxQuantity { get; set; }

    /// <summary>
    /// Specifies the minimum number of units for this charge. Use this field and the `maxQuantity` field to create a range of units allowed in a product rate plan charge. 
    /// </summary>
    /// <value>Specifies the minimum number of units for this charge. Use this field and the `maxQuantity` field to create a range of units allowed in a product rate plan charge. </value>
    [DataMember(Name="minQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minQuantity")]
    public string MinQuantity { get; set; }

    /// <summary>
    /// Charge model which determines how charges are calculated.  [Charge models](https://knowledgecenter.zuora.com/BC_Subscription_Management/Product_Catalog/B_Charge_Models) must be individually activated in Z-Billing administration.   Possible values are: - FlatFee - PerUnit - Overage - Volume - Tiered - TieredWithOverage - DiscountFixedAmount - DiscountPercentage The [Pricing Summaries](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Catalog#Pricing_Summaries) section below details these charge models and their associated pricingSummary values. 
    /// </summary>
    /// <value>Charge model which determines how charges are calculated.  [Charge models](https://knowledgecenter.zuora.com/BC_Subscription_Management/Product_Catalog/B_Charge_Models) must be individually activated in Z-Billing administration.   Possible values are: - FlatFee - PerUnit - Overage - Volume - Tiered - TieredWithOverage - DiscountFixedAmount - DiscountPercentage The [Pricing Summaries](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Catalog#Pricing_Summaries) section below details these charge models and their associated pricingSummary values. </value>
    [DataMember(Name="model", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "model")]
    public string Model { get; set; }

    /// <summary>
    /// Name of the product rate-plan charge. (Not required to be unique.) 
    /// </summary>
    /// <value>Name of the product rate-plan charge. (Not required to be unique.) </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Value specifies the number of periods used in the smoothing model calculations Used when overage smoothing model is `RollingWindow` or `Rollover`. 
    /// </summary>
    /// <value>Value specifies the number of periods used in the smoothing model calculations Used when overage smoothing model is `RollingWindow` or `Rollover`. </value>
    [DataMember(Name="numberOfPeriods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfPeriods")]
    public long? NumberOfPeriods { get; set; }

    /// <summary>
    /// Value specifies when to calculate overage charges.  Values: - EndOfSmoothingPeriod - PerBillingPeriod 
    /// </summary>
    /// <value>Value specifies when to calculate overage charges.  Values: - EndOfSmoothingPeriod - PerBillingPeriod </value>
    [DataMember(Name="overageCalculationOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overageCalculationOption")]
    public string OverageCalculationOption { get; set; }

    /// <summary>
    /// Determines whether to credit the customer with unused units of usage.  Values: - NoCredit - CreditBySpecificRate 
    /// </summary>
    /// <value>Determines whether to credit the customer with unused units of usage.  Values: - NoCredit - CreditBySpecificRate </value>
    [DataMember(Name="overageUnusedUnitsCreditOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overageUnusedUnitsCreditOption")]
    public string OverageUnusedUnitsCreditOption { get; set; }

    /// <summary>
    /// The number of periods to which prepayment is set.   **Note:** This field is only available if you already have the [prepayment](https://knowledgecenter.zuora.com/BC_Subscription_Management/Product_Catalog/A_Product_Catalog_Concepts/zz_Prepayments) feature enabled. The prepayment feature is deprecated and available only for backward compatibility. Zuora does not support enabling this feature anymore. 
    /// </summary>
    /// <value>The number of periods to which prepayment is set.   **Note:** This field is only available if you already have the [prepayment](https://knowledgecenter.zuora.com/BC_Subscription_Management/Product_Catalog/A_Product_Catalog_Concepts/zz_Prepayments) feature enabled. The prepayment feature is deprecated and available only for backward compatibility. Zuora does not support enabling this feature anymore. </value>
    [DataMember(Name="prepayPeriods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prepayPeriods")]
    public long? PrepayPeriods { get; set; }

    /// <summary>
    /// Applies an automatic price change when a termed subscription is renewed and the following applies:  1. AutomatedPriceChange setting is on 2. Charge type is not one-time 3. Charge model is not discount fixed amount  Values: - NoChange (default) - SpecificPercentageValue - UseLatestProductCatalogPricing 
    /// </summary>
    /// <value>Applies an automatic price change when a termed subscription is renewed and the following applies:  1. AutomatedPriceChange setting is on 2. Charge type is not one-time 3. Charge model is not discount fixed amount  Values: - NoChange (default) - SpecificPercentageValue - UseLatestProductCatalogPricing </value>
    [DataMember(Name="priceChangeOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceChangeOption")]
    public string PriceChangeOption { get; set; }

    /// <summary>
    /// Specifies the percentage to increase or decrease the price of a termed subscription's renewal. Use this field if you set the `PriceChangeOption` value to `SpecificPercentageValue`.  1. AutomatedPriceChange setting is on 2. Charge type is not one-time 3. Charge model is not discount fixed amount  Values: a decimal between -100 and 100 
    /// </summary>
    /// <value>Specifies the percentage to increase or decrease the price of a termed subscription's renewal. Use this field if you set the `PriceChangeOption` value to `SpecificPercentageValue`.  1. AutomatedPriceChange setting is on 2. Charge type is not one-time 3. Charge model is not discount fixed amount  Values: a decimal between -100 and 100 </value>
    [DataMember(Name="priceIncreasePercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceIncreasePercentage")]
    public string PriceIncreasePercentage { get; set; }

    /// <summary>
    /// One or more price charge models with attributes that further describe the model.  Some attributes show as null values when not applicable. 
    /// </summary>
    /// <value>One or more price charge models with attributes that further describe the model.  Some attributes show as null values when not applicable. </value>
    [DataMember(Name="pricing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pricing")]
    public List<GETProductRatePlanChargePricingType> Pricing { get; set; }

    /// <summary>
    /// A concise description of the charge model and pricing that is suitable to show to your customers. See [Pricing Summaries](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Catalog#Pricing_Summaries) below for more information. 
    /// </summary>
    /// <value>A concise description of the charge model and pricing that is suitable to show to your customers. See [Pricing Summaries](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Catalog#Pricing_Summaries) below for more information. </value>
    [DataMember(Name="pricingSummary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pricingSummary")]
    public List<string> PricingSummary { get; set; }

    /// <summary>
    /// Specifies a rating group based on which usage records are rated.   **Note:** This feature is in Limited Availability. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  
    /// </summary>
    /// <value>Specifies a rating group based on which usage records are rated.   **Note:** This feature is in Limited Availability. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  </value>
    [DataMember(Name="ratingGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratingGroup")]
    public string RatingGroup { get; set; }

    /// <summary>
    /// The name of the revenue recognition rule governing the revenue schedule. 
    /// </summary>
    /// <value>The name of the revenue recognition rule governing the revenue schedule. </value>
    [DataMember(Name="revenueRecognitionRuleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueRecognitionRuleName")]
    public string RevenueRecognitionRuleName { get; set; }

    /// <summary>
    /// Specifies the smoothing model for an [overage smoothing charge model](https://knowledgecenter.zuora.com/CB_Billing/D_Product_Catalog/B_Charge_Models/A_Overage_Smoothing_Charge_Model) or an tiered with overage model, which is an advanced type of a usage model that avoids spikes in usage charges. If a customer's usage spikes in a single period, then an overage smoothing model eases overage charges by considering usage and multiple periods.  One of the following values shows which smoothing model will be applied to the charge when `Overage` or `Tiered with Overage` is used:  - `RollingWindow` considers a number of periods to smooth usage. The rolling window starts and increments forward based on billing frequency. When allowed usage is met, then period resets and a new window begins. - `Rollover` considers a fixed number of periods before calculating usage. The net balance at the end of a period is unused usage, which is carried over to the next period's balance. 
    /// </summary>
    /// <value>Specifies the smoothing model for an [overage smoothing charge model](https://knowledgecenter.zuora.com/CB_Billing/D_Product_Catalog/B_Charge_Models/A_Overage_Smoothing_Charge_Model) or an tiered with overage model, which is an advanced type of a usage model that avoids spikes in usage charges. If a customer's usage spikes in a single period, then an overage smoothing model eases overage charges by considering usage and multiple periods.  One of the following values shows which smoothing model will be applied to the charge when `Overage` or `Tiered with Overage` is used:  - `RollingWindow` considers a number of periods to smooth usage. The rolling window starts and increments forward based on billing frequency. When allowed usage is met, then period resets and a new window begins. - `Rollover` considers a fixed number of periods before calculating usage. The net balance at the end of a period is unused usage, which is carried over to the next period's balance. </value>
    [DataMember(Name="smoothingModel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "smoothingModel")]
    public string SmoothingModel { get; set; }

    /// <summary>
    /// When the billing period is set to `Specific` Months then this positive integer reflects the number of months for billing period charges. 
    /// </summary>
    /// <value>When the billing period is set to `Specific` Months then this positive integer reflects the number of months for billing period charges. </value>
    [DataMember(Name="specificBillingPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "specificBillingPeriod")]
    public long? SpecificBillingPeriod { get; set; }

    /// <summary>
    /// Specifies the [tax code](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax/B_Configure_Tax_Codes_in_Z-Billing) for taxation rules; used by Z-Tax. 
    /// </summary>
    /// <value>Specifies the [tax code](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax/B_Configure_Tax_Codes_in_Z-Billing) for taxation rules; used by Z-Tax. </value>
    [DataMember(Name="taxCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxCode")]
    public string TaxCode { get; set; }

    /// <summary>
    /// Specifies how to define taxation for the charge; used by Z-Tax. Possible values are: `TaxExclusive`, `TaxInclusive`. 
    /// </summary>
    /// <value>Specifies how to define taxation for the charge; used by Z-Tax. Possible values are: `TaxExclusive`, `TaxInclusive`. </value>
    [DataMember(Name="taxMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxMode")]
    public string TaxMode { get; set; }

    /// <summary>
    /// Specifies whether the charge is taxable; used by Z-Tax. Possible values are:`true`, `false`. 
    /// </summary>
    /// <value>Specifies whether the charge is taxable; used by Z-Tax. Possible values are:`true`, `false`. </value>
    [DataMember(Name="taxable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxable")]
    public bool? Taxable { get; set; }

    /// <summary>
    /// Specifies when to start billing the customer for the charge.  Values: one of the following: - `ContractEffective` is the date when the subscription's contract goes into effect and the charge is ready to be billed. - `ServiceActivation` is the date when the services or products for a subscription have been activated and the customers have access. - `CustomerAcceptance` is when the customer accepts the services or products for a subscription.  - `SpecificDate` is the date specified. 
    /// </summary>
    /// <value>Specifies when to start billing the customer for the charge.  Values: one of the following: - `ContractEffective` is the date when the subscription's contract goes into effect and the charge is ready to be billed. - `ServiceActivation` is the date when the services or products for a subscription have been activated and the customers have access. - `CustomerAcceptance` is when the customer accepts the services or products for a subscription.  - `SpecificDate` is the date specified. </value>
    [DataMember(Name="triggerEvent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerEvent")]
    public string TriggerEvent { get; set; }

    /// <summary>
    /// The type of charge. Possible values are: `OneTime`, `Recurring`, `Usage`. 
    /// </summary>
    /// <value>The type of charge. Possible values are: `OneTime`, `Recurring`, `Usage`. </value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Describes the Units of Measure (uom) configured in **Z-Billing > Settings** for the productRatePlanCharges.  Values: `Each`, `License`, `Seat`, or `null` 
    /// </summary>
    /// <value>Describes the Units of Measure (uom) configured in **Z-Billing > Settings** for the productRatePlanCharges.  Values: `Each`, `License`, `Seat`, or `null` </value>
    [DataMember(Name="uom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uom")]
    public string Uom { get; set; }

    /// <summary>
    /// Specifies the length of the period during which the charge is active. If this period ends before the subscription ends, the charge ends when this period ends. If the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge end date will change accordingly up to the original period end. 
    /// </summary>
    /// <value>Specifies the length of the period during which the charge is active. If this period ends before the subscription ends, the charge ends when this period ends. If the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge end date will change accordingly up to the original period end. </value>
    [DataMember(Name="upToPeriods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upToPeriods")]
    public long? UpToPeriods { get; set; }

    /// <summary>
    /// The period type used to define when the charge ends.  Values: - Billing_Periods - Days - Weeks - Months - Years    
    /// </summary>
    /// <value>The period type used to define when the charge ends.  Values: - Billing_Periods - Days - Weeks - Months - Years    </value>
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
    /// Determines whether to define a new accounting code for the new discount charge. Values: `true`, `false` 
    /// </summary>
    /// <value>Determines whether to define a new accounting code for the new discount charge. Values: `true`, `false` </value>
    [DataMember(Name="useDiscountSpecificAccountingCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "useDiscountSpecificAccountingCode")]
    public bool? UseDiscountSpecificAccountingCode { get; set; }

    /// <summary>
    /// Shows the tenant-level percentage uplift value for an automatic price change to a termed subscription's renewal. You set the tenant uplift value in the web-based UI: **Z-Billing > Define Default Subscription Settings**.  Values: `true`, `false` 
    /// </summary>
    /// <value>Shows the tenant-level percentage uplift value for an automatic price change to a termed subscription's renewal. You set the tenant uplift value in the web-based UI: **Z-Billing > Define Default Subscription Settings**.  Values: `true`, `false` </value>
    [DataMember(Name="useTenantDefaultForPriceChange", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "useTenantDefaultForPriceChange")]
    public bool? UseTenantDefaultForPriceChange { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETProductRatePlanChargeType {\n");
      sb.Append("  ApplyDiscountTo: ").Append(ApplyDiscountTo).Append("\n");
      sb.Append("  BillingDay: ").Append(BillingDay).Append("\n");
      sb.Append("  BillingPeriod: ").Append(BillingPeriod).Append("\n");
      sb.Append("  BillingPeriodAlignment: ").Append(BillingPeriodAlignment).Append("\n");
      sb.Append("  BillingTiming: ").Append(BillingTiming).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  DefaultQuantity: ").Append(DefaultQuantity).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DiscountLevel: ").Append(DiscountLevel).Append("\n");
      sb.Append("  EndDateCondition: ").Append(EndDateCondition).Append("\n");
      sb.Append("  FinanceInformation: ").Append(FinanceInformation).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IncludedUnits: ").Append(IncludedUnits).Append("\n");
      sb.Append("  ListPriceBase: ").Append(ListPriceBase).Append("\n");
      sb.Append("  MaxQuantity: ").Append(MaxQuantity).Append("\n");
      sb.Append("  MinQuantity: ").Append(MinQuantity).Append("\n");
      sb.Append("  Model: ").Append(Model).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NumberOfPeriods: ").Append(NumberOfPeriods).Append("\n");
      sb.Append("  OverageCalculationOption: ").Append(OverageCalculationOption).Append("\n");
      sb.Append("  OverageUnusedUnitsCreditOption: ").Append(OverageUnusedUnitsCreditOption).Append("\n");
      sb.Append("  PrepayPeriods: ").Append(PrepayPeriods).Append("\n");
      sb.Append("  PriceChangeOption: ").Append(PriceChangeOption).Append("\n");
      sb.Append("  PriceIncreasePercentage: ").Append(PriceIncreasePercentage).Append("\n");
      sb.Append("  Pricing: ").Append(Pricing).Append("\n");
      sb.Append("  PricingSummary: ").Append(PricingSummary).Append("\n");
      sb.Append("  RatingGroup: ").Append(RatingGroup).Append("\n");
      sb.Append("  RevenueRecognitionRuleName: ").Append(RevenueRecognitionRuleName).Append("\n");
      sb.Append("  SmoothingModel: ").Append(SmoothingModel).Append("\n");
      sb.Append("  SpecificBillingPeriod: ").Append(SpecificBillingPeriod).Append("\n");
      sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
      sb.Append("  TaxMode: ").Append(TaxMode).Append("\n");
      sb.Append("  Taxable: ").Append(Taxable).Append("\n");
      sb.Append("  TriggerEvent: ").Append(TriggerEvent).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Uom: ").Append(Uom).Append("\n");
      sb.Append("  UpToPeriods: ").Append(UpToPeriods).Append("\n");
      sb.Append("  UpToPeriodsType: ").Append(UpToPeriodsType).Append("\n");
      sb.Append("  UsageRecordRatingOption: ").Append(UsageRecordRatingOption).Append("\n");
      sb.Append("  UseDiscountSpecificAccountingCode: ").Append(UseDiscountSpecificAccountingCode).Append("\n");
      sb.Append("  UseTenantDefaultForPriceChange: ").Append(UseTenantDefaultForPriceChange).Append("\n");
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
