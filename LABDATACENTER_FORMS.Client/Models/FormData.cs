namespace LABDATACENTER_FORMS.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class FormData
    {
        public int Id { get; set; }
        public string Formulario { get; set; }
        public string NumeroFuncionario { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
        public string Fornecedor { get; set; }        
        public string NifFornecedor { get; set; }
        public string TipoRequisicao { get; set; }
        public string? DescricaoMaterial { get; set; }
        public string LocalEntrega { get; set; }
        public decimal? PrecoSemIva { get; set; }
        public decimal? PortesSemIva { get; set; }
        public decimal? ValorDoAdiantamento { get; set; }
        public string Justificacao { get; set; }
        public DateTime? DataPretendida { get; set; }
        public string CentroDeCustoOuPep { get; set; }
        public string Adiantamento { get; set; }
        public string AdiantamentoDescricao { get; set; }
        public string NumeroOrdemInvestimento { get; set; }
        public string CodigoServico { get; set; }
        public DateTime? DataLevantamento { get; set; }
        public DateTime? DataEntrega { get; set; }
        public string ModeloViatura { get; set; }
        public string NomeCondutores { get; set; }
        public string CcCondutores { get; set; }
        public string ContatoCondutores { get; set; }
        public string HotelPreferencia { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string Observacoes { get; set; }
        public string MeioTransporte { get; set; }

        // Default constructor
        public FormData()
        {
            // Initialize properties with default values if necessary
            Date = DateTime.Now; // Default to current date
            // Other properties can be initialized as needed
        }

        // Parameterized constructor
        public FormData(int id, string formulario,string numeroFuncionario, DateTime date, string fornecedor,
                        string nifFornecedor, string tipoRequisicao, string descricaoMaterial,
                        string localEntrega, decimal? precoSemIva, decimal? portesSemIva, 
                        decimal? valorDoAdiantamento, string justificacao, DateTime dataPretendida, 
                        string centroDeCustoOuPep, string adiantamento, string adiantamentoDescricao, string numeroOrdemInvestimento,
                        string codigoServico, DateTime dataLevantamento, DateTime dataEntrega, 
                        string modeloViatura, string nomeCondutores, string ccCondutores, 
                        string contatoCondutores, string hotelPreferencia, DateTime dataInicio, 
                        DateTime dataFim, string observacoes, string meioTransporte)
        {
            Id = id;
            Formulario = formulario;
            NumeroFuncionario = numeroFuncionario;
            Date = DateTime.Today;
            Fornecedor = fornecedor;
            NifFornecedor = nifFornecedor;
            TipoRequisicao = tipoRequisicao;
            DescricaoMaterial = descricaoMaterial;
            LocalEntrega = localEntrega;
            PrecoSemIva = precoSemIva;
            PortesSemIva = portesSemIva;
            ValorDoAdiantamento = valorDoAdiantamento;
            Justificacao = justificacao;
            DataPretendida = dataPretendida;
            CentroDeCustoOuPep = centroDeCustoOuPep;
            Adiantamento = adiantamento;
            AdiantamentoDescricao = adiantamentoDescricao;
            NumeroOrdemInvestimento = numeroOrdemInvestimento;
            CodigoServico = codigoServico;
            DataLevantamento = dataLevantamento;
            DataEntrega = dataEntrega;
            ModeloViatura = modeloViatura;
            NomeCondutores = nomeCondutores;
            CcCondutores = ccCondutores;
            ContatoCondutores = contatoCondutores;
            HotelPreferencia = hotelPreferencia;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Observacoes = observacoes;
            MeioTransporte = meioTransporte;
        }
    }
}