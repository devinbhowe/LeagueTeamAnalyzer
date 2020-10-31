using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueTeamAnalyzer.UI
{
    public class SimpleNumberSorter : IComparer
    {
        private int m_columnToSort;
        private SortOrder m_orderOfSort;
        private CaseInsensitiveComparer m_objectCompare;
        private List<Type> m_columnTypes;

        public int ColumnToSort
        {
            get { return m_columnToSort; }
            set 
            { 
                if (m_columnToSort == value)
                {
                    m_orderOfSort = m_orderOfSort == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
                }
                else
                {
                    m_columnToSort = value;
                    m_orderOfSort = SortOrder.Descending;
                }
            }
        }

        public SimpleNumberSorter(int columnToSort, List<Type> columnTypes)
        {
            m_columnToSort = columnToSort;
            m_orderOfSort = SortOrder.Descending;
            m_columnTypes = columnTypes;
            m_objectCompare = new CaseInsensitiveComparer();
        }

        public int Compare(object x_obj, object y_obj)
        {
            string x = ((ListViewItem)x_obj).SubItems[m_columnToSort].Text;
            string y = ((ListViewItem)y_obj).SubItems[m_columnToSort].Text;

            int comparison = 0;
            if (m_columnTypes.ElementAt(m_columnToSort) == typeof(int))
            {
                comparison = m_objectCompare.Compare(Int32.Parse(x), Int32.Parse(y));
            }
            else if (m_columnTypes.ElementAt(m_columnToSort) == typeof(string))
            {
                comparison = m_objectCompare.Compare(x, y);
            }
            else if (m_columnTypes.ElementAt(m_columnToSort) == typeof(double))
            {
                // Remove % symbol
                comparison = m_objectCompare.Compare(double.Parse(x.Substring(0,x.Length-1)), double.Parse(y.Substring(0, y.Length-1)));
            }
            
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
