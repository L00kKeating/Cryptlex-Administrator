using Cryptlex_Administrator.Classes;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            PopProductsDatatable();
        }

        #region Populate mainform components
        public void PopProductsDatatable()
        {
            var apiHandler = new APIHandler();

            //apiHandler.Login();

            var source = new BindingSource();
            source.DataSource = apiHandler.GetProducts();

            dataGridProducts.AutoGenerateColumns = true;
            dataGridProducts.DataSource = source;
        }
        #endregion

        private void btn_CreateProduct_Click(object sender, EventArgs e)
        {
            var createProductForm = new CreateProductForm();
            createProductForm.ShowDialog();
            createProductForm.FormClosed += delegate
            {
                //MessageBox.Show("subForm has closed");
            };
            this.PopProductsDatatable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var key = APIHandler.CreateLiscence(dataGridProducts.CurrentCell.Value.ToString());

            if(key != string.Empty)
                MessageBox.Show($"License key: {key}", "License key has been succesfully generated.");

            this.PopProductsDatatable();
        }
    }

}
