using CursoPadroesProjeto.EstadosDeUmOrcamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }

        public EstadoDeUmOrcamento EstadoAtual { get; set; }
        public MetaEstadoDeUmOrcamento MetaEstadoAtual { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
            this.MetaEstadoAtual = new DescontoAAplicar();
        }

        public void adicionaItem(Item item)
        {
            this.Itens.Add(item);
        }

        public void AplicaDescontoExtra()
        {
            MetaEstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
