using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace LED_Handheld_Project.Class
{
    public class UserRepository : IUserRepository
    {
        public async Task<bool> Insert (User user)
        {
            using(IDbConnection db = new SqlConnection(AppHelper.ConnectionString))
            {
                var result = await db.ExecuteAsync(LED_Handheld_Project.Properties.Resources.InsertUser, new { username = user.username, password = user.password });
                return result > 0;
            }
        }
    }
}
