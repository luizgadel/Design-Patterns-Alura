namespace CursoPadroesProjeto.RequisicoesWeb
{
    public class ProcessadorRequisicaoPorcento : ProcessadorRequisicao
    {
        public ProcessadorRequisicaoPorcento() : base()
        {
        }

        public ProcessadorRequisicaoPorcento(ProcessadorRequisicao proximo) : base(proximo)
        {
        }

        protected override string GetDelimitador()
        {
            return "%";
        }
    }
}