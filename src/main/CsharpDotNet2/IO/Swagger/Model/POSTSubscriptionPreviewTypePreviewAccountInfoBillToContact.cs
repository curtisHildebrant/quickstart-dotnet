using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for bill-to contact information of this account. 
  /// </summary>
  [DataContract]
  public class POSTSubscriptionPreviewTypePreviewAccountInfoBillToContact {
    /// <summary>
    /// The city of the bill-to address. The value should be 40 characters or less. 
    /// </summary>
    /// <value>The city of the bill-to address. The value should be 40 characters or less. </value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// The country of the bill-to address. The value must be a valid [country name or abbreviation](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/A_Country_Names_and_Their_ISO_Codes). 
    /// </summary>
    /// <value>The country of the bill-to address. The value must be a valid [country name or abbreviation](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/A_Country_Names_and_Their_ISO_Codes). </value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// The county of the bill-to address. The value should be 32 characters or less. 
    /// </summary>
    /// <value>The county of the bill-to address. The value should be 32 characters or less. </value>
    [DataMember(Name="county", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "county")]
    public string County { get; set; }

    /// <summary>
    /// The state of the bill-to address. The value must be a valid state or province name or 2-character abbreviation. 
    /// </summary>
    /// <value>The state of the bill-to address. The value must be a valid state or province name or 2-character abbreviation. </value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// If using [Z-Tax](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax), a region string as optionally defined in your tax rules. 
    /// </summary>
    /// <value>If using [Z-Tax](https://knowledgecenter.zuora.com/CB_Billing/J_Billing_Operations/L_Taxes/A_Z-Tax), a region string as optionally defined in your tax rules. </value>
    [DataMember(Name="taxRegion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxRegion")]
    public string TaxRegion { get; set; }

    /// <summary>
    /// The zip code of the bill-to address. The value should be 20 characters or less. 
    /// </summary>
    /// <value>The zip code of the bill-to address. The value should be 20 characters or less. </value>
    [DataMember(Name="zipCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zipCode")]
    public string ZipCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTSubscriptionPreviewTypePreviewAccountInfoBillToContact {\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  County: ").Append(County).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  TaxRegion: ").Append(TaxRegion).Append("\n");
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
