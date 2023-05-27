namespace HelpDesk {
    partial class frmHomeKorisnik {
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
            this.btnNoviZahtjev = new System.Windows.Forms.Button();
            this.btnMojiZahtjevi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Control;
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
            this.btnOdjava.Location = new System.Drawing.Point(713, 12);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(75, 27);
            this.btnOdjava.TabIndex = 1;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnNoviZahtjev
            // 
            this.btnNoviZahtjev.Location = new System.Drawing.Point(298, 96);
            this.btnNoviZahtjev.Name = "btnNoviZahtjev";
            this.btnNoviZahtjev.Size = new System.Drawing.Size(182, 104);
            this.btnNoviZahtjev.TabIndex = 2;
            this.btnNoviZahtjev.Text = "Novi Zahtjev";
            this.btnNoviZahtjev.UseVisualStyleBackColor = true;
            this.btnNoviZahtjev.Click += new System.EventHandler(this.btnNoviZahtjev_Click);
            // 
            // btnMojiZahtjevi
            // 
            this.btnMojiZahtjevi.Location = new System.Drawing.Point(298, 253);
            this.btnMojiZahtjevi.Name = "btnMojiZahtjevi";
            this.btnMojiZahtjevi.Size = new System.Drawing.Size(182, 104);
            this.btnMojiZahtjevi.TabIndex = 3;
            this.btnMojiZahtjevi.Text = "Pregled mojih zahtjeva";
            this.btnMojiZahtjevi.UseVisualStyleBackColor = true;
            // 
            // frmHomeKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMojiZahtjevi);
            this.Controls.Add(this.btnNoviZahtjev);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.txtUsername);
            this.Name = "frmHomeKorisnik";
            this.Text = "frmHomeKorisnik";
            this.Load += new System.EventHandler(this.frmHomeKorisnik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnNoviZahtjev;
        private System.Windows.Forms.Button btnMojiZahtjevi;
    }
}