namespace WindowsFormsApp5
{
    partial class AddShiftForm
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
            this.AssignShiftbtn = new System.Windows.Forms.Button();
            this.Employeescbx = new System.Windows.Forms.ComboBox();
            this.selectShiftTypecbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pickDateCld = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AssignShiftbtn
            // 
            this.AssignShiftbtn.Location = new System.Drawing.Point(278, 176);
            this.AssignShiftbtn.Name = "AssignShiftbtn";
            this.AssignShiftbtn.Size = new System.Drawing.Size(178, 23);
            this.AssignShiftbtn.TabIndex = 0;
            this.AssignShiftbtn.Text = "Assign Shift";
            this.AssignShiftbtn.UseVisualStyleBackColor = true;
            this.AssignShiftbtn.Click += new System.EventHandler(this.AssignShiftbtn_Click);
            // 
            // Employeescbx
            // 
            this.Employeescbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Employeescbx.FormattingEnabled = true;
            this.Employeescbx.Location = new System.Drawing.Point(277, 95);
            this.Employeescbx.Name = "Employeescbx";
            this.Employeescbx.Size = new System.Drawing.Size(179, 21);
            this.Employeescbx.TabIndex = 2;
            // 
            // selectShiftTypecbx
            // 
            this.selectShiftTypecbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectShiftTypecbx.FormattingEnabled = true;
            this.selectShiftTypecbx.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.selectShiftTypecbx.Location = new System.Drawing.Point(278, 37);
            this.selectShiftTypecbx.Name = "selectShiftTypecbx";
            this.selectShiftTypecbx.Size = new System.Drawing.Size(179, 21);
            this.selectShiftTypecbx.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose a Date";
            // 
            // pickDateCld
            // 
            this.pickDateCld.Location = new System.Drawing.Point(18, 37);
            this.pickDateCld.Name = "pickDateCld";
            this.pickDateCld.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Employee";
            // 
            // AddShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 227);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pickDateCld);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectShiftTypecbx);
            this.Controls.Add(this.Employeescbx);
            this.Controls.Add(this.AssignShiftbtn);
            this.Name = "AddShiftForm";
            this.Text = "AddShiftForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AssignShiftbtn;
        private System.Windows.Forms.ComboBox Employeescbx;
        private System.Windows.Forms.ComboBox selectShiftTypecbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar pickDateCld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}