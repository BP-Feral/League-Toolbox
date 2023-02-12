using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobbyRV
{
    public class Variables
    {
        // Needed so Threads don't get duplicated
        public static bool LobbyHandlerVisited = false;
    }
}
