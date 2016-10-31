using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for billing and payment information for the account. 
  /// </summary>
  [DataContract]
  public class GETAccountTypeBillingAndPayment {
    /// <summary>
    /// Billing cycle day (BCD), the day of the month when a bill run generates invoices for the account. 
    /// </summary>
    /// <value>Billing cycle day (BCD), the day of the month when a bill run generates invoices for the account. </value>
    [DataMember(Name="billCycleDay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billCycleDay")]
    public string BillCycleDay { get; set; }

    /// <summary>
    /// A currency defined in the [administrative web-based UI](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Customize_Currencies). 
    /// </summary>
    /// <value>A currency defined in the [administrative web-based UI](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Customize_Currencies). </value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// The name of the payment gateway instance. If null or left unassigned, the Account will use the Default Gateway. 
    /// </summary>
    /// <value>The name of the payment gateway instance. If null or left unassigned, the Account will use the Default Gateway. </value>
    [DataMember(Name="paymentGateway", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentGateway")]
    public string PaymentGateway { get; set; }

    /// <summary>
    /// A payment-terms indicator defined in the [web-based UI administrative settings](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Payment_Terms), e.g., \"Net 30\". 
    /// </summary>
    /// <value>A payment-terms indicator defined in the [web-based UI administrative settings](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Payment_Terms), e.g., \"Net 30\". </value>
    [DataMember(Name="paymentTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentTerm")]
    public string PaymentTerm { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountTypeBillingAndPayment {\n");
      sb.Append("  BillCycleDay: ").Append(BillCycleDay).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  PaymentGateway: ").Append(PaymentGateway).Append("\n");
      sb.Append("  PaymentTerm: ").Append(PaymentTerm).Append("\n");
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
