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
  public class GETAccountingPeriodType {
    /// <summary>
    /// ID of the user who created the accounting period. 
    /// </summary>
    /// <value>ID of the user who created the accounting period. </value>
    [DataMember(Name="createdBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdBy")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// Date and time when the accounting period was created. 
    /// </summary>
    /// <value>Date and time when the accounting period was created. </value>
    [DataMember(Name="createdOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdOn")]
    public DateTime? CreatedOn { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// The end date of the accounting period. 
    /// </summary>
    /// <value>The end date of the accounting period. </value>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// File IDs of the reports available for the accounting period. You can retrieve the reports by specifying the file ID in a [Get Files](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Get_Files) REST API call. 
    /// </summary>
    /// <value>File IDs of the reports available for the accounting period. You can retrieve the reports by specifying the file ID in a [Get Files](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Get_Files) REST API call. </value>
    [DataMember(Name="fileIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileIds")]
    public List<GETAccountingPeriodFileIdsType> FileIds { get; set; }

    /// <summary>
    /// Fiscal year of the accounting period. 
    /// </summary>
    /// <value>Fiscal year of the accounting period. </value>
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
    /// ID of the accounting period. 
    /// </summary>
    /// <value>ID of the accounting period. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Name of the accounting period. 
    /// </summary>
    /// <value>Name of the accounting period. </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Any optional notes about the accounting period. 
    /// </summary>
    /// <value>Any optional notes about the accounting period. </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// Date and time that the trial balance was completed. If the trial balance status is `Pending`, `Processing`, or `Error`, this field is `null`. 
    /// </summary>
    /// <value>Date and time that the trial balance was completed. If the trial balance status is `Pending`, `Processing`, or `Error`, this field is `null`. </value>
    [DataMember(Name="runTrialBalanceEnd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runTrialBalanceEnd")]
    public DateTime? RunTrialBalanceEnd { get; set; }

    /// <summary>
    /// If trial balance status is Error, an error message is returned in this field. 
    /// </summary>
    /// <value>If trial balance status is Error, an error message is returned in this field. </value>
    [DataMember(Name="runTrialBalanceErrorMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runTrialBalanceErrorMessage")]
    public string RunTrialBalanceErrorMessage { get; set; }

    /// <summary>
    /// Date and time that the trial balance was run. If the trial balance status is Pending, this field is null. 
    /// </summary>
    /// <value>Date and time that the trial balance was run. If the trial balance status is Pending, this field is null. </value>
    [DataMember(Name="runTrialBalanceStart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runTrialBalanceStart")]
    public DateTime? RunTrialBalanceStart { get; set; }

    /// <summary>
    /// Status of the trial balance for the accounting period. Possible values:  * `Pending` * `Processing` * `Completed` * `Error` 
    /// </summary>
    /// <value>Status of the trial balance for the accounting period. Possible values:  * `Pending` * `Processing` * `Completed` * `Error` </value>
    [DataMember(Name="runTrialBalanceStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runTrialBalanceStatus")]
    public string RunTrialBalanceStatus { get; set; }

    /// <summary>
    /// The start date of the accounting period. 
    /// </summary>
    /// <value>The start date of the accounting period. </value>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Status of the accounting period. Possible values: * `Open` * `PendingClose` * `Closed` 
    /// </summary>
    /// <value>Status of the accounting period. Possible values: * `Open` * `PendingClose` * `Closed` </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Returns `true` if the request was processed successfully. 
    /// </summary>
    /// <value>Returns `true` if the request was processed successfully. </value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// ID of the user who last updated the accounting period. 
    /// </summary>
    /// <value>ID of the user who last updated the accounting period. </value>
    [DataMember(Name="updatedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedBy")]
    public string UpdatedBy { get; set; }

    /// <summary>
    /// Date and time when the accounting period was last updated. 
    /// </summary>
    /// <value>Date and time when the accounting period was last updated. </value>
    [DataMember(Name="updatedOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedOn")]
    public DateTime? UpdatedOn { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountingPeriodType {\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
      sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  FileIds: ").Append(FileIds).Append("\n");
      sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
      sb.Append("  FiscalQuarter: ").Append(FiscalQuarter).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  RunTrialBalanceEnd: ").Append(RunTrialBalanceEnd).Append("\n");
      sb.Append("  RunTrialBalanceErrorMessage: ").Append(RunTrialBalanceErrorMessage).Append("\n");
      sb.Append("  RunTrialBalanceStart: ").Append(RunTrialBalanceStart).Append("\n");
      sb.Append("  RunTrialBalanceStatus: ").Append(RunTrialBalanceStatus).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
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
