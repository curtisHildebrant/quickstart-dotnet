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
  public class GETAccountSummarySubscriptionType {
    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="CpqBundleJsonId__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CpqBundleJsonId__QT")]
    public string CpqBundleJsonIdQT { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="OpportunityCloseDate__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OpportunityCloseDate__QT")]
    public string OpportunityCloseDateQT { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="OpportunityName__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OpportunityName__QT")]
    public string OpportunityNameQT { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="QuoteBusinessType__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteBusinessType__QT")]
    public string QuoteBusinessTypeQT { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="QuoteNumber__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteNumber__QT")]
    public string QuoteNumberQT { get; set; }

    /// <summary>
    /// dummy
    /// </summary>
    /// <value>dummy</value>
    [DataMember(Name="QuoteType__QT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteType__QT")]
    public string QuoteTypeQT { get; set; }

    /// <summary>
    /// If `true`, auto-renew is enabled. If `false`, auto-renew is disabled. 
    /// </summary>
    /// <value>If `true`, auto-renew is enabled. If `false`, auto-renew is disabled. </value>
    [DataMember(Name="autoRenew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoRenew")]
    public bool? AutoRenew { get; set; }

    /// <summary>
    /// Any custom fields defined for this object. 
    /// </summary>
    /// <value>Any custom fields defined for this object. </value>
    [DataMember(Name="customField__c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customField__c")]
    public string CustomFieldC { get; set; }

    /// <summary>
    /// Subscription ID. 
    /// </summary>
    /// <value>Subscription ID. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Duration of the initial subscription term in whole months.  
    /// </summary>
    /// <value>Duration of the initial subscription term in whole months.  </value>
    [DataMember(Name="initialTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initialTerm")]
    public string InitialTerm { get; set; }

    /// <summary>
    /// Container for rate plans for this subscription. 
    /// </summary>
    /// <value>Container for rate plans for this subscription. </value>
    [DataMember(Name="ratePlans", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratePlans")]
    public List<GETAccountSummarySubscriptionRatePlanType> RatePlans { get; set; }

    /// <summary>
    /// Duration of the renewal term in whole months. 
    /// </summary>
    /// <value>Duration of the renewal term in whole months. </value>
    [DataMember(Name="renewalTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewalTerm")]
    public string RenewalTerm { get; set; }

    /// <summary>
    /// Subscription status; possible values are: `Draft`, `PendingActivation`, `PendingAcceptance`, `Active`, `Cancelled`, `Expired`. 
    /// </summary>
    /// <value>Subscription status; possible values are: `Draft`, `PendingActivation`, `PendingAcceptance`, `Active`, `Cancelled`, `Expired`. </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Subscription Number. 
    /// </summary>
    /// <value>Subscription Number. </value>
    [DataMember(Name="subscriptionNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionNumber")]
    public string SubscriptionNumber { get; set; }

    /// <summary>
    /// Subscription start date. 
    /// </summary>
    /// <value>Subscription start date. </value>
    [DataMember(Name="subscriptionStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionStartDate")]
    public DateTime? SubscriptionStartDate { get; set; }

    /// <summary>
    /// End date of the subscription term. If the subscription is evergreen, this is either null or equal to the cancellation date, as appropriate. 
    /// </summary>
    /// <value>End date of the subscription term. If the subscription is evergreen, this is either null or equal to the cancellation date, as appropriate. </value>
    [DataMember(Name="termEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "termEndDate")]
    public DateTime? TermEndDate { get; set; }

    /// <summary>
    /// Start date of the subscription term. If this is a renewal subscription, this date is different than the subscription start date. 
    /// </summary>
    /// <value>Start date of the subscription term. If this is a renewal subscription, this date is different than the subscription start date. </value>
    [DataMember(Name="termStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "termStartDate")]
    public DateTime? TermStartDate { get; set; }

    /// <summary>
    /// Possible values are: `TERMED`, `EVERGREEN`. 
    /// </summary>
    /// <value>Possible values are: `TERMED`, `EVERGREEN`. </value>
    [DataMember(Name="termType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "termType")]
    public string TermType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountSummarySubscriptionType {\n");
      sb.Append("  CpqBundleJsonIdQT: ").Append(CpqBundleJsonIdQT).Append("\n");
      sb.Append("  OpportunityCloseDateQT: ").Append(OpportunityCloseDateQT).Append("\n");
      sb.Append("  OpportunityNameQT: ").Append(OpportunityNameQT).Append("\n");
      sb.Append("  QuoteBusinessTypeQT: ").Append(QuoteBusinessTypeQT).Append("\n");
      sb.Append("  QuoteNumberQT: ").Append(QuoteNumberQT).Append("\n");
      sb.Append("  QuoteTypeQT: ").Append(QuoteTypeQT).Append("\n");
      sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
      sb.Append("  CustomFieldC: ").Append(CustomFieldC).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InitialTerm: ").Append(InitialTerm).Append("\n");
      sb.Append("  RatePlans: ").Append(RatePlans).Append("\n");
      sb.Append("  RenewalTerm: ").Append(RenewalTerm).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  SubscriptionNumber: ").Append(SubscriptionNumber).Append("\n");
      sb.Append("  SubscriptionStartDate: ").Append(SubscriptionStartDate).Append("\n");
      sb.Append("  TermEndDate: ").Append(TermEndDate).Append("\n");
      sb.Append("  TermStartDate: ").Append(TermStartDate).Append("\n");
      sb.Append("  TermType: ").Append(TermType).Append("\n");
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
