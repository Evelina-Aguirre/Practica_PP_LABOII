using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bar
    {
        private List<Empleado> empleados;
        private List<Gente> gente;
        private static Bar singleton;


        public List<Empleado> Empleados
        {
            get
            {
                return this.empleados;
            }
        }

        public List<Gente> Gente
        {
            get
            {
                return this.gente;
            }
        }

        private Bar()
        {
            empleados = new List<Empleado>();
            gente = new List<Gente>();
        }

        public static Bar GetBar()
        {
            if (Bar.singleton is null)
            {
                Bar.singleton = new Bar();
            }

            return Bar.singleton;
        }

        public static bool operator +(Bar bar, Empleado empleado)
        {
            if (!(bar is null) && !(empleado is null))
            {
                if (bar.empleados.Count == 0 && empleado.Validar())
                {
                    bar.empleados.Add(empleado);
                    return true;
                }
                else
                {
                    //Si tengo uno o más empleados cargados en la lista los comparo y si el emp a agregar es dif de y tienen nombre
                    //..y es mayor de 21 años lo agrego 
                    //poorq soy una empleadora pudiente q contrata a cualquiera de copada q soy.
                    foreach (Empleado item in bar.empleados)
                    {

                        if (item != empleado && empleado.Validar())
                        {
                            bar.empleados.Add(empleado);
                            return true;
                        }
                    }
                }
                
            }
            return false;

        }
        public static bool operator +(Bar bar, Gente gente)
        {
            if (!(bar is null) && !(gente is null))
            {
                if (gente.Validar() && bar.gente.Count < (bar.empleados.Count * 10))
                {
                    bar.gente.Add(gente);
                    return true;


                }
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"EMPLEADOS :");
            foreach (Empleado item in this.empleados)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine($"--------------------");

            sb.AppendLine($"GENTE :");
            foreach (Gente item in this.gente)
            {
                sb.AppendLine(item.ToString());    
            }

            sb.AppendLine($"--------------------");
            
            return sb.ToString();
        }
    }
}
