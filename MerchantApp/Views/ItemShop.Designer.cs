namespace MerchantApp
{
    partial class ItemShop
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
            this.dgvWares = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtItem_Name = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtItem_Origin = new System.Windows.Forms.TextBox();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemOriginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemOrigin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWares
            // 
            this.dgvWares.AutoGenerateColumns = false;
            this.dgvWares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.priceDataGridViewTextBoxColumn,
            this.Item_Name,
            this.itemOriginDataGridViewTextBoxColumn});
            this.dgvWares.DataSource = this.wareBindingSource;
            this.dgvWares.Location = new System.Drawing.Point(501, 331);
            this.dgvWares.Name = "dgvWares";
            this.dgvWares.RowHeadersWidth = 30;
            this.dgvWares.Size = new System.Drawing.Size(333, 120);
            this.dgvWares.TabIndex = 0;
            this.dgvWares.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWares_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Item_Name
            // 
            this.Item_Name.DataPropertyName = "Item_Name";
            this.Item_Name.HeaderText = "Item_Name";
            this.Item_Name.Name = "Item_Name";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(527, 302);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(630, 302);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(736, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtItem_Name
            // 
            this.txtItem_Name.Location = new System.Drawing.Point(374, 382);
            this.txtItem_Name.Name = "txtItem_Name";
            this.txtItem_Name.Size = new System.Drawing.Size(100, 20);
            this.txtItem_Name.TabIndex = 5;
            this.txtItem_Name.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(374, 331);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // txtItem_Origin
            // 
            this.txtItem_Origin.Location = new System.Drawing.Point(374, 431);
            this.txtItem_Origin.Name = "txtItem_Origin";
            this.txtItem_Origin.Size = new System.Drawing.Size(100, 20);
            this.txtItem_Origin.TabIndex = 8;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // itemOriginDataGridViewTextBoxColumn
            // 
            this.itemOriginDataGridViewTextBoxColumn.DataPropertyName = "Item_Origin";
            this.itemOriginDataGridViewTextBoxColumn.HeaderText = "Item_Origin";
            this.itemOriginDataGridViewTextBoxColumn.Name = "itemOriginDataGridViewTextBoxColumn";
            // 
            // wareBindingSource
            // 
            this.wareBindingSource.DataSource = typeof(MerchantApp.Model.Ware);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(407, 312);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(394, 366);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 10;
            this.lblItemName.Text = "Item Name";
            // 
            // lblItemOrigin
            // 
            this.lblItemOrigin.AutoSize = true;
            this.lblItemOrigin.Location = new System.Drawing.Point(394, 415);
            this.lblItemOrigin.Name = "lblItemOrigin";
            this.lblItemOrigin.Size = new System.Drawing.Size(57, 13);
            this.lblItemOrigin.TabIndex = 11;
            this.lblItemOrigin.Text = "Item Origin";
            // 
            // ItemShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MerchantApp.Properties.Resources.merchant;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 463);
            this.Controls.Add(this.lblItemOrigin);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtItem_Origin);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItem_Name);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvWares);
            this.Name = "ItemShop";
            this.Text = "ItemShop";
            this.Load += new System.EventHandler(this.ItemShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWares;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource wareBindingSource;
        private System.Windows.Forms.TextBox txtItem_Name;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemOriginDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtItem_Origin;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemOrigin;
    }
}

