using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromocionAcademica
{
    public class BDPromAcademica
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PromAcademica;Data Source=DESKTOP-PGS8GBU");
            conexion.Open();
            return conexion;
        }




    }
}
