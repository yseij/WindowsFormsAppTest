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

        public void fillCmbBoxUrl(List<UrlData> urlDatas)
        {
            ClearDataSource();
            DataSource = urlDatas;
        }

        public void fillCmbBoxWebservice(List<WebServiceData> webServiceDatas)
        {
            ClearDataSource();
            DataSource = webServiceDatas;
            
        }

        public void fillCmbBoxKlant(List<KlantData> klantDatas)
        {
            ClearDataSource();
            DataSource = klantDatas;
        }
    }
}
