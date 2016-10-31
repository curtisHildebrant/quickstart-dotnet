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
  public class PUTScUpdateType {
    /// <summary>
    /// Aligns charges within the same subscription if multiple charges begin on different dates.  Values:  * `AlignToCharge` * `AlignToSubscriptionStart` * `AlignToTermStart`  Available for the following charge types:  * Recurring * Usage-based 
    /// </summary>
    /// <value>Aligns charges within the same subscription if multiple charges begin on different dates.  Values:  * `AlignToCharge` * `AlignToSubscriptionStart` * `AlignToTermStart`  Available for the following charge types:  * Recurring * Usage-based </value>
    [DataMember(Name="billingPeriodAlignment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingPeriodAlignment")]
    public string BillingPeriodAlignment { get; set; }

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
    /// Specifies the number of units in the base set of units for this charge. Must be >=0.  Available for the following charge types for the Overage charge model:  * `Recurring` * `Usage-based` 
    /// </summary>
    /// <value>Specifies the number of units in the base set of units for this charge. Must be >=0.  Available for the following charge types for the Overage charge model:  * `Recurring` * `Usage-based` </value>
    [DataMember(Name="includedUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includedUnits")]
    public string IncludedUnits { get; set; }

    /// <summary>
    /// Price for units over the allowed amount.   Available for the following charge type for the Overage and Tiered with Overage charge models:  * Usage-based 
    /// </summary>
    /// <value>Price for units over the allowed amount.   Available for the following charge type for the Overage and Tiered with Overage charge models:  * Usage-based </value>
    [DataMember(Name="overagePrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overagePrice")]
    public string OveragePrice { get; set; }

    /// <summary>
    /// Price for units in the subscription rate plan.  Supports all charge types for the Flat Fee and Per Unit charge models 
    /// </summary>
    /// <value>Price for units in the subscription rate plan.  Supports all charge types for the Flat Fee and Per Unit charge models </value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// Applies an automatic price change when a termed subscription is renewed. The Billing Admin setting **Enable Automatic Price Change When Subscriptions are Renewed?** must be set to Yes to use this field.  See [Define Default Subscription Settings](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings) for more information on setting this option.  Values:  * `NoChange` (default) * `SpecificPercentageValue` * `UseLatestProductCatalogPricing`  Available for the following charge types:  * Recurring * Usage-based  Not available for the Fixed-Amount Discount charge model. 
    /// </summary>
    /// <value>Applies an automatic price change when a termed subscription is renewed. The Billing Admin setting **Enable Automatic Price Change When Subscriptions are Renewed?** must be set to Yes to use this field.  See [Define Default Subscription Settings](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings) for more information on setting this option.  Values:  * `NoChange` (default) * `SpecificPercentageValue` * `UseLatestProductCatalogPricing`  Available for the following charge types:  * Recurring * Usage-based  Not available for the Fixed-Amount Discount charge model. </value>
    [DataMember(Name="priceChangeOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceChangeOption")]
    public string PriceChangeOption { get; set; }

    /// <summary>
    /// Specifies the percentage to increase or decrease the price of a termed subscription's renewal. Required if you set the `PriceChangeOption` field to `SpecificPercentageValue`.  Decimal between `-100` and `100`.  Available for the following charge types:  * Recurring * Usage-based  Not available for the Fixed-Amount Discount charge model. 
    /// </summary>
    /// <value>Specifies the percentage to increase or decrease the price of a termed subscription's renewal. Required if you set the `PriceChangeOption` field to `SpecificPercentageValue`.  Decimal between `-100` and `100`.  Available for the following charge types:  * Recurring * Usage-based  Not available for the Fixed-Amount Discount charge model. </value>
    [DataMember(Name="priceIncreasePercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceIncreasePercentage")]
    public string PriceIncreasePercentage { get; set; }

    /// <summary>
    /// Quantity of units; must be greater than zero. 
    /// </summary>
    /// <value>Quantity of units; must be greater than zero. </value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public string Quantity { get; set; }

    /// <summary>
    /// ID of a rate-plan charge for this subscription. 
    /// </summary>
    /// <value>ID of a rate-plan charge for this subscription. </value>
    [DataMember(Name="ratePlanChargeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratePlanChargeId")]
    public string RatePlanChargeId { get; set; }

    /// <summary>
    /// Container for Volume, Tiered or Tiered with Overage charge models. Supports the following charge types:  * One-time * Recurring * Usage-based 
    /// </summary>
    /// <value>Container for Volume, Tiered or Tiered with Overage charge models. Supports the following charge types:  * One-time * Recurring * Usage-based </value>
    [DataMember(Name="tiers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tiers")]
    public List<POSTTierType> Tiers { get; set; }

    /// <summary>
    /// Specifies when to start billing the customer for the charge. Required if the `triggerEvent` field is set to USD.  `triggerDate` cannot be updated for the following using the REST update subscription call:  * One-time charge type * Discount-Fixed Amount charge model * Discount-Percentage charge model 
    /// </summary>
    /// <value>Specifies when to start billing the customer for the charge. Required if the `triggerEvent` field is set to USD.  `triggerDate` cannot be updated for the following using the REST update subscription call:  * One-time charge type * Discount-Fixed Amount charge model * Discount-Percentage charge model </value>
    [DataMember(Name="triggerDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerDate")]
    public DateTime? TriggerDate { get; set; }

    /// <summary>
    /// Specifies when to start billing the customer for the charge.  Values:  * `UCE` * `USA` * `UCA` * `USD`  This is the date when charge changes in the REST request become effective.  `triggerEvent` cannot be updated for the following using the REST update subscription call:  * One-time charge type * Discount-Fixed Amount charge model * Discount-Percentage charge model 
    /// </summary>
    /// <value>Specifies when to start billing the customer for the charge.  Values:  * `UCE` * `USA` * `UCA` * `USD`  This is the date when charge changes in the REST request become effective.  `triggerEvent` cannot be updated for the following using the REST update subscription call:  * One-time charge type * Discount-Fixed Amount charge model * Discount-Percentage charge model </value>
    [DataMember(Name="triggerEvent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerEvent")]
    public string TriggerEvent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PUTScUpdateType {\n");
      sb.Append("  BillingPeriodAlignment: ").Append(BillingPeriodAlignment).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  IncludedUnits: ").Append(IncludedUnits).Append("\n");
      sb.Append("  OveragePrice: ").Append(OveragePrice).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  PriceChangeOption: ").Append(PriceChangeOption).Append("\n");
      sb.Append("  PriceIncreasePercentage: ").Append(PriceIncreasePercentage).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  RatePlanChargeId: ").Append(RatePlanChargeId).Append("\n");
      sb.Append("  Tiers: ").Append(Tiers).Append("\n");
      sb.Append("  TriggerDate: ").Append(TriggerDate).Append("\n");
      sb.Append("  TriggerEvent: ").Append(TriggerEvent).Append("\n");
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
