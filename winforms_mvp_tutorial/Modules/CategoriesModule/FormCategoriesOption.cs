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

namespace winforms_mvp_tutorial.Modules.CategoriesModule
{
    public partial class FormCategoriesOption : MetroFramework.Forms.MetroForm,ICategory
    {
        private event EventHandler btnSaveClick;
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

        #region ICategory Interface implementation using expression body
        string ICategory.tbxCatName { get => tbxCatName.Text; set => tbxCatName.Text = value; }

        public DataGridView dgvCategoriesDetails => throw new NotImplementedException();

        public ComboBox cbxCategories => throw new NotImplementedException();

        #endregion
       
        public FormCategoriesOption()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CategoryPresenter.Instance.insertCategory(this);
            btnSaveClick?.Invoke(sender,e);
            Close();
        }
    }
}
