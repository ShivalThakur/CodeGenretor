using System;
using System.Data;
using SearchFile.Library.DB;

namespace SearchFile.Library
{
    public class Angular : CurrentTechnology
    {

        public override string GenerateView(string spName)
        {
            var columns= GetColumnNames(spName);
            string serverProp = "";
            //Create Angular View
            string view = "<table><tr ng-repeat=\"obj in objList\">";
            foreach (var item in columns)
            {
                view += "<td>{{obj."+item.ColumnName+"}}</td>";
                serverProp += "[DataMember]"+Environment.NewLine+"public "+item.SqlDbType +" " +item.ColumnName +"{get;set;}" + Environment.NewLine;
            }
            view += "</tr></table>";
            view += Environment.NewLine+ "-----------------------";
            view += Environment.NewLine;
            view += serverProp;

            return view;
        }

        public override string GenerateServerCode()
        {
            throw new NotImplementedException();
        }
    }
}