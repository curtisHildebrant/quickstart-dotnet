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
  public class POSTMassUpdateType {
    /// <summary>
    /// File containing data about the mass action you want to perform. The file requirements are the same as when uploading a file through the Mass Updater on the Zuora UI.  The file must be a .csv file or a zipped .csv file.   The maximum file size is 4 MB.  The data in the file must be formatted according to the mass action type you want to perform. Refer to the articles listed in the `actionType` field below for the requirements of each mass action type.  See the [Uploaded File](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater#Uploaded_File) section of the Mass Updater article for more information about the upload file. 
    /// </summary>
    /// <value>File containing data about the mass action you want to perform. The file requirements are the same as when uploading a file through the Mass Updater on the Zuora UI.  The file must be a .csv file or a zipped .csv file.   The maximum file size is 4 MB.  The data in the file must be formatted according to the mass action type you want to perform. Refer to the articles listed in the `actionType` field below for the requirements of each mass action type.  See the [Uploaded File](https://knowledgecenter.zuora.com/CC_Finance/Mass_Updater#Uploaded_File) section of the Mass Updater article for more information about the upload file. </value>
    [DataMember(Name="file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "file")]
    public string File { get; set; }

    /// <summary>
    /// Gets or Sets _Params
    /// </summary>
    [DataMember(Name="params", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "params")]
    public POSTMassUpdateTypeParams _Params { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class POSTMassUpdateType {\n");
      sb.Append("  File: ").Append(File).Append("\n");
      sb.Append("  _Params: ").Append(_Params).Append("\n");
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
