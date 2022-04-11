
namespace WindowsFormsApp5
{
    partial class AddProductForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbShipDate = new System.Windows.Forms.TextBox();
            this.tbWarehouseNr = new System.Windows.Forms.TextBox();
            this.tbRegEmp = new System.Windows.Forms.TextBox();
            this.tbLocRight = new System.Windows.Forms.TextBox();
            this.tbLocLeft = new System.Windows.Forms.TextBox();
            this.tbAisle = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(201, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 28;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(65, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 36);
            this.button2.TabIndex = 29;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 395);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 17);
            this.label14.TabIndex = 57;
            this.label14.Text = "Shipment Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 368);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 17);
            this.label13.TabIndex = 56;
            this.label13.Text = "Number in warehouse*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 17);
            this.label12.TabIndex = 55;
            this.label12.Text = "Registering employee*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 17);
            this.label11.TabIndex = 54;
            this.label11.Text = "Location right side*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 17);
            this.label10.TabIndex = 53;
            this.label10.Text = "Location left side*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "Aisle nr*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 51;
            this.label8.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Width* [cm]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Height* [cm]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Weight* [kg]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Price* [eur]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Brand name*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Model*";
            // 
            // tbShipDate
            // 
            this.tbShipDate.Location = new System.Drawing.Point(166, 391);
            this.tbShipDate.Name = "tbShipDate";
            this.tbShipDate.Size = new System.Drawing.Size(100, 22);
            this.tbShipDate.TabIndex = 43;
            // 
            // tbWarehouseNr
            // 
            this.tbWarehouseNr.Location = new System.Drawing.Point(166, 363);
            this.tbWarehouseNr.Name = "tbWarehouseNr";
            this.tbWarehouseNr.Size = new System.Drawing.Size(100, 22);
            this.tbWarehouseNr.TabIndex = 42;
            // 
            // tbRegEmp
            // 
            this.tbRegEmp.Location = new System.Drawing.Point(166, 335);
            this.tbRegEmp.Name = "tbRegEmp";
            this.tbRegEmp.Size = new System.Drawing.Size(100, 22);
            this.tbRegEmp.TabIndex = 41;
            // 
            // tbLocRight
            // 
            this.tbLocRight.Location = new System.Drawing.Point(166, 307);
            this.tbLocRight.Name = "tbLocRight";
            this.tbLocRight.Size = new System.Drawing.Size(100, 22);
            this.tbLocRight.TabIndex = 40;
            // 
            // tbLocLeft
            // 
            this.tbLocLeft.Location = new System.Drawing.Point(166, 279);
            this.tbLocLeft.Name = "tbLocLeft";
            this.tbLocLeft.Size = new System.Drawing.Size(100, 22);
            this.tbLocLeft.TabIndex = 38;
            // 
            // tbAisle
            // 
            this.tbAisle.Location = new System.Drawing.Point(166, 251);
            this.tbAisle.Name = "tbAisle";
            this.tbAisle.Size = new System.Drawing.Size(100, 22);
            this.tbAisle.TabIndex = 37;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(166, 194);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(100, 22);
            this.tbWidth.TabIndex = 36;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(166, 166);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 22);
            this.tbHeight.TabIndex = 35;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(166, 138);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(100, 22);
            this.tbWeight.TabIndex = 34;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(166, 110);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(100, 22);
            this.tbDescription.TabIndex = 33;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(166, 82);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 22);
            this.tbPrice.TabIndex = 32;
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(166, 54);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(100, 22);
            this.tbBrand.TabIndex = 31;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(166, 26);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 22);
            this.tbModel.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 525);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 17);
            this.label15.TabIndex = 58;
            this.label15.Text = "*Required information";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "ELECTRONICS",
            "KITCHENWARE",
            "SALES"});
            this.cbCategory.Location = new System.Drawing.Point(166, 223);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(100, 24);
            this.cbCategory.TabIndex = 59;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 551);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbShipDate);
            this.Controls.Add(this.tbWarehouseNr);
            this.Controls.Add(this.tbRegEmp);
            this.Controls.Add(this.tbLocRight);
            this.Controls.Add(this.tbLocLeft);
            this.Controls.Add(this.tbAisle);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AddProductForm";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbShipDate;
        private System.Windows.Forms.TextBox tbWarehouseNr;
        private System.Windows.Forms.TextBox tbRegEmp;
        private System.Windows.Forms.TextBox tbLocRight;
        private System.Windows.Forms.TextBox tbLocLeft;
        private System.Windows.Forms.TextBox tbAisle;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}