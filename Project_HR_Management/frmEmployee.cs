namespace Project_HR_Management
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="frmEmployee" />
    /// </summary>
    public partial class frmEmployee : Form
    {
        /// <summary>
        /// Defines the con
        /// </summary>
        internal SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HR_MDB;Integrated Security=True;MultipleActiveResultSets=true;MultipleActiveResultSets=true");

        /// <summary>
        /// Initializes a new instance of the <see cref="frmEmployee"/> class.
        /// </summary>
        public frmEmployee()
        {
            InitializeComponent();
            LoadkkCountry();
        }

        private void LoadkkCountry()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblCountry", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbCountry.DisplayMember = ds.Tables[0].Columns["countryName"].ToString();
            cmbCountry.ValueMember = ds.Tables[0].Columns["countryId"].ToString();
            cmbCountry.DataSource = ds.Tables[0];

        }

        /// <summary>
        /// The frmEmployee_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void frmEmployee_Load(object sender, EventArgs e)
        {


            /*LoadCountry*//*();*/
            LoadCity();
            LoadReligion();
            LoadGender();
            LoadDesignation();
            LoadSection();
            LoadDepartment();
            LoadGrid();
            cmbCity.SelectedIndex = -1;
            cmbCountry.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;
            cmbDesignation.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            cmbReligion.SelectedIndex = -1;
            cmbSection.SelectedIndex = -1;
        }

        /// <summary>
        /// The LoadCountry
        /// </summary>
        private void LoadCountry()
        {
            //con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblCountry", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbCountry.DisplayMember = ds.Tables[0].Columns["countryName"].ToString();
            cmbCountry.ValueMember = ds.Tables[0].Columns["countryId"].ToString();
            cmbCountry.DataSource = ds.Tables[0];
            //con.Close();
        }

        /// <summary>
        /// The LoadCity
        /// </summary>
        private void LoadCity()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblCity", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbCity.DisplayMember = ds.Tables[0].Columns["cityName"].ToString();
            cmbCity.ValueMember = ds.Tables[0].Columns["cityId"].ToString();
            cmbCity.DataSource = ds.Tables[0];
            con.Close();
        }

        /// <summary>
        /// The LoadReligion
        /// </summary>
        private void LoadReligion()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblReligion", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbReligion.DisplayMember = ds.Tables[0].Columns["religionName"].ToString();
            cmbReligion.ValueMember = ds.Tables[0].Columns["religionId"].ToString();
            cmbReligion.DataSource = ds.Tables[0];
            con.Close();
        }

        /// <summary>
        /// The LoadGender
        /// </summary>
        private void LoadGender()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblGender", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbGender.DisplayMember = ds.Tables[0].Columns["genderName"].ToString();
            cmbGender.ValueMember = ds.Tables[0].Columns["genderId"].ToString();
            cmbGender.DataSource = ds.Tables[0];
            con.Close();
        }

        /// <summary>
        /// The LoadDesignation
        /// </summary>
        private void LoadDesignation()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblDesignation", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbDesignation.DisplayMember = ds.Tables[0].Columns["designationName"].ToString();
            cmbDesignation.ValueMember = ds.Tables[0].Columns["designationId"].ToString();
            cmbDesignation.DataSource = ds.Tables[0];
            con.Close();
        }

        /// <summary>
        /// The LoadSection
        /// </summary>
        private void LoadSection()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblSection", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbSection.DisplayMember = ds.Tables[0].Columns["sectionName"].ToString();
            cmbSection.ValueMember = ds.Tables[0].Columns["sectionId"].ToString();
            cmbSection.DataSource = ds.Tables[0];
            con.Close();
        }

        /// <summary>
        /// The LoadDepartment
        /// </summary>
        private void LoadDepartment()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblDepartment", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbDepartment.DisplayMember = ds.Tables[0].Columns["departmentName"].ToString();
            cmbDepartment.ValueMember = ds.Tables[0].Columns["departmentId"].ToString();
            cmbDepartment.DataSource = ds.Tables[0];
            con.Close();
        }

        /// <summary>
        /// The btnInsert_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Name is required!!");
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Address is required!!");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Email is required!!");
            }
            else if (txtPhone.Text == "")
            {
                MessageBox.Show("Phone No is required!!");
            }
            else if (txtSalary.Text == "")
            {
                MessageBox.Show("Salary is required!!");
            }
            else if (cmbCity.Text == "")
            {
                MessageBox.Show("City is required!!");
            }
            else if (cmbCountry.Text == "")
            {
                MessageBox.Show("Country is required!!");
            }
            else if (cmbDepartment.Text == "")
            {
                MessageBox.Show("Department is required!!");
            }
            else if (cmbDesignation.Text == "")
            {
                MessageBox.Show("Designation is required!!");
            }
            else if (cmbGender.Text == "")
            {
                MessageBox.Show("Gender is required!!");
            }
            else if (cmbReligion.Text == "")
            {
                MessageBox.Show("Religion is required!!");
            }
            else if (cmbSection.Text == "")
            {
                MessageBox.Show("Section is required!!");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert Into tblEmployee Values('" + txtName.Text + "','" + txtAddress.Text + "','" + dtpDOB.Value.ToString() + "'," + txtPhone.Text + ",'" + txtEmail.Text + "','" + txtSalary.Text + "','" + dtpJoiningDate.Value.ToString() + "','" + cmbDesignation.SelectedValue + "','" + cmbSection.SelectedValue + "','" + cmbDepartment.SelectedValue + "','" + cmbGender.SelectedValue + "','" + cmbReligion.SelectedValue + "','" + cmbCity.SelectedValue + "','" + cmbCountry.SelectedValue + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!!!");
                txtName.Clear();
                txtAddress.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtSalary.Clear();
                cmbCity.SelectedIndex = -1;
                cmbCountry.SelectedIndex = -1;
                cmbDepartment.SelectedIndex = -1;
                cmbDesignation.SelectedIndex = -1;
                cmbGender.SelectedIndex = -1;
                cmbReligion.SelectedIndex = -1;
                cmbSection.SelectedIndex = -1;
                txtName.Focus();
                con.Close();
            }
            //LoadCountry();
            //LoadCity();
            //LoadReligion();
            //LoadGender();
            //LoadDesignation();
            //LoadSection();
            //LoadDepartment();
            LoadGrid();
        }

        /// <summary>
        /// The ClearAll
        /// </summary>
        private void ClearAll()
        {
            cmbCity.SelectedIndex = -1;
            cmbCountry.SelectedIndex = -1;
        }

        /// <summary>
        /// The btnSearch_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtEmpIdSearch.Text=="")
            {
                MessageBox.Show("Please Enter Employee ID");
            }
            //if (cmbCountry.SelectedIndex == 0)
            //{
            //    MessageBox.Show("Please Select Country Before Searching !!");

            //}
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tblEmployee e " +
                      "join tblCity ci on e.cityId = ci.cityId " +
                      "join tblCountry c on e.countryId = c.countryId " +
                      "join tblDepartment de on e.departmentId = de.departmentId " +
                      "join tblDesignation dg on e.designationId = dg.designationId " +
                      "join tblGender g on e.genderId = g.genderId " +
                      "join tblReligion r on e.religionId = r.religionId " +
                      "join tblSection s on e.sectionId = s.sectionId " +
                       "where e.employeeId = " + txtEmpIdSearch.Text + "", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtName.Text = dr["employeeName"].ToString();
                    txtAddress.Text = dr["employeeAddress"].ToString();
                    dtpDOB.Text = dr["employeeDOB"].ToString();
                    txtPhone.Text = dr["employeePhone"].ToString();
                    txtEmail.Text = dr["employeeEmail"].ToString();
                    txtSalary.Text = dr["employeeCurrentSalary"].ToString();
                    dtpJoiningDate.Text = dr["employeeJoiningDate"].ToString();
                    cmbDesignation.SelectedValue = dr["designationId"].ToString();

                    //cmbCountry.SelectedText= dr["countryName"].ToString();
                    //cmbCountry.SelectedValue = dr["countryId"].ToString();

                    ////cmbCity.SelectedText = dr["cityName"].ToString();
                    //cmbCity.SelectedValue = dr["cityId"].ToString();
                    cmbDepartment.SelectedValue = dr["departmentId"].ToString();
                    cmbSection.SelectedValue = dr["sectionId"].ToString();
                    cmbGender.SelectedValue = dr["genderId"].ToString();
                    cmbReligion.SelectedValue = dr["religionId"].ToString();
                }
                dr.Close();
                con.Close();
                LoadGridOnSearch();
            }            
        }


        /// <summary>
        /// The fillByToolStripButton_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The cmbCountry_SelectedIndexChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblCity Where countryId='" + cmbCountry.SelectedValue + "'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbCity.DisplayMember = ds.Tables[0].Columns["cityName"].ToString();
            cmbCity.ValueMember = ds.Tables[0].Columns["cityId"].ToString();
            cmbCity.DataSource = ds.Tables[0];
            con.Close();
        }

        /// <summary>
        /// The LoadGrid
        /// </summary>
        private void LoadGrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select e.employeeId as ID,e.employeeName as Name,con.countryName as Country,ct.cityName as City,e.employeeAddress As Address,e.employeeDOB as DOB,e.employeePhone as phone,e.employeeCurrentSalary as Salary,e.employeeJoiningDate as Joinig_Date,dsg.designationName as Designation,dpt.departmentName as Department,g.genderName as Gender,r.religionName as Religion,s.sectionName as Section from tblEmployee e" +
