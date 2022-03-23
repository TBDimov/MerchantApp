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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemOriginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waresDBDataSet = new MerchantApp.WaresDBDataSet();
            this.waresTableAdapter = new MerchantApp.WaresDBDataSetTableAdapters.WaresTableAdapter();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waresDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWares
            // 
            this.dgvWares.AutoGenerateColumns = false;
            this.dgvWares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemOriginDataGridViewTextBoxColumn});
            this.dgvWares.DataSource = this.waresBindingSource;
            this.dgvWares.Location = new System.Drawing.Point(366, 318);
            this.dgvWares.Name = "dgvWares";
            this.dgvWares.RowHeadersWidth = 20;
            this.dgvWares.Size = new System.Drawing.Size(422, 120);
            this.dgvWares.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Name";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item_Name";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // itemOriginDataGridViewTextBoxColumn
            // 
            this.itemOriginDataGridViewTextBoxColumn.DataPropertyName = "Item_Origin";
            this.itemOriginDataGridViewTextBoxColumn.HeaderText = "Item_Origin";
            this.itemOriginDataGridViewTextBoxColumn.Name = "itemOriginDataGridViewTextBoxColumn";
            // 
            // waresBindingSource
            // 
            this.waresBindingSource.DataMember = "Wares";
            this.waresBindingSource.DataSource = this.waresDBDataSet;
            // 
            // waresDBDataSet
            // 
            this.waresDBDataSet.DataSetName = "WaresDBDataSet";
            this.waresDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // waresTableAdapter
            // 
            this.waresTableAdapter.ClearBeforeFill = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(393, 289);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(497, 289);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(597, 289);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(694, 289);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // ItemShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MerchantApp.Properties.Resources.merchant;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvWares);
            this.Name = "ItemShop";
            this.Text = "ItemShop";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waresDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWares;
        private WaresDBDataSet waresDBDataSet;
        private System.Windows.Forms.BindingSource waresBindingSource;
        private WaresDBDataSetTableAdapters.WaresTableAdapter waresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemOriginDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

