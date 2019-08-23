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
    public partial class FrmUserEdit : Form
    {
        int id = -1;
        public FrmUserEdit()
        {
            InitializeComponent();
        }
        public FrmUserEdit(Users usr)
        {
            InitializeComponent();
            id = usr.Id;
            textBoxFullName.Text = usr.FullName;
            textBoxUserName.Text = usr.UserName;
            textBoxPassword.Text = usr.Password;
            textBoxCredit.Text = usr.Credit.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Users usr = new Users();
            usr.FullName = textBoxFullName.Text;
            usr.UserName = textBoxUserName.Text;
            usr.Password = textBoxPassword.Text;
            usr.Credit = Convert.ToDecimal(textBoxCredit.Text);

            UserRepository rep = new UserRepository();

            if (id == -1)
            {
                rep.Add(usr);
            }
            else
            {
                usr.Id = id;
                 rep.Update(usr);
            }

            Close();
        }
    }
}
