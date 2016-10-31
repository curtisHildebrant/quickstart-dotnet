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
  public class PUTPaymentMethodType {
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
    /// The full name as it appears on the card, e.g., \"John J Smith\", 50 characters or less. 
    /// </summary>
    /// <value>The full name as it appears on the card, e.g., \"John J Smith\", 50 characters or less. </value>
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
    /// Country; must be a [valid country name or abbreviation](https://knowledgecenter.zuora.com/BC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/A_Country_Names_and_Their_ISO_Codes). 
    /// </summary>
    /// <value>Country; must be a [valid country name or abbreviation](https://knowledgecenter.zuora.com/BC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/A_Country_Names_and_Their_ISO_Codes). </value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Specify \"true\" to make this card the default payment method; otherwise, omit this parameter to keep the current default payment method. 
    /// </summary>
    /// <value>Specify \"true\" to make this card the default payment method; otherwise, omit this parameter to keep the current default payment method. </value>
    [DataMember(Name="defaultPaymentMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultPaymentMethod")]
    public bool? DefaultPaymentMethod { get; set; }

    /// <summary>
    /// Card holder's email address, 80 characters or less. 
    /// </summary>
    /// <value>Card holder's email address, 80 characters or less. </value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Two-digit expiration month (01-12). 
    /// </summary>
    /// <value>Two-digit expiration month (01-12). </value>
    [DataMember(Name="expirationMonth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expirationMonth")]
    public string ExpirationMonth { get; set; }

    /// <summary>
    /// Four-digit expiration year. 
    /// </summary>
    /// <value>Four-digit expiration year. </value>
    [DataMember(Name="expirationYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expirationYear")]
    public string ExpirationYear { get; set; }

    /// <summary>
    /// Phone number, 40 characters or less. 
    /// </summary>
    /// <value>Phone number, 40 characters or less. </value>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// The CVV or CVV2 security code for the credit card or debit card. Only required if changing expirationMonth, expirationYear, or cardHolderName. To ensure PCI compliance, this value isn't stored and can't be queried. For more information, see [How do I control what information Zuora sends over to the Payment Gateway](https://knowledgecenter.zuora.com/kb/How_do_I_control_what_information_Zuora_sends_over_to_the_payment_gateway_when_verifying_payment_methods%3F)? 
    /// </summary>
    /// <value>The CVV or CVV2 security code for the credit card or debit card. Only required if changing expirationMonth, expirationYear, or cardHolderName. To ensure PCI compliance, this value isn't stored and can't be queried. For more information, see [How do I control what information Zuora sends over to the Payment Gateway](https://knowledgecenter.zuora.com/kb/How_do_I_control_what_information_Zuora_sends_over_to_the_payment_gateway_when_verifying_payment_methods%3F)? </value>
    [DataMember(Name="securityCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityCode")]
    public string SecurityCode { get; set; }

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
      sb.Append("class PUTPaymentMethodType {\n");
      sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
      sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
      sb.Append("  CardHolderName: ").Append(CardHolderName).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  DefaultPaymentMethod: ").Append(DefaultPaymentMethod).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
      sb.Append("  ExpirationYear: ").Append(ExpirationYear).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
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
