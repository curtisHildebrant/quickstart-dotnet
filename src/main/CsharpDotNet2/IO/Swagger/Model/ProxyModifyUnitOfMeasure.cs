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
  public class ProxyModifyUnitOfMeasure {
    /// <summary>
    ///  Indicates if the UOM is available for new product rate plans. The default value is `true`. **Character limit**: 5 **Values**: `true`, `false ` 
    /// </summary>
    /// <value> Indicates if the UOM is available for new product rate plans. The default value is `true`. **Character limit**: 5 **Values**: `true`, `false ` </value>
    [DataMember(Name="Active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Active")]
    public bool? Active { get; set; }

    /// <summary>
    /// The number of digits to the right of the decimal point that you want to measure for the unit. To use whole numbers only, set this value to 0. You can't change this value after this `UOM` is used in any product, subscription, or usage. **Character limit**: 1 **Values**: an integer between 0 and 9, exclusive 
    /// </summary>
    /// <value>The number of digits to the right of the decimal point that you want to measure for the unit. To use whole numbers only, set this value to 0. You can't change this value after this `UOM` is used in any product, subscription, or usage. **Character limit**: 1 **Values**: an integer between 0 and 9, exclusive </value>
    [DataMember(Name="DecimalPlaces", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DecimalPlaces")]
    public long? DecimalPlaces { get; set; }

    /// <summary>
    /// The name of the UOM that you want displayed on invoices. The default value is the `UomName` field value. **Character limit**: 50 **Values**: A string of 50 characters or fewer 
    /// </summary>
    /// <value>The name of the UOM that you want displayed on invoices. The default value is the `UomName` field value. **Character limit**: 50 **Values**: A string of 50 characters or fewer </value>
    [DataMember(Name="DisplayedAs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayedAs")]
    public string DisplayedAs { get; set; }

    /// <summary>
    ///  Specifies whether to round the UOM value up or down when the value exceeds the `DecimalPlaces` field value. The default value is `Up`. **Character limit**: 4 **Values**: `Up`, `Down` 
    /// </summary>
    /// <value> Specifies whether to round the UOM value up or down when the value exceeds the `DecimalPlaces` field value. The default value is `Up`. **Character limit**: 4 **Values**: `Up`, `Down` </value>
    [DataMember(Name="RoundingMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoundingMode")]
    public string RoundingMode { get; set; }

    /// <summary>
    ///  The name of the UOM, such as license or GB. This name is displayed in query results and in the web-based UI labels. If you want a different name to be displayed on invoices, then use the `DisplayedAs` field to provide the invoice label. **Character limit**: 50 **Values**: a string of 50 characters or fewer 
    /// </summary>
    /// <value> The name of the UOM, such as license or GB. This name is displayed in query results and in the web-based UI labels. If you want a different name to be displayed on invoices, then use the `DisplayedAs` field to provide the invoice label. **Character limit**: 50 **Values**: a string of 50 characters or fewer </value>
    [DataMember(Name="UomName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UomName")]
    public string UomName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyModifyUnitOfMeasure {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  DecimalPlaces: ").Append(DecimalPlaces).Append("\n");
      sb.Append("  DisplayedAs: ").Append(DisplayedAs).Append("\n");
      sb.Append("  RoundingMode: ").Append(RoundingMode).Append("\n");
      sb.Append("  UomName: ").Append(UomName).Append("\n");
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
