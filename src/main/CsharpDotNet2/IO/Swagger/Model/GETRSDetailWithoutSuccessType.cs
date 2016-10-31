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
  public class GETRSDetailWithoutSuccessType {
    /// <summary>
    /// An account ID. 
    /// </summary>
    /// <value>An account ID. </value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public string AccountId { get; set; }

    /// <summary>
    /// The revenue schedule amount, which is the sum of all revenue items. This field cannot be null and must be formatted based on the currency, such as `JPY 30` or `USD 30.15`. Test out the currency to ensure you are using the proper formatting otherwise, the response will fail and this error message is returned: `Allocation amount with wrong decimal places.` 
    /// </summary>
    /// <value>The revenue schedule amount, which is the sum of all revenue items. This field cannot be null and must be formatted based on the currency, such as `JPY 30` or `USD 30.15`. Test out the currency to ensure you are using the proper formatting otherwise, the response will fail and this error message is returned: `Allocation amount with wrong decimal places.` </value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// The date when the record was created in `YYYY-MM-DD HH:MM:SS` format. 
    /// </summary>
    /// <value>The date when the record was created in `YYYY-MM-DD HH:MM:SS` format. </value>
    [DataMember(Name="createdOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdOn")]
    public DateTime? CreatedOn { get; set; }

    /// <summary>
    /// The type of currency used. 
    /// </summary>
    /// <value>The type of currency used. </value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// The linked transaction ID for billing transactions. This field is used for all rules except the custom unlimited or manual recognition rule models. If using the custom unlimited rule model, then the field value must be null. If the field is not null, then the referenceId field must be null.  
    /// </summary>
    /// <value>The linked transaction ID for billing transactions. This field is used for all rules except the custom unlimited or manual recognition rule models. If using the custom unlimited rule model, then the field value must be null. If the field is not null, then the referenceId field must be null.  </value>
    [DataMember(Name="linkedTransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkedTransactionId")]
    public string LinkedTransactionId { get; set; }

    /// <summary>
    /// The number for the linked invoice item or invoice item adjustment transaction. This field is used for all rules except the custom unlimited or manual recognition rule models.  If using the custom unlimited or manual recognition rule models, then the field value is null.  
    /// </summary>
    /// <value>The number for the linked invoice item or invoice item adjustment transaction. This field is used for all rules except the custom unlimited or manual recognition rule models.  If using the custom unlimited or manual recognition rule models, then the field value is null.  </value>
    [DataMember(Name="linkedTransactionNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkedTransactionNumber")]
    public string LinkedTransactionNumber { get; set; }

    /// <summary>
    /// The type of linked transaction for billing transactions, which can be invoice item or invoice item adjustment. This field is used for all rules except the custom unlimited or manual recognition rule models. 
    /// </summary>
    /// <value>The type of linked transaction for billing transactions, which can be invoice item or invoice item adjustment. This field is used for all rules except the custom unlimited or manual recognition rule models. </value>
    [DataMember(Name="linkedTransactionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkedTransactionType")]
    public string LinkedTransactionType { get; set; }

    /// <summary>
    /// Additional information about this record. 
    /// </summary>
    /// <value>Additional information about this record. </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// Revenue schedule number. The revenue schedule number is always prefixed with \"RS\", for example, \"RS-00000001\". 
    /// </summary>
    /// <value>Revenue schedule number. The revenue schedule number is always prefixed with \"RS\", for example, \"RS-00000001\". </value>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public string Number { get; set; }

    /// <summary>
    /// The name of the recognition rule. 
    /// </summary>
    /// <value>The name of the recognition rule. </value>
    [DataMember(Name="recognitionRuleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recognitionRuleName")]
    public string RecognitionRuleName { get; set; }

    /// <summary>
    /// The revenue that was distributed in a closed accounting period. 
    /// </summary>
    /// <value>The revenue that was distributed in a closed accounting period. </value>
    [DataMember(Name="recognizedRevenue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recognizedRevenue")]
    public string RecognizedRevenue { get; set; }

    /// <summary>
    /// Reference ID is used only in the custom unlimited rule to create a revenue schedule. In this scenario, the revenue schedule is not linked to an invoice item or invoice item adjustment. 
    /// </summary>
    /// <value>Reference ID is used only in the custom unlimited rule to create a revenue schedule. In this scenario, the revenue schedule is not linked to an invoice item or invoice item adjustment. </value>
    [DataMember(Name="referenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceId")]
    public string ReferenceId { get; set; }

    /// <summary>
    /// Revenue items are listed in ascending order by the accounting period start date. 
    /// </summary>
    /// <value>Revenue items are listed in ascending order by the accounting period start date. </value>
    [DataMember(Name="revenueItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueItems")]
    public List<GETRsRevenueItemType> RevenueItems { get; set; }

    /// <summary>
    /// The effective date of the revenue schedule. For example, the revenue schedule date for bookings-based revenue recognition is typically set to the order date or contract date.  The date cannot be in a closed accounting period. The date must be in the `YYYY-MM-DD` format. 
    /// </summary>
    /// <value>The effective date of the revenue schedule. For example, the revenue schedule date for bookings-based revenue recognition is typically set to the order date or contract date.  The date cannot be in a closed accounting period. The date must be in the `YYYY-MM-DD` format. </value>
    [DataMember(Name="revenueScheduleDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueScheduleDate")]
    public DateTime? RevenueScheduleDate { get; set; }

    /// <summary>
    /// The original subscription charge ID. 
    /// </summary>
    /// <value>The original subscription charge ID. </value>
    [DataMember(Name="subscriptionChargeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionChargeId")]
    public string SubscriptionChargeId { get; set; }

    /// <summary>
    /// The original subscription ID. 
    /// </summary>
    /// <value>The original subscription ID. </value>
    [DataMember(Name="subscriptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionId")]
    public string SubscriptionId { get; set; }

    /// <summary>
    /// Revenue in the open-ended accounting period. 
    /// </summary>
    /// <value>Revenue in the open-ended accounting period. </value>
    [DataMember(Name="undistributedUnrecognizedRevenue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "undistributedUnrecognizedRevenue")]
    public string UndistributedUnrecognizedRevenue { get; set; }

    /// <summary>
    /// Revenue distributed in all open accounting periods, which includes the open-ended accounting period. 
    /// </summary>
    /// <value>Revenue distributed in all open accounting periods, which includes the open-ended accounting period. </value>
    [DataMember(Name="unrecognizedRevenue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unrecognizedRevenue")]
    public string UnrecognizedRevenue { get; set; }

    /// <summary>
    /// The date when the revenue automation start date was set. 
    /// </summary>
    /// <value>The date when the revenue automation start date was set. </value>
    [DataMember(Name="updatedOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedOn")]
    public DateTime? UpdatedOn { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETRSDetailWithoutSuccessType {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  LinkedTransactionId: ").Append(LinkedTransactionId).Append("\n");
      sb.Append("  LinkedTransactionNumber: ").Append(LinkedTransactionNumber).Append("\n");
      sb.Append("  LinkedTransactionType: ").Append(LinkedTransactionType).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  RecognitionRuleName: ").Append(RecognitionRuleName).Append("\n");
      sb.Append("  RecognizedRevenue: ").Append(RecognizedRevenue).Append("\n");
      sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
      sb.Append("  RevenueItems: ").Append(RevenueItems).Append("\n");
      sb.Append("  RevenueScheduleDate: ").Append(RevenueScheduleDate).Append("\n");
      sb.Append("  SubscriptionChargeId: ").Append(SubscriptionChargeId).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
      sb.Append("  UndistributedUnrecognizedRevenue: ").Append(UndistributedUnrecognizedRevenue).Append("\n");
      sb.Append("  UnrecognizedRevenue: ").Append(UnrecognizedRevenue).Append("\n");
      sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
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
