using LABDATACENTER_FORMS.Models;
using MudBlazor;
using System.Globalization;

namespace LABDATACENTER_FORMS.Client.Pages
{
    public partial class MarcacaoHotel
    {
        private FormData formData = new FormData();

        //private List<FormData> tableData = new List<FormData>();

        public CultureInfo _pt = CultureInfo.GetCultureInfo("pt-PT");

        bool success;

        private MudForm form;

        private bool showConfirmationDialog = false;

        private DateRange _dateRange = new DateRange(DateTime.Now.Date, DateTime.Now.AddDays(5).Date);

        protected override void OnInitialized()
        {
            //formData.DataPretendida = DateOnly.FromDateTime(DateTime.Today);
            formData.NumeroFuncionario = "9999";
            formData.Formulario = "MarcacaoHotel";
        }

        private bool IsFormFilled()
        {
            return success && !string.IsNullOrEmpty(formData.LocalEntrega) &&
               !string.IsNullOrEmpty(formData.HotelPreferencia) && !string.IsNullOrEmpty(formData.NomeCondutores) &&
               !string.IsNullOrEmpty(formData.NumeroFuncionario) && !string.IsNullOrEmpty(formData.CentroDeCustoOuPep);
        }

        private async void openConfirmationDialog()
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
            if (!form.IsValid)
            {
                Snackbar.Add("Por favor, corrija os erros assinalados no formulário", MudBlazor.Severity.Error);
                return;
            }

            formData.DataInicio = _dateRange.Start.GetValueOrDefault().Date;
            formData.DataFim = _dateRange.End.GetValueOrDefault().Date;

            formDataService.AddFormData(formData);
            Snackbar.Add("Formulário submetido com sucesso", MudBlazor.Severity.Success);
            formData = new FormData(); // Reset the form data
            showConfirmationDialog = false;
        }
    }
}
