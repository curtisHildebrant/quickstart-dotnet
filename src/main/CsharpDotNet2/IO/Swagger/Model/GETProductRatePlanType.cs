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
  public class GETProductRatePlanType {
    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Rate plan description. 
    /// </summary>
    /// <value>Rate plan description. </value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Final date the rate plan is active, as `yyyy-mm-dd`. After this date, the rate plan status is `Expired`. 
    /// </summary>
    /// <value>Final date the rate plan is active, as `yyyy-mm-dd`. After this date, the rate plan status is `Expired`. </value>
    [DataMember(Name="effectiveEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effectiveEndDate")]
    public DateTime? EffectiveEndDate { get; set; }

    /// <summary>
    /// First date the rate plan is active (i.e., available to be subscribed to), as `yyyy-mm-dd`.  Before this date, the status is `NotStarted`. 
    /// </summary>
    /// <value>First date the rate plan is active (i.e., available to be subscribed to), as `yyyy-mm-dd`.  Before this date, the status is `NotStarted`. </value>
    [DataMember(Name="effectiveStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effectiveStartDate")]
    public DateTime? EffectiveStartDate { get; set; }

    /// <summary>
    /// Unique product rate-plan charge ID. 
    /// </summary>
    /// <value>Unique product rate-plan charge ID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Name of the product rate-plan charge. (Not required to be unique.) 
    /// </summary>
    /// <value>Name of the product rate-plan charge. (Not required to be unique.) </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Field attributes describing the product rate plan charges: 
    /// </summary>
    /// <value>Field attributes describing the product rate plan charges: </value>
    [DataMember(Name="productRatePlanCharges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productRatePlanCharges")]
    public List<GETProductRatePlanChargeType> ProductRatePlanCharges { get; set; }

    /// <summary>
    /// Possible vales are: `Active`, `Expired`, `NotStarted`. 
    /// </summary>
    /// <value>Possible vales are: `Active`, `Expired`, `NotStarted`. </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETProductRatePlanType {\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
      sb.Append("  EffectiveStartDate: ").Append(EffectiveStartDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ProductRatePlanCharges: ").Append(ProductRatePlanCharges).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
