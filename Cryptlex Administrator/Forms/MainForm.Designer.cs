namespace Cryptlex_Administrator
{
    partial class MainForm
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tab_Products = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_CreateProduct = new System.Windows.Forms.Button();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTrialActivationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalReleasesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProductVersionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFeatureFlagsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metaDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TabControl.SuspendLayout();
            this.tab_Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tab_Products);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1366, 305);
            this.TabControl.TabIndex = 0;
            // 
            // tab_Products
            // 
            this.tab_Products.Controls.Add(this.button1);
            this.tab_Products.Controls.Add(this.btn_CreateProduct);
            this.tab_Products.Controls.Add(this.dataGridProducts);
            this.tab_Products.Location = new System.Drawing.Point(4, 22);
            this.tab_Products.Name = "tab_Products";
            this.tab_Products.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Products.Size = new System.Drawing.Size(1358, 279);
            this.tab_Products.TabIndex = 0;
            this.tab_Products.Text = "Products";
            this.tab_Products.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Create a liscence/ generate license key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_CreateProduct
            // 
            this.btn_CreateProduct.Location = new System.Drawing.Point(6, 6);
            this.btn_CreateProduct.Name = "btn_CreateProduct";
            this.btn_CreateProduct.Size = new System.Drawing.Size(192, 23);
            this.btn_CreateProduct.TabIndex = 18;
            this.btn_CreateProduct.Text = "Create Product";
            this.btn_CreateProduct.UseVisualStyleBackColor = true;
            this.btn_CreateProduct.Click += new System.EventHandler(this.btn_CreateProduct_Click);
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.AutoGenerateColumns = false;
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.displayNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.publicKeyDataGridViewTextBoxColumn,
            this.totalTrialActivationsDataGridViewTextBoxColumn,
            this.totalReleasesDataGridViewTextBoxColumn,
            this.totalProductVersionsDataGridViewTextBoxColumn,
            this.totalFeatureFlagsDataGridViewTextBoxColumn,
            this.metaDataDataGridViewTextBoxColumn});
            this.dataGridProducts.DataSource = this.productsBindingSource;
            this.dataGridProducts.Location = new System.Drawing.Point(6, 35);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.Size = new System.Drawing.Size(1346, 235);
            this.dataGridProducts.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // displayNameDataGridViewTextBoxColumn
            // 
            this.displayNameDataGridViewTextBoxColumn.DataPropertyName = "displayName";
            this.displayNameDataGridViewTextBoxColumn.HeaderText = "displayName";
            this.displayNameDataGridViewTextBoxColumn.Name = "displayNameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // publicKeyDataGridViewTextBoxColumn
            // 
            this.publicKeyDataGridViewTextBoxColumn.DataPropertyName = "publicKey";
            this.publicKeyDataGridViewTextBoxColumn.HeaderText = "publicKey";
            this.publicKeyDataGridViewTextBoxColumn.Name = "publicKeyDataGridViewTextBoxColumn";
            // 
            // totalTrialActivationsDataGridViewTextBoxColumn
            // 
            this.totalTrialActivationsDataGridViewTextBoxColumn.DataPropertyName = "totalTrialActivations";
            this.totalTrialActivationsDataGridViewTextBoxColumn.HeaderText = "totalTrialActivations";
            this.totalTrialActivationsDataGridViewTextBoxColumn.Name = "totalTrialActivationsDataGridViewTextBoxColumn";
            // 
            // totalReleasesDataGridViewTextBoxColumn
            // 
            this.totalReleasesDataGridViewTextBoxColumn.DataPropertyName = "totalReleases";
            this.totalReleasesDataGridViewTextBoxColumn.HeaderText = "totalReleases";
            this.totalReleasesDataGridViewTextBoxColumn.Name = "totalReleasesDataGridViewTextBoxColumn";
            // 
            // totalProductVersionsDataGridViewTextBoxColumn
            // 
            this.totalProductVersionsDataGridViewTextBoxColumn.DataPropertyName = "totalProductVersions";
            this.totalProductVersionsDataGridViewTextBoxColumn.HeaderText = "totalProductVersions";
            this.totalProductVersionsDataGridViewTextBoxColumn.Name = "totalProductVersionsDataGridViewTextBoxColumn";
            // 
            // totalFeatureFlagsDataGridViewTextBoxColumn
            // 
            this.totalFeatureFlagsDataGridViewTextBoxColumn.DataPropertyName = "totalFeatureFlags";
            this.totalFeatureFlagsDataGridViewTextBoxColumn.HeaderText = "totalFeatureFlags";
            this.totalFeatureFlagsDataGridViewTextBoxColumn.Name = "totalFeatureFlagsDataGridViewTextBoxColumn";
            // 
            // metaDataDataGridViewTextBoxColumn
            // 
            this.metaDataDataGridViewTextBoxColumn.DataPropertyName = "metaData";
            this.metaDataDataGridViewTextBoxColumn.HeaderText = "metaData";
            this.metaDataDataGridViewTextBoxColumn.Name = "metaDataDataGridViewTextBoxColumn";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(Cryptlex_Administrator.Classes.Products);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Cryptlex_Administrator.Classes.Product);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(Cryptlex_Administrator.Classes.Product);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 329);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.tab_Products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tab_Products;
        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTrialActivationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalReleasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProductVersionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFeatureFlagsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseTemplateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trailPolicyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metaDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_CreateProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource productsBindingSource;
    }
}

