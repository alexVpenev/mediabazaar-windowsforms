namespace WindowsFormsApp5.ucHR
{
    partial class ucHRShifts
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
            this.calendarShift = new System.Windows.Forms.MonthCalendar();
            this.selectShiftTypecbx = new System.Windows.Forms.ComboBox();
            this.peopleOnAShiftlbx = new System.Windows.Forms.ListBox();
            this.AddNewShiftbtn = new System.Windows.Forms.Button();
            this.UnassignShiftbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calendarShift
            // 
            this.calendarShift.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.calendarShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calendarShift.Location = new System.Drawing.Point(131, 81);
            this.calendarShift.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calendarShift.Name = "calendarShift";
            this.calendarShift.TabIndex = 1;
            this.calendarShift.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarShift_DateChanged);
            // 
            // selectShiftTypecbx
            // 
            this.selectShiftTypecbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectShiftTypecbx.FormattingEnabled = true;
            this.selectShiftTypecbx.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.selectShiftTypecbx.Location = new System.Drawing.Point(810, 81);
            this.selectShiftTypecbx.Margin = new System.Windows.Forms.Padding(4);
            this.selectShiftTypecbx.Name = "selectShiftTypecbx";
            this.selectShiftTypecbx.Size = new System.Drawing.Size(237, 24);
            this.selectShiftTypecbx.TabIndex = 2;
            this.selectShiftTypecbx.SelectedIndexChanged += new System.EventHandler(this.selectShiftTypecbx_SelectedIndexChanged);
            // 
            // peopleOnAShiftlbx
            // 
            this.peopleOnAShiftlbx.FormattingEnabled = true;
            this.peopleOnAShiftlbx.ItemHeight = 16;
            this.peopleOnAShiftlbx.Location = new System.Drawing.Point(810, 137);
            this.peopleOnAShiftlbx.Margin = new System.Windows.Forms.Padding(4);
            this.peopleOnAShiftlbx.Name = "peopleOnAShiftlbx";
            this.peopleOnAShiftlbx.Size = new System.Drawing.Size(237, 308);
            this.peopleOnAShiftlbx.TabIndex = 3;
            // 
            // AddNewShiftbtn
            // 
            this.AddNewShiftbtn.Location = new System.Drawing.Point(822, 518);
            this.AddNewShiftbtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddNewShiftbtn.Name = "AddNewShiftbtn";
            this.AddNewShiftbtn.Size = new System.Drawing.Size(204, 68);
            this.AddNewShiftbtn.TabIndex = 5;
            this.AddNewShiftbtn.Text = "Assign Shift";
            this.AddNewShiftbtn.UseVisualStyleBackColor = true;
            this.AddNewShiftbtn.Click += new System.EventHandler(this.AddNewShiftbtn_Click);
            // 
            // UnassignShiftbtn
            // 
            this.UnassignShiftbtn.Location = new System.Drawing.Point(563, 507);
            this.UnassignShiftbtn.Margin = new System.Windows.Forms.Padding(4);
            this.UnassignShiftbtn.Name = "UnassignShiftbtn";
            this.UnassignShiftbtn.Size = new System.Drawing.Size(211, 68);
            this.UnassignShiftbtn.TabIndex = 4;
            this.UnassignShiftbtn.Text = "Remove";
            this.UnassignShiftbtn.UseVisualStyleBackColor = true;
            this.UnassignShiftbtn.Click += new System.EventHandler(this.UnassignShiftbtn_Click);
            // 
            // ucHRShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.AddNewShiftbtn);
            this.Controls.Add(this.UnassignShiftbtn);
            this.Controls.Add(this.peopleOnAShiftlbx);
            this.Controls.Add(this.selectShiftTypecbx);
            this.Controls.Add(this.calendarShift);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucHRShifts";
            this.Size = new System.Drawing.Size(1293, 666);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar calendarShift;
        private System.Windows.Forms.ComboBox selectShiftTypecbx;
        private System.Windows.Forms.ListBox peopleOnAShiftlbx;
        private System.Windows.Forms.Button AddNewShiftbtn;
        private System.Windows.Forms.Button UnassignShiftbtn;
    }
}
