using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoSalario.Entities
{
    class Impostos
    {
        public double Salario { get; set; }


        public Impostos(double salario)
        {
            Salario = salario;
        }

        public double CalcularFgts(double salario)
        {
            double fgts = salario * 0.08;
            return fgts;
        }

        public double CalcularVale(double salario)
        {
            double vale = salario * 0.06;
            return vale;
        }

        public double CalcularInss(double salario)
        {
            double inss = salario * 0.08;
            return inss;
        }

        public double CalcularIr(double salario)
        {
            double ir = salario * 0.2;
            if (salario <= 1900)
            {
                return 0;
            }
            else
            {
                return ir;
            }

        }

        public double CalcularSalario(double salario)
        {
            double inss = salario * 0.08;
            double vale = salario * 0.06;
            if (salario <= 1900)
            {
                salario = salario - (inss + vale);
                return salario;
            }
            else
            {
                salario = salario - (vale + inss + salario * 0.2);
                return salario;
            }
        }
    }
}
