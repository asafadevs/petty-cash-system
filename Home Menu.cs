using System;
using System.Windows.Forms;

namespace NetOne_Cash_Requisition_System
{
    public partial class homemenufrm : Form
    {
        public homemenufrm()
        {
            InitializeComponent();
        }

        //Opens the Create Voucher form.
        private void Createvoucherbtn_Click(object sender, EventArgs e)
        {
            Createvoucherfrm createvoucherfrm = new Createvoucherfrm();
            createvoucherfrm.Show();
            this.Close();
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

        //Opens the Manager Approval form.
        private void Managerapprovalbtn_Click(object sender, EventArgs e)
        {
            if (Loginfrm.vaccess_level == "Manager" || Loginfrm.vaccess_level == "Master")
            {
                Managerapprovalfrm managerapprovalfrm = new Managerapprovalfrm();
                managerapprovalfrm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your access level does not allow you to access this menu option.", "Access Level Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Hodapprovalbtn_Click(object sender, EventArgs e)
        {
            if (Loginfrm.vaccess_level == "HOD" || Loginfrm.vaccess_level == "Master")
            {
                Hodapprovalfrm hodapprovalfrm = new Hodapprovalfrm();
                hodapprovalfrm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your access level does not allow you to access this menu option.", "Access Level Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Paymentsbtn_Click(object sender, EventArgs e)
        {
            if (Loginfrm.vaccess_level == "Cash Office" || Loginfrm.vaccess_level == "Master")
            {
                Paymentsfrm paymentsfrm = new Paymentsfrm();
                paymentsfrm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your access level does not allow you to access this menu option.", "Access Level Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reportsbtn_Click(object sender, EventArgs e)
        {
            if (Loginfrm.vaccess_level == "Cash Office" || Loginfrm.vaccess_level == "Master")
            {
                Reportsfrm reportsfrm = new Reportsfrm();
                reportsfrm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your access level does not allow you to access this menu option.", "Access Level Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Createnewuserbtn_Click(object sender, EventArgs e)
        {
            if (Loginfrm.vaccess_level == "Admin" || Loginfrm.vaccess_level == "Master")
            {
                Create_New_User create_New_User = new Create_New_User();
                create_New_User.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your access level does not allow you to access this menu option.", "Access Level Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Justificationreportsbtn_Click(object sender, EventArgs e)
        {
            if (Loginfrm.vaccess_level == "Cash Office" || Loginfrm.vaccess_level == "Master")
            {
                Justification_Reports justification_Reports = new Justification_Reports();
                justification_Reports.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your access level does not allow you to access this menu option.", "Access Level Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Justificationbtn_Click(object sender, EventArgs e)
        {
            Justification justification = new Justification();
            justification.Show();
            this.Close();
        }

        private void Homemenufrm_Load(object sender, EventArgs e)
        {

        }
    }
}