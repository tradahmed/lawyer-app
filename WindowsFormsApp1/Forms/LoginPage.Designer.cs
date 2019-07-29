namespace WindowsFormsApp1
{
    partial class Welcome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.submit = new System.Windows.Forms.Button();
            this.rest = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.motdepasse = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.avocatsDataSet = new WindowsFormsApp1.AvocatsDataSet();
            this.authTableAdapter = new WindowsFormsApp1.AvocatsDataSetTableAdapters.AuthTableAdapter();
            this.errorlogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorpass = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.errorrole = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.avocatsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorrole)).BeginInit();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(26, 302);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(81, 35);
            this.submit.TabIndex = 2;
            this.submit.Text = "دخول";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // rest
            // 
            this.rest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rest.FlatAppearance.BorderSize = 0;
            this.rest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rest.ForeColor = System.Drawing.Color.White;
            this.rest.Location = new System.Drawing.Point(135, 302);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(81, 35);
            this.rest.TabIndex = 3;
            this.rest.Text = "إعادة";
            this.rest.UseVisualStyleBackColor = false;
            this.rest.Click += new System.EventHandler(this.Reset);
            // 
            // tb1
            // 
            this.tb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(53)))), ((int)(((byte)(149)))));
            this.tb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(48, 134);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(144, 22);
            this.tb1.TabIndex = 4;
            // 
            // tb2
            // 
            this.tb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(53)))), ((int)(((byte)(149)))));
            this.tb2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.Location = new System.Drawing.Point(48, 199);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(144, 22);
            this.tb2.TabIndex = 5;
            this.tb2.UseSystemPasswordChar = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // motdepasse
            // 
            this.motdepasse.AutoSize = true;
            this.motdepasse.BackColor = System.Drawing.Color.Transparent;
            this.motdepasse.Font = new System.Drawing.Font("Cooper Black", 20.25F);
            this.motdepasse.ForeColor = System.Drawing.Color.Black;
            this.motdepasse.Location = new System.Drawing.Point(70, 162);
            this.motdepasse.Name = "motdepasse";
            this.motdepasse.Size = new System.Drawing.Size(100, 31);
            this.motdepasse.TabIndex = 1;
            this.motdepasse.Text = "كلمة السر";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.Black;
            this.login.Location = new System.Drawing.Point(50, 97);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(141, 31);
            this.login.TabIndex = 1;
            this.login.Text = "تسجيل الدخول";
            this.login.UseMnemonic = false;
            // 
            // avocatsDataSet
            // 
            this.avocatsDataSet.DataSetName = "AvocatsDataSet";
            this.avocatsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authTableAdapter
            // 
            this.authTableAdapter.ClearBeforeFill = true;
            // 
            // errorlogin
            // 
            this.errorlogin.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorlogin.ContainerControl = this;
            this.errorlogin.Icon = ((System.Drawing.Icon)(resources.GetObject("errorlogin.Icon")));
            this.errorlogin.RightToLeft = true;
            // 
            // errorpass
            // 
            this.errorpass.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorpass.ContainerControl = this;
            this.errorpass.Icon = ((System.Drawing.Icon)(resources.GetObject("errorpass.Icon")));
            this.errorpass.RightToLeft = true;
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.AutoSize = true;
            this.lbl_Msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(52)))), ((int)(((byte)(147)))));
            this.lbl_Msg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Msg.Location = new System.Drawing.Point(12, 338);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(0, 13);
            this.lbl_Msg.TabIndex = 11;
            // 
            // errorrole
            // 
            this.errorrole.ContainerControl = this;
            this.errorrole.Icon = ((System.Drawing.Icon)(resources.GetObject("errorrole.Icon")));
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fond_geometrique_avec_une_couleur_degradee_moderne_et_elegante_8188_231;
            this.ClientSize = new System.Drawing.Size(244, 360);
            this.Controls.Add(this.lbl_Msg);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.rest);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.motdepasse);
            this.Controls.Add(this.login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            ((System.ComponentModel.ISupportInitialize)(this.avocatsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorrole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button rest;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label motdepasse;
        private System.Windows.Forms.Label login;
        private AvocatsDataSet avocatsDataSet;
        private AvocatsDataSetTableAdapters.AuthTableAdapter authTableAdapter;
        private System.Windows.Forms.ErrorProvider errorlogin;
        private System.Windows.Forms.ErrorProvider errorpass;
        private System.Windows.Forms.Label lbl_Msg;
        private System.Windows.Forms.ErrorProvider errorrole;
    }
}

