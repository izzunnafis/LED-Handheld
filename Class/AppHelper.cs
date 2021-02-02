using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LED_Handheld_Project.Class
{
    public static class AppHelper
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["LED_Handheld_Project.Properties.Settings.cn"].ConnectionString;
    }
}
