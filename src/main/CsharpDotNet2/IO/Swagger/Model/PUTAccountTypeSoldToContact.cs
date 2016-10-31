using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for optional sold-to contact. 
  /// </summary>
  [DataContract]
  public class PUTAccountTypeSoldToContact {
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
    /// Country; must be a valid country name or abbreviation. If using [Z-Tax](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax), must specify a country in the sold-to contact to calculate tax. A bill-to contact may be used if no sold-to contact is provided. 
    /// </summary>
    /// <value>Country; must be a valid country name or abbreviation. If using [Z-Tax](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax), must specify a country in the sold-to contact to calculate tax. A bill-to contact may be used if no sold-to contact is provided. </value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// County; 32 characters or less. May optionally be used by [Z-Tax](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax) to calculate county tax. 
    /// </summary>
    /// <value>County; 32 characters or less. May optionally be used by [Z-Tax](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax) to calculate county tax. </value>
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
    /// Home phone number, 40 characters or less. 
    /// </summary>
    /// <value>Home phone number, 40 characters or less. </value>
    [DataMember(Name="homePhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "homePhone")]
    public string HomePhone { get; set; }

    /// <summary>
    /// Last name, 100 characters or less. 
    /// </summary>
    /// <value>Last name, 100 characters or less. </value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Mobile phone number, 40 characters or less. 
    /// </summary>
    /// <value>Mobile phone number, 40 characters or less. </value>
    [DataMember(Name="mobilePhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobilePhone")]
    public string MobilePhone { get; set; }

    /// <summary>
    /// Nickname for this contact 
    /// </summary>
    /// <value>Nickname for this contact </value>
    [DataMember(Name="nickname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nickname")]
    public string Nickname { get; set; }

    /// <summary>
    /// Other phone number, 40 characters or less. 
    /// </summary>
    /// <value>Other phone number, 40 characters or less. </value>
    [DataMember(Name="otherPhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "otherPhone")]
    public string OtherPhone { get; set; }

    /// <summary>
    /// Possible values are: `Work`, `Mobile`, `Home`, `Other`. 
    /// </summary>
    /// <value>Possible values are: `Work`, `Mobile`, `Home`, `Other`. </value>
    [DataMember(Name="otherPhoneType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "otherPhoneType")]
    public string OtherPhoneType { get; set; }

    /// <summary>
    /// Personal email address, 80 characters or less. 
    /// </summary>
    /// <value>Personal email address, 80 characters or less. </value>
    [DataMember(Name="personalEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "personalEmail")]
    public string PersonalEmail { get; set; }

    /// <summary>
    /// State; must be a valid state or province name or 2-character abbreviation. If using Z-Tax, be aware that [Z-Tax](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax) requires a state (in the US) or province (in Canada) in this field for the sold-to contact to calculate tax, and that a bill-to contact may be used if no sold-to contact is provided. 
    /// </summary>
    /// <value>State; must be a valid state or province name or 2-character abbreviation. If using Z-Tax, be aware that [Z-Tax](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax) requires a state (in the US) or province (in Canada) in this field for the sold-to contact to calculate tax, and that a bill-to contact may be used if no sold-to contact is provided. </value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// If using [Z-Tax](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax), a region string as optionally defined in your tax rules. Not required. 
    /// </summary>
    /// <value>If using [Z-Tax](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax), a region string as optionally defined in your tax rules. Not required. </value>
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
      sb.Append("class PUTAccountTypeSoldToContact {\n");
      sb.Append("  Address1: ").Append(Address1).Append("\n");
      sb.Append("  Address2: ").Append(Address2).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  County: ").Append(County).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  Fax: ").Append(Fax).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  HomePhone: ").Append(HomePhone).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
      sb.Append("  Nickname: ").Append(Nickname).Append("\n");
      sb.Append("  OtherPhone: ").Append(OtherPhone).Append("\n");
      sb.Append("  OtherPhoneType: ").Append(OtherPhoneType).Append("\n");
      sb.Append("  PersonalEmail: ").Append(PersonalEmail).Append("\n");
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
