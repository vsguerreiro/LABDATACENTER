using LABDATACENTER_FORMS.Models;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using System.Globalization;

namespace LABDATACENTER_FORMS.Client.Pages 
{

    public partial class RequisicaoMaterialServico 
    {
        private FormData formData = new();

        public CultureInfo _pt = CultureInfo.GetCultureInfo("pt-PT");

        bool success;

        private bool showConfirmationDialog = false;

        private MudForm? form;

        private const string DefaultDragClass = "relative rounded-lg border-2 border-dashed pa-4 mt-4 mud-width-full mud-height-full z-10";
        private string _dragClass = DefaultDragClass;
        private readonly List<string> _fileNames = new();

        protected override void OnInitialized()
        {
            formData.TipoRequisicao = "Material";
            formData.NumeroFuncionario = "9999";
            formData.Formulario = "ReqMatSer";
            formData.NifFornecedor = "510217028";
        }        

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

        public static bool IsValidNIF(string nif)
        {
            const int expectedLength = 9;
            if (string.IsNullOrEmpty(nif) || nif.Length != expectedLength)
                return false;

            int checkSum = 0;
            for (int i = 0; i < expectedLength - 1; i++)
            {
                checkSum += (nif[i] - '0') * (expectedLength - i);
            }

            int checkDigit = 11 - (checkSum % 11);
            if (checkDigit == 10)
                checkDigit = 0;

            return checkDigit == (nif[expectedLength - 1] - '0');
        }

        private async Task HandleSubmit()
        {
            await form.Validate();
            if (!form.IsValid)
            {
                Snackbar.Add("Por favor, corrija os erros assinalados no formulário", MudBlazor.Severity.Error);
                return;
            }

            formDataService.AddFormData(formData);
            Snackbar.Add("Formulário submetido com sucesso", MudBlazor.Severity.Success);
            formData = new FormData(); // Reset the form data
            showConfirmationDialog = false;
        }

        private void SetDragClass()
            => _dragClass = $"{DefaultDragClass} mud-border-primary";

        private void ClearDragClass()
            => _dragClass = DefaultDragClass;

        private bool IsFormFilled()
        {
            return success && !string.IsNullOrEmpty(@formData.Fornecedor) &&
               !string.IsNullOrEmpty(formData.NifFornecedor) && !string.IsNullOrEmpty(formData.TipoRequisicao) &&
               !string.IsNullOrEmpty(formData.CentroDeCustoOuPep);
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

        private async Task LoadFiles()
        {

        }

    }
}