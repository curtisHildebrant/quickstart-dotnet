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
  public class GETAccountSummaryType {
    /// <summary>
    /// Gets or Sets BasicInfo
    /// </summary>
    [DataMember(Name="basicInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "basicInfo")]
    public GETAccountSummaryTypeBasicInfo BasicInfo { get; set; }

    /// <summary>
    /// Gets or Sets BillToContact
    /// </summary>
    [DataMember(Name="billToContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billToContact")]
    public GETAccountSummaryTypeBillToContact BillToContact { get; set; }

    /// <summary>
    /// Container for invoices. Only returns the last 6 invoices. 
    /// </summary>
    /// <value>Container for invoices. Only returns the last 6 invoices. </value>
    [DataMember(Name="invoices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoices")]
    public List<GETAccountSummaryInvoiceType> Invoices { get; set; }

    /// <summary>
    /// Container for payments. Only returns the last 6 payments. 
    /// </summary>
    /// <value>Container for payments. Only returns the last 6 payments. </value>
    [DataMember(Name="payments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payments")]
    public List<GETAccountSummaryPaymentType> Payments { get; set; }

    /// <summary>
    /// Gets or Sets SoldToContact
    /// </summary>
    [DataMember(Name="soldToContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "soldToContact")]
    public GETAccountSummaryTypeSoldToContact SoldToContact { get; set; }

    /// <summary>
    /// Container for subscriptions. 
    /// </summary>
    /// <value>Container for subscriptions. </value>
    [DataMember(Name="subscriptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptions")]
    public List<GETAccountSummarySubscriptionType> Subscriptions { get; set; }

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
    /// Container for usage data. Only returns the last 6 months of usage. 
    /// </summary>
    /// <value>Container for usage data. Only returns the last 6 months of usage. </value>
    [DataMember(Name="usage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usage")]
    public List<GETAccountSummaryUsageType> Usage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountSummaryType {\n");
      sb.Append("  BasicInfo: ").Append(BasicInfo).Append("\n");
      sb.Append("  BillToContact: ").Append(BillToContact).Append("\n");
      sb.Append("  Invoices: ").Append(Invoices).Append("\n");
      sb.Append("  Payments: ").Append(Payments).Append("\n");
      sb.Append("  SoldToContact: ").Append(SoldToContact).Append("\n");
      sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  TaxInfo: ").Append(TaxInfo).Append("\n");
      sb.Append("  Usage: ").Append(Usage).Append("\n");
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
