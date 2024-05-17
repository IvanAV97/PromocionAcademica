using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromocionAcademica
{
    public class Maestro
    {
        public int NumeroDeEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string NumeroTelefono { get; set; }
        public string AreaProfesional { get; set; }


        public Maestro() { }

        public Maestro(int NumeroEmpleado,string Nombre, string Apellido, string CorreoElectronico, string NumeroTelefono, string AreaProfesional)
        {
            this.NumeroDeEmpleado = NumeroEmpleado;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.CorreoElectronico = CorreoElectronico;
            this.NumeroTelefono = NumeroTelefono;
            this.AreaProfesional = AreaProfesional;
        }

    }
}
