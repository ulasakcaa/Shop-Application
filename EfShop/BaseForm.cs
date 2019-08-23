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
    public partial class BaseForm<T> : Form where T: class, IEntityBase
    {
        protected BaseRepository<T> rep;
        public BaseForm()
        {
            InitializeComponent();
        }

        protected virtual void refresh()
        {
            dataGridView1.DataSource = rep.List();

        }

        protected virtual void button1_Click(object sender, EventArgs e)
        {

        }

        protected virtual void button2_Click(object sender, EventArgs e)
        {

        }

        protected virtual void buttonDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select Row To Edit");
                return;
            }
            T entity = (T)dataGridView1.SelectedRows[0].DataBoundItem;

            rep.Delete(entity.Id);
            refresh();
        }
    }
}
