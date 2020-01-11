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
    public partial class Crystal_Report : Form
    {
        public Crystal_Report()
        {
            InitializeComponent();
        }

        private void Crystal_Report_Load(object sender, EventArgs e)
        {
            using(HR_MDBEntities db=new HR_MDBEntities())
            {
                showSalaryResultBindingSource.DataSource = db.ShowSalary().ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ShowSalary_Result> list = showSalaryResultBindingSource.DataSource as List<ShowSalary_Result>;
            if (list!=null)
            {
                using (Form2 frm = new Form2(list))
                {
                    frm.ShowDialog();
                }
            }
        }
    }
}
