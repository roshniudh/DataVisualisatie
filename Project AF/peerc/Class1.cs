using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peerc
{
    class SubwijkGeweld
    {
        //List<SubwijkGeweld> x = new List<SubwijkGeweld>();
        private string subwijk;
        private int geweldtotaal;
        private int geweldprom;

        public SubwijkGeweld(string subwijk, int geweldtotaal, int geweldprom)
        {
            this.subwijk = subwijk;
            this.geweldtotaal = geweldtotaal;
            this.geweldprom = geweldprom;
        }
    }
}
// Notities
// {
//     DBConnectie x = new DBConnectie();
//     DataTable data = x.GrabData("select * from subwijkgeweld");
//     int counter = 0;
//     foreach (DataRow row in data.Rows)
//    {
//         counter++;
//         Console.WriteLine(counter + ". " + row[0] + "  " + row[1] + "  " + row[2]);
//         Console.ReadLine();
//     }
// }
