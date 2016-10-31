using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for information on a credit card to associate with this account. You must provide either this structure or the &#x60;hpmCreditCardPaymentMethodId&#x60; field, but not both. 
  /// </summary>
  [DataContract]
  public class POSTAccountTypeCreditCard {
    /// <summary>
    /// Gets or Sets CardHolderInfo
    /// </summary>
    [DataMember(Name="cardHolderInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardHolderInfo")]
    public POSTAccountTypeCreditCardCardHolderInfo CardHolderInfo { get; set; }

    /// <summary>
    /// Card number, up to 16 characters. Once created, this field can't be updated or queried, and is only available in masked format (e.g., XXXX-XXXX-XXXX-1234). 
    /// </summary>
    /// <value>Card number, up to 16 characters. Once created, this field can't be updated or queried, and is only available in masked format (e.g., XXXX-XXXX-XXXX-1234). </value>
    [DataMember(Name="cardNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardNumber")]
    public string CardNumber { get; set; }

    /// <summary>
    /// Possible values are: `Visa`, `MasterCard`, `AmericanExpress`, `Discover`. 
    /// </summary>
    /// <value>Possible values are: `Visa`, `MasterCard`, `AmericanExpress`, `Discover`. </value>
    [DataMember(Name="cardType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardType")]
    public string CardType { get; set; }

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
    /// The CVV or CVV2 security code of the card. To ensure PCI compliance, this value isn't stored and can't be queried. For more information, see [How do I control what information Zuora sends over to the Payment Gateway?](https://knowledgecenter.zuora.com/kb/How_do_I_control_information_sent_to_payment_gateways_when_verifying_payment_methods%3F). 
    /// </summary>
    /// <value>The CVV or CVV2 security code of the card. To ensure PCI compliance, this value isn't stored and can't be queried. For more information, see [How do I control what information Zuora sends over to the Payment Gateway?](https://knowledgecenter.zuora.com/kb/How_do_I_control_information_sent_to_payment_gateways_when_verifying_payment_methods%3F). </value>
    [DataMember(Name="securityCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityCode")]
    public string SecurityCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTAccountTypeCreditCard {\n");
      sb.Append("  CardHolderInfo: ").Append(CardHolderInfo).Append("\n");
      sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
      sb.Append("  CardType: ").Append(CardType).Append("\n");
      sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
      sb.Append("  ExpirationYear: ").Append(ExpirationYear).Append("\n");
      sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
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
