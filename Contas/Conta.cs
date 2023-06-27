using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.Contas
{
    public class Conta : ContaBancaria
    {
        public DateTime DataAbertura { get; set; }

        public Conta(double saldo) : base(saldo) 
        {
            DataAbertura = DateTime.Now;
        }

        public Conta(double saldo, DateTime dataAbertura) : base(saldo)
        {
            DataAbertura = dataAbertura;
        }

        public new string ToString()
        {
            return $"{Saldo}, {DataAbertura.ToString()}";
        }
    }
}
