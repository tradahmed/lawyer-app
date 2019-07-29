namespace WindowsFormsApp1.form
{
    partial class ListAvocat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListAvocat));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tavocatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avocatsDataSet6 = new WindowsFormsApp1.AvocatsDataSet6();
            this.gb_pi = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_avocatTableAdapter = new WindowsFormsApp1.AvocatsDataSet6TableAdapters.t_avocatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavocatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avocatsDataSet6)).BeginInit();
            this.gb_pi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 333);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tavocatBindingSource
            // 
            this.tavocatBindingSource.DataMember = "t_avocat";
            this.tavocatBindingSource.DataSource = this.avocatsDataSet6;
            // 
            // avocatsDataSet6
            // 
            this.avocatsDataSet6.DataSetName = "AvocatsDataSet6";
            this.avocatsDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gb_pi
            // 
            this.gb_pi.Controls.Add(this.textBox1);
            this.gb_pi.Controls.Add(this.label1);
            this.gb_pi.Controls.Add(this.tb5);
            this.gb_pi.Controls.Add(this.tb2);
            this.gb_pi.Controls.Add(this.label5);
            this.gb_pi.Controls.Add(this.label2);
            this.gb_pi.Location = new System.Drawing.Point(2, 0);
            this.gb_pi.Name = "gb_pi";
            this.gb_pi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_pi.Size = new System.Drawing.Size(797, 112);
            this.gb_pi.TabIndex = 3;
            this.gb_pi.TabStop = false;
            this.gb_pi.Text = "معلومات";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "الولاية";
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(38, 51);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(112, 20);
            this.tb5.TabIndex = 13;
            this.tb5.TextChanged += new System.EventHandler(this.tb5_TextChanged);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(551, 55);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(112, 20);
            this.tb2.TabIndex = 10;
            this.tb2.TextChanged += new System.EventHandler(this.tb2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "العنوان";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم و اللقب";
            // 
            // t_avocatTableAdapter
            // 
            this.t_avocatTableAdapter.ClearBeforeFill = true;
            // 
            // ListAvocat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_pi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListAvocat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListAvocat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListAvocat_FormClosed);
            this.Load += new System.EventHandler(this.ListAvocat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavocatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avocatsDataSet6)).EndInit();
            this.gb_pi.ResumeLayout(false);
            this.gb_pi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb_pi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private AvocatsDataSet avocatsDataSet;
        private AvocatsDataSetTableAdapters.ListavocatTableAdapter listavocatTableAdapter;
        private AvocatsDataSet6 avocatsDataSet6;
        private System.Windows.Forms.BindingSource tavocatBindingSource;
        private AvocatsDataSet6TableAdapters.t_avocatTableAdapter t_avocatTableAdapter;
    }
}