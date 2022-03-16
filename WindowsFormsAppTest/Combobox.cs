using MaterialSkin.Controls;
using System.Collections.Generic;

namespace WindowsFormsAppTest
{
    class Combobox
    {
        private MaterialComboBox ComboBox;
        public Combobox(MaterialComboBox comboBox)
        {
            ComboBox = comboBox;
        }

        private void fillCmbBoxBase()
        {
            ComboBox.DataSource = null;
            ComboBox.ValueMember = "Id";
        }

        public void fillCmbBoxUrl(List<UrlData> urlDatas)
        {
            fillCmbBoxBase();
            ComboBox.DataSource = urlDatas;
            ComboBox.DisplayMember = "Name";
        }

        public void fillCmbBoxWebservice(List<WebServiceData> webServiceDatas)
        {
            fillCmbBoxBase();
            ComboBox.DataSource = webServiceDatas;
            ComboBox.DisplayMember = "Name";
        }

        public void fillCmbBoxKlant(List<KlantData> klantDatas)
        {
            fillCmbBoxBase();
            ComboBox.DataSource = klantDatas;
            ComboBox.DisplayMember = "Name";
        }
    }
}
