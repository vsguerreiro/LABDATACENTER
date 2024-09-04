using LABDATACENTER_FORMS.Models;

namespace LABDATACENTER_FORMS.Services
{
    public class FormDataService
    {
        public List<FormData> TableData { get; private set; } = new List<FormData>();

        public void AddFormData(FormData formData)
        {
            TableData.Add(formData);
        }

    }
}
