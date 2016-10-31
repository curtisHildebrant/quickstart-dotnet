using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for basic information about the account. 
  /// </summary>
  [DataContract]
  public class GETAccountTypeBasicInfo {
    /// <summary>
    /// Account number. 
    /// </summary>
    /// <value>Account number. </value>
    [DataMember(Name="accountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// The alias name given to a batch. A string of 50 characters or less. 
    /// </summary>
    /// <value>The alias name given to a batch. A string of 50 characters or less. </value>
    [DataMember(Name="batch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "batch")]
    public string Batch { get; set; }

    /// <summary>
    /// ID of a [communication profile](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Communication_Profile). 
    /// </summary>
    /// <value>ID of a [communication profile](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Communication_Profile). </value>
    [DataMember(Name="communicationProfileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "communicationProfileId")]
    public string CommunicationProfileId { get; set; }

    /// <summary>
    /// CRM account ID for the account, 100 characters or less. 
    /// </summary>
    /// <value>CRM account ID for the account, 100 characters or less. </value>
    [DataMember(Name="crmId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "crmId")]
    public string CrmId { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Account ID. 
    /// </summary>
    /// <value>Account ID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Invoice template ID, configured in [Billing Settings in the Zuora UI](https://knowledgecenter.zuora.com/CB_Billing/IA_Invoices/Creating_a_Custom_Invoice_Template). 
    /// </summary>
    /// <value>Invoice template ID, configured in [Billing Settings in the Zuora UI](https://knowledgecenter.zuora.com/CB_Billing/IA_Invoices/Creating_a_Custom_Invoice_Template). </value>
    [DataMember(Name="invoiceTemplateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceTemplateId")]
    public string InvoiceTemplateId { get; set; }

    /// <summary>
    /// Account name. 
    /// </summary>
    /// <value>Account name. </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Notes associated with the account, up to 65,535 characters. 
    /// </summary>
    /// <value>Notes associated with the account, up to 65,535 characters. </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// Account status; possible values are: `Active`, `Draft`, `Canceled`. 
    /// </summary>
    /// <value>Account status; possible values are: `Active`, `Draft`, `Canceled`. </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public string Tags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountTypeBasicInfo {\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  Batch: ").Append(Batch).Append("\n");
      sb.Append("  CommunicationProfileId: ").Append(CommunicationProfileId).Append("\n");
      sb.Append("  CrmId: ").Append(CrmId).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InvoiceTemplateId: ").Append(InvoiceTemplateId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
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
