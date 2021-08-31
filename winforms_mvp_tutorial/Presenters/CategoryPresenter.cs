using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winforms_mvp_tutorial.Data;
using winforms_mvp_tutorial.Models;
using winforms_mvp_tutorial.Views;

namespace winforms_mvp_tutorial.Presenters
{
    class CategoryPresenter
    {
        ApplicationDbContext db = new ApplicationDbContext();
        private ICategory ICat;
        Category category = new Category();

        public CategoryPresenter()
        {
            
        }

        #region Singleton

        private static CategoryPresenter _instance;

        public static CategoryPresenter Instance => _instance ?? (_instance = new CategoryPresenter());

        #endregion

        public void InsertCategory(ICategory view)
        {
            ICat = view;
            category.CategoryName = ICat.tbxCatName;
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public DataGridView ShowCategories(ICategory view)
        {
            ICat = view;
            var result = db.Categories.ToList();
            foreach (var item in result)
            {
                int n = ICat.dgvCategoriesDetails.Rows.Add();
                ICat.dgvCategoriesDetails.Rows[n].Cells[0].Value = item.Id;
                ICat.dgvCategoriesDetails.Rows[n].Cells[1].Value = item.CategoryName;
            }

            if (ICat.dgvCategoriesDetails.Rows.Count > 0)
            {
                ICat.dgvCategoriesDetails.ClearSelection();
            }

            return ICat.dgvCategoriesDetails;
        }
    }
}
