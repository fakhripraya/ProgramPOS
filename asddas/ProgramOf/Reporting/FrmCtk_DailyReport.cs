using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProgramOf.DataAccess;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace ProgramOf.Reporting
{
    public partial class FrmCtk_DailyReport : Form
    {
        public FrmCtk_DailyReport()
        {
            InitializeComponent();
        }

        private void FrmCtk_DailyReport_Load(object sender, EventArgs e)
        {
        }

        private void CmdCetak_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            string sql = "SELECT station,namakasir,tgltransaksi,sum(BKP) BKP,sum(BTKP) BTKP,SUM(kupon) Kupon,sum(tunai) tunai,sum(kredit) kredit," +
                "sum(kaskupon) kaskupon,sum(kastunai) kastunai,sum(modal) modal,sum(Total_ISaku) Total_ISaku,sum(PB1) PB1 from sitrnrec" +
                " where tgltransaksi = '" + date + "'" +
                "group by tgltransaksi;";

            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("d:/CrystalReport/CrystalReport1.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = dtp.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["fromDate"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = dtp.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["toDate"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "tenantbsd";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "Root@gatau123";

            CrTables = cryRpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
