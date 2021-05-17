using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private short edad;
        private string nombre;

        protected Persona(string nombre, short edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public short Edad
        {
            get
            {
               return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        
        protected virtual string Mostrar()//No deberá imprimir información sin cargar
             //sin empleado no tiene dni debe devolver -1
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("EMPLEADOS:"); 
            sb.AppendLine("----------");
            sb.AppendLine(string.Format("Nombre : {0}", this.Nombre));
            sb.AppendLine(string.Format("Edad : {0}", this.Edad));
            return sb.ToString();
        }

        public abstract bool Validar();




    }
}
