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
  public class ProxyGetAccountingPeriod {
    /// <summary>
    ///  The identifier of the user who created the accounting code. **Character limit:** N/A **Z-Finance Required****: **No 
    /// </summary>
    /// <value> The identifier of the user who created the accounting code. **Character limit:** N/A **Z-Finance Required****: **No </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  The date when the accounting code was created. **Character limit:** N/A **Z-Finance Required****: **No 
    /// </summary>
    /// <value> The date when the accounting code was created. **Character limit:** N/A **Z-Finance Required****: **No </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    ///  The end date of the accounting period. **Character limit**: **Version notes**: Z-Finance 
    /// </summary>
    /// <value> The end date of the accounting period. **Character limit**: **Version notes**: Z-Finance </value>
    [DataMember(Name="EndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EndDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    ///  The fiscal year for the accounting period. **Values**: a valid integer of the form, YYYY 
    /// </summary>
    /// <value> The fiscal year for the accounting period. **Values**: a valid integer of the form, YYYY </value>
    [DataMember(Name="FiscalYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FiscalYear")]
    public int? FiscalYear { get; set; }

    /// <summary>
    /// Object identifier.
    /// </summary>
    /// <value>Object identifier.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    ///  The name of the accounting period, which is displayed on the list of accounting periods on the All Accounting Periods page. **Character limit**:100 **Values**: a string of 100 characters or fewer 
    /// </summary>
    /// <value> The name of the accounting period, which is displayed on the list of accounting periods on the All Accounting Periods page. **Character limit**:100 **Values**: a string of 100 characters or fewer </value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Use this field to record comments about the accounting period. **Character limit**: 255 **Values**: a string of 255 characters or fewer 
    /// </summary>
    /// <value>Use this field to record comments about the accounting period. **Character limit**: 255 **Values**: a string of 255 characters or fewer </value>
    [DataMember(Name="Notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Notes")]
    public string Notes { get; set; }

    /// <summary>
    ///  The start date of the accounting period. **Character limit**: 29 **Values**: automatically generated after the first accounting period 
    /// </summary>
    /// <value> The start date of the accounting period. **Character limit**: 29 **Values**: automatically generated after the first accounting period </value>
    [DataMember(Name="StartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    ///  The status of the accounting period. **Character limit**: 6 **Allowable values**: automatically generated on creattion; one of the following values:  - Open - Closed 
    /// </summary>
    /// <value> The status of the accounting period. **Character limit**: 6 **Allowable values**: automatically generated on creattion; one of the following values:  - Open - Closed </value>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    ///  The identifier of the user who created the accounting code. **Character limit:** N/A **Z-Finance Required**: No 
    /// </summary>
    /// <value> The identifier of the user who created the accounting code. **Character limit:** N/A **Z-Finance Required**: No </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    ///  The date when the accounting code was updated. **Character limit:** N/A **Z-Finance Required****: **No 
    /// </summary>
    /// <value> The date when the accounting code was updated. **Character limit:** N/A **Z-Finance Required****: **No </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetAccountingPeriod {\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
