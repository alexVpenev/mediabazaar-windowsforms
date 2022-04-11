namespace WindowsFormsApp5
{
    partial class SalesRepresentative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesRepresentative));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnSRAttendance = new System.Windows.Forms.Button();
            this.btnSRStockRequests = new System.Windows.Forms.Button();
            this.btnSRStockDepot = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(207, 78);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1299, 662);
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
            this.panelTop.Size = new System.Drawing.Size(1299, 74);
            this.panelTop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sales Representative";
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
            this.sidePanel.Controls.Add(this.btnSRAttendance);
            this.sidePanel.Controls.Add(this.btnSRStockRequests);
            this.sidePanel.Controls.Add(this.btnSRStockDepot);
            this.sidePanel.Location = new System.Drawing.Point(-1, -2);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(209, 742);
            this.sidePanel.TabIndex = 3;
            // 
            // btnSRAttendance
            // 
            this.btnSRAttendance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSRAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSRAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSRAttendance.Location = new System.Drawing.Point(0, 215);
            this.btnSRAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.btnSRAttendance.Name = "btnSRAttendance";
            this.btnSRAttendance.Size = new System.Drawing.Size(209, 74);
            this.btnSRAttendance.TabIndex = 3;
            this.btnSRAttendance.Text = "Attendance check";
            this.btnSRAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSRAttendance.UseVisualStyleBackColor = false;
            this.btnSRAttendance.Click += new System.EventHandler(this.btnSRAttendance_Click);
            // 
            // btnSRStockRequests
            // 
            this.btnSRStockRequests.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSRStockRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSRStockRequests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSRStockRequests.Location = new System.Drawing.Point(0, 144);
            this.btnSRStockRequests.Margin = new System.Windows.Forms.Padding(4);
            this.btnSRStockRequests.Name = "btnSRStockRequests";
            this.btnSRStockRequests.Size = new System.Drawing.Size(209, 74);
            this.btnSRStockRequests.TabIndex = 1;
            this.btnSRStockRequests.Text = "Stock Requests";
            this.btnSRStockRequests.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSRStockRequests.UseVisualStyleBackColor = false;
            this.btnSRStockRequests.Click += new System.EventHandler(this.btnSRStockRequests_Click);
            // 
            // btnSRStockDepot
            // 
            this.btnSRStockDepot.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSRStockDepot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSRStockDepot.Location = new System.Drawing.Point(0, 74);
            this.btnSRStockDepot.Margin = new System.Windows.Forms.Padding(4);
            this.btnSRStockDepot.Name = "btnSRStockDepot";
            this.btnSRStockDepot.Size = new System.Drawing.Size(209, 74);
            this.btnSRStockDepot.TabIndex = 0;
            this.btnSRStockDepot.Text = "Stock Depot";
            this.btnSRStockDepot.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSRStockDepot.UseVisualStyleBackColor = false;
            this.btnSRStockDepot.Click += new System.EventHandler(this.btnSRStockDepot_Click);
            // 
            // SalesRepresentative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 740);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesRepresentative";
            this.Text = "SalesRepresentative";
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
        private System.Windows.Forms.Button btnSRStockRequests;
        private System.Windows.Forms.Button btnSRStockDepot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSRAttendance;
    }
}