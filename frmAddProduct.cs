using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryApp_BSCS301
{
    public partial class frmAddProduct : Form
    {
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private int _Quantity;
        private double _SellPrice;
        BindingSource showProductList;


        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = { "Beverages", "Bread/Bakery", "Canned/Jarred Goods", "Dairy",
            "Frozen Goods", "Meat", "Personal Care", "Other"};

            foreach (string Product in ListOfProductCategory)
            {
                cbCategory.Items.Add(Product);
            }

        }

        public string Product_Name(string name)
        {

            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                throw new StringFormatException("Invalid Product Input!");
            }
            else
            {
                return name;
            }
        }

        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]"))
            {
                    throw new NumberFormatException("Invalid Quantity Input!");
            }
            else
            {
                return Convert.ToInt32(qty);
            }
               
            

        }
        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
            {
                throw new CurrencyFormatException("Invalid Price Input!");
            }
            else
            {
                return Convert.ToDouble(price);
            }
                
            
        }


        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSellPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtPickerMfgDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtPickerExpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTxtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                
                
               

            } catch(StringFormatException sfe)
            {
                Console.WriteLine(sfe.Message);
            }

            try {
                _Quantity = Quantity(txtQuantity.Text);
                
            }
            catch (NumberFormatException nfe)
            {
                Console.WriteLine(nfe.Message);
            }
            try {
                _SellPrice = SellingPrice(txtSellPrice.Text);
            }
            catch (CurrencyFormatException cfe)
            {
                Console.WriteLine(cfe.Message);
            }

            _Category = cbCategory.Text;
            _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
            _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
            _Description = richTxtDescription.Text;


            showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate, _SellPrice, _Quantity, _Description));
            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            gridViewProductList.DataSource = showProductList;

        }

        private void gridViewProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
