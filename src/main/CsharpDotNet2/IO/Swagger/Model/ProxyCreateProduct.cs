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
  public class ProxyCreateProduct {
    /// <summary>
    ///  Controls whether to allow your users to add or remove features while creating or amending a subscription. **Character** **limit**: n/a **notes**: WSDL 58.0+ **Values**: true, false (default) 
    /// </summary>
    /// <value> Controls whether to allow your users to add or remove features while creating or amending a subscription. **Character** **limit**: n/a **notes**: WSDL 58.0+ **Values**: true, false (default) </value>
    [DataMember(Name="AllowFeatureChanges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowFeatureChanges")]
    public bool? AllowFeatureChanges { get; set; }

    /// <summary>
    ///  Category of the product. Used by Zuora Quotes Guided Product Selector. **Character** **limit**: 100 **notes**: WSDL16.0+ **Values**: One of the following:  - Base Products - Add On Services - Miscellaneous Products 
    /// </summary>
    /// <value> Category of the product. Used by Zuora Quotes Guided Product Selector. **Character** **limit**: 100 **notes**: WSDL16.0+ **Values**: One of the following:  - Base Products - Add On Services - Miscellaneous Products </value>
    [DataMember(Name="Category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Category")]
    public string Category { get; set; }

    /// <summary>
    ///  A descriptionof the product. **Character limit**: 500 **Values**: a string of 500 characters or fewer 
    /// </summary>
    /// <value> A descriptionof the product. **Character limit**: 500 **Values**: a string of 500 characters or fewer </value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// The date when the product expires and can't be subscribed to anymore. **Character limit**: 29 **Values**: a valid date and time value 
    /// </summary>
    /// <value>The date when the product expires and can't be subscribed to anymore. **Character limit**: 29 **Values**: a valid date and time value </value>
    [DataMember(Name="EffectiveEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveEndDate")]
    public DateTime? EffectiveEndDate { get; set; }

    /// <summary>
    /// The date when the product becomes available and can be subscribed to. **Character limit**: 29 **Values**: a valid date and time value 
    /// </summary>
    /// <value>The date when the product becomes available and can be subscribed to. **Character limit**: 29 **Values**: a valid date and time value </value>
    [DataMember(Name="EffectiveStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveStartDate")]
    public DateTime? EffectiveStartDate { get; set; }

    /// <summary>
    /// The name of the product. This information is displayed in the product catalog pages in the web-based UI. **Character limit**: 100 **Values**: a string of 100 characters or fewer 
    /// </summary>
    /// <value>The name of the product. This information is displayed in the product catalog pages in the web-based UI. **Character limit**: 100 **Values**: a string of 100 characters or fewer </value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// The unique SKU for the product. **Character limit**: 50 **Values**: one of the following:  - leave null for automatic generated - an alphanumeric string of 50 characters or fewer 
    /// </summary>
    /// <value>The unique SKU for the product. **Character limit**: 50 **Values**: one of the following:  - leave null for automatic generated - an alphanumeric string of 50 characters or fewer </value>
    [DataMember(Name="SKU", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SKU")]
    public string SKU { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyCreateProduct {\n");
      sb.Append("  AllowFeatureChanges: ").Append(AllowFeatureChanges).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
      sb.Append("  EffectiveStartDate: ").Append(EffectiveStartDate).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SKU: ").Append(SKU).Append("\n");
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
