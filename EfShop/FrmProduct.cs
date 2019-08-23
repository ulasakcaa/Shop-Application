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
    public partial class FrmProduct : BaseForm<Products>
    {
       
        public FrmProduct()
        {
            InitializeComponent();
            rep = new ProductRepository();
            refresh();
        }

        protected override void button1_Click(object sender, EventArgs e)
        {
            FrmProductEdit frm = new FrmProductEdit();

            frm.ShowDialog();
            refresh();
        }

        protected override void button2_Click(object sender, EventArgs e)
        {
            Products pp = (Products)dataGridView1.SelectedRows[0].DataBoundItem;

            FrmProductEdit frm = new FrmProductEdit(pp);

            frm.ShowDialog();
            refresh();
        }

       
    }
}
