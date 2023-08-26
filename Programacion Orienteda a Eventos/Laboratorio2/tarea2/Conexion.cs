using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace POEllaboratorio_
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=ZETATW0\\SQLEXPRESS;DATABASE=ADMINISTRACION;integrated security=true;");
            cn.Open();
            return cn;
        }

    }
}
