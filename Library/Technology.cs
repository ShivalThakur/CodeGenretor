using SearchFile.Library;
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
            currentTechnology = tech;
        }
        public CurrentTechnology GetCurrentTechnology()
        {
            switch (currentTechnology)
            {
                case Technologies.AspNet:
                    {
                        return new AspNet(null);

                    }
                case Technologies.AspMVC:
                    {
                        return null;
                    }
                case Technologies.Angular:
                    {
                        return new Angular();

                    }
                default:
                    return null;
            }
        }

    }
    public enum Technologies
    {
        AspNet,
        AspMVC,
        Angular
    }
}
