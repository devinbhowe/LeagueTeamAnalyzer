using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueTeamAnalyzer
{
    public interface IAnalyzerView
    {
        void DisplayRecentHistoryList();
        void DisplayMasteryList( );
        void DisplayResults(object item);
        void DisplayFailure(Exception ex);
    }
}
