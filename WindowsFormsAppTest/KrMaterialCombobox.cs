
using MaterialSkin.Controls;
using System.Collections.Generic;

namespace WindowsFormsAppTest
{
    class KrMaterialCombobox : MaterialComboBox
    {
        public KrMaterialCombobox()
        {

        }

        private void ClearDataSource()
        {
            DataSource = null;
        }

        private void SetDisplayAndValueMember()
        {
            ValueMember = "Id";
            DisplayMember = "Name";
        }

        public void FillCmbBoxUrl(List<Url> urlDatas)
        {
            ClearDataSource();
            DataSource = urlDatas;
            SetDisplayAndValueMember();
        }

        public void FillCmbBoxWebservice(List<WebService> webServiceDatas)
        {
            ClearDataSource();

            DataSource = webServiceDatas;
            SetDisplayAndValueMember();
        }

        public void FillCmbBoxKlant(List<Klant> klantDatas)
        {
            ClearDataSource();
            DataSource = klantDatas;
            SetDisplayAndValueMember();
        }

        public void FillCmbBoxHttp(List<HttpData> httpDatas)
        {
            ClearDataSource();
            DataSource = httpDatas;
            SetDisplayAndValueMember();
        }
    }
}
