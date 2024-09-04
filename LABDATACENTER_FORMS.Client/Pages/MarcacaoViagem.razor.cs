using LABDATACENTER_FORMS.Models;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;

namespace LABDATACENTER_FORMS.Client.Pages
{
    public partial class MarcacaoViagem
    {
        private FormData formData = new FormData();

        bool success;

        private MudForm form;

        private bool showConfirmationDialog = false;

        private DateRange _dateRange = new DateRange(DateTime.Now.Date, DateTime.Now.AddDays(5).Date);

        protected override void OnInitialized()
        {
            formData.NumeroFuncionario = "9999";
            formData.Formulario = "MarcacaoViagem";
        }

#nullable enable
        private const string DefaultDragClass = "relative rounded-lg border-2 border-dashed pa-4 mt-4 mud-width-full mud-height-full z-10";
        private string _dragClass = DefaultDragClass;
        private readonly List<string> _fileNames = new();

        private async Task Clear()
        {
            _fileNames.Clear();
            ClearDragClass();
            await Task.Delay(100);
        }

        private void OnInputFileChanged(InputFileChangeEventArgs e)
        {
            ClearDragClass();
            var files = e.GetMultipleFiles();
            foreach (var file in files)
            {
                _fileNames.Add(file.Name);
            }
        }

        private bool IsFormFilled()
        {
            return success && !string.IsNullOrEmpty(formData.LocalEntrega) && !string.IsNullOrEmpty(formData.CentroDeCustoOuPep);
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

        private void SetDragClass()
            => _dragClass = $"{DefaultDragClass} mud-border-primary";

        private void ClearDragClass()
            => _dragClass = DefaultDragClass;

        private async Task LoadFiles()
        {

        }
    }
}
