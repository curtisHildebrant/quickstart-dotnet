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
  public class GETAccountingPeriodFileIdsType {
    /// <summary>
    /// File ID of the [Accounts Receivable Aging Account Detail](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/F_View_Accounting_Period_Balances/Accounts_Receivable_Aging#Invoice_Aging_Details) report. 
    /// </summary>
    /// <value>File ID of the [Accounts Receivable Aging Account Detail](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/F_View_Accounting_Period_Balances/Accounts_Receivable_Aging#Invoice_Aging_Details) report. </value>
    [DataMember(Name="accountsReceivableAccountAgingDetailExportFileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountsReceivableAccountAgingDetailExportFileId")]
    public string AccountsReceivableAccountAgingDetailExportFileId { get; set; }

    /// <summary>
    /// File ID of the [Accounts Receivable Aging Invoice Detail](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/F_View_Accounting_Period_Balances/Accounts_Receivable_Aging#Account_Aging_Details) report. 
    /// </summary>
    /// <value>File ID of the [Accounts Receivable Aging Invoice Detail](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/F_View_Accounting_Period_Balances/Accounts_Receivable_Aging#Account_Aging_Details) report. </value>
    [DataMember(Name="accountsReceivableInvoiceAgingDetailExportFileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountsReceivableInvoiceAgingDetailExportFileId")]
    public string AccountsReceivableInvoiceAgingDetailExportFileId { get; set; }

    /// <summary>
    /// File ID of the [Accounts Receivable Detail](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/F_View_Accounting_Period_Balances/Accounts_Receivable#Accounts_Receivable_Detail_Report) report. 
    /// </summary>
    /// <value>File ID of the [Accounts Receivable Detail](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/F_View_Accounting_Period_Balances/Accounts_Receivable#Accounts_Receivable_Detail_Report) report. </value>
    [DataMember(Name="arRollForwardDetailExportFileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "arRollForwardDetailExportFileId")]
    public string ArRollForwardDetailExportFileId { get; set; }

    /// <summary>
    /// File ID of the [Realized Gain and Loss Detail](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/F_View_Accounting_Period_Balances/Foreign_Currency_Gains_and_Losses#Realized_Gain.2FLoss_Detail_Report) report.  Returned only if you have [Foreign Currency Conversion](https://knowledgecenter.zuora.com/CC_Finance/Foreign_Currency_Conversion) enabled. 
    /// </summary>
    /// <value>File ID of the [Realized Gain and Loss Detail](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/F_View_Accounting_Period_Balances/Foreign_Currency_Gains_and_Losses#Realized_Gain.2FLoss_Detail_Report) report.  Returned only if you have [Foreign Currency Conversion](https://knowledgecenter.zuora.com/CC_Finance/Foreign_Currency_Conversion) enabled. </value>
    [DataMember(Name="fxRealizedGainAndLossDetailExportFileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fxRealizedGainAndLossDetailExportFileId")]
    public string FxRealizedGainAndLossDetailExportFileId { get; set; }

    /// <summary>
    /// File ID of the [Unrealized Gain and Loss Detail](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/F_View_Accounting_Period_Balances/Foreign_Currency_Gains_and_Losses#Unrealized_Gain.2FLoss_Detailed_Report) report.  Returned only if you have [Foreign Currency Conversion](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/F_View_Accounting_Period_Balances/Foreign_Currency_Gains_and_Losses#Unrealized_Gain.2FLoss_Detailed_Report) enabled 
    /// </summary>
    /// <value>File ID of the [Unrealized Gain and Loss Detail](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/F_View_Accounting_Period_Balances/Foreign_Currency_Gains_and_Losses#Unrealized_Gain.2FLoss_Detailed_Report) report.  Returned only if you have [Foreign Currency Conversion](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/F_View_Accounting_Period_Balances/Foreign_Currency_Gains_and_Losses#Unrealized_Gain.2FLoss_Detailed_Report) enabled </value>
    [DataMember(Name="fxUnrealizedGainAndLossDetailExportFileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fxUnrealizedGainAndLossDetailExportFileId")]
    public string FxUnrealizedGainAndLossDetailExportFileId { get; set; }

    /// <summary>
    /// File ID of the [Revenue Detail](https://knowledgecenter.zuora.com/CC_Finance/Revenue_Recognition/X_Accounting_Period_Revenue_Detail) report in CSV format. 
    /// </summary>
    /// <value>File ID of the [Revenue Detail](https://knowledgecenter.zuora.com/CC_Finance/Revenue_Recognition/X_Accounting_Period_Revenue_Detail) report in CSV format. </value>
    [DataMember(Name="revenueDetailCsvFileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueDetailCsvFileId")]
    public string RevenueDetailCsvFileId { get; set; }

    /// <summary>
    /// File ID of the [Revenue Detail](https://knowledgecenter.zuora.com/CC_Finance/Revenue_Recognition/X_Accounting_Period_Revenue_Detail) report in XLSX format. 
    /// </summary>
    /// <value>File ID of the [Revenue Detail](https://knowledgecenter.zuora.com/CC_Finance/Revenue_Recognition/X_Accounting_Period_Revenue_Detail) report in XLSX format. </value>
    [DataMember(Name="revenueDetailExcelFileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenueDetailExcelFileId")]
    public string RevenueDetailExcelFileId { get; set; }

    /// <summary>
    /// File ID of a report containing all [unprocessed charges](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/G_Reconcile_transactions_before_closing_an_accounting_period#Optional:_Clear_unprocessed_charges) for the accounting period. 
    /// </summary>
    /// <value>File ID of a report containing all [unprocessed charges](https://knowledgecenter.zuora.com/CC_Finance/A_Z-Finance/E_Accounting_Periods/G_Reconcile_transactions_before_closing_an_accounting_period#Optional:_Clear_unprocessed_charges) for the accounting period. </value>
    [DataMember(Name="unprocessedChargesFileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unprocessedChargesFileId")]
    public string UnprocessedChargesFileId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GETAccountingPeriodFileIdsType {\n");
      sb.Append("  AccountsReceivableAccountAgingDetailExportFileId: ").Append(AccountsReceivableAccountAgingDetailExportFileId).Append("\n");
      sb.Append("  AccountsReceivableInvoiceAgingDetailExportFileId: ").Append(AccountsReceivableInvoiceAgingDetailExportFileId).Append("\n");
      sb.Append("  ArRollForwardDetailExportFileId: ").Append(ArRollForwardDetailExportFileId).Append("\n");
      sb.Append("  FxRealizedGainAndLossDetailExportFileId: ").Append(FxRealizedGainAndLossDetailExportFileId).Append("\n");
      sb.Append("  FxUnrealizedGainAndLossDetailExportFileId: ").Append(FxUnrealizedGainAndLossDetailExportFileId).Append("\n");
      sb.Append("  RevenueDetailCsvFileId: ").Append(RevenueDetailCsvFileId).Append("\n");
      sb.Append("  RevenueDetailExcelFileId: ").Append(RevenueDetailExcelFileId).Append("\n");
      sb.Append("  UnprocessedChargesFileId: ").Append(UnprocessedChargesFileId).Append("\n");
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
