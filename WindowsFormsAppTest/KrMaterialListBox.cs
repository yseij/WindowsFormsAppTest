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

        public void FillListBoxUrlData(List<UrlData> urlDatas)
        {
            ClearListBox();
            DataSource = urlDatas;
        }

        public void FillListBoxKlantData(List<KlantData> klantDatas)
        {
            ClearListBox();
            DataSource = klantDatas;
        }

        public void FillListBoxWebserviceData(List<WebServiceData> webServiceDatas)
        {
            ClearListBox();
            DataSource = webServiceDatas;
        }

        public void FillListBoxHttpData(List<HttpData> httpDatas)
        {
            ClearListBox();
            DataSource = httpDatas;
        }
    }
}
