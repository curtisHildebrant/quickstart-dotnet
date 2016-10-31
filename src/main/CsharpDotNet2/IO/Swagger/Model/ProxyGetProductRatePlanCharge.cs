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
  public class ProxyGetProductRatePlanCharge {
    /// <summary>
    /// The accounting code for the charge. Accounting codes group transactions that contain similar accounting attributes. **Character limit**: 100 **Values**: an active accounting code in your Zuora Chart of Accounts 
    /// </summary>
    /// <value>The accounting code for the charge. Accounting codes group transactions that contain similar accounting attributes. **Character limit**: 100 **Values**: an active accounting code in your Zuora Chart of Accounts </value>
    [DataMember(Name="AccountingCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountingCode")]
    public string AccountingCode { get; set; }

    /// <summary>
    /// Specifies the type of charges that you want a specific discount to apply to. All field values are case sensitive: note that these values are in all-caps. **Character limit**: 21 **Values**: one of the following:  - `ONETIME (1)` - `RECURRING (2)` - `USAGE (4)` - `ONETIMERECURRING (3)` - `ONETIMEUSAGE (5)` - `RECURRINGUSAGE (6)` - `ONETIMERECURRINGUSAGE (7)` 
    /// </summary>
    /// <value>Specifies the type of charges that you want a specific discount to apply to. All field values are case sensitive: note that these values are in all-caps. **Character limit**: 21 **Values**: one of the following:  - `ONETIME (1)` - `RECURRING (2)` - `USAGE (4)` - `ONETIMERECURRING (3)` - `ONETIMEUSAGE (5)` - `RECURRINGUSAGE (6)` - `ONETIMERECURRINGUSAGE (7)` </value>
    [DataMember(Name="ApplyDiscountTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplyDiscountTo")]
    public string ApplyDiscountTo { get; set; }

    /// <summary>
    ///  Sets the bill cycle day (BCD) for the charge. The BCD determines which day of the month customer is billed. The BCD value in the account can override the BCD in this object. **Character limit**: 2 **Values**: a valid BCD integer, 1 - 31 
    /// </summary>
    /// <value> Sets the bill cycle day (BCD) for the charge. The BCD determines which day of the month customer is billed. The BCD value in the account can override the BCD in this object. **Character limit**: 2 **Values**: a valid BCD integer, 1 - 31 </value>
    [DataMember(Name="BillCycleDay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillCycleDay")]
    public int? BillCycleDay { get; set; }

    /// <summary>
    ///  Specifies how to determine the billing day for the charge. **Character limit**: 20 **Values**: one of the following:  - `DefaultFromCustomer` - `SpecificDayofMonth:` - `SubscriptionStartDay` - `ChargeTriggerDay` - `SpecificDayofWeek` **Note**:  - If you set this field to `SpecificDayofMonth`, you must specify which day of the month as the billing day for the charge in the BillCycleDay field. - If you set this field to `SpecificDayofWeek`, you must specify which day of the week as the billing day for the charge in the WeeklyBillCycleDay field. 
    /// </summary>
    /// <value> Specifies how to determine the billing day for the charge. **Character limit**: 20 **Values**: one of the following:  - `DefaultFromCustomer` - `SpecificDayofMonth:` - `SubscriptionStartDay` - `ChargeTriggerDay` - `SpecificDayofWeek` **Note**:  - If you set this field to `SpecificDayofMonth`, you must specify which day of the month as the billing day for the charge in the BillCycleDay field. - If you set this field to `SpecificDayofWeek`, you must specify which day of the week as the billing day for the charge in the WeeklyBillCycleDay field. </value>
    [DataMember(Name="BillCycleType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillCycleType")]
    public string BillCycleType { get; set; }

    /// <summary>
    ///  The billing period for the charge. The start day of the billing period is also called the bill cycle day (BCD). **Character limit**: 15 **Values**: one of the following  - `Month` - `Quarter` - `Annual` - `Semi-Annual` - `Specific Months` - `Subscription Term` (This value is in **Limited Availability**.) - `Week` - `Specific Weeks` **Note**: Specify the number of months or weeks in the SpecificBillingPeriod field if you set this field to `Specific Months` or `Specific Weeks`. 
    /// </summary>
    /// <value> The billing period for the charge. The start day of the billing period is also called the bill cycle day (BCD). **Character limit**: 15 **Values**: one of the following  - `Month` - `Quarter` - `Annual` - `Semi-Annual` - `Specific Months` - `Subscription Term` (This value is in **Limited Availability**.) - `Week` - `Specific Weeks` **Note**: Specify the number of months or weeks in the SpecificBillingPeriod field if you set this field to `Specific Months` or `Specific Weeks`. </value>
    [DataMember(Name="BillingPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillingPeriod")]
    public string BillingPeriod { get; set; }

    /// <summary>
    ///  Aligns charges within the same subscription if multiple charges begin on different dates. **Character limit**: 24 **Values**: one of the following:  - `AlignToCharge` - `AlignToSubscriptionStart` - `AlignToTermStart` 
    /// </summary>
    /// <value> Aligns charges within the same subscription if multiple charges begin on different dates. **Character limit**: 24 **Values**: one of the following:  - `AlignToCharge` - `AlignToSubscriptionStart` - `AlignToTermStart` </value>
    [DataMember(Name="BillingPeriodAlignment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillingPeriodAlignment")]
    public string BillingPeriodAlignment { get; set; }

    /// <summary>
    ///  The billing timing for the charge. You can choose to bill in advance or in arrears for recurring charge types. This field is not used in one-time or usage based charge types. **Character limit**: **Values**: one of the following:  - `In Advance` - `In Arrears`  This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  
    /// </summary>
    /// <value> The billing timing for the charge. You can choose to bill in advance or in arrears for recurring charge types. This field is not used in one-time or usage based charge types. **Character limit**: **Values**: one of the following:  - `In Advance` - `In Arrears`  This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  </value>
    [DataMember(Name="BillingTiming", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillingTiming")]
    public string BillingTiming { get; set; }

    /// <summary>
    ///  Determines how to calculate charges. Charge models must be individually activated in Z-Billing administration. **Character limit**: 27 **Values**: one of the following:  - `Discount-Fixed Amount` - `Discount-Percentage` - `Flat Fee Pricing` - `Per Unit Pricing` - `Overage Pricing` - `Tiered Pricing` - `Tiered with Overage Pricing` - `Volume Pricing` 
    /// </summary>
    /// <value> Determines how to calculate charges. Charge models must be individually activated in Z-Billing administration. **Character limit**: 27 **Values**: one of the following:  - `Discount-Fixed Amount` - `Discount-Percentage` - `Flat Fee Pricing` - `Per Unit Pricing` - `Overage Pricing` - `Tiered Pricing` - `Tiered with Overage Pricing` - `Volume Pricing` </value>
    [DataMember(Name="ChargeModel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeModel")]
    public string ChargeModel { get; set; }

    /// <summary>
    ///  Specifies the type of charge. **Character limit**: 9 **Values**: one of the following:  - `OneTime` - `Recurring` - `Usage` 
    /// </summary>
    /// <value> Specifies the type of charge. **Character limit**: 9 **Values**: one of the following:  - `OneTime` - `Recurring` - `Usage` </value>
    [DataMember(Name="ChargeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeType")]
    public string ChargeType { get; set; }

    /// <summary>
    /// The ID of the Zuora user who created the `ProductRatePlanCharge` object. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value>The ID of the Zuora user who created the `ProductRatePlanCharge` object. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  The date when the  `ProductRatePlanCharge` object was created. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the  `ProductRatePlanCharge` object was created. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    ///  The default quantity of units, such as the number of authors in a hosted wiki service. This field is required if you use a per-unit pricing model. **Character limit**: 16 **Values**: a valid quantity value 
    /// </summary>
    /// <value> The default quantity of units, such as the number of authors in a hosted wiki service. This field is required if you use a per-unit pricing model. **Character limit**: 16 **Values**: a valid quantity value </value>
    [DataMember(Name="DefaultQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultQuantity")]
    public double? DefaultQuantity { get; set; }

    /// <summary>
    ///  The name of the deferred revenue account for this charge. **Character limit**: 100 **Values**: an active accounting code in your Zuora Chart of Accounts This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  
    /// </summary>
    /// <value> The name of the deferred revenue account for this charge. **Character limit**: 100 **Values**: an active accounting code in your Zuora Chart of Accounts This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  </value>
    [DataMember(Name="DeferredRevenueAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeferredRevenueAccount")]
    public string DeferredRevenueAccount { get; set; }

    /// <summary>
    /// A description of the charge. **Character limit**: 500 **Values**: a string of 500 characters or fewer 
    /// </summary>
    /// <value>A description of the charge. **Character limit**: 500 **Values**: a string of 500 characters or fewer </value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    ///  Specifies if the discount applies to just the product rate plan, the entire subscription, or to any activity in the account. **Character limit**: 12 **Values**: one of the following:  - `rateplan` - `subscription`, `account` 
    /// </summary>
    /// <value> Specifies if the discount applies to just the product rate plan, the entire subscription, or to any activity in the account. **Character limit**: 12 **Values**: one of the following:  - `rateplan` - `subscription`, `account` </value>
    [DataMember(Name="DiscountLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscountLevel")]
    public string DiscountLevel { get; set; }

    /// <summary>
    ///  Defines when the charge ends after the charge trigger date. **Values**: one of the following:  - `SubscriptionEnd`: The charge ends on the subscription end date after a specified period based on the trigger date of the charge. This is the default value. - `FixedPeriod`: The charge ends after a specified period based on the trigger date of the charge. If you set this field to `FixedPeriod`, you must specify the length of the period and a period type by defining the `UpToPeriods` and `UpToPeriodsType` fields. **Note**: If the subscription ends before the charge end date, the charge ends when the subscription ends. But if the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge will end on the charge end date. 
    /// </summary>
    /// <value> Defines when the charge ends after the charge trigger date. **Values**: one of the following:  - `SubscriptionEnd`: The charge ends on the subscription end date after a specified period based on the trigger date of the charge. This is the default value. - `FixedPeriod`: The charge ends after a specified period based on the trigger date of the charge. If you set this field to `FixedPeriod`, you must specify the length of the period and a period type by defining the `UpToPeriods` and `UpToPeriodsType` fields. **Note**: If the subscription ends before the charge end date, the charge ends when the subscription ends. But if the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge will end on the charge end date. </value>
    [DataMember(Name="EndDateCondition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EndDateCondition")]
    public string EndDateCondition { get; set; }

    /// <summary>
    /// Object identifier.
    /// </summary>
    /// <value>Object identifier.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// Specifies the number of units in the base set of units. **Character limit**: 16 **Values**: a positive decimal value 
    /// </summary>
    /// <value>Specifies the number of units in the base set of units. **Character limit**: 16 **Values**: a positive decimal value </value>
    [DataMember(Name="IncludedUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IncludedUnits")]
    public double? IncludedUnits { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="LegacyRevenueReporting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LegacyRevenueReporting")]
    public bool? LegacyRevenueReporting { get; set; }

    /// <summary>
    /// The list price base for the product rate plan charge. **Values**: one of the following:  - `Per Month` - `Per Billing Period` - `Per Week` 
    /// </summary>
    /// <value>The list price base for the product rate plan charge. **Values**: one of the following:  - `Per Month` - `Per Billing Period` - `Per Week` </value>
    [DataMember(Name="ListPriceBase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ListPriceBase")]
    public string ListPriceBase { get; set; }

    /// <summary>
    ///  Specifies the maximum number of units for this charge. Use this field and the `MinQuantity` field to create a range of units allowed in a product rate plan charge. **Character limit**: 16 **Values**: a positive decimal value 
    /// </summary>
    /// <value> Specifies the maximum number of units for this charge. Use this field and the `MinQuantity` field to create a range of units allowed in a product rate plan charge. **Character limit**: 16 **Values**: a positive decimal value </value>
    [DataMember(Name="MaxQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxQuantity")]
    public double? MaxQuantity { get; set; }

    /// <summary>
    /// Specifies the minimum number of units for this charge. Use this field and the `MaxQuantity` field to create a range of units allowed in a product rate plan charge. **Character limit**: 16 **Values**: a positive decimal value 
    /// </summary>
    /// <value>Specifies the minimum number of units for this charge. Use this field and the `MaxQuantity` field to create a range of units allowed in a product rate plan charge. **Character limit**: 16 **Values**: a positive decimal value </value>
    [DataMember(Name="MinQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinQuantity")]
    public double? MinQuantity { get; set; }

    /// <summary>
    /// The name of the product rate plan charge. **Character limit**: 100 **Values**: a string of 100 characters or fewer 
    /// </summary>
    /// <value>The name of the product rate plan charge. **Character limit**: 100 **Values**: a string of 100 characters or fewer </value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Specifies the number of periods to use when calculating charges in an overage smoothing charge model. **Character limit**: **Values**: a positive whole number 
    /// </summary>
    /// <value>Specifies the number of periods to use when calculating charges in an overage smoothing charge model. **Character limit**: **Values**: a positive whole number </value>
    [DataMember(Name="NumberOfPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NumberOfPeriod")]
    public long? NumberOfPeriod { get; set; }

    /// <summary>
    /// Determines when to calculate overage charges. If the value of the SmoothingMode field is not specified, the value of this field is ignored. **Character limit**: 20 **Values**: one of the following:  - `EndOfSmoothingPeriod`: This option is used by default. The overage is charged at the end of the smoothing period. - `PerBillingPeriod`: The overage is charged on-demand rather than waiting until the end of the smoothing period. 
    /// </summary>
    /// <value>Determines when to calculate overage charges. If the value of the SmoothingMode field is not specified, the value of this field is ignored. **Character limit**: 20 **Values**: one of the following:  - `EndOfSmoothingPeriod`: This option is used by default. The overage is charged at the end of the smoothing period. - `PerBillingPeriod`: The overage is charged on-demand rather than waiting until the end of the smoothing period. </value>
    [DataMember(Name="OverageCalculationOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OverageCalculationOption")]
    public string OverageCalculationOption { get; set; }

    /// <summary>
    ///  Determines whether to credit the customer with unused units of usage. **Character limit**: 20 **Values**: one of the following:  - `NoCredit` - `CreditBySpecificRate` 
    /// </summary>
    /// <value> Determines whether to credit the customer with unused units of usage. **Character limit**: 20 **Values**: one of the following:  - `NoCredit` - `CreditBySpecificRate` </value>
    [DataMember(Name="OverageUnusedUnitsCreditOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OverageUnusedUnitsCreditOption")]
    public string OverageUnusedUnitsCreditOption { get; set; }

    /// <summary>
    ///  Applies an automatic price change when a termed subscription is renewed. **Character limit**: **Values**: one of the following:  - `NoChange` (default) - `SpecificPercentageValue` - `UseLatestProductCatalogPricing` 
    /// </summary>
    /// <value> Applies an automatic price change when a termed subscription is renewed. **Character limit**: **Values**: one of the following:  - `NoChange` (default) - `SpecificPercentageValue` - `UseLatestProductCatalogPricing` </value>
    [DataMember(Name="PriceChangeOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceChangeOption")]
    public string PriceChangeOption { get; set; }

    /// <summary>
    ///  Specifies the percentage to increase or decrease the price of a termed subscription's renewal. Use this field if you set the [`PriceChangeOption`](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/ProductRatePlanCharge#PriceIncreaseOption) value to `SpecificPercentageValue`. **Character limit**: 16 **Values**: a decimal value between -100 and 100 
    /// </summary>
    /// <value> Specifies the percentage to increase or decrease the price of a termed subscription's renewal. Use this field if you set the [`PriceChangeOption`](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/ProductRatePlanCharge#PriceIncreaseOption) value to `SpecificPercentageValue`. **Character limit**: 16 **Values**: a decimal value between -100 and 100 </value>
    [DataMember(Name="PriceIncreasePercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceIncreasePercentage")]
    public double? PriceIncreasePercentage { get; set; }

    /// <summary>
    ///  The ID of the product rate plan associated with this product rate plan charge. **Character limit**: 32 **Values**: a valid product rate plan ID 
    /// </summary>
    /// <value> The ID of the product rate plan associated with this product rate plan charge. **Character limit**: 32 **Values**: a valid product rate plan ID </value>
    [DataMember(Name="ProductRatePlanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductRatePlanId")]
    public string ProductRatePlanId { get; set; }

    /// <summary>
    ///  The name of the recognized revenue account for this charge.  - Required when the Allow Blank Accounting Code setting is No. - Optional when the Allow Blank Accounting Code setting is Yes. Navigate to **Z-Finance Settings > Configure Accounting Rules** to check this setting. **Character limit**: 100 **Values**: an active accounting code in your Zuora Chart of Accounts This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  
    /// </summary>
    /// <value> The name of the recognized revenue account for this charge.  - Required when the Allow Blank Accounting Code setting is No. - Optional when the Allow Blank Accounting Code setting is Yes. Navigate to **Z-Finance Settings > Configure Accounting Rules** to check this setting. **Character limit**: 100 **Values**: an active accounting code in your Zuora Chart of Accounts This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  </value>
    [DataMember(Name="RecognizedRevenueAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RecognizedRevenueAccount")]
    public string RecognizedRevenueAccount { get; set; }

    /// <summary>
    /// Associates this product rate plan charge with a specific revenue recognition code. **Character limit**: 70 **Values**: a valid revenue recognition code 
    /// </summary>
    /// <value>Associates this product rate plan charge with a specific revenue recognition code. **Character limit**: 70 **Values**: a valid revenue recognition code </value>
    [DataMember(Name="RevRecCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RevRecCode")]
    public string RevRecCode { get; set; }

    /// <summary>
    ///  Specifies when revenue recognition begins. **Character limit**: 22 **Values**: one of the following:  - `ContractEffectiveDate` - `ServiceActivationDate` - `CustomerAcceptanceDate` 
    /// </summary>
    /// <value> Specifies when revenue recognition begins. **Character limit**: 22 **Values**: one of the following:  - `ContractEffectiveDate` - `ServiceActivationDate` - `CustomerAcceptanceDate` </value>
    [DataMember(Name="RevRecTriggerCondition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RevRecTriggerCondition")]
    public string RevRecTriggerCondition { get; set; }

    /// <summary>
    /// Determines when to recognize the revenue for this charge. **Character limit**: 25 **Values**: one of the following:  - `Recognize upon invoicing` - `Recognize daily over time` 
    /// </summary>
    /// <value>Determines when to recognize the revenue for this charge. **Character limit**: 25 **Values**: one of the following:  - `Recognize upon invoicing` - `Recognize daily over time` </value>
    [DataMember(Name="RevenueRecognitionRuleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RevenueRecognitionRuleName")]
    public string RevenueRecognitionRuleName { get; set; }

    /// <summary>
    ///  Specifies the smoothing model for an overage smoothing charge model. **Character limit**: 22 **Values**: one of the following:  - `RollingWindow` - `Rollover` 
    /// </summary>
    /// <value> Specifies the smoothing model for an overage smoothing charge model. **Character limit**: 22 **Values**: one of the following:  - `RollingWindow` - `Rollover` </value>
    [DataMember(Name="SmoothingModel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SmoothingModel")]
    public string SmoothingModel { get; set; }

    /// <summary>
    ///  Customizes the number of months or weeks for the charges billing period. This field is required if you set the value of the BillingPeriod field to `Specific Months` or `Specific Weeks`. **Values**: a positive integer 
    /// </summary>
    /// <value> Customizes the number of months or weeks for the charges billing period. This field is required if you set the value of the BillingPeriod field to `Specific Months` or `Specific Weeks`. **Values**: a positive integer </value>
    [DataMember(Name="SpecificBillingPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpecificBillingPeriod")]
    public long? SpecificBillingPeriod { get; set; }

    /// <summary>
    ///  Specifies the tax code for taxation rules. Required when the Taxable field is set to `True`. **Character limit**: 64 **Values**: a valid tax code 
    /// </summary>
    /// <value> Specifies the tax code for taxation rules. Required when the Taxable field is set to `True`. **Character limit**: 64 **Values**: a valid tax code </value>
    [DataMember(Name="TaxCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxCode")]
    public string TaxCode { get; set; }

    /// <summary>
    ///  Determines how to define taxation for the charge. Required when the Taxable field is set to `True`. **Character limit**: 12 **Values**: one of the following:  - `TaxExclusive` - `TaxInclusive` 
    /// </summary>
    /// <value> Determines how to define taxation for the charge. Required when the Taxable field is set to `True`. **Character limit**: 12 **Values**: one of the following:  - `TaxExclusive` - `TaxInclusive` </value>
    [DataMember(Name="TaxMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxMode")]
    public string TaxMode { get; set; }

    /// <summary>
    ///  Determines whether the charge is taxable. When set to `True`, the TaxMode and TaxCode fields are required when creating or updating th ProductRatePlanCharge object. **Character limit**: 5 **Values**: `True`, `False` 
    /// </summary>
    /// <value> Determines whether the charge is taxable. When set to `True`, the TaxMode and TaxCode fields are required when creating or updating th ProductRatePlanCharge object. **Character limit**: 5 **Values**: `True`, `False` </value>
    [DataMember(Name="Taxable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Taxable")]
    public bool? Taxable { get; set; }

    /// <summary>
    ///  Specifies when to start billing the customer for the charge. **Character limit**: 18 **Values**: one of the following:  - `ContractEffective` is the date when the subscription's contract goes into effect and the charge is ready to be billed. - `ServiceActivation` is the date when the services or products for a subscription have been activated and the customers have access. - `CustomerAcceptance` is when the customer accepts the services or products for a subscription. 
    /// </summary>
    /// <value> Specifies when to start billing the customer for the charge. **Character limit**: 18 **Values**: one of the following:  - `ContractEffective` is the date when the subscription's contract goes into effect and the charge is ready to be billed. - `ServiceActivation` is the date when the services or products for a subscription have been activated and the customers have access. - `CustomerAcceptance` is when the customer accepts the services or products for a subscription. </value>
    [DataMember(Name="TriggerEvent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TriggerEvent")]
    public string TriggerEvent { get; set; }

    /// <summary>
    ///  Specifies the units to measure usage. Units of measure are configured in the web-based UI: **Z-Billing > Settings**. **Character limit**: 25 **Values**: a configured unit of measure **Note**: You must specify this field when creating the following charge models:  - Per Unit Pricing - Volume Pricing - Overage Pricing - Tiered Pricing - Tiered with Overage Pricing 
    /// </summary>
    /// <value> Specifies the units to measure usage. Units of measure are configured in the web-based UI: **Z-Billing > Settings**. **Character limit**: 25 **Values**: a configured unit of measure **Note**: You must specify this field when creating the following charge models:  - Per Unit Pricing - Volume Pricing - Overage Pricing - Tiered Pricing - Tiered with Overage Pricing </value>
    [DataMember(Name="UOM", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UOM")]
    public string UOM { get; set; }

    /// <summary>
    ///  Specifies the length of the period during which the charge is active. If this period ends before the subscription ends, the charge ends when this period ends. **Character limit**: 5 **Values**: a whole number between 0 and 65535, exclusive **Note**:  - You must use this field together with the `UpToPeriodsType` field to specify the time period. This field is applicable only when the `EndDateCondition` field is set to `FixedPeriod`. - If the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge end date will change accordingly up to the original period end. 
    /// </summary>
    /// <value> Specifies the length of the period during which the charge is active. If this period ends before the subscription ends, the charge ends when this period ends. **Character limit**: 5 **Values**: a whole number between 0 and 65535, exclusive **Note**:  - You must use this field together with the `UpToPeriodsType` field to specify the time period. This field is applicable only when the `EndDateCondition` field is set to `FixedPeriod`. - If the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge end date will change accordingly up to the original period end. </value>
    [DataMember(Name="UpToPeriods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpToPeriods")]
    public long? UpToPeriods { get; set; }

    /// <summary>
    ///  The period type used to define when the charge ends. **Character limit**: -- **Values**: one of the following:  - `Billing Periods` (default) - `Days` - `Weeks` - `Months` - Years **Note**:  - You must use this field together with the `UpToPeriods` field to specify the time period. - This field is applicable only when the `EndDateCondition` field is set to `FixedPeriod`. 
    /// </summary>
    /// <value> The period type used to define when the charge ends. **Character limit**: -- **Values**: one of the following:  - `Billing Periods` (default) - `Days` - `Weeks` - `Months` - Years **Note**:  - You must use this field together with the `UpToPeriods` field to specify the time period. - This field is applicable only when the `EndDateCondition` field is set to `FixedPeriod`. </value>
    [DataMember(Name="UpToPeriodsType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpToPeriodsType")]
    public string UpToPeriodsType { get; set; }

    /// <summary>
    /// The ID of the last user to update the object. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value>The ID of the last user to update the object. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    /// The date when the object was last updated. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value>The date when the object was last updated. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }

    /// <summary>
    /// Determines whether to define a new accounting code for the new discount charge. **Character limit**: 5 **Values**: `True`, `False` 
    /// </summary>
    /// <value>Determines whether to define a new accounting code for the new discount charge. **Character limit**: 5 **Values**: `True`, `False` </value>
    [DataMember(Name="UseDiscountSpecificAccountingCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseDiscountSpecificAccountingCode")]
    public bool? UseDiscountSpecificAccountingCode { get; set; }

    /// <summary>
    ///  Applies the tenant-level percentage uplift value for an automatic price change to a termed subscription's renewal. You set the tenant uplift value in the web-based UI: **Z-Billing > Define Default Subscription Settings** **Character limit**: 5 **Values**: `true`, `false` 
    /// </summary>
    /// <value> Applies the tenant-level percentage uplift value for an automatic price change to a termed subscription's renewal. You set the tenant uplift value in the web-based UI: **Z-Billing > Define Default Subscription Settings** **Character limit**: 5 **Values**: `true`, `false` </value>
    [DataMember(Name="UseTenantDefaultForPriceChange", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseTenantDefaultForPriceChange")]
    public bool? UseTenantDefaultForPriceChange { get; set; }

    /// <summary>
    ///  Specifies which day of the week as the bill cycle day (BCD) for the charge. This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  **Values**: one of the following:  - `Sunday` - `Monday` - `Tuesday` - `Wednesday` - `Thursday` - `Friday` - `Saturday` 
    /// </summary>
    /// <value> Specifies which day of the week as the bill cycle day (BCD) for the charge. This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  **Values**: one of the following:  - `Sunday` - `Monday` - `Tuesday` - `Wednesday` - `Thursday` - `Friday` - `Saturday` </value>
    [DataMember(Name="WeeklyBillCycleDay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WeeklyBillCycleDay")]
    public string WeeklyBillCycleDay { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetProductRatePlanCharge {\n");
      sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
      sb.Append("  ApplyDiscountTo: ").Append(ApplyDiscountTo).Append("\n");
      sb.Append("  BillCycleDay: ").Append(BillCycleDay).Append("\n");
      sb.Append("  BillCycleType: ").Append(BillCycleType).Append("\n");
      sb.Append("  BillingPeriod: ").Append(BillingPeriod).Append("\n");
      sb.Append("  BillingPeriodAlignment: ").Append(BillingPeriodAlignment).Append("\n");
      sb.Append("  BillingTiming: ").Append(BillingTiming).Append("\n");
      sb.Append("  ChargeModel: ").Append(ChargeModel).Append("\n");
      sb.Append("  ChargeType: ").Append(ChargeType).Append("\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  DefaultQuantity: ").Append(DefaultQuantity).Append("\n");
      sb.Append("  DeferredRevenueAccount: ").Append(DeferredRevenueAccount).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DiscountLevel: ").Append(DiscountLevel).Append("\n");
      sb.Append("  EndDateCondition: ").Append(EndDateCondition).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IncludedUnits: ").Append(IncludedUnits).Append("\n");
      sb.Append("  LegacyRevenueReporting: ").Append(LegacyRevenueReporting).Append("\n");
      sb.Append("  ListPriceBase: ").Append(ListPriceBase).Append("\n");
      sb.Append("  MaxQuantity: ").Append(MaxQuantity).Append("\n");
      sb.Append("  MinQuantity: ").Append(MinQuantity).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NumberOfPeriod: ").Append(NumberOfPeriod).Append("\n");
      sb.Append("  OverageCalculationOption: ").Append(OverageCalculationOption).Append("\n");
      sb.Append("  OverageUnusedUnitsCreditOption: ").Append(OverageUnusedUnitsCreditOption).Append("\n");
      sb.Append("  PriceChangeOption: ").Append(PriceChangeOption).Append("\n");
      sb.Append("  PriceIncreasePercentage: ").Append(PriceIncreasePercentage).Append("\n");
      sb.Append("  ProductRatePlanId: ").Append(ProductRatePlanId).Append("\n");
      sb.Append("  RecognizedRevenueAccount: ").Append(RecognizedRevenueAccount).Append("\n");
      sb.Append("  RevRecCode: ").Append(RevRecCode).Append("\n");
      sb.Append("  RevRecTriggerCondition: ").Append(RevRecTriggerCondition).Append("\n");
      sb.Append("  RevenueRecognitionRuleName: ").Append(RevenueRecognitionRuleName).Append("\n");
      sb.Append("  SmoothingModel: ").Append(SmoothingModel).Append("\n");
      sb.Append("  SpecificBillingPeriod: ").Append(SpecificBillingPeriod).Append("\n");
      sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
      sb.Append("  TaxMode: ").Append(TaxMode).Append("\n");
      sb.Append("  Taxable: ").Append(Taxable).Append("\n");
      sb.Append("  TriggerEvent: ").Append(TriggerEvent).Append("\n");
      sb.Append("  UOM: ").Append(UOM).Append("\n");
      sb.Append("  UpToPeriods: ").Append(UpToPeriods).Append("\n");
      sb.Append("  UpToPeriodsType: ").Append(UpToPeriodsType).Append("\n");
      sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
      sb.Append("  UseDiscountSpecificAccountingCode: ").Append(UseDiscountSpecificAccountingCode).Append("\n");
      sb.Append("  UseTenantDefaultForPriceChange: ").Append(UseTenantDefaultForPriceChange).Append("\n");
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
