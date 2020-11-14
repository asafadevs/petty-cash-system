using System;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;

namespace NetOne_Cash_Requisition_System
{
    public partial class Create_New_User : Form
    {
        public Create_New_User()
        {
            InitializeComponent();
        }

        string empID = "EMP";

        private void Create_New_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crsDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.crsDataSet.user);
            user_idTextBox.Clear();
            first_nameTextBox.Clear();
            last_nameTextBox.Clear();
            phoneTextBox.Clear();
            emailTextBox.Clear();
            passwordTextBox.Clear();
            departmentcmbx.SelectedIndex = 0;
            access_levelcmbx.SelectedIndex = 0;
            generateid();
            first_nameTextBox.Focus();
        }

        private void Saveuserbtn_Click(object sender, EventArgs e)
        {
            if (user_idTextBox.Text != "" && first_nameTextBox.Text != "" && last_nameTextBox.Text != "" && departmentcmbx.Text != "Please Select" && access_levelcmbx.Text != "Please Select" && phoneTextBox.Text != "" && emailTextBox.Text != "" && passwordTextBox.Text != "")
            {
                var selectedoption = MessageBox.Show("Are you sure you want to create a new user account?", "Please select an option", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (selectedoption == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
                        con2.Open();
                        SqlCommand cmd = new SqlCommand("insert into [user](user_id, first_name, last_name, department, access_level, phone, email, password) values (@user_id,@first_name,@last_name,@department,@access_level,@phone,@email,@password)", con2);

                        cmd.Parameters.AddWithValue("@user_id", user_idTextBox.Text);
                        cmd.Parameters.AddWithValue("@first_name", first_nameTextBox.Text);
                        cmd.Parameters.AddWithValue("@last_name", last_nameTextBox.Text);
                        cmd.Parameters.AddWithValue("@department", departmentcmbx.Text);
                        cmd.Parameters.AddWithValue("@access_level", access_levelcmbx.Text);
                        cmd.Parameters.AddWithValue("@phone", phoneTextBox.Text);
                        cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                        cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("New user created. Please wait a moment while an email is being sent.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sendemail();
                        Create_New_User_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                if (selectedoption == DialogResult.No)
                {
                    Create_New_User_Load(sender, e);
                    return;
                }
            }
            else
            {
                MessageBox.Show("You cannot leave empty fields. Please enter all the required information.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void generateid()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from [user]", con);
            Int32 i = (Int32)cmd.ExecuteScalar();
            con.Close();
            i++;
            user_idTextBox.Text = empID + i.ToString();
        }

        public void sendemail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("cashrequisitionsystem@gmail.com");
                mail.To.Add(emailTextBox.Text);
                mail.Subject = "CRS User Account Details";
                mail.Body = $"Your user account for the Cash Requisition System has been successfully created. Your User ID is {user_idTextBox.Text}, and your password is {passwordTextBox.Text}.";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("cashrequisitionsystem@gmail.com", "crs2019email");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("An email has been sent to the new user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check your network connection. Approval email was not sent.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Create_New_User_Load(sender, e);
        }

        private void HomeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homemenufrm homemenufrm = new homemenufrm();
            homemenufrm.Show();
            this.Close();
        }

        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void First_nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Last_nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
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