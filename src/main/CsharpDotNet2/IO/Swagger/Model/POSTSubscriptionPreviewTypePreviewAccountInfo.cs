using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A container for providing a customer account information if you do not have an existing customer account. This customer account information is only used for subscription preview.  You must specify the account information either in this field or in the &#x60;accountKey&#x60; field with the following conditions:  * If you already have a customer account, specify the account number or ID in the accountKey field. * If you do not have a customer account, provide account information in this field. 
  /// </summary>
  [DataContract]
  public class POSTSubscriptionPreviewTypePreviewAccountInfo {
    /// <summary>
    /// The account's bill cycle day (BCD), when bill runs generate invoices for the account. Specify any day of the month (`1`-`31`, where `31` = end-of-month), or `0` for auto-set. 
    /// </summary>
    /// <value>The account's bill cycle day (BCD), when bill runs generate invoices for the account. Specify any day of the month (`1`-`31`, where `31` = end-of-month), or `0` for auto-set. </value>
    [DataMember(Name="billCycleDay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billCycleDay")]
    public long? BillCycleDay { get; set; }

    /// <summary>
    /// Gets or Sets BillToContact
    /// </summary>
    [DataMember(Name="billToContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billToContact")]
    public POSTSubscriptionPreviewTypePreviewAccountInfoBillToContact BillToContact { get; set; }

    /// <summary>
    /// A currency as defined in (Billing Settings)[https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Customize_Currencies]. 
    /// </summary>
    /// <value>A currency as defined in (Billing Settings)[https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Customize_Currencies]. </value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTSubscriptionPreviewTypePreviewAccountInfo {\n");
      sb.Append("  BillCycleDay: ").Append(BillCycleDay).Append("\n");
      sb.Append("  BillToContact: ").Append(BillToContact).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
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
