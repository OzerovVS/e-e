//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.ConstrainedExecution;
//using System.Text;
//using System.Threading.Tasks;

//namespace trts
//{
//    internal class l
//    {
//        public static List<char> a0;
//        public static List<char> a1;
//        public static List<char> a2;
//        public static List<char> a3;
//        public static string b;
//        public static string c;
//        public static string d;
//        public static string f;
//        private List<char> tt(string b)
//        {
//            return b.ToCharArray().ToList();
//        }
//        public void pris()
//        {
//            a0 = tt(b);
//            a1 = tt(c);
//            a2 = tt(d);
//            a3 = tt(f);
//        }
//        public static void t2()
//        {
//            Console.SetCursorPosition(0, 0);
//            for (int i = 0; i < a0.Count; i++)
//            {
//                Console.Write(a0[i]);
//            }
//            Console.SetCursorPosition(0, 1);
//            for (int i = 0; i < a1.Count; i++)
//            {
//                Console.Write(a1[i]);
//            }
//            Console.SetCursorPosition(0, 2);
//            for (int i = 0; i < a2.Count; i++)
//            {
//                Console.Write(a2[i]);
//            }
//            Console.SetCursorPosition(0, 3);
//            for (int i = 0; i < a3.Count; i++)
//            {
//                Console.Write(a3[i]);
//            }
//        }
//        public int tyt(int pos, List<char> a,int h)
//        {
//            char g;
//            ConsoleKeyInfo aa;
//            do
//            {
//                Console.SetCursorPosition(0, pos);
//                aa = Console.ReadKey();
//                if (aa.Key == ConsoleKey.Backspace)
//                {
//                    a = a.SkipLast(1).ToList();
//                }
//                if (aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.J || aa.Key == ConsoleKey.H || aa.Key == ConsoleKey.G || aa.Key == ConsoleKey.F || aa.Key == ConsoleKey.D || aa.Key == ConsoleKey.S || aa.Key == ConsoleKey.A || aa.Key == ConsoleKey.Q || aa.Key == ConsoleKey.W || aa.Key == ConsoleKey.E || aa.Key == ConsoleKey.R || aa.Key == ConsoleKey.T || aa.Key == ConsoleKey.Y || aa.Key == ConsoleKey.U || aa.Key == ConsoleKey.I || aa.Key == ConsoleKey.O || aa.Key == ConsoleKey.P || aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.Z || aa.Key == ConsoleKey.L || aa.Key == ConsoleKey.X || aa.Key == ConsoleKey.C || aa.Key == ConsoleKey.B || aa.Key == ConsoleKey.V || aa.Key == ConsoleKey.N || aa.Key == ConsoleKey.M || aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.Oem4 || aa.Key == ConsoleKey.Oem6 || aa.Key == ConsoleKey.Oem5 || aa.Key == ConsoleKey.Oem7 || aa.Key == ConsoleKey.OemPeriod || aa.Key == ConsoleKey.OemComma || aa.Key == ConsoleKey.D0 || aa.Key == ConsoleKey.D1 || aa.Key == ConsoleKey.D2 || aa.Key == ConsoleKey.D3 || aa.Key == ConsoleKey.D4 || aa.Key == ConsoleKey.D5 || aa.Key == ConsoleKey.D6 || aa.Key == ConsoleKey.D7 || aa.Key == ConsoleKey.D8 || aa.Key == ConsoleKey.D9 || aa.Key == ConsoleKey.Oem3 || aa.Key == ConsoleKey.Oem1)
//                {
//                    g = aa.KeyChar;
//                    a.Add(g);
//                }

