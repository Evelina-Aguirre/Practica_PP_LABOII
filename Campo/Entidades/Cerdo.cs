using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Cerdo : Animal
    {
        public Cerdo(string nombre, int kilosAlimentos) : base(nombre, kilosAlimentos)
        {

        }
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
                return false;
            }
        }
    }

}
