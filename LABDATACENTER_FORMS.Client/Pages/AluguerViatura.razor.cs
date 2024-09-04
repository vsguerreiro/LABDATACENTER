using LABDATACENTER_FORMS.Models;
using MudBlazor;
using System.Globalization;

namespace LABDATACENTER_FORMS.Client.Pages
{
    public partial class AluguerViatura
    {
        private FormData formData = new();

        //private List<FormData> tableData = new List<FormData>();

        public CultureInfo _pt = CultureInfo.GetCultureInfo("pt-PT");

        bool success;

        private MudForm form;

        private bool showConfirmationDialog = false;

        DateTime? _pickupDate;
        TimeSpan? _pickupTime;
        DateTime? _returnDate;
        TimeSpan? _returnTime;

        //private DateRange _dateRange = new (DateTime.Now.Date, DateTime.Now.AddDays(5).Date);
        //private TimeSpan _startTime = new (0, 0, 0);
        //private TimeSpan _endTime = new (23, 59, 59);

        //private DateTime DataLevantamento => _dateRange.Start.GetValueOrDefault().Date + _startTime;
        //private DateTime DataEntrega => _dateRange.End.GetValueOrDefault().Date + _endTime;

        private bool IsFormFilled()
        {
            return success &&
                   !string.IsNullOrEmpty(formData.LocalEntrega) &&
                   _pickupDate.HasValue &&
                   _pickupTime.HasValue &&
                   _returnDate.HasValue &&
                   _returnTime.HasValue &&
                   !string.IsNullOrEmpty(formData.ModeloViatura) &&
                   //!string.IsNullOrEmpty(formData.NomeCondutores) &&
                   //!string.IsNullOrEmpty(formData.CcCondutores) &&
                   //!string.IsNullOrEmpty(formData.ContatoCondutores) &&
                   //!string.IsNullOrEmpty(formData.Justificacao) &&
                   !string.IsNullOrEmpty(formData.CentroDeCustoOuPep);
        }

        protected override void OnInitialized()
        {
            formData.NumeroFuncionario = "9999";
            formData.Formulario = "AluguerViatura";
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
            //await form.Validate();
            //if (!form.IsValid)
            //{
            //    Snackbar.Add("Por favor, corrija os erros assinalados no formulário", MudBlazor.Severity.Error);
            //    return;
            //}

            //formData.DataLevantamento = _dateRange.Start.GetValueOrDefault().Date + _startTime;
            //formData.DataEntrega = _dateRange.End.GetValueOrDefault().Date + _endTime;

            formData.DataLevantamento = _pickupDate.Value.Date + _pickupTime.Value;
            formData.DataEntrega = _returnDate.Value.Date + _returnTime.Value;

            formData.NumeroFuncionario = "9999";
            formData.Formulario = "AluguerViatura";
            formDataService.AddFormData(formData);
            Snackbar.Add("Formulário submetido com sucesso", MudBlazor.Severity.Success);
            formData = new FormData(); // Reset the form data
            showConfirmationDialog = false;
        }

    }
}
