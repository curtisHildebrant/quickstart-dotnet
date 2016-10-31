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
  public class POSTPaymentMethodType {
    /// <summary>
    /// ID of the customer account to update. 
    /// </summary>
    /// <value>ID of the customer account to update. </value>
    [DataMember(Name="accountKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountKey")]
    public string AccountKey { get; set; }

    /// <summary>
    /// Gets or Sets CardHolderInfo
    /// </summary>
    [DataMember(Name="cardHolderInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardHolderInfo")]
    public POSTPaymentMethodTypeCardHolderInfo CardHolderInfo { get; set; }

    /// <summary>
    /// Credit card number, a string of up to 16 characters. This field can only be set when creating a new payment method; it cannot be queried or updated. 
    /// </summary>
    /// <value>Credit card number, a string of up to 16 characters. This field can only be set when creating a new payment method; it cannot be queried or updated. </value>
    [DataMember(Name="creditCardNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creditCardNumber")]
    public string CreditCardNumber { get; set; }

    /// <summary>
    /// Possible values are: `Visa`, `MasterCard`, `AmericanExpress`, `Discover`. 
    /// </summary>
    /// <value>Possible values are: `Visa`, `MasterCard`, `AmericanExpress`, `Discover`. </value>
    [DataMember(Name="creditCardType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creditCardType")]
    public string CreditCardType { get; set; }

    /// <summary>
    /// Specify true to make this card the default payment method; otherwise, omit this parameter to keep the current default payment method. 
    /// </summary>
    /// <value>Specify true to make this card the default payment method; otherwise, omit this parameter to keep the current default payment method. </value>
    [DataMember(Name="defaultPaymentMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultPaymentMethod")]
    public bool? DefaultPaymentMethod { get; set; }

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
    /// The CVV or CVV2 security code for the credit card or debit card. Only required if changing expirationMonth, expirationYear, or cardHolderName. To ensure PCI compliance, this value isn't stored and can't be queried. For more information, see [How do I control what information Zuora sends over to the Payment Gateway?](https://knowledgecenter.zuora.com/kb/How_do_I_control_what_information_Zuora_sends_over_to_the_payment_gateway_when_verifying_payment_methods%3F) 
    /// </summary>
    /// <value>The CVV or CVV2 security code for the credit card or debit card. Only required if changing expirationMonth, expirationYear, or cardHolderName. To ensure PCI compliance, this value isn't stored and can't be queried. For more information, see [How do I control what information Zuora sends over to the Payment Gateway?](https://knowledgecenter.zuora.com/kb/How_do_I_control_what_information_Zuora_sends_over_to_the_payment_gateway_when_verifying_payment_methods%3F) </value>
    [DataMember(Name="securityCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityCode")]
    public string SecurityCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTPaymentMethodType {\n");
      sb.Append("  AccountKey: ").Append(AccountKey).Append("\n");
      sb.Append("  CardHolderInfo: ").Append(CardHolderInfo).Append("\n");
      sb.Append("  CreditCardNumber: ").Append(CreditCardNumber).Append("\n");
      sb.Append("  CreditCardType: ").Append(CreditCardType).Append("\n");
      sb.Append("  DefaultPaymentMethod: ").Append(DefaultPaymentMethod).Append("\n");
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
