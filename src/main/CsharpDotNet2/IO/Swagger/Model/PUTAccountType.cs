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
  public class PUTAccountType {
    /// <summary>
    /// Specifies whether future payments are to be automatically billed when they are due. Possible values are: `true`, `false`. 
    /// </summary>
    /// <value>Specifies whether future payments are to be automatically billed when they are due. Possible values are: `true`, `false`. </value>
    [DataMember(Name="autoPay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoPay")]
    public bool? AutoPay { get; set; }

    /// <summary>
    /// The alias name given to a batch. A string of 50 characters or less. 
    /// </summary>
    /// <value>The alias name given to a batch. A string of 50 characters or less. </value>
    [DataMember(Name="batch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "batch")]
    public string Batch { get; set; }

    /// <summary>
    /// Gets or Sets BillToContact
    /// </summary>
    [DataMember(Name="billToContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billToContact")]
    public PUTAccountTypeBillToContact BillToContact { get; set; }

    /// <summary>
    /// The ID of a [communication profile](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Communication_Profile). 
    /// </summary>
    /// <value>The ID of a [communication profile](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Communication_Profile). </value>
    [DataMember(Name="communicationProfileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "communicationProfileId")]
    public string CommunicationProfileId { get; set; }

    /// <summary>
    /// CRM account ID for the account, up to 100 characters. 
    /// </summary>
    /// <value>CRM account ID for the account, up to 100 characters. </value>
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
    /// Invoice template ID, configured in [Billing Settings in the Zuora UI](https://knowledgecenter.zuora.com/CB_Billing/IA_Invoices/Creating_a_Custom_Invoice_Template). 
    /// </summary>
    /// <value>Invoice template ID, configured in [Billing Settings in the Zuora UI](https://knowledgecenter.zuora.com/CB_Billing/IA_Invoices/Creating_a_Custom_Invoice_Template). </value>
    [DataMember(Name="invoiceTemplateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceTemplateId")]
    public string InvoiceTemplateId { get; set; }

    /// <summary>
    /// Account name, up to 255 characters. 
    /// </summary>
    /// <value>Account name, up to 255 characters. </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A string of up to 65,535 characters. 
    /// </summary>
    /// <value>A string of up to 65,535 characters. </value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// The name of the payment gateway instance. If null or left unassigned, the Account will use the Default Gateway. 
    /// </summary>
    /// <value>The name of the payment gateway instance. If null or left unassigned, the Account will use the Default Gateway. </value>
    [DataMember(Name="paymentGateway", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentGateway")]
    public string PaymentGateway { get; set; }

    /// <summary>
    /// Gets or Sets SoldToContact
    /// </summary>
    [DataMember(Name="soldToContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "soldToContact")]
    public PUTAccountTypeSoldToContact SoldToContact { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="tagging", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tagging")]
    public string Tagging { get; set; }

    /// <summary>
    /// Gets or Sets TaxInfo
    /// </summary>
    [DataMember(Name="taxInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxInfo")]
    public POSTAccountTypeTaxInfo TaxInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PUTAccountType {\n");
      sb.Append("  AutoPay: ").Append(AutoPay).Append("\n");
      sb.Append("  Batch: ").Append(Batch).Append("\n");
      sb.Append("  BillToContact: ").Append(BillToContact).Append("\n");
      sb.Append("  CommunicationProfileId: ").Append(CommunicationProfileId).Append("\n");
      sb.Append("  CrmId: ").Append(CrmId).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  InvoiceTemplateId: ").Append(InvoiceTemplateId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  PaymentGateway: ").Append(PaymentGateway).Append("\n");
      sb.Append("  SoldToContact: ").Append(SoldToContact).Append("\n");
      sb.Append("  Tagging: ").Append(Tagging).Append("\n");
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
