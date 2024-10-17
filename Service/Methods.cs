using HttpRequestDB.Context;
using HttpRequestDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequestDB.Service
{
    public class Methods
    {
        public List<User> GetAllUsers()
        {
            using (var context = new UserContext())
            {
                return context.Users.ToList();
            }
        }
    }
}
