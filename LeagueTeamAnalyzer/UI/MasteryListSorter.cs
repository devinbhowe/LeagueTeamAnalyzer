using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueTeamAnalyzer.UI
{
    public class MasteryListSorter : IComparer
    {
        private int m_columnToSort;
        private SortOrder m_orderOfSort;
        private CaseInsensitiveComparer m_objectCompare;

        public MasteryListSorter()
        {
            m_columnToSort = 1;
            m_orderOfSort = SortOrder.Descending;
            m_objectCompare = new CaseInsensitiveComparer();
        }

        public int Compare(object x_obj, object y_obj)
        {
            string x = ((ListViewItem)x_obj).SubItems[m_columnToSort].Text;
            string y = ((ListViewItem)y_obj).SubItems[m_columnToSort].Text;

            int comparison = m_objectCompare.Compare(Int32.Parse(x), Int32.Parse(y));

            switch (m_orderOfSort)
            {
                case SortOrder.Descending:
                    return -comparison;
                case SortOrder.Ascending:
                    return comparison;
                default:
                    return 0;
            }
        }
    }
}
