using System;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;

namespace NetOne_Cash_Requisition_System
{
    public partial class Createvoucherfrm : Form
    {
        public static string vline_manager_id;
        public static string vapprover1email;
        public static decimal vbudget_limit;
        public static decimal vamount;
        public static decimal newbudget_limit;
        public string voucher_id;
        string vidadd = "VOU";

        public Createvoucherfrm()
        {
            InitializeComponent();
        }

        private void Createvoucherfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crsDataSet.voucher' table. You can move, or remove it, as needed.
            this.voucherTableAdapter.Fill(this.crsDataSet.voucher);
            amountTextBox.Clear();
            description_of_itemsTextBox.Clear();
            requestor_idTextBox.Text = Loginfrm.vuser_id;
            first_nameTextBox.Text = Loginfrm.vfirst_name;
            last_nameTextBox.Text = Loginfrm.vlast_name;
            phoneTextBox.Text = Loginfrm.vphone;
            emailTextBox.Text = Loginfrm.vemail;
            departmentTextBox.Text = Loginfrm.vdepartment;
            dateTextBox.Text = Loginfrm.vdate;
            manager_approverTextBox.Text = Loginfrm.vmanagerapprover;
            hod_approverTextBox.Text = Loginfrm.vhodapprover;
            paid_statusTextBox.Text = Loginfrm.vpaidstatus;
            justification_statusTextBox.Text = Loginfrm.vjustificationstatus;
            searchapprover();
            generateid();
        }

        //Refreshes the form to the original load state.
        void resetfrm()
        {
            this.voucherTableAdapter.Fill(this.crsDataSet.voucher);
            amountTextBox.Clear();
            description_of_itemsTextBox.Clear();
            requestor_idTextBox.Text = Loginfrm.vuser_id;
            first_nameTextBox.Text = Loginfrm.vfirst_name;
            last_nameTextBox.Text = Loginfrm.vlast_name;
            phoneTextBox.Text = Loginfrm.vphone;
            emailTextBox.Text = Loginfrm.vemail;
            departmentTextBox.Text = Loginfrm.vdepartment;
            dateTextBox.Text = Loginfrm.vdate;
            manager_approverTextBox.Text = Loginfrm.vmanagerapprover;
            hod_approverTextBox.Text = Loginfrm.vhodapprover;
            paid_statusTextBox.Text = Loginfrm.vpaidstatus;
            justification_statusTextBox.Text = Loginfrm.vjustificationstatus;
            searchapprover();
            generateid();
        }

