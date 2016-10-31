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
  public class ProxyGetPaymentMethod {
    /// <summary>
    ///  The ID of the customer account associated with this payment method. This field is not required for the `[account ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account) 
    /// </summary>
    /// <value> The ID of the customer account associated with this payment method. This field is not required for the `[account ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account) </value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public string AccountId { get; set; }

    /// <summary>
    ///  The nine-digit routing number or ABA number used by banks. Use this field for ACH payment methods. **Character limit**: 9 **Values**: a string of 9 characters or fewer 
    /// </summary>
    /// <value> The nine-digit routing number or ABA number used by banks. Use this field for ACH payment methods. **Character limit**: 9 **Values**: a string of 9 characters or fewer </value>
    [DataMember(Name="AchAbaCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AchAbaCode")]
    public string AchAbaCode { get; set; }

    /// <summary>
    ///  The name of the account holder, which can be either a person or a company. Use this field for ACH payment methods. **Character limit**: 70 **Values**: a string of 70 characters or fewer 
    /// </summary>
    /// <value> The name of the account holder, which can be either a person or a company. Use this field for ACH payment methods. **Character limit**: 70 **Values**: a string of 70 characters or fewer </value>
    [DataMember(Name="AchAccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AchAccountName")]
    public string AchAccountName { get; set; }

    /// <summary>
    ///  This is a masked displayable version of the ACH account number, used for security purposes. For example: `XXXXXXXXX54321`. Use this field for ACH payment methods. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> This is a masked displayable version of the ACH account number, used for security purposes. For example: `XXXXXXXXX54321`. Use this field for ACH payment methods. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="AchAccountNumberMask", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AchAccountNumberMask")]
    public string AchAccountNumberMask { get; set; }

    /// <summary>
    ///  The type of bank account associated with the ACH payment. Use this field for ACH payment methods. **Character limit**: 16 **Values**:  - `BusinessChecking` - `Checking` - `Saving` 
    /// </summary>
    /// <value> The type of bank account associated with the ACH payment. Use this field for ACH payment methods. **Character limit**: 16 **Values**:  - `BusinessChecking` - `Checking` - `Saving` </value>
    [DataMember(Name="AchAccountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AchAccountType")]
    public string AchAccountType { get; set; }

    /// <summary>
    ///  Line 1 for the ACH address. Required on create for the Vantiv payment gateway. Optional for other gateways. **Character limit:** **Values:** an address 
    /// </summary>
    /// <value> Line 1 for the ACH address. Required on create for the Vantiv payment gateway. Optional for other gateways. **Character limit:** **Values:** an address </value>
    [DataMember(Name="AchAddress1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AchAddress1")]
    public string AchAddress1 { get; set; }

    /// <summary>
    ///  Line 2 for the ACH address. Required on create for the Vantiv payment gateway. Optional for other gateways. **Character limit:** **Values:** an address 
    /// </summary>
    /// <value> Line 2 for the ACH address. Required on create for the Vantiv payment gateway. Optional for other gateways. **Character limit:** **Values:** an address </value>
    [DataMember(Name="AchAddress2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AchAddress2")]
    public string AchAddress2 { get; set; }

    /// <summary>
    ///  The name of the bank where the ACH payment account is held. Use this field for ACH payment methods. **Character limit**: 70 **Values**: a string of 70 characters or fewer 
    /// </summary>
    /// <value> The name of the bank where the ACH payment account is held. Use this field for ACH payment methods. **Character limit**: 70 **Values**: a string of 70 characters or fewer </value>
    [DataMember(Name="AchBankName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AchBankName")]
    public string AchBankName { get; set; }

    /// <summary>
    ///  Specifies whether a payment method is available in Zuora. The default value is `false`. **Character limit**: 5 **Values**: `true`, `false` 
    /// </summary>
    /// <value> Specifies whether a payment method is available in Zuora. The default value is `false`. **Character limit**: 5 **Values**: `true`, `false` </value>
    [DataMember(Name="Active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Active")]
    public bool? Active { get; set; }

    /// <summary>
    ///  The branch code of the bank used for direct debit. Use this field for direct debit payment methods. **Character limit**: 10 **Values**:  string of 10 characters or fewer 
    /// </summary>
    /// <value> The branch code of the bank used for direct debit. Use this field for direct debit payment methods. **Character limit**: 10 **Values**:  string of 10 characters or fewer </value>
    [DataMember(Name="BankBranchCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankBranchCode")]
    public string BankBranchCode { get; set; }

    /// <summary>
    /// The check digit in the international bank account number, which confirms the validity of the account. Use this field for direct debit payment methods. **Character limit**: 4 **Values**:  string of 4 characters or fewer 
    /// </summary>
    /// <value>The check digit in the international bank account number, which confirms the validity of the account. Use this field for direct debit payment methods. **Character limit**: 4 **Values**:  string of 4 characters or fewer </value>
    [DataMember(Name="BankCheckDigit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankCheckDigit")]
    public string BankCheckDigit { get; set; }

    /// <summary>
    ///  The city of the direct debit bank. Use this field for direct debit payment methods. **Character limit**:70 **Values**:  string of 70 characters or fewer 
    /// </summary>
    /// <value> The city of the direct debit bank. Use this field for direct debit payment methods. **Character limit**:70 **Values**:  string of 70 characters or fewer </value>
    [DataMember(Name="BankCity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankCity")]
    public string BankCity { get; set; }

    /// <summary>
    ///  The sort code or number that identifies the bank. This is also known as the sort code. This field is required for direct debit payment methods. **Character limit**: 18 **Values**:  string of 18 characters or fewer 
    /// </summary>
    /// <value> The sort code or number that identifies the bank. This is also known as the sort code. This field is required for direct debit payment methods. **Character limit**: 18 **Values**:  string of 18 characters or fewer </value>
    [DataMember(Name="BankCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankCode")]
    public string BankCode { get; set; }

    /// <summary>
    ///  The first six digits of the payment method's number, such as the credit card number or account number. Banks use this number to identify a payment method. **Character limit**: 6 **Values**:  string of 6 characters or fewer 
    /// </summary>
    /// <value> The first six digits of the payment method's number, such as the credit card number or account number. Banks use this number to identify a payment method. **Character limit**: 6 **Values**:  string of 6 characters or fewer </value>
    [DataMember(Name="BankIdentificationNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankIdentificationNumber")]
    public string BankIdentificationNumber { get; set; }

    /// <summary>
    ///  The name of the direct debit bank. Use this field for direct debit payment methods. **Character limit**:80 **Values**:  string of 80 characters or fewer 
    /// </summary>
    /// <value> The name of the direct debit bank. Use this field for direct debit payment methods. **Character limit**:80 **Values**:  string of 80 characters or fewer </value>
    [DataMember(Name="BankName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankName")]
    public string BankName { get; set; }

    /// <summary>
    ///  The zip code or postal code of the direct debit bank. Use this field for direct debit payment methods. **Character limit**:20 **Values**:  string of 20 characters or fewer 
    /// </summary>
    /// <value> The zip code or postal code of the direct debit bank. Use this field for direct debit payment methods. **Character limit**:20 **Values**:  string of 20 characters or fewer </value>
    [DataMember(Name="BankPostalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankPostalCode")]
    public string BankPostalCode { get; set; }

    /// <summary>
    ///  The name of the street of the direct debit bank. Use this field for direct debit payment methods. **Character limit**:60 **Values**:  string of 60 characters or fewer 
    /// </summary>
    /// <value> The name of the street of the direct debit bank. Use this field for direct debit payment methods. **Character limit**:60 **Values**:  string of 60 characters or fewer </value>
    [DataMember(Name="BankStreetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankStreetName")]
    public string BankStreetName { get; set; }

    /// <summary>
    ///  The number of the direct debit bank. Use this field for direct debit payment methods. **Character limit**:10 **Values**:  string of 10 characters or fewer 
    /// </summary>
    /// <value> The number of the direct debit bank. Use this field for direct debit payment methods. **Character limit**:10 **Values**:  string of 10 characters or fewer </value>
    [DataMember(Name="BankStreetNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankStreetNumber")]
    public string BankStreetNumber { get; set; }

    /// <summary>
    ///  The name on the direct debit bank account. Use this field for direct debit payment methods. **Character limit**: 60 **Values**:  string of 60 characters or fewer 
    /// </summary>
    /// <value> The name on the direct debit bank account. Use this field for direct debit payment methods. **Character limit**: 60 **Values**:  string of 60 characters or fewer </value>
    [DataMember(Name="BankTransferAccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankTransferAccountName")]
    public string BankTransferAccountName { get; set; }

    /// <summary>
    ///  This is a masked displayable version of the ACH account number, used for security purposes. For example: `XXXXXXXXX54321`. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> This is a masked displayable version of the ACH account number, used for security purposes. For example: `XXXXXXXXX54321`. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="BankTransferAccountNumberMask", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankTransferAccountNumberMask")]
    public string BankTransferAccountNumberMask { get; set; }

    /// <summary>
    ///  The type of the customer's bank account. Use this field for direct debit payment methods. **Character limit**: 11 **Values**: `DirectDebit` 
    /// </summary>
    /// <value> The type of the customer's bank account. Use this field for direct debit payment methods. **Character limit**: 11 **Values**: `DirectDebit` </value>
    [DataMember(Name="BankTransferAccountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankTransferAccountType")]
    public string BankTransferAccountType { get; set; }

    /// <summary>
    ///  Specifies the type of direct debit transfer. The value of this field is dependent on the country of the user. Use this field is used for direct debit payment methods. **Character limit**: 20 **Values**:  - `AutomatischIncasso` (NL) - `LastschriftDE` (Germany) - `LastschriftAT` (Austria) - `DemandeDePrelevement` (FR) - `DirectDebitUK` (UK) - `Domicil` (Belgium) - `LastschriftCH` (CH) - `RID` (Italy) - `OrdenDeDomiciliacion` (Spain) 
    /// </summary>
    /// <value> Specifies the type of direct debit transfer. The value of this field is dependent on the country of the user. Use this field is used for direct debit payment methods. **Character limit**: 20 **Values**:  - `AutomatischIncasso` (NL) - `LastschriftDE` (Germany) - `LastschriftAT` (Austria) - `DemandeDePrelevement` (FR) - `DirectDebitUK` (UK) - `Domicil` (Belgium) - `LastschriftCH` (CH) - `RID` (Italy) - `OrdenDeDomiciliacion` (Spain) </value>
    [DataMember(Name="BankTransferType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankTransferType")]
    public string BankTransferType { get; set; }

    /// <summary>
    ///  The business identification code for Swiss direct payment methods that use the Global Collect payment gateway. Use this field only for direct debit payments in Switzerland with Global Collect. **Character limit**: 11 **Values**: string of 11 characters or fewer 
    /// </summary>
    /// <value> The business identification code for Swiss direct payment methods that use the Global Collect payment gateway. Use this field only for direct debit payments in Switzerland with Global Collect. **Character limit**: 11 **Values**: string of 11 characters or fewer </value>
    [DataMember(Name="BusinessIdentificationCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BusinessIdentificationCode")]
    public string BusinessIdentificationCode { get; set; }

    /// <summary>
    ///  The city of the customer's address. Use this field for direct debit payment methods. **Character limit**:80 **Values**:  string of 80 characters or fewer 
    /// </summary>
    /// <value> The city of the customer's address. Use this field for direct debit payment methods. **Character limit**:80 **Values**:  string of 80 characters or fewer </value>
    [DataMember(Name="City", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "City")]
    public string City { get; set; }

    /// <summary>
    ///  The two-letter country code of the customer's address. Use this field for direct debit payment methods. **Character limit**: 2 **Values**: [a valid country code](/BC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/A_Country_Names_and_Their_ISO_Codes) 
    /// </summary>
    /// <value> The two-letter country code of the customer's address. Use this field for direct debit payment methods. **Character limit**: 2 **Values**: [a valid country code](/BC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/A_Country_Names_and_Their_ISO_Codes) </value>
    [DataMember(Name="Country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Country")]
    public string Country { get; set; }

    /// <summary>
    ///  The user ID of the person who created the `PaymentMethod` object when there is a login user in the user session. In Hosted Payment Method and Z-Checkout pages, this field is set to 3 as there is no login user to initiate a user session. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The user ID of the person who created the `PaymentMethod` object when there is a login user in the user session. In Hosted Payment Method and Z-Checkout pages, this field is set to 3 as there is no login user to initiate a user session. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    ///  The date when the `PaymentMethod` object was created in the Zuora system. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the `PaymentMethod` object was created in the Zuora system. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    ///  The first line of the card holder's address, which is often a street address or business name. Use this field for credit card and direct debit payment methods. **Character limit**: 255 **Values**: a string of 255 characters or fewer 
    /// </summary>
    /// <value> The first line of the card holder's address, which is often a street address or business name. Use this field for credit card and direct debit payment methods. **Character limit**: 255 **Values**: a string of 255 characters or fewer </value>
    [DataMember(Name="CreditCardAddress1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardAddress1")]
    public string CreditCardAddress1 { get; set; }

    /// <summary>
    ///  The second line of the card holder's address. Use this field for credit card and direct debit payment methods. **Character limit**: 255 **Values**: a string of 255 characters or fewer 
    /// </summary>
    /// <value> The second line of the card holder's address. Use this field for credit card and direct debit payment methods. **Character limit**: 255 **Values**: a string of 255 characters or fewer </value>
    [DataMember(Name="CreditCardAddress2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardAddress2")]
    public string CreditCardAddress2 { get; set; }

    /// <summary>
    ///  The city of the card holder's address. Use this field for credit card and direct debit payment methods **Character limit**: 40 **Values**: a string of 40 characters or fewer 
    /// </summary>
    /// <value> The city of the card holder's address. Use this field for credit card and direct debit payment methods **Character limit**: 40 **Values**: a string of 40 characters or fewer </value>
    [DataMember(Name="CreditCardCity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardCity")]
    public string CreditCardCity { get; set; }

    /// <summary>
    ///  The country of the card holder's address. See [a supported country name](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/A_Country_Names_and_Their_ISO_Codes) 
    /// </summary>
    /// <value> The country of the card holder's address. See [a supported country name](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/A_Country_Names_and_Their_ISO_Codes) </value>
    [DataMember(Name="CreditCardCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardCountry")]
    public string CreditCardCountry { get; set; }

    /// <summary>
    ///  The expiration month of the credit card or debit card. Use this field for credit card and direct debit payment methods. **Character limit**: 2 **Values**: a two-digit number, 01 - 12 
    /// </summary>
    /// <value> The expiration month of the credit card or debit card. Use this field for credit card and direct debit payment methods. **Character limit**: 2 **Values**: a two-digit number, 01 - 12 </value>
    [DataMember(Name="CreditCardExpirationMonth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardExpirationMonth")]
    public int? CreditCardExpirationMonth { get; set; }

    /// <summary>
    ///  The expiration month of the credit card or debit card. Use this field for credit card and direct debit payment methods. **Character limit**: 4 **Values**: a four-digit number 
    /// </summary>
    /// <value> The expiration month of the credit card or debit card. Use this field for credit card and direct debit payment methods. **Character limit**: 4 **Values**: a four-digit number </value>
    [DataMember(Name="CreditCardExpirationYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardExpirationYear")]
    public int? CreditCardExpirationYear { get; set; }

    /// <summary>
    ///  The full name of the card holder. Use this field for credit card and direct debit payment methods. **Character limit**: 50 **Values**: a string of 50 characters or fewer 
    /// </summary>
    /// <value> The full name of the card holder. Use this field for credit card and direct debit payment methods. **Character limit**: 50 **Values**: a string of 50 characters or fewer </value>
    [DataMember(Name="CreditCardHolderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardHolderName")]
    public string CreditCardHolderName { get; set; }

    /// <summary>
    ///  A masked version of the credit or debit card number. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> A masked version of the credit or debit card number. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreditCardMaskNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardMaskNumber")]
    public string CreditCardMaskNumber { get; set; }

    /// <summary>
    ///  The billing address's zip code. This field is required only when you define a debit card or credit card payment. **Character limit**: 20 **Values**: a string of 20 characters or fewer 
    /// </summary>
    /// <value> The billing address's zip code. This field is required only when you define a debit card or credit card payment. **Character limit**: 20 **Values**: a string of 20 characters or fewer </value>
    [DataMember(Name="CreditCardPostalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardPostalCode")]
    public string CreditCardPostalCode { get; set; }

    /// <summary>
    ///  The billing address's state. Use this field is if the `CreditCardCountry` value is either Canada or the US. State names must be spelled in full. For more information see the list of [a valid state name](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/B_State_Names_and_2-Digit_Codes) 
    /// </summary>
    /// <value> The billing address's state. Use this field is if the `CreditCardCountry` value is either Canada or the US. State names must be spelled in full. For more information see the list of [a valid state name](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/J_Country%2C_State%2C_and_Province_Codes/B_State_Names_and_2-Digit_Codes) </value>
    [DataMember(Name="CreditCardState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardState")]
    public string CreditCardState { get; set; }

    /// <summary>
    ///  The type of credit card or debit card. This field is required only when you define a debit card or credit card payment. **Character limit**: 32 **Values**: `AmericanExpress`, `Discover`, `MasterCard`, `Visa` 
    /// </summary>
    /// <value> The type of credit card or debit card. This field is required only when you define a debit card or credit card payment. **Character limit**: 32 **Values**: `AmericanExpress`, `Discover`, `MasterCard`, `Visa` </value>
    [DataMember(Name="CreditCardType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCardType")]
    public string CreditCardType { get; set; }

    /// <summary>
    ///  The session ID of the user when the `PaymentMethod` was created or updated. Some gateways use this field for fraud prevention. If this field is passed to Zuora, then Zuora passes this field to supported gateways. Currently only Verifi supports this field. **Character limit**: 255 **Values**: 
    /// </summary>
    /// <value> The session ID of the user when the `PaymentMethod` was created or updated. Some gateways use this field for fraud prevention. If this field is passed to Zuora, then Zuora passes this field to supported gateways. Currently only Verifi supports this field. **Character limit**: 255 **Values**: </value>
    [DataMember(Name="DeviceSessionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeviceSessionId")]
    public string DeviceSessionId { get; set; }

    /// <summary>
    ///  An email address for the payment method in addition to the bill to contact email address. **Character limit**: 80 **Values**: a string of 80 characters or fewer 
    /// </summary>
    /// <value> An email address for the payment method in addition to the bill to contact email address. **Character limit**: 80 **Values**: a string of 80 characters or fewer </value>
    [DataMember(Name="Email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Email")]
    public string Email { get; set; }

    /// <summary>
    ///  Indicates if the customer has an existing mandate or a new mandate. A mandate is a signed authorization for UK and NL customers. When you are migrating mandates from another system, be sure to set this field correctly. If you indicate that a new mandate is an existing mandate or vice-versa, then transactions fail. This field is used only for the direct debit payment method. **Character limit**: 3 **Values**: `Yes`, `No` 
    /// </summary>
    /// <value> Indicates if the customer has an existing mandate or a new mandate. A mandate is a signed authorization for UK and NL customers. When you are migrating mandates from another system, be sure to set this field correctly. If you indicate that a new mandate is an existing mandate or vice-versa, then transactions fail. This field is used only for the direct debit payment method. **Character limit**: 3 **Values**: `Yes`, `No` </value>
    [DataMember(Name="ExistingMandate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExistingMandate")]
    public string ExistingMandate { get; set; }

    /// <summary>
    ///  The customer's first name. This field is used only for the direct debit payment method. **Character limit**: 30 **Values**: a string of 30 characters or fewer 
    /// </summary>
    /// <value> The customer's first name. This field is used only for the direct debit payment method. **Character limit**: 30 **Values**: a string of 30 characters or fewer </value>
    [DataMember(Name="FirstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FirstName")]
    public string FirstName { get; set; }

    /// <summary>
    ///  The International Bank Account Number. This field is used only for the direct debit payment method. **Character limit**: 42 **Values**: a string of 42 characters or fewer 
    /// </summary>
    /// <value> The International Bank Account Number. This field is used only for the direct debit payment method. **Character limit**: 42 **Values**: a string of 42 characters or fewer </value>
    [DataMember(Name="IBAN", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IBAN")]
    public string IBAN { get; set; }

    /// <summary>
    ///  The IP address of the user when the payment method was created or updated. Some gateways use this field for fraud prevention. If this field is passed to Zuora, then Zuora passes this field to supported gateways. Currently PayPal, CyberSource, Authorize.Net, and Verifi support this field. **Character limit**: 15 **Values**: a string of 15 characters or fewer 
    /// </summary>
    /// <value> The IP address of the user when the payment method was created or updated. Some gateways use this field for fraud prevention. If this field is passed to Zuora, then Zuora passes this field to supported gateways. Currently PayPal, CyberSource, Authorize.Net, and Verifi support this field. **Character limit**: 15 **Values**: a string of 15 characters or fewer </value>
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
    ///  The date of the last failed attempt to collect payment with this payment method. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date of the last failed attempt to collect payment with this payment method. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="LastFailedSaleTransactionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailedSaleTransactionDate")]
    public DateTime? LastFailedSaleTransactionDate { get; set; }

    /// <summary>
    ///  The customer's last name. This field is used only for the direct debit payment method. **Character limit**: 70 **Values**: a string of 70 characters or fewer 
    /// </summary>
    /// <value> The customer's last name. This field is used only for the direct debit payment method. **Character limit**: 70 **Values**: a string of 70 characters or fewer </value>
    [DataMember(Name="LastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastName")]
    public string LastName { get; set; }

    /// <summary>
    ///  The date of the most recent transaction. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_Format_and_Datetimes_in_Zuora) 
    /// </summary>
    /// <value> The date of the most recent transaction. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_Format_and_Datetimes_in_Zuora) </value>
    [DataMember(Name="LastTransactionDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastTransactionDateTime")]
    public DateTime? LastTransactionDateTime { get; set; }

    /// <summary>
    ///  The status of the most recent transaction. **Character limit**: 39 **Values**: automatically generated 
    /// </summary>
    /// <value> The status of the most recent transaction. **Character limit**: 39 **Values**: automatically generated </value>
    [DataMember(Name="LastTransactionStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastTransactionStatus")]
    public string LastTransactionStatus { get; set; }

    /// <summary>
    ///  The date when the mandate was created. A mandate is a signed authorization for UK and NL customers. This field is used only for the direct debit payment method. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_Format_and_Datetimes_in_Zuora) 
    /// </summary>
    /// <value> The date when the mandate was created. A mandate is a signed authorization for UK and NL customers. This field is used only for the direct debit payment method. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_Format_and_Datetimes_in_Zuora) </value>
    [DataMember(Name="MandateCreationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MandateCreationDate")]
    public DateTime? MandateCreationDate { get; set; }

    /// <summary>
    ///  The ID of the mandate. A mandate is a signed authorization for UK and NL customers. This field is used only for the direct debit payment method. **Character limit**: 36 **Values**: a string of 36 characters or fewer 
    /// </summary>
    /// <value> The ID of the mandate. A mandate is a signed authorization for UK and NL customers. This field is used only for the direct debit payment method. **Character limit**: 36 **Values**: a string of 36 characters or fewer </value>
    [DataMember(Name="MandateID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MandateID")]
    public string MandateID { get; set; }

    /// <summary>
    ///  Indicates if  the mandate was received. A mandate is a signed authorization for UK and NL customers. This field is used only for the direct debit payment method. **Character limit**: 3 **Values**: `Yes`, `No `(case-sensitive) 
    /// </summary>
    /// <value> Indicates if  the mandate was received. A mandate is a signed authorization for UK and NL customers. This field is used only for the direct debit payment method. **Character limit**: 3 **Values**: `Yes`, `No `(case-sensitive) </value>
    [DataMember(Name="MandateReceived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MandateReceived")]
    public string MandateReceived { get; set; }

    /// <summary>
    ///  The date when the mandate was last updated. A mandate is a signed authorization for UK and NL customers. This field is used only for the direct debit payment method. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_Format_and_Datetimes_in_Zuora) 
    /// </summary>
    /// <value> The date when the mandate was last updated. A mandate is a signed authorization for UK and NL customers. This field is used only for the direct debit payment method. **Character limit**: 29 **Values**: [a valid date and time value](/CB_Billing/WA_Dates_in_Zuora/A_Date_Format_and_Datetimes_in_Zuora) </value>
    [DataMember(Name="MandateUpdateDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MandateUpdateDate")]
    public DateTime? MandateUpdateDate { get; set; }

    /// <summary>
    ///  Specifies the number of allowable consecutive failures Zuora attempts with the payment method before stopping. **Values**: a valid number 
    /// </summary>
    /// <value> Specifies the number of allowable consecutive failures Zuora attempts with the payment method before stopping. **Values**: a valid number </value>
    [DataMember(Name="MaxConsecutivePaymentFailures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxConsecutivePaymentFailures")]
    public int? MaxConsecutivePaymentFailures { get; set; }

    /// <summary>
    ///  Create Query Delete Filter 
    /// </summary>
    /// <value> Create Query Delete Filter </value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    ///  The number of consecutive failed payment for this payment method. It is reset to 0 upon successful payment. You can use the API to update the field value to 0. **Character limit**: **Values**: a positive whole number 
    /// </summary>
    /// <value> The number of consecutive failed payment for this payment method. It is reset to 0 upon successful payment. You can use the API to update the field value to 0. **Character limit**: **Values**: a positive whole number </value>
    [DataMember(Name="NumConsecutiveFailures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NumConsecutiveFailures")]
    public int? NumConsecutiveFailures { get; set; }

    /// <summary>
    ///  Specifies the status of the payment method. It is set to Active on creation. **Character limit**: 6 **Values**: `Active` or `Closed` *Update() functionality added in WSDL 47. PaymentMethodStatus should not be used in the `create()` call. You can only set this field to **Closed** via the `update()` call. 
    /// </summary>
    /// <value> Specifies the status of the payment method. It is set to Active on creation. **Character limit**: 6 **Values**: `Active` or `Closed` *Update() functionality added in WSDL 47. PaymentMethodStatus should not be used in the `create()` call. You can only set this field to **Closed** via the `update()` call. </value>
    [DataMember(Name="PaymentMethodStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentMethodStatus")]
    public string PaymentMethodStatus { get; set; }

    /// <summary>
    ///  The retry interval setting, which prevents making a payment attempt if the last failed attempt was within the last specified number of hours. This field is required if the `UseDefaultRetryRule` field value is set to `false`. **Character limit**: 4 **Values**: a whole number between 1 and 1000, exclusive 
    /// </summary>
    /// <value> The retry interval setting, which prevents making a payment attempt if the last failed attempt was within the last specified number of hours. This field is required if the `UseDefaultRetryRule` field value is set to `false`. **Character limit**: 4 **Values**: a whole number between 1 and 1000, exclusive </value>
    [DataMember(Name="PaymentRetryWindow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentRetryWindow")]
    public int? PaymentRetryWindow { get; set; }

    /// <summary>
    ///  The PayPal billing agreement ID, which is a contract between two PayPal accounts. Typically, the selling party initiates a request to create a BAID, and sends it to buying party for acceptance. The seller can keep track of the BAID and use it for future charges against the buyer. This field is required when defining a PayPal payment method. **Character limit**: 64 **Values**: a string of 64 characters or fewer 
    /// </summary>
    /// <value> The PayPal billing agreement ID, which is a contract between two PayPal accounts. Typically, the selling party initiates a request to create a BAID, and sends it to buying party for acceptance. The seller can keep track of the BAID and use it for future charges against the buyer. This field is required when defining a PayPal payment method. **Character limit**: 64 **Values**: a string of 64 characters or fewer </value>
    [DataMember(Name="PaypalBaid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaypalBaid")]
    public string PaypalBaid { get; set; }

    /// <summary>
    ///  The email address associated with the account holder's PayPal account or of the PayPal account of the person paying for the service. This field is required only when you define a PayPal payment method. **Character limit**: 80 **Values**: a string of 80 characters or fewer 
    /// </summary>
    /// <value> The email address associated with the account holder's PayPal account or of the PayPal account of the person paying for the service. This field is required only when you define a PayPal payment method. **Character limit**: 80 **Values**: a string of 80 characters or fewer </value>
    [DataMember(Name="PaypalEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaypalEmail")]
    public string PaypalEmail { get; set; }

    /// <summary>
    ///  PayPal's Adaptive Payments API key. Zuora does not create this key, nor does it call PayPal to generate it. You must use PayPal's Adaptive Payments' API to generate this key, and then pass it to Zuora. Zuora uses this key to authorize future payments to PayPal's Adaptive Payments API. This field is required when you use PayPal Adaptive Payments gateway. **Character limit**: 32 **Values**: a valid PayPal Adaptive Payment pre-approval key 
    /// </summary>
    /// <value> PayPal's Adaptive Payments API key. Zuora does not create this key, nor does it call PayPal to generate it. You must use PayPal's Adaptive Payments' API to generate this key, and then pass it to Zuora. Zuora uses this key to authorize future payments to PayPal's Adaptive Payments API. This field is required when you use PayPal Adaptive Payments gateway. **Character limit**: 32 **Values**: a valid PayPal Adaptive Payment pre-approval key </value>
    [DataMember(Name="PaypalPreapprovalKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaypalPreapprovalKey")]
    public string PaypalPreapprovalKey { get; set; }

    /// <summary>
    ///  Specifies the PayPal gateway: PayFlow Pro (Express Checkout) or Adaptive Payments. This field is required when you use PayPal Adaptive Payments or Payflow Pro (Express Checkout) gateways. **Character limit**: 32 **Values**: `ExpressCheckout`, `AdaptivePayments` 
    /// </summary>
    /// <value> Specifies the PayPal gateway: PayFlow Pro (Express Checkout) or Adaptive Payments. This field is required when you use PayPal Adaptive Payments or Payflow Pro (Express Checkout) gateways. **Character limit**: 32 **Values**: `ExpressCheckout`, `AdaptivePayments` </value>
    [DataMember(Name="PaypalType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaypalType")]
    public string PaypalType { get; set; }

    /// <summary>
    ///  The phone number that the account holder registered with the bank. This field is used for credit card validation when passing to a gateway. **Character limit**: 40 **Values**: a string of 40 characters or fewer 
    /// </summary>
    /// <value> The phone number that the account holder registered with the bank. This field is used for credit card validation when passing to a gateway. **Character limit**: 40 **Values**: a string of 40 characters or fewer </value>
    [DataMember(Name="Phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Phone")]
    public string Phone { get; set; }

    /// <summary>
    ///  The zip code of the customer's address. This field is used only for the direct debit payment method. **Character limit**: 20 **Values**: a string of 20 characters or fewer 
    /// </summary>
    /// <value> The zip code of the customer's address. This field is used only for the direct debit payment method. **Character limit**: 20 **Values**: a string of 20 characters or fewer </value>
    [DataMember(Name="PostalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PostalCode")]
    public string PostalCode { get; set; }

    /// <summary>
    ///  A gateway unique identifier that replaces sensitive payment method data. SecondTokenId is conditionally required only when TokenID is being used to represent a gateway customer profile. SecondTokenId is used in the CC Reference Transaction payment method. **Character limit**: 64 **Values**: a string of 64 characters or fewer 
    /// </summary>
    /// <value> A gateway unique identifier that replaces sensitive payment method data. SecondTokenId is conditionally required only when TokenID is being used to represent a gateway customer profile. SecondTokenId is used in the CC Reference Transaction payment method. **Character limit**: 64 **Values**: a string of 64 characters or fewer </value>
    [DataMember(Name="SecondTokenId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SecondTokenId")]
    public string SecondTokenId { get; set; }

    /// <summary>
    ///  The state of the customer's address. This field is used only for the direct debit payment method. **Character limit**: 70 **Values**: a string of 70 characters or fewer 
    /// </summary>
    /// <value> The state of the customer's address. This field is used only for the direct debit payment method. **Character limit**: 70 **Values**: a string of 70 characters or fewer </value>
    [DataMember(Name="State", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "State")]
    public string State { get; set; }

    /// <summary>
    ///  The street name of the customer's address. This field is used only for the direct debit payment method. **Character limit**: 100 **Values**: a string of 100 characters or fewer 
    /// </summary>
    /// <value> The street name of the customer's address. This field is used only for the direct debit payment method. **Character limit**: 100 **Values**: a string of 100 characters or fewer </value>
    [DataMember(Name="StreetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StreetName")]
    public string StreetName { get; set; }

    /// <summary>
    ///  The street number of the customer's address. This field is used only for the direct debit payment method. **Character limit**: 30 **Values**: a string of 30 characters or fewer 
    /// </summary>
    /// <value> The street number of the customer's address. This field is used only for the direct debit payment method. **Character limit**: 30 **Values**: a string of 30 characters or fewer </value>
    [DataMember(Name="StreetNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StreetNumber")]
    public string StreetNumber { get; set; }

    /// <summary>
    ///  A gateway unique identifier that replaces sensitive payment method data or represents a gateway's unique customer profile. When TokenId is used to represent a customer profile, then SecondTokenId is conditionally required for representing the underlying tokenized payment method. TokenId is required for the CC Reference Transaction payment method. **Character limit**: 255 **Values**: a string of 255 characters or fewer 
    /// </summary>
    /// <value> A gateway unique identifier that replaces sensitive payment method data or represents a gateway's unique customer profile. When TokenId is used to represent a customer profile, then SecondTokenId is conditionally required for representing the underlying tokenized payment method. TokenId is required for the CC Reference Transaction payment method. **Character limit**: 255 **Values**: a string of 255 characters or fewer </value>
    [DataMember(Name="TokenId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TokenId")]
    public string TokenId { get; set; }

    /// <summary>
    ///  The number of error payments that used this payment method. **Character limit**: **Values**: automatically generated 
    /// </summary>
    /// <value> The number of error payments that used this payment method. **Character limit**: **Values**: automatically generated </value>
    [DataMember(Name="TotalNumberOfErrorPayments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalNumberOfErrorPayments")]
    public int? TotalNumberOfErrorPayments { get; set; }

    /// <summary>
    ///  The number of successful payments that used this payment method. **Character limit**: **Values**: automatically generated 
    /// </summary>
    /// <value> The number of successful payments that used this payment method. **Character limit**: **Values**: automatically generated </value>
    [DataMember(Name="TotalNumberOfProcessedPayments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalNumberOfProcessedPayments")]
    public int? TotalNumberOfProcessedPayments { get; set; }

    /// <summary>
    ///  Create Query Update Delete Filter 
    /// </summary>
    /// <value> Create Query Update Delete Filter </value>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }

    /// <summary>
    ///  The ID of the user who last updated the payment method. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the user who last updated the payment method. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    ///  The date when the payment method was last updated. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the payment method was last updated. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }

    /// <summary>
    ///  Determines whether to use the default retry rules configured in the [Z-Payments settings](https://knowledgecenter.zuora.com/CB_Billing/L_Payment_Methods/H_Configure_Payment_Method_Retry_Rules). Set this to `true` to use the default retry rules. Set this to `false` to set the specific rules for this payment method. If you set this value to `false`, then the fields, `PaymentRetryWindow` and `MaxConsecutivePaymentFailures`, are required. **Character limit**: 5 **Values**: `t``rue`, `false` 
    /// </summary>
    /// <value> Determines whether to use the default retry rules configured in the [Z-Payments settings](https://knowledgecenter.zuora.com/CB_Billing/L_Payment_Methods/H_Configure_Payment_Method_Retry_Rules). Set this to `true` to use the default retry rules. Set this to `false` to set the specific rules for this payment method. If you set this value to `false`, then the fields, `PaymentRetryWindow` and `MaxConsecutivePaymentFailures`, are required. **Character limit**: 5 **Values**: `t``rue`, `false` </value>
    [DataMember(Name="UseDefaultRetryRule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseDefaultRetryRule")]
    public bool? UseDefaultRetryRule { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetPaymentMethod {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AchAbaCode: ").Append(AchAbaCode).Append("\n");
      sb.Append("  AchAccountName: ").Append(AchAccountName).Append("\n");
      sb.Append("  AchAccountNumberMask: ").Append(AchAccountNumberMask).Append("\n");
      sb.Append("  AchAccountType: ").Append(AchAccountType).Append("\n");
      sb.Append("  AchAddress1: ").Append(AchAddress1).Append("\n");
      sb.Append("  AchAddress2: ").Append(AchAddress2).Append("\n");
      sb.Append("  AchBankName: ").Append(AchBankName).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
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
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
      sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
