using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromocionAcademica
{
    public class Aspirante
    {
        public string Nombre { get; set; }
        public string CorreoE { get; set; }
        public string Numtelefono { get; set; }
        public string EscuelaProcedencia { get; set; }




        public Aspirante() { }

        public Aspirante(string Nombre, string CorreoE, string Numtelefono, string EscuelaProcedencia)
        {
            this.Nombre = Nombre;
            this.CorreoE = CorreoE;
            this.Numtelefono = Numtelefono;
            this.EscuelaProcedencia = EscuelaProcedencia;
        }



    }




}