        //This method searches for the department line manager.
        public void searchapprover()
        {
            //Database connection and search query.
            SqlConnection con4 = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("SELECT line_manager_id FROM [department] WHERE department_name LIKE '" + departmentTextBox.Text + "'", con4);

            try
            {
                con4.Open();

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        vline_manager_id = (read["line_manager_id"].ToString());
                    }
                }
            }
            finally
            {
                con4.Close();
            }

            searchapproveremail();
        }

        //This method searches for the line managers email address.
        public void searchapproveremail()
        {
            SqlConnection con5 = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("SELECT email FROM [user] WHERE user_id LIKE '" + vline_manager_id + "'", con5);

            try
            {
                con5.Open();

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        vapprover1email = (read["email"].ToString());
                    }
                }
            }
            finally
            {
                con5.Close();
            }
        }


        //This method sends an email to the department line manager for approval, after voucher has been submitted.
        public void sendemail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("cashrequisitionsystem@gmail.com");
                mail.To.Add(vapprover1email);
                mail.Subject = "CRS Voucher Approval";
                mail.Body = $"A new petty cash voucher, id number {voucher_id} awaits your approval.";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("cashrequisitionsystem@gmail.com", "crs2019email");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("An email has been sent to the department manager.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check your network connection. Approval email was not sent.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.ToString());
            }
        }

        //Generates a voucher id based on the last id number in the db (Increments by 1).  
        public void generateid()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from voucher", con);
            Int32 i = (Int32)cmd.ExecuteScalar();
            con.Close();
            i++;
            voucher_idTextBox.Text = vidadd + i.ToString();
            voucher_id = voucher_idTextBox.Text;
        }

        //Inserts new voucher details into the database.
        public void submitvoucher()
        {
            var selectedoption = MessageBox.Show("Are you sure you want to submit Voucher?", "Please select an option", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (selectedoption == DialogResult.Yes)
            {
                try
                {
                    SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
                    con2.Open();
                    SqlCommand cmd = new SqlCommand("insert into voucher(voucher_id, date, requestor_id, first_name, last_name, phone, email, department, amount, description_of_items, manager_approver, hod_approver, paid_status, justification_status) values (@voucher_id,@date,@requestor_id,@first_name,@last_name,@phone,@email,@department,@amount,@description_of_items,@manager_approver,@hod_approver,@paid_status,@justification_status)", con2);

                    cmd.Parameters.AddWithValue("@voucher_id", voucher_idTextBox.Text);
                    cmd.Parameters.AddWithValue("@date", dateTextBox.Text);
                    cmd.Parameters.AddWithValue("@requestor_id", requestor_idTextBox.Text);
                    cmd.Parameters.AddWithValue("@first_name", first_nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@last_name", last_nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@phone", phoneTextBox.Text);
                    cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                    cmd.Parameters.AddWithValue("@department", departmentTextBox.Text);
                    cmd.Parameters.AddWithValue("@amount", amountTextBox.Text);
                    cmd.Parameters.AddWithValue("@description_of_items", description_of_itemsTextBox.Text);
                    cmd.Parameters.AddWithValue("@manager_approver", manager_approverTextBox.Text);
                    cmd.Parameters.AddWithValue("@hod_approver", hod_approverTextBox.Text);
                    cmd.Parameters.AddWithValue("@paid_status", paid_statusTextBox.Text);
                    cmd.Parameters.AddWithValue("@justification_status", justification_statusTextBox.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Voucher submitted. Please wait a moment while an email is being sent.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sendemail();
                    resetfrm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (selectedoption == DialogResult.No)
            {
                amountTextBox.Clear();
                description_of_itemsTextBox.Clear();
                amountTextBox.Focus();
                return;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text =="")
            {
                MessageBox.Show("Cannot submit voucher without an amount. Please enter amount.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                amountTextBox.Clear();
                description_of_itemsTextBox.Clear();
                amountTextBox.Focus();
                return;
            }
            else if (amountTextBox.Text.StartsWith("0"))
            {
                MessageBox.Show("Amount cannot be less than $1. Please enter an amount greater than $0", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                amountTextBox.Clear();
                description_of_itemsTextBox.Clear();
                amountTextBox.Focus();
                return;
            }
            else
            {
                budgetcheck();
            }
        }

        //Retrieves value of remaining amount in the department petty cash account.
        public void budgetcheck()
        {
            SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("select budget_limit from department where department_name LIKE '" + departmentTextBox.Text + "'", con3);

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

            if (vbudget_limit < 50)
            {
                MessageBox.Show("The Department's petty cash fund is below the allowed float balance. Requisitions cannot be submitted until the department petty cash fund has been refilled.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                vamount = Convert.ToDecimal(amountTextBox.Text);
                newbudget_limit = vbudget_limit - vamount;

                if (newbudget_limit < 0)
                {
                    MessageBox.Show("Cannot submit voucher! The amount is above the department petty cash balance.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    submitvoucher();
                }
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            amountTextBox.Clear();
            description_of_itemsTextBox.Clear();
            amountTextBox.Focus();
        }

        private void HomeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homemenufrm homemenufrm = new homemenufrm();
            homemenufrm.Show();
            this.Close();
        }

        private void AmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void NewVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetfrm();
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