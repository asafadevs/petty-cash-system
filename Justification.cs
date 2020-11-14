using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace NetOne_Cash_Requisition_System
{
    public partial class Justification : Form
    {
        public Justification()
        {
            InitializeComponent();
        }

        public static string voucher_id;
        public string imgLocation;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");


        private void HomeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homemenufrm homemenufrm = new homemenufrm();
            homemenufrm.Show();
            this.Close();
        }

        private void Justification_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [voucher] WHERE (requestor_id LIKE '" + Loginfrm.vuser_id + "') AND (paid_status LIKE 'Paid') AND (justification_status LIKE 'Not Justified')", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            int numRows = dataGridView1.Rows.Count;
            numRows = numRows - 1;
            label4.Text = numRows.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                con.Close();
                Justification_Load(sender, e);
            }
            else
            {
                searchdata();
            }
        }

        public void searchdata()
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
            con2.Open();
            SqlDataAdapter qry2 = new SqlDataAdapter("SELECT * FROM voucher WHERE (requestor_id LIKE '%" + Loginfrm.vuser_id + "%') AND (paid_status LIKE 'Paid') AND (voucher_id LIKE '%" + textBox1.Text + "%' or date LIKE '%" + textBox1.Text + "%' or amount LIKE  '%" + textBox1.Text + "%')", con2);
            DataTable dtbl2 = new DataTable();
            qry2.Fill(dtbl2);
            dataGridView1.DataSource = dtbl2;
            int numRows = dataGridView1.Rows.Count;
            label4.Text = numRows.ToString();
            con2.Close();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            voucher_id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            var selectedoption = MessageBox.Show("Would you like to upload the receipts for this voucher", "Justification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (selectedoption == DialogResult.Yes)
            {
                SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");

                SearchImage();
                byte[] image = null;
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(stream);
                image = binaryReader.ReadBytes((int)stream.Length);
                con3.Close();
                con3.Open();
                SqlCommand UpdateCommand = new SqlCommand("update voucher set attachments = '" + image + "', justification_status = 'Justified' where voucher_id LIKE'" + voucher_id + "'", con3);
                SqlDataReader myReader;

                try
                {
                    myReader = UpdateCommand.ExecuteReader();
                    MessageBox.Show("Receipt Uploaded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    Justification_Load(sender, e);
                }
                finally
                {
                    con3.Close();
                }
            }
        }

        public void SearchImage()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
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
