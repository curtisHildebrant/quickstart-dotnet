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
  public class GETAccountType {
    /// <summary>
    /// Gets or Sets BasicInfo
    /// </summary>
    [DataMember(Name="basicInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "basicInfo")]
    public GETAccountTypeBasicInfo BasicInfo { get; set; }

    /// <summary>
    /// Gets or Sets BillToContact
    /// </summary>
    [DataMember(Name="billToContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billToContact")]
    public GETAccountTypeBillToContact BillToContact { get; set; }

    /// <summary>
    /// Gets or Sets BillingAndPayment
    /// </summary>
    [DataMember(Name="billingAndPayment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingAndPayment")]
    public GETAccountTypeBillingAndPayment BillingAndPayment { get; set; }

    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    [DataMember(Name="metrics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metrics")]
    public GETAccountTypeMetrics Metrics { get; set; }

    /// <summary>
    /// Gets or Sets SoldToContact
    /// </summary>
    [DataMember(Name="soldToContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "soldToContact")]
    public GETAccountTypeSoldToContact SoldToContact { get; set; }

    /// <summary>
    /// Returns `true` if the request was processed successfully. 
    /// </summary>
    /// <value>Returns `true` if the request was processed successfully. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// Gets or Sets TaxInfo
    /// </summary>
    [DataMember(Name="taxInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxInfo")]
    public GETAccountSummaryTypeTaxInfo TaxInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountType {\n");
      sb.Append("  BasicInfo: ").Append(BasicInfo).Append("\n");
      sb.Append("  BillToContact: ").Append(BillToContact).Append("\n");
      sb.Append("  BillingAndPayment: ").Append(BillingAndPayment).Append("\n");
      sb.Append("  Metrics: ").Append(Metrics).Append("\n");
      sb.Append("  SoldToContact: ").Append(SoldToContact).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  TaxInfo: ").Append(TaxInfo).Append("\n");
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
