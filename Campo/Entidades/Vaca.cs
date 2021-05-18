using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vaca :Animal
    {
        public enum Clasificacion
        {
            Lechera,
                Normando,
                Pasiega,
                HolandoArgentina,
                Tudaca
        }

        private Clasificacion clasificacion;

        public override bool ComeBalanceado
        {
            get
            {
                return true;
            }
        }

        public override bool ComePasto
        {
            get
            {
                return true;
            }
        }

        public Vaca(string nombre, int kilosAlimentos) : base (nombre, kilosAlimentos)
        {

        }

        public Vaca(string nombre, int kilosAlimentos, Clasificacion clasificacion) : this (nombre, kilosAlimentos)
        {
            this.clasificacion = clasificacion;
        }


        public override string Datos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Datos());
            sb.AppendLine(String.Format($"Clasificada como : {this.clasificacion}"));

            return sb.ToString();
        }
    }
}
