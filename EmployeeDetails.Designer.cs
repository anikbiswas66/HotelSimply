namespace HotelSimply
{
    partial class EmployeeDetails
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.dlbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 148);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 540);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(1275, 148);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(183, 60);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(1275, 252);
            this.btnAddEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(203, 60);
            this.btnAddEmp.TabIndex = 21;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(357, 52);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(141, 42);
            this.searchbtn.TabIndex = 84;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(55, 62);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(293, 22);
            this.searchtxt.TabIndex = 83;
            // 
            // dlbtn
            // 
            this.dlbtn.Location = new System.Drawing.Point(1275, 354);
            this.dlbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dlbtn.Name = "dlbtn";
            this.dlbtn.Size = new System.Drawing.Size(203, 74);
            this.dlbtn.TabIndex = 85;
            this.dlbtn.Text = "Delete";
            this.dlbtn.UseVisualStyleBackColor = true;
            this.dlbtn.Click += new System.EventHandler(this.dlbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 86;
            this.label1.Text = "User Name";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(675, 65);
            this.txtUid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUid.Name = "txtUid";
            this.txtUid.ReadOnly = true;
            this.txtUid.Size = new System.Drawing.Size(199, 22);
            this.txtUid.TabIndex = 87;
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1503, 730);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dlbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeDetails";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button dlbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUid;
    }
}