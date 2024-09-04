using LABDATACENTER_FORMS.Models;

namespace LABDATACENTER_FORMS.Services
{
    public class FormReclamacoesDataService
    {
        public List<FormReclamacoesData> TableData { get; private set; } = new List<FormReclamacoesData>();


        public void AddFormReclamacoesData(FormReclamacoesData formReclamacoesData)
        {
            TableData.Add(formReclamacoesData);
        }
    }
}