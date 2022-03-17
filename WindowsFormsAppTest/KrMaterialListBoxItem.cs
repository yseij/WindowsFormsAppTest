using MaterialSkin;

namespace WindowsFormsAppTest
{
    class KrMaterialListBoxItem : MaterialListBoxItem
    {
        public KrMaterialListBoxItem(int id, string name)
        {
            Tag = id;
            Text = name;
        }
    }
}
