using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCorto3
{
    class proyecto : Comparador
    {
        public int prioridad;
        public string departamento;
        public string nombre;
        public double monto;


        public proyecto()
        {
            prioridad = 0;
            departamento = "";
            nombre = "";
            monto = 0;
        }

        public proyecto(int numero, string dep, string name, double dinero)
        {
            prioridad = numero;
            departamento = dep;
            nombre = name;
            monto = dinero;
        }
        //bool Comparador.igualQue(object op2)
        //{
        //    throw new NotImplementedException();
        //}

        //bool Comparador.menorQue(object op2)
        //{
        //    throw new NotImplementedException();
        //}

        bool Comparador.menorQue(object op2)
        {
            bool bandera = false;
            proyecto p2 = (proyecto)op2;
            if (prioridad <= p2.prioridad)
            {
                if (departamento == "Chiquimula" || departamento == "Baja Verapaz" || departamento == "Alta Verapaz" || departamento == "Zacapa" || departamento == "El Progreso" || departamento == "Guatemala")
                {
                    if (nombre.CompareTo(p2.nombre) < 0 || nombre.CompareTo(p2.nombre) > 0)
                    {
                        bandera = true;
                    }
                    else
                    {
                        bandera = false;
                    }
                }
                else
                {
                    bandera = false;
                }
            }
            else
            {
                bandera = false;
            }

            return bandera;
        }

        bool Comparador.mayorQue(object op2)
        {
            bool bandera = false;
            proyecto p2 = (proyecto)op2;
            if (prioridad <= p2.prioridad)
            {
                if (departamento == "Chiquimula" || departamento == "Baja Verapaz" || departamento == "Alta Verapaz" || departamento == "Zacapa" || departamento == "El Progreso" || departamento == "Guatemala")
                {
                    if (nombre.CompareTo(p2.nombre)  > 0 || nombre.CompareTo(p2.nombre) < 0)
                    {
                        bandera = true;
                    }
                    else
                    {
                        bandera = false;
                    }
                }
                else
                {
                    bandera = false;
                }
            }
            else
            {
                bandera = false;
            }

            return bandera;
        }

        //bool Comparador.mayorIgualQue(object op2)
        //{
        //    throw new NotImplementedException();
        //}

        public override string ToString()
        {
            return "(" + departamento + " - " + nombre + " - " + monto + " " + prioridad + ")";
        }
    }


}
