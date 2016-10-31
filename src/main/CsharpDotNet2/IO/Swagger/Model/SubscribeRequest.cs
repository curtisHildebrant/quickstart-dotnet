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
  public class SubscribeRequest {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Account")]
    public Account Account { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BillToContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillToContact")]
    public Contact BillToContact { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentMethod")]
    public PaymentMethod PaymentMethod { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PreviewOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PreviewOptions")]
    public PreviewOptions PreviewOptions { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="SoldToContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SoldToContact")]
    public Contact SoldToContact { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="SubscribeOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubscribeOptions")]
    public SubscribeOptions SubscribeOptions { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="SubscriptionData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubscriptionData")]
    public SubscriptionData SubscriptionData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscribeRequest {\n");
      sb.Append("  Account: ").Append(Account).Append("\n");
      sb.Append("  BillToContact: ").Append(BillToContact).Append("\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
      sb.Append("  PreviewOptions: ").Append(PreviewOptions).Append("\n");
      sb.Append("  SoldToContact: ").Append(SoldToContact).Append("\n");
      sb.Append("  SubscribeOptions: ").Append(SubscribeOptions).Append("\n");
      sb.Append("  SubscriptionData: ").Append(SubscriptionData).Append("\n");
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
