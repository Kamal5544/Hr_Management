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
    
    public partial class frmCity : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HR_MDB;Integrated Security=True;MultipleActiveResultSets=true;MultipleActiveResultSets=true");
        public frmCity()
        {
            InitializeComponent();
        }
        private void LoadCountry()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tblCountry", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbCountry.DisplayMember = ds.Tables[0].Columns["countryName"].ToString();
            cmbCountry.ValueMember = ds.Tables[0].Columns["countryId"].ToString();
            cmbCountry.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert Into tblCity Values('"+txtCityName.Text+"','"+cmbCountry.SelectedValue+"')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully");
            txtCityName.Clear();
            txtCityName.Focus();
            con.Close();
            con.Close();
        }

        private void frmCity_Load(object sender, EventArgs e)
        {
            LoadCountry();
            cmbCountry.SelectedIndex = -1;
        }
    }
}
