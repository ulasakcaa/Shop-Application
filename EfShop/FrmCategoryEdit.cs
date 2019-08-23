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
    public partial class FrmCategoryEdit : Form
    {
        int id = -1;
        public FrmCategoryEdit()
        {
            InitializeComponent();
        }
        public FrmCategoryEdit(Categories entity)
        {
            InitializeComponent();
            txtOrder.Text = entity.CatOrder.ToString();
            txtDesc.Text = entity.Description;
            txtName.Text = entity.Name;
            txtId.Text = entity.Id.ToString();
            id = entity.Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categories ct = new Categories();
            ct.CatOrder = Convert.ToInt32(txtOrder.Text);
            ct.Description = txtDesc.Text;
            ct.Name = txtName.Text;

            var rep = new CategoryRepository();

            if (id == -1)
            {
                rep.Add(ct);
            }
            else
            {
                ct.Id = id;
                rep.Update(ct);
            }

            Close();
        }
    }
}
