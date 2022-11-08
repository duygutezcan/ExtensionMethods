using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static string IlkHarfBuyuk(this string value)     //string e ek özellik kazandırır
        {
            return value.Substring(0,1).ToUpper() + value.Substring(1);
        }

        public static  string  Ayadi( this DateTime date)
        {
            
            int ay = date.Month;
            if(ay==1)
            {
                return "ocak"; 
            }
            else if(ay==2)
            {
                return "şubat";
            }
            else if (ay == 3)
            {
                return "mart";
            }
            else if (ay == 4)
            {
                return "nisan";
            }
            else if (ay == 5)
            {
                return "mayıs";
            }
            else if (ay == 6)
            {
                return "haziran";
            }
            else if (ay == 7)
            {
                return "temmuz";
            }
            else if (ay == 8)
            {
                return "ağustos";
            }
            else if (ay == 9)
            {
                return "eylül";
            }
            else if (ay == 10)
            {
                return "ekim";
            }
            else if (ay == 11)
            {
                return "kasım";
            }
            else if (ay == 12)
            {
                return "aralık";
            }
            else 
            {
            return "ay yok";
             }
        }

    }
}
