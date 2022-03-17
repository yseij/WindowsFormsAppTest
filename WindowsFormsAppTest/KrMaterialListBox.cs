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
            foreach (UrlData urlData in urlDatas)
            {
                KrMaterialListBoxItem krMaterialListBoxItem = new KrMaterialListBoxItem(urlData.Id, urlData.Name);
                AddItem(krMaterialListBoxItem);
            }
        }

        public void FillListBoxKlantData(List<KlantData> klantDatas)
        {
            foreach (KlantData klantData in klantDatas)
            {
                KrMaterialListBoxItem krMaterialListBoxItem = new KrMaterialListBoxItem(klantData.Id, klantData.Name);
                AddItem(krMaterialListBoxItem);
            }
        }
    }
}
