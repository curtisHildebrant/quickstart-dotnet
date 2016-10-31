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
  public class POSTAccountingPeriodType {
    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// The end date of the accounting period in yyyy-mm-dd format, for example, \"2016-02-19\". 
    /// </summary>
    /// <value>The end date of the accounting period in yyyy-mm-dd format, for example, \"2016-02-19\". </value>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Fiscal year of the accounting period in yyyy format, for example, \"2016\". 
    /// </summary>
    /// <value>Fiscal year of the accounting period in yyyy format, for example, \"2016\". </value>
    [DataMember(Name="fiscalYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fiscalYear")]
    public string FiscalYear { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="fiscal_quarter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fiscal_quarter")]
    public long? FiscalQuarter { get; set; }

    /// <summary>
    /// Name of the accounting period.  Accounting period name must be unique. Maximum of 100 characters. 
    /// </summary>
    /// <value>Name of the accounting period.  Accounting period name must be unique. Maximum of 100 characters. </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Notes about the accounting period.  Maximum of 255 characters. 
    /// </summary>
    /// <value>Notes about the accounting period.  Maximum of 255 characters. </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// The start date of the accounting period in yyyy-mm-dd format, for example, \"2016-02-19\". 
    /// </summary>
    /// <value>The start date of the accounting period in yyyy-mm-dd format, for example, \"2016-02-19\". </value>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTAccountingPeriodType {\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
      sb.Append("  FiscalQuarter: ").Append(FiscalQuarter).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
