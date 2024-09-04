using LABDATACENTER_FORMS.Models;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using System.Globalization;

namespace LABDATACENTER_FORMS.Client.Pages
{
    public partial class AcaoCorretiva
    {
        private FormReclamacoesData formReclamacoesData = new();

        public CultureInfo _pt = CultureInfo.GetCultureInfo("pt-PT");

        private MudForm form;

        private List<FormReclamacoesData> formDataList = new();

        private async Task HandleSubmit()
        {
            await form.Validate();
            if (!form.IsValid)
            {
                Snackbar.Add("Por favor, corrija os erros assinalados no formulário", MudBlazor.Severity.Error);
                return;
            }

            //formReclamacoesDataService.AddFormReclamacoesData(formReclamacoesData);
            //Snackbar.Add("Formulário submetido com sucesso", MudBlazor.Severity.Success);
            //formReclamacoesData = new FormReclamacoesData(); // Reset the form data
        }



    }
}
