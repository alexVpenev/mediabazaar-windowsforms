namespace WindowsFormsApp5
{
    partial class HRForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRForm));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHRShifts = new System.Windows.Forms.Button();
            this.btnHREmployees = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidePanel.Controls.Add(this.label1);
            this.sidePanel.Controls.Add(this.btnHRShifts);
            this.sidePanel.Controls.Add(this.btnHREmployees);
            this.sidePanel.Location = new System.Drawing.Point(0, -4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(157, 604);
            this.sidePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "HR";
            // 
            // btnHRShifts
            // 
            this.btnHRShifts.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHRShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHRShifts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHRShifts.Location = new System.Drawing.Point(0, 117);
            this.btnHRShifts.Name = "btnHRShifts";
            this.btnHRShifts.Size = new System.Drawing.Size(157, 60);
            this.btnHRShifts.TabIndex = 2;
            this.btnHRShifts.Text = "Shifts";
            this.btnHRShifts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHRShifts.UseVisualStyleBackColor = false;
            this.btnHRShifts.Click += new System.EventHandler(this.btnShifts2_Click);
            // 
            // btnHREmployees
            // 
            this.btnHREmployees.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHREmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHREmployees.Location = new System.Drawing.Point(0, 60);
            this.btnHREmployees.Name = "btnHREmployees";
            this.btnHREmployees.Size = new System.Drawing.Size(157, 60);
            this.btnHREmployees.TabIndex = 0;
            this.btnHREmployees.Text = "Employees";
            this.btnHREmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHREmployees.UseVisualStyleBackColor = false;
            this.btnHREmployees.Click += new System.EventHandler(this.btnHREmployees_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.Controls.Add(this.btnLogOut);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Location = new System.Drawing.Point(156, -1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(974, 60);
            this.panelTop.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(845, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(56, 60);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(908, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 60);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(156, 61);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(974, 540);
            this.panelMain.TabIndex = 2;
            // 
            // HRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 601);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HRForm";
            this.Text = "HRForm";
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnHREmployees;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHRShifts;
    }
}