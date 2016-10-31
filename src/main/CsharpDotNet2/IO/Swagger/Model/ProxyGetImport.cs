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
  public class ProxyGetImport {
    /// <summary>
    ///  The user ID of the person who created the import. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The user ID of the person who created the import. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  The date when the import was created. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the import was created. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Object identifier.
    /// </summary>
    /// <value>Object identifier.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    ///  The type of item imported. **Character limit**: 7 **Values**: Usage 
    /// </summary>
    /// <value> The type of item imported. **Character limit**: 7 **Values**: Usage </value>
    [DataMember(Name="ImportType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ImportType")]
    public string ImportType { get; set; }

    /// <summary>
    /// The number of records successfully imported. **Character limit**: **Values**: automatically generated 
    /// </summary>
    /// <value>The number of records successfully imported. **Character limit**: **Values**: automatically generated </value>
    [DataMember(Name="ImportedCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ImportedCount")]
    public int? ImportedCount { get; set; }

    /// <summary>
    ///  A check to validate the import file's integrity. **Character limi**t: 32 **System-generated**: no **Values**: a string of 32 characters or fewer 
    /// </summary>
    /// <value> A check to validate the import file's integrity. **Character limi**t: 32 **System-generated**: no **Values**: a string of 32 characters or fewer </value>
    [DataMember(Name="Md5", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Md5")]
    public string Md5 { get; set; }

    /// <summary>
    ///  A descriptive name for the import. **Character limi**t: 100 **Values**: one of the following:  - a string of 100 characters or fewer - if NULL default is:` import <ImportType_value>` 
    /// </summary>
    /// <value> A descriptive name for the import. **Character limi**t: 100 **Values**: one of the following:  - a string of 100 characters or fewer - if NULL default is:` import <ImportType_value>` </value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    ///  The URL for your import file, which contains your records for upload. When you upload the file, Zuora assigns it to this address. **Character limit**: **Values**: automatic dynamically-generated URL 
    /// </summary>
    /// <value> The URL for your import file, which contains your records for upload. When you upload the file, Zuora assigns it to this address. **Character limit**: **Values**: automatic dynamically-generated URL </value>
    [DataMember(Name="OriginalResourceUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OriginalResourceUrl")]
    public string OriginalResourceUrl { get; set; }

    /// <summary>
    ///  The URL for the import result file, which is a zipped CSV file. **Character limit**: **Values**: automatic dynamically-generated URL 
    /// </summary>
    /// <value> The URL for the import result file, which is a zipped CSV file. **Character limit**: **Values**: automatic dynamically-generated URL </value>
    [DataMember(Name="ResultResourceUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ResultResourceUrl")]
    public string ResultResourceUrl { get; set; }

    /// <summary>
    /// The status of the import process. **Character limit**: 10 **Values**: automatically generated using one of the following values:  - Pending - Processing - Completed - Failed 
    /// </summary>
    /// <value>The status of the import process. **Character limit**: 10 **Values**: automatically generated using one of the following values:  - Pending - Processing - Completed - Failed </value>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    ///  The reason for the system-generated status. Use this information if the import fails. **Character limit**: 2000 **Values**: automatically generated error message 
    /// </summary>
    /// <value> The reason for the system-generated status. Use this information if the import fails. **Character limit**: 2000 **Values**: automatically generated error message </value>
    [DataMember(Name="StatusReason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StatusReason")]
    public string StatusReason { get; set; }

    /// <summary>
    ///  The number of records in the import file. **Character limit**: **Values**: automatically generated 
    /// </summary>
    /// <value> The number of records in the import file. **Character limit**: **Values**: automatically generated </value>
    [DataMember(Name="TotalCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalCount")]
    public int? TotalCount { get; set; }

    /// <summary>
    ///  The ID of the user who last updated the import. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the user who last updated the import. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    ///  The date when the import was last updated. **Character limi**t: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the import was last updated. **Character limi**t: 29 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetImport {\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ImportType: ").Append(ImportType).Append("\n");
      sb.Append("  ImportedCount: ").Append(ImportedCount).Append("\n");
      sb.Append("  Md5: ").Append(Md5).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  OriginalResourceUrl: ").Append(OriginalResourceUrl).Append("\n");
      sb.Append("  ResultResourceUrl: ").Append(ResultResourceUrl).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  StatusReason: ").Append(StatusReason).Append("\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
