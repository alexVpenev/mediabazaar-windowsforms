namespace WindowsFormsApp5
{
    partial class ChangeInfoEmployeeForm
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
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lbExplanation = new System.Windows.Forms.Label();
            this.tbFTE = new System.Windows.Forms.TextBox();
            this.lbFTE = new System.Windows.Forms.Label();
            this.chbFulltime = new System.Windows.Forms.CheckBox();
            this.tbBSN = new System.Windows.Forms.TextBox();
            this.lbBSN = new System.Windows.Forms.Label();
            this.chbMarried = new System.Windows.Forms.CheckBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbDoB = new System.Windows.Forms.Label();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbLN = new System.Windows.Forms.TextBox();
            this.lbLN = new System.Windows.Forms.Label();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.lbFN = new System.Windows.Forms.Label();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.lbHour = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.lbPosition = new System.Windows.Forms.Label();
            this.chbBox = new System.Windows.Forms.ComboBox();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.lbEmergency = new System.Windows.Forms.Label();
            this.timerButtons = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(103, 599);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(126, 55);
            this.btnAddEmployee.TabIndex = 42;
            this.btnAddEmployee.Text = "Change Info";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lbExplanation
            // 
            this.lbExplanation.AutoSize = true;
            this.lbExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExplanation.Location = new System.Drawing.Point(11, 374);
            this.lbExplanation.Name = "lbExplanation";
            this.lbExplanation.Size = new System.Drawing.Size(321, 48);
            this.lbExplanation.TabIndex = 40;
            this.lbExplanation.Text = "(Full time employees automatically have an FTE of 1,\r\nwhile the others have an FT" +
    "E ranging from 0.1 to 0.9)\r\n\r\n";
            // 
            // tbFTE
            // 
            this.tbFTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFTE.Location = new System.Drawing.Point(127, 340);
            this.tbFTE.Name = "tbFTE";
            this.tbFTE.Size = new System.Drawing.Size(137, 22);
            this.tbFTE.TabIndex = 39;
            // 
            // lbFTE
            // 
            this.lbFTE.AutoSize = true;
            this.lbFTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFTE.Location = new System.Drawing.Point(12, 343);
            this.lbFTE.Name = "lbFTE";
            this.lbFTE.Size = new System.Drawing.Size(37, 16);
            this.lbFTE.TabIndex = 38;
            this.lbFTE.Text = "FTE:";
            // 
            // chbFulltime
            // 
            this.chbFulltime.AutoSize = true;
            this.chbFulltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFulltime.Location = new System.Drawing.Point(14, 310);
            this.chbFulltime.Name = "chbFulltime";
            this.chbFulltime.Size = new System.Drawing.Size(73, 20);
            this.chbFulltime.TabIndex = 37;
            this.chbFulltime.Text = "Fulltime";
            this.chbFulltime.UseVisualStyleBackColor = true;
            this.chbFulltime.CheckedChanged += new System.EventHandler(this.chbFulltime_CheckedChanged);
            // 
            // tbBSN
            // 
            this.tbBSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBSN.Location = new System.Drawing.Point(127, 276);
            this.tbBSN.Name = "tbBSN";
            this.tbBSN.Size = new System.Drawing.Size(137, 22);
            this.tbBSN.TabIndex = 36;
            // 
            // lbBSN
            // 
            this.lbBSN.AutoSize = true;
            this.lbBSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBSN.Location = new System.Drawing.Point(12, 279);
            this.lbBSN.Name = "lbBSN";
            this.lbBSN.Size = new System.Drawing.Size(39, 16);
            this.lbBSN.TabIndex = 35;
            this.lbBSN.Text = "BSN:";
            // 
            // chbMarried
            // 
            this.chbMarried.AutoSize = true;
            this.chbMarried.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMarried.Location = new System.Drawing.Point(15, 246);
            this.chbMarried.Name = "chbMarried";
            this.chbMarried.Size = new System.Drawing.Size(73, 20);
            this.chbMarried.TabIndex = 34;
            this.chbMarried.Text = "Married";
            this.chbMarried.UseVisualStyleBackColor = true;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(127, 209);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(137, 22);
            this.tbAddress.TabIndex = 33;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(12, 212);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(62, 16);
            this.lbAddress.TabIndex = 32;
            this.lbAddress.Text = "Address:";
            // 
            // lbDoB
            // 
            this.lbDoB.AutoSize = true;
            this.lbDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoB.Location = new System.Drawing.Point(11, 139);
            this.lbDoB.Name = "lbDoB";
            this.lbDoB.Size = new System.Drawing.Size(83, 16);
            this.lbDoB.TabIndex = 31;
            this.lbDoB.Text = "Date of Birth:";
            // 
            // dtpDoB
            // 
            this.dtpDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDoB.Location = new System.Drawing.Point(127, 134);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(137, 22);
            this.dtpDoB.TabIndex = 30;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(127, 172);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(137, 22);
            this.tbPhone.TabIndex = 29;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(12, 175);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(101, 16);
            this.lbPhone.TabIndex = 28;
            this.lbPhone.Text = "Phone Number:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(127, 97);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(137, 22);
            this.tbEmail.TabIndex = 27;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(12, 100);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(99, 16);
            this.lbEmail.TabIndex = 26;
            this.lbEmail.Text = "Email Address:";
            // 
            // tbLN
            // 
            this.tbLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLN.Location = new System.Drawing.Point(127, 60);
            this.tbLN.Name = "tbLN";
            this.tbLN.Size = new System.Drawing.Size(137, 22);
            this.tbLN.TabIndex = 25;
            // 
            // lbLN
            // 
            this.lbLN.AutoSize = true;
            this.lbLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLN.Location = new System.Drawing.Point(12, 63);
            this.lbLN.Name = "lbLN";
            this.lbLN.Size = new System.Drawing.Size(76, 16);
            this.lbLN.TabIndex = 24;
            this.lbLN.Text = "Last Name:";
            // 
            // tbFN
            // 
            this.tbFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFN.Location = new System.Drawing.Point(127, 25);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(137, 22);
            this.tbFN.TabIndex = 23;
            // 
            // lbFN
            // 
            this.lbFN.AutoSize = true;
            this.lbFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFN.Location = new System.Drawing.Point(12, 28);
            this.lbFN.Name = "lbFN";
            this.lbFN.Size = new System.Drawing.Size(76, 16);
            this.lbFN.TabIndex = 22;
            this.lbFN.Text = "First Name:";
            // 
            // tbHour
            // 
            this.tbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHour.Location = new System.Drawing.Point(126, 432);
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(137, 22);
            this.tbHour.TabIndex = 44;
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHour.Location = new System.Drawing.Point(11, 435);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(86, 16);
            this.lbHour.TabIndex = 43;
            this.lbHour.Text = "Hourly wage:";
            // 
            // tbPosition
            // 
            this.tbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPosition.Location = new System.Drawing.Point(127, 506);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(137, 22);
            this.tbPosition.TabIndex = 50;
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.Location = new System.Drawing.Point(12, 509);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(59, 16);
            this.lbPosition.TabIndex = 49;
            this.lbPosition.Text = "Position:";
            // 
            // chbBox
            // 
            this.chbBox.FormattingEnabled = true;
            this.chbBox.Location = new System.Drawing.Point(127, 545);
            this.chbBox.Name = "chbBox";
            this.chbBox.Size = new System.Drawing.Size(137, 21);
            this.chbBox.TabIndex = 48;
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartment.Location = new System.Drawing.Point(12, 545);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(81, 16);
            this.lbDepartment.TabIndex = 47;
            this.lbDepartment.Text = "Department:";
            // 
            // tbContact
            // 
            this.tbContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.Location = new System.Drawing.Point(146, 470);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(137, 22);
            this.tbContact.TabIndex = 46;
            // 
            // lbEmergency
            // 
            this.lbEmergency.AutoSize = true;
            this.lbEmergency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmergency.Location = new System.Drawing.Point(12, 473);
            this.lbEmergency.Name = "lbEmergency";
            this.lbEmergency.Size = new System.Drawing.Size(128, 16);
            this.lbEmergency.TabIndex = 45;
            this.lbEmergency.Text = "Emergency Contact:";
            // 
            // timerButtons
            // 
            this.timerButtons.Interval = 7500;
            this.timerButtons.Tick += new System.EventHandler(this.timerButtons_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(127, 576);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(136, 20);
            this.tbPassword.TabIndex = 52;
            // 
            // ChangeInfoEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(343, 666);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.chbBox);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.lbEmergency);
            this.Controls.Add(this.tbHour);
            this.Controls.Add(this.lbHour);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.lbExplanation);
            this.Controls.Add(this.tbFTE);
            this.Controls.Add(this.lbFTE);
            this.Controls.Add(this.chbFulltime);
            this.Controls.Add(this.tbBSN);
            this.Controls.Add(this.lbBSN);
            this.Controls.Add(this.chbMarried);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbDoB);
            this.Controls.Add(this.dtpDoB);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbLN);
            this.Controls.Add(this.lbLN);
            this.Controls.Add(this.tbFN);
            this.Controls.Add(this.lbFN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ChangeInfoEmployeeForm";
            this.Text = "ChangeInfoEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lbExplanation;
        private System.Windows.Forms.TextBox tbFTE;
        private System.Windows.Forms.Label lbFTE;
        private System.Windows.Forms.CheckBox chbFulltime;
        private System.Windows.Forms.TextBox tbBSN;
        private System.Windows.Forms.Label lbBSN;
        private System.Windows.Forms.CheckBox chbMarried;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbDoB;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbLN;
        private System.Windows.Forms.Label lbLN;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.Label lbFN;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.ComboBox chbBox;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label lbEmergency;
        private System.Windows.Forms.Timer timerButtons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
    }
}