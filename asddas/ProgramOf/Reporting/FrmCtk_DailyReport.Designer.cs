namespace ProgramOf.Reporting
{
    partial class FrmCtk_DailyReport
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
            this.CmdCetak = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdCetak
            // 
            this.CmdCetak.Location = new System.Drawing.Point(362, 12);
            this.CmdCetak.Name = "CmdCetak";
            this.CmdCetak.Size = new System.Drawing.Size(75, 23);
            this.CmdCetak.TabIndex = 5;
            this.CmdCetak.Text = "Cetak";
            this.CmdCetak.UseVisualStyleBackColor = true;
            this.CmdCetak.Click += new System.EventHandler(this.CmdCetak_Click);
            // 
            // dtp
            // 
            this.dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(203, 47);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(112, 29);
            this.dtp.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(132, 51);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(66, 20);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Tanggal";
            // 
            // FrmCtk_DailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 145);
            this.Controls.Add(this.CmdCetak);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.Label1);
            this.Name = "FrmCtk_DailyReport";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCtk_DailyReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdCetak;
        internal System.Windows.Forms.DateTimePicker dtp;
        internal System.Windows.Forms.Label Label1;
    }
}