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
  public class ProxyCreateAmendment {
    /// <summary>
    ///  Determines whether the subscription is automatically renewed, or whether it expires at the end of the term and needs to be manually renewed. **Required:** For amendment of type TermsAndConditions when changing the automatic renewal status of a subscription. **Values**: true, false 
    /// </summary>
    /// <value> Determines whether the subscription is automatically renewed, or whether it expires at the end of the term and needs to be manually renewed. **Required:** For amendment of type TermsAndConditions when changing the automatic renewal status of a subscription. **Values**: true, false </value>
    [DataMember(Name="AutoRenew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AutoRenew")]
    public bool? AutoRenew { get; set; }

    /// <summary>
    ///  The date when the amendment's changes become effective for billing purposes. **Version notes**: -- 
    /// </summary>
    /// <value> The date when the amendment's changes become effective for billing purposes. **Version notes**: -- </value>
    [DataMember(Name="ContractEffectiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContractEffectiveDate")]
    public DateTime? ContractEffectiveDate { get; set; }

    /// <summary>
    ///  The length of the period for the current subscription term. This field can be updated when Status is `Draft`. **Required**: Only if the value of the Type field is set to `TermsAndConditions` and TermType is set to `TERMED`. This field is not required if TermType is set to `EVERGREEN`. **Character limit**: **Values**: a valid number **Note**: The InitialTerm field is deprecated from WSDL 73.0, use the CurrentTerm field instead. 
    /// </summary>
    /// <value> The length of the period for the current subscription term. This field can be updated when Status is `Draft`. **Required**: Only if the value of the Type field is set to `TermsAndConditions` and TermType is set to `TERMED`. This field is not required if TermType is set to `EVERGREEN`. **Character limit**: **Values**: a valid number **Note**: The InitialTerm field is deprecated from WSDL 73.0, use the CurrentTerm field instead. </value>
    [DataMember(Name="CurrentTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CurrentTerm")]
    public long? CurrentTerm { get; set; }

    /// <summary>
    ///  The period type for the current subscription term. **Values**:  - `Month` (default) - `Year` - `Day` - `Week` **Note**:  - This field can be updated when Status is `Draft`. - This field is used with the CurrentTerm field to specify the current subscription term. 
    /// </summary>
    /// <value> The period type for the current subscription term. **Values**:  - `Month` (default) - `Year` - `Day` - `Week` **Note**:  - This field can be updated when Status is `Draft`. - This field is used with the CurrentTerm field to specify the current subscription term. </value>
    [DataMember(Name="CurrentTermPeriodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CurrentTermPeriodType")]
    public string CurrentTermPeriodType { get; set; }

    /// <summary>
    ///  The date when the customer accepts the amendment's changes to the subscription. Use this field if [Zuora is configured to require customer acceptance in Z-Billing](https://knowledgecenter.zuora.com/CB_Billing/W_Billing_and_Payments_Settings/Define_Default_Subscription_Settings). **Required**: Only if the value of the Status field is set to PendingAcceptance. **Version notes**: -- 
    /// </summary>
    /// <value> The date when the customer accepts the amendment's changes to the subscription. Use this field if [Zuora is configured to require customer acceptance in Z-Billing](https://knowledgecenter.zuora.com/CB_Billing/W_Billing_and_Payments_Settings/Define_Default_Subscription_Settings). **Required**: Only if the value of the Status field is set to PendingAcceptance. **Version notes**: -- </value>
    [DataMember(Name="CustomerAcceptanceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerAcceptanceDate")]
    public DateTime? CustomerAcceptanceDate { get; set; }

    /// <summary>
    ///  A description of the amendment. **Character limit**: 500 **Values**: maximum 500 characters 
    /// </summary>
    /// <value> A description of the amendment. **Character limit**: 500 **Values**: maximum 500 characters </value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    ///  The date when the amendment's changes take effective. This field validates that the amendment's changes are within valid ranges of products and product rate plans. **Required**: For the cancellation amendments. Optional for other types of amendments. **Version notes**: -- 
    /// </summary>
    /// <value> The date when the amendment's changes take effective. This field validates that the amendment's changes are within valid ranges of products and product rate plans. **Required**: For the cancellation amendments. Optional for other types of amendments. **Version notes**: -- </value>
    [DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveDate")]
    public DateTime? EffectiveDate { get; set; }

    /// <summary>
    ///  The name of the amendment. **Character limit**: 100 **Values**: a string of 100 characters or fewer 
    /// </summary>
    /// <value> The name of the amendment. **Character limit**: 100 **Values**: a string of 100 characters or fewer </value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    ///  Specifies whether a termed subscription will remain termed or change to evergreen when it is renewed. **Required**: If TermType is Termed **Values**: RENEW_WITH_SPECIFIC_TERM (default), RENEW_TO_EVERGREEN 
    /// </summary>
    /// <value> Specifies whether a termed subscription will remain termed or change to evergreen when it is renewed. **Required**: If TermType is Termed **Values**: RENEW_WITH_SPECIFIC_TERM (default), RENEW_TO_EVERGREEN </value>
    [DataMember(Name="RenewalSetting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RenewalSetting")]
    public string RenewalSetting { get; set; }

    /// <summary>
    ///  The term of renewal for the amended subscription. This field can be updated when Status is `Draft`. **Required**: Only if the value of the Type field is set to `TermsAndConditions`. **Character limit**: **Values:** a valid number 
    /// </summary>
    /// <value> The term of renewal for the amended subscription. This field can be updated when Status is `Draft`. **Required**: Only if the value of the Type field is set to `TermsAndConditions`. **Character limit**: **Values:** a valid number </value>
    [DataMember(Name="RenewalTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RenewalTerm")]
    public long? RenewalTerm { get; set; }

    /// <summary>
    ///  The period type for the subscription renewal term. This field can be updated when Status is `Draft`. **Required**: Only if the value of the Type field is set to `TermsAndConditions`. This field is used with the RenewalTerm field to specify the subscription renewal term. **Values**:  - `Month` (default) - `Year` - `Day` - `Week` 
    /// </summary>
    /// <value> The period type for the subscription renewal term. This field can be updated when Status is `Draft`. **Required**: Only if the value of the Type field is set to `TermsAndConditions`. This field is used with the RenewalTerm field to specify the subscription renewal term. **Values**:  - `Month` (default) - `Year` - `Day` - `Week` </value>
    [DataMember(Name="RenewalTermPeriodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RenewalTermPeriodType")]
    public string RenewalTermPeriodType { get; set; }

    /// <summary>
    ///  The date when service is activated. Use this field if [Zuora is configured to require service activation in Z-Billing](https://knowledgecenter.zuora.com/CB_Billing/W_Billing_and_Payments_Settings/Define_Default_Subscription_Settings). **Required**: Only if the value of the Status field is set to PendingActivation. **Version notes**: -- 
    /// </summary>
    /// <value> The date when service is activated. Use this field if [Zuora is configured to require service activation in Z-Billing](https://knowledgecenter.zuora.com/CB_Billing/W_Billing_and_Payments_Settings/Define_Default_Subscription_Settings). **Required**: Only if the value of the Status field is set to PendingActivation. **Version notes**: -- </value>
    [DataMember(Name="ServiceActivationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceActivationDate")]
    public DateTime? ServiceActivationDate { get; set; }

    /// <summary>
    ///  The date when the UpdateProduct amendment takes effect. This field is only applicable if there is already a future-dated UpdateProduct amendment on the subscription. See [Create an UpdateProduct Amendment Before a Future-dated Update](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Amendment/Update_a_Product_(Amendment)#Create_an_UpdateProduct_Amendment_Before_a_Future-dated_Update_(API_version_71.0.2B)) for more information. **Required**: Only for the UpdateProduct amendments if there is already a future-dated UpdateProduct amendment on the subscription. **Version notes**: WSDL 71.0+ 
    /// </summary>
    /// <value> The date when the UpdateProduct amendment takes effect. This field is only applicable if there is already a future-dated UpdateProduct amendment on the subscription. See [Create an UpdateProduct Amendment Before a Future-dated Update](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Amendment/Update_a_Product_(Amendment)#Create_an_UpdateProduct_Amendment_Before_a_Future-dated_Update_(API_version_71.0.2B)) for more information. **Required**: Only for the UpdateProduct amendments if there is already a future-dated UpdateProduct amendment on the subscription. **Version notes**: WSDL 71.0+ </value>
    [DataMember(Name="SpecificUpdateDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpecificUpdateDate")]
    public DateTime? SpecificUpdateDate { get; set; }

    /// <summary>
    ///  The status of the amendment. Type: string (enum) **Character limit**: 17 **Values**: one of the following:  - Draft (default, if left null) - Pending Activation - Pending Acceptance - Completed 
    /// </summary>
    /// <value> The status of the amendment. Type: string (enum) **Character limit**: 17 **Values**: one of the following:  - Draft (default, if left null) - Pending Activation - Pending Acceptance - Completed </value>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    ///  The ID of the subscription that the amendment changes. **Character limit**: 32 **Values**: [a valid subscription ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Subscription#Id) 
    /// </summary>
    /// <value> The ID of the subscription that the amendment changes. **Character limit**: 32 **Values**: [a valid subscription ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Subscription#Id) </value>
    [DataMember(Name="SubscriptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubscriptionId")]
    public string SubscriptionId { get; set; }

    /// <summary>
    ///  The date when the new terms and conditions take effect. **Required**: Only if the value of the Type field is set to TermsAndConditions. **Version notes**: -- 
    /// </summary>
    /// <value> The date when the new terms and conditions take effect. **Required**: Only if the value of the Type field is set to TermsAndConditions. **Version notes**: -- </value>
    [DataMember(Name="TermStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TermStartDate")]
    public DateTime? TermStartDate { get; set; }

    /// <summary>
    ///  Indicates if the subscription isTERMED or EVERGREEN.  - A TERMED subscription has an expiration date, and must be manually renewed. - An EVERGREEN subscription doesn't have an expiration date, and must be manually ended.  **Required**: Only when as part of an amendment of type TermsAndConditions &#65279;to change the term type of a subscription. Type: string **Character limit**: 9 **Values**: TERMED, EVERGREEN 
    /// </summary>
    /// <value> Indicates if the subscription isTERMED or EVERGREEN.  - A TERMED subscription has an expiration date, and must be manually renewed. - An EVERGREEN subscription doesn't have an expiration date, and must be manually ended.  **Required**: Only when as part of an amendment of type TermsAndConditions &#65279;to change the term type of a subscription. Type: string **Character limit**: 9 **Values**: TERMED, EVERGREEN </value>
    [DataMember(Name="TermType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TermType")]
    public string TermType { get; set; }

    /// <summary>
    ///  The type of amendment. **Character limit**: 18 **Values**: one of the following:  - Cancellation - NewProduct - OwnerTransfer - RemoveProduct - Renewal - UpdateProduct - TermsAndConditions - SuspendSubscription (This value is in **Limited Availability**.) - ResumeSubscription (This value is in **Limited Availability**.) 
    /// </summary>
    /// <value> The type of amendment. **Character limit**: 18 **Values**: one of the following:  - Cancellation - NewProduct - OwnerTransfer - RemoveProduct - Renewal - UpdateProduct - TermsAndConditions - SuspendSubscription (This value is in **Limited Availability**.) - ResumeSubscription (This value is in **Limited Availability**.) </value>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyCreateAmendment {\n");
      sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
      sb.Append("  ContractEffectiveDate: ").Append(ContractEffectiveDate).Append("\n");
      sb.Append("  CurrentTerm: ").Append(CurrentTerm).Append("\n");
      sb.Append("  CurrentTermPeriodType: ").Append(CurrentTermPeriodType).Append("\n");
      sb.Append("  CustomerAcceptanceDate: ").Append(CustomerAcceptanceDate).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  RenewalSetting: ").Append(RenewalSetting).Append("\n");
      sb.Append("  RenewalTerm: ").Append(RenewalTerm).Append("\n");
      sb.Append("  RenewalTermPeriodType: ").Append(RenewalTermPeriodType).Append("\n");
      sb.Append("  ServiceActivationDate: ").Append(ServiceActivationDate).Append("\n");
      sb.Append("  SpecificUpdateDate: ").Append(SpecificUpdateDate).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
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
