using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDComDapper
{
    public static class StringConexao
    {
        public static string Conexao()
        {
            string conn = "Server=DESKTOP-VDKR8R6\\SQLEXPRESS;Database=CRUDDapper; Integrated Security=True;";
            return conn;
        }
    }
}
