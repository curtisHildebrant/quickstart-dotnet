using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for cardholder information. If provided, Zuora will only use this information for this card.  If not provided, Zuora will use the account&#39;s existing bill-to contact information for this card. 
  /// </summary>
  [DataContract]
  public class POSTPaymentMethodTypeCardHolderInfo {
    /// <summary>
    /// First address line, 255 characters or less. 
    /// </summary>
    /// <value>First address line, 255 characters or less. </value>
    [DataMember(Name="addressLine1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressLine1")]
    public string AddressLine1 { get; set; }

    /// <summary>
    /// Second address line, 255 characters or less. 
    /// </summary>
    /// <value>Second address line, 255 characters or less. </value>
    [DataMember(Name="addressLine2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressLine2")]
    public string AddressLine2 { get; set; }

    /// <summary>
    /// The card holder's full name as it appears on the card, e.g., \"John J Smith\", 50 characters or less. 
    /// </summary>
    /// <value>The card holder's full name as it appears on the card, e.g., \"John J Smith\", 50 characters or less. </value>
    [DataMember(Name="cardHolderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardHolderName")]
    public string CardHolderName { get; set; }

    /// <summary>
    /// City, 40 characters or less. 
    /// </summary>
    /// <value>City, 40 characters or less. </value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// Country, must be a [valid country name or abbreviation](https://knowledgecenter.zuora.com/BC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/A_Country_Names_and_Their_ISO_Codes). 
    /// </summary>
    /// <value>Country, must be a [valid country name or abbreviation](https://knowledgecenter.zuora.com/BC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/A_Country_Names_and_Their_ISO_Codes). </value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Card holder's email address, 80 characters or less. 
    /// </summary>
    /// <value>Card holder's email address, 80 characters or less. </value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Phone number, 40 characters or less. 
    /// </summary>
    /// <value>Phone number, 40 characters or less. </value>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// State; must be a [valid state name or 2-character abbreviation](https://knowledgecenter.zuora.com/BC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/B_State_Names_and_2-Digit_Codes). 
    /// </summary>
    /// <value>State; must be a [valid state name or 2-character abbreviation](https://knowledgecenter.zuora.com/BC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/B_State_Names_and_2-Digit_Codes). </value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

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
      sb.Append("class POSTPaymentMethodTypeCardHolderInfo {\n");
      sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
      sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
      sb.Append("  CardHolderName: ").Append(CardHolderName).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
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
