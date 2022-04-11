namespace WindowsFormsApp5.ucM
{
    partial class ucMEmployees
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
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.chbTerminated = new System.Windows.Forms.CheckBox();
            this.btnCancelSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(434, 39);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(251, 20);
            this.lbSearch.TabIndex = 10;
            this.lbSearch.Text = "Search for an employee by their:";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(118, 36);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(261, 26);
            this.tbSearch.TabIndex = 9;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
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
            this.listView1.Location = new System.Drawing.Point(85, 82);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1065, 537);
            this.listView1.TabIndex = 8;
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
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Name",
            "BSN",
            "Position"});
            this.cmbSearch.Location = new System.Drawing.Point(709, 39);
            this.cmbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(116, 24);
            this.cmbSearch.TabIndex = 13;
            // 
            // chbTerminated
            // 
            this.chbTerminated.AutoSize = true;
            this.chbTerminated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTerminated.Location = new System.Drawing.Point(834, 40);
            this.chbTerminated.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbTerminated.Name = "chbTerminated";
            this.chbTerminated.Size = new System.Drawing.Size(241, 24);
            this.chbTerminated.TabIndex = 12;
            this.chbTerminated.Text = "Show terminated employees";
            this.chbTerminated.UseVisualStyleBackColor = true;
            this.chbTerminated.CheckedChanged += new System.EventHandler(this.chbTerminated_CheckedChanged);
            // 
            // btnCancelSearch
            // 
            this.btnCancelSearch.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSearch.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelSearch.Location = new System.Drawing.Point(385, 37);
            this.btnCancelSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Size = new System.Drawing.Size(37, 27);
            this.btnCancelSearch.TabIndex = 11;
            this.btnCancelSearch.Text = "X";
            this.btnCancelSearch.UseVisualStyleBackColor = false;
            this.btnCancelSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // ucMEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.chbTerminated);
            this.Controls.Add(this.btnCancelSearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucMEmployees";
            this.Size = new System.Drawing.Size(1297, 667);
            this.Click += new System.EventHandler(this.ucMEmployees_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader BSN;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader EmailAddress;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.CheckBox chbTerminated;
        private System.Windows.Forms.Button btnCancelSearch;
        private System.Windows.Forms.ColumnHeader Position;
    }
}
