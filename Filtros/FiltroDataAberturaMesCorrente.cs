using CursoPadroesProjeto.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.Filtros
{
    class FiltroDataAberturaMesCorrente : Filtro
    {
        public FiltroDataAberturaMesCorrente() : base() { }

        public FiltroDataAberturaMesCorrente(Filtro outroFiltro) : base(outroFiltro) { }

        public override bool Filtra(Conta conta)
        {
            return (conta.DataAbertura.Month == DateTime.Now.Month) || AplicaOutroFiltro(conta);
        }
    }
}
