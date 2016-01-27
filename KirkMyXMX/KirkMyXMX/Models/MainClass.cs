using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KirkMyXMX.Models
{
    public class MainClass
    {
        //метод рандомящий видеоссылки
        private static int nyaZong=0;
        private static int nyanyaZong = 0;
        public string GetString()
        {
            Random rnd = new Random();
            string[] Hyperlinks;
            //бонусный список песен
            if (nyaZong == 30)
            {
                nyaZong = 0;

                Hyperlinks = new string[]
                {
                "https://www.youtube.com/watch?v=yzC4hFK5P3g",
                "https://www.youtube.com/watch?v=kuNixp-wvWM",
                "https://www.youtube.com/watch?v=_HyCUr95LEU",
                "https://www.youtube.com/watch?v=K7hdWbl603c",
                "https://www.youtube.com/watch?v=8zwc8zDNjpE",
                "https://www.youtube.com/watch?v=yEXT1V1G68E"
                };
            }
            //мега-бонусный список песен
            else if (nyanyaZong==50)
            {
                nyanyaZong = 0;

                Hyperlinks = new string[]
                {
                "https://www.youtube.com/watch?v=yCgpL7wDDds",
                "https://www.youtube.com/watch?v=dh6gGmRQmyQ",
                "https://www.youtube.com/watch?v=pAPGG_zq-t4",
                "https://www.youtube.com/watch?v=GJ4yehnerHQ",
                "https://www.youtube.com/watch?v=nIrYjzHAEp0",
                };
            }
            //обычные песни
            else
            {
                nyaZong++;
                nyanyaZong++;


                Hyperlinks = new string[]
                {
                "https://www.youtube.com/watch?v=K_xTet06SUo",
                "https://www.youtube.com/watch?v=-Gu_Hwnvp5U",
                "https://www.youtube.com/watch?v=t0AKLRDPKUc",
                "https://www.youtube.com/watch?v=ySvwgyt_fSw",
                "https://www.youtube.com/watch?v=nHA-ByU7OHU",
                "https://www.youtube.com/watch?v=Fy8hK3blQOQ",
                "https://www.youtube.com/watch?v=Gx22w6LFVV4",
                "https://www.youtube.com/watch?v=jJ1xxAH7_tQ"
                };
            }
            return Hyperlinks[rnd.Next(0, Hyperlinks.Length)];
        }

        public string Name { get; set; }
        public string Pame { get; set; }
        public string Getother()
        {
            return "Faq";
        }
    }
}