using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caballo : Animal
    {
        private bool corredor;

        public Caballo(string nombre, int kilosAlimentos, bool corredor) : base(nombre, kilosAlimentos)
        {
            this.corredor = corredor;
        }
        public override bool ComeBalanceado
        {
            get
            {
                return false;
            }
        }

        public override bool ComePasto
        {
            get
            {
                return true;
            }
        }


        public override string Datos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Datos());
            if(corredor)
            {
                sb.AppendLine(String.Format("Es de Carrera : SI"));
            }
            else
            {
                sb.AppendLine(String.Format("Es de Carrera : NO"));
            }

            return sb.ToString();
        }

    }
}
