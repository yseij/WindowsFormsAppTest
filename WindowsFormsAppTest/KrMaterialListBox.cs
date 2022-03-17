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

        public void fillListBoxUrlData(List<UrlData> urlDatas)
        {
            foreach (UrlData urlData in urlDatas)
            {
                KrMaterialListBoxItem krMaterialListBoxItem = new KrMaterialListBoxItem(urlData.Id, urlData.Name);
                AddItem(krMaterialListBoxItem);
            }
        }
    }
}
