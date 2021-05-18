using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Animal
    {

        private int kilosAlimento;
        private string nombre;

        public abstract bool ComeBalanceado
        {
            get;
        }

        public abstract bool ComePasto
        {
            get;
        }

        public int KilosAlimento
        {
            get
            {
                return this.kilosAlimento; 
            }
        }


        public Animal(string nombre, int volumen)
        {
            this.nombre = nombre;
            this.kilosAlimento = volumen;
        }

        public virtual string Datos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("{0} come {1}", this.nombre, this.kilosAlimento));
            if (this.ComeBalanceado)
            {
                sb.AppendLine("Come balanceado SI");
            }
            else
            {
                sb.AppendLine("Come balanceado NO");
            }

            if (this.ComePasto)
            {
                sb.AppendLine("Come pasto SI");
            }
            else
            {
                sb.AppendLine("Come pasto NO");
            }

            return sb.ToString();
        }


    }

}