//            } while (aa.Key != ConsoleKey.UpArrow || aa.Key != ConsoleKey.DownArrow);
//            if (aa.Key == ConsoleKey.UpArrow)
//            {
//                pos--;
//                if (pos < 0)
//                {
//                    pos++;
//                }
//            }
//            if (aa.Key == ConsoleKey.DownArrow)
//            {
//                pos++;
//                if (pos > 3)
//                {
//                    pos--;
//                }
//            }
//            switch (h)
//            {
//                case 1:
//                    pr1(a);
//                    break;
//                case 2:
//                    pr2(a);
//                    break;
//                case 3:
//                    pr3(a);
//                    break;
//                case 4:
//                    pr4(a);
//                    break;
//            }
//            return pos;
//        }
//        void pr1(List<char> a)
//        {
//            a0 = a;
//        }
//        void pr2(List<char> a)
//        {
//            a1 = a;
//        }
//        void pr3(List<char> a)
//        {
//            a2 = a;
//        }
//        void pr4(List<char> a)
//        {
//            a3 = a;
//        }
//        public void prsv(figurs fig)
//        {
//            fig = new figurs();
//            b = fig.figura1;
//            c = fig.figura2;
//            d = fig.figura3;
//            f = fig.figura4;
//        }
//    }
//    internal class figurs
//    {
//        public string figura1;
//        public string figura2;
//        public string figura3;
//        public string figura4;
//    }
//}

