using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms_mvp_tutorial.Modules.CategoriesModule
{
    public partial class FormCategoriesOption : MetroFramework.Forms.MetroForm
    {
        #region FormCategoriesOption singleton
        private static FormCategoriesOption _instance;
        public static FormCategoriesOption Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FormCategoriesOption();
                }
                return _instance;
            }
        } 
        #endregion
        public FormCategoriesOption()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
