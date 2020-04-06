using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using winforms_mvp_tutorial.Models;
using winforms_mvp_tutorial.Views;

namespace winforms_mvp_tutorial.Presenters
{
    public class UserPresenter
    {
        simple_store_dbEntities _db = new simple_store_dbEntities();
        IUser _user;
        public static string GeTUsername { get; set; }

        private static UserPresenter _instance;

        public static UserPresenter Instance => _instance ?? (_instance = new UserPresenter());

        public UserPresenter()
        {
            //Constructor
        }

        public bool Login(IUser view)
        {
            _user = view;
            var result = (from p in _db.profiles
                    join u in _db.users
                        on p.profile_id equals u.fk_profile_id
                    where (u.username == _user.tbxUsername && u.pwd == _user.tbxPwd)
                    select new
                    {
                        profile_name = p.profile_name,
                        username = u.username,
                        pwd = u.pwd
                    })
                .ToList()
                .FirstOrDefault();
            if (result == null || _user.tbxUsername != result.username || _user.tbxPwd != result.pwd) return false;
            GeTUsername = result.username;
            return true;
        }


    }
}