using Newtonsoft;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace trts
{
    internal class osn
    {
        public static void deserializaciya(string sslka)
        {
            if (sslka.Contains("txt"))
            {
                List<fig> figs = new List<fig>();
                string[] figi = File.ReadAllLines(sslka);
                for (int i = 0; i < figi.Length; i+=4)
                {
                    fig a = new fig();
                    a.f1 = figi[i];
                    a.f2 = figi[i + 1];
                    a.f3 = figi[i + 2];
                    a.f4 = figi[i + 3];
                    figs.Add(a);
                    List<char> a1 = fr(a.f1);
                    List<char> a2 = fr(a.f2);
                    List<char> a3 = fr(a.f3);
                    List<char> a4 = fr(a.f4);
                    List<char> fr(string a)
                    {
                        List<char> b = a.ToCharArray().ToList();
                        return b;
                    }
                    int pos = 2;
                    char g;
                    ConsoleKeyInfo aa;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine($"Для перехода в режим редактирования нажмите F4, для выхода из этого режима - F10," +
                            $"\nСериализовать в .xml файл - F2,Сериализовать в .json файл - F3");
                        Console.SetCursorPosition(0, pos);
                        gg(a1, a2, a3, a4);
                        Console.SetCursorPosition(0, pos);
                        aa = Console.ReadKey();
                        ConsoleKeyInfo aaaa;
                        if (aa.Key == ConsoleKey.F4)
                        {
                            do
                            {
                                Console.SetCursorPosition(0, pos);
                                aaaa = Console.ReadKey();
                                if (aaaa.Key == ConsoleKey.K || aa.Key == ConsoleKey.J || aa.Key == ConsoleKey.H || aa.Key == ConsoleKey.G || aa.Key == ConsoleKey.F || aa.Key == ConsoleKey.D || aa.Key == ConsoleKey.S || aa.Key == ConsoleKey.A || aa.Key == ConsoleKey.Q || aa.Key == ConsoleKey.W || aa.Key == ConsoleKey.E || aa.Key == ConsoleKey.R || aa.Key == ConsoleKey.T || aa.Key == ConsoleKey.Y || aa.Key == ConsoleKey.U || aa.Key == ConsoleKey.I || aa.Key == ConsoleKey.O || aa.Key == ConsoleKey.P || aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.Z || aa.Key == ConsoleKey.L || aa.Key == ConsoleKey.X || aa.Key == ConsoleKey.C || aa.Key == ConsoleKey.B || aa.Key == ConsoleKey.V || aa.Key == ConsoleKey.N || aa.Key == ConsoleKey.M || aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.Oem4 || aa.Key == ConsoleKey.Oem6 || aa.Key == ConsoleKey.Oem5 || aa.Key == ConsoleKey.Oem7 || aa.Key == ConsoleKey.OemPeriod || aa.Key == ConsoleKey.OemComma || aa.Key == ConsoleKey.D0 || aa.Key == ConsoleKey.D1 || aa.Key == ConsoleKey.D2 || aa.Key == ConsoleKey.D3 || aa.Key == ConsoleKey.D4 || aa.Key == ConsoleKey.D5 || aa.Key == ConsoleKey.D6 || aa.Key == ConsoleKey.D7 || aa.Key == ConsoleKey.D8 || aa.Key == ConsoleKey.D9 || aa.Key == ConsoleKey.Oem3 || aa.Key == ConsoleKey.Oem1)
                                {
                                    switch (pos)
                                    {
                                        case 2:
                                            g = aa.KeyChar;
                                            a1.Add(g);
                                            break;
                                        case 3:
                                            g = aa.KeyChar;
                                            a2.Add(g);
                                            break;
                                        case 4:
                                            g = aa.KeyChar;
                                            a3.Add(g);
                                            break;
                                        case 5:
                                            g = aa.KeyChar;
                                            a4.Add(g);
                                            break;

                                    }
                                }
                                else if (aaaa.Key == ConsoleKey.Backspace)
                                {
                                    switch (pos)
                                    {
                                        case 2:
                                            a1 = a1.SkipLast(1).ToList();
                                            break;
                                        case 3:
                                            a2 = a2.SkipLast(1).ToList();
                                            break;
                                        case 4:
                                            a3 = a3.SkipLast(1).ToList();
                                            break;
                                        case 5:
                                            a4 = a4.SkipLast(1).ToList();
                                            break;
                                    }
                                }
                                else if (aaaa.Key == ConsoleKey.DownArrow)
                                {
                                    pos++;
                                    if (pos > 5)
                                    {
                                        pos--;
                                    }
                                }
                                else if (aaaa.Key == ConsoleKey.UpArrow)
                                {
                                    pos--;
                                    if (pos < 2)
                                    {
                                        pos++;
                                    }
                                }
                                Console.Clear();
                                Console.WriteLine($"Для перехода в режим редактирования нажмите F4, для выхода из этого режима - F10," +
                                $"\nСериализовать в .xml файл - F2,Сериализовать в .json файл - F3");
                                gg(a1, a2, a3, a4);
                            } while (aaaa.Key != ConsoleKey.F10);
                        }
                        else if (aa.Key != ConsoleKey.F2 || aa.Key != ConsoleKey.F3 || aa.Key != ConsoleKey.F4)
                            break;
                    } while (aa.Key != ConsoleKey.F2 || aa.Key != ConsoleKey.F3 || aa.Key != ConsoleKey.F4);
                    switch (aa.Key)
                    {
                        case ConsoleKey.F2:
                            break;
                        case ConsoleKey.F3:
                            fig com1 = new fig();
                            com1.f1 = String.Concat(a1);
                            com1.f2 = String.Concat(a2);
                            com1.f3 = String.Concat(a3);
                            com1.f4 = String.Concat(a4);
                            List<fig> figurr = new List<fig> { };
                            figurr.Add(com1);
                            string json = JsonConvert.SerializeObject(figurr);
                            File.WriteAllText("C:\\Users\\user\\Desktop\\Result.json", json);
                            break;
                    }
                }


            }
            if (sslka.Contains("json"))
            {

            }
            if (sslka.Contains("xml"))
            {

            }
        }
        static void gg(List<char> a, List<char> b, List<char> c, List<char> d)
        {
            Console.SetCursorPosition(0, 2);
            foreach (char name in a)
            {
                Console.Write(name);
            }
            Console.SetCursorPosition(0, 3);
            foreach (char name in b)
            {
                Console.Write(name);
            }
            Console.SetCursorPosition(0, 4);
            foreach (char name in c)
            {
                Console.Write(name);
            }
            Console.SetCursorPosition(0, 5);
            foreach (char name in d)
            {
                Console.Write(name);
            }

        }
    }
    internal class fig
    {
        public string f1;
        public string f2;
        public string f3;
        public string f4;
    }
}