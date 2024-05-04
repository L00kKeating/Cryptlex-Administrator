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
            var apiHandler = new APIHandler(new UserCredentials("11013c89-af41-44b2-82a6-5fc34c40a961", "wholholho@gmail.com", "password"));

            apiHandler.Login();

            var source = new BindingSource();
            source.DataSource = apiHandler.GetProducts();

            dataGridProducts.AutoGenerateColumns = true;
            dataGridProducts.DataSource = source;
        }
        #endregion 
    }

}
