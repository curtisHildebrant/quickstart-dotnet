using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// dummy
  /// </summary>
  [DataContract]
  public class GETAccountSummaryTypeBasicInfoDefaultPaymentMethod {
    /// <summary>
    /// Two-digit numeric card expiration month as `mm`. 
    /// </summary>
    /// <value>Two-digit numeric card expiration month as `mm`. </value>
    [DataMember(Name="creditCardExpirationMonth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creditCardExpirationMonth")]
    public string CreditCardExpirationMonth { get; set; }

    /// <summary>
    /// Four-digit card expiration year as `yyyy`. 
    /// </summary>
    /// <value>Four-digit card expiration year as `yyyy`. </value>
    [DataMember(Name="creditCardExpirationYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creditCardExpirationYear")]
    public string CreditCardExpirationYear { get; set; }

    /// <summary>
    /// Credit card number, 16 characters or less, displayed in masked format (e.g., ************1234). 
    /// </summary>
    /// <value>Credit card number, 16 characters or less, displayed in masked format (e.g., ************1234). </value>
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
    /// The ID of the credit card payment method associated with this account. 
    /// </summary>
    /// <value>The ID of the credit card payment method associated with this account. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="paymentMethodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethodType")]
    public string PaymentMethodType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountSummaryTypeBasicInfoDefaultPaymentMethod {\n");
      sb.Append("  CreditCardExpirationMonth: ").Append(CreditCardExpirationMonth).Append("\n");
      sb.Append("  CreditCardExpirationYear: ").Append(CreditCardExpirationYear).Append("\n");
      sb.Append("  CreditCardNumber: ").Append(CreditCardNumber).Append("\n");
      sb.Append("  CreditCardType: ").Append(CreditCardType).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
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