" join tblDepartment dpt on e.departmentId = dpt.departmentId " +
" join tblDesignation dsg on e.designationId = dsg.designationId " +
" join tblGender g on e.genderId = g.genderId " +
" join tblSection s on e.sectionId = s.sectionId " +
" join tblReligion r on e.religionId = r.religionId " +
" join tblCountry con  on e.countryId = con.countryId " +
" join tblCity ct on e.cityId = ct.cityId ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        /// <summary>
        /// The LoadGridOnSearch
        /// </summary>
        private void LoadGridOnSearch()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblEmployee where employeeId = " + txtEmpIdSearch.Text + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        /// <summary>
        /// The btnNameSearch_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Name is empty!!");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT e.EmployeeId AS ID, e.employeeName, d.departmentName, dg.designationName, e.employeeJoiningDate AS [Joining Date], CAST(e.employeeCurrentSalary AS NUMERIC(10,2)) AS Salary, e.employeeEmail, e.employeePhone [Mobile No.], e.employeeDOB AS [Date Of Birth]  FROM tblEmployee e INNER JOIN tblCountry co ON e.CountryId = co.CountryId INNER JOIN tblCity ci ON e.CityId = ci.CityId INNER JOIN tblDepartment d ON e.DepartmentId = d.DepartmentId INNER JOIN tblDesignation dg ON e.DesignationId = dg.DesignationId INNER JOIN tblSection s ON e.SectionId = s.SectionId WHERE e.employeeName LIKE '%" + txtName.Text + "%'", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Employee found");
                }
                con.Close();
            }
        }

        /// <summary>
        /// The txtPhone_KeyPress
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/></param>
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ab = e.KeyChar;
            if (char.IsDigit(ab) == true || ab == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Only Number Allowed!!");
                e.Handled = true;
            }
        }

        /// <summary>
        /// The txtSalary_KeyPress
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/></param>
        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ab = e.KeyChar;
            if (char.IsDigit(ab) == true || ab == 8 || ab == 46)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Only Numeric No is allowed!!");
                e.Handled = true;
            }
        }

        /// <summary>
        /// The txtName_KeyPress
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/></param>
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ab = e.KeyChar;
            if (char.IsLetter(ab) == true || ab == 8 || ab == 32 || ab == 45 || ab == 46)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Only Text like space, text, notation sign are allowed!!");
                e.Handled = true;
            }
        }

        /// <summary>
        /// The btnUpdate_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Name is required!!");
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Address is required!!");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Email is required!!");
            }
            else if (txtPhone.Text == "")
            {
                MessageBox.Show("Phone No is required!!");
            }
            else if (txtSalary.Text == "")
            {
                MessageBox.Show("Salary is required!!");
            }
            else if (cmbCity.Text == "")
            {
                MessageBox.Show("City is required!!");
            }
            else if (cmbCountry.Text == "")
            {
                MessageBox.Show("Country is required!!");
            }
            else if (cmbDepartment.Text == "")
            {
                MessageBox.Show("Department is required!!");
            }
            else if (cmbDesignation.Text == "")
            {
                MessageBox.Show("Designation is required!!");
            }
            else if (cmbGender.Text == "")
            {
                MessageBox.Show("Gender is required!!");
            }
            else if (cmbReligion.Text == "")
            {
                MessageBox.Show("Religion is required!!");
            }
            else if (cmbSection.Text == "")
            {
                MessageBox.Show("Section is required!!");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Update tblEmployee Set employeeName='" + txtName.Text + "',employeeAddress='" + txtAddress.Text + "',employeeDOB='" + dtpDOB.Value + "',employeePhone='" + txtPhone.Text + "',employeeEmail='" + txtEmail.Text + "',employeeCurrentSalary=" + txtSalary.Text + ",employeeJoiningDate='" + dtpJoiningDate.Value + "',designationId='" + cmbDesignation.SelectedValue + "',sectionId='" + cmbSection.SelectedValue + "',departmentId='" + cmbDepartment.SelectedValue + "',genderId='" + cmbGender.SelectedValue + "',religionId='" + cmbReligion.SelectedValue + "',cityId='" + cmbCity.SelectedValue + "',countryId='" + cmbCountry.SelectedValue + "' where employeeId=" + txtEmpIdSearch.Text + "";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully!!!");
                txtName.Clear();
                txtAddress.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtSalary.Clear();
                cmbCity.SelectedIndex = -1;
                cmbCountry.SelectedIndex = -1;
                cmbDepartment.SelectedIndex = -1;
                cmbDesignation.SelectedIndex = -1;
                cmbGender.SelectedIndex = -1;
                cmbReligion.SelectedIndex = -1;
                cmbSection.SelectedIndex = -1;
                txtName.Focus();
                LoadGrid();
                con.Close();
            }
        }

        /// <summary>
        /// The btnDelete_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Sure to Delete?", "confirmation",
                 MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete tblEmployee where employeeId=" + txtEmpIdSearch.Text + "";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully!!");
                txtName.Clear();
                txtAddress.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtSalary.Clear();
                cmbCity.SelectedIndex = -1;
                cmbCountry.SelectedIndex = -1;
                cmbDepartment.SelectedIndex = -1;
                cmbDesignation.SelectedIndex = -1;
                cmbGender.SelectedIndex = -1;
                cmbReligion.SelectedIndex = -1;
                cmbSection.SelectedIndex = -1;
                txtName.Focus();
                LoadGrid();
                con.Close();
            }
            else if (form1 == DialogResult.No)
            {
                this.Hide();
                new frmEmployee().Show();
            }


        }

        private void frmEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to close the program?",
                "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                Environment.Exit(0);
                Application.Exit();
            }
            else if (form1 == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //private void txtEmpIdSearch_TextChanged(object sender, EventArgs e)
        //{
        //    //txtEmpIdSearch.Text = "";

        //}

        private void txtEmpIdSearch_Click(object sender, EventArgs e)
        {
            ////cmbCountry.SelectedIndex < 0;
            //if (cmbCountry.SelectedIndex < 0)
            //{
            //    MessageBox.Show("Please Select Country Before Searching !!");
                
            //}
            //if (cmbCountry.SelectedIndex == 0)
            //{
            //    txtEmpIdSearch.Hide();
            //}
            //else
            //{
                
            //    txtSearch2.Show();
            //}

        }

        private void txtSearch2_TextChanged(object sender, EventArgs e)
        {
            //if (cmbCountry.SelectedIndex < 0)
            //{
            //    MessageBox.Show("Please Select Country Before Searching !!");
            //    //txtSearch2.Text = "";
            //}
            //else
            //{
            //    txtSearch2.Hide();
            //    txtEmpIdSearch.Show();
            //}

        }

        private void txtEmpIdSearch_TextChanged(object sender, EventArgs e)
        {
            //Application.Run(new frmEmployee());
        }
    }
}
