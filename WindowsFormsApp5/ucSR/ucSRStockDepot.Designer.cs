namespace WindowsFormsApp5.ucSR
{
    partial class ucSRStockDepot
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
            this.model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brand_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nr_in_warehouse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aisle_nr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shelf_nr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.model,
            this.brand_name,
            this.category,
            this.price,
            this.nr_in_warehouse,
            this.aisle_nr,
            this.shelf_nr});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(78, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1098, 573);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // model
            // 
            this.model.Text = "Model";
            this.model.Width = 113;
            // 
            // brand_name
            // 
            this.brand_name.Text = "BrandName";
            this.brand_name.Width = 130;
            // 
            // category
            // 
            this.category.Text = "Category";
            this.category.Width = 135;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 83;
            // 
            // nr_in_warehouse
            // 
            this.nr_in_warehouse.Text = "Quantity";
            this.nr_in_warehouse.Width = 110;
            // 
            // aisle_nr
            // 
            this.aisle_nr.Text = "AisleNr";
            this.aisle_nr.Width = 78;
            // 
            // shelf_nr
            // 
            this.shelf_nr.Text = "ShelfID";
            // 
            // ucSRStockDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucSRStockDepot";
            this.Size = new System.Drawing.Size(1295, 668);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader model;
        private System.Windows.Forms.ColumnHeader brand_name;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader aisle_nr;
        private System.Windows.Forms.ColumnHeader nr_in_warehouse;
        private System.Windows.Forms.ColumnHeader shelf_nr;
        private System.Windows.Forms.ColumnHeader category;
    }
}
