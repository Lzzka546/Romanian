using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanianLibrary
{
    public class RomanianClass
    {
        public static bool GenerationNumber(string surname, string gender, DateTime date, bool rezRum, string city)
        {
            string code = "";

            if (date.Year > 1900 && date.Year < 1949)
            {
                    code += "1";
            }
                if (date.Year > 1950 && date.Year < 1999)
                {
                    code += "2";
                }
                if (date.Year > 1800 && date.Year < 1849)
                {
                    code += "3";
                }
                if (date.Year > 1850 && date.Year < 1899)
                {
                    code += "4";
                }
                if (date.Year > 2000 && date.Year < 2049)
                {
                    code += "5";
                }
                if (date.Year > 2050 && date.Year < 2099)
                {
                    code += "6";
                }
                if (rezRum != true)
                {
                Random r = new Random();
                int rInt = r.Next(7, 10);
                code += rInt;
                }
            return true; 
        }
       
    }
   
}
