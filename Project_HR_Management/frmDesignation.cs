using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Project_HR_Management
{
    public partial class frmDesignation : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HR_MDB;Integrated Security=True;MultipleActiveResultSets=true");
        public frmDesignation()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert Into tblDesignation Values('" + txtDesigName.Text + "','"+cmbDepartment.SelectedValue+"')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully!!!");
            txtDesigName.Clear();
            txtDesigName.Focus();
            con.Close();
        }

        private void frmDesignation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dept_Load.tblDepartment' table. You can move, or remove it, as needed.
            this.tblDepartmentTableAdapter.Fill(this.dept_Load.tblDepartment);
            // TODO: This line of code loads data into the 'hR_MDBDataSet1.tblDepartment' table. You can move, or remove it, as needed.


        }
    }
}
