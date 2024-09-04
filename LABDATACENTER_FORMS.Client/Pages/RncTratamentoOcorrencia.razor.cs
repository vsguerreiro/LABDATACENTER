using LABDATACENTER_FORMS.Models;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using System.Globalization;

namespace LABDATACENTER_FORMS.Client.Pages
{
    public partial class RncTratamentoOcorrencia
    {
        private FormRelatorioNaoConformidade formRelatorioNaoConformidade = new();

        public CultureInfo _pt = CultureInfo.GetCultureInfo("pt-PT");

        bool success;

        private MudForm form;

        private List<FormRelatorioNaoConformidade> formDataList = new();

        private bool showConfirmationDialog = false;

        private void AddToList()
        {
            formDataList.Add(new FormRelatorioNaoConformidade
            {
                DescricaoTratamento = formRelatorioNaoConformidade.DescricaoTratamento,
                ResponsavelTratamento = formRelatorioNaoConformidade.ResponsavelTratamento,
                PrazoTratamento = formRelatorioNaoConformidade.PrazoTratamento
            });

            // Clear form data for next entry
            formRelatorioNaoConformidade = new();
        }

        private async Task HandleSubmit()
        {
            await form.Validate();
            if (!form.IsValid)
            {
                Snackbar.Add("Por favor, corrija os erros assinalados no formulário", MudBlazor.Severity.Error);
                return;
            }

        }
    }
}
