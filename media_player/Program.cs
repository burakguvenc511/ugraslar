using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace media_player
{
    class Program
    {
        static void Main(string[] args)
        {
            Random karisik = new Random();
            SoundPlayer ses = new SoundPlayer();
            string yol;
            int sayi;
            string[] muzik = new string[16];
            muzik[0] = "ahmet kaya      - adı bahtiyar";
            muzik[1] = "ahmet kaya      - ağladıkça";
            muzik[2] = "ahmet kaya      - benden selam söyleyin";
            muzik[3] = "ahmet kaya      - dağlarda kar olsaydım";
            muzik[4] = "ahmet kaya      - korkarım";
            muzik[5] = "ahmet kaya      - nereden bileceksiniz";
            muzik[6] = "akın            - anlatamıyorum";
            muzik[7] = "azer bülbül     - bu gece karakolluk olabilirim";
            muzik[8] = "azer bülbül     - duygularım";
            muzik[9] = "cem adrian      - akşam olur karanlığa kalırsın";
            muzik[10] = "cem adrian     - ah bu şarkıların gözü kör olsun";
            muzik[11] = "hirai zerdüşt  - gitme aklım sende kalır";
            muzik[12] = "hirai zerdüşt  - içime sevda kaçar";
            muzik[13] = "hirai zerdüşt  - iki günlük dünya";
            muzik[14] = "müslüm gürses  - adını sen koy";
            muzik[15] = "müzeyyen senar - elbet bir gün buluşacağız";

            Console.WriteLine("\tparçalar: ");
            Console.WriteLine("\n-----------------------\n");
            for (int i = 0; i < muzik.Length; i++)
            {
                Console.WriteLine(i + 1 + " ) " + muzik[i]);
            }

            Console.WriteLine("şarkı kapatmak için -10:");
            Console.WriteLine("çalma durumu: sıralı");
            Console.Write("başlamasını istediğiniz şarkı numarasınız girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            tekrar:
            switch (sayi)
            {
                case 1: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Ahmet Kaya - Adı Bahtiyar.wav"; ses.SoundLocation = yol; ses.Play(); break;
                case 2: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Ahmet Kaya - Ağladıkça.wav"; ses.SoundLocation = yol; ses.Play(); break;
                case 3: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Ahmet Kaya - Benden Selam Söyleyin.wav"; ses.SoundLocation = yol; ses.Play(); break;
                case 4: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\mp3indirdur-Ahmet-Kaya-Daglarda-Kar-Olsaydim.wav"; ses.SoundLocation = yol; ses.Play(); break;
                case 5: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Ahmet Kaya - Korkarım.wav"; ses.SoundLocation = yol; ses.Play(); break;
                case 6: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Ahmet Kaya - Nereden Bileceksiniz.wav"; ses.SoundLocation = yol; ses.Play(); break;
                case 7: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Akın - Anlatamıyorum.wav"; ses.SoundLocation = yol; ses.Play(); break;
                case 8: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Azer Bülbül - Bu Gece Karakolluk Olabilirim.wav"; ses.SoundLocation = yol; ses.Play(); break;
                case 9: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Azer Bülbül - Duygularım.wav"; ses.SoundLocation = yol; ses.Play(); break;
                case 10: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Cem Adrian - feat Zeynep Karababa-Akşam Olur Karanlığa Kalırsın.wav"; ses.SoundLocation = yol; ses.Play(); break;
                case 11: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\mp3indircol-cem-adrian-ah-bu-sarkilarin-gozu-kor-olsun-ft-hande-mehan.wav"; ses.SoundLocation = yol; ses.Play(); break;
                case 12: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\HiraiZerdüş - Gitme Aklım Sende Kalır.wav"; ses.SoundLocation = yol; ses.Play(); break;
                case 13: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\HiraiZerdüş - İçime Sevda Kaçar.wav"; ses.SoundLocation = yol; ses.Play(); break;
                case 14: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\HiraiZerdüş - İki Günlük Dünya.wav"; ses.SoundLocation = yol; ses.Play(); break;
                case 15: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\mp3indirdur-Muslum-Gurses-Adini-Sen-Koy-(Funda-Arar).wav"; ses.SoundLocation = yol; ses.Play(); break;
                case 16: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Müzeyyen Senar - Elbet Birgün Buluşacağız.wav"; ses.SoundLocation = yol; ses.Play(); break;
            }

            sayi = sayi + 1;
            if (sayi > muzik.Length)
            {
                sayi = sayi % muzik.Length;
            }
                switch (sayi)
                {
                    case 1: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Ahmet Kaya - Adı Bahtiyar.wav";                                                ses.SoundLocation = yol; ses.PlayLooping(); break;
                    case 2: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Ahmet Kaya - Ağladıkça.wav";                                                   ses.SoundLocation = yol; ses.PlayLooping(); break;
                    case 3: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Ahmet Kaya - Benden Selam Söyleyin.wav";                                       ses.SoundLocation = yol; ses.PlayLooping(); break;
                    case 4: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\mp3indirdur-Ahmet-Kaya-Daglarda-Kar-Olsaydim.wav";                             ses.SoundLocation = yol; ses.PlayLooping(); break;
                    case 5: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Ahmet Kaya - Korkarım.wav";                                                    ses.SoundLocation = yol; ses.PlayLooping(); break;
                    case 6: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Ahmet Kaya - Nereden Bileceksiniz.wav";                                        ses.SoundLocation = yol; ses.PlayLooping(); break;
                    case 7: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Akın - Anlatamıyorum.wav";                                                     ses.SoundLocation = yol; ses.PlayLooping(); break;
                    case 8: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Azer Bülbül - Bu Gece Karakolluk Olabilirim.wav";                              ses.SoundLocation = yol; ses.PlayLooping(); break;
                    case 9: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Azer Bülbül - Duygularım.wav";                                                 ses.SoundLocation = yol; ses.PlayLooping(); break;
                    case 10: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Cem Adrian - feat Zeynep Karababa-Akşam Olur Karanlığa Kalırsın.wav";         ses.SoundLocation = yol; ses.PlayLooping(); break;
                    case 11: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\mp3indircol-cem-adrian-ah-bu-sarkilarin-gozu-kor-olsun-ft-hande-mehan.wav";   ses.SoundLocation = yol; ses.PlayLooping(); break;
                    case 12: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\HiraiZerdüş - Gitme Aklım Sende Kalır.wav";                                   ses.SoundLocation = yol; ses.PlayLooping(); break;
                    case 13: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\HiraiZerdüş - İçime Sevda Kaçar.wav";                                         ses.SoundLocation = yol; ses.PlayLooping(); break;
                    case 14: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\HiraiZerdüş - İki Günlük Dünya.wav";                                          ses.SoundLocation = yol; ses.PlayLooping(); break;
                    case 15: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\mp3indirdur-Muslum-Gurses-Adini-Sen-Koy-(Funda-Arar).wav";                    ses.SoundLocation = yol; ses.PlayLooping(); break;
                    case 16: Console.WriteLine("şarkı açılıyor: {0}", muzik[sayi - 1]); yol = @"C:\Users\guven\Desktop\müzik\medya player\Müzeyyen Senar - Elbet Birgün Buluşacağız.wav";                               ses.SoundLocation = yol; ses.PlayLooping(); break;
                }
            sayi = sayi + 1;
            if (sayi > muzik.Length)
            {
                sayi = sayi % muzik.Length;
            }
            goto tekrar;
        }
    }
}
