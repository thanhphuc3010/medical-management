using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management
{
    public partial class rptDoanhthuprv : Form
    {
        public rptDoanhthuprv(rptDoanhthu rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt; 
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
