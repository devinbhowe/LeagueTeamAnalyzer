﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueTeamAnalyzer.UI
{
    public interface IFormController
    {
        Task PageFinishedAsync();
        void UpdateDebugTextbox(string text);
    }
}
