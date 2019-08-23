using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfShop
{
    public partial class FrmProductEdit : Form
    {
        int id = -1;
        public FrmProductEdit()
        {
            InitializeComponent();

            var catREp = new CategoryRepository();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = catREp.List();
        }

        public FrmProductEdit(Products entity)
        {
            InitializeComponent();

            var catREp = new CategoryRepository();
           
            comboBox1.DataSource = catREp.List();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedValue = entity.categoryId;

            txtName.Text = entity.Name;
            txtPrice.Text = entity.Price.ToString();
            txtProductCode.Text = entity.productCode;
            txtStok.Text = entity.stocks.ToString();
            id = entity.Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.categoryId = Convert.ToInt32(comboBox1.SelectedValue);
            p.Name = txtName.Text;
            p.Price = Convert.ToDecimal(txtPrice.Text);
            p.productCode = txtProductCode.Text;
            p.stocks = Convert.ToInt32(txtStok.Text);
            
            ProductRepository rep = new ProductRepository();

            if (id == -1)
            {
                rep.Add(p);
            }
            else
            {
                p.Id = id;
                rep.Update(p);
            }


            Close();

        }
    }
}
