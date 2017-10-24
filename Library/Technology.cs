using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchFile
{

    public class Technology
    {
        Technologies currentTechnology;
        public Technology(Technologies tech)
        {
           // currentTechnology = Enum.GetValues(typeof(Technologies)).Cast<string>().Where(x => x == tech);
        }
        
    }

    public enum Technologies
    {
        AspNet,
        AspMVC,
        Angular
    }
}
