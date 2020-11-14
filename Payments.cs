using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NetOne_Cash_Requisition_System
{
    public partial class Paymentsfrm : Form
    {
        public Paymentsfrm()
        {
            InitializeComponent();
        }

        public string voucher_id;
        public string requestor_id;
        public string amount;
        public static decimal vbudget_limit;
        public static decimal vnewbudget_limit;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");

        public void budgetlimitcheck()
        {
            SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("select budget_limit from department where department_name LIKE '" + Loginfrm.vdepartment + "'", con3);

            try
            {
                con3.Open();

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        vbudget_limit = Convert.ToDecimal(read["budget_limit"]);
                    }
                }
            }
            finally
            {
                con3.Close();
            }
        }

        public void voucherupdate()
        {
            SqlCommand UpdateCommand = new SqlCommand("update voucher set paid_status = 'Paid' where voucher_id LIKE'" + voucher_id + "'", con);
            SqlDataReader myReader;

            try
            {
                myReader = UpdateCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Paymentsfrm_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [voucher] WHERE department LIKE '" + Loginfrm.vdepartment + "' AND hod_approver LIKE 'Approved' AND paid_status LIKE 'Not Paid'", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            int numRows = dataGridView1.Rows.Count;
            numRows = numRows - 1;
            vaplbl.Text = numRows.ToString();
            departmentpcbnlbl.Text = $"{Loginfrm.vdepartment} Department Petty Cash Fund Balance:";
            budgetlimitcheck();
            balancelbl.Text = $"${vbudget_limit}";
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            voucher_id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            requestor_id = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            amount = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();

            var selectedoption = MessageBox.Show("Would you like to pay the requestor?", "Voucher Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (selectedoption == DialogResult.Yes)
            {
                budgetlimitcheck();
                vnewbudget_limit = vbudget_limit - Convert.ToDecimal(amount);

                //adjusts budget limit value in db.
                SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
                SqlCommand UpdateCommand = new SqlCommand("update department set budget_limit = '" + vnewbudget_limit + "' where department_name LIKE'" + Loginfrm.vdepartment + "'", con2);
                SqlDataReader myReader;

                try
                {
                    con2.Open();
                    myReader = UpdateCommand.ExecuteReader();
                    voucherupdate();
                    MessageBox.Show(String.Format("Requestor has been paid. The petty cash fund balance for the department is now ${0}.", vnewbudget_limit), "Payment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    Paymentsfrm_Load(sender, e);
                    balancelbl.Text = $"${vnewbudget_limit}";
                }
                finally
                {
                    con2.Close();
                }
            }
            if (selectedoption == DialogResult.No)
            {
                return;
            }
        }

        private void HomeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homemenufrm homemenufrm = new homemenufrm();
            homemenufrm.Show();
            this.Close();
        }

        private void Searchtxtbx_TextChanged(object sender, EventArgs e)
        {
            if (searchtxtbx.Text == "")
            {
                con.Close();
                Paymentsfrm_Load(sender, e);
            }
            else
            {
                searchdata();
            }
        }

        public void searchdata()
        {
            SqlConnection con4 = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
            con4.Open();
            SqlDataAdapter qry = new SqlDataAdapter("SELECT * FROM voucher WHERE (voucher_id LIKE '%" + searchtxtbx.Text + "%' or date LIKE '%" + searchtxtbx.Text + "%' or requestor_id LIKE '%" + searchtxtbx.Text + "%' or first_name LIKE '%" + searchtxtbx.Text + "%' or last_name LIKE '%" + searchtxtbx.Text + "%' or phone LIKE '%" + searchtxtbx.Text + "%' or email LIKE '%" + searchtxtbx.Text + "%' or amount LIKE '%" + searchtxtbx.Text + "%') AND department LIKE '%" + Loginfrm.vdepartment + "%' AND hod_approver LIKE 'Approved' AND paid_status LIKE 'Not Paid'", con4);
            DataTable dtb2 = new DataTable();
            qry.Fill(dtb2);
            dataGridView1.DataSource = dtb2;
            int numRows = dataGridView1.Rows.Count;
            numRows = numRows - 1;
            vaplbl.Text = numRows.ToString();
            con4.Close();
        }

        private void Refillbtn_Click(object sender, EventArgs e)
        {
            if (vbudget_limit < 3000)
            {
                Refill_Fundcs refillfundcs = new Refill_Fundcs();
                refillfundcs.Show();
            }
            else
            {
                MessageBox.Show("The petty cash fund balance is above the allowed refill balance. You can only refill when the balance is below $3000", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Createvoucherfrm createvoucherfrm = new Createvoucherfrm();
            createvoucherfrm.Show();
            this.Close();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loginfrm loginfrm = new Loginfrm();
            loginfrm.Visible = true;
            this.Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}