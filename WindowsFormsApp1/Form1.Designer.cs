namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.btnsave1 = new System.Windows.Forms.Button();
            this.btnupdate1 = new System.Windows.Forms.Button();
            this.btnsearch1 = new System.Windows.Forms.Button();
            this.btndelete1 = new System.Windows.Forms.Button();
            this.btnshowallemployee1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "employee id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "employee name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "salary";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(258, 85);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(258, 132);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 5;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(258, 196);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(100, 22);
            this.txtsalary.TabIndex = 6;
            // 
            // btnsave1
            // 
            this.btnsave1.Location = new System.Drawing.Point(113, 314);
            this.btnsave1.Name = "btnsave1";
            this.btnsave1.Size = new System.Drawing.Size(75, 23);
            this.btnsave1.TabIndex = 7;
            this.btnsave1.Text = "save";
            this.btnsave1.UseVisualStyleBackColor = true;
            this.btnsave1.Click += new System.EventHandler(this.btnsave1_Click);
            // 
            // btnupdate1
            // 
            this.btnupdate1.Location = new System.Drawing.Point(258, 314);
            this.btnupdate1.Name = "btnupdate1";
            this.btnupdate1.Size = new System.Drawing.Size(75, 24);
            this.btnupdate1.TabIndex = 8;
            this.btnupdate1.Text = "update";
            this.btnupdate1.UseVisualStyleBackColor = true;
            this.btnupdate1.Click += new System.EventHandler(this.btnupdate1_Click);
            // 
            // btnsearch1
            // 
            this.btnsearch1.Location = new System.Drawing.Point(479, 39);
            this.btnsearch1.Name = "btnsearch1";
            this.btnsearch1.Size = new System.Drawing.Size(75, 23);
            this.btnsearch1.TabIndex = 9;
            this.btnsearch1.Text = "search";
            this.btnsearch1.UseVisualStyleBackColor = true;
            this.btnsearch1.Click += new System.EventHandler(this.btnsearch1_Click);
            // 
            // btndelete1
            // 
            this.btndelete1.Location = new System.Drawing.Point(616, 39);
            this.btndelete1.Name = "btndelete1";
            this.btndelete1.Size = new System.Drawing.Size(75, 23);
            this.btndelete1.TabIndex = 10;
            this.btndelete1.Text = "delete";
            this.btndelete1.UseVisualStyleBackColor = true;
            this.btndelete1.Click += new System.EventHandler(this.btndelete1_Click);
            // 
            // btnshowallemployee1
            // 
            this.btnshowallemployee1.Location = new System.Drawing.Point(467, 314);
            this.btnshowallemployee1.Name = "btnshowallemployee1";
            this.btnshowallemployee1.Size = new System.Drawing.Size(167, 23);
            this.btnshowallemployee1.TabIndex = 11;
            this.btnshowallemployee1.Text = "show all employee";
            this.btnshowallemployee1.UseVisualStyleBackColor = true;
            this.btnshowallemployee1.Click += new System.EventHandler(this.btnshowallemployee1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(451, 106);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(397, 150);
            this.dataGridView2.TabIndex = 12;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(930, 438);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnshowallemployee1);
            this.Controls.Add(this.btndelete1);
            this.Controls.Add(this.btnsearch1);
            this.Controls.Add(this.btnupdate1);
            this.Controls.Add(this.btnsave1);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnshowallemployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Button btnsave1;
        private System.Windows.Forms.Button btnupdate1;
        private System.Windows.Forms.Button btnsearch1;
        private System.Windows.Forms.Button btndelete1;
        private System.Windows.Forms.Button btnshowallemployee1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

