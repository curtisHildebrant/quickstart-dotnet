using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for tax exempt information, used to establish the tax exempt status of a customer account. 
  /// </summary>
  [DataContract]
  public class GETAccountSummaryTypeTaxInfo {
    /// <summary>
    /// EU Value Added Tax ID. 
    /// </summary>
    /// <value>EU Value Added Tax ID. </value>
    [DataMember(Name="VATId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VATId")]
    public string VATId { get; set; }

    /// <summary>
    /// Unique code that identifies a company account in Avalara. 
    /// </summary>
    /// <value>Unique code that identifies a company account in Avalara. </value>
    [DataMember(Name="companyCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "companyCode")]
    public string CompanyCode { get; set; }

    /// <summary>
    /// ID of the customer tax exemption certificate. 
    /// </summary>
    /// <value>ID of the customer tax exemption certificate. </value>
    [DataMember(Name="exemptCertificateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exemptCertificateId")]
    public string ExemptCertificateId { get; set; }

    /// <summary>
    /// Type of tax exemption certificate that the customer holds. 
    /// </summary>
    /// <value>Type of tax exemption certificate that the customer holds. </value>
    [DataMember(Name="exemptCertificateType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exemptCertificateType")]
    public string ExemptCertificateType { get; set; }

    /// <summary>
    /// Description of the tax exemption certificate that the customer holds. 
    /// </summary>
    /// <value>Description of the tax exemption certificate that the customer holds. </value>
    [DataMember(Name="exemptDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exemptDescription")]
    public string ExemptDescription { get; set; }

    /// <summary>
    /// Date when the customer tax exemption starts. 
    /// </summary>
    /// <value>Date when the customer tax exemption starts. </value>
    [DataMember(Name="exemptEffectiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exemptEffectiveDate")]
    public DateTime? ExemptEffectiveDate { get; set; }

    /// <summary>
    /// Date when the customer tax exemption expires. 
    /// </summary>
    /// <value>Date when the customer tax exemption expires. </value>
    [DataMember(Name="exemptExpirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exemptExpirationDate")]
    public DateTime? ExemptExpirationDate { get; set; }

    /// <summary>
    /// Jurisdiction in which the customer tax exemption certificate was issued. 
    /// </summary>
    /// <value>Jurisdiction in which the customer tax exemption certificate was issued. </value>
    [DataMember(Name="exemptIssuingJurisdiction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exemptIssuingJurisdiction")]
    public string ExemptIssuingJurisdiction { get; set; }

    /// <summary>
    /// Status of the account tax exemption. 
    /// </summary>
    /// <value>Status of the account tax exemption. </value>
    [DataMember(Name="exemptStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exemptStatus")]
    public string ExemptStatus { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountSummaryTypeTaxInfo {\n");
      sb.Append("  VATId: ").Append(VATId).Append("\n");
      sb.Append("  CompanyCode: ").Append(CompanyCode).Append("\n");
      sb.Append("  ExemptCertificateId: ").Append(ExemptCertificateId).Append("\n");
      sb.Append("  ExemptCertificateType: ").Append(ExemptCertificateType).Append("\n");
      sb.Append("  ExemptDescription: ").Append(ExemptDescription).Append("\n");
      sb.Append("  ExemptEffectiveDate: ").Append(ExemptEffectiveDate).Append("\n");
      sb.Append("  ExemptExpirationDate: ").Append(ExemptExpirationDate).Append("\n");
      sb.Append("  ExemptIssuingJurisdiction: ").Append(ExemptIssuingJurisdiction).Append("\n");
      sb.Append("  ExemptStatus: ").Append(ExemptStatus).Append("\n");
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
