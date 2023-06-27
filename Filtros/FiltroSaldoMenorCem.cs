using CursoPadroesProjeto.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.Filtros
{
    public class FiltroSaldoMenorCem : Filtro
    {
        public FiltroSaldoMenorCem() : base() { }

        public FiltroSaldoMenorCem(Filtro outroFiltro) : base(outroFiltro) { }

        public override bool Filtra(Conta conta)
        {
            return (conta.Saldo < 100) || AplicaOutroFiltro(conta);
        }
    }
}
