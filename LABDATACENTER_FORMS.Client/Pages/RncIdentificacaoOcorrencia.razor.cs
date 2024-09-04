using LABDATACENTER_FORMS.Models;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using System.Globalization;

namespace LABDATACENTER_FORMS.Client.Pages
{
    public partial class RncIdentificacaoOcorrencia
    {
        private FormRelatorioNaoConformidade formRelatorioNaoConformidade = new();

        public CultureInfo _pt = CultureInfo.GetCultureInfo("pt-PT");

        bool success;

        private MudForm form;

        private bool showConfirmationDialog = false;

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
        private void SetDragClass()
    => _dragClass = $"{DefaultDragClass} mud-border-primary";

        private void ClearDragClass()
            => _dragClass = DefaultDragClass;


        private async Task LoadFiles()
        {
        }

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
