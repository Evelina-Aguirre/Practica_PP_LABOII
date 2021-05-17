using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gente :Persona
    {

        public Gente(short edad) :base ("Cliente", edad)
        {

        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Gente :");
            sb.AppendLine("-------");
            sb.AppendLine(base.Mostrar());
            
            return sb.ToString();
        }
        public override bool Validar()
        {
            return this.Edad > 17;
            
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
