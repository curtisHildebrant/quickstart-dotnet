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
  public class GETChargeRSDetailType {
    /// <summary>
    /// An account ID. 
    /// </summary>
    /// <value>An account ID. </value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public string AccountId { get; set; }

    /// <summary>
    /// The revenue schedule amount, which is the sum of all revenue items. This field cannot be null and must be formatted based on the currency, such as *JPY 30* or USD *30.15*. Test out the currency to ensure you are using the proper formatting otherwise, the response will fail and this error message is returned:  *\"Allocation amount with wrong decimal places.\"* 
    /// </summary>
    /// <value>The revenue schedule amount, which is the sum of all revenue items. This field cannot be null and must be formatted based on the currency, such as *JPY 30* or USD *30.15*. Test out the currency to ensure you are using the proper formatting otherwise, the response will fail and this error message is returned:  *\"Allocation amount with wrong decimal places.\"* </value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// The type of currency used.  
    /// </summary>
    /// <value>The type of currency used.  </value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Additional information about this record. 
    /// </summary>
    /// <value>Additional information about this record. </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// The charge revenue summary number. 
    /// </summary>
    /// <value>The charge revenue summary number. </value>
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
    /// Revenue items are listed in ascending order by the accounting period start date. 
    /// </summary>
    /// <value>Revenue items are listed in ascending order by the accounting period start date. </value>
    [DataMember(Name="revenueItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueItems")]
    public List<GETRevenueItemType> RevenueItems { get; set; }

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
    /// Returns `true` if the request was processed successfully. 
    /// </summary>
    /// <value>Returns `true` if the request was processed successfully. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETChargeRSDetailType {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  RecognitionRuleName: ").Append(RecognitionRuleName).Append("\n");
      sb.Append("  RecognizedRevenue: ").Append(RecognizedRevenue).Append("\n");
      sb.Append("  RevenueItems: ").Append(RevenueItems).Append("\n");
      sb.Append("  SubscriptionChargeId: ").Append(SubscriptionChargeId).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  UndistributedUnrecognizedRevenue: ").Append(UndistributedUnrecognizedRevenue).Append("\n");
      sb.Append("  UnrecognizedRevenue: ").Append(UnrecognizedRevenue).Append("\n");
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
