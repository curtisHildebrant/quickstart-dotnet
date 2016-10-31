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
  public class GETCalloutHistoryVOType {
    /// <summary>
    /// The number of times the callout was retried. 
    /// </summary>
    /// <value>The number of times the callout was retried. </value>
    [DataMember(Name="attemptedNum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attemptedNum")]
    public string AttemptedNum { get; set; }

    /// <summary>
    /// The time that the calloutHistory record was made. 
    /// </summary>
    /// <value>The time that the calloutHistory record was made. </value>
    [DataMember(Name="createTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createTime")]
    public string CreateTime { get; set; }

    /// <summary>
    /// The [event category](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Notification_History/Z_Event_Categories) for the callout. 
    /// </summary>
    /// <value>The [event category](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Notification_History/Z_Event_Categories) for the callout. </value>
    [DataMember(Name="eventCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventCategory")]
    public string EventCategory { get; set; }

    /// <summary>
    /// The context of the callout event. 
    /// </summary>
    /// <value>The context of the callout event. </value>
    [DataMember(Name="eventContext", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventContext")]
    public string EventContext { get; set; }

    /// <summary>
    /// The name of the [notification](https://knowledgecenter.zuora.com/BB_Introducing_Z_Business/Notifications). 
    /// </summary>
    /// <value>The name of the [notification](https://knowledgecenter.zuora.com/BB_Introducing_Z_Business/Notifications). </value>
    [DataMember(Name="notification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notification")]
    public string Notification { get; set; }

    /// <summary>
    /// The request method set in [notifications settings](https://knowledgecenter.zuora.com/BB_Introducing_Z_Business/Notifications/C_Create_Notifications). 
    /// </summary>
    /// <value>The request method set in [notifications settings](https://knowledgecenter.zuora.com/BB_Introducing_Z_Business/Notifications/C_Create_Notifications). </value>
    [DataMember(Name="requestMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestMethod")]
    public string RequestMethod { get; set; }

    /// <summary>
    /// The base url set in [notifications settings](https://knowledgecenter.zuora.com/BB_Introducing_Z_Business/Notifications). 
    /// </summary>
    /// <value>The base url set in [notifications settings](https://knowledgecenter.zuora.com/BB_Introducing_Z_Business/Notifications). </value>
    [DataMember(Name="requestUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestUrl")]
    public string RequestUrl { get; set; }

    /// <summary>
    /// The responseCode of the request. 
    /// </summary>
    /// <value>The responseCode of the request. </value>
    [DataMember(Name="responseCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responseCode")]
    public string ResponseCode { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="responseContent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responseContent")]
    public string ResponseContent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETCalloutHistoryVOType {\n");
      sb.Append("  AttemptedNum: ").Append(AttemptedNum).Append("\n");
      sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
      sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
      sb.Append("  EventContext: ").Append(EventContext).Append("\n");
      sb.Append("  Notification: ").Append(Notification).Append("\n");
      sb.Append("  RequestMethod: ").Append(RequestMethod).Append("\n");
      sb.Append("  RequestUrl: ").Append(RequestUrl).Append("\n");
      sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
      sb.Append("  ResponseContent: ").Append(ResponseContent).Append("\n");
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
