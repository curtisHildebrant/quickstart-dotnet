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
  public class GETAccountSummarySubscriptionRatePlanType {
    /// <summary>
    /// Product ID. 
    /// </summary>
    /// <value>Product ID. </value>
    [DataMember(Name="productId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productId")]
    public string ProductId { get; set; }

    /// <summary>
    /// Product name. 
    /// </summary>
    /// <value>Product name. </value>
    [DataMember(Name="productName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productName")]
    public string ProductName { get; set; }

    /// <summary>
    /// Product Rate Plan ID. 
    /// </summary>
    /// <value>Product Rate Plan ID. </value>
    [DataMember(Name="productRatePlanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productRatePlanId")]
    public string ProductRatePlanId { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="productSku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productSku")]
    public string ProductSku { get; set; }

    /// <summary>
    /// Rate plan name. 
    /// </summary>
    /// <value>Rate plan name. </value>
    [DataMember(Name="ratePlanName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratePlanName")]
    public string RatePlanName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountSummarySubscriptionRatePlanType {\n");
      sb.Append("  ProductId: ").Append(ProductId).Append("\n");
      sb.Append("  ProductName: ").Append(ProductName).Append("\n");
      sb.Append("  ProductRatePlanId: ").Append(ProductRatePlanId).Append("\n");
      sb.Append("  ProductSku: ").Append(ProductSku).Append("\n");
      sb.Append("  RatePlanName: ").Append(RatePlanName).Append("\n");
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
