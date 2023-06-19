namespace CursoPadroesProjeto.RequisicoesWeb
{
    public class ProcessadorRequisicaoXML : ProcessadorRequisicao
    {
        public ProcessadorRequisicaoXML() : base()
        {
        }

        public ProcessadorRequisicaoXML(ProcessadorRequisicao proximo) : base(proximo)
        {
        }

        protected override string GetDelimitador()
        {
            return ";";
        }
    }
}
