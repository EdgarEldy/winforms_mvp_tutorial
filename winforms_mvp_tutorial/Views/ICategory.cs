using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms_mvp_tutorial.Views
{
   public interface ICategory
    {
        string tbxCatName { get; set; }
        DataGridView dgvCategoriesDetails { get; }
        ComboBox cbxCategories { get; }
    }
}
