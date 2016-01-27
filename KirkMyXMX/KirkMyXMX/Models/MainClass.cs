using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KirkMyXMX.Models
{
    public class MainClass
    {
        //метод рандомящий видеоссылки
        public string GetString()
        {
            Random rnd = new Random();
            string[] Hyperlinks = new string[]
            {
                "https://www.youtube.com/watch?v=K_xTet06SUo",
                "https://www.youtube.com/watch?v=-Gu_Hwnvp5U",
                "https://www.youtube.com/watch?v=t0AKLRDPKUc",
                "https://www.youtube.com/watch?v=ySvwgyt_fSw"
            };
         //   string a = @"https://www.youtube.com/watch?v=K_xTet06SUo";
            return Hyperlinks[rnd.Next(0, Hyperlinks.Length - 1)];
       //     return a;
        }
        public string Name { get; set; }
        public string Pame { get; set; }
        public string Getother()
        {
            return "Faq";
        }
    }
}