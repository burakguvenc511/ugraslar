using System;

namespace XOXgame
{
    class Program
    {
        static void Main(string[] args)
        {
            int devam=0,secim,a=0;
            string gamer1, gamer2;
            char[,] arr = new char[3, 3];

            Console.Title = "XOX.exe";

            Console.Write("1. oyuncu adı girin: ");
            gamer1 = Console.ReadLine();
            Console.Write("2. oyuncu adı girin: ");
            gamer2 = Console.ReadLine();

            //diziler değer atama

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = ' ';
                }
            }

            Console.Clear();
            //çizim

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("+-----+-----+-----+"); Console.Write("|");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("  " + arr[i, j] + "  |");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("+-----+-----+-----+");

            //sonsuz döngü

            while (devam == 0)
            {

                //1. oyuncu kutu seçimi

            again:
                Console.Write("1. oyuncu {0} kutu seçin: ", gamer1);
                secim = Convert.ToInt16(Console.ReadLine());
                if (secim < 1 || secim > 9)
                {
                    Console.Write("hatalı seçim tekrar dene: ");
                    goto again;
                }

                //boş kutu olması

                if (secim == 1) { if (arr[2, 0] != 'X' && arr[2, 0] != 'O') { arr[2, 0] = 'X'; } else { goto again; } }
                if (secim == 2) { if (arr[2, 1] != 'X' && arr[2, 1] != 'O') { arr[2, 1] = 'X'; } else { goto again; } }
                if (secim == 3) { if (arr[2, 2] != 'X' && arr[2, 2] != 'O') { arr[2, 2] = 'X'; } else { goto again; } }
                if (secim == 4) { if (arr[1, 0] != 'X' && arr[1, 0] != 'O') { arr[1, 0] = 'X'; } else { goto again; } }
                if (secim == 5) { if (arr[1, 1] != 'X' && arr[1, 1] != 'O') { arr[1, 1] = 'X'; } else { goto again; } }
                if (secim == 6) { if (arr[1, 2] != 'X' && arr[1, 2] != 'O') { arr[1, 2] = 'X'; } else { goto again; } }
                if (secim == 7) { if (arr[0, 0] != 'X' && arr[0, 0] != 'O') { arr[0, 0] = 'X'; } else { goto again; } }
                if (secim == 8) { if (arr[0, 1] != 'X' && arr[0, 1] != 'O') { arr[0, 1] = 'X'; } else { goto again; } }
                if (secim == 9) { if (arr[0, 2] != 'X' && arr[0, 2] != 'O') { arr[0, 2] = 'X'; } else { goto again; } }

                Console.Clear();
                //çizim

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("+-----+-----+-----+"); Console.Write("|");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("  " + arr[i, j] + "  |");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("+-----+-----+-----+");

                //1. oyuncu kazanma

                if (arr[2, 0] == 'X' && arr[2, 1] == 'X' && arr[2, 2] == 'X') { Console.WriteLine("tebrikler kazanan {0} oyuncu", gamer1); goto son; }
                if (arr[1, 0] == 'X' && arr[1, 1] == 'X' && arr[1, 2] == 'X') { Console.WriteLine("tebrikler kazanan {0} oyuncu", gamer1); goto son; }
                if (arr[0, 0] == 'X' && arr[0, 1] == 'X' && arr[0, 2] == 'X') { Console.WriteLine("tebrikler kazanan {0} oyuncu", gamer1); goto son; }
                if (arr[0, 0] == 'X' && arr[1, 0] == 'X' && arr[2, 0] == 'X') { Console.WriteLine("tebrikler kazanan {0} oyuncu", gamer1); goto son; }
                if (arr[0, 1] == 'X' && arr[1, 1] == 'X' && arr[2, 1] == 'X') { Console.WriteLine("tebrikler kazanan {0} oyuncu", gamer1); goto son; }
                if (arr[0, 2] == 'X' && arr[1, 2] == 'X' && arr[2, 2] == 'X') { Console.WriteLine("tebrikler kazanan {0} oyuncu", gamer1); goto son; }
                if (arr[0, 0] == 'X' && arr[1, 1] == 'X' && arr[2, 2] == 'X') { Console.WriteLine("tebrikler kazanan {0} oyuncu", gamer1); goto son; }
                if (arr[0, 2] == 'X' && arr[1, 1] == 'X' && arr[2, 0] == 'X') { Console.WriteLine("tebrikler kazanan {0} oyuncu", gamer1); goto son; }

                //beraberlik durumu

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (arr[i, j] == 'X' || arr[i, j] == 'O')
                        {
                            a++;
                        }
                        if (a == 9)
                        {
                            Console.WriteLine("oyun berabere...");
                            goto son;
                        }
                    }
                }
                a = 0;

            //2. oyuncu kutu seçimi

            again1:
                Console.Write("2. oyuncu {0} kutu seçin: ", gamer2);
                secim = Convert.ToInt16(Console.ReadLine());
                if (secim < 1 || secim > 9)
                {
                    Console.Write("hatalı seçim tekrar dene: ");
                    goto again1;
                }

                //boş kutu olması

                if (secim == 1) { if (arr[2, 0] != 'X' && arr[2, 0] != 'O') { arr[2, 0] = 'O'; } else { goto again1; } }
                if (secim == 2) { if (arr[2, 1] != 'X' && arr[2, 1] != 'O') { arr[2, 1] = 'O'; } else { goto again1; } }
                if (secim == 3) { if (arr[2, 2] != 'X' && arr[2, 2] != 'O') { arr[2, 2] = 'O'; } else { goto again1; } }
                if (secim == 4) { if (arr[1, 0] != 'X' && arr[1, 0] != 'O') { arr[1, 0] = 'O'; } else { goto again1; } }
                if (secim == 5) { if (arr[1, 1] != 'X' && arr[1, 1] != 'O') { arr[1, 1] = 'O'; } else { goto again1; } }
                if (secim == 6) { if (arr[1, 2] != 'X' && arr[1, 2] != 'O') { arr[1, 2] = 'O'; } else { goto again1; } }
                if (secim == 7) { if (arr[0, 0] != 'X' && arr[0, 0] != 'O') { arr[0, 0] = 'O'; } else { goto again1; } }
                if (secim == 8) { if (arr[0, 1] != 'X' && arr[0, 1] != 'O') { arr[0, 1] = 'O'; } else { goto again1; } }
                if (secim == 9) { if (arr[0, 2] != 'X' && arr[0, 2] != 'O') { arr[0, 2] = 'O'; } else { goto again1; } }
               
                Console.Clear();
                //çizim

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("+-----+-----+-----+"); Console.Write("|");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("  " + arr[i, j] + "  |");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("+-----+-----+-----+");

                //2. oyuncu kazanma

                if (arr[2, 0] == 'O' && arr[2, 1] == 'O' && arr[2, 2] == 'O') { Console.WriteLine("tebrikler kazanan {0} oyuncu", gamer2); goto son; }
                if (arr[1, 0] == 'O' && arr[1, 1] == 'O' && arr[1, 2] == 'O') { Console.WriteLine("tebrikler kazanan {0} oyuncu", gamer2); goto son; }
                if (arr[0, 0] == 'O' && arr[0, 1] == 'O' && arr[0, 2] == 'O') { Console.WriteLine("tebrikler kazanan {0} oyuncu", gamer2); goto son; }
                if (arr[0, 0] == 'O' && arr[1, 0] == 'O' && arr[2, 0] == 'O') { Console.WriteLine("tebrikler kazanan {0} oyuncu", gamer2); goto son; }
                if (arr[0, 1] == 'O' && arr[1, 1] == 'O' && arr[2, 1] == 'O') { Console.WriteLine("tebrikler kazanan {0} oyuncu", gamer2); goto son; }
                if (arr[0, 2] == 'O' && arr[1, 2] == 'O' && arr[2, 2] == 'O') { Console.WriteLine("tebrikler kazanan {0} oyuncu", gamer2); goto son; }
                if (arr[0, 0] == 'O' && arr[1, 1] == 'O' && arr[2, 2] == 'O') { Console.WriteLine("tebrikler kazanan {0} oyuncu", gamer2); goto son; }
                if (arr[0, 2] == 'O' && arr[1, 1] == 'O' && arr[2, 0] == 'O') { Console.WriteLine("tebrikler kazanan {0} oyuncu", gamer2); goto son; }

                //beraberlik durumu

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (arr[i, j] == 'X' || arr[i, j] == 'O')
                        {
                            a++;
                        }
                        if (a == 9)
                        {
                            Console.WriteLine("oyun berabere...");
                            goto son;
                        }
                    }
                }
                a = 0;
            }

        son:
            Console.Read();
        }
    }
}