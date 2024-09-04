using LABDATACENTER_FORMS.Models;

namespace LABDATACENTER_FORMS.Services
{
    public class FormRelatorioNaoConformidadeService
    {
        public List<FormRelatorioNaoConformidade> TableData { get; private set; } = new List<FormRelatorioNaoConformidade>();


        public void AddFormRelatorioNaoConformidade(FormRelatorioNaoConformidade formRelatorioNaoConformidade)
        {
            TableData.Add(formRelatorioNaoConformidade);
        }
    }

}
