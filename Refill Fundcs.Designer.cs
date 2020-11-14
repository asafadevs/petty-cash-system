namespace NetOne_Cash_Requisition_System
{
    partial class Refill_Fundcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Refill_Fundcs));
            this.refillbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.refillamonuttxtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // refillbtn
            // 
            this.refillbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.refillbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refillbtn.Location = new System.Drawing.Point(19, 99);
            this.refillbtn.Name = "refillbtn";
            this.refillbtn.Size = new System.Drawing.Size(135, 33);
            this.refillbtn.TabIndex = 0;
            this.refillbtn.Text = "Refill";
            this.refillbtn.UseVisualStyleBackColor = false;
            this.refillbtn.Click += new System.EventHandler(this.Refillbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(192, 99);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(135, 33);
            this.cancelbtn.TabIndex = 1;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount:";
            // 
            // refillamonuttxtbx
            // 
            this.refillamonuttxtbx.Location = new System.Drawing.Point(78, 36);
            this.refillamonuttxtbx.Name = "refillamonuttxtbx";
            this.refillamonuttxtbx.Size = new System.Drawing.Size(249, 20);
            this.refillamonuttxtbx.TabIndex = 3;
            this.refillamonuttxtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Refillamonuttxtbx_KeyPress);
            // 
            // Refill_Fundcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 155);
            this.Controls.Add(this.refillamonuttxtbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.refillbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Refill_Fundcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refill Fund";
            this.Load += new System.EventHandler(this.Refill_Fundcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refillbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox refillamonuttxtbx;
    }
}