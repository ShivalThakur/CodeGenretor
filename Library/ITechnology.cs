using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SearchFile.Library
{
    public abstract class CurrentTechnology
    {
        public DataSet colData;
        public abstract string GenerateView();
        public abstract string GenerateServerCode();
    }
}
