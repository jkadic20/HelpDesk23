namespace HelpDesk {
    partial class frmHomeDjelatnik {
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnSviZahtjevi = new System.Windows.Forms.Button();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(12, 12);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdjava.BackColor = System.Drawing.Color.IndianRed;
            this.btnOdjava.Location = new System.Drawing.Point(713, 12);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(75, 27);
            this.btnOdjava.TabIndex = 1;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnSviZahtjevi
            // 
            this.btnSviZahtjevi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSviZahtjevi.BackColor = System.Drawing.SystemColors.Info;
            this.btnSviZahtjevi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSviZahtjevi.Location = new System.Drawing.Point(290, 54);
            this.btnSviZahtjevi.Name = "btnSviZahtjevi";
            this.btnSviZahtjevi.Size = new System.Drawing.Size(182, 104);
            this.btnSviZahtjevi.TabIndex = 2;
            this.btnSviZahtjevi.Text = "Svi zahtjevi";
            this.btnSviZahtjevi.UseVisualStyleBackColor = false;
            this.btnSviZahtjevi.Click += new System.EventHandler(this.btnSviZahtjevi_Click);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIzvjestaj.BackColor = System.Drawing.SystemColors.Info;
            this.btnIzvjestaj.Location = new System.Drawing.Point(290, 186);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(182, 104);
            this.btnIzvjestaj.TabIndex = 3;
            this.btnIzvjestaj.Text = "Izrada izvješća";
            this.btnIzvjestaj.UseVisualStyleBackColor = false;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStatistika.BackColor = System.Drawing.SystemColors.Info;
            this.btnStatistika.Location = new System.Drawing.Point(290, 319);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(182, 104);
            this.btnStatistika.TabIndex = 4;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = false;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // frmHomeDjelatnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.btnSviZahtjevi);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.txtUsername);
            this.Name = "frmHomeDjelatnik";
            this.Text = "frmHomeDjelatnik";
            this.Load += new System.EventHandler(this.frmHomeDjelatnik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnSviZahtjevi;
        private System.Windows.Forms.Button btnIzvjestaj;
        private System.Windows.Forms.Button btnStatistika;
    }
}