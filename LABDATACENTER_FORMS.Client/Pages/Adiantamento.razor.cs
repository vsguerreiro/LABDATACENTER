using LABDATACENTER_FORMS.Models;
using MudBlazor;
using System.Globalization;

namespace LABDATACENTER_FORMS.Client.Pages
{
    public partial class Adiantamento
    {
        private FormData formData = new();

        public CultureInfo _pt = CultureInfo.GetCultureInfo("pt-PT");

        bool success;

        private MudForm form;

        private bool showConfirmationDialog = false;

        protected override void OnInitialized()
        {
            formData.NumeroFuncionario = "9999";
            formData.Formulario = "Adiantamento";
        }

        private bool IsFormFilled()
        {
            return success && !string.IsNullOrEmpty(formData.ValorDoAdiantamento.ToString()) &&
               !string.IsNullOrEmpty(formData.Justificacao) && formData.DataPretendida.HasValue &&
               !string.IsNullOrEmpty(formData.CentroDeCustoOuPep);
        }

        private async Task openConfirmationDialog()
        {
            await form.Validate();
            if (!form.IsValid)
            {
                Snackbar.Add("Por favor, corrija os erros assinalados no formulário", MudBlazor.Severity.Error);
                return;
            }

            showConfirmationDialog = true;
        }

        private async Task HandleSubmit()
        {
            await form.Validate();
            //if (!form.IsValid)
            //{
            //    Snackbar.Add("Por favor, corrija os erros assinalados no formulário", MudBlazor.Severity.Error);
            //    return;
            //}

            formDataService.AddFormData(formData);
            Snackbar.Add("Formulário submetido com sucesso", MudBlazor.Severity.Success);
            formData = new FormData(); // Reset the form data
            formData.DataPretendida = (DateTime.Today);
            formData.NumeroFuncionario = "9999";
            formData.Formulario = "Adiantamento";
            showConfirmationDialog = false;
        }
    }
}
