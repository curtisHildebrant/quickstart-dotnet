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
  public class POSTQuoteDocType {
    /// <summary>
    /// If not using Salesforce locale, this API Zuora user will be used to retrieve the locale from Zuora. 
    /// </summary>
    /// <value>If not using Salesforce locale, this API Zuora user will be used to retrieve the locale from Zuora. </value>
    [DataMember(Name="apiuser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiuser")]
    public string Apiuser { get; set; }

    /// <summary>
    /// Type of the document to generate: `PDF` or `DOC`. 
    /// </summary>
    /// <value>Type of the document to generate: `PDF` or `DOC`. </value>
    [DataMember(Name="documentType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentType")]
    public string DocumentType { get; set; }

    /// <summary>
    /// Salesforce locale value to use. 
    /// </summary>
    /// <value>Salesforce locale value to use. </value>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; }

    /// <summary>
    /// ｜ Id of the quote。
    /// </summary>
    /// <value>｜ Id of the quote。</value>
    [DataMember(Name="quoteId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quoteId")]
    public string QuoteId { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="sandbox", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sandbox")]
    public string Sandbox { get; set; }

    /// <summary>
    /// SOAP URL used to login to Salesforce to get data. You can get the value with the following code in a Visualforce page: `{!$Api.Partner_Server_URL_100}` 
    /// </summary>
    /// <value>SOAP URL used to login to Salesforce to get data. You can get the value with the following code in a Visualforce page: `{!$Api.Partner_Server_URL_100}` </value>
    [DataMember(Name="serverUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serverUrl")]
    public string ServerUrl { get; set; }

    /// <summary>
    /// Salesforce session id used to log in to Salesforce to get data. You can get the value with the following code in a Visualforce page: *{!$Api.Session_ID}* 
    /// </summary>
    /// <value>Salesforce session id used to log in to Salesforce to get data. You can get the value with the following code in a Visualforce page: *{!$Api.Session_ID}* </value>
    [DataMember(Name="sessionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sessionId")]
    public string SessionId { get; set; }

    /// <summary>
    /// Id of the quote template in Zuora. 
    /// </summary>
    /// <value>Id of the quote template in Zuora. </value>
    [DataMember(Name="templateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "templateId")]
    public string TemplateId { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

    /// <summary>
    /// If using Salesforce org locale, set this to a value that is not null. 
    /// </summary>
    /// <value>If using Salesforce org locale, set this to a value that is not null. </value>
    [DataMember(Name="useSFDCLocale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "useSFDCLocale")]
    public string UseSFDCLocale { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }

    /// <summary>
    /// The major version number of Zuora Quotes you are generating the quote document in. You can use a quote template with hierarchy sizes bigger than 3 if this is set to 7 or higher. 
    /// </summary>
    /// <value>The major version number of Zuora Quotes you are generating the quote document in. You can use a quote template with hierarchy sizes bigger than 3 if this is set to 7 or higher. </value>
    [DataMember(Name="zquotesMajorVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zquotesMajorVersion")]
    public string ZquotesMajorVersion { get; set; }

    /// <summary>
    /// The minor version number of Zuora Quotes you are generating the quote document in. 
    /// </summary>
    /// <value>The minor version number of Zuora Quotes you are generating the quote document in. </value>
    [DataMember(Name="zquotesMinorVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zquotesMinorVersion")]
    public string ZquotesMinorVersion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTQuoteDocType {\n");
      sb.Append("  Apiuser: ").Append(Apiuser).Append("\n");
      sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  QuoteId: ").Append(QuoteId).Append("\n");
      sb.Append("  Sandbox: ").Append(Sandbox).Append("\n");
      sb.Append("  ServerUrl: ").Append(ServerUrl).Append("\n");
      sb.Append("  SessionId: ").Append(SessionId).Append("\n");
      sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
      sb.Append("  UseSFDCLocale: ").Append(UseSFDCLocale).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
      sb.Append("  ZquotesMajorVersion: ").Append(ZquotesMajorVersion).Append("\n");
      sb.Append("  ZquotesMinorVersion: ").Append(ZquotesMinorVersion).Append("\n");
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
