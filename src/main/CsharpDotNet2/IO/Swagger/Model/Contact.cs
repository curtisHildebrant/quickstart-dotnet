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
  public class Contact {
    /// <summary>
    ///  The Zuora account ID associated with this contact. This field is not required when you use the subscribe() call. This field is required for all other calls. **Character limit: **32 **Values: **[a valid account ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account#Id) 
    /// </summary>
    /// <value> The Zuora account ID associated with this contact. This field is not required when you use the subscribe() call. This field is required for all other calls. **Character limit: **32 **Values: **[a valid account ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account#Id) </value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public string AccountId { get; set; }

    /// <summary>
    ///  The first line of the contact's address, which is often a street address or business name. **Character limit**: 255 **Values**: a string of 255 characters or fewer 
    /// </summary>
    /// <value> The first line of the contact's address, which is often a street address or business name. **Character limit**: 255 **Values**: a string of 255 characters or fewer </value>
    [DataMember(Name="Address1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Address1")]
    public string Address1 { get; set; }

    /// <summary>
    ///  The second line of the contact's address. **Character limit**: 255 **Values**: a string of 255 characters or fewer 
    /// </summary>
    /// <value> The second line of the contact's address. **Character limit**: 255 **Values**: a string of 255 characters or fewer </value>
    [DataMember(Name="Address2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Address2")]
    public string Address2 { get; set; }

    /// <summary>
    ///  The city of the contact's address. **Character limit**: 40 **Values: **a string of 40 characters or fewer 
    /// </summary>
    /// <value> The city of the contact's address. **Character limit**: 40 **Values: **a string of 40 characters or fewer </value>
    [DataMember(Name="City", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "City")]
    public string City { get; set; }

    /// <summary>
    ///  The country of the contact's address. If using [a valid country name or abbreviation](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes) 
    /// </summary>
    /// <value> The country of the contact's address. If using [a valid country name or abbreviation](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes) </value>
    [DataMember(Name="Country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Country")]
    public string Country { get; set; }

    /// <summary>
    ///  The country. May optionally be used by [Z-Tax](/C_Zuora_User_Guides/A_Billing_and_Payments/I_Taxes/Z-Tax) to calculate county tax. **Character limit**: 32 **Values**: a string of 32 characters or fewer 
    /// </summary>
    /// <value> The country. May optionally be used by [Z-Tax](/C_Zuora_User_Guides/A_Billing_and_Payments/I_Taxes/Z-Tax) to calculate county tax. **Character limit**: 32 **Values**: a string of 32 characters or fewer </value>
    [DataMember(Name="County", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "County")]
    public string County { get; set; }

    /// <summary>
    /// The ID of the Zuora user who created the contact. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value>The ID of the Zuora user who created the contact. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    /// The date when the contact was created. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value>The date when the contact was created. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    ///  A description for the contact. **Character limit**: 100 **Values**: a string of 100 characters or fewer 
    /// </summary>
    /// <value> A description for the contact. **Character limit**: 100 **Values**: a string of 100 characters or fewer </value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    ///  The contact's fax number. **Character limit**: 40 **Values**: a string of 40 characters or fewer 
    /// </summary>
    /// <value> The contact's fax number. **Character limit**: 40 **Values**: a string of 40 characters or fewer </value>
    [DataMember(Name="Fax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Fax")]
    public string Fax { get; set; }

    /// <summary>
    ///  The contact's first name. **Character limit**: 100 **Values**: a string of the contact's first name 
    /// </summary>
    /// <value> The contact's first name. **Character limit**: 100 **Values**: a string of the contact's first name </value>
    [DataMember(Name="FirstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FirstName")]
    public string FirstName { get; set; }

    /// <summary>
    ///  The contact's home phone number. **Character limit**: 40 **Values**: a string of 40 characters or fewer 
    /// </summary>
    /// <value> The contact's home phone number. **Character limit**: 40 **Values**: a string of 40 characters or fewer </value>
    [DataMember(Name="HomePhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HomePhone")]
    public string HomePhone { get; set; }

    /// <summary>
    ///  The ID of this object. Upon creation of this object, this field becomes `ContactId`. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of this object. Upon creation of this object, this field becomes `ContactId`. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    ///  The contact's last name. **Character limit**: 100 **Values**: a string of 100 characters or fewer 
    /// </summary>
    /// <value> The contact's last name. **Character limit**: 100 **Values**: a string of 100 characters or fewer </value>
    [DataMember(Name="LastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastName")]
    public string LastName { get; set; }

    /// <summary>
    ///  The contact's mobile phone number. **Character limit**: 40 **Values**: a string of 40 characters or fewer 
    /// </summary>
    /// <value> The contact's mobile phone number. **Character limit**: 40 **Values**: a string of 40 characters or fewer </value>
    [DataMember(Name="MobilePhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MobilePhone")]
    public string MobilePhone { get; set; }

    /// <summary>
    ///  A nickname for the contact. **Character limit**: 100 **Values**: a string of 100 characters or fewer 
    /// </summary>
    /// <value> A nickname for the contact. **Character limit**: 100 **Values**: a string of 100 characters or fewer </value>
    [DataMember(Name="NickName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NickName")]
    public string NickName { get; set; }

    /// <summary>
    ///  An additional phone number for the contact. **Character limit**: 40 **Values**: a string of 40 characters or fewer 
    /// </summary>
    /// <value> An additional phone number for the contact. **Character limit**: 40 **Values**: a string of 40 characters or fewer </value>
    [DataMember(Name="OtherPhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherPhone")]
    public string OtherPhone { get; set; }

    /// <summary>
    /// The type of the `OtherPhone`. **Character limit**: 20 **Values**: `Work`, `Mobile`, `Home`, `Other` 
    /// </summary>
    /// <value>The type of the `OtherPhone`. **Character limit**: 20 **Values**: `Work`, `Mobile`, `Home`, `Other` </value>
    [DataMember(Name="OtherPhoneType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherPhoneType")]
    public string OtherPhoneType { get; set; }

    /// <summary>
    ///  The contact's personal email address. **Character limit**: 80 **Values**: a string of 80 characters or fewer 
    /// </summary>
    /// <value> The contact's personal email address. **Character limit**: 80 **Values**: a string of 80 characters or fewer </value>
    [DataMember(Name="PersonalEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PersonalEmail")]
    public string PersonalEmail { get; set; }

    /// <summary>
    ///  The zip code for the contact's address. **Character limit:** 20 **Values: **a string of 20 characters or fewer 
    /// </summary>
    /// <value> The zip code for the contact's address. **Character limit:** 20 **Values: **a string of 20 characters or fewer </value>
    [DataMember(Name="PostalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PostalCode")]
    public string PostalCode { get; set; }

    /// <summary>
    ///  The state or province of the contact's address. If using [a valid state name or abbreviation](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/B_State_Names_and_2-Digit_Codes) 
    /// </summary>
    /// <value> The state or province of the contact's address. If using [a valid state name or abbreviation](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/B_State_Names_and_2-Digit_Codes) </value>
    [DataMember(Name="State", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "State")]
    public string State { get; set; }

    /// <summary>
    /// If using [Z-Tax](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax) tax rules 
    /// </summary>
    /// <value>If using [Z-Tax](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax) tax rules </value>
    [DataMember(Name="TaxRegion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxRegion")]
    public string TaxRegion { get; set; }

    /// <summary>
    ///  The ID of the user who lasted updated the contact. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the user who lasted updated the contact. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    ///  The date when the contact was last updated. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the contact was last updated. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }

    /// <summary>
    ///  The contact's business email address. **Character limit**: 80 **Values**: a string of 80 characters or fewer 
    /// </summary>
    /// <value> The contact's business email address. **Character limit**: 80 **Values**: a string of 80 characters or fewer </value>
    [DataMember(Name="WorkEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WorkEmail")]
    public string WorkEmail { get; set; }

    /// <summary>
    ///  The contact's business phone number. **Character limit**: 40 **notes**: -- **Values**: a string of 40 characters or fewer 
    /// </summary>
    /// <value> The contact's business phone number. **Character limit**: 40 **notes**: -- **Values**: a string of 40 characters or fewer </value>
    [DataMember(Name="WorkPhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WorkPhone")]
    public string WorkPhone { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="fieldsToNull", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldsToNull")]
    public string FieldsToNull { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Contact {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  Address1: ").Append(Address1).Append("\n");
      sb.Append("  Address2: ").Append(Address2).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  County: ").Append(County).Append("\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Fax: ").Append(Fax).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  HomePhone: ").Append(HomePhone).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
      sb.Append("  NickName: ").Append(NickName).Append("\n");
      sb.Append("  OtherPhone: ").Append(OtherPhone).Append("\n");
      sb.Append("  OtherPhoneType: ").Append(OtherPhoneType).Append("\n");
      sb.Append("  PersonalEmail: ").Append(PersonalEmail).Append("\n");
      sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  TaxRegion: ").Append(TaxRegion).Append("\n");
      sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
      sb.Append("  WorkEmail: ").Append(WorkEmail).Append("\n");
      sb.Append("  WorkPhone: ").Append(WorkPhone).Append("\n");
      sb.Append("  FieldsToNull: ").Append(FieldsToNull).Append("\n");
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
