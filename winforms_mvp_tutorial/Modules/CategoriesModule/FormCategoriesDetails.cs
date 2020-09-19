using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winforms_mvp_tutorial.Views;

namespace winforms_mvp_tutorial.Modules.CategoriesModule
{
    public partial class FormCategoriesDetails : MetroFramework.Forms.MetroForm,  ICategory
    {
        public FormCategoriesDetails()
        {
            InitializeComponent();
        }

        #region ICategory interface implementation 
        public ComboBox cbxCategories
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string tbxCatName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        DataGridView ICategory.dgvCategoriesDetails => dgvCategoriesDetails;
        
        #endregion
        

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormCategoriesOption.Instance.Show();
        }
    }
}
