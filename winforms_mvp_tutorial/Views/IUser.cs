using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winforms_mvp_tutorial.Views
{
    public interface IUser
    {
        string tbxUsername { get; set; }
        string tbxPwd { get; set; }
    }
}
