using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace media.player
{                                                   
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer ses = new SoundPlayer();
            Random rastgele = new Random();
            int buyukluk = 17;
            int dk, dk2, saniye, saniye2 ;
            int sayi = 1;
            int ek_dk=0, ek_saniye=0;
            string degisim;
            int oynat=1;
            //şarkı yolları belirle

            string[] yol = new string[buyukluk];
            yol[0] = @"C:\Users\guven\Desktop\müzik\medya player\Ahmet Kaya - Adı Bahtiyar.wav";
            yol[1] = @"C:\Users\guven\Desktop\müzik\medya player\Ahmet Kaya - Ağladıkça.wav";
            yol[2] = @"C:\Users\guven\Desktop\müzik\medya player\Ahmet Kaya - Benden Selam Söyleyin.wav";
            yol[3] = @"C:\Users\guven\Desktop\müzik\medya player\Ahmet Kaya - Korkarım.wav";
            yol[4] = @"C:\Users\guven\Desktop\müzik\medya player\Ahmet Kaya - Nereden Bileceksiniz.wav";
            yol[5] = @"C:\Users\guven\Desktop\müzik\medya player\Ahmet-Kaya-Daglarda-Kar-Olsaydim.wav";
            yol[6] = @"C:\Users\guven\Desktop\müzik\medya player\Akın - Anlatamıyorum.wav";
            yol[7] = @"C:\Users\guven\Desktop\müzik\medya player\Azer Bülbül - Bu Gece Karakolluk Olabilirim.wav";
            yol[8] = @"C:\Users\guven\Desktop\müzik\medya player\Azer Bülbül - Duygularım.wav";
            yol[9] = @"C:\Users\guven\Desktop\müzik\medya player\Cem Adrian - feat Zeynep Karababa-Akşam Olur Karanlığa Kalırsın.wav";
            yol[10] = @"C:\Users\guven\Desktop\müzik\medya player\cem-adrian-ah-bu-sarkilarin-gozu-kor-olsun-ft-hande-mehan.wav";
            yol[11] = @"C:\Users\guven\Desktop\müzik\medya player\HiraiZerdüş - Gitme Aklım Sende Kalır.wav";
            yol[12] = @"C:\Users\guven\Desktop\müzik\medya player\HiraiZerdüş - İçime Sevda Kaçar.wav";
            yol[13] = @"C:\Users\guven\Desktop\müzik\medya player\HiraiZerdüş - İki Günlük Dünya.wav";
            yol[14] = @"C:\Users\guven\Desktop\müzik\medya player\Muslum-Gurses-Adini-Sen-Koy-(Funda-Arar).wav";
            yol[15] = @"C:\Users\guven\Desktop\müzik\medya player\Müzeyyen Senar - Elbet Birgün Buluşacağız.wav";
            yol[16] = @"C:\Users\guven\Desktop\müzik\medya player\Bir kadın seni seviyorsa sana aittir.wav";

            //ekran görünümü
            
            Console.WriteLine("*************************************************************");
            Console.WriteLine("**                        şarkılar                         **");
            Console.WriteLine("*************************************************************");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("**  1)      ahmet kaya --- adı bahtiyar                    **");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("**  2)      ahmet kaya --- ağladıkça                       **");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("**  3)      ahmet kaya --- benden selam söyleyin           **");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("**  4)      ahmet kaya --- korkarım                        **");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("**  5)      ahmet kaya --- nereden bileceksiniz            **");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("**  6)      ahmet kaya --- dağlarda kar olsaydım           **");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("**  7)            akın --- anlatamıyorum                   **");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("**  8)     azer bülbül --- karakolluk olabilrim            **");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("**  9)     azer bülbül --- duygularım                      **");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("**  10)     cem adrian --- akşam olur karanlığa kalırsın   **");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("**  11)     cem adrian --- ah bu şarkıların gözü kör olsun **");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("**  12)   hiraizerfüşt --- gitme aklım sende kalır         **");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("**  13)   hiraizerdüşt --- içime sewvda kaçar              **");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("**  14)   hiraizerdüşt --- iki günlük dünya                **");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("**  15)  müslüm gürses --- adını sen koy                   **");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("**  16) müzeyyen senar --- elbet bir gün buluşacağız       **");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("**  17)         amatör --- bir kadın seni seviyorsa        **");
            Console.WriteLine("**                                                         **");
            Console.WriteLine("*************************************************************");
        tekrar2:

            Console.Write("lütfen şarkı numarası girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > buyukluk || sayi < 1)
            {
                Console.WriteLine("\n");
                goto tekrar2;
            }
            Console.WriteLine("oynatma durumu: sıralı ");
            Console.Write("değiştirmek ister misiniz(evet=e): ");
            degisim = Console.ReadLine();
            if(degisim=="e"|| degisim == "E")
            {
                Console.WriteLine("dyeni oynatma durumu giriniz:");
                Console.WriteLine("1) sıralı -- 2) terkar -- 3) karışık:");
                Console.Write("--> ");
                oynat = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                oynat = 1;
            }


            //şarkı süre belirle

            int[] sarki_dk = new int[buyukluk];
            int[] sarki_saniye = new int[buyukluk];

            sarki_dk[0] = 6; sarki_saniye[0] = 9;
            sarki_dk[1] = 4; sarki_saniye[1] = 42;
            sarki_dk[2] = 4; sarki_saniye[2] = 0;
            sarki_dk[3] = 4; sarki_saniye[3] = 54;
            sarki_dk[4] = 6; sarki_saniye[4] = 0;
            sarki_dk[5] = 6; sarki_saniye[5] = 9;
            sarki_dk[6] = 3; sarki_saniye[6] = 30;
            sarki_dk[7] = 5; sarki_saniye[7] = 2;
            sarki_dk[8] = 4; sarki_saniye[8] = 57;
            sarki_dk[9] = 5; sarki_saniye[9] = 5;
            sarki_dk[10] = 3; sarki_saniye[10] = 33;
            sarki_dk[11] = 2; sarki_saniye[11] = 31;
            sarki_dk[12] = 4; sarki_saniye[12] = 9;
            sarki_dk[13] = 5; sarki_saniye[13] = 15;
            sarki_dk[14] = 3; sarki_saniye[14] = 47;
            sarki_dk[15] = 5; sarki_saniye[15] = 47;
            sarki_dk[16] = 3; sarki_saniye[16] = 0;

        gec:


            for (int i = 0; i < buyukluk; i++)
            {
                if (sayi == i + 1)
                {
                    ek_dk = sarki_dk[i];
                    ek_saniye = sarki_saniye[i];
                }
            }

            //zaman test amaçlı süre tutma

            dk = DateTime.Now.Minute;
            saniye = DateTime.Now.Second;
            Console.WriteLine(dk + "    " + saniye);

            //zaman hesabı

            dk = dk + ek_dk;
            saniye = saniye + ek_saniye;
            if (saniye > 59)
            {
                saniye = saniye % 60;
                dk = dk + 1;
            }
            Console.WriteLine(dk+"    "+saniye);

            // çalınacak şarkının yolunu belirle
            for (int j = 0; j < buyukluk; j++)
            {
                if (sayi == j + 1)
                {
                    ses.SoundLocation = yol[j];
                }
            }

            //ses çalma sistemi

            ses.Play();

        tekrar:
            dk2 = DateTime.Now.Minute;
            saniye2 = DateTime.Now.Second;

            //oynatma durum listesi

            if (oynat==1)
            {
                if (dk == dk2 && saniye == saniye2)
                {
                    Console.WriteLine("şarkı geçiliyor");
                    sayi = sayi + 1;
                    if (sayi > buyukluk)
                    {
                        sayi = sayi % buyukluk;
                    }
                    goto gec;
                }
                else
                {
                    goto tekrar;
                }
            }
            if (oynat == 2)
            {
                if (dk == dk2 && saniye == saniye2)
                {
                    Console.WriteLine("şarkı tekrar ediliyor");
                    goto gec;
                }
                else
                {
                    goto tekrar;
                }
            }
            if (oynat == 3)
            {
                if (dk == dk2 && saniye == saniye2)
                {
                    Console.WriteLine("yeni şarkı yükleniyor");
                    sayi=rastgele.Next(1, 17);
                    goto gec;
                }
                else
                {
                    goto tekrar;
                }
            }

        }
    }
}
