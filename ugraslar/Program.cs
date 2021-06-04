using System;

namespace ugraslar
{
    class Program
    {
        static void Main(string[] args)
        {
            int gecengun, gecenay, gecenyil;
            int tarihgun, tarihay, tarihyil;
            int gun, ay, yil;
            gun = 14;
            ay = 8;
            yil = 2020;
            tarihgun = DateTime.Now.Day;
            tarihay = DateTime.Now.Month;
            tarihyil = DateTime.Now.Year;

            if (tarihgun < gun)
            {
                tarihay = tarihay - 1;
                tarihgun = tarihgun + 30;
            }
            gecengun = tarihgun - gun;

            if (tarihay < ay)
            {
                tarihyil = tarihyil - 1;
                tarihay = tarihay + 12;
            }
            gecenay = tarihay - ay;
            gecenyil = tarihyil - yil;

            Console.WriteLine("geçen zaman: {0} yıl; {1} ay; {2} gün.",gecenyil,gecenay,gecengun);
            Console.Read();
        }
    }
}
