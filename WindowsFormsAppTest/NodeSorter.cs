using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    class NodeSorter : IComparer
    {
        public int Compare(object x, object y)
        {
            TreeNode tx = x as TreeNode;

            if (tx.ForeColor == Color.FromArgb(0, 255, 0, 0) && tx.FirstNode == null)
            {
                return 0;
            }
            return 1;
        }
    }
}
