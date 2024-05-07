namespace Cryptlex_Administrator
{
    partial class CreateProductForm
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
            this.btn_CreateProduct = new System.Windows.Forms.Button();
            this.btn_CreateLiscence = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DisplayName = new System.Windows.Forms.TextBox();
            this.rtb_ProductDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_liscenceTempates = new System.Windows.Forms.ComboBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_CreateProduct
            // 
            this.btn_CreateProduct.Location = new System.Drawing.Point(14, 187);
            this.btn_CreateProduct.Name = "btn_CreateProduct";
            this.btn_CreateProduct.Size = new System.Drawing.Size(192, 23);
            this.btn_CreateProduct.TabIndex = 25;
            this.btn_CreateProduct.Text = "Create Product";
            this.btn_CreateProduct.UseVisualStyleBackColor = true;
            this.btn_CreateProduct.Click += new System.EventHandler(this.btn_CreateProduct_Click);
            // 
            // btn_CreateLiscence
            // 
            this.btn_CreateLiscence.Location = new System.Drawing.Point(141, 64);
            this.btn_CreateLiscence.Name = "btn_CreateLiscence";
            this.btn_CreateLiscence.Size = new System.Drawing.Size(69, 23);
            this.btn_CreateLiscence.TabIndex = 26;
            this.btn_CreateLiscence.Text = "+";
            this.btn_CreateLiscence.UseVisualStyleBackColor = true;
            this.btn_CreateLiscence.Click += new System.EventHandler(this.btn_CreateLiscence_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Description";
            // 
            // txt_DisplayName
            // 
            this.txt_DisplayName.Location = new System.Drawing.Point(114, 24);
            this.txt_DisplayName.Name = "txt_DisplayName";
            this.txt_DisplayName.Size = new System.Drawing.Size(96, 20);
            this.txt_DisplayName.TabIndex = 20;
            this.txt_DisplayName.TextChanged += new System.EventHandler(this.txt_DisplayName_TextChanged);
            // 
            // rtb_ProductDescription
            // 
            this.rtb_ProductDescription.Location = new System.Drawing.Point(12, 111);
            this.rtb_ProductDescription.Name = "rtb_ProductDescription";
            this.rtb_ProductDescription.Size = new System.Drawing.Size(198, 69);
            this.rtb_ProductDescription.TabIndex = 23;
            this.rtb_ProductDescription.Text = "";
            this.rtb_ProductDescription.TextChanged += new System.EventHandler(this.rtb_ProductDescription_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Liscence Template *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Display Name *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name *";
            // 
            // cmb_liscenceTempates
            // 
            this.cmb_liscenceTempates.FormattingEnabled = true;
            this.cmb_liscenceTempates.Location = new System.Drawing.Point(12, 66);
            this.cmb_liscenceTempates.Name = "cmb_liscenceTempates";
            this.cmb_liscenceTempates.Size = new System.Drawing.Size(123, 21);
            this.cmb_liscenceTempates.TabIndex = 21;
            this.cmb_liscenceTempates.SelectedValueChanged += new System.EventHandler(this.cmb_liscenceTempates_SelectedValueChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(12, 24);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(96, 20);
            this.txt_Name.TabIndex = 19;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // CreateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 221);
            this.Controls.Add(this.btn_CreateProduct);
            this.Controls.Add(this.btn_CreateLiscence);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_DisplayName);
            this.Controls.Add(this.rtb_ProductDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_liscenceTempates);
            this.Controls.Add(this.txt_Name);
            this.Name = "CreateProductForm";
            this.Text = "CreateProductFomr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateProduct;
        private System.Windows.Forms.Button btn_CreateLiscence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DisplayName;
        private System.Windows.Forms.RichTextBox rtb_ProductDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_liscenceTempates;
        private System.Windows.Forms.TextBox txt_Name;
    }
}