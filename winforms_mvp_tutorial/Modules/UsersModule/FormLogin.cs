using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winforms_mvp_tutorial.Presenters;
using winforms_mvp_tutorial.Views;

namespace winforms_mvp_tutorial.Modules.UsersModule
{
    public partial class FormLogin : MetroFramework.Forms.MetroForm,IUser
    {
        UserPresenter userp= new UserPresenter();
        public FormLogin()
        {
            InitializeComponent();
            tbxUsername.Focus();
        }

        string IUser.tbxPwd
        {
            get { return tbxPwd.Text; }

            set { tbxPwd.Text = value; }
        }

        string IUser.tbxUsername
        {
            get { return tbxUsername.Text; }

            set { tbxUsername.Text = value; }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (UserPresenter.Instance.Login(this))
            {
                var d = new Dashboard();
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Impossible de se connecter");
                tbxUsername.Clear();
                tbxPwd.Clear();
                tbxUsername.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
