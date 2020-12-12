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
    public partial class TEST : Form
    {
        public TEST()
        {
            InitializeComponent();
        }

        private void TEST_Load(object sender, EventArgs e)
        {
            //CHATLIEU_BUS bus = new CHATLIEU_BUS();
            //List<CHATLIEU_DTO> ds = bus.LayDSChatLieu();
            //RPDanhSachChatLieu rp = new RPDanhSachChatLieu();
            //rp.SetDataSource(ds);
            //crystalReportViewer1.ReportSource = rp;
            //DataTable dt = new DataTable();
           
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }
    }
}
