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

        public void FillListBoxKlantData(List<Klant> klantDatas)
        {
            ClearListBox();
            DataSource = klantDatas;
        }

        public void FillListBoxWebserviceData(List<WebService> webServiceDatas)
        {
            ClearListBox();
            DataSource = webServiceDatas;
        }

        public void FillListBoxUrlData(List<Url> UrlDatas)
        {
            ClearListBox();
            DataSource = UrlDatas;
        }

        public void FillListBoxHttpData(List<HttpData> httpDatas)
        {
            ClearListBox();
            DataSource = httpDatas;
        }
    }
}
