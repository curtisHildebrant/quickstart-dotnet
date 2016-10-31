using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for finance information of a rate plan charge. 
  /// </summary>
  [DataContract]
  public class GETProductRatePlanChargeTypeFinanceInformation {
    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// The accounting code for deferred revenue, such as Monthly Recurring Liability.  
    /// </summary>
    /// <value>The accounting code for deferred revenue, such as Monthly Recurring Liability.  </value>
    [DataMember(Name="deferredRevenueAccountingCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deferredRevenueAccountingCode")]
    public string DeferredRevenueAccountingCode { get; set; }

    /// <summary>
    /// The type associated with the deferred revenue accounting code, such as Deferred Revenue.  
    /// </summary>
    /// <value>The type associated with the deferred revenue accounting code, such as Deferred Revenue.  </value>
    [DataMember(Name="deferredRevenueAccountingCodeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deferredRevenueAccountingCodeType")]
    public string DeferredRevenueAccountingCodeType { get; set; }

    /// <summary>
    /// The accounting code for recognized revenue, such as Monthly Recurring Charges or Overage Charges.  
    /// </summary>
    /// <value>The accounting code for recognized revenue, such as Monthly Recurring Charges or Overage Charges.  </value>
    [DataMember(Name="recognizedRevenueAccountingCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recognizedRevenueAccountingCode")]
    public string RecognizedRevenueAccountingCode { get; set; }

    /// <summary>
    /// The type associated with the recognized revenue accounting code, such as Sales Revenue or Sales Discount.  
    /// </summary>
    /// <value>The type associated with the recognized revenue accounting code, such as Sales Revenue or Sales Discount.  </value>
    [DataMember(Name="recognizedRevenueAccountingCodeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recognizedRevenueAccountingCodeType")]
    public string RecognizedRevenueAccountingCodeType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETProductRatePlanChargeTypeFinanceInformation {\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  DeferredRevenueAccountingCode: ").Append(DeferredRevenueAccountingCode).Append("\n");
      sb.Append("  DeferredRevenueAccountingCodeType: ").Append(DeferredRevenueAccountingCodeType).Append("\n");
      sb.Append("  RecognizedRevenueAccountingCode: ").Append(RecognizedRevenueAccountingCode).Append("\n");
      sb.Append("  RecognizedRevenueAccountingCodeType: ").Append(RecognizedRevenueAccountingCodeType).Append("\n");
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
