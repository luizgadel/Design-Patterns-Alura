using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto
{
    public class ContaBancaria
    {
        public double Saldo { get; private set; }

        public ContaBancaria(double saldo) 
        {
            this.Saldo = saldo;
        }

        public void adicionaSaldo(double adicional)
        {
            this.Saldo += adicional;
        }
    }
}
