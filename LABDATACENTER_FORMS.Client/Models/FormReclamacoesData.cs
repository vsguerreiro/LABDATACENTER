namespace LABDATACENTER_FORMS.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class FormReclamacoesData
    {
        public int Id { get; set; }
        public int NumeroFuncionario { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
        public string TipoOcorrencia { get; set; }
        public string Reclamante { get; set; }
        public string DescricaoReclamante { get; set; }
        public string NomeCliente { get; set; }
        public string MotivoTipo { get; set; }
        public string Motivo { get; set; }
        public string DescricaoOcorrencia { get; set; }
        public string OrigemReclamacao { get; set; }
        public DateOnly? DataReclamacao { get; set; }
        public string RececaoReclamante { get; set; }
        public string EmailReclamante { get; set; }
        public string ResponsavelIdentificacao { get; set; }
        public string CcResponsavelIdentificacao { get; set; }
        public string IdentificacaoCausas { get; set; }
        public string IncidenciasProcesso { get; set; }
        public string DecisaoReclamacao { get; set; }
        public string DecisaoJustificacao { get; set; }
        public string DecisaoEmail { get; set; }
        public string RequerAcao { get; set; }
        public string ResponsavelAnalise { get; set; }
        public string CcResponsavelAnalise { get; set; }
        public string DescricaoTratamento { get; set; }
        public string ResponsavelTratamento { get; set; }
        public DateTime? PrazoTratamento { get; set; }
        public DateTime? DataFechoTratamento { get; set; }
        public string TratamentoObservacoes { get; set; }
        public string ResponsavelVerificacaoTratamento { get; set; }
        public DateTime? DataVerificacaoImplementacao { get; set; }
        public string NecessidadeRevisao { get; set; }
        public string NecessidadeRevisaoObservacoes { get; set; }
        public string AcaoCorretivaDefinidoPor { get; set; }
        public DateTime? DataAcaoCorretiva { get; set; }
        public string CcAcaoCorretiva { get; set; }
        public string AcaoCorretivaAprovado { get; set; }
        public DateTime? DataAcaoCorretivaAprovado { get; set; }
        public string CcAcaoCorretivaAprovado { get; set; }
        public string AcompanhamentoObservacoes { get; set; }
        public string AcompanhamentoResponsavel { get; set; }
        public DateTime? PrazoAcompanhamento { get; set; }
        public string CcAcompanhamento { get; set; }
        public string AcaoEficacia { get; set; }
        public string NovaAcao { get; set; }
        public string AcaoEficaciaObservacoes { get; set; }
        public string AvaliacaoEficaciaResponsavel { get; set; }
        public DateTime? DataAvaliacaoEficacia { get; set; }
        public DateTime? DataFechoFinal { get; set; }
        public string CcAvaliacaoEficacia { get; set; }

        public FormReclamacoesData() 
    {
            Date = DateTime.Now; // Default to current date
    }

        public FormReclamacoesData(int id, int numeroFuncionario, DateTime date, DateOnly dataReclamacao, string tipoOcorrencia,
            string reclamante, string descricaoReclamante, string nomeCliente, string motivoTipo, string motivo, string descricaoOcorrencia,
            string origemReclamacao, string rececaoReclamante, string emailReclamante, string responsavelIdentificacao, string ccResponsavelIdentificacao,
            string identificacaoCausas, string incidenciasProcesso, string decisaoReclamacao, string decisaoJustificacao, string decisaoEmail,
            string requerAcao, string responsavelAnalise, string ccresponsavelAnalise, string descricaoTratamento, string responsavelTratamento, 
            DateTime? prazoTratamento, DateTime? dataFechoTratamento, string tratamentoObservacoes, string responsavelVerificacaoTratamento, 
            DateTime? dataVerificacaoImplementacao, string necessidadeRevisao, string necessidadeRevisaoObservacoes,
            string acaoCorretivaDefinidoPor, DateTime? dataAcaoCorretiva, string ccAcaoCorretiva, string acaoCorretivaAprovado,
            DateTime? dataAcaoCorretivaAprovado, string ccAcaoCorretivaAprovado, string acompanhamentoObservacoes, string acompanhamentoResponsavel, 
            DateTime? prazoAcompanhamento, string ccAcompanhamento, string acaoEficacia, string novaAcao, string acaoEficaciaObservacoes, 
            string avaliacaoEficaciaResponsavel, DateTime? dataAvaliacaoEficacia, DateTime? dataFechoFinal, string ccAvaliacaoEficacia)
        {
            Id = id;
            NumeroFuncionario = numeroFuncionario;
            Date = date;
            DataReclamacao = dataReclamacao;
            TipoOcorrencia = tipoOcorrencia;
            Reclamante = reclamante;
            DescricaoReclamante = descricaoReclamante;
            NomeCliente = nomeCliente;
            MotivoTipo = motivoTipo;
            Motivo = motivo;
            DescricaoOcorrencia = descricaoOcorrencia;
            OrigemReclamacao = origemReclamacao;
            RececaoReclamante = rececaoReclamante;
            EmailReclamante = emailReclamante;
            ResponsavelIdentificacao = responsavelIdentificacao;
            CcResponsavelIdentificacao = ccResponsavelIdentificacao;
            IdentificacaoCausas = identificacaoCausas;
            IncidenciasProcesso = incidenciasProcesso;
            DecisaoReclamacao = decisaoReclamacao;
            DecisaoJustificacao = decisaoJustificacao;
            DecisaoEmail = decisaoEmail;
            RequerAcao = requerAcao;
            ResponsavelAnalise = responsavelAnalise;
            CcResponsavelAnalise = ccresponsavelAnalise;
            DescricaoTratamento = descricaoTratamento;
            ResponsavelTratamento = responsavelTratamento;
            PrazoTratamento = prazoTratamento;
            DataFechoTratamento = dataFechoTratamento;
            TratamentoObservacoes = tratamentoObservacoes;
            ResponsavelVerificacaoTratamento = responsavelVerificacaoTratamento;
            DataVerificacaoImplementacao = dataVerificacaoImplementacao;
            NecessidadeRevisao = necessidadeRevisao;
            NecessidadeRevisao = necessidadeRevisao;
            NecessidadeRevisaoObservacoes = necessidadeRevisaoObservacoes;
            AcaoCorretivaDefinidoPor = acaoCorretivaDefinidoPor;
            DataAcaoCorretiva = dataAcaoCorretiva;
            CcAcaoCorretiva = ccAcaoCorretiva;
            AcaoCorretivaAprovado = acaoCorretivaAprovado;
            DataAcaoCorretivaAprovado = dataAcaoCorretivaAprovado;
            CcAcaoCorretivaAprovado = ccAcaoCorretivaAprovado;
            AcompanhamentoObservacoes = acompanhamentoObservacoes;
            AcompanhamentoResponsavel = acompanhamentoResponsavel;
            PrazoAcompanhamento = prazoAcompanhamento;
            CcAcompanhamento = ccAcompanhamento;
            AcaoEficacia = acaoEficacia;
            NovaAcao = novaAcao;
            AcaoEficaciaObservacoes = acaoEficaciaObservacoes;
            AvaliacaoEficaciaResponsavel = avaliacaoEficaciaResponsavel;
            DataAvaliacaoEficacia = dataAvaliacaoEficacia;
            DataFechoFinal = dataFechoFinal;
            CcAvaliacaoEficacia = ccAvaliacaoEficacia;
        }
    }
}
