using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
     
    public class Rosal : Planta
    {
        public enum Color
        {
            Roja,
            Blanca,
            Amarilla,
            Rosa,
            Azul
        }

        private Color florColor;  


        public Rosal(string nombre, int tamanio) :base(nombre, tamanio)
        {

        }

        public Rosal(string nombre, int tamanio, Color flor) : this(nombre, tamanio)
        {
            this.florColor = flor;
        }



        public override bool TieneFlores
        {

            get
            {
                return true;
            }
        }

        public override bool TieneFruto
        {

            get
            {
                return false;
            }
        }

        public override string ResumeDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ResumeDeDatos());
            sb.AppendLine($"Flores de Color : {this.florColor}");
            return sb.ToString();
        }




    }
}

