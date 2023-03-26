using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eajuste_salarial
{
    public class calculo
    {
        public double CalculaSalario(double Salario)
        {
            double NovoSalario = 0;

            if (Salario >= 1700){
                NovoSalario = (Salario + 200);
            }else{
                NovoSalario = (Salario + 300);
            }

            return NovoSalario;

        }

    }
}