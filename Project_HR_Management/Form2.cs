using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_HR_Management
{
    public partial class Form2 : Form
    {
        List<ShowSalary_Result> list;
        public Form2(List<ShowSalary_Result> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            salary_Report1.SetDataSource(list);
            crystalReportViewer1.Refresh();
        }
    }
}
