using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexolBilling.BAL
{
    public class CommonFunctions
    {
        public string GenerateRandomNo()
        {
            string prefix = "PUR";
            Random rand = new Random();
            int random = rand.Next(1, 1000);
            int day = DateTime.Now.Day;
            int Month = DateTime.Now.Month;
            int Year = DateTime.Now.Year;
            return "" + prefix + "" + random + "" + day + "" + Month + "" + Year + "";

        }
        public string GenerateSaleTransaction()
        {
            string prefix = "SAL";
            Random rand = new Random();
            int random = rand.Next(1, 1000);
            int day = DateTime.Now.Day;
            int Month = DateTime.Now.Month;
            int Year = DateTime.Now.Year;
            return "" + prefix + "" + random + "" + day + "" + Month + "" + Year + "";
        }

       
    }
}
