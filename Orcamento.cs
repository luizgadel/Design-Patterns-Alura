﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void adicionaItem(Item item)
        {
            this.Itens.Add(item);
        }
    }
}
