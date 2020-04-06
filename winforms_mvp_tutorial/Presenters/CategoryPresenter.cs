using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winforms_mvp_tutorial.Models;
using winforms_mvp_tutorial.Views;

namespace winforms_mvp_tutorial.Presenters
{
    class CategoryPresenter
    {
        simple_store_dbEntities db = new simple_store_dbEntities();
        private ICategory ICat;
        category cat =new category();

        public CategoryPresenter()
        {
            
        }

        #region Singleton

        private static CategoryPresenter _instance;

        public static CategoryPresenter Instance => _instance ?? (_instance = new CategoryPresenter());

        #endregion

        public void insertCategory(ICategory view)
        {
            ICat = view;
            cat.cat_name = ICat.tbxCatName;
            db.categories.Add(cat);
            db.SaveChanges();
        }
    }
}
