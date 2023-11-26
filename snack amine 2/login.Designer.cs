namespace snack_amine_2
{
    partial class login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.iduser = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtiduser = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(263, 337);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(102, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "create new account";
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(333, 309);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(62, 26);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(136, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 199);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(208, 309);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(62, 26);
            this.btnlogin.TabIndex = 12;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(158, 269);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(77, 17);
            this.password.TabIndex = 11;
            this.password.Text = "Password";
            // 
            // iduser
            // 
            this.iduser.AutoSize = true;
            this.iduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iduser.Location = new System.Drawing.Point(158, 219);
            this.iduser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.iduser.Name = "iduser";
            this.iduser.Size = new System.Drawing.Size(81, 17);
            this.iduser.TabIndex = 10;
            this.iduser.Text = "Username";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(286, 264);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(164, 26);
            this.txtpassword.TabIndex = 9;
            // 
            // txtiduser
            // 
            this.txtiduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiduser.Location = new System.Drawing.Point(286, 219);
            this.txtiduser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtiduser.Name = "txtiduser";
            this.txtiduser.Size = new System.Drawing.Size(164, 26);
            this.txtiduser.TabIndex = 8;
            this.txtiduser.TextChanged += new System.EventHandler(this.txtiduser_TextChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.iduser);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtiduser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label iduser;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtiduser;
    }
}

