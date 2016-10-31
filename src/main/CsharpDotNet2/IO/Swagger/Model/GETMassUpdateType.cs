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
  public class GETMassUpdateType {
    /// <summary>
    /// Type of mass action. 
    /// </summary>
    /// <value>Type of mass action. </value>
    [DataMember(Name="actionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actionType")]
    public string ActionType { get; set; }

    /// <summary>
    /// Date and time that the mass action was completed. The format is `yyyy-MM-dd hh:mm:ss`. 
    /// </summary>
    /// <value>Date and time that the mass action was completed. The format is `yyyy-MM-dd hh:mm:ss`. </value>
    [DataMember(Name="endedOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endedOn")]
    public DateTime? EndedOn { get; set; }

    /// <summary>
    /// Total number of failed records.  This field is updated in real time. When the mass action **status** is Processing, this field returns the number of records that have failed so far. When the mass action **status** is Pending, this field is null. 
    /// </summary>
    /// <value>Total number of failed records.  This field is updated in real time. When the mass action **status** is Processing, this field returns the number of records that have failed so far. When the mass action **status** is Pending, this field is null. </value>
    [DataMember(Name="errorCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorCount")]
    public string ErrorCount { get; set; }

    /// <summary>
    /// Size of the input file in bytes. 
    /// </summary>
    /// <value>Size of the input file in bytes. </value>
    [DataMember(Name="inputSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inputSize")]
    public long? InputSize { get; set; }

    /// <summary>
    /// Size of the response file in bytes. 
    /// </summary>
    /// <value>Size of the response file in bytes. </value>
    [DataMember(Name="outputSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "outputSize")]
    public long? OutputSize { get; set; }

    /// <summary>
    /// Type of output for the response file. The following table describes the output type.  | Output Type    | Description                         | |----------------|-------------------------------------| | (url:.csv.zip) | URL pointing to a zipped .csv file. | 
    /// </summary>
    /// <value>Type of output for the response file. The following table describes the output type.  | Output Type    | Description                         | |----------------|-------------------------------------| | (url:.csv.zip) | URL pointing to a zipped .csv file. | </value>
    [DataMember(Name="outputType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "outputType")]
    public string OutputType { get; set; }

    /// <summary>
    /// URL to download the response file. The response file is a zipped .csv file.  The response file is identical to the file you uploaded to perform the mass action, with additional columns providing information about the outcome of each record. See the [Supported Mass Actions](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater) articles for more information about the response file for each type of mass action.  This field only returns a value when the mass action **status** is Completed or Stopped. Otherwise, this field is null. 
    /// </summary>
    /// <value>URL to download the response file. The response file is a zipped .csv file.  The response file is identical to the file you uploaded to perform the mass action, with additional columns providing information about the outcome of each record. See the [Supported Mass Actions](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater) articles for more information about the response file for each type of mass action.  This field only returns a value when the mass action **status** is Completed or Stopped. Otherwise, this field is null. </value>
    [DataMember(Name="outputURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "outputURL")]
    public string OutputURL { get; set; }

    /// <summary>
    /// Total number of processed records. This field is equal to the sum of `errorCount` and `successCount`.  This field is updated in real time. When the mass action **status** is Processing, this field returns the number of records that have been processed so far. When the mass action **status** is Pending, this field is null. 
    /// </summary>
    /// <value>Total number of processed records. This field is equal to the sum of `errorCount` and `successCount`.  This field is updated in real time. When the mass action **status** is Processing, this field returns the number of records that have been processed so far. When the mass action **status** is Pending, this field is null. </value>
    [DataMember(Name="processedCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processedCount")]
    public string ProcessedCount { get; set; }

    /// <summary>
    /// Date and time that Zuora started processing the mass action. The format is `yyyy-MM-dd hh:mm:ss`. 
    /// </summary>
    /// <value>Date and time that Zuora started processing the mass action. The format is `yyyy-MM-dd hh:mm:ss`. </value>
    [DataMember(Name="startedOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startedOn")]
    public DateTime? StartedOn { get; set; }

    /// <summary>
    /// Status of the mass action. The following table describes the mass action statuses.  | Status     | Description                                                                | |------------|----------------------------------------------------------------------------| | Pending    | Mass action has not yet started being processed.                           | | Processing | Mass action is in progress.                                                | | Stopping   | Mass action is in the process of stopping, but has not yet stopped.        | | Stopped    | Mass action has stopped.                                                   | | Completed  | Mass action was successfully completed. There may still be failed records. | | Failed     | Mass action failed. No records are processed. No response file is created. | 
    /// </summary>
    /// <value>Status of the mass action. The following table describes the mass action statuses.  | Status     | Description                                                                | |------------|----------------------------------------------------------------------------| | Pending    | Mass action has not yet started being processed.                           | | Processing | Mass action is in progress.                                                | | Stopping   | Mass action is in the process of stopping, but has not yet stopped.        | | Stopped    | Mass action has stopped.                                                   | | Completed  | Mass action was successfully completed. There may still be failed records. | | Failed     | Mass action failed. No records are processed. No response file is created. | </value>
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
    /// Total number of successful records. This field is updated in real time. When the mass action **status** is Processing, this field returns the number of records that have succeeded so far. When the mass action **status** is Pending, this field is null. 
    /// </summary>
    /// <value>Total number of successful records. This field is updated in real time. When the mass action **status** is Processing, this field returns the number of records that have succeeded so far. When the mass action **status** is Pending, this field is null. </value>
    [DataMember(Name="successCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "successCount")]
    public string SuccessCount { get; set; }

    /// <summary>
    /// Total number of records in the uploaded mass action file. When the mass action **status** is Pending, this field is null. 
    /// </summary>
    /// <value>Total number of records in the uploaded mass action file. When the mass action **status** is Pending, this field is null. </value>
    [DataMember(Name="totalCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalCount")]
    public string TotalCount { get; set; }

    /// <summary>
    /// Email of the person who uploaded the mass action file. 
    /// </summary>
    /// <value>Email of the person who uploaded the mass action file. </value>
    [DataMember(Name="uploadedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uploadedBy")]
    public string UploadedBy { get; set; }

    /// <summary>
    /// Date and time that the mass action file was uploaded. The format is `yyyy-MM-dd hh:mm:ss`. 
    /// </summary>
    /// <value>Date and time that the mass action file was uploaded. The format is `yyyy-MM-dd hh:mm:ss`. </value>
    [DataMember(Name="uploadedOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uploadedOn")]
    public DateTime? UploadedOn { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETMassUpdateType {\n");
      sb.Append("  ActionType: ").Append(ActionType).Append("\n");
      sb.Append("  EndedOn: ").Append(EndedOn).Append("\n");
      sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
      sb.Append("  InputSize: ").Append(InputSize).Append("\n");
      sb.Append("  OutputSize: ").Append(OutputSize).Append("\n");
      sb.Append("  OutputType: ").Append(OutputType).Append("\n");
      sb.Append("  OutputURL: ").Append(OutputURL).Append("\n");
      sb.Append("  ProcessedCount: ").Append(ProcessedCount).Append("\n");
      sb.Append("  StartedOn: ").Append(StartedOn).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  SuccessCount: ").Append(SuccessCount).Append("\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
      sb.Append("  UploadedBy: ").Append(UploadedBy).Append("\n");
      sb.Append("  UploadedOn: ").Append(UploadedOn).Append("\n");
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
