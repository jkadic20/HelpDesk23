namespace HelpDesk {
    partial class frmFilter {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtZahtjevPreuzeo = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPrioritet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPotvrdiFIlter = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtZahtjevPreuzeo
            // 
            this.txtZahtjevPreuzeo.Location = new System.Drawing.Point(12, 63);
            this.txtZahtjevPreuzeo.Name = "txtZahtjevPreuzeo";
            this.txtZahtjevPreuzeo.Size = new System.Drawing.Size(100, 22);
            this.txtZahtjevPreuzeo.TabIndex = 0;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(302, 63);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 22);
            this.txtStatus.TabIndex = 1;
            // 
            // txtPrioritet
            // 
            this.txtPrioritet.Location = new System.Drawing.Point(158, 63);
            this.txtPrioritet.Name = "txtPrioritet";
            this.txtPrioritet.Size = new System.Drawing.Size(100, 22);
            this.txtPrioritet.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zahtjev Preuzeo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prioritet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // btnPotvrdiFIlter
            // 
            this.btnPotvrdiFIlter.BackColor = System.Drawing.SystemColors.Info;
            this.btnPotvrdiFIlter.Location = new System.Drawing.Point(327, 12);
            this.btnPotvrdiFIlter.Name = "btnPotvrdiFIlter";
            this.btnPotvrdiFIlter.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdiFIlter.TabIndex = 6;
            this.btnPotvrdiFIlter.Text = "Filtriraj";
            this.btnPotvrdiFIlter.UseVisualStyleBackColor = false;
            this.btnPotvrdiFIlter.Click += new System.EventHandler(this.btnPotvrdiFIlter_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.IndianRed;
            this.btnOdustani.Location = new System.Drawing.Point(12, 12);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(80, 23);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // frmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(423, 109);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdiFIlter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrioritet);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtZahtjevPreuzeo);
            this.Name = "frmFilter";
            this.Text = "frmFilter";
            this.Load += new System.EventHandler(this.frmFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZahtjevPreuzeo;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPrioritet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPotvrdiFIlter;
        private System.Windows.Forms.Button btnOdustani;
    }
}