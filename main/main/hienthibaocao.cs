using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace main
{
    public partial class hienthibaocao : Form
    {
        public hienthibaocao()
        {
            InitializeComponent();
        }

        private void hienthibaocao_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            CHATLIEU_BUS bus = new CHATLIEU_BUS();
            List<CHATLIEU_DTO> ds = bus.LayDSChatLieu();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLy.Report1.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSchatlieu", ds));
            this.reportViewer1.RefreshReport();
        }
        public void Tatcachatlieu()
        {
            //CHATLIEU_BUS bus = new CHATLIEU_BUS();
            //List<CHATLIEU_DTO> ds = bus.LayDSChatLieu();
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLy.Report1.rdlc";
            //this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSchatlieu", ds));
            //this.reportViewer1.RefreshReport();
        }
    }
}
