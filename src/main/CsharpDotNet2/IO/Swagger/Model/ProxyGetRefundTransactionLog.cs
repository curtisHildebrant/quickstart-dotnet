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
  public class ProxyGetRefundTransactionLog {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BatchId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BatchId")]
    public string BatchId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Gateway", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Gateway")]
    public string Gateway { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="GatewayReasonCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GatewayReasonCode")]
    public string GatewayReasonCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="GatewayReasonCodeDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GatewayReasonCodeDescription")]
    public string GatewayReasonCodeDescription { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="GatewayState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GatewayState")]
    public string GatewayState { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="GatewayTransactionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GatewayTransactionType")]
    public string GatewayTransactionType { get; set; }

    /// <summary>
    /// Object identifier.
    /// </summary>
    /// <value>Object identifier.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="RefundId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefundId")]
    public string RefundId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="RequestString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestString")]
    public string RequestString { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="ResponseString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ResponseString")]
    public string ResponseString { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="TransactionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransactionDate")]
    public DateTime? TransactionDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="TransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransactionId")]
    public string TransactionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetRefundTransactionLog {\n");
      sb.Append("  BatchId: ").Append(BatchId).Append("\n");
      sb.Append("  Gateway: ").Append(Gateway).Append("\n");
      sb.Append("  GatewayReasonCode: ").Append(GatewayReasonCode).Append("\n");
      sb.Append("  GatewayReasonCodeDescription: ").Append(GatewayReasonCodeDescription).Append("\n");
      sb.Append("  GatewayState: ").Append(GatewayState).Append("\n");
      sb.Append("  GatewayTransactionType: ").Append(GatewayTransactionType).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RefundId: ").Append(RefundId).Append("\n");
      sb.Append("  RequestString: ").Append(RequestString).Append("\n");
      sb.Append("  ResponseString: ").Append(ResponseString).Append("\n");
      sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
      sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
