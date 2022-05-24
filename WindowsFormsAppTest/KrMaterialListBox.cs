using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    class KrMaterialListBox : ListBox
    {
        public KrMaterialListBox()
        {
        }

        public void ClearListBox()
        {
            DataSource = null;
            SetMembers();
        }

        public void SetMembers()
        {
            ValueMember = "Id";
            DisplayMember = "Name";
        }

        public void FillListBoxKlantData(List<Klant> klanten)
        {
            ClearListBox();
            DataSource = klanten;
        }

        public void FillListBoxWebserviceData(List<WebService> webServices)
        {
            ClearListBox();
            DataSource = webServices;
        }

        public void FillListBoxUrls(List<Url> urls)
        {
            ClearListBox();
            DataSource = urls;
        }
    }
}
