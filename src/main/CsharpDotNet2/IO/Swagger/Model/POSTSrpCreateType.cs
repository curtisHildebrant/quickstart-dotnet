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
  public class POSTSrpCreateType {
    /// <summary>
    /// This optional container is used to override the quantity of one or more product rate plan charges for this subscription. 
    /// </summary>
    /// <value>This optional container is used to override the quantity of one or more product rate plan charges for this subscription. </value>
    [DataMember(Name="chargeOverrides", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeOverrides")]
    public List<POSTScCreateType> ChargeOverrides { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// ID of a product rate plan for this subscription. 
    /// </summary>
    /// <value>ID of a product rate plan for this subscription. </value>
    [DataMember(Name="productRatePlanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productRatePlanId")]
    public string ProductRatePlanId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTSrpCreateType {\n");
      sb.Append("  ChargeOverrides: ").Append(ChargeOverrides).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  ProductRatePlanId: ").Append(ProductRatePlanId).Append("\n");
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
