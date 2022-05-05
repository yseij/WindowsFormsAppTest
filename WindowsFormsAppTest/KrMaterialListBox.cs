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

        private void SetMembers()
        {
            DisplayMember = "Name";
            ValueMember = "Id";
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
