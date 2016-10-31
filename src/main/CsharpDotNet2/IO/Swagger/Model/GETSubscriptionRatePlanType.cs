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
  public class GETSubscriptionRatePlanType {
    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Rate plan ID. 
    /// </summary>
    /// <value>Rate plan ID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The last amendment on the rate plan.  Possible Values:  * `Add` * `Update` * `Remove` 
    /// </summary>
    /// <value>The last amendment on the rate plan.  Possible Values:  * `Add` * `Update` * `Remove` </value>
    [DataMember(Name="lastChangeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastChangeType")]
    public string LastChangeType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="productId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productId")]
    public string ProductId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="productName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productName")]
    public string ProductName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="productRatePlanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productRatePlanId")]
    public string ProductRatePlanId { get; set; }

    /// <summary>
    /// The unique SKU for the product. 
    /// </summary>
    /// <value>The unique SKU for the product. </value>
    [DataMember(Name="productSku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productSku")]
    public string ProductSku { get; set; }

    /// <summary>
    /// Container for one or more charges. 
    /// </summary>
    /// <value>Container for one or more charges. </value>
    [DataMember(Name="ratePlanCharges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratePlanCharges")]
    public List<GETSubscriptionRatePlanChargesType> RatePlanCharges { get; set; }

    /// <summary>
    /// Name of the rate plan. 
    /// </summary>
    /// <value>Name of the rate plan. </value>
    [DataMember(Name="ratePlanName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratePlanName")]
    public string RatePlanName { get; set; }

    /// <summary>
    /// Container for one or more features.   Only available when the following settings are enabled:  * The Entitlements feature in your tenant. * The [Enable Feature Specification in Product and Subscriptions](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Enable_Feature_Specification_in_Products_and_Subscriptions.3F) setting in Billing Settings. 
    /// </summary>
    /// <value>Container for one or more features.   Only available when the following settings are enabled:  * The Entitlements feature in your tenant. * The [Enable Feature Specification in Product and Subscriptions](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Enable_Feature_Specification_in_Products_and_Subscriptions.3F) setting in Billing Settings. </value>
    [DataMember(Name="subscriptionProductFeatures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionProductFeatures")]
    public List<GETSubscriptionProductFeatureType> SubscriptionProductFeatures { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETSubscriptionRatePlanType {\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastChangeType: ").Append(LastChangeType).Append("\n");
      sb.Append("  ProductId: ").Append(ProductId).Append("\n");
      sb.Append("  ProductName: ").Append(ProductName).Append("\n");
      sb.Append("  ProductRatePlanId: ").Append(ProductRatePlanId).Append("\n");
      sb.Append("  ProductSku: ").Append(ProductSku).Append("\n");
      sb.Append("  RatePlanCharges: ").Append(RatePlanCharges).Append("\n");
      sb.Append("  RatePlanName: ").Append(RatePlanName).Append("\n");
      sb.Append("  SubscriptionProductFeatures: ").Append(SubscriptionProductFeatures).Append("\n");
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
