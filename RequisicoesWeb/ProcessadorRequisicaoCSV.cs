namespace CursoPadroesProjeto.RequisicoesWeb
{
    public class ProcessadorRequisicaoCSV : ProcessadorRequisicao
    {
        public ProcessadorRequisicaoCSV() : base()
        {
        }

        public ProcessadorRequisicaoCSV(ProcessadorRequisicao proximo) : base(proximo)
        {
        }

        protected override string GetDelimitador()
        {
            return ",";
        }
    }
}
