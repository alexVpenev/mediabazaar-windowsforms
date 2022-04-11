namespace WindowsFormsApp5
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnMStatistics = new System.Windows.Forms.Button();
            this.btnMEmployees = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(211, 72);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1294, 668);
            this.panelMain.TabIndex = 5;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.btnLogOut);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Location = new System.Drawing.Point(207, 1);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1298, 74);
            this.panelTop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manager";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(1128, 0);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 74);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1211, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 74);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidePanel.Controls.Add(this.btnMStatistics);
            this.sidePanel.Controls.Add(this.btnMEmployees);
            this.sidePanel.Location = new System.Drawing.Point(-1, -2);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(209, 742);
            this.sidePanel.TabIndex = 3;
            // 
            // btnMStatistics
            // 
            this.btnMStatistics.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMStatistics.Location = new System.Drawing.Point(0, 144);
            this.btnMStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.btnMStatistics.Name = "btnMStatistics";
            this.btnMStatistics.Size = new System.Drawing.Size(209, 74);
            this.btnMStatistics.TabIndex = 1;
            this.btnMStatistics.Text = "Statistics";
            this.btnMStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMStatistics.UseVisualStyleBackColor = false;
            this.btnMStatistics.Click += new System.EventHandler(this.btnMStatistics_Click);
            // 
            // btnMEmployees
            // 
            this.btnMEmployees.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMEmployees.Location = new System.Drawing.Point(0, 74);
            this.btnMEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.btnMEmployees.Name = "btnMEmployees";
            this.btnMEmployees.Size = new System.Drawing.Size(209, 74);
            this.btnMEmployees.TabIndex = 0;
            this.btnMEmployees.Text = "Employees";
            this.btnMEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMEmployees.UseVisualStyleBackColor = false;
            this.btnMEmployees.Click += new System.EventHandler(this.btnMEmployees_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 741);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnMStatistics;
        private System.Windows.Forms.Button btnMEmployees;
        private System.Windows.Forms.Label label1;
    }
}