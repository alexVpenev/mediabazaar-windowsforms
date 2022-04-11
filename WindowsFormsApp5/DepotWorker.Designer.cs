namespace WindowsFormsApp5
{
    partial class DepotWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepotWorker));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnDWStockRequests = new System.Windows.Forms.Button();
            this.btnDWStockDepot = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(207, 76);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1302, 666);
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
            this.panelTop.Size = new System.Drawing.Size(1302, 74);
            this.panelTop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Depot Worker";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(1130, 0);
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
            this.btnClose.Location = new System.Drawing.Point(1213, 0);
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
            this.sidePanel.Controls.Add(this.btnDWStockRequests);
            this.sidePanel.Controls.Add(this.btnDWStockDepot);
            this.sidePanel.Location = new System.Drawing.Point(-1, -2);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(209, 748);
            this.sidePanel.TabIndex = 3;
            // 
            // btnDWStockRequests
            // 
            this.btnDWStockRequests.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDWStockRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDWStockRequests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDWStockRequests.Location = new System.Drawing.Point(0, 144);
            this.btnDWStockRequests.Margin = new System.Windows.Forms.Padding(4);
            this.btnDWStockRequests.Name = "btnDWStockRequests";
            this.btnDWStockRequests.Size = new System.Drawing.Size(209, 74);
            this.btnDWStockRequests.TabIndex = 1;
            this.btnDWStockRequests.Text = "Stock Requests";
            this.btnDWStockRequests.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDWStockRequests.UseVisualStyleBackColor = false;
            this.btnDWStockRequests.Click += new System.EventHandler(this.btnDWStockRequests_Click);
            // 
            // btnDWStockDepot
            // 
            this.btnDWStockDepot.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDWStockDepot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDWStockDepot.Location = new System.Drawing.Point(0, 74);
            this.btnDWStockDepot.Margin = new System.Windows.Forms.Padding(4);
            this.btnDWStockDepot.Name = "btnDWStockDepot";
            this.btnDWStockDepot.Size = new System.Drawing.Size(209, 74);
            this.btnDWStockDepot.TabIndex = 0;
            this.btnDWStockDepot.Text = "Stock Depot";
            this.btnDWStockDepot.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDWStockDepot.UseVisualStyleBackColor = false;
            this.btnDWStockDepot.Click += new System.EventHandler(this.btnDWStockDepot_Click);
            // 
            // DepotWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 740);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepotWorker";
            this.Text = "DepotWorker";
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
        private System.Windows.Forms.Button btnDWStockRequests;
        private System.Windows.Forms.Button btnDWStockDepot;
        private System.Windows.Forms.Label label1;
    }
}