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
  public class GETAccountingCodeItemType {
    /// <summary>
    /// The category associated with the accounting code.  Possible values: * `Assets` * `Liabilities` * `Equity` * `Revenue` * `Expenses` 
    /// </summary>
    /// <value>The category associated with the accounting code.  Possible values: * `Assets` * `Liabilities` * `Equity` * `Revenue` * `Expenses` </value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// The ID of the user who created the accounting code. 
    /// </summary>
    /// <value>The ID of the user who created the accounting code. </value>
    [DataMember(Name="createdBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdBy")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// Date and time when the accounting code was created. 
    /// </summary>
    /// <value>Date and time when the accounting code was created. </value>
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
    /// Name of the account in your general ledger.  Field only available if you have Z-Finance enabled. 
    /// </summary>
    /// <value>Name of the account in your general ledger.  Field only available if you have Z-Finance enabled. </value>
    [DataMember(Name="glAccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "glAccountName")]
    public string GlAccountName { get; set; }

    /// <summary>
    /// Account number in your general ledger.  Field only available if you have Z-Finance enabled. 
    /// </summary>
    /// <value>Account number in your general ledger.  Field only available if you have Z-Finance enabled. </value>
    [DataMember(Name="glAccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "glAccountNumber")]
    public string GlAccountNumber { get; set; }

    /// <summary>
    /// ID of the accounting code. 
    /// </summary>
    /// <value>ID of the accounting code. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Name of the accounting code. 
    /// </summary>
    /// <value>Name of the accounting code. </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Any optional notes for the accounting code. 
    /// </summary>
    /// <value>Any optional notes for the accounting code. </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// The accounting code status.  Possible values: * `Active` * `Inactive` 
    /// </summary>
    /// <value>The accounting code status.  Possible values: * `Active` * `Inactive` </value>
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
    /// Accounting code type.  Possible values: * `AccountsReceivable` * `Cash` * `OtherAssets` * `CustomerCashOnAccount` * `DeferredRevenue` * `SalesTaxPayable` * `OtherLiabilities` * `SalesRevenue` * `SalesDiscounts` * `OtherRevenue` * `OtherEquity` * `BadDebt` * `OtherExpenses` 
    /// </summary>
    /// <value>Accounting code type.  Possible values: * `AccountsReceivable` * `Cash` * `OtherAssets` * `CustomerCashOnAccount` * `DeferredRevenue` * `SalesTaxPayable` * `OtherLiabilities` * `SalesRevenue` * `SalesDiscounts` * `OtherRevenue` * `OtherEquity` * `BadDebt` * `OtherExpenses` </value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The ID of the user who last updated the accounting code. 
    /// </summary>
    /// <value>The ID of the user who last updated the accounting code. </value>
    [DataMember(Name="updatedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedBy")]
    public string UpdatedBy { get; set; }

    /// <summary>
    /// Date and time when the accounting code was last updated. 
    /// </summary>
    /// <value>Date and time when the accounting code was last updated. </value>
    [DataMember(Name="updatedOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedOn")]
    public DateTime? UpdatedOn { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountingCodeItemType {\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
      sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  GlAccountName: ").Append(GlAccountName).Append("\n");
      sb.Append("  GlAccountNumber: ").Append(GlAccountNumber).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
