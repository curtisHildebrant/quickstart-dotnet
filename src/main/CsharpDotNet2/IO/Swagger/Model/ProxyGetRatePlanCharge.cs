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
  public class ProxyGetRatePlanCharge {
    /// <summary>
    /// The accounting code for the charge. Accounting codes group transactions that contain similar accounting attributes. **Character limit**: 100 **Values**: inherited from `ProductRatePlanCharge.AccountingCode` 
    /// </summary>
    /// <value>The accounting code for the charge. Accounting codes group transactions that contain similar accounting attributes. **Character limit**: 100 **Values**: inherited from `ProductRatePlanCharge.AccountingCode` </value>
    [DataMember(Name="AccountingCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountingCode")]
    public string AccountingCode { get; set; }

    /// <summary>
    ///  Specifies the type of charges a specific discount applies to. **Character limit**: 21 **Values**: inherited from `ProductRatePlanCharge.ApplyDiscountTo` 
    /// </summary>
    /// <value> Specifies the type of charges a specific discount applies to. **Character limit**: 21 **Values**: inherited from `ProductRatePlanCharge.ApplyDiscountTo` </value>
    [DataMember(Name="ApplyDiscountTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplyDiscountTo")]
    public string ApplyDiscountTo { get; set; }

    /// <summary>
    ///  Indicates the charge's billing cycle day (BCD), which is when bill runs generate invoices for charges associated with the product rate plan charge or the account. **Character limit**: 2 **Values**: inherited from `ProductRatePlanCharge.BillCycleDay` 
    /// </summary>
    /// <value> Indicates the charge's billing cycle day (BCD), which is when bill runs generate invoices for charges associated with the product rate plan charge or the account. **Character limit**: 2 **Values**: inherited from `ProductRatePlanCharge.BillCycleDay` </value>
    [DataMember(Name="BillCycleDay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillCycleDay")]
    public int? BillCycleDay { get; set; }

    /// <summary>
    ///  Specifies how to determine the billing day for the charge. **Character limit**: 20 **Values**: inherited from `ProductRatePlanCharge.BillCycleType` **Note:** You can override the value inherited from the Product Rate Plan Charge, but only when creating a new subscription or a New Product amendment. 
    /// </summary>
    /// <value> Specifies how to determine the billing day for the charge. **Character limit**: 20 **Values**: inherited from `ProductRatePlanCharge.BillCycleType` **Note:** You can override the value inherited from the Product Rate Plan Charge, but only when creating a new subscription or a New Product amendment. </value>
    [DataMember(Name="BillCycleType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillCycleType")]
    public string BillCycleType { get; set; }

    /// <summary>
    ///  Allows billing period to be overridden on rate plan charge. ****Values**: **inherited from `ProductRatePlanCharge.BillingPeriod` **Note:** You can override the value inherited from the Product Rate Plan Charge, but only when creating a new subscription or a New Product amendment. 
    /// </summary>
    /// <value> Allows billing period to be overridden on rate plan charge. ****Values**: **inherited from `ProductRatePlanCharge.BillingPeriod` **Note:** You can override the value inherited from the Product Rate Plan Charge, but only when creating a new subscription or a New Product amendment. </value>
    [DataMember(Name="BillingPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillingPeriod")]
    public string BillingPeriod { get; set; }

    /// <summary>
    ///  Aligns charges within the same subscription if multiple charges begin on different dates. **Character limit**: 24 **Values**: inherited from `ProductRatePlanCharge.BillingPeriodAlignment` 
    /// </summary>
    /// <value> Aligns charges within the same subscription if multiple charges begin on different dates. **Character limit**: 24 **Values**: inherited from `ProductRatePlanCharge.BillingPeriodAlignment` </value>
    [DataMember(Name="BillingPeriodAlignment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillingPeriodAlignment")]
    public string BillingPeriodAlignment { get; set; }

    /// <summary>
    ///  The billing timing for the charge. You can choose to bill in advance or in arrears for recurring charge types. This field is not used in one-time or usage based charge types. **Character limit**: **Values**: one of the following:  - I`n Advance` - `In Arrears` **Note:** You can override the value inherited from the Product Rate Plan Charge when a subscription has a recurring charge type. This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  
    /// </summary>
    /// <value> The billing timing for the charge. You can choose to bill in advance or in arrears for recurring charge types. This field is not used in one-time or usage based charge types. **Character limit**: **Values**: one of the following:  - I`n Advance` - `In Arrears` **Note:** You can override the value inherited from the Product Rate Plan Charge when a subscription has a recurring charge type. This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  </value>
    [DataMember(Name="BillingTiming", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillingTiming")]
    public string BillingTiming { get; set; }

    /// <summary>
    ///  Determines how to evaluate charges. Charge models must be individually activated in the web-based UI. **Character limit**: 29 **Values**: inherited from `ProductRatePlanCharge.ChargeModel` 
    /// </summary>
    /// <value> Determines how to evaluate charges. Charge models must be individually activated in the web-based UI. **Character limit**: 29 **Values**: inherited from `ProductRatePlanCharge.ChargeModel` </value>
    [DataMember(Name="ChargeModel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeModel")]
    public string ChargeModel { get; set; }

    /// <summary>
    ///  A unique number that identifies the charge. This number is returned as a string. **Character limit**: 50 **Values**: one of the following:  - automatically generated if left null - a unique number of 50 characters or fewer 
    /// </summary>
    /// <value> A unique number that identifies the charge. This number is returned as a string. **Character limit**: 50 **Values**: one of the following:  - automatically generated if left null - a unique number of 50 characters or fewer </value>
    [DataMember(Name="ChargeNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeNumber")]
    public string ChargeNumber { get; set; }

    /// <summary>
    ///  Specifies the type of charge. **Character limit**: 9 **Values**: inherited from `ProductRatePlanCharge.ChargeType` 
    /// </summary>
    /// <value> Specifies the type of charge. **Character limit**: 9 **Values**: inherited from `ProductRatePlanCharge.ChargeType` </value>
    [DataMember(Name="ChargeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeType")]
    public string ChargeType { get; set; }

    /// <summary>
    ///  The date through which a customer has been billed for the charge. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date through which a customer has been billed for the charge. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="ChargedThroughDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargedThroughDate")]
    public DateTime? ChargedThroughDate { get; set; }

    /// <summary>
    /// The ID of the Zuora user who created the `RatePlanCharge` object. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value>The ID of the Zuora user who created the `RatePlanCharge` object. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  The date when the `RatePlanCharge` object was created. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the `RatePlanCharge` object was created. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// A delta monthly recurring charge is the change in monthly recurring revenue caused by an amendment or a new subscription. **Character limit**: 16 **Values**: automatically generated 
    /// </summary>
    /// <value>A delta monthly recurring charge is the change in monthly recurring revenue caused by an amendment or a new subscription. **Character limit**: 16 **Values**: automatically generated </value>
    [DataMember(Name="DMRC", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DMRC")]
    public double? DMRC { get; set; }

    /// <summary>
    ///  After an Amendment, the change in the total contract value (TCV) amount for this charge, compared with its previous value. **Character limit**: 16 **Values**: automatically generated 
    /// </summary>
    /// <value> After an Amendment, the change in the total contract value (TCV) amount for this charge, compared with its previous value. **Character limit**: 16 **Values**: automatically generated </value>
    [DataMember(Name="DTCV", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DTCV")]
    public double? DTCV { get; set; }

    /// <summary>
    ///  A description of the charge. **Character limit**: 500 **Values**: inherited from `ProductRatePlanCharge.Description` 
    /// </summary>
    /// <value> A description of the charge. **Character limit**: 500 **Values**: inherited from `ProductRatePlanCharge.Description` </value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Specifies if the discount applies to just the product rate plan, the entire subscription, or to any activity in the account. **Character limit**: 12 **Values**: inherited from `ProductRatePlanCharge.DiscountLevel` 
    /// </summary>
    /// <value>Specifies if the discount applies to just the product rate plan, the entire subscription, or to any activity in the account. **Character limit**: 12 **Values**: inherited from `ProductRatePlanCharge.DiscountLevel` </value>
    [DataMember(Name="DiscountLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscountLevel")]
    public string DiscountLevel { get; set; }

    /// <summary>
    ///  The date when the segmented charge ends or ended. **Character limit**: 16 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the segmented charge ends or ended. **Character limit**: 16 **Values**: automatically generated </value>
    [DataMember(Name="EffectiveEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveEndDate")]
    public DateTime? EffectiveEndDate { get; set; }

    /// <summary>
    ///  The date when the segmented charge starts or started. **Character limit**: 16 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the segmented charge starts or started. **Character limit**: 16 **Values**: automatically generated </value>
    [DataMember(Name="EffectiveStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveStartDate")]
    public DateTime? EffectiveStartDate { get; set; }

    /// <summary>
    ///  Defines when the charge ends after the charge trigger date. This field can be updated when **Status** is `Draft`. **Values**: one of the following:  - `SubscriptionEnd`: The charge ends on the subscription end date after the charge trigger date. This is the default value. - `FixedPeriod`: The charge ends after a specified period based on the trigger date of the charge. If you set this field to `FixedPeriod`, you must specify the length of the period and a period type by defining the `UpToPeriods` and `UpToPeriodsType` fields. - `SpecificEndDate`: The specific date on which the charge ends. If you set this field to `SpecificEndDate`, you must specify the specific date by defining the `SpecificEndDate` field.  **Note**: If the subscription ends before the charge end date, the charge ends when the subscription ends. But if the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge will end on the charge end date. 
    /// </summary>
    /// <value> Defines when the charge ends after the charge trigger date. This field can be updated when **Status** is `Draft`. **Values**: one of the following:  - `SubscriptionEnd`: The charge ends on the subscription end date after the charge trigger date. This is the default value. - `FixedPeriod`: The charge ends after a specified period based on the trigger date of the charge. If you set this field to `FixedPeriod`, you must specify the length of the period and a period type by defining the `UpToPeriods` and `UpToPeriodsType` fields. - `SpecificEndDate`: The specific date on which the charge ends. If you set this field to `SpecificEndDate`, you must specify the specific date by defining the `SpecificEndDate` field.  **Note**: If the subscription ends before the charge end date, the charge ends when the subscription ends. But if the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge will end on the charge end date. </value>
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
    /// Indicates if the segment of the rate plan charge is the most recent segment. **Character limit**: 5 **Values**: automatically generated: `true`, `false` 
    /// </summary>
    /// <value>Indicates if the segment of the rate plan charge is the most recent segment. **Character limit**: 5 **Values**: automatically generated: `true`, `false` </value>
    [DataMember(Name="IsLastSegment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsLastSegment")]
    public bool? IsLastSegment { get; set; }

    /// <summary>
    /// The list price base for the product rate plan charge. **Values**: one of the following:  - `Per Month` - `Per Billing Period` - `Per Week` 
    /// </summary>
    /// <value>The list price base for the product rate plan charge. **Values**: one of the following:  - `Per Month` - `Per Billing Period` - `Per Week` </value>
    [DataMember(Name="ListPriceBase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ListPriceBase")]
    public string ListPriceBase { get; set; }

    /// <summary>
    /// Monthly recurring revenue (MRR) is the amount of recurring charges in a given month. The MRR calculation doesn't include one-time charges nor usage charges. **Character limit**: 16 **Values**: automatically generated 
    /// </summary>
    /// <value>Monthly recurring revenue (MRR) is the amount of recurring charges in a given month. The MRR calculation doesn't include one-time charges nor usage charges. **Character limit**: 16 **Values**: automatically generated </value>
    [DataMember(Name="MRR", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MRR")]
    public double? MRR { get; set; }

    /// <summary>
    /// The name of the rate plan charge. **Character limit**: 100 **Values**: automatically generated 
    /// </summary>
    /// <value>The name of the rate plan charge. **Character limit**: 100 **Values**: automatically generated </value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Specifies the number of periods to use when calculating charges in an overage smoothing charge model. **Character limit**: 5 **Values**: inherited from `ProductRatePlanCharge.NumberOfPeriod` 
    /// </summary>
    /// <value>Specifies the number of periods to use when calculating charges in an overage smoothing charge model. **Character limit**: 5 **Values**: inherited from `ProductRatePlanCharge.NumberOfPeriod` </value>
    [DataMember(Name="NumberOfPeriods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NumberOfPeriods")]
    public long? NumberOfPeriods { get; set; }

    /// <summary>
    /// The original ID of the rate plan charge. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value>The original ID of the rate plan charge. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="OriginalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OriginalId")]
    public string OriginalId { get; set; }

    /// <summary>
    /// Determines when to calculate overage charges. If the value of the SmoothingMode field is null (not specified and not inherited from ProductRatePlanCharge.SmoothingMode), the value of this field is ignored. **Character limit**: 20 **Values**: inherited from `ProductRatePlanCharge.OverageCalculationOption` 
    /// </summary>
    /// <value>Determines when to calculate overage charges. If the value of the SmoothingMode field is null (not specified and not inherited from ProductRatePlanCharge.SmoothingMode), the value of this field is ignored. **Character limit**: 20 **Values**: inherited from `ProductRatePlanCharge.OverageCalculationOption` </value>
    [DataMember(Name="OverageCalculationOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OverageCalculationOption")]
    public string OverageCalculationOption { get; set; }

    /// <summary>
    ///  Determines whether to credit the customer with unused units of usage. **Character limit**: 20 **Values**: inherited from `ProductRatePlanCharge.OverageUnusedUnitsCreditOption` 
    /// </summary>
    /// <value> Determines whether to credit the customer with unused units of usage. **Character limit**: 20 **Values**: inherited from `ProductRatePlanCharge.OverageUnusedUnitsCreditOption` </value>
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
    ///  Specifies the percentage to increase or decrease the price of renewed subscriptions. Use this field if the [`ProductRatePlanCharge.PriceChangeOption`](/D_Zuora_APIs/SOAP_API/C_SOAP_API_Reference/F_API_Objects/ProductRatePlanCharge#PriceChangeOption) value is set to SpecificPercentageValue. **Character limit**: 16 **Values**: a decimal value between -100 and 100 
    /// </summary>
    /// <value> Specifies the percentage to increase or decrease the price of renewed subscriptions. Use this field if the [`ProductRatePlanCharge.PriceChangeOption`](/D_Zuora_APIs/SOAP_API/C_SOAP_API_Reference/F_API_Objects/ProductRatePlanCharge#PriceChangeOption) value is set to SpecificPercentageValue. **Character limit**: 16 **Values**: a decimal value between -100 and 100 </value>
    [DataMember(Name="PriceIncreasePercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceIncreasePercentage")]
    public double? PriceIncreasePercentage { get; set; }

    /// <summary>
    ///  The date until when charges have been processed. When billing in arrears, such as usage, this field value is the the same as the `ChargedThroughDate` value. This date is the earliest date when a charge can be amended. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date until when charges have been processed. When billing in arrears, such as usage, this field value is the the same as the `ChargedThroughDate` value. This date is the earliest date when a charge can be amended. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="ProcessedThroughDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProcessedThroughDate")]
    public DateTime? ProcessedThroughDate { get; set; }

    /// <summary>
    ///  The default quantity of units, such as the number of authors in a hosted wiki service. Valid for all charge models except for Flat Fee pricing. **Character limit**: 16 **Values**: a valid quantity value 
    /// </summary>
    /// <value> The default quantity of units, such as the number of authors in a hosted wiki service. Valid for all charge models except for Flat Fee pricing. **Character limit**: 16 **Values**: a valid quantity value </value>
    [DataMember(Name="Quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Quantity")]
    public double? Quantity { get; set; }

    /// <summary>
    ///  The ID of the rate plan associated with the rate plan charge. **Character limit**: 32 **Values**: inherited from `RatePlan.Id` 
    /// </summary>
    /// <value> The ID of the rate plan associated with the rate plan charge. **Character limit**: 32 **Values**: inherited from `RatePlan.Id` </value>
    [DataMember(Name="RatePlanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RatePlanId")]
    public string RatePlanId { get; set; }

    /// <summary>
    ///  Associates this product rate plan charge with a specific revenue recognition code. **Character limit**: 70 **Values**: a valid revenue recognition code 
    /// </summary>
    /// <value> Associates this product rate plan charge with a specific revenue recognition code. **Character limit**: 70 **Values**: a valid revenue recognition code </value>
    [DataMember(Name="RevRecCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RevRecCode")]
    public string RevRecCode { get; set; }

    /// <summary>
    ///  Specifies when revenue recognition begins. **Character limit**: 22 **Values**: one of the following:  -  `ContractEffectiveDate`  -  `ServiceActivationDate`  -  `CustomerAcceptanceDate`  
    /// </summary>
    /// <value> Specifies when revenue recognition begins. **Character limit**: 22 **Values**: one of the following:  -  `ContractEffectiveDate`  -  `ServiceActivationDate`  -  `CustomerAcceptanceDate`  </value>
    [DataMember(Name="RevRecTriggerCondition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RevRecTriggerCondition")]
    public string RevRecTriggerCondition { get; set; }

    /// <summary>
    ///  Specifies the Revenue Recognition Rule that you want the Rate Plan Charge to use. This field can be updated when **Status** is `Draft`. By default, the Revenue Recognition Rule is inherited from the Product Rate Plan Charge. For Amend() calls, you can use this field only for NewProduct amendments. For Update() calls, you can use this field only to update subscriptions in draft status. Note that if you use this field to specify a Revenue Recognition Rule for the Rate Plan Charge, the rule will remain as specified even if you later change the rule used by the corresponding Product Rate Plan Charge. See [Z-Billing User Role](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/d_Billing_Roles) permission enabled to use this field.  **Character limit**: n/a **Values**: name of an active Revenue Recognition Rule 
    /// </summary>
    /// <value> Specifies the Revenue Recognition Rule that you want the Rate Plan Charge to use. This field can be updated when **Status** is `Draft`. By default, the Revenue Recognition Rule is inherited from the Product Rate Plan Charge. For Amend() calls, you can use this field only for NewProduct amendments. For Update() calls, you can use this field only to update subscriptions in draft status. Note that if you use this field to specify a Revenue Recognition Rule for the Rate Plan Charge, the rule will remain as specified even if you later change the rule used by the corresponding Product Rate Plan Charge. See [Z-Billing User Role](https://knowledgecenter.zuora.com/CF_Users_and_Administrators/A_Administrator_Settings/User_Roles/d_Billing_Roles) permission enabled to use this field.  **Character limit**: n/a **Values**: name of an active Revenue Recognition Rule </value>
    [DataMember(Name="RevenueRecognitionRuleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RevenueRecognitionRuleName")]
    public string RevenueRecognitionRuleName { get; set; }

    /// <summary>
    ///  The identifying number of the subscription rate plan segment. Segments are numbered sequentially, starting with 1. **Character limit**: 2 **Values**: automatically generated 
    /// </summary>
    /// <value> The identifying number of the subscription rate plan segment. Segments are numbered sequentially, starting with 1. **Character limit**: 2 **Values**: automatically generated </value>
    [DataMember(Name="Segment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Segment")]
    public int? Segment { get; set; }

    /// <summary>
    ///  Customizes the number of months or weeks for the charges billing period. This field is required if you set the value of the BillingPeriod field to `Specific Months` or `Specific Weeks`. **Character limit**: 5 **Values**: inherited from `ProductRatePlanCharge.BillingPeriod` **Note:** You can override the value inherited from the Product Rate Plan Charge, but only when creating a new subscription or a New Product amendment. 
    /// </summary>
    /// <value> Customizes the number of months or weeks for the charges billing period. This field is required if you set the value of the BillingPeriod field to `Specific Months` or `Specific Weeks`. **Character limit**: 5 **Values**: inherited from `ProductRatePlanCharge.BillingPeriod` **Note:** You can override the value inherited from the Product Rate Plan Charge, but only when creating a new subscription or a New Product amendment. </value>
    [DataMember(Name="SpecificBillingPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpecificBillingPeriod")]
    public long? SpecificBillingPeriod { get; set; }

    /// <summary>
    ///  The specific date on which the charge ends. **Character limit**: 29 **Values**: a valid date and time value **Note**:  - This field is only applicable when the `EndDateCondition` field is set to `SpecificEndDate`. - If the subscription ends before the specific end date, the charge ends when the subscription ends. But if the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge will end on the specific end date. 
    /// </summary>
    /// <value> The specific date on which the charge ends. **Character limit**: 29 **Values**: a valid date and time value **Note**:  - This field is only applicable when the `EndDateCondition` field is set to `SpecificEndDate`. - If the subscription ends before the specific end date, the charge ends when the subscription ends. But if the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge will end on the specific end date. </value>
    [DataMember(Name="SpecificEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpecificEndDate")]
    public DateTime? SpecificEndDate { get; set; }

    /// <summary>
    ///  The total contract value (TCV) is the value of a single rate plan charge in a subscription over the lifetime of the subscription. This value does not represent all charges on the subscription. The TCV includes recurring charges and one-time charges, but it doesn't include usage charge. **Character limit**: 16 **Values**: automatically generated 
    /// </summary>
    /// <value> The total contract value (TCV) is the value of a single rate plan charge in a subscription over the lifetime of the subscription. This value does not represent all charges on the subscription. The TCV includes recurring charges and one-time charges, but it doesn't include usage charge. **Character limit**: 16 **Values**: automatically generated </value>
    [DataMember(Name="TCV", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TCV")]
    public double? TCV { get; set; }

    /// <summary>
    ///  The date when the charge becomes effective, and billing begins. This field is required if the `TriggerEvent` field value is `SpecificDate`. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_Format_and_Datetimes_in_Zuora) 
    /// </summary>
    /// <value> The date when the charge becomes effective, and billing begins. This field is required if the `TriggerEvent` field value is `SpecificDate`. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_Format_and_Datetimes_in_Zuora) </value>
    [DataMember(Name="TriggerDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TriggerDate")]
    public DateTime? TriggerDate { get; set; }

    /// <summary>
    ///  Specifies when to start billing the customer for the charge. **Note: **This field can be passed through the subscribe() and amend() calls and will override the default value set on the Product Rate Plan Charge. **Character limit**: 18 **Values**: inherited from `ProductRatePlanCharge.TriggerEvent` and can be one of the following values:  - `ContractEffective `is the date when the subscription's contract goes into effect and the charge is ready to be billed. - `ServiceActivationDate `is when the services or products for a subscription have been activated and the customers have access. - `CustomerAcceptance `is when the customer accepts the services or products for a subscription. - SpecificDate is valid only on the RatePlanCharge. 
    /// </summary>
    /// <value> Specifies when to start billing the customer for the charge. **Note: **This field can be passed through the subscribe() and amend() calls and will override the default value set on the Product Rate Plan Charge. **Character limit**: 18 **Values**: inherited from `ProductRatePlanCharge.TriggerEvent` and can be one of the following values:  - `ContractEffective `is the date when the subscription's contract goes into effect and the charge is ready to be billed. - `ServiceActivationDate `is when the services or products for a subscription have been activated and the customers have access. - `CustomerAcceptance `is when the customer accepts the services or products for a subscription. - SpecificDate is valid only on the RatePlanCharge. </value>
    [DataMember(Name="TriggerEvent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TriggerEvent")]
    public string TriggerEvent { get; set; }

    /// <summary>
    ///  Specifies the units to measure usage. Units of measure are configured in the web-based UI: **Z-Billing > Settings**. **Character limit**: 25 **Values**: inherited from `ProductRatePlanCharge.UOM` 
    /// </summary>
    /// <value> Specifies the units to measure usage. Units of measure are configured in the web-based UI: **Z-Billing > Settings**. **Character limit**: 25 **Values**: inherited from `ProductRatePlanCharge.UOM` </value>
    [DataMember(Name="UOM", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UOM")]
    public string UOM { get; set; }

    /// <summary>
    ///  Specifies the length of the period during which the charge is active. If this period ends before the subscription ends, the charge ends when this period ends. **Character limit**: 5 **Values**: inherited from `ProductRatePlanCharge.UpToPeriods` **Note**:  - You must use this field together with the `UpToPeriodsType` field to specify the time period. This field is only applicable only when the `EndDateCondition` field is set to `FixedPeriod`. - You can override the value inherited from the Product Rate Plan Charge, but only when creating a new subscription or a New Product amendment. - Use this field to override the value in `ProductRatePlanCharge.UpToPeriod`. - If you override the value in this field, enter a whole number between 0 and 65535, exclusive. - If the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge end date will change accordingly up to the original period end. 
    /// </summary>
    /// <value> Specifies the length of the period during which the charge is active. If this period ends before the subscription ends, the charge ends when this period ends. **Character limit**: 5 **Values**: inherited from `ProductRatePlanCharge.UpToPeriods` **Note**:  - You must use this field together with the `UpToPeriodsType` field to specify the time period. This field is only applicable only when the `EndDateCondition` field is set to `FixedPeriod`. - You can override the value inherited from the Product Rate Plan Charge, but only when creating a new subscription or a New Product amendment. - Use this field to override the value in `ProductRatePlanCharge.UpToPeriod`. - If you override the value in this field, enter a whole number between 0 and 65535, exclusive. - If the subscription end date is subsequently changed through a Renewal, or Terms and Conditions amendment, the charge end date will change accordingly up to the original period end. </value>
    [DataMember(Name="UpToPeriods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpToPeriods")]
    public long? UpToPeriods { get; set; }

    /// <summary>
    ///  The period type used to define when the charge ends. This field can be updated when **Status** is `Draft`. **Values**: one of the following:  - `Billing Periods` (default) - `Days` - `Weeks` - `Months` - `Years` **Note**:  - You must use this field together with the `UpToPeriods` field to specify the time period. - This field is only applicable only when the `EndDateCondition` field is set to `FixedPeriod`. 
    /// </summary>
    /// <value> The period type used to define when the charge ends. This field can be updated when **Status** is `Draft`. **Values**: one of the following:  - `Billing Periods` (default) - `Days` - `Weeks` - `Months` - `Years` **Note**:  - You must use this field together with the `UpToPeriods` field to specify the time period. - This field is only applicable only when the `EndDateCondition` field is set to `FixedPeriod`. </value>
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
    ///  The date when the object was last updated. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the object was last updated. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }

    /// <summary>
    ///  The version of the rate plan charge. Each time a charge is amended, Zuora creates a new version of the rate plan charge. **Character limit**: 5 **Values**: automatically generated 
    /// </summary>
    /// <value> The version of the rate plan charge. Each time a charge is amended, Zuora creates a new version of the rate plan charge. **Character limit**: 5 **Values**: automatically generated </value>
    [DataMember(Name="Version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Version")]
    public long? Version { get; set; }

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
      sb.Append("class ProxyGetRatePlanCharge {\n");
      sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
      sb.Append("  ApplyDiscountTo: ").Append(ApplyDiscountTo).Append("\n");
      sb.Append("  BillCycleDay: ").Append(BillCycleDay).Append("\n");
      sb.Append("  BillCycleType: ").Append(BillCycleType).Append("\n");
      sb.Append("  BillingPeriod: ").Append(BillingPeriod).Append("\n");
      sb.Append("  BillingPeriodAlignment: ").Append(BillingPeriodAlignment).Append("\n");
      sb.Append("  BillingTiming: ").Append(BillingTiming).Append("\n");
      sb.Append("  ChargeModel: ").Append(ChargeModel).Append("\n");
      sb.Append("  ChargeNumber: ").Append(ChargeNumber).Append("\n");
      sb.Append("  ChargeType: ").Append(ChargeType).Append("\n");
      sb.Append("  ChargedThroughDate: ").Append(ChargedThroughDate).Append("\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  DMRC: ").Append(DMRC).Append("\n");
      sb.Append("  DTCV: ").Append(DTCV).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DiscountLevel: ").Append(DiscountLevel).Append("\n");
      sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
      sb.Append("  EffectiveStartDate: ").Append(EffectiveStartDate).Append("\n");
      sb.Append("  EndDateCondition: ").Append(EndDateCondition).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IsLastSegment: ").Append(IsLastSegment).Append("\n");
      sb.Append("  ListPriceBase: ").Append(ListPriceBase).Append("\n");
      sb.Append("  MRR: ").Append(MRR).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NumberOfPeriods: ").Append(NumberOfPeriods).Append("\n");
      sb.Append("  OriginalId: ").Append(OriginalId).Append("\n");
      sb.Append("  OverageCalculationOption: ").Append(OverageCalculationOption).Append("\n");
      sb.Append("  OverageUnusedUnitsCreditOption: ").Append(OverageUnusedUnitsCreditOption).Append("\n");
      sb.Append("  PriceChangeOption: ").Append(PriceChangeOption).Append("\n");
      sb.Append("  PriceIncreasePercentage: ").Append(PriceIncreasePercentage).Append("\n");
      sb.Append("  ProcessedThroughDate: ").Append(ProcessedThroughDate).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  RatePlanId: ").Append(RatePlanId).Append("\n");
      sb.Append("  RevRecCode: ").Append(RevRecCode).Append("\n");
      sb.Append("  RevRecTriggerCondition: ").Append(RevRecTriggerCondition).Append("\n");
      sb.Append("  RevenueRecognitionRuleName: ").Append(RevenueRecognitionRuleName).Append("\n");
      sb.Append("  Segment: ").Append(Segment).Append("\n");
      sb.Append("  SpecificBillingPeriod: ").Append(SpecificBillingPeriod).Append("\n");
      sb.Append("  SpecificEndDate: ").Append(SpecificEndDate).Append("\n");
      sb.Append("  TCV: ").Append(TCV).Append("\n");
      sb.Append("  TriggerDate: ").Append(TriggerDate).Append("\n");
      sb.Append("  TriggerEvent: ").Append(TriggerEvent).Append("\n");
      sb.Append("  UOM: ").Append(UOM).Append("\n");
      sb.Append("  UpToPeriods: ").Append(UpToPeriods).Append("\n");
      sb.Append("  UpToPeriodsType: ").Append(UpToPeriodsType).Append("\n");
      sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
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
