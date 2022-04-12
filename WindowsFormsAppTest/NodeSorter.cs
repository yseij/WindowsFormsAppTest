using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    class NodeSorter : IComparer
    {
        public int Compare(object x, object y)
        {
            TreeNode tx = x as TreeNode;
            TreeNode ty = y as TreeNode;

            if (tx.ForeColor == Color.FromArgb(0, 255, 0, 0) && tx.FirstNode == null)
            {
                return 0;
            }
            return 1;
            //else
            //{
            //    //Compare the length of the strings, returning the difference.
            //    if (tx.Text.Length != ty.Text.Length)
            //        return tx.Text.Length - ty.Text.Length;

            //    // If they are the same length, call Compare.
            //    return string.Compare(tx.Text, ty.Text);
            //}
        }
    }
}
