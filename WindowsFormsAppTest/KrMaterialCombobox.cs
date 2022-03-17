
using MaterialSkin.Controls;
using System.Collections.Generic;


namespace WindowsFormsAppTest
{
    class KrMaterialCombobox : MaterialComboBox
    {
        public KrMaterialCombobox()
        {
            ValueMember = "Id";
            DisplayMember = "Name";
        }

        private void ClearDataSource()
        {
            DataSource = null;
        }

        public void FillCmbBoxUrl(List<UrlData> urlDatas)
        {
            ClearDataSource();
            DataSource = urlDatas;
        }

        public void FillCmbBoxWebservice(List<WebServiceData> webServiceDatas)
        {
            ClearDataSource();
            DataSource = webServiceDatas;
            
        }

        public void FillCmbBoxKlant(List<KlantData> klantDatas)
        {
            ClearDataSource();
            DataSource = klantDatas;
        }

        public void FillCmbBoxRest(List<string> data)
        {
            ClearDataSource();
            DataSource = data;
        }
    }
}
