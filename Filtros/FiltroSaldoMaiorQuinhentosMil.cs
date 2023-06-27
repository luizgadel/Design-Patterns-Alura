using CursoPadroesProjeto.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.Filtros
{
    public class FiltroSaldoMaiorQuinhentosMil : Filtro
    {
        public FiltroSaldoMaiorQuinhentosMil() : base() { }

        public FiltroSaldoMaiorQuinhentosMil(Filtro outroFiltro) : base(outroFiltro) { }
        
        public override bool Filtra(Conta conta)
        {
            return (conta.Saldo > 500_000) || AplicaOutroFiltro(conta); 
        }
    }
}
