char g;
int pos = 0;
int sop = 0;
string b = "Прямоугольник";
char[] bb = b.ToCharArray();
List<char> a = new List<char>();
for (int i = 0; i < bb.Length; i++)
{
    a.Add(bb[i]);
}
for (int i = 0; i < a.Count; i++)
{
    Console.Write(a[i]);
}
tt(a);
static void tt(List<char> a)
{
    ConsoleKeyInfo aa;
    char g;
    int pos = 0;
    int sop = 0;
    do
    {
        Console.SetCursorPosition(sop, pos);
        aa = Console.ReadKey();
        if (aa.Key == ConsoleKey.RightArrow)
        {
            sop++;
        }
        if (aa.Key == ConsoleKey.LeftArrow)
        {
            sop--;
            if (sop < 0)
            {
                sop = 0;
            }
        }
        if (aa.Key == ConsoleKey.UpArrow)
        {
            pos--;
            if (pos < 0)
            {
                pos = 0;
            }
        }
        if (aa.Key == ConsoleKey.DownArrow)
        {
            pos++;
        }
        if (aa.Key == ConsoleKey.Backspace)
        {
            a[sop] = ' ';
            sop--;
            if (sop < 0)
            {
                sop = 0;
            }
            Console.SetCursorPosition(sop, pos);
        }
        if (aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.J || aa.Key == ConsoleKey.H || aa.Key == ConsoleKey.G || aa.Key == ConsoleKey.F || aa.Key == ConsoleKey.D || aa.Key == ConsoleKey.S || aa.Key == ConsoleKey.A || aa.Key == ConsoleKey.Q || aa.Key == ConsoleKey.W || aa.Key == ConsoleKey.E || aa.Key == ConsoleKey.R || aa.Key == ConsoleKey.T || aa.Key == ConsoleKey.Y || aa.Key == ConsoleKey.U || aa.Key == ConsoleKey.I || aa.Key == ConsoleKey.O || aa.Key == ConsoleKey.P || aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.Z || aa.Key == ConsoleKey.X || aa.Key == ConsoleKey.C || aa.Key == ConsoleKey.B || aa.Key == ConsoleKey.N || aa.Key == ConsoleKey.M || aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.Oem4 || aa.Key == ConsoleKey.Oem6 || aa.Key == ConsoleKey.Oem5 || aa.Key == ConsoleKey.Oem7 || aa.Key == ConsoleKey.OemPeriod || aa.Key == ConsoleKey.OemComma || aa.Key == ConsoleKey.D0 || aa.Key == ConsoleKey.D1 || aa.Key == ConsoleKey.D2 || aa.Key == ConsoleKey.D3 || aa.Key == ConsoleKey.D4 || aa.Key == ConsoleKey.D5 || aa.Key == ConsoleKey.D6 || aa.Key == ConsoleKey.D7 || aa.Key == ConsoleKey.D8 || aa.Key == ConsoleKey.D9 || aa.Key == ConsoleKey.Oem3)
        {
            sop++;
            g = aa.KeyChar;
            if (sop == 1 && a[0] == ' ')
            {
                sop--;
                if (sop > a.Count - 1)
                {
                    a.Add(g);
                }
                else
                {
                    a[sop] = g;
                }
            }
            if (sop > a.Count - 1)
                {
                    a.Add(g);
                }
                else
                {
                    a[sop] = g;
                }
        }


        Console.Clear();
        for (int i = 0; i < a.Count; i++)
        {
            Console.Write(a[i]);
        }
    } while (true);
}