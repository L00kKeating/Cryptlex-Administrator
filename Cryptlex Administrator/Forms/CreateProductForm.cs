using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptlex_Administrator
{
    public partial class CreateProductForm : Form
    {
        public CreateProductForm()
        {
            InitializeComponent();
            PopLiscenceTemplateDropdown();
        }

        public void PopLiscenceTemplateDropdown()
        {
            var apiHandler = new APIHandler();


            var source = new BindingSource();
            source.DataSource = apiHandler.GetLiscenceTemplates();

            this.cmb_liscenceTempates.DataSource = source;
            this.cmb_liscenceTempates.DisplayMember = "name";
            this.cmb_liscenceTempates.ValueMember = "id";
            this.cmb_liscenceTempates.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_CreateLiscence_Click(object sender, EventArgs e)
        {

        }

        private void btn_CreateProduct_Click(object sender, EventArgs e)
        {
            var missingField = new List<string>();
            var missingFieldText = string.Empty;

            if (this.txt_Name.Text == string.Empty)
            {
                missingField.Add("name");
                txt_Name.BackColor = Color.Red;
            }

            if (this.txt_DisplayName.Text == string.Empty)
            {
                missingField.Add("display name");
                txt_DisplayName.BackColor = Color.Red;
            }

            if (this.cmb_liscenceTempates.SelectedItem == null)
            {
                missingField.Add("liscence template");
                cmb_liscenceTempates.BackColor = Color.Red;
            }
            if (this.rtb_ProductDescription.Text == string.Empty)
            {
                missingField.Add("liscence template");
                rtb_ProductDescription.BackColor = Color.Red;
            }

            if (missingField.Count() != 0)
            {
                foreach (var s in missingField)
                    missingFieldText = missingFieldText + ", " + s;

                MessageBox.Show($"Please fill in the {missingFieldText}", "Empty ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                APIHandler.CreateProduct(txt_Name.Text, txt_DisplayName.Text, cmb_liscenceTempates.SelectedValue.ToString(), rtb_ProductDescription.Text);
                this.Dispose();
            }

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_Name.Text != string.Empty)
                txt_Name.BackColor = Color.White;
        }

        private void txt_DisplayName_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_DisplayName.Text != string.Empty)
                txt_DisplayName.BackColor = Color.White;
        }

        private void cmb_liscenceTempates_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.txt_DisplayName.Text != string.Empty)
                cmb_liscenceTempates.BackColor = Color.White;
        }

        private void rtb_ProductDescription_TextChanged(object sender, EventArgs e)
        {

            if (this.txt_DisplayName.Text != string.Empty)
                txt_DisplayName.BackColor = Color.White;
        }
    }
}
