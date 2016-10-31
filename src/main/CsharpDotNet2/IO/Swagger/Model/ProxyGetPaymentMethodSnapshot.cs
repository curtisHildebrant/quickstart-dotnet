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
  public class ProxyGetPaymentMethodSnapshot {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public string AccountId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="AchAbaCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AchAbaCode")]
    public string AchAbaCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="AchAccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AchAccountName")]
    public string AchAccountName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="AchAccountNumberMask", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AchAccountNumberMask")]
    public string AchAccountNumberMask { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="AchAccountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AchAccountType")]
    public string AchAccountType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="AchBankName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AchBankName")]
    public string AchBankName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BankBranchCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankBranchCode")]
    public string BankBranchCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BankCheckDigit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankCheckDigit")]
    public string BankCheckDigit { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BankCity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankCity")]
    public string BankCity { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BankCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankCode")]
    public string BankCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BankIdentificationNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankIdentificationNumber")]
    public string BankIdentificationNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BankName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankName")]
    public string BankName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BankPostalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankPostalCode")]
    public string BankPostalCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BankStreetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankStreetName")]
    public string BankStreetName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BankStreetNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankStreetNumber")]
    public string BankStreetNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BankTransferAccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankTransferAccountName")]
    public string BankTransferAccountName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BankTransferAccountNumberMask", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankTransferAccountNumberMask")]
    public string BankTransferAccountNumberMask { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BankTransferAccountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankTransferAccountType")]
    public string BankTransferAccountType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BankTransferType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankTransferType")]
    public string BankTransferType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BusinessIdentificationCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BusinessIdentificationCode")]
    public string BusinessIdentificationCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="City", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "City")]
    public string City { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Country")]
    public string Country { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CreditCardAddress1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardAddress1")]
    public string CreditCardAddress1 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CreditCardAddress2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardAddress2")]
    public string CreditCardAddress2 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CreditCardCity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardCity")]
    public string CreditCardCity { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CreditCardCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardCountry")]
    public string CreditCardCountry { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CreditCardExpirationMonth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardExpirationMonth")]
    public int? CreditCardExpirationMonth { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CreditCardExpirationYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardExpirationYear")]
    public int? CreditCardExpirationYear { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CreditCardHolderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardHolderName")]
    public string CreditCardHolderName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CreditCardMaskNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardMaskNumber")]
    public string CreditCardMaskNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CreditCardPostalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardPostalCode")]
    public string CreditCardPostalCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CreditCardState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardState")]
    public string CreditCardState { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CreditCardType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardType")]
    public string CreditCardType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="DeviceSessionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeviceSessionId")]
    public string DeviceSessionId { get; set; }

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
    [DataMember(Name="ExistingMandate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExistingMandate")]
    public string ExistingMandate { get; set; }

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
    [DataMember(Name="IBAN", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IBAN")]
    public string IBAN { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="IPAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IPAddress")]
    public string IPAddress { get; set; }

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
    [DataMember(Name="LastFailedSaleTransactionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailedSaleTransactionDate")]
    public DateTime? LastFailedSaleTransactionDate { get; set; }

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
    [DataMember(Name="LastTransactionDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastTransactionDateTime")]
    public DateTime? LastTransactionDateTime { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="LastTransactionStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastTransactionStatus")]
    public string LastTransactionStatus { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="MandateCreationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MandateCreationDate")]
    public DateTime? MandateCreationDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="MandateID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MandateID")]
    public string MandateID { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="MandateReceived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MandateReceived")]
    public string MandateReceived { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="MandateUpdateDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MandateUpdateDate")]
    public DateTime? MandateUpdateDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="MaxConsecutivePaymentFailures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxConsecutivePaymentFailures")]
    public int? MaxConsecutivePaymentFailures { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="NumConsecutiveFailures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NumConsecutiveFailures")]
    public int? NumConsecutiveFailures { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PaymentMethodId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentMethodId")]
    public string PaymentMethodId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PaymentMethodStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentMethodStatus")]
    public string PaymentMethodStatus { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PaymentRetryWindow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentRetryWindow")]
    public int? PaymentRetryWindow { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PaypalBaid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaypalBaid")]
    public string PaypalBaid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PaypalEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaypalEmail")]
    public string PaypalEmail { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PaypalPreapprovalKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaypalPreapprovalKey")]
    public string PaypalPreapprovalKey { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PaypalType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaypalType")]
    public string PaypalType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Phone")]
    public string Phone { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PostalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PostalCode")]
    public string PostalCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="SecondTokenId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SecondTokenId")]
    public string SecondTokenId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="State", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "State")]
    public string State { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="StreetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StreetName")]
    public string StreetName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="StreetNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StreetNumber")]
    public string StreetNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="TokenId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TokenId")]
    public string TokenId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="TotalNumberOfErrorPayments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalNumberOfErrorPayments")]
    public int? TotalNumberOfErrorPayments { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="TotalNumberOfProcessedPayments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalNumberOfProcessedPayments")]
    public int? TotalNumberOfProcessedPayments { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="UseDefaultRetryRule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseDefaultRetryRule")]
    public bool? UseDefaultRetryRule { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetPaymentMethodSnapshot {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AchAbaCode: ").Append(AchAbaCode).Append("\n");
      sb.Append("  AchAccountName: ").Append(AchAccountName).Append("\n");
      sb.Append("  AchAccountNumberMask: ").Append(AchAccountNumberMask).Append("\n");
      sb.Append("  AchAccountType: ").Append(AchAccountType).Append("\n");
      sb.Append("  AchBankName: ").Append(AchBankName).Append("\n");
      sb.Append("  BankBranchCode: ").Append(BankBranchCode).Append("\n");
      sb.Append("  BankCheckDigit: ").Append(BankCheckDigit).Append("\n");
      sb.Append("  BankCity: ").Append(BankCity).Append("\n");
      sb.Append("  BankCode: ").Append(BankCode).Append("\n");
      sb.Append("  BankIdentificationNumber: ").Append(BankIdentificationNumber).Append("\n");
      sb.Append("  BankName: ").Append(BankName).Append("\n");
      sb.Append("  BankPostalCode: ").Append(BankPostalCode).Append("\n");
      sb.Append("  BankStreetName: ").Append(BankStreetName).Append("\n");
      sb.Append("  BankStreetNumber: ").Append(BankStreetNumber).Append("\n");
      sb.Append("  BankTransferAccountName: ").Append(BankTransferAccountName).Append("\n");
      sb.Append("  BankTransferAccountNumberMask: ").Append(BankTransferAccountNumberMask).Append("\n");
      sb.Append("  BankTransferAccountType: ").Append(BankTransferAccountType).Append("\n");
      sb.Append("  BankTransferType: ").Append(BankTransferType).Append("\n");
      sb.Append("  BusinessIdentificationCode: ").Append(BusinessIdentificationCode).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  CreditCardAddress1: ").Append(CreditCardAddress1).Append("\n");
      sb.Append("  CreditCardAddress2: ").Append(CreditCardAddress2).Append("\n");
      sb.Append("  CreditCardCity: ").Append(CreditCardCity).Append("\n");
      sb.Append("  CreditCardCountry: ").Append(CreditCardCountry).Append("\n");
      sb.Append("  CreditCardExpirationMonth: ").Append(CreditCardExpirationMonth).Append("\n");
      sb.Append("  CreditCardExpirationYear: ").Append(CreditCardExpirationYear).Append("\n");
      sb.Append("  CreditCardHolderName: ").Append(CreditCardHolderName).Append("\n");
      sb.Append("  CreditCardMaskNumber: ").Append(CreditCardMaskNumber).Append("\n");
      sb.Append("  CreditCardPostalCode: ").Append(CreditCardPostalCode).Append("\n");
      sb.Append("  CreditCardState: ").Append(CreditCardState).Append("\n");
      sb.Append("  CreditCardType: ").Append(CreditCardType).Append("\n");
      sb.Append("  DeviceSessionId: ").Append(DeviceSessionId).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  ExistingMandate: ").Append(ExistingMandate).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  IBAN: ").Append(IBAN).Append("\n");
      sb.Append("  IPAddress: ").Append(IPAddress).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastFailedSaleTransactionDate: ").Append(LastFailedSaleTransactionDate).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  LastTransactionDateTime: ").Append(LastTransactionDateTime).Append("\n");
      sb.Append("  LastTransactionStatus: ").Append(LastTransactionStatus).Append("\n");
      sb.Append("  MandateCreationDate: ").Append(MandateCreationDate).Append("\n");
      sb.Append("  MandateID: ").Append(MandateID).Append("\n");
      sb.Append("  MandateReceived: ").Append(MandateReceived).Append("\n");
      sb.Append("  MandateUpdateDate: ").Append(MandateUpdateDate).Append("\n");
      sb.Append("  MaxConsecutivePaymentFailures: ").Append(MaxConsecutivePaymentFailures).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NumConsecutiveFailures: ").Append(NumConsecutiveFailures).Append("\n");
      sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
      sb.Append("  PaymentMethodStatus: ").Append(PaymentMethodStatus).Append("\n");
      sb.Append("  PaymentRetryWindow: ").Append(PaymentRetryWindow).Append("\n");
      sb.Append("  PaypalBaid: ").Append(PaypalBaid).Append("\n");
      sb.Append("  PaypalEmail: ").Append(PaypalEmail).Append("\n");
      sb.Append("  PaypalPreapprovalKey: ").Append(PaypalPreapprovalKey).Append("\n");
      sb.Append("  PaypalType: ").Append(PaypalType).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
      sb.Append("  SecondTokenId: ").Append(SecondTokenId).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  StreetName: ").Append(StreetName).Append("\n");
      sb.Append("  StreetNumber: ").Append(StreetNumber).Append("\n");
      sb.Append("  TokenId: ").Append(TokenId).Append("\n");
      sb.Append("  TotalNumberOfErrorPayments: ").Append(TotalNumberOfErrorPayments).Append("\n");
      sb.Append("  TotalNumberOfProcessedPayments: ").Append(TotalNumberOfProcessedPayments).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  UseDefaultRetryRule: ").Append(UseDefaultRetryRule).Append("\n");
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
