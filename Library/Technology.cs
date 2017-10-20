using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchFile.Library
{

    public class Technology
    {
        public Technology()
        {

        }
        public class AspNet : ITechnology
        {
            public string GenerateView()
            {
                return "";
                //throw new NotImplementedException();
            }
            public string GenerateServerCode()
            {
                return "";
                //throw new NotImplementedException();
            }
        }
        public class AspMVC : ITechnology
        {
            public string GenerateView()
            {
                throw new NotImplementedException();
            }
            public string GenerateServerCode()
            {
                throw new NotImplementedException();
            }
        }
        public class Angular : ITechnology
        {

            public string GenerateView()
            {
                throw new NotImplementedException();
            }

            public string GenerateServerCode()
            {
                throw new NotImplementedException();
            }
        }
    }

}
