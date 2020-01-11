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
    public partial class frmRegistration : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HR_MDB;Integrated Security=True;MultipleActiveResultSets=true");
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert Into tblUser Values('" + txtName.Text + "','" + txtEmail.Text + "','" + txtPassword.Text + "','" + txtContact.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Data Inserted Successfully");
            this.Hide();
            new frmLogin().Show();
            con.Close();
        }
        
    }
}
