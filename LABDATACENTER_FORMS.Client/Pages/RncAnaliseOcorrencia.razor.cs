using LABDATACENTER_FORMS.Models;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using System.Globalization;

namespace LABDATACENTER_FORMS.Client.Pages
{
    public partial class RncAnaliseOcorrencia
    {
        private FormRelatorioNaoConformidade formRelatorioNaoConformidade = new();

        public CultureInfo _pt = CultureInfo.GetCultureInfo("pt-PT");

        bool success;

        private MudForm form;

        private bool showConfirmationDialog = false;

        private bool _openPopover = false;
        private void ToggleOpen() => _openPopover = !_openPopover;

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
