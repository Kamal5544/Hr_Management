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
    public partial class frmCountry : Form
    {
        public frmCountry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HR_MDB;Integrated Security=True;MultipleActiveResultSets=true;MultipleActiveResultSets=true");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert Into tblCountry Values('" + txtCountryName.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            lblMsgShow.Text = "Data Inserted Successfully";
            txtCountryName.Clear();
            txtCountryName.Focus();
            con.Close();

        }
    }
}
