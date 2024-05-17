using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromocionAcademica
{
    public class MaestrosDal
    {
        public static int AgregarMaestro(Maestro maestro)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDPromAcademica.ObtenerConexion())
            {
                string query = "INSERT INTO Maestros (NumeroDeEmpleado,Nombre,Apellido,CorreoElectronico,NumeroTelefono,AreaProfesional) values ("+maestro.NumeroDeEmpleado+", '"+maestro.Nombre+"', '"+maestro.Apellido+"', '"+maestro.CorreoElectronico+"', '"+maestro.NumeroTelefono+"', '"+maestro.AreaProfesional+"')";
                SqlCommand Comando = new SqlCommand(query, conexion);
                retorna = Comando.ExecuteNonQuery();



            }

            return retorna;


        }


    }
}
