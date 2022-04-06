
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

        public void FillCmbBoxUrl(List<UrlData> urlDatas)
        {
            ClearDataSource();
            DataSource = urlDatas;
            SetDisplayAndValueMember();
        }

        public void FillCmbBoxWebservice(List<WebServiceData> webServiceDatas)
        {
            ClearDataSource();
            DataSource = webServiceDatas;
            SetDisplayAndValueMember();
        }

        public void FillCmbBoxKlant(List<KlantData> klantDatas)
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
