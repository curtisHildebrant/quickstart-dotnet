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
  public class User {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="DataSecurityLevel__h", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DataSecurityLevel__h")]
    public string DataSecurityLevelH { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Email")]
    public string Email { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="FirstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FirstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="LastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastName")]
    public string LastName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Username")]
    public string Username { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="fieldsToNull", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldsToNull")]
    public string FieldsToNull { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class User {\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  DataSecurityLevelH: ").Append(DataSecurityLevelH).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
      sb.Append("  FieldsToNull: ").Append(FieldsToNull).Append("\n");
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
