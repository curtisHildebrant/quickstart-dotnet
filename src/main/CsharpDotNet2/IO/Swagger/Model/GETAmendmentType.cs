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
  public class GETAmendmentType {
    /// <summary>
    /// Determines whether the subscription is automatically renewed, or whether it expires at the end of the term and needs to be manually renewed.  
    /// </summary>
    /// <value>Determines whether the subscription is automatically renewed, or whether it expires at the end of the term and needs to be manually renewed.  </value>
    [DataMember(Name="autoRenew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoRenew")]
    public bool? AutoRenew { get; set; }

    /// <summary>
    /// The rate plan ID on which changes are made. Only the Update or Remove amendment returns a base rate plan ID. 
    /// </summary>
    /// <value>The rate plan ID on which changes are made. Only the Update or Remove amendment returns a base rate plan ID. </value>
    [DataMember(Name="baseRatePlanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseRatePlanId")]
    public string BaseRatePlanId { get; set; }

    /// <summary>
    /// The ID of the subscription based on which the amendment is created. 
    /// </summary>
    /// <value>The ID of the subscription based on which the amendment is created. </value>
    [DataMember(Name="baseSubscriptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseSubscriptionId")]
    public string BaseSubscriptionId { get; set; }

    /// <summary>
    /// The amendment code. 
    /// </summary>
    /// <value>The amendment code. </value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// The date when the amendment becomes effective for billing purposes, as `yyyy-mm-dd`. 
    /// </summary>
    /// <value>The date when the amendment becomes effective for billing purposes, as `yyyy-mm-dd`. </value>
    [DataMember(Name="contractEffectiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractEffectiveDate")]
    public DateTime? ContractEffectiveDate { get; set; }

    /// <summary>
    /// The length of the period for the current subscription term.  
    /// </summary>
    /// <value>The length of the period for the current subscription term.  </value>
    [DataMember(Name="currentTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentTerm")]
    public long? CurrentTerm { get; set; }

    /// <summary>
    /// The period type for the current subscription term. Possible values are:  - Month - Year - Day - Week 
    /// </summary>
    /// <value>The period type for the current subscription term. Possible values are:  - Month - Year - Day - Week </value>
    [DataMember(Name="currentTermPeriodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentTermPeriodType")]
    public string CurrentTermPeriodType { get; set; }

    /// <summary>
    /// The date when the customer accepts the amendment changes to the subscription, as `yyyy-mm-dd`. 
    /// </summary>
    /// <value>The date when the customer accepts the amendment changes to the subscription, as `yyyy-mm-dd`. </value>
    [DataMember(Name="customerAcceptanceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customerAcceptanceDate")]
    public DateTime? CustomerAcceptanceDate { get; set; }

    /// <summary>
    /// Description of the amendment. 
    /// </summary>
    /// <value>Description of the amendment. </value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The ID of the account that the subscription is being transferred to. 
    /// </summary>
    /// <value>The ID of the account that the subscription is being transferred to. </value>
    [DataMember(Name="destinationAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationAccountId")]
    public string DestinationAccountId { get; set; }

    /// <summary>
    /// The ID of the invoice that the subscription is being transferred to. 
    /// </summary>
    /// <value>The ID of the invoice that the subscription is being transferred to. </value>
    [DataMember(Name="destinationInvoiceOwnerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationInvoiceOwnerId")]
    public string DestinationInvoiceOwnerId { get; set; }

    /// <summary>
    /// The date when the amendment changes take effective.  
    /// </summary>
    /// <value>The date when the amendment changes take effective.  </value>
    [DataMember(Name="effectiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effectiveDate")]
    public DateTime? EffectiveDate { get; set; }

    /// <summary>
    /// The amendment ID. 
    /// </summary>
    /// <value>The amendment ID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The name of the amendment. 
    /// </summary>
    /// <value>The name of the amendment. </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The ID of the rate plan charge on which amendment is made. Only the Add or Update amendment returns a new rate plan ID. 
    /// </summary>
    /// <value>The ID of the rate plan charge on which amendment is made. Only the Add or Update amendment returns a new rate plan ID. </value>
    [DataMember(Name="newRatePlanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "newRatePlanId")]
    public string NewRatePlanId { get; set; }

    /// <summary>
    /// The ID of the subscription that the amendment changes. 
    /// </summary>
    /// <value>The ID of the subscription that the amendment changes. </value>
    [DataMember(Name="newSubscriptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "newSubscriptionId")]
    public string NewSubscriptionId { get; set; }

    /// <summary>
    /// Specifies whether a termed subscription will remain termed or change to evergreen when it is renewed. Possible values are:  - RENEW_WITH_SPECIFIC_TERM - RENEW_TO_EVERGREEN 
    /// </summary>
    /// <value>Specifies whether a termed subscription will remain termed or change to evergreen when it is renewed. Possible values are:  - RENEW_WITH_SPECIFIC_TERM - RENEW_TO_EVERGREEN </value>
    [DataMember(Name="renewalSetting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewalSetting")]
    public string RenewalSetting { get; set; }

    /// <summary>
    /// The term of renewal for the amended subscription. 
    /// </summary>
    /// <value>The term of renewal for the amended subscription. </value>
    [DataMember(Name="renewalTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewalTerm")]
    public long? RenewalTerm { get; set; }

    /// <summary>
    /// The period type for the subscription renewal term. Possible values are:  - Month - Year - Day - Week 
    /// </summary>
    /// <value>The period type for the subscription renewal term. Possible values are:  - Month - Year - Day - Week </value>
    [DataMember(Name="renewalTermPeriodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewalTermPeriodType")]
    public string RenewalTermPeriodType { get; set; }

    /// <summary>
    /// The date when the subscription resumption takes effect, as `yyyy-mm-dd`.  **Note:** This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/). 
    /// </summary>
    /// <value>The date when the subscription resumption takes effect, as `yyyy-mm-dd`.  **Note:** This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/). </value>
    [DataMember(Name="resumeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resumeDate")]
    public DateTime? ResumeDate { get; set; }

    /// <summary>
    /// The date when service is activated, as `yyyy-mm-dd`. 
    /// </summary>
    /// <value>The date when service is activated, as `yyyy-mm-dd`. </value>
    [DataMember(Name="serviceActivationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceActivationDate")]
    public DateTime? ServiceActivationDate { get; set; }

    /// <summary>
    /// The date when the Update Product amendment takes effect.  Only for the Update Product amendments if there is already a future-dated Update Product amendment on the subscription. 
    /// </summary>
    /// <value>The date when the Update Product amendment takes effect.  Only for the Update Product amendments if there is already a future-dated Update Product amendment on the subscription. </value>
    [DataMember(Name="specificUpdateDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "specificUpdateDate")]
    public DateTime? SpecificUpdateDate { get; set; }

    /// <summary>
    /// The status of the amendment. Possible values are:  - Draft  - Pending Activation - Pending Acceptance - Completed 
    /// </summary>
    /// <value>The status of the amendment. Possible values are:  - Draft  - Pending Activation - Pending Acceptance - Completed </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Returns `true` if the request was processed successfully. 
    /// </summary>
    /// <value>Returns `true` if the request was processed successfully. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// The date when the subscription suspension takes effect, as `yyyy-mm-dd`.  **Note:** This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/). 
    /// </summary>
    /// <value>The date when the subscription suspension takes effect, as `yyyy-mm-dd`.  **Note:** This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/). </value>
    [DataMember(Name="suspendDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suspendDate")]
    public DateTime? SuspendDate { get; set; }

    /// <summary>
    /// The date when the new terms and conditions take effect. 
    /// </summary>
    /// <value>The date when the new terms and conditions take effect. </value>
    [DataMember(Name="termStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "termStartDate")]
    public DateTime? TermStartDate { get; set; }

    /// <summary>
    /// Indicates if the subscription is `TERMED` or `EVERGREEN`. 
    /// </summary>
    /// <value>Indicates if the subscription is `TERMED` or `EVERGREEN`. </value>
    [DataMember(Name="termType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "termType")]
    public string TermType { get; set; }

    /// <summary>
    /// Type of the amendment. Possible values are:  - Cancellation - NewProduct - OwnerTransfer - RemoveProduct - Renewal - UpdateProduct - TermsAndConditions 
    /// </summary>
    /// <value>Type of the amendment. Possible values are:  - Cancellation - NewProduct - OwnerTransfer - RemoveProduct - Renewal - UpdateProduct - TermsAndConditions </value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAmendmentType {\n");
      sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
      sb.Append("  BaseRatePlanId: ").Append(BaseRatePlanId).Append("\n");
      sb.Append("  BaseSubscriptionId: ").Append(BaseSubscriptionId).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  ContractEffectiveDate: ").Append(ContractEffectiveDate).Append("\n");
      sb.Append("  CurrentTerm: ").Append(CurrentTerm).Append("\n");
      sb.Append("  CurrentTermPeriodType: ").Append(CurrentTermPeriodType).Append("\n");
      sb.Append("  CustomerAcceptanceDate: ").Append(CustomerAcceptanceDate).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DestinationAccountId: ").Append(DestinationAccountId).Append("\n");
      sb.Append("  DestinationInvoiceOwnerId: ").Append(DestinationInvoiceOwnerId).Append("\n");
      sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NewRatePlanId: ").Append(NewRatePlanId).Append("\n");
      sb.Append("  NewSubscriptionId: ").Append(NewSubscriptionId).Append("\n");
      sb.Append("  RenewalSetting: ").Append(RenewalSetting).Append("\n");
      sb.Append("  RenewalTerm: ").Append(RenewalTerm).Append("\n");
      sb.Append("  RenewalTermPeriodType: ").Append(RenewalTermPeriodType).Append("\n");
      sb.Append("  ResumeDate: ").Append(ResumeDate).Append("\n");
      sb.Append("  ServiceActivationDate: ").Append(ServiceActivationDate).Append("\n");
      sb.Append("  SpecificUpdateDate: ").Append(SpecificUpdateDate).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  SuspendDate: ").Append(SuspendDate).Append("\n");
      sb.Append("  TermStartDate: ").Append(TermStartDate).Append("\n");
      sb.Append("  TermType: ").Append(TermType).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
