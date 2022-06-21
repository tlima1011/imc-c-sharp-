using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC {
    class Imc {

        public static double calcularImc(double peso, double altura) {
            return peso / (altura * altura); 
        }
        public static string informarImc(double indice) {
            
            string resultado = ""; 
            
            if (indice <= 18.5) {
                resultado = "Magreza";
            }
            else if (indice <= 24.9) {
                resultado = "Normal";
            }
            else if (indice <= 29.9) {
                resultado = "Sobrepeso I";
            }
            else if (indice <= 39.9) {
                resultado = "Obesidade II";
            }
            else {
                resultado = "Obesidade III";
            }
            return resultado; 
        }
    }
}
