namespace WindowsFormsApp5.ucHR
{
    partial class ucHREmployees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.BSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnChangeInfo = new System.Windows.Forms.Button();
            this.btnFireEmployee = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbReason = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnCancelSearch = new System.Windows.Forms.Button();
            this.chbTerminated = new System.Windows.Forms.CheckBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Azure;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BSN,
            this.FullName,
            this.EmailAddress,
            this.PhoneNumber,
            this.Address,
            this.Status,
            this.Position});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(87, 80);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1060, 347);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // BSN
            // 
            this.BSN.Text = "BSN";
            this.BSN.Width = 80;
            // 
            // FullName
            // 
            this.FullName.Text = "Full Name";
            this.FullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FullName.Width = 150;
            // 
            // EmailAddress
            // 
            this.EmailAddress.Text = "Email Address";
            this.EmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailAddress.Width = 120;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Phone Number";
            this.PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneNumber.Width = 90;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address.Width = 125;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Status.Width = 100;
            // 
            // Position
            // 
            this.Position.Text = "Position";
            this.Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position.Width = 80;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Azure;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(180, 477);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(177, 90);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add New Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.BackColor = System.Drawing.Color.Azure;
            this.btnChangeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeInfo.Location = new System.Drawing.Point(535, 477);
            this.btnChangeInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(177, 90);
            this.btnChangeInfo.TabIndex = 2;
            this.btnChangeInfo.Text = "Change Info Employee";
            this.btnChangeInfo.UseVisualStyleBackColor = false;
            this.btnChangeInfo.Click += new System.EventHandler(this.btnChangeInfo_Click);
            // 
            // btnFireEmployee
            // 
            this.btnFireEmployee.BackColor = System.Drawing.Color.Azure;
            this.btnFireEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireEmployee.Location = new System.Drawing.Point(894, 547);
            this.btnFireEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnFireEmployee.Name = "btnFireEmployee";
            this.btnFireEmployee.Size = new System.Drawing.Size(177, 90);
            this.btnFireEmployee.TabIndex = 3;
            this.btnFireEmployee.Text = "Fire Employee";
            this.btnFireEmployee.UseVisualStyleBackColor = false;
            this.btnFireEmployee.Click += new System.EventHandler(this.btnFireEmployee_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(894, 477);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(171, 62);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // lbReason
            // 
            this.lbReason.AutoSize = true;
            this.lbReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReason.Location = new System.Drawing.Point(890, 440);
            this.lbReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(221, 20);
            this.lbReason.TabIndex = 5;
            this.lbReason.Text = "Reason for ending contract :";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(131, 35);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(264, 26);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(446, 39);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(251, 20);
            this.lbSearch.TabIndex = 7;
            this.lbSearch.Text = "Search for an employee by their:\r\n";
            // 
            // btnCancelSearch
            // 
            this.btnCancelSearch.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSearch.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelSearch.Location = new System.Drawing.Point(400, 35);
            this.btnCancelSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Size = new System.Drawing.Size(37, 27);
            this.btnCancelSearch.TabIndex = 8;
            this.btnCancelSearch.Text = "X";
            this.btnCancelSearch.UseVisualStyleBackColor = false;
            this.btnCancelSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // chbTerminated
            // 
            this.chbTerminated.AutoSize = true;
            this.chbTerminated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTerminated.Location = new System.Drawing.Point(859, 37);
            this.chbTerminated.Margin = new System.Windows.Forms.Padding(4);
            this.chbTerminated.Name = "chbTerminated";
            this.chbTerminated.Size = new System.Drawing.Size(241, 24);
            this.chbTerminated.TabIndex = 9;
            this.chbTerminated.Text = "Show terminated employees";
            this.chbTerminated.UseVisualStyleBackColor = true;
            this.chbTerminated.CheckedChanged += new System.EventHandler(this.chbTerminated_CheckedChanged);
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Name",
            "BSN",
            "Position"});
            this.cmbSearch.Location = new System.Drawing.Point(720, 37);
            this.cmbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(116, 24);
            this.cmbSearch.TabIndex = 10;
            // 
            // ucHREmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.chbTerminated);
            this.Controls.Add(this.btnCancelSearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbReason);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnFireEmployee);
            this.Controls.Add(this.btnChangeInfo);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucHREmployees";
            this.Size = new System.Drawing.Size(1293, 666);
            this.Load += new System.EventHandler(this.ucHREmployees_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ucHREmployees_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnChangeInfo;
        private System.Windows.Forms.Button btnFireEmployee;
        private System.Windows.Forms.ColumnHeader BSN;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader EmailAddress;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbReason;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btnCancelSearch;
        private System.Windows.Forms.CheckBox chbTerminated;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.ColumnHeader Position;
    }
}
