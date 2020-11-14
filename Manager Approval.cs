using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;

namespace NetOne_Cash_Requisition_System
{
    public partial class Managerapprovalfrm : Form
    {
        public Managerapprovalfrm()
        {
            InitializeComponent();
        }

        string voucher_id;
        public static string v2hod_id;
        public static string hodemail;
        public string requestor_id;
        public string requestoremail;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");

        private void Manager_Approval_Load(object sender, EventArgs e)
        {
            con.Open();
            //Fills Datagrid View with records from the voucher table according to the appropriate department.
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [voucher] WHERE department LIKE '" + Loginfrm.vdepartment + "' AND manager_approver LIKE 'Not Approved'", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgv1.DataSource = dtbl;
            int numRows = dgv1.Rows.Count;
            numRows = numRows - 1;
            rdlbl.Text = numRows.ToString();
        }

        //Method searches for the department HOD.
        public void searchhodapprover()
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("SELECT hod_id FROM [department] WHERE department_name LIKE '" + Loginfrm.vdepartment + "'", con2);

            try
            {
                con2.Open();

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        v2hod_id = (read["hod_id"].ToString());
                    }
                }
            }
            finally
            {
                con2.Close();
            }
            searchhodapproveremail();
            sendemail();
        }

        //Method searches for the HOD's email address.
        public void searchhodapproveremail()
        {
            SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("SELECT email FROM [user] WHERE user_id LIKE '" + v2hod_id + "'", con3);

            try
            {
                con3.Open();

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        hodemail = (read["email"].ToString());
                    }
                }
            }
            finally
            {
                con3.Close();
            }
        }

        //Method sends approval email to the department HOD.
        public void sendemail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("cashrequisitionsystem@gmail.com");
                mail.To.Add(hodemail);
                mail.Subject = "CRS Voucher Approval";
                mail.Body = $"A new petty cash voucher, id number {voucher_id} awaits your approval.";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("cashrequisitionsystem@gmail.com", "crs2019email");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("An email has been sent to the Head of Department.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Check your network connection. Approval email was not sent.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.ToString());
            }
            textBox1.Clear();
        }

        //Method searches for the initial voucher requestor.
        public void searchrequestor()
        {
            SqlConnection con4 = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("SELECT email FROM [user] WHERE user_id LIKE '" + requestor_id + "'", con4);

            try
            {
                con4.Open();

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        requestoremail = (read["email"].ToString());
                    }
                }
                rejectionemail();
            }
            finally
            {
                con4.Close();
            }
        }

        //Sends voucher rejection email.
        public void rejectionemail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("cashrequisitionsystem@gmail.com");
                mail.To.Add(requestoremail);
                mail.Subject = "CRS Voucher Rejection";
                mail.Body = $"Your petty cash voucher, id number {voucher_id} has been rejected. Please consult your Manager or Head of Department.";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("cashrequisitionsystem@gmail.com", "crs2019email");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("An email has been sent to the requestor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check your network connection, email was not sent.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.ToString());
            }
            textBox1.Clear();
        }

        //Approval & Rejection Action.
        private void Dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            voucher_id = this.dgv1.CurrentRow.Cells[0].Value.ToString();
            requestor_id = this.dgv1.CurrentRow.Cells[2].Value.ToString();
            var selectedoption = MessageBox.Show("Would you like to approve this petty cash voucher? Click 'Yes' to approve the voucher or click 'No' to reject the voucher.", "Manager approval", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (selectedoption == DialogResult.Yes)
            {
                SqlCommand UpdateCommand = new SqlCommand("update voucher set manager_approver = 'Approved' where voucher_id LIKE'" + voucher_id + "'", con);
                SqlDataReader myReader;

                try
                {
                    myReader = UpdateCommand.ExecuteReader();
                    MessageBox.Show("Voucher Approved. Please wait a moment while an email is being sent.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchhodapprover();
                    con.Close();
                    Manager_Approval_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (selectedoption == DialogResult.No)
            {
                SqlCommand UpdateCommand = new SqlCommand("update voucher set manager_approver = 'Rejected' where voucher_id LIKE'" + voucher_id + "'", con);
                SqlDataReader myReader;

                try
                {
                    myReader = UpdateCommand.ExecuteReader();
                    MessageBox.Show("Voucher Rejected. Please wait a moment while an email is being sent.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchrequestor();
                    con.Close();
                    Manager_Approval_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (selectedoption == DialogResult.Cancel)
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                con.Close();
                Manager_Approval_Load(sender, e);
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
            SqlDataAdapter qry = new SqlDataAdapter("SELECT * FROM voucher WHERE (voucher_id LIKE '%" + textBox1.Text + "%' or date LIKE '%" + textBox1.Text + "%' or requestor_id LIKE '%" + textBox1.Text + "%' or first_name LIKE '%" + textBox1.Text + "%' or last_name LIKE '%" + textBox1.Text + "%' or phone LIKE '%" + textBox1.Text + "%' or email LIKE '%" + textBox1.Text + "%' or amount LIKE '%" + textBox1.Text + "%') AND department LIKE '" + Loginfrm.vdepartment + "' AND manager_approver LIKE 'Not Approved'", con4);
            DataTable dtb2 = new DataTable();
            qry.Fill(dtb2);
            dgv1.DataSource = dtb2;
            int numRows = dgv1.Rows.Count;
            numRows = numRows - 1;
            rdlbl.Text = numRows.ToString();
            con4.Close();
        }

        private void NewVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Createvoucherfrm createvoucherfrm = new Createvoucherfrm();
            createvoucherfrm.Show();
            this.Close();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
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