using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AnalysisServices.Tabular;
//using Microsoft.AnalysisServices.Core

namespace ManageAAS
{
    class Program
    {
        static void Main(string[] args)
        {
            Microsoft.AnalysisServices.Tabular.Server serv = new Server();
            //var connstr = "Provider = MSOLAP; Data Source =; Initial Catalog =< aas database name>; User ID =< your username >; Password =< your password >
            serv.Connect("asazure://westeurope.asazure.windows.net/korndemo2");
            Database db = serv.Databases["TabularProject1"]; 
            Model mod = db.Model;
            mod.RequestRefresh(RefreshType.ClearValues);
            mod.SaveChanges();
            mod.RequestRefresh(RefreshType.Full);
            mod.SaveChanges();
        }
    }
}
