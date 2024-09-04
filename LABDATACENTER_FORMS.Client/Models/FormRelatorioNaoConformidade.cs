namespace LABDATACENTER_FORMS.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    public partial class FormRelatorioNaoConformidade
    {
        public int Id { get; set; }
        public int NumeroFuncionario { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
        public string TipoOcorrencia { get; set; }
        public string DescricaoOcorrencia { get; set; }
        public string OrigemOcorrencia { get; set; }
        public string RequerAcao { get; set; }
        public string ResponsavelAnalise { get; set; }
        public string DescricaoTratamento { get; set; }
        public string ResponsavelTratamento { get; set; }
        public DateTime? PrazoTratamento { get; set; }
        public string TratamentoObservacoes { get; set; }
        public string ResponsavelVerificacaoTratamento { get; set; }
        public DateTime? DataVerificacaoImplementacao { get; set; }
        public string DescricaoAcaoCorretiva { get; set; }
        public string ResponsavelAcaoCorretiva { get; set; }
        public DateTime? PrazoAcaoCorretiva { get; set; }
        public string NecessidadeRevisao { get; set; }
        public string NecessidadeRevisaoObservacoes { get; set; }
        public string AcaoCorretivaDefinidoPor {  get; set; }
        public string AcaoCorretivaAprovadoPor { get; set; }
        public DateTime? DataAcaoCorretiva { get; set; }
        public string AcompanhamentoObservacoes { get; set; }
        public string AcompanhamentoVerificadoPor { get; set; }
        public DateTime? DataAcompanhamento { get; set; }
        public string EficaciaAcao { get; set; }
        public string NovaAcaoRnc { get; set; }
        public string AvaliacaoEficaciaObservacoes { get; set; }
        public string AvaliacaoEficaciaAvaliadoPor { get; set; }
        public DateTime? AvaliacaoEficaciaData { get; set; }
        public DateTime? AvaliacaoEficaciaDataFinal { get; set; }

        public FormRelatorioNaoConformidade()
        {
            Date = DateTime.Now; // Default to current date
        }

        public FormRelatorioNaoConformidade(int id, int numeroFuncionario, DateTime date, DateOnly dataReclamacao, string tipoOcorrencia, 
            string descricaoOcorrencia, string origemOcorrencia, string requerAcao, string responsavelAnalise, string descricaoTratamento,
            string responsavelTratamento, DateTime? prazoTratamento, string tratamentoObservacoes, string responsavelVerificacaoTratamento, 
            DateTime? dataVerificacaoImplementacao, string descricaoAcaoCorretiva, string responsavelAcaoCorretiva, 
            DateTime? prazoAcaoCorretiva, string necessidadeRevisao, string necessidadeRevisaoObservacoes, string acaoCorretivaDefinidoPor,
            string acaoCorretivaAprovadoPor, DateTime? dataAcaoCorretiva, string acompanhamentoObservacoes, string acompanhamentoVerificadoPor,
            DateTime? dataAcompanhamento, string eficaciaAcao, string novaAcaoRnc, string avaliacaoEficaciaObservacoes, 
            string avaliacaoEficaciaAvaliadoPor, DateTime? avaliacaoEficaciaData, DateTime? avaliacaoEficaciaDataFinal)
        {
            Id = id;
            NumeroFuncionario = numeroFuncionario;
            Date = date;
            TipoOcorrencia = tipoOcorrencia;
            DescricaoOcorrencia = descricaoOcorrencia;
            OrigemOcorrencia = origemOcorrencia;
            RequerAcao = requerAcao;
            ResponsavelAnalise = responsavelAnalise;
            DescricaoTratamento = descricaoTratamento;
            ResponsavelTratamento = responsavelTratamento;
            PrazoTratamento = prazoTratamento;
            TratamentoObservacoes = tratamentoObservacoes;
            ResponsavelVerificacaoTratamento = responsavelVerificacaoTratamento;
            DataVerificacaoImplementacao = dataVerificacaoImplementacao;
            DescricaoAcaoCorretiva = descricaoAcaoCorretiva;
            ResponsavelAcaoCorretiva = responsavelAcaoCorretiva;
            PrazoAcaoCorretiva = prazoAcaoCorretiva;
            NecessidadeRevisao = necessidadeRevisao;
            NecessidadeRevisaoObservacoes = necessidadeRevisaoObservacoes;
            AcaoCorretivaDefinidoPor = acaoCorretivaDefinidoPor;
            AcaoCorretivaAprovadoPor = acaoCorretivaAprovadoPor;
            DataAcaoCorretiva = dataAcaoCorretiva;
            AcompanhamentoObservacoes = acompanhamentoObservacoes;
            AcompanhamentoVerificadoPor = acompanhamentoVerificadoPor;
            DataAcompanhamento = dataAcompanhamento;
            EficaciaAcao = eficaciaAcao;
            NovaAcaoRnc = novaAcaoRnc;
            AvaliacaoEficaciaObservacoes = avaliacaoEficaciaObservacoes;
            AvaliacaoEficaciaAvaliadoPor = avaliacaoEficaciaAvaliadoPor;
            AvaliacaoEficaciaData = avaliacaoEficaciaData;
            AvaliacaoEficaciaDataFinal = avaliacaoEficaciaDataFinal;
        }

    }


}
