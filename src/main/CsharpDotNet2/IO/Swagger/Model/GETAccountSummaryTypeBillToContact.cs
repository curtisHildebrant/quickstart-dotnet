using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for bill-to contact information.
  /// </summary>
  [DataContract]
  public class GETAccountSummaryTypeBillToContact {
    /// <summary>
    /// First address line, 255 characters or less. 
    /// </summary>
    /// <value>First address line, 255 characters or less. </value>
    [DataMember(Name="address1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address1")]
    public string Address1 { get; set; }

    /// <summary>
    /// Second address line, 255 characters or less. 
    /// </summary>
    /// <value>Second address line, 255 characters or less. </value>
    [DataMember(Name="address2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address2")]
    public string Address2 { get; set; }

    /// <summary>
    /// City, 40 characters or less. 
    /// </summary>
    /// <value>City, 40 characters or less. </value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// [A valid country name or abbreviation](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/A_Country_Names_and_Their_ISO_Codes). 
    /// </summary>
    /// <value>[A valid country name or abbreviation](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/A_Country_Names_and_Their_ISO_Codes). </value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// County; 32 characters or less. [Z-Tax](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax) uses this information to calculate county taxation.           
    /// </summary>
    /// <value>County; 32 characters or less. [Z-Tax](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax) uses this information to calculate county taxation.           </value>
    [DataMember(Name="county", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "county")]
    public string County { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Fax phone number, 40 characters or less. 
    /// </summary>
    /// <value>Fax phone number, 40 characters or less. </value>
    [DataMember(Name="fax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fax")]
    public string Fax { get; set; }

    /// <summary>
    /// First name, 100 characters or less. 
    /// </summary>
    /// <value>First name, 100 characters or less. </value>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Contact ID. 
    /// </summary>
    /// <value>Contact ID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Last name, 100 characters or less. 
    /// </summary>
    /// <value>Last name, 100 characters or less. </value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// [State name or 2-character abbreviation](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/B_State_Names_and_2-Digit_Codes). 
    /// </summary>
    /// <value>[State name or 2-character abbreviation](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/B_State_Names_and_2-Digit_Codes). </value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// A region string, defined in your [Z-Tax](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax) tax rules. 
    /// </summary>
    /// <value>A region string, defined in your [Z-Tax](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax) tax rules. </value>
    [DataMember(Name="taxRegion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxRegion")]
    public string TaxRegion { get; set; }

    /// <summary>
    /// Work email address, 80 characters or less. 
    /// </summary>
    /// <value>Work email address, 80 characters or less. </value>
    [DataMember(Name="workEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workEmail")]
    public string WorkEmail { get; set; }

    /// <summary>
    /// Work phone number, 40 characters or less. 
    /// </summary>
    /// <value>Work phone number, 40 characters or less. </value>
    [DataMember(Name="workPhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workPhone")]
    public string WorkPhone { get; set; }

    /// <summary>
    /// Zip code, 20 characters or less. 
    /// </summary>
    /// <value>Zip code, 20 characters or less. </value>
    [DataMember(Name="zipCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zipCode")]
    public string ZipCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountSummaryTypeBillToContact {\n");
      sb.Append("  Address1: ").Append(Address1).Append("\n");
      sb.Append("  Address2: ").Append(Address2).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  County: ").Append(County).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  Fax: ").Append(Fax).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  TaxRegion: ").Append(TaxRegion).Append("\n");
      sb.Append("  WorkEmail: ").Append(WorkEmail).Append("\n");
      sb.Append("  WorkPhone: ").Append(WorkPhone).Append("\n");
      sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
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
