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
  public class ProxyGetAccount {
    /// <summary>
    /// Unique account number assigned to the account. **Character limit**: 50 **Values**: one of the following:  - null to auto-generate - a string of 50 characters or fewer that doesn't begin with the default account number prefix 
    /// </summary>
    /// <value>Unique account number assigned to the account. **Character limit**: 50 **Values**: one of the following:  - null to auto-generate - a string of 50 characters or fewer that doesn't begin with the default account number prefix </value>
    [DataMember(Name="AccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// List of additional email addresses to receive emailed invoices. **Character limit**: 120 **Values**: comma-separated list of email addresses 
    /// </summary>
    /// <value>List of additional email addresses to receive emailed invoices. **Character limit**: 120 **Values**: comma-separated list of email addresses </value>
    [DataMember(Name="AdditionalEmailAddresses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdditionalEmailAddresses")]
    public string AdditionalEmailAddresses { get; set; }

    /// <summary>
    ///  Indicates if associated invoices can be edited. **Character limit**: 5 **Values**: `true`, `false` (default if left null) 
    /// </summary>
    /// <value> Indicates if associated invoices can be edited. **Character limit**: 5 **Values**: `true`, `false` (default if left null) </value>
    [DataMember(Name="AllowInvoiceEdit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowInvoiceEdit")]
    public bool? AllowInvoiceEdit { get; set; }

    /// <summary>
    ///  Indicates if future payments are automatically collected when they're due during a Payment Run. **Character limit**: 5 **Values**: `true`, `false` (default) 
    /// </summary>
    /// <value> Indicates if future payments are automatically collected when they're due during a Payment Run. **Character limit**: 5 **Values**: `true`, `false` (default) </value>
    [DataMember(Name="AutoPay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AutoPay")]
    public bool? AutoPay { get; set; }

    /// <summary>
    /// Current outstanding balance for the account. **Character limit**: 16 **Values**: automatically generated 
    /// </summary>
    /// <value>Current outstanding balance for the account. **Character limit**: 16 **Values**: automatically generated </value>
    [DataMember(Name="Balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Balance")]
    public double? Balance { get; set; }

    /// <summary>
    ///  Organizes your customer accounts into groups to optimize your billing and payment operations. Required if use the [subscribe()](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E_SOAP_API_Calls/subscribe_call) call, optional for other supported calls. **Character limit**: 20 **Values**:any system-defined batch (`Batch1` - `Batch50 `or by name). 
    /// </summary>
    /// <value> Organizes your customer accounts into groups to optimize your billing and payment operations. Required if use the [subscribe()](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E_SOAP_API_Calls/subscribe_call) call, optional for other supported calls. **Character limit**: 20 **Values**:any system-defined batch (`Batch1` - `Batch50 `or by name). </value>
    [DataMember(Name="Batch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Batch")]
    public string Batch { get; set; }

    /// <summary>
    /// Billing cycle day setting option. **Character limit**: 9 **Values**: `AutoSet`, `ManualSet` 
    /// </summary>
    /// <value>Billing cycle day setting option. **Character limit**: 9 **Values**: `AutoSet`, `ManualSet` </value>
    [DataMember(Name="BcdSettingOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BcdSettingOption")]
    public string BcdSettingOption { get; set; }

    /// <summary>
    /// Billing cycle day (BCD) on which bill runs generate invoices for the account. **Character limit**: 2 **Values**: any activated system-defined bill cycle day (`1` - `31`) 
    /// </summary>
    /// <value>Billing cycle day (BCD) on which bill runs generate invoices for the account. **Character limit**: 2 **Values**: any activated system-defined bill cycle day (`1` - `31`) </value>
    [DataMember(Name="BillCycleDay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillCycleDay")]
    public int? BillCycleDay { get; set; }

    /// <summary>
    /// ID of the person to bill for the account. **Character limit**: 32 **Values**: a valid contact ID for the account 
    /// </summary>
    /// <value>ID of the person to bill for the account. **Character limit**: 32 **Values**: a valid contact ID for the account </value>
    [DataMember(Name="BillToId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillToId")]
    public string BillToId { get; set; }

    /// <summary>
    /// Associates the account with a specified communication profile. **Character limit**: 32 **Values**: a valid communication profile ID 
    /// </summary>
    /// <value>Associates the account with a specified communication profile. **Character limit**: 32 **Values**: a valid communication profile ID </value>
    [DataMember(Name="CommunicationProfileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CommunicationProfileId")]
    public string CommunicationProfileId { get; set; }

    /// <summary>
    /// ID of the Zuora user who created the Account object. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value>ID of the Zuora user who created the Account object. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="CreatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedById")]
    public string CreatedById { get; set; }

    /// <summary>
    /// Date when the Account object was created. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value>Date when the Account object was created. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Total credit balance for the account. **Character limit**: 16 **Values**: automatically generated 
    /// </summary>
    /// <value>Total credit balance for the account. **Character limit**: 16 **Values**: automatically generated </value>
    [DataMember(Name="CreditBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditBalance")]
    public double? CreditBalance { get; set; }

    /// <summary>
    /// CRM account ID for the account. A CRM is a customer relationship management system, such as Salesforce.com. **Character limit**: 100 **Values**: a string of 100 characters or fewer 
    /// </summary>
    /// <value>CRM account ID for the account. A CRM is a customer relationship management system, such as Salesforce.com. **Character limit**: 100 **Values**: a string of 100 characters or fewer </value>
    [DataMember(Name="CrmId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CrmId")]
    public string CrmId { get; set; }

    /// <summary>
    ///  Currency that the customer is billed in. See [a currency value defined in the Zuora Ui admin settings](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Customize_Currencies) 
    /// </summary>
    /// <value> Currency that the customer is billed in. See [a currency value defined in the Zuora Ui admin settings](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Customize_Currencies) </value>
    [DataMember(Name="Currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Name of the account's customer service representative, if applicable. **Character limit**: 50 **Values**: a string of 50 characters or fewer 
    /// </summary>
    /// <value>Name of the account's customer service representative, if applicable. **Character limit**: 50 **Values**: a string of 50 characters or fewer </value>
    [DataMember(Name="CustomerServiceRepName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerServiceRepName")]
    public string CustomerServiceRepName { get; set; }

    /// <summary>
    /// ID of the default payment method for the account. This field is required if the AutoPay field is set to `true`. **Character limit**: 32 **Values**: [a valid ID for an existing payment method](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/PaymentMethod) 
    /// </summary>
    /// <value>ID of the default payment method for the account. This field is required if the AutoPay field is set to `true`. **Character limit**: 32 **Values**: [a valid ID for an existing payment method](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/PaymentMethod) </value>
    [DataMember(Name="DefaultPaymentMethodId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultPaymentMethodId")]
    public string DefaultPaymentMethodId { get; set; }

    /// <summary>
    /// Object identifier.
    /// </summary>
    /// <value>Object identifier.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// Indicates if the customer wants to receive invoices through email.  **Character limit**: 5 **Values**: `true`, `false` (default if left null) 
    /// </summary>
    /// <value>Indicates if the customer wants to receive invoices through email.  **Character limit**: 5 **Values**: `true`, `false` (default if left null) </value>
    [DataMember(Name="InvoiceDeliveryPrefsEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceDeliveryPrefsEmail")]
    public bool? InvoiceDeliveryPrefsEmail { get; set; }

    /// <summary>
    /// Indicates if the customer wants to receive printed invoices, such as through postal mail. **Character limit**: 5 **Values**: `true`, `false` (default if left null) 
    /// </summary>
    /// <value>Indicates if the customer wants to receive printed invoices, such as through postal mail. **Character limit**: 5 **Values**: `true`, `false` (default if left null) </value>
    [DataMember(Name="InvoiceDeliveryPrefsPrint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceDeliveryPrefsPrint")]
    public bool? InvoiceDeliveryPrefsPrint { get; set; }

    /// <summary>
    /// The ID of the invoice template. Each customer account can use a specific invoice template for invoice generation. **Character limit**: 32 **Values**: a[ valid template ID configured in Z-Billing Settings](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Manage_Invoice_Rules_and_Templates) To find the ID of your current invoice template: In Zuora, navigate to **Settings > Z-Billing > Manage Invoice Rules and Templates** and click **Show Id **next to the template you want to use.   
    /// </summary>
    /// <value>The ID of the invoice template. Each customer account can use a specific invoice template for invoice generation. **Character limit**: 32 **Values**: a[ valid template ID configured in Z-Billing Settings](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Manage_Invoice_Rules_and_Templates) To find the ID of your current invoice template: In Zuora, navigate to **Settings > Z-Billing > Manage Invoice Rules and Templates** and click **Show Id **next to the template you want to use.   </value>
    [DataMember(Name="InvoiceTemplateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceTemplateId")]
    public string InvoiceTemplateId { get; set; }

    /// <summary>
    ///  The date when the previous invoice was generated for the account. The field value is null if no invoice has ever been generated for the account. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value> The date when the previous invoice was generated for the account. The field value is null if no invoice has ever been generated for the account. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="LastInvoiceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastInvoiceDate")]
    public DateTime? LastInvoiceDate { get; set; }

    /// <summary>
    /// Name of the account as displayed in the Zuora UI. **Character limit**: 255 **Values**: a string of 255 characters or fewer 
    /// </summary>
    /// <value>Name of the account as displayed in the Zuora UI. **Character limit**: 255 **Values**: a string of 255 characters or fewer </value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    ///  Comments about the account. **Character limit**: 65,535 **Values**: a string of 65,535 characters 
    /// </summary>
    /// <value> Comments about the account. **Character limit**: 65,535 **Values**: a string of 65,535 characters </value>
    [DataMember(Name="Notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Notes")]
    public string Notes { get; set; }

    /// <summary>
    /// Identifier of the parent customer account for this Account object. Use this field if you have customer hierarchy enabled. **Character limit**: 32 **Values**: [a valid account ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account#Id) 
    /// </summary>
    /// <value>Identifier of the parent customer account for this Account object. Use this field if you have customer hierarchy enabled. **Character limit**: 32 **Values**: [a valid account ID](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Account#Id) </value>
    [DataMember(Name="ParentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentId")]
    public string ParentId { get; set; }

    /// <summary>
    /// Gateway used for processing electronic payments and refunds. **Character limit**: 40 **Values**: one of the following:  - a valid configured gateway name - Null to inherit the default value set in Z-Payment Settings 
    /// </summary>
    /// <value>Gateway used for processing electronic payments and refunds. **Character limit**: 40 **Values**: one of the following:  - a valid configured gateway name - Null to inherit the default value set in Z-Payment Settings </value>
    [DataMember(Name="PaymentGateway", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentGateway")]
    public string PaymentGateway { get; set; }

    /// <summary>
    /// Indicates when the customer pays for subscriptions. **Character limit**: 100 **Values**: [a valid, active payment term defined in the web-based UI administrative settings](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Payment_Terms) 
    /// </summary>
    /// <value>Indicates when the customer pays for subscriptions. **Character limit**: 100 **Values**: [a valid, active payment term defined in the web-based UI administrative settings](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Payment_Terms) </value>
    [DataMember(Name="PaymentTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentTerm")]
    public string PaymentTerm { get; set; }

    /// <summary>
    /// The number of the purchase order associated with this account. Purchase order information generally comes from customers. **Character limit**: 100 **Values**: a string of 100 characters or fewer 
    /// </summary>
    /// <value>The number of the purchase order associated with this account. Purchase order information generally comes from customers. **Character limit**: 100 **Values**: a string of 100 characters or fewer </value>
    [DataMember(Name="PurchaseOrderNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PurchaseOrderNumber")]
    public string PurchaseOrderNumber { get; set; }

    /// <summary>
    /// The name of the sales representative associated with this account, if applicable. **Character limit**: 50 **Values**: a string of 50 characters or fewer 
    /// </summary>
    /// <value>The name of the sales representative associated with this account, if applicable. **Character limit**: 50 **Values**: a string of 50 characters or fewer </value>
    [DataMember(Name="SalesRepName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SalesRepName")]
    public string SalesRepName { get; set; }

    /// <summary>
    /// ID of the person who bought the subscription associated with the account. **Character limit**: 32 **Values**: [a valid contact ID for the account](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Contact) 
    /// </summary>
    /// <value>ID of the person who bought the subscription associated with the account. **Character limit**: 32 **Values**: [a valid contact ID for the account](https://knowledgecenter.zuora.com/DC_Developers/SOAP_API/E1_SOAP_API_Object_Reference/Contact) </value>
    [DataMember(Name="SoldToId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SoldToId")]
    public string SoldToId { get; set; }

    /// <summary>
    /// Status of the account in the system. **Character limit**: 8 **Values**: one of the following:  - leave null if you're using `subscribe()` - if you're using `create()`: - `Draft` - `Active` - `Canceled` 
    /// </summary>
    /// <value>Status of the account in the system. **Character limit**: 8 **Values**: one of the following:  - leave null if you're using `subscribe()` - if you're using `create()`: - `Draft` - `Active` - `Canceled` </value>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    ///  Unique code that identifies a company account in Avalara. Use this field to calculate taxes based on origin and sold-to addresses in Avalara. This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  **Character limit**: 50 **Values**: a valid company code 
    /// </summary>
    /// <value> Unique code that identifies a company account in Avalara. Use this field to calculate taxes based on origin and sold-to addresses in Avalara. This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  **Character limit**: 50 **Values**: a valid company code </value>
    [DataMember(Name="TaxCompanyCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxCompanyCode")]
    public string TaxCompanyCode { get; set; }

    /// <summary>
    /// ID of your customer's tax exemption certificate. **Character limit**: 32 **Values**: a string of 32 characters or fewer 
    /// </summary>
    /// <value>ID of your customer's tax exemption certificate. **Character limit**: 32 **Values**: a string of 32 characters or fewer </value>
    [DataMember(Name="TaxExemptCertificateID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxExemptCertificateID")]
    public string TaxExemptCertificateID { get; set; }

    /// <summary>
    /// Type of the tax exemption certificate that your customer holds.  **Character limit**: 32 **Values**: a string of 32 characters or fewer 
    /// </summary>
    /// <value>Type of the tax exemption certificate that your customer holds.  **Character limit**: 32 **Values**: a string of 32 characters or fewer </value>
    [DataMember(Name="TaxExemptCertificateType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxExemptCertificateType")]
    public string TaxExemptCertificateType { get; set; }

    /// <summary>
    /// Description of the tax exemption certificate that your customer holds. **Character limit**: 500 **Values**: a string of 500 characters or fewer 
    /// </summary>
    /// <value>Description of the tax exemption certificate that your customer holds. **Character limit**: 500 **Values**: a string of 500 characters or fewer </value>
    [DataMember(Name="TaxExemptDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxExemptDescription")]
    public string TaxExemptDescription { get; set; }

    /// <summary>
    /// Date when the the customer's tax exemption starts. **Character limit**: 29 **Version notes**: requires Z-Tax 
    /// </summary>
    /// <value>Date when the the customer's tax exemption starts. **Character limit**: 29 **Version notes**: requires Z-Tax </value>
    [DataMember(Name="TaxExemptEffectiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxExemptEffectiveDate")]
    public DateTime? TaxExemptEffectiveDate { get; set; }

    /// <summary>
    /// Date when the customer's tax exemption certificate expires  **Character limit**: 29 **Version notes**: requires Z-Tax 
    /// </summary>
    /// <value>Date when the customer's tax exemption certificate expires  **Character limit**: 29 **Version notes**: requires Z-Tax </value>
    [DataMember(Name="TaxExemptExpirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxExemptExpirationDate")]
    public DateTime? TaxExemptExpirationDate { get; set; }

    /// <summary>
    /// Indicates the jurisdiction in which the customer's tax exemption certificate was issued. **Character limit**: 32 **Values**: a string of 32 characters or fewer 
    /// </summary>
    /// <value>Indicates the jurisdiction in which the customer's tax exemption certificate was issued. **Character limit**: 32 **Values**: a string of 32 characters or fewer </value>
    [DataMember(Name="TaxExemptIssuingJurisdiction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxExemptIssuingJurisdiction")]
    public string TaxExemptIssuingJurisdiction { get; set; }

    /// <summary>
    ///  Status of the account's tax exemption. Required if you use Z-Tax. This field is unavailable if you don't use Z-Tax. **Character limit**: 19 **Values**: one of the following:  - `Yes` - `No` - `PendingVerification` 
    /// </summary>
    /// <value> Status of the account's tax exemption. Required if you use Z-Tax. This field is unavailable if you don't use Z-Tax. **Character limit**: 19 **Values**: one of the following:  - `Yes` - `No` - `PendingVerification` </value>
    [DataMember(Name="TaxExemptStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxExemptStatus")]
    public string TaxExemptStatus { get; set; }

    /// <summary>
    /// Total balance of the account's invoices. **Character limit**: 16 **Values**: a valid currency value 
    /// </summary>
    /// <value>Total balance of the account's invoices. **Character limit**: 16 **Values**: a valid currency value </value>
    [DataMember(Name="TotalInvoiceBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalInvoiceBalance")]
    public double? TotalInvoiceBalance { get; set; }

    /// <summary>
    /// ID of the user who last updated the account. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value>ID of the user who last updated the account. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedById", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedById")]
    public string UpdatedById { get; set; }

    /// <summary>
    /// Date when the account was last updated. **Character limit**: 29 **Values**: automatically generated 
    /// </summary>
    /// <value>Date when the account was last updated. **Character limit**: 29 **Values**: automatically generated </value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }

    /// <summary>
    ///  EU Value Added Tax ID. This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  **Character limit**: 25 **Values**: a valid Value Added Tax ID 
    /// </summary>
    /// <value> EU Value Added Tax ID. This feature is in **Limited Availability**. If you wish to have access to the feature, submit a request at [Zuora Global Support](http://support.zuora.com/).  **Character limit**: 25 **Values**: a valid Value Added Tax ID </value>
    [DataMember(Name="VATId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VATId")]
    public string VATId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyGetAccount {\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  AdditionalEmailAddresses: ").Append(AdditionalEmailAddresses).Append("\n");
      sb.Append("  AllowInvoiceEdit: ").Append(AllowInvoiceEdit).Append("\n");
      sb.Append("  AutoPay: ").Append(AutoPay).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  Batch: ").Append(Batch).Append("\n");
      sb.Append("  BcdSettingOption: ").Append(BcdSettingOption).Append("\n");
      sb.Append("  BillCycleDay: ").Append(BillCycleDay).Append("\n");
      sb.Append("  BillToId: ").Append(BillToId).Append("\n");
      sb.Append("  CommunicationProfileId: ").Append(CommunicationProfileId).Append("\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreditBalance: ").Append(CreditBalance).Append("\n");
      sb.Append("  CrmId: ").Append(CrmId).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  CustomerServiceRepName: ").Append(CustomerServiceRepName).Append("\n");
      sb.Append("  DefaultPaymentMethodId: ").Append(DefaultPaymentMethodId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InvoiceDeliveryPrefsEmail: ").Append(InvoiceDeliveryPrefsEmail).Append("\n");
      sb.Append("  InvoiceDeliveryPrefsPrint: ").Append(InvoiceDeliveryPrefsPrint).Append("\n");
      sb.Append("  InvoiceTemplateId: ").Append(InvoiceTemplateId).Append("\n");
      sb.Append("  LastInvoiceDate: ").Append(LastInvoiceDate).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      sb.Append("  PaymentGateway: ").Append(PaymentGateway).Append("\n");
      sb.Append("  PaymentTerm: ").Append(PaymentTerm).Append("\n");
      sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
      sb.Append("  SalesRepName: ").Append(SalesRepName).Append("\n");
      sb.Append("  SoldToId: ").Append(SoldToId).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  TaxCompanyCode: ").Append(TaxCompanyCode).Append("\n");
      sb.Append("  TaxExemptCertificateID: ").Append(TaxExemptCertificateID).Append("\n");
      sb.Append("  TaxExemptCertificateType: ").Append(TaxExemptCertificateType).Append("\n");
      sb.Append("  TaxExemptDescription: ").Append(TaxExemptDescription).Append("\n");
      sb.Append("  TaxExemptEffectiveDate: ").Append(TaxExemptEffectiveDate).Append("\n");
      sb.Append("  TaxExemptExpirationDate: ").Append(TaxExemptExpirationDate).Append("\n");
      sb.Append("  TaxExemptIssuingJurisdiction: ").Append(TaxExemptIssuingJurisdiction).Append("\n");
      sb.Append("  TaxExemptStatus: ").Append(TaxExemptStatus).Append("\n");
      sb.Append("  TotalInvoiceBalance: ").Append(TotalInvoiceBalance).Append("\n");
      sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
      sb.Append("  VATId: ").Append(VATId).Append("\n");
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
