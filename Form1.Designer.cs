namespace logowanie
{
    partial class Logowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logowanie));
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.zaloguj = new System.Windows.Forms.Button();
            this.pasword = new System.Windows.Forms.Label();
            this.userlb = new System.Windows.Forms.Label();
            this.rejestracja_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tweeter = new System.Windows.Forms.PictureBox();
            this.google = new System.Windows.Forms.PictureBox();
            this.login_lbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.reset_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tweeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.google)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.SkyBlue;
            this.Username.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Username.Location = new System.Drawing.Point(26, 99);
            this.Username.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(330, 24);
            this.Username.TabIndex = 0;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.SkyBlue;
            this.Password.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Password.Location = new System.Drawing.Point(26, 168);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(330, 24);
            this.Password.TabIndex = 1;
            this.Password.UseSystemPasswordChar = true;
            // 
            // zaloguj
            // 
            this.zaloguj.BackColor = System.Drawing.Color.SkyBlue;
            this.zaloguj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zaloguj.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zaloguj.Location = new System.Drawing.Point(284, 201);
            this.zaloguj.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.zaloguj.Name = "zaloguj";
            this.zaloguj.Size = new System.Drawing.Size(72, 29);
            this.zaloguj.TabIndex = 2;
            this.zaloguj.Text = "Zaloguj";
            this.zaloguj.UseVisualStyleBackColor = false;
            this.zaloguj.Click += new System.EventHandler(this.zaloguj_Click);
            // 
            // pasword
            // 
            this.pasword.AutoSize = true;
            this.pasword.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pasword.Location = new System.Drawing.Point(30, 149);
            this.pasword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pasword.Name = "pasword";
            this.pasword.Size = new System.Drawing.Size(66, 17);
            this.pasword.TabIndex = 3;
            this.pasword.Text = "Password";
            this.pasword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userlb
            // 
            this.userlb.AutoSize = true;
            this.userlb.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userlb.Location = new System.Drawing.Point(30, 80);
            this.userlb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userlb.Name = "userlb";
            this.userlb.Size = new System.Drawing.Size(67, 17);
            this.userlb.TabIndex = 4;
            this.userlb.Text = "Username";
            // 
            // rejestracja_btn
            // 
            this.rejestracja_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.rejestracja_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestracja_btn.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rejestracja_btn.Location = new System.Drawing.Point(143, 254);
            this.rejestracja_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rejestracja_btn.Name = "rejestracja_btn";
            this.rejestracja_btn.Size = new System.Drawing.Size(106, 59);
            this.rejestracja_btn.TabIndex = 5;
            this.rejestracja_btn.Text = "Zarejestruj się";
            this.rejestracja_btn.UseVisualStyleBackColor = false;
            this.rejestracja_btn.Click += new System.EventHandler(this.rejestracja_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 360);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 56);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tweeter
            // 
            this.tweeter.Image = ((System.Drawing.Image)(resources.GetObject("tweeter.Image")));
            this.tweeter.Location = new System.Drawing.Point(284, 360);
            this.tweeter.Name = "tweeter";
            this.tweeter.Size = new System.Drawing.Size(60, 56);
            this.tweeter.TabIndex = 7;
            this.tweeter.TabStop = false;
            // 
            // google
            // 
            this.google.Image = ((System.Drawing.Image)(resources.GetObject("google.Image")));
            this.google.Location = new System.Drawing.Point(154, 360);
            this.google.Name = "google";
            this.google.Size = new System.Drawing.Size(60, 56);
            this.google.TabIndex = 8;
            this.google.TabStop = false;
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_lbl.Location = new System.Drawing.Point(118, 328);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(131, 17);
            this.login_lbl.TabIndex = 9;
            this.login_lbl.Text = "Zaloguj się używając";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(154, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 56);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset_btn.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reset_btn.Location = new System.Drawing.Point(26, 201);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(155, 29);
            this.reset_btn.TabIndex = 11;
            this.reset_btn.Text = "Nie pamiętasz hasła?";
            this.reset_btn.UseVisualStyleBackColor = false;
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(394, 456);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.google);
            this.Controls.Add(this.tweeter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rejestracja_btn);
            this.Controls.Add(this.userlb);
            this.Controls.Add(this.pasword);
            this.Controls.Add(this.zaloguj);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.Logowanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tweeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.google)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button zaloguj;
        private System.Windows.Forms.Label pasword;
        private System.Windows.Forms.Label userlb;
        private System.Windows.Forms.Button rejestracja_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox tweeter;
        private System.Windows.Forms.PictureBox google;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button reset_btn;
    }
}

