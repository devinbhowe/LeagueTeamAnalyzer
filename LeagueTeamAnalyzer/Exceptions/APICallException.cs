using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueTeamAnalyzer.Exceptions
{
    public class APICallException : Exception
    {
        public APICallExceptionType Type;

        public APICallException(APICallExceptionType type, string message)
            : base(message)
        {
            Type = type;
        }
    }

    public enum APICallExceptionType
    {
        InvalidSummonerName,
    }
}
