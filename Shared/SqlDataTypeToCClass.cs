using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchFile.Shared
{
   public class SqlDataTypeToCClass
    {
       public string ToClass(string c)
       {
           string returndatatype = "";
           switch (c.ToLower())
           {
               case "datetime":
               case "date":
                   {
                       returndatatype = "DateTime";
                       break;
                   }
               case "varchar":
               case "nvarchar":
               case "char":
                   {
                       returndatatype = "String";
                       break;
                   }
               case "int":
                   {
                       returndatatype = "Int32";
                       break;
                   }
               case "smallint":
                   {
                       returndatatype = "Int16";
                       break;
                   }
               case "decimal":
                   {
                       returndatatype = "Decimal";
                       break;
                   }

           }          
           return "Convert.To"+ returndatatype;
       }
    }
}
