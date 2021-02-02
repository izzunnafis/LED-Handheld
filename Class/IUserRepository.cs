using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED_Handheld_Project.Class
{
    public interface IUserRepository
    {
        Task<bool> Insert(User user);
    }
}
