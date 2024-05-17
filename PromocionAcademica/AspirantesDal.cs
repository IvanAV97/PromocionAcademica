using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromocionAcademica
{
    public class AspirantesDal
    {

        public static int AgregarAspirantes(Aspirante aspirante) 
        {
            int retorna = 0;

            using (SqlConnection conexion = BDPromAcademica.ObtenerConexion())
            {
                string query = "insert into Aspirante (Nombre,CorreoE,Numtelefono,EscuelaProcedencia) values ('" + aspirante.Nombre + "', '" + aspirante.CorreoE + "', '" + aspirante.Numtelefono + "', '" + aspirante.EscuelaProcedencia + "')";
                SqlCommand Comando = new SqlCommand(query, conexion);
                retorna = Comando.ExecuteNonQuery();



            }
                
                return retorna;
        
        
        
        }









    }
}
