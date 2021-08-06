using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
namespace Tema
{
    public static class Helper
    {
        public static string CnnVal(string nume)
        {
            return ConfigurationManager.ConnectionStrings[nume].ConnectionString;
        }
    }
}
