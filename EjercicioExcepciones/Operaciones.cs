using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones
{
    public class Operaciones
    {

        public double numero1 {  get; set; }
        public double numero2 { get; set; }

        public double suma(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public double resta(double numero1, double numero2) 
        {
            return (numero1 - numero2);
        }


        public double division(double numero1, double numero2) 
        {
            return numero1 / numero2;
        
        }

        public double multiplicacion(double numero1, double numero2) 
        {
        
            return numero1 * numero2;
        }

    }
}
