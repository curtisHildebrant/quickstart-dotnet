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
  public class GETEmailHistoryVOType {
    /// <summary>
    /// Blind carbon copy recipients of the email. 
    /// </summary>
    /// <value>Blind carbon copy recipients of the email. </value>
    [DataMember(Name="bcc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bcc")]
    public string Bcc { get; set; }

    /// <summary>
    /// Carbon Copy recipients of the email. 
    /// </summary>
    /// <value>Carbon Copy recipients of the email. </value>
    [DataMember(Name="cc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cc")]
    public string Cc { get; set; }

    /// <summary>
    /// null if the content of result is \"OK\". A description of the error if the content of result is not \"OK\". 
    /// </summary>
    /// <value>null if the content of result is \"OK\". A description of the error if the content of result is not \"OK\". </value>
    [DataMember(Name="errorMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorMessage")]
    public string ErrorMessage { get; set; }

    /// <summary>
    /// The [event category](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Notification_History/Z_Event_Categories) of the email. 
    /// </summary>
    /// <value>The [event category](https://knowledgecenter.zuora.com/DC_Developers/REST_API/B_REST_API_reference/Notification_History/Z_Event_Categories) of the email. </value>
    [DataMember(Name="eventCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventCategory")]
    public string EventCategory { get; set; }

    /// <summary>
    /// The sender of the email. 
    /// </summary>
    /// <value>The sender of the email. </value>
    [DataMember(Name="fromEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fromEmail")]
    public string FromEmail { get; set; }

    /// <summary>
    /// The name of the notification. 
    /// </summary>
    /// <value>The name of the notification. </value>
    [DataMember(Name="notification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notification")]
    public string Notification { get; set; }

    /// <summary>
    /// The reply-to address as configured in the email template. 
    /// </summary>
    /// <value>The reply-to address as configured in the email template. </value>
    [DataMember(Name="replyTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replyTo")]
    public string ReplyTo { get; set; }

    /// <summary>
    /// The result from the mail server of sending the email. 
    /// </summary>
    /// <value>The result from the mail server of sending the email. </value>
    [DataMember(Name="result", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "result")]
    public string Result { get; set; }

    /// <summary>
    /// The date and time the email was sent. 
    /// </summary>
    /// <value>The date and time the email was sent. </value>
    [DataMember(Name="sendTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sendTime")]
    public string SendTime { get; set; }

    /// <summary>
    /// The subject of the email. 
    /// </summary>
    /// <value>The subject of the email. </value>
    [DataMember(Name="subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subject")]
    public string Subject { get; set; }

    /// <summary>
    /// The intended recipient of the email. 
    /// </summary>
    /// <value>The intended recipient of the email. </value>
    [DataMember(Name="toEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toEmail")]
    public string ToEmail { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETEmailHistoryVOType {\n");
      sb.Append("  Bcc: ").Append(Bcc).Append("\n");
      sb.Append("  Cc: ").Append(Cc).Append("\n");
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
      sb.Append("  FromEmail: ").Append(FromEmail).Append("\n");
      sb.Append("  Notification: ").Append(Notification).Append("\n");
      sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
      sb.Append("  Result: ").Append(Result).Append("\n");
      sb.Append("  SendTime: ").Append(SendTime).Append("\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
      sb.Append("  ToEmail: ").Append(ToEmail).Append("\n");
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
