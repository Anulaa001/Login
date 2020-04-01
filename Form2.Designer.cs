namespace logowanie
{
    partial class Rejestracja
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
            this.username_lbl = new System.Windows.Forms.Label();
            this.username_rejestr = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.email_rejestr = new System.Windows.Forms.TextBox();
            this.haslo_lbl = new System.Windows.Forms.Label();
            this.haslo_rejestr = new System.Windows.Forms.TextBox();
            this.warunki = new System.Windows.Forms.CheckBox();
            this.zarejestruj_sie = new System.Windows.Forms.Button();
            this.Rejestraja_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(22, 88);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(67, 17);
            this.username_lbl.TabIndex = 3;
            this.username_lbl.Text = "Username";
            // 
            // username_rejestr
            // 
            this.username_rejestr.BackColor = System.Drawing.Color.SkyBlue;
            this.username_rejestr.Location = new System.Drawing.Point(25, 108);
            this.username_rejestr.Name = "username_rejestr";
            this.username_rejestr.Size = new System.Drawing.Size(348, 24);
            this.username_rejestr.TabIndex = 4;
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Location = new System.Drawing.Point(21, 158);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(42, 17);
            this.email_lbl.TabIndex = 5;
            this.email_lbl.Text = "Email";
            // 
            // email_rejestr
            // 
            this.email_rejestr.BackColor = System.Drawing.Color.SkyBlue;
            this.email_rejestr.Location = new System.Drawing.Point(25, 178);
            this.email_rejestr.Name = "email_rejestr";
            this.email_rejestr.Size = new System.Drawing.Size(348, 24);
            this.email_rejestr.TabIndex = 6;
            // 
            // haslo_lbl
            // 
            this.haslo_lbl.AutoSize = true;
            this.haslo_lbl.Location = new System.Drawing.Point(21, 227);
            this.haslo_lbl.Name = "haslo_lbl";
            this.haslo_lbl.Size = new System.Drawing.Size(43, 17);
            this.haslo_lbl.TabIndex = 7;
            this.haslo_lbl.Text = "Hasło";
            // 
            // haslo_rejestr
            // 
            this.haslo_rejestr.BackColor = System.Drawing.Color.SkyBlue;
            this.haslo_rejestr.Location = new System.Drawing.Point(24, 247);
            this.haslo_rejestr.Name = "haslo_rejestr";
            this.haslo_rejestr.PasswordChar = '*';
            this.haslo_rejestr.Size = new System.Drawing.Size(349, 24);
            this.haslo_rejestr.TabIndex = 8;
            // 
            // warunki
            // 
            this.warunki.AutoSize = true;
            this.warunki.Location = new System.Drawing.Point(24, 306);
            this.warunki.Name = "warunki";
            this.warunki.Size = new System.Drawing.Size(271, 21);
            this.warunki.TabIndex = 9;
            this.warunki.Text = "Akceptuje warunki kożystania z aplikacji.";
            this.warunki.UseVisualStyleBackColor = true;
            // 
            // zarejestruj_sie
            // 
            this.zarejestruj_sie.BackColor = System.Drawing.Color.SkyBlue;
            this.zarejestruj_sie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zarejestruj_sie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zarejestruj_sie.Location = new System.Drawing.Point(129, 361);
            this.zarejestruj_sie.Name = "zarejestruj_sie";
            this.zarejestruj_sie.Size = new System.Drawing.Size(138, 59);
            this.zarejestruj_sie.TabIndex = 10;
            this.zarejestruj_sie.Text = "Zarejestruj się";
            this.zarejestruj_sie.UseVisualStyleBackColor = false;
            this.zarejestruj_sie.Click += new System.EventHandler(this.zarejestruj_sie_Click);
            // 
            // Rejestraja_lbl
            // 
            this.Rejestraja_lbl.AutoSize = true;
            this.Rejestraja_lbl.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rejestraja_lbl.Location = new System.Drawing.Point(141, 9);
            this.Rejestraja_lbl.Name = "Rejestraja_lbl";
            this.Rejestraja_lbl.Size = new System.Drawing.Size(126, 28);
            this.Rejestraja_lbl.TabIndex = 0;
            this.Rejestraja_lbl.Text = "Rejestracja";
            this.Rejestraja_lbl.Click += new System.EventHandler(this.Rejestraja_lbl_Click);
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(394, 456);
            this.Controls.Add(this.zarejestruj_sie);
            this.Controls.Add(this.warunki);
            this.Controls.Add(this.haslo_rejestr);
            this.Controls.Add(this.haslo_lbl);
            this.Controls.Add(this.email_rejestr);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.username_rejestr);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.Rejestraja_lbl);
            this.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Rejestracja";
            this.Text = "Rejestracja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.TextBox username_rejestr;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.TextBox email_rejestr;
        private System.Windows.Forms.Label haslo_lbl;
        private System.Windows.Forms.TextBox haslo_rejestr;
        private System.Windows.Forms.CheckBox warunki;
        private System.Windows.Forms.Button zarejestruj_sie;
        private System.Windows.Forms.Label Rejestraja_lbl;
    }
}