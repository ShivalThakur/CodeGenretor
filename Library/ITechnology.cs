using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchFile.Library
{
    interface ITechnology
    {
        string GenerateView();
        string GenerateServerCode();
    }
}
