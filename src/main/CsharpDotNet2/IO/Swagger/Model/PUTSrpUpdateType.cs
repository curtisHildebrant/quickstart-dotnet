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
  public class PUTSrpUpdateType {
    /// <summary>
    /// Container for one or more product rate plan charges.  
    /// </summary>
    /// <value>Container for one or more product rate plan charges.  </value>
    [DataMember(Name="chargeUpdateDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeUpdateDetails")]
    public List<PUTScUpdateType> ChargeUpdateDetails { get; set; }

    /// <summary>
    /// The date when the amendment changes take effect. The format of the date is yyyy-mm-dd.  If there is already a future-dated Update Product amendment on the subscription, the `specificUpdateDate` field will be used instead of this field to specify when the Update Product amendment takes effect. 
    /// </summary>
    /// <value>The date when the amendment changes take effect. The format of the date is yyyy-mm-dd.  If there is already a future-dated Update Product amendment on the subscription, the `specificUpdateDate` field will be used instead of this field to specify when the Update Product amendment takes effect. </value>
    [DataMember(Name="contractEffectiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractEffectiveDate")]
    public DateTime? ContractEffectiveDate { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// The date when the customer accepts the contract in yyyy-mm-dd format.  If this field is not set:  * If the `serviceActivationDate` field is not set, the value of this field is set to be the contract effective date. * If the `serviceActivationDate` field is set, the value of this field is set to be the service activation date.  The billing trigger dates must follow this rule:  contractEffectiveDate <= serviceActivationDate <= contractAcceptanceDate 
    /// </summary>
    /// <value>The date when the customer accepts the contract in yyyy-mm-dd format.  If this field is not set:  * If the `serviceActivationDate` field is not set, the value of this field is set to be the contract effective date. * If the `serviceActivationDate` field is set, the value of this field is set to be the service activation date.  The billing trigger dates must follow this rule:  contractEffectiveDate <= serviceActivationDate <= contractAcceptanceDate </value>
    [DataMember(Name="customerAcceptanceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customerAcceptanceDate")]
    public DateTime? CustomerAcceptanceDate { get; set; }

    /// <summary>
    /// ID of a rate plan for this subscription. 
    /// </summary>
    /// <value>ID of a rate plan for this subscription. </value>
    [DataMember(Name="ratePlanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratePlanId")]
    public string RatePlanId { get; set; }

    /// <summary>
    /// The date when the update amendment is activated in yyyy-mm-dd format.  You must specify a Service Activation date if the Customer Acceptance date is set. If the Customer Acceptance date is not set, the value of the `serviceActivationDate` field defaults to be the Contract Effective Date.  The billing trigger dates must follow this rule:  contractEffectiveDate <= serviceActivationDate <= contractAcceptanceDate 
    /// </summary>
    /// <value>The date when the update amendment is activated in yyyy-mm-dd format.  You must specify a Service Activation date if the Customer Acceptance date is set. If the Customer Acceptance date is not set, the value of the `serviceActivationDate` field defaults to be the Contract Effective Date.  The billing trigger dates must follow this rule:  contractEffectiveDate <= serviceActivationDate <= contractAcceptanceDate </value>
    [DataMember(Name="serviceActivationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceActivationDate")]
    public DateTime? ServiceActivationDate { get; set; }

    /// <summary>
    /// The date when the Update Product amendment takes effect. This field is only applicable if there is already a future-dated Update Product amendment on the subscription. The format of the date is yyyy-mm-dd.  Required only for Update Product amendments if there is already a future-dated Update Product amendment on the subscription. 
    /// </summary>
    /// <value>The date when the Update Product amendment takes effect. This field is only applicable if there is already a future-dated Update Product amendment on the subscription. The format of the date is yyyy-mm-dd.  Required only for Update Product amendments if there is already a future-dated Update Product amendment on the subscription. </value>
    [DataMember(Name="specificUpdateDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "specificUpdateDate")]
    public DateTime? SpecificUpdateDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PUTSrpUpdateType {\n");
      sb.Append("  ChargeUpdateDetails: ").Append(ChargeUpdateDetails).Append("\n");
      sb.Append("  ContractEffectiveDate: ").Append(ContractEffectiveDate).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  CustomerAcceptanceDate: ").Append(CustomerAcceptanceDate).Append("\n");
      sb.Append("  RatePlanId: ").Append(RatePlanId).Append("\n");
      sb.Append("  ServiceActivationDate: ").Append(ServiceActivationDate).Append("\n");
      sb.Append("  SpecificUpdateDate: ").Append(SpecificUpdateDate).Append("\n");
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
