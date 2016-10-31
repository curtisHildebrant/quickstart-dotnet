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
  public class ProxyCreateUsage {
    /// <summary>
    ///  The ID of the account associated with the usage data. This field is required if no value is specified for the `AccountNumber` field. **Character limit**: 32 **Values**: a valid [account ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account) 
    /// </summary>
    /// <value> The ID of the account associated with the usage data. This field is required if no value is specified for the `AccountNumber` field. **Character limit**: 32 **Values**: a valid [account ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account) </value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public string AccountId { get; set; }

    /// <summary>
    ///  The number of the account associated with the usage data. This field is required if no value is specified for the `AccountId` field. **Character limit**: 50 **Values**: a valid [account number](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account) 
    /// </summary>
    /// <value> The number of the account associated with the usage data. This field is required if no value is specified for the `AccountId` field. **Character limit**: 50 **Values**: a valid [account number](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account) </value>
    [DataMember(Name="AccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    ///  The OrginalId of the rate plan charge related to the usage record, e.g., `2c9081a03c63c94c013c6873357a0117` **Character limit**: 32 **Values**: a valid [rate plan charge OriginalID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/RatePlanCharge) 
    /// </summary>
    /// <value> The OrginalId of the rate plan charge related to the usage record, e.g., `2c9081a03c63c94c013c6873357a0117` **Character limit**: 32 **Values**: a valid [rate plan charge OriginalID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/RatePlanCharge) </value>
    [DataMember(Name="ChargeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeId")]
    public string ChargeId { get; set; }

    /// <summary>
    ///  The end date and time of a range of time when usage is tracked. Use this field for reporting; this field doesn't affect usage calculation. **Character limit**: 29 **Values**: a valid [date and time value](https://knowledgecenter.zuora.com/CB_Billing/WA_Dates_in_Zuora/A_Date_and_dateTime_Format) 
    /// </summary>
    /// <value> The end date and time of a range of time when usage is tracked. Use this field for reporting; this field doesn't affect usage calculation. **Character limit**: 29 **Values**: a valid [date and time value](https://knowledgecenter.zuora.com/CB_Billing/WA_Dates_in_Zuora/A_Date_and_dateTime_Format) </value>
    [DataMember(Name="EndDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EndDateTime")]
    public DateTime? EndDateTime { get; set; }

    /// <summary>
    ///  Indicates the number of units used. **Character limit**: 16 **Values**: a valid decimal amount equal to or greater than 0 
    /// </summary>
    /// <value> Indicates the number of units used. **Character limit**: 16 **Values**: a valid decimal amount equal to or greater than 0 </value>
    [DataMember(Name="Quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Quantity")]
    public double? Quantity { get; set; }

    /// <summary>
    ///  Indicates if the rating and billing engine (RBE) processed usage data for an invoice. **Character limit**: 9 **Values**: automatically generated to be one of the following values: `Importing`, `Pending`, `Processed` 
    /// </summary>
    /// <value> Indicates if the rating and billing engine (RBE) processed usage data for an invoice. **Character limit**: 9 **Values**: automatically generated to be one of the following values: `Importing`, `Pending`, `Processed` </value>
    [DataMember(Name="RbeStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RbeStatus")]
    public string RbeStatus { get; set; }

    /// <summary>
    ///  The start date and time of a range of time when usage is tracked. Zuora uses this field value to determine the usage date. Unlike the `EndDateTime`, the `StartDateTime` field does affect usage calculation. **Character limit**: 29 **Values**: a valid [date and time value](https://knowledgecenter.zuora.com/CB_Billing/WA_Dates_in_Zuora/A_Date_and_dateTime_Format) 
    /// </summary>
    /// <value> The start date and time of a range of time when usage is tracked. Zuora uses this field value to determine the usage date. Unlike the `EndDateTime`, the `StartDateTime` field does affect usage calculation. **Character limit**: 29 **Values**: a valid [date and time value](https://knowledgecenter.zuora.com/CB_Billing/WA_Dates_in_Zuora/A_Date_and_dateTime_Format) </value>
    [DataMember(Name="StartDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartDateTime")]
    public DateTime? StartDateTime { get; set; }

    /// <summary>
    ///  The date when usage was submitted. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when usage was submitted. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="SubmissionDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubmissionDateTime")]
    public DateTime? SubmissionDateTime { get; set; }

    /// <summary>
    ///  The ID of the subscription that contains the fees related to the usage data. **Character limit**: 32 **Values**: a valid [subscription ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Subscription) 
    /// </summary>
    /// <value> The ID of the subscription that contains the fees related to the usage data. **Character limit**: 32 **Values**: a valid [subscription ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Subscription) </value>
    [DataMember(Name="SubscriptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubscriptionId")]
    public string SubscriptionId { get; set; }

    /// <summary>
    ///  Specifies the units to measure usage. Units of measure are configured in the web-based UI. Your values depend on your configuration in **Z-Billing > Settings**. **Character limit**: **Values**: a valid unit of measure 
    /// </summary>
    /// <value> Specifies the units to measure usage. Units of measure are configured in the web-based UI. Your values depend on your configuration in **Z-Billing > Settings**. **Character limit**: **Values**: a valid unit of measure </value>
    [DataMember(Name="UOM", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UOM")]
    public string UOM { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyCreateUsage {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  ChargeId: ").Append(ChargeId).Append("\n");
      sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  RbeStatus: ").Append(RbeStatus).Append("\n");
      sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
      sb.Append("  SubmissionDateTime: ").Append(SubmissionDateTime).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
      sb.Append("  UOM: ").Append(UOM).Append("\n");
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
