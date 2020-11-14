using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NetOne_Cash_Requisition_System
{
    public partial class Loginfrm : Form
    {
        //Variables that are storing database retrieved user specific voucher details.
        public static string vuser_id;
        public static string vfirst_name;
        public static string vlast_name;
        public static string vphone;
        public static string vemail;
        public static string vdepartment;
        public static string vmanagerapprover;
        public static string vhodapprover;
        public static string vpaidstatus;
        public static string vjustificationstatus;
        public static string vdate;
        public static string vaccess_level;

        public Loginfrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Makes sure textboxes are clear, before entering any details.
            user_idTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            //Database connection and search query for user login credintials.
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [user] WHERE user_id LIKE '" + user_idTextBox.Text + "' AND password LIKE '" + passwordTextBox.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                Search();
                MessageBox.Show("Login successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Opens home menu and hides the login form.
                this.Visible = false;
                homemenufrm homemenu = new homemenufrm();
                homemenu.Show();
            }
            else
            {
                //Error message for a failed login.
                MessageBox.Show("Invalid login, please check username and password.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                user_idTextBox.Clear();
                passwordTextBox.Clear();
                user_idTextBox.Focus();
            }
            con.Close();
        }

        //Exits the application.
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            var selectedoption = MessageBox.Show("Are you sure you want to exit the Application?", "Please select an option", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (selectedoption == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (selectedoption == DialogResult.No)
            {
                return;
            }
        }

        //The "Search" method searches user specific details which are to be used in vouchers.
        public void Search()
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("SELECT user_id, first_name, last_name, phone, email, department, access_level FROM [user] WHERE user_id LIKE '" + user_idTextBox.Text + "'", con2);

            try
            {
                con2.Open();

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    //Assigns values to variables.
                    while (read.Read())
                    {
                        vuser_id = (read["user_id"].ToString());
                        vfirst_name = (read["first_name"].ToString());
                        vlast_name = (read["last_name"].ToString());
                        vphone = (read["phone"].ToString());
                        vemail = (read["email"].ToString());
                        vdepartment = (read["department"].ToString());
                        vaccess_level = (read["access_level"].ToString());
                        vpaidstatus = "Not Paid";
                        vjustificationstatus = "Not Justified";
                        vdate = DateTime.Now.ToString("yyyy-MM-dd");
                        vmanagerapprover = "Not Approved";
                        vhodapprover = "Not Approved";
                    }
                }
            }
            finally
            {
                con2.Close();
            }
        }

        //Enter key triggers the login button.
        private void User_idTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                Loginbtn_Click(sender, e);
            }
        }

        //Enter key triggers the login button.
        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                Loginbtn_Click(sender, e);
            }
        }
    }
}