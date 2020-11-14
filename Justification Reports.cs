using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;
using Image = System.Drawing.Image;

namespace NetOne_Cash_Requisition_System
{
    public partial class Justification_Reports : Form
    {
        public Justification_Reports()
        {
            InitializeComponent();
        }

        public string voucher_id;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");

        private void HomeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homemenufrm homemenufrm = new homemenufrm();
            homemenufrm.Show();
            this.Close();
        }

        private void FromdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
            con3.Open();
            SqlDataAdapter qry3 = new SqlDataAdapter("SELECT * FROM voucher WHERE ([date] BETWEEN '" + FromdateTimePicker.Value.Date + "' AND '" + TodateTimePicker.Value.Date + "') AND (department LIKE '" + Loginfrm.vdepartment + "') AND (paid_status LIKE 'Paid')", con3);
            DataTable dtbl3 = new DataTable();
            qry3.Fill(dtbl3);
            dataGridView1.DataSource = dtbl3;
            int numRows3 = dataGridView1.Rows.Count - 1;
            rdlbl.Text = numRows3.ToString();
            con3.Close();
        }

        private void Justification_Reports_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [voucher] WHERE department LIKE '" + Loginfrm.vdepartment + "' AND paid_status LIKE 'Paid'", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            int numRows = dataGridView1.Rows.Count - 1;
            rdlbl.Text = numRows.ToString();
            dataGridView1.Columns[14].Visible = false;
        }

        private void TodateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
            con2.Open();
            SqlDataAdapter qry2 = new SqlDataAdapter("SELECT * FROM voucher WHERE ([date] BETWEEN '" + FromdateTimePicker.Value.Date + "' AND '" + TodateTimePicker.Value.Date + "') AND (department LIKE '" + Loginfrm.vdepartment + "') AND (paid_status LIKE 'Paid')", con2);
            DataTable dtbl2 = new DataTable();
            qry2.Fill(dtbl2);
            dataGridView1.DataSource = dtbl2;
            int numRows2 = dataGridView1.Rows.Count - 1;
            rdlbl.Text = numRows2.ToString();
            con2.Close();
            dataGridView1.Columns[14].Visible = false;
        }

        public void searchdata()
        {
            con.Open();
            SqlDataAdapter qry = new SqlDataAdapter("SELECT * FROM voucher WHERE ([date] BETWEEN '" + FromdateTimePicker.Value.Date + "' AND '" + TodateTimePicker.Value.Date + "') AND (voucher_id LIKE '%" + Searchtxtbx.Text + "%' or requestor_id LIKE '%" + Searchtxtbx.Text + "%' or first_name LIKE '%" + Searchtxtbx.Text + "%' or last_name LIKE '%" + Searchtxtbx.Text + "%' or phone LIKE '%" + Searchtxtbx.Text + "%' or email LIKE '%" + Searchtxtbx.Text + "%' or amount LIKE '%" + Searchtxtbx.Text + "%') AND (paid_status LIKE 'Paid')", con);
            DataTable dtbl = new DataTable();
            qry.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            int numRows = dataGridView1.Rows.Count - 1;
            rdlbl.Text = numRows.ToString();
            con.Close();
            dataGridView1.Columns[14].Visible = false;
        }

        public void searchwhenempty()
        {
            con.Open();
            SqlDataAdapter qry = new SqlDataAdapter("SELECT * FROM voucher WHERE ([date] BETWEEN '" + FromdateTimePicker.Value.Date + "' AND '" + TodateTimePicker.Value.Date + "')", con);
            DataTable dtbl = new DataTable();
            qry.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            int numRows = dataGridView1.Rows.Count - 1;
            rdlbl.Text = numRows.ToString();
            con.Close();
            dataGridView1.Columns[14].Visible = false;
        }

        private void Searchtxtbx_TextChanged(object sender, EventArgs e)
        {
            if (Searchtxtbx.Text == "")
            {
                searchwhenempty();
            }
            else
            {
                searchdata();
            }
        }

        /*private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            voucher_id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            SqlConnection con4 = new SqlConnection(@"Data Source=DESKTOP-H7S5UDN\SQLEXPRESS;Initial Catalog=crs;Integrated Security=True;");
            con4.Open();
            SqlCommand cmd = new SqlCommand("SELECT attachments FROM voucher where voucher_id LIKE '" + voucher_id + "'", con4);
            SqlDataReader dataRead = cmd.ExecuteReader();
            dataRead.Read();

            if (dataRead.HasRows)
            {
                byte[] images = ((byte[])dataRead[0]);

                if (images == null)
                {
                    pictureBox2.Image = null;
                    MessageBox.Show("This voucher has not yet been justified.");
                    con4.Close();
                }
                else
                {   // Section is not working
                    //var imageMemoryStream = new MemoryStream(images);
                    //Image imgFromStream = Image.FromStream(imageMemoryStream);
                    // pictureBox2.Image = imgFromStream;
                    return;
                }
            }
            else
            {
                MessageBox.Show("This voucher has not yet been justified.");
            }

            con4.Close();

            //What the heck!
        }*/

        private void Exporttopdfbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please wait a moment while your PDF report is being exported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.Columns[14].Visible = false;

            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 7;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }

            int row = dataGridView1.Rows.Count;
            int cell2 = dataGridView1.Rows[1].Cells.Count;
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < cell2; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {

                        dataGridView1.Rows[i].Cells[j].Value = "null";
                    }
                    pdfTable.AddCell(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
            }

            //Exporting to PDF
            string folderPath = @"C:\Log\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + $"Justification Report {DateTime.Now.ToString("yyyy-MM-dd hhmm")}.pdf ", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
            MessageBox.Show("PDF report has been exported to location 'C:/Log/'.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Exporttoexcelbtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Petty Cash Vouchers Report.xls";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Format column D as text before pasting results, this was required for my data
                Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
                rng.NumberFormat = "@";

                // Paste clipboard results to worksheet range
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                // For some reason column A is always blank in the worksheet.
                // Delete blank column A and select cell A1
                Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dataGridView1.ClearSelection();
            }
            MessageBox.Show("Your Excel Spreadsheet has been successfully exported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
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
