namespace final
{
    partial class CRfrm
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
            this.DNtb = new System.Windows.Forms.TextBox();
            this.DNlbl = new System.Windows.Forms.Label();
            this.IDatelbl = new System.Windows.Forms.Label();
            this.WNlbl = new System.Windows.Forms.Label();
            this.GNlbl = new System.Windows.Forms.Label();
            this.Qlbl = new System.Windows.Forms.Label();
            this.UPlbl = new System.Windows.Forms.Label();
            this.IMlbl = new System.Windows.Forms.Label();
            this.CRdgv = new System.Windows.Forms.DataGridView();
            this.IDatepicker = new System.Windows.Forms.DateTimePicker();
            this.IDlbl = new System.Windows.Forms.Label();
            this.WNtb = new System.Windows.Forms.TextBox();
            this.IDtb = new System.Windows.Forms.TextBox();
            this.GNtb = new System.Windows.Forms.TextBox();
            this.Qtb = new System.Windows.Forms.TextBox();
            this.UPtb = new System.Windows.Forms.TextBox();
            this.IMtb = new System.Windows.Forms.TextBox();
            this.Clbtn = new System.Windows.Forms.Button();
            this.Crbtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.CRdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // DNtb
            // 
            this.DNtb.Location = new System.Drawing.Point(112, 35);
            this.DNtb.Name = "DNtb";
            this.DNtb.Size = new System.Drawing.Size(100, 20);
            this.DNtb.TabIndex = 0;
            this.DNtb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DNlbl
            // 
            this.DNlbl.AutoSize = true;
            this.DNlbl.Location = new System.Drawing.Point(12, 42);
            this.DNlbl.Name = "DNlbl";
            this.DNlbl.Size = new System.Drawing.Size(76, 13);
            this.DNlbl.TabIndex = 1;
            this.DNlbl.Text = "Delivery Name";
            // 
            // IDatelbl
            // 
            this.IDatelbl.AutoSize = true;
            this.IDatelbl.Location = new System.Drawing.Point(12, 83);
            this.IDatelbl.Name = "IDatelbl";
            this.IDatelbl.Size = new System.Drawing.Size(62, 13);
            this.IDatelbl.TabIndex = 2;
            this.IDatelbl.Text = "Import Date";
            // 
            // WNlbl
            // 
            this.WNlbl.AutoSize = true;
            this.WNlbl.Location = new System.Drawing.Point(12, 124);
            this.WNlbl.Name = "WNlbl";
            this.WNlbl.Size = new System.Drawing.Size(93, 13);
            this.WNlbl.TabIndex = 3;
            this.WNlbl.Text = "Warehouse Name";
            // 
            // GNlbl
            // 
            this.GNlbl.AutoSize = true;
            this.GNlbl.Location = new System.Drawing.Point(373, 42);
            this.GNlbl.Name = "GNlbl";
            this.GNlbl.Size = new System.Drawing.Size(64, 13);
            this.GNlbl.TabIndex = 4;
            this.GNlbl.Text = "Good Name";
            // 
            // Qlbl
            // 
            this.Qlbl.AutoSize = true;
            this.Qlbl.Location = new System.Drawing.Point(373, 83);
            this.Qlbl.Name = "Qlbl";
            this.Qlbl.Size = new System.Drawing.Size(46, 13);
            this.Qlbl.TabIndex = 5;
            this.Qlbl.Text = "Quantity";
            // 
            // UPlbl
            // 
            this.UPlbl.AutoSize = true;
            this.UPlbl.Location = new System.Drawing.Point(373, 124);
            this.UPlbl.Name = "UPlbl";
            this.UPlbl.Size = new System.Drawing.Size(53, 13);
            this.UPlbl.TabIndex = 6;
            this.UPlbl.Text = "Unit Price";
            this.UPlbl.Click += new System.EventHandler(this.label6_Click);
            // 
            // IMlbl
            // 
            this.IMlbl.AutoSize = true;
            this.IMlbl.Location = new System.Drawing.Point(373, 163);
            this.IMlbl.Name = "IMlbl";
            this.IMlbl.Size = new System.Drawing.Size(60, 13);
            this.IMlbl.TabIndex = 7;
            this.IMlbl.Text = "Into Money";
            // 
            // CRdgv
            // 
            this.CRdgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.CRdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CRdgv.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.CRdgv.Location = new System.Drawing.Point(12, 272);
            this.CRdgv.Name = "CRdgv";
            this.CRdgv.Size = new System.Drawing.Size(643, 178);
            this.CRdgv.TabIndex = 8;
            // 
            // IDatepicker
            // 
            this.IDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IDatepicker.Location = new System.Drawing.Point(112, 83);
            this.IDatepicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.IDatepicker.Name = "IDatepicker";
            this.IDatepicker.Size = new System.Drawing.Size(200, 20);
            this.IDatepicker.TabIndex = 9;
            this.IDatepicker.ValueChanged += new System.EventHandler(this.IDatepicker_ValueChanged);
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Location = new System.Drawing.Point(12, 163);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(16, 13);
            this.IDlbl.TabIndex = 10;
            this.IDlbl.Text = "Id";
            // 
            // WNtb
            // 
            this.WNtb.Location = new System.Drawing.Point(112, 121);
            this.WNtb.Name = "WNtb";
            this.WNtb.Size = new System.Drawing.Size(100, 20);
            this.WNtb.TabIndex = 11;
            // 
            // IDtb
            // 
            this.IDtb.Location = new System.Drawing.Point(112, 160);
            this.IDtb.Name = "IDtb";
            this.IDtb.Size = new System.Drawing.Size(100, 20);
            this.IDtb.TabIndex = 12;
            // 
            // GNtb
            // 
            this.GNtb.Location = new System.Drawing.Point(461, 35);
            this.GNtb.Name = "GNtb";
            this.GNtb.Size = new System.Drawing.Size(100, 20);
            this.GNtb.TabIndex = 13;
            // 
            // Qtb
            // 
            this.Qtb.Location = new System.Drawing.Point(461, 76);
            this.Qtb.Name = "Qtb";
            this.Qtb.Size = new System.Drawing.Size(100, 20);
            this.Qtb.TabIndex = 14;
            // 
            // UPtb
            // 
            this.UPtb.Location = new System.Drawing.Point(461, 121);
            this.UPtb.Name = "UPtb";
            this.UPtb.Size = new System.Drawing.Size(100, 20);
            this.UPtb.TabIndex = 15;
            // 
            // IMtb
            // 
            this.IMtb.Location = new System.Drawing.Point(461, 156);
            this.IMtb.Name = "IMtb";
            this.IMtb.Size = new System.Drawing.Size(100, 20);
            this.IMtb.TabIndex = 16;
            // 
            // Clbtn
            // 
            this.Clbtn.Location = new System.Drawing.Point(237, 217);
            this.Clbtn.Name = "Clbtn";
            this.Clbtn.Size = new System.Drawing.Size(75, 23);
            this.Clbtn.TabIndex = 17;
            this.Clbtn.Text = "Clear";
            this.Clbtn.UseVisualStyleBackColor = true;
            this.Clbtn.Click += new System.EventHandler(this.Clbtn_Click);
            // 
            // Crbtn
            // 
            this.Crbtn.Location = new System.Drawing.Point(344, 217);
            this.Crbtn.Name = "Crbtn";
            this.Crbtn.Size = new System.Drawing.Size(75, 23);
            this.Crbtn.TabIndex = 18;
            this.Crbtn.Text = " Create";
            this.Crbtn.UseVisualStyleBackColor = true;
            // 
            // CRfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 462);
            this.Controls.Add(this.Crbtn);
            this.Controls.Add(this.Clbtn);
            this.Controls.Add(this.IMtb);
            this.Controls.Add(this.UPtb);
            this.Controls.Add(this.Qtb);
            this.Controls.Add(this.GNtb);
            this.Controls.Add(this.IDtb);
            this.Controls.Add(this.WNtb);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.IDatepicker);
            this.Controls.Add(this.CRdgv);
            this.Controls.Add(this.IMlbl);
            this.Controls.Add(this.UPlbl);
            this.Controls.Add(this.Qlbl);
            this.Controls.Add(this.GNlbl);
            this.Controls.Add(this.WNlbl);
            this.Controls.Add(this.IDatelbl);
            this.Controls.Add(this.DNlbl);
            this.Controls.Add(this.DNtb);
            this.Name = "CRfrm";
            this.Text = "Create Received";
            this.Load += new System.EventHandler(this.CRfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CRdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DNtb;
        private System.Windows.Forms.Label DNlbl;
        private System.Windows.Forms.Label IDatelbl;
        private System.Windows.Forms.Label WNlbl;
        private System.Windows.Forms.Label GNlbl;
        private System.Windows.Forms.Label Qlbl;
        private System.Windows.Forms.Label UPlbl;
        private System.Windows.Forms.Label IMlbl;
        private System.Windows.Forms.DataGridView CRdgv;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.TextBox WNtb;
        private System.Windows.Forms.TextBox IDtb;
        private System.Windows.Forms.TextBox GNtb;
        private System.Windows.Forms.TextBox Qtb;
        private System.Windows.Forms.TextBox UPtb;
        private System.Windows.Forms.TextBox IMtb;
        private System.Windows.Forms.Button Clbtn;
        private System.Windows.Forms.Button Crbtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        protected internal System.Windows.Forms.DateTimePicker IDatepicker;
    }
}