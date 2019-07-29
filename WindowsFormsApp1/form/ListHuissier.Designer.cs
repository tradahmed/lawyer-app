namespace WindowsFormsApp1.form
{
    partial class ListHuissier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListHuissier));
            this.gb_pi = new System.Windows.Forms.GroupBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_pi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_pi
            // 
            this.gb_pi.Controls.Add(this.tb1);
            this.gb_pi.Controls.Add(this.label1);
            this.gb_pi.Controls.Add(this.tb5);
            this.gb_pi.Controls.Add(this.tb2);
            this.gb_pi.Controls.Add(this.label5);
            this.gb_pi.Controls.Add(this.label2);
            this.gb_pi.Location = new System.Drawing.Point(1, 0);
            this.gb_pi.Name = "gb_pi";
            this.gb_pi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_pi.Size = new System.Drawing.Size(797, 112);
            this.gb_pi.TabIndex = 1;
            this.gb_pi.TabStop = false;
            this.gb_pi.Text = "معلومات";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(296, 55);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(112, 21);
            this.tb1.TabIndex = 16;
            this.tb1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "الولاية";
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(34, 55);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(112, 21);
            this.tb5.TabIndex = 13;
            this.tb5.TextChanged += new System.EventHandler(this.tb5_TextChanged);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(554, 55);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(112, 21);
            this.tb2.TabIndex = 10;
            this.tb2.TextChanged += new System.EventHandler(this.tb2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "العنوان";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم و اللقب";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 333);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ListHuissier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_pi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListHuissier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListHuissier";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListHuissier_FormClosed);
            this.Load += new System.EventHandler(this.ListHuissier_Load);
            this.gb_pi.ResumeLayout(false);
            this.gb_pi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_pi;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label1;
    }
}