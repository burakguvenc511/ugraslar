using System;

namespace milyoner_.yarismasi
{
    class Program
    {
        public static int soru_D(ref int over, ref int sayi, ref int para, ref int rastgele, ref int dogru, ref string soru, ref string a, ref string b, ref string c, ref string d)
        {
            string cevap;
        sor1:
            Console.Write("cevap nedir ?: ");
            cevap = Console.ReadLine();

            if (cevap == "a" || cevap == "A")
            {
                Console.Clear();
                Console.WriteLine("soru {0}:", sayi);
                Console.WriteLine(soru);
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write(a);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("       "); Console.WriteLine(b);
                Console.Write(c); Console.Write("       ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(d);
                Console.BackgroundColor = ConsoleColor.Black;
                over = 1;
                Console.WriteLine("cevap yanlış...");
                Console.Read();
                Console.Clear();
            }

            else if (cevap == "b" || cevap == "B")
            {
                Console.Clear();
                Console.WriteLine("soru {0}:", sayi);
                Console.WriteLine(soru);
                Console.Write(a); Console.Write("       ");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(b);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(c); Console.Write("       ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(d);
                Console.BackgroundColor = ConsoleColor.Black;
                over = 1;
                Console.WriteLine("cevap yanlış...");
                Console.Read();
                Console.Clear();
            }

            else if (cevap == "c" || cevap == "C")
            {
                Console.Clear();
                Console.WriteLine("soru {0}:", sayi);
                Console.WriteLine(soru);
                Console.Write(a);
                Console.Write("       ");
                Console.WriteLine(b);
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write(c);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("       ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(d);
                Console.BackgroundColor = ConsoleColor.Black;
                over = 1;
                Console.WriteLine("cevap yanlış...");
                Console.Read();
                Console.Clear();
            }

            else if (cevap == "d" || cevap == "D")
            {
                Console.Clear();
                Console.WriteLine("soru {0}:", sayi);
                Console.WriteLine(soru);
                Console.Write(a); Console.Write("       ");
                Console.WriteLine(b);
                Console.Write(c); Console.Write("       ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(d);
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine("tebrikler doğru cevap...");
                if (sayi == 1)
                {
                    Console.WriteLine("ödül: 500 TL");
                    para = para + 500;
                }
                else if (sayi == 2)
                {
                    Console.WriteLine("ödül: 1000 TL");
                    para = para + 1000;
                }
                else if (sayi == 3)
                {
                    Console.WriteLine("ödül: 2000 TL");
                    para = para + 2000;
                }
                else if (sayi == 4)
                {
                    Console.WriteLine("ödül: 5000 TL");
                    para = para + 5000;
                }
                else if (sayi == 5)
                {
                    Console.WriteLine("ödül: 7500 TL");
                    para = para + 7500;
                }
                else if (sayi == 6)
                {
                    Console.WriteLine("ödül: 10000 TL");
                    para = para + 10000;
                }
                else if (sayi == 7)
                {
                    Console.WriteLine("ödül: 20000 TL");
                    para = para + 20000;
                }
                else if (sayi == 8)
                {
                    Console.WriteLine("ödül: 30000 TL");
                    para = para + 30000;
                }
                else if (sayi == 9)
                {
                    Console.WriteLine("ödül: 40000 TL");
                    para = para + 40000;
                }
                else if (sayi == 10)
                {
                    Console.WriteLine("ödül: 50000 TL");
                    para = para + 50000;
                }
                Console.Read();
                Console.Clear();
                dogru = dogru + 1;
                return dogru;
            }
            else
            {
                goto sor1;
            }
            return 0;

        }

        public static int soru_C(ref int over, ref int sayi, ref int para, ref int rastgele, ref int dogru, ref string soru, ref string a, ref string b, ref string c, ref string d)
        {
            string cevap;
        sor2:
            Console.Write("cevap nedir ?: ");
            cevap = Console.ReadLine();

            if (cevap == "a" || cevap == "A")
            {
                Console.Clear();
                Console.WriteLine("soru {0}:", sayi);
                Console.WriteLine(soru);
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write(a);
                Console.BackgroundColor = ConsoleColor.Black; Console.Write("       ");
                Console.WriteLine(b);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(c);
                Console.BackgroundColor = ConsoleColor.Black; Console.Write("       ");
                Console.WriteLine(d);
                over = 1;
                Console.WriteLine("cevap yanlış...");
                Console.Read();
                Console.Clear();
            }
            else if (cevap == "b" || cevap == "B")
            {
                Console.Clear();
                Console.WriteLine("soru {0}:", sayi);
                Console.WriteLine(soru);
                Console.Write(a); Console.Write("       ");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(b);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(c);
                Console.BackgroundColor = ConsoleColor.Black; Console.Write("       ");
                Console.WriteLine(d);
                over = 1;
                Console.WriteLine("cevap yanlış...");
                Console.Read();
                Console.Clear();

            }
            else if (cevap == "d" || cevap == "D")
            {
                Console.Clear();
                Console.WriteLine("soru {0}:", sayi);
                Console.WriteLine(soru);
                Console.Write(a); Console.Write("       ");
                Console.WriteLine(b);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(c);
                Console.BackgroundColor = ConsoleColor.Black; Console.Write("       ");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(d);
                Console.BackgroundColor = ConsoleColor.Black;
                over = 1;
                Console.WriteLine("cevap yanlış...");
                Console.Read();
                Console.Clear();
            }



            else if (cevap == "c" || cevap == "C")
            {
                Console.Clear();
                Console.WriteLine("soru {0}:", sayi);
                Console.WriteLine(soru);
                Console.Write(a); Console.Write("       ");
                Console.WriteLine(b);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(c);
                Console.BackgroundColor = ConsoleColor.Black; Console.Write("       ");
                Console.WriteLine(d);

                Console.WriteLine("tebrikler doğru cevap...");
                if (sayi == 1)
                {
                    Console.WriteLine("ödül: 500 TL");
                    para = para + 500;
                }
                else if (sayi == 2)
                {
                    Console.WriteLine("ödül: 1000 TL");
                    para = para + 1000;
                }
                else if (sayi == 3)
                {
                    Console.WriteLine("ödül: 2000 TL");
                    para = para + 2000;
                }
                else if (sayi == 4)
                {
                    Console.WriteLine("ödül: 5000 TL");
                    para = para + 5000;
                }
                else if (sayi == 5)
                {
                    Console.WriteLine("ödül: 7500 TL");
                    para = para + 7500;
                }
                else if (sayi == 6)
                {
                    Console.WriteLine("ödül: 10000 TL");
                    para = para + 10000;
                }
                else if (sayi == 7)
                {
                    Console.WriteLine("ödül: 20000 TL");
                    para = para + 20000;
                }
                else if (sayi == 8)
                {
                    Console.WriteLine("ödül: 30000 TL");
                    para = para + 30000;
                }
                else if (sayi == 9)
                {
                    Console.WriteLine("ödül: 40000 TL");
                    para = para + 40000;
                }
                else if (sayi == 10)
                {
                    Console.WriteLine("ödül: 50000 TL");
                    para = para + 50000;
                }
                Console.Read();
                Console.Clear();
                dogru = dogru + 1;
                return dogru;
            }
            else
            {
                goto sor2;
            }
            return 0;

        }

        public static int soru_B(ref int over, ref int sayi, ref int para, ref int rastgele, ref int dogru, ref string soru, ref string a, ref string b, ref string c, ref string d)
        {
            string cevap;
        sor3:
            Console.Write("cevap nedir ?: ");
            cevap = Console.ReadLine();

            if (cevap == "d" || cevap == "D")
            {
                Console.Clear();
                Console.WriteLine("soru {0}:", sayi);
                Console.WriteLine(soru);
                Console.Write(a); Console.Write("       ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(b);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(c); Console.Write("       ");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(d);
                Console.BackgroundColor = ConsoleColor.Black;
                over = 1;
                Console.WriteLine("cevap yanlış...");
                Console.Read();
                Console.Clear();
            }

            else if (cevap == "a" || cevap == "A")
            {
                Console.Clear();
                Console.WriteLine("soru {0}:", sayi);
                Console.WriteLine(soru);
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write(a);
                Console.BackgroundColor = ConsoleColor.Black; Console.Write("       ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(b);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(c); Console.Write("       ");
                Console.WriteLine(d);
                over = 1;
                Console.WriteLine("cevap yanlış...");
                Console.Read();
                Console.Clear();
            }

            else if (cevap == "c" || cevap == "C")
            {
                Console.Clear();
                Console.WriteLine("soru {0}:", sayi);
                Console.WriteLine(soru);
                Console.Write(a); Console.Write("       ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(b);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write(c);
                Console.BackgroundColor = ConsoleColor.Black; Console.Write("       ");
                Console.WriteLine(d);
                over = 1;
                Console.WriteLine("cevap yanlış...");
                Console.Read();
                Console.Clear();
            }


            else if (cevap == "b" || cevap == "B")
            {
                Console.Clear();
                Console.WriteLine("soru {0}:", sayi);
                Console.WriteLine(soru);
                Console.Write(a); Console.Write("       ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(b);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(c); Console.Write("       ");
                Console.WriteLine(d);

                Console.WriteLine("tebrikler doğru cevap...");
                if (sayi == 1)
                {
                    Console.WriteLine("ödül: 500 TL");
                    para = para + 500;
                }
                else if (sayi == 2)
                {
                    Console.WriteLine("ödül: 1000 TL");
                    para = para + 1000;
                }
                else if (sayi == 3)
                {
                    Console.WriteLine("ödül: 2000 TL");
                    para = para + 2000;
                }
                else if (sayi == 4)
                {
                    Console.WriteLine("ödül: 5000 TL");
                    para = para + 5000;
                }
                else if (sayi == 5)
                {
                    Console.WriteLine("ödül: 7500 TL");
                    para = para + 7500;
                }
                else if (sayi == 6)
                {
                    Console.WriteLine("ödül: 10000 TL");
                    para = para + 10000;
                }
                else if (sayi == 7)
                {
                    Console.WriteLine("ödül: 20000 TL");
                    para = para + 20000;
                }
                else if (sayi == 8)
                {
                    Console.WriteLine("ödül: 30000 TL");
                    para = para + 30000;
                }
                else if (sayi == 9)
                {
                    Console.WriteLine("ödül: 40000 TL");
                    para = para + 40000;
                }
                else if (sayi == 10)
                {
                    Console.WriteLine("ödül: 50000 TL");
                    para = para + 50000;
                }
                Console.Read();
                Console.Clear();
                dogru = dogru + 1;
                return dogru;
            }
            else
            {
                goto sor3;
            }
            return 0;

        }

        public static int soru_A(ref int over, ref int sayi, ref int para, ref int rastgele, ref int dogru, ref string soru, ref string a, ref string b, ref string c, ref string d)
        {
            string cevap;
        sor4:
            Console.Write("cevap nedir ?: ");
            cevap = Console.ReadLine();

            if (cevap == "d" || cevap == "D")
            {
                Console.Clear();
                Console.WriteLine("soru {0}:", sayi);
                Console.WriteLine(soru);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(a);
                Console.BackgroundColor = ConsoleColor.Black; Console.Write("       ");
                Console.WriteLine(b);
                Console.Write(c); Console.Write("       ");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(d);
                Console.BackgroundColor = ConsoleColor.Black;
                over = 1;
                Console.WriteLine("cevap yanlış...");
                Console.Read();
                Console.Clear();
            }

            else if (cevap == "b" || cevap == "B")
            {
                Console.Clear();
                Console.WriteLine("soru {0}:", sayi);
                Console.WriteLine(soru);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(a);
                Console.BackgroundColor = ConsoleColor.Black; Console.Write("       ");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(b);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(c); Console.Write("       ");
                Console.WriteLine(d);
                over = 1;
                Console.WriteLine("cevap yanlış...");
                Console.Read();
                Console.Clear();
            }

            else if (cevap == "c" || cevap == "C")
            {
                Console.Clear();
                Console.WriteLine("soru {0}:", sayi);
                Console.WriteLine(soru);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(a);
                Console.BackgroundColor = ConsoleColor.Black; Console.Write("       ");
                Console.WriteLine(b);
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write(c);
                Console.BackgroundColor = ConsoleColor.Black; Console.Write("       ");
                Console.WriteLine(d);
                over = 1;
                Console.WriteLine("cevap yanlış...");
                Console.Read();
                Console.Clear();
            }



            else if (cevap == "a" || cevap == "A")
            {
                Console.Clear();
                Console.WriteLine("soru {0}:", sayi);
                Console.WriteLine(soru);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(a);
                Console.BackgroundColor = ConsoleColor.Black; Console.Write("       ");
                Console.WriteLine(b);
                Console.Write(c); Console.Write("       ");
                Console.WriteLine(d);

                Console.WriteLine("tebrikler doğru cevap...");
                if (sayi == 1)
                {
                    Console.WriteLine("ödül: 500 TL");
                    para = para + 500;
                }
                else if (sayi == 2)
                {
                    Console.WriteLine("ödül: 1000 TL");
                    para = para + 1000;
                }
                else if (sayi == 3)
                {
                    Console.WriteLine("ödül: 2000 TL");
                    para = para + 2000;
                }
                else if (sayi == 4)
                {
                    Console.WriteLine("ödül: 5000 TL");
                    para = para + 5000;
                }
                else if (sayi == 5)
                {
                    Console.WriteLine("ödül: 7500 TL");
                    para = para + 7500;
                }
                else if (sayi == 6)
                {
                    Console.WriteLine("ödül: 10000 TL");
                    para = para + 10000;
                }
                else if (sayi == 7)
                {
                    Console.WriteLine("ödül: 20000 TL");
                    para = para + 20000;
                }
                else if (sayi == 8)
                {
                    Console.WriteLine("ödül: 30000 TL");
                    para = para + 30000;
                }
                else if (sayi == 9)
                {
                    Console.WriteLine("ödül: 40000 TL");
                    para = para + 40000;
                }
                else if (sayi == 10)
                {
                    Console.WriteLine("ödül: 50000 TL");
                    para = para + 50000;
                }
                Console.Read();
                Console.Clear();
                dogru = dogru + 1;
                return dogru;
            }
            else
            {
                goto sor4;
            }
            return 0;

        }

        // buradan itibaren yukarı taraf soru kalıpları.

        static void Main(string[] args)
        {
            int rastgele = 0, x = 0, sayi = 0, over = 0;
            int dogru = 0, yanlis = 0, para = 0;
            int s1 = 0, s2 = 0, s3 = 0, s4 = 0, s5 = 0, s6 = 0, s7 = 0, s8 = 0, s9 = 0, s10 = 0, s11 = 0, s12 = 0, s13 = 0, s14 = 0, s15 = 0, s16 = 0, s17 = 0, s18 = 0, s19 = 0, s20 = 0;
            int s21 = 0, s22 = 0, s23 = 0, s24 = 0, s25 = 0;
            string isim;
            string soyisim;

            Console.WriteLine("***  yarışmaya hoş geldiniz  ***\n\n");
            Console.Title = "milyoner olma yarışması.exe";

            Console.Write("adınız: ");
            isim = Console.ReadLine();
            Console.Write("soyadınız: ");
            soyisim = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("yarışmacı adı soyadı: {0} {1}\n", isim, soyisim);
            Console.WriteLine("*** yarışma başlıyor ***\n\n");

            Random secim = new Random();
        tekrar:
            if (sayi == 0 || sayi == 1)
            {
                rastgele = secim.Next(1, 6);
            }
            else if (sayi == 2 || sayi == 3)
            {
                rastgele = secim.Next(6, 11);
            }
            else if (sayi == 4 || sayi == 5)
            {
                rastgele = secim.Next(11, 16);
            }
            else if (sayi == 6 || sayi == 7)
            {
                rastgele = secim.Next(16, 21);
            }
            else if (sayi == 8 || sayi == 9)
            {
                rastgele = secim.Next(21, 26);
            }

            while (x == 0)
            {
                if (over == 1 || sayi == 10)
                {
                    goto over;
                }

                // soru 1        1-6 arası zorluk 1

                if (rastgele == 1)
                {
                    if (s1 == 0)
                    {
                        s1 = 1;
                        sayi = sayi + 1;
                        string soru = "cumhuriyet kaç yılında ilan edilmiştir ?";
                        string a = "A) 1920";
                        string b = "B) 1925";
                        string c = "C) 1928";
                        string d = "D) 1923";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.Write("A) 1920"); Console.Write("       "); Console.WriteLine("B) 1925");
                        Console.Write("C) 1928"); Console.Write("       "); Console.WriteLine("D) 1923");
                        soru_D(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 2

                else if (rastgele == 2)
                {
                    if (s2 == 0)
                    {
                        s2 = 1;
                        sayi = sayi + 1;
                        string soru = "Atasözüne göre -gönülden de ırak- olan kimdir ?";
                        string a = "A) aracı tamirde olan";
                        string b = "B) evi uzak olan";
                        string c = "C) gözden ırak olan  ";
                        string d = "D) işyeri karşıda olan";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) aracı tamirde olan      B) evi uzak olan");
                        Console.WriteLine("C) gözden ırak olan        D) işyeri karşıda olan");

                        soru_C(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }

                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 3

                else if (rastgele == 3)
                {
                    if (s3 == 0)
                    {
                        s3 = 1;
                        sayi = sayi + 1;
                        string soru = "Gıpgıcır ne anlama gelir ?";
                        string a = "A) yepyeni";
                        string b = "B) tozpembe";
                        string c = "C) sapsarı";
                        string d = "D) çok eski";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) yepyeni     B) tozpembe");
                        Console.WriteLine("C) sapsarı     D) çok eski");

                        soru_A(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 4

                else if (rastgele == 4)
                {
                    if (s4 == 0)
                    {
                        s4 = 1;
                        sayi = sayi + 1;
                        string soru = "Trafikte hangi araçların arkasında Dolu ya da Boş yazar ?";
                        string a = "A) Akaryekıt tankeri";
                        string b = "B) Öğrenci servisi";
                        string c = "C) Harfiyat kamyonu ";
                        string d = "D) Yolcu otobüsü";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) Akaryekıt tankeri     B) Öğrenci servisi");
                        Console.WriteLine("C) Harfiyat kamyonu      D) Yolcu otobüsü");

                        soru_A(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 5

                else if (rastgele == 5)
                {
                    if (s5 == 0)
                    {
                        s5 = 1;
                        sayi = sayi + 1;

                        string soru = "uyuyamadım anlamındaki söz hangisidir ?";
                        string a = "A) uyku atmadı  ";
                        string b = "B) uyku tutmadı";
                        string c = "C) uyku kalkmadı";
                        string d = "D) uyku yatmadı";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) uyku atmadı        B) uyku tutmadı");
                        Console.WriteLine("C) uyku kalkmadı      D) uyku yatmadı");

                        soru_B(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 6         6-11 arası zorluk 2

                else if (rastgele == 6)
                {
                    if (s6 == 0)
                    {
                        s6 = 1;
                        sayi = sayi + 1;
                        string soru = "Hangisi, internetten video izlerken en sık karşılaşılan görüntü modlarından biri değildir ?";
                        string a = "A) 360p";
                        string b = "B) 480p";
                        string c = "C) 640p";
                        string d = "D) 720p";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) 360p                   B) 480p");
                        Console.WriteLine("C) 640p                   D) 720p");

                        soru_C(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 7

                else if (rastgele == 7)
                {
                    if (s7 == 0)
                    {
                        s7 = 1;
                        sayi = sayi + 1;
                        string soru = "iki dirhem bir çekirdek ifadesi kimler için kullanılır ?";
                        string a = "A) güzel ve özenli giyinenler için";
                        string b = "B) az ve seyrek yiyenler için";
                        string c = "C) çok ve bol yiyenler için       ";
                        string d = "D) güçlü ve kaslı olanlar için";
                        Console.WriteLine("soru {0}:", sayi);

                        Console.WriteLine(soru);
                        Console.WriteLine("A) güzel ve özenli giyinenler için                   B) az ve seyrek yiyenler için");
                        Console.WriteLine("C) az ve seyrek yiyenler için                        D) güçlü ve kaslı olanlar için");

                        soru_A(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }

                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 8

                else if (rastgele == 8)
                {
                    if (s8 == 0)
                    {
                        s8 = 1;
                        sayi = sayi + 1;
                        string soru = "Kuruluşların internet sitelerinde, sosyal medya hesaplarının paylaşıldığı sayfanın başlığı genellikle hangisi olur ?";
                        string a = "A) bizi idare edin";
                        string b = "B) bizi merak edin";
                        string c = "C) bizi ihbar edin";
                        string d = "D) bizi takip edin";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) bizi idare edin                  B) bizi merak edin");
                        Console.WriteLine("C) bizi ihbar edin                  D) bizi takip edin");

                        soru_D(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }

                }

                //soru 9

                else if (rastgele == 9)
                {
                    if (s9 == 0)
                    {
                        s9 = 1;
                        sayi = sayi + 1;
                        string soru = "Bir varmış bir yokmuş diyerek anlatılmaya başlanan genellikle hangisi olur ?";
                        string a = "A) masal";
                        string b = "B) özgeçmiş";
                        string c = "C) sunum";
                        string d = "D) bilimsel makale";
                        Console.WriteLine("soru {0}:", sayi);

                        Console.WriteLine(soru);
                        Console.WriteLine("A) masal                      B) sunum");
                        Console.WriteLine("C) özgeçmiş                   D) bilimsel makale");

                        soru_A(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 10

                else if (rastgele == 10)
                {
                    if (s10 == 0)
                    {
                        s10 = 1;
                        sayi = sayi + 1;
                        string soru = "Genellikle güneşten korunmak için bir yerin üzerine gerilen, bez veya naylondan yapılmış örtüye ne ad verilir ?";
                        string a = "A) Tente ";
                        string b = "B) Marley";
                        string c = "C) Lambri";
                        string d = "D) Laminant";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) Tente                   B) Marley");
                        Console.WriteLine("C) Lambri                  D) Laminant");

                        soru_A(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 11       11-16 arası zorluk 3

                else if (rastgele == 11)
                {
                    if (s11 == 0)
                    {
                        s11 = 1;
                        sayi = sayi + 1;
                        string soru = "Bezekçi hangisinin diğer adıdır ?";
                        string a = "A) hattat";
                        string b = "B) sarraf";
                        string c = "C) nakkaş";
                        string d = "D) hallaç";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) hattat                  B) sarraf");
                        Console.WriteLine("C) nakkaş                  D) hallaç");

                        soru_C(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 12

                else if (rastgele == 12)
                {
                    if (s12 == 0)
                    {
                        s12 = 1;
                        sayi = sayi + 1;
                        string soru = "Patates cipsi paketleri, içinde cipslerin taze kalması için genellikle hangi gazla doldurulur ?";
                        string a = "A) oksijen";
                        string b = "B) hidrojen";
                        string c = "C) helyum";
                        string d = "D) azot";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) oksijen                  B) hidrojen");
                        Console.WriteLine("C) helyum                   D) azot");

                        soru_D(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 13

                else if (rastgele == 13)
                {
                    if (s13 == 0)
                    {
                        s13 = 1;
                        sayi = sayi + 1;
                        string soru = "Dal sarkar kartal kalkar şeklinde biten tekerlemenin başı nasıldır ?";
                        string a = "A) Kartal uçar dal sarkar  ";
                        string b = "B) Kartal kalkar dal düşer";
                        string c = "C) Kartal kalkar dal sarkar";
                        string d = "D) kartal uçar dal düşer";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) Kartal uçar dal sarkar                    B) Kartal kalkar dal düşer");
                        Console.WriteLine("C) Kartal kalkar dal sarkar                  D) kartal uçar dal düşer");

                        soru_C(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }

                }

                //soru 14

                else if (rastgele == 14)
                {
                    if (s14 == 0)
                    {
                        s14 = 1;
                        sayi = sayi + 1;

                        string soru = "Klasik bir çengel bulmacada, bir kutucukta en fazla kaç farklı soru sorulur ?";
                        string a = "     A) 1";
                        string b = "B) 2";
                        string c = "     C) 3";
                        string d = "D) 4";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("     A) 1                   B) 2");
                        Console.WriteLine("     C) 3                   D) 4");

                        soru_B(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 15

                else if (rastgele == 15)
                {
                    if (s15 == 0)
                    {
                        s15 = 1;
                        sayi = sayi + 1;
                        string soru = "Hangi kelime kalınca bükülmüş ipek iplik anlamına gelir?";
                        string a = "A) ibrik";
                        string b = "B) ilmik";
                        string c = "C) meşin";
                        string d = "D) ibrişim";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) ibrik                   B) ilmik");
                        Console.WriteLine("C) meşin                   D) ibrişim");

                        soru_D(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 16       16-21 arası zorluk 4

                else if (rastgele == 16)
                {
                    if (s16 == 0)
                    {
                        s16 = 1;
                        sayi = sayi + 1;
                        string soru = "Winnie the Poth adlı çizgi filmde sürekli olarak mutsuz ve üzgün olan Eoyore karakteri hangi hayvandır ?";
                        string a = "A) baykuş";
                        string b = "B) eşek";
                        string c = "C) kalpan";
                        string d = "D) ayı";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) baykuş                   B) eşek");
                        Console.WriteLine("C) kaplan                   D) ayı");

                        soru_B(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 17       

                else if (rastgele == 17)
                {
                    if (s17 == 0)
                    {
                        s17 = 1;
                        sayi = sayi + 1;
                        string soru = "Ming Hanedanlığı günümüzde hangi ülkenin bulunduğu toprakları yönetmiştir ?";
                        string a = "A) hindistan";
                        string b = "B) çin";
                        string c = "C) ukrayna  ";
                        string d = "D) iran";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) hindistan                   B) çin");
                        Console.WriteLine("C) ukrayna                     D) iran");

                        soru_B(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 18

                else if (rastgele == 18)
                {
                    if (s18 == 0)
                    {
                        s18 = 1;
                        sayi = sayi + 1;
                        string soru = "Hangisi için notere gidlir?";
                        string a = "A) ikametgah belgesi almak için";
                        string b = "B) vekalet çıkartmak için";
                        string c = "C) temiz kağıdı almak için     ";
                        string d = "D) pasaport yenilemek için";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) ikametgah belgesi almak için                   B) vekalet çıkartmak için");
                        Console.WriteLine("C) temiz kağıdı almak için                        D) pasaport yenilemek için");

                        soru_B(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 19

                else if (rastgele == 19)
                {
                    if (s19 == 0)
                    {
                        s19 = 1;
                        sayi = sayi + 1;
                        string soru = "Pizzaya en yakıştırdığım malzeme ançüezdir cümlesinde adı geçen ançüez hangisinden yapılan bir ezme çeşididir?";
                        string a = "A) mantar";
                        string b = "B) tavuk";
                        string c = "C) balık";
                        string d = "D) mısır";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) mantar                   B) tavuk");
                        Console.WriteLine("C) balık                    D) mısır");

                        soru_C(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 20

                else if (rastgele == 20)
                {
                    if (s20 == 0)
                    {
                        s20 = 1;
                        sayi = sayi + 1;
                        string soru = "Tarih boyunca İngiltere tahtına hangi adda bir kral çıkmamıştır ?";
                        string a = "A) arthur";
                        string b = "B) richard";
                        string c = "C) henry";
                        string d = "D) george";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) arthur                   B) richard");
                        Console.WriteLine("C) henry                    D) george");

                        soru_A(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 21       21-26 arası zorluk 5

                else if (rastgele == 21)
                {
                    if (s21 == 0)
                    {
                        s21 = 1;
                        sayi = sayi + 1;
                        string soru = "Göktırmalayan hangisinin diğer adıdır?";
                        string a = "gökkuşağı";
                        string b = "gök gürültüsü";
                        string c = "gökdelen ";
                        string d = "göktaşı";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) gökkuşağı                   B) gök gürültüsü");
                        Console.WriteLine("C) gökdelen                    D) göktaşı");

                        soru_C(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 22

                else if (rastgele == 22)
                {
                    if (s22 == 0)
                    {
                        s22 = 1;
                        sayi = sayi + 1;
                        string soru = "Bir eşyayı tepe tepe kullanan biri, onu nasıl kullanmış olur?";
                        string a = "nazikçe ";
                        string b = "dikkatlice";
                        string c = "hoyratça";
                        string d = "esirgeyerek";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) nazikçe                   B) dikkatlice");
                        Console.WriteLine("C) hoyratça                  D) esirgeyerek");

                        soru_C(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 23

                else if (rastgele == 23)
                {
                    if (s23 == 0)
                    {
                        s23 = 1;
                        sayi = sayi + 1;
                        string soru = "Türkiye'de bir yerin posta kodunun ilk iki rakamı, oranın nesiyle aynıdır ?";
                        string a = "telefon koduyla";
                        string b = "PUK dokuyla";
                        string c = "plaka koduyla";
                        string d = "ülke koduyla   ";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) telefon koduyla                   B) PUK koduyla");
                        Console.WriteLine("C) plaka koduyla                     D) ülke koduyla");

                        soru_C(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 24

                else if (rastgele == 24)
                {
                    if (s24 == 0)
                    {
                        s24 = 1;
                        sayi = sayi + 1;
                        string soru = "Kuşları inceleyen bilim dalı hangisidir ?";
                        string a = "paleontoloji";
                        string b = "arkeoloji";
                        string c = "etimoloji";
                        string d = "ornitoloji ";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) paleontoloji                  B) arkeoloji");
                        Console.WriteLine("C) etimoloji                     D) ornitoloji");

                        soru_D(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

                //soru 25

                else if (rastgele == 25)
                {
                    if (s25 == 0)
                    {
                        s25 = 1;
                        sayi = sayi + 1;
                        string soru = "Hangisinin hem -İsviçre- hem de -Sürmene- işi olanları meşhurdur ?";
                        string a = "hamsili pilav";
                        string b = "kol saati";
                        string c = "çikolata     ";
                        string d = "çakı";
                        Console.WriteLine("soru {0}:", sayi);
                        Console.WriteLine(soru);
                        Console.WriteLine("A) hamsili pilav                B) kol saati");
                        Console.WriteLine("C) çikolata                     D) çakı");

                        soru_D(ref over, ref sayi, ref para, ref rastgele, ref dogru, ref soru, ref a, ref b, ref c, ref d);
                    }
                    else
                    {
                        goto tekrar;
                    }
                }
            }
        over:
            yanlis = sayi - dogru;
            Console.WriteLine("\n");
            Console.WriteLine("yarışmacı adı soyadı: {0} {1}", isim, soyisim);
            Console.WriteLine("\ndoğru sayınız: {0} // yanlış sayınız: {1}\n", dogru, yanlis);
            Console.WriteLine("\nkazanılan ödül: {0} TL\n", para);

            Console.Read();
        }
    }
}
