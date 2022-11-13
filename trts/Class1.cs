using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace trts
{
    internal class l
    {
        public static List<char> a0;
        public static List<char> a1;
        public static List<char> a2;
        public static List<char> a3;
        static string b = "Прямоугольник";
        static string c = "Треугольник";
        static string d = "Четырехугольник";
        static string f = "Круг";
        private static List<char> tt(string b)
        {
            char[] bb = b.ToCharArray();
            List<char> a = new List<char> { };
            for (int i = 0; i < bb.Length; i++)
            {
                a.Add(bb[i]);
            }
            return a;
        }
        public static void pris()
        {
            a0 = tt(b);
            a1 = tt(c);
            a2 = tt(d);
            a3 = tt(f);
        }
        public static void t2()
        {
            Console.WriteLine($"Отредактируйте текст, если хотите или нажмите Enter, а затем выберите во что хотите перевести");
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < a0.Count; i++)
            {
                Console.Write(a0[i]);
            }
            Console.SetCursorPosition(0, 1);
            for (int i = 0; i < a1.Count; i++)
            {
                Console.Write(a1[i]);
            }
            Console.SetCursorPosition(0, 2);
            for (int i = 0; i < a2.Count; i++)
            {
                Console.Write(a2[i]);
            }
            Console.SetCursorPosition(0, 3);
            for (int i = 0; i < a3.Count; i++)
            {
                Console.Write(a3[i]);
            }
        }
        public static int tyt(int pos, List<char> a,int h)
        {
            char g;
            ConsoleKeyInfo aa;
            do
            {
                Console.SetCursorPosition(0, pos);
                aa = Console.ReadKey();
                if (aa.Key == ConsoleKey.Backspace)
                {
                    a = a.SkipLast(1).ToList();
                }
                if (aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.J || aa.Key == ConsoleKey.H || aa.Key == ConsoleKey.G || aa.Key == ConsoleKey.F || aa.Key == ConsoleKey.D || aa.Key == ConsoleKey.S || aa.Key == ConsoleKey.A || aa.Key == ConsoleKey.Q || aa.Key == ConsoleKey.W || aa.Key == ConsoleKey.E || aa.Key == ConsoleKey.R || aa.Key == ConsoleKey.T || aa.Key == ConsoleKey.Y || aa.Key == ConsoleKey.U || aa.Key == ConsoleKey.I || aa.Key == ConsoleKey.O || aa.Key == ConsoleKey.P || aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.Z || aa.Key == ConsoleKey.L || aa.Key == ConsoleKey.X || aa.Key == ConsoleKey.C || aa.Key == ConsoleKey.B || aa.Key == ConsoleKey.V || aa.Key == ConsoleKey.N || aa.Key == ConsoleKey.M || aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.Oem4 || aa.Key == ConsoleKey.Oem6 || aa.Key == ConsoleKey.Oem5 || aa.Key == ConsoleKey.Oem7 || aa.Key == ConsoleKey.OemPeriod || aa.Key == ConsoleKey.OemComma || aa.Key == ConsoleKey.D0 || aa.Key == ConsoleKey.D1 || aa.Key == ConsoleKey.D2 || aa.Key == ConsoleKey.D3 || aa.Key == ConsoleKey.D4 || aa.Key == ConsoleKey.D5 || aa.Key == ConsoleKey.D6 || aa.Key == ConsoleKey.D7 || aa.Key == ConsoleKey.D8 || aa.Key == ConsoleKey.D9 || aa.Key == ConsoleKey.Oem3 || aa.Key == ConsoleKey.Oem1)
                {
                    g = aa.KeyChar;
                    a.Add(g);
                }

            } while (aa.Key != ConsoleKey.UpArrow || aa.Key != ConsoleKey.DownArrow);
            if (aa.Key == ConsoleKey.UpArrow)
            {
                pos--;
                if (pos < 0)
                {
                    pos++;
                }
            }
            if (aa.Key == ConsoleKey.DownArrow)
            {
                pos++;
                if (pos > 3)
                {
                    pos--;
                }
            }
            switch (h)
            {
                case 1:
                    pr1(a);
                    break;
                case 2:
                    pr2(a);
                    break;
                case 3:
                    pr3(a);
                    break;
                case 4:
                    pr4(a);
                    break;
            }
            return pos;
        }
        static void pr1(List<char> a)
        {
            a0 = a;
        }
        static void pr2(List<char> a)
        {
            a1 = a;
        }
        static void pr3(List<char> a)
        {
            a2 = a;
        }
        static void pr4(List<char> a)
        {
            a3 = a;
        }
    }
    internal class figurs
    {
        string figura1;
        string figura2;
        string figura3;
        string figura4;
    }
}
