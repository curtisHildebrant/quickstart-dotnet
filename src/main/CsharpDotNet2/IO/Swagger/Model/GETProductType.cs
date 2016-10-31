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
  public class GETProductType {
    /// <summary>
    /// Category of the product. Used by Zuora Quotes Guided Product Selector.  Possible values are:   - Base Products   - Add On Services   - Miscellaneous Products 
    /// </summary>
    /// <value>Category of the product. Used by Zuora Quotes Guided Product Selector.  Possible values are:   - Base Products   - Add On Services   - Miscellaneous Products </value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Optional product description. 
    /// </summary>
    /// <value>Optional product description. </value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The date when the product expires and cannot be subscribed to anymore, as `yyyy-mm-dd`. 
    /// </summary>
    /// <value>The date when the product expires and cannot be subscribed to anymore, as `yyyy-mm-dd`. </value>
    [DataMember(Name="effectiveEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effectiveEndDate")]
    public DateTime? EffectiveEndDate { get; set; }

    /// <summary>
    /// The date when the product becomes available and can be subscribed to, as `yyyy-mm-dd`. 
    /// </summary>
    /// <value>The date when the product becomes available and can be subscribed to, as `yyyy-mm-dd`. </value>
    [DataMember(Name="effectiveStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effectiveStartDate")]
    public DateTime? EffectiveStartDate { get; set; }

    /// <summary>
    /// Product ID. 
    /// </summary>
    /// <value>Product ID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Product name, up to 100 characters. 
    /// </summary>
    /// <value>Product name, up to 100 characters. </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Container for one or more product features. Only available when the following settings are enabled: - The Entitlements feature in your tenant - The [Enable Feature Specification in Product and Subscriptions](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Enable_Feature_Specification_in_Products_and_Subscriptions.3F) setting in Z-Billing Settings 
    /// </summary>
    /// <value>Container for one or more product features. Only available when the following settings are enabled: - The Entitlements feature in your tenant - The [Enable Feature Specification in Product and Subscriptions](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Enable_Feature_Specification_in_Products_and_Subscriptions.3F) setting in Z-Billing Settings </value>
    [DataMember(Name="productFeatures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productFeatures")]
    public List<GetProductFeatureType> ProductFeatures { get; set; }

    /// <summary>
    /// Container for one or more product rate plans: 
    /// </summary>
    /// <value>Container for one or more product rate plans: </value>
    [DataMember(Name="productRatePlans", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productRatePlans")]
    public List<GETProductRatePlanType> ProductRatePlans { get; set; }

    /// <summary>
    /// Unique product SKU, up to 50 characters. 
    /// </summary>
    /// <value>Unique product SKU, up to 50 characters. </value>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public string Tags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETProductType {\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
      sb.Append("  EffectiveStartDate: ").Append(EffectiveStartDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ProductFeatures: ").Append(ProductFeatures).Append("\n");
      sb.Append("  ProductRatePlans: ").Append(ProductRatePlans).Append("\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
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
