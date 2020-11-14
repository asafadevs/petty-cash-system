using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NetOne_Cash_Requisition_System
{
    public partial class Refill_Fundcs : Form
    {

        public decimal refillamount;
        public decimal newbalance;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");

        public Refill_Fundcs()
        {
            InitializeComponent();
        }

        private void Refillbtn_Click(object sender, EventArgs e)
        {
            refillamount = Convert.ToDecimal(refillamonuttxtbx.Text);
            newbalance = Paymentsfrm.vbudget_limit + refillamount;

            if (newbalance > 5000)
            {
                MessageBox.Show("Petty cash fund balance cannot exceed $5000.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                refillamonuttxtbx.Clear();
            }
            else
            {
                con.Open();
                SqlCommand UpdateCommand = new SqlCommand("update department set budget_limit = '" + newbalance + "' where department_name LIKE'" + Loginfrm.vdepartment + "'", con);
                SqlDataReader myReader;

                try
                {
                    myReader = UpdateCommand.ExecuteReader();
                    MessageBox.Show("Department Fund Refilled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refillamonuttxtbx.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                con.Close();
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            refillamonuttxtbx.Clear();
            this.Close();
        }

        private void Refillamonuttxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Refill_Fundcs_Load(object sender, EventArgs e)
        {

        }
    }
}