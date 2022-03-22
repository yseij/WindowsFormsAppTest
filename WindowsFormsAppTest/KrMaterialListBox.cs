using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;

namespace WindowsFormsAppTest
{
    class KrMaterialListBox : MaterialListBox
    {
        public KrMaterialListBox()
        {
        }

        public void ClearListBox()
        {
            Clear();
        }

        public void FillListBoxUrlData(List<UrlData> urlDatas)
        {
            ClearListBox();
            foreach (UrlData urlData in urlDatas)
            {
                KrMaterialListBoxItem krMaterialListBoxItem = new KrMaterialListBoxItem(urlData.Id, urlData.Name);
                AddItem(krMaterialListBoxItem);
            }
        }

        public void FillListBoxKlantData(List<KlantData> klantDatas)
        {
            ClearListBox();
            foreach (KlantData klantData in klantDatas)
            {
                KrMaterialListBoxItem krMaterialListBoxItem = new KrMaterialListBoxItem(klantData.Id, klantData.Name);
                AddItem(krMaterialListBoxItem);
            }
        }

        public void FillListBoxWebserviceData(List<WebServiceData> webServiceDatas)
        {
            ClearListBox();
            foreach (WebServiceData webServiceData in webServiceDatas)
            {
                KrMaterialListBoxItem krMaterialListBoxItem = new KrMaterialListBoxItem(webServiceData.Id, webServiceData.Name);
                AddItem(krMaterialListBoxItem);
            }
        }
    }
}
