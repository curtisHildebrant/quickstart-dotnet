using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Container for the following fields. You must format the &#x60;params&#x60; field as a JSON object. 
  /// </summary>
  [DataContract]
  public class POSTMassUpdateTypeParams {
    /// <summary>
    /// Type of mass action you want to perform. The following mass actions are supported: - [UpdateAccountingCode](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater/Update_Accounting_Codes) - [CreateRevenueSchedule](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater/Create_Revenue_Schedules) - [UpdateRevenueSchedule](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater/Update_Revenue_Schedules) - [DeleteRevenueSchedule](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater/Delete_Revenue_Schedules) - [ImportFXRate](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater/Import_Foreign_Exchange_Rates) 
    /// </summary>
    /// <value>Type of mass action you want to perform. The following mass actions are supported: - [UpdateAccountingCode](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater/Update_Accounting_Codes) - [CreateRevenueSchedule](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater/Create_Revenue_Schedules) - [UpdateRevenueSchedule](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater/Update_Revenue_Schedules) - [DeleteRevenueSchedule](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater/Delete_Revenue_Schedules) - [ImportFXRate](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater/Import_Foreign_Exchange_Rates) </value>
    [DataMember(Name="actionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actionType")]
    public string ActionType { get; set; }

    /// <summary>
    /// An MD5 checksum that is used to validate the integrity of the uploaded file. The checksum is a 32-character string. 
    /// </summary>
    /// <value>An MD5 checksum that is used to validate the integrity of the uploaded file. The checksum is a 32-character string. </value>
    [DataMember(Name="checksum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checksum")]
    public string Checksum { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTMassUpdateTypeParams {\n");
      sb.Append("  ActionType: ").Append(ActionType).Append("\n");
      sb.Append("  Checksum: ").Append(Checksum).Append("\n");
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
