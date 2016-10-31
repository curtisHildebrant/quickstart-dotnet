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
  public class ProxyGetProductRatePlan {
    /// <summary>
    /// The ID of the Zuora user who created the `ProductRatePlan` object. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value>The ID of the Zuora user who created the `ProductRatePlan` object. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  The date when the `ProductRatePlan` object was created. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the `ProductRatePlan` object was created. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// A description of the product rate plan. **Character limit**: 500 **Values**: a string of 500 characters or fewer 
    /// </summary>
    /// <value>A description of the product rate plan. **Character limit**: 500 **Values**: a string of 500 characters or fewer </value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    ///  The date when the product rate plan expires and can't be subscribed to. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_and_dateTime_Format) 
    /// </summary>
    /// <value> The date when the product rate plan expires and can't be subscribed to. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_and_dateTime_Format) </value>
    [DataMember(Name="EffectiveEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveEndDate")]
    public DateTime? EffectiveEndDate { get; set; }

    /// <summary>
    ///  The date when the product rate plan becomes available and can be subscribed to. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_and_dateTime_Format) 
    /// </summary>
    /// <value> The date when the product rate plan becomes available and can be subscribed to. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_and_dateTime_Format) </value>
    [DataMember(Name="EffectiveStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveStartDate")]
    public DateTime? EffectiveStartDate { get; set; }

    /// <summary>
    /// Object identifier.
    /// </summary>
    /// <value>Object identifier.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// The name of the product rate plan. The name doesn't have to be unique in a Product Catalog, but the name has to be unique within a product. **Character limit**: 100 **Values**: a string of 100 characters or fewer 
    /// </summary>
    /// <value>The name of the product rate plan. The name doesn't have to be unique in a Product Catalog, but the name has to be unique within a product. **Character limit**: 100 **Values**: a string of 100 characters or fewer </value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// The [ID of the product](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Product) that contains the product rate plan. **Character limit**: 32 **Values**: a string of 32 characters or fewer 
    /// </summary>
    /// <value>The [ID of the product](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Product) that contains the product rate plan. **Character limit**: 32 **Values**: a string of 32 characters or fewer </value>
    [DataMember(Name="ProductId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductId")]
    public string ProductId { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetProductRatePlan {\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
      sb.Append("  EffectiveStartDate: ").Append(EffectiveStartDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ProductId: ").Append(ProductId).Append("\n");
      sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
