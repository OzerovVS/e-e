using trts;
l.pris();
int pos = 0;
char g;
ConsoleKeyInfo aa;
do
{
    Console.SetCursorPosition(0, pos);
    switch (pos)
    {
        case 0:
            Console.Clear();
            l.t2();
            do
            {
                Console.SetCursorPosition(0, pos);
                aa = Console.ReadKey();
                if (aa.Key == ConsoleKey.Backspace)
                {
                    l.a0 = l.a0.SkipLast(1).ToList();
                }
                if (aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.J || aa.Key == ConsoleKey.H || aa.Key == ConsoleKey.G || aa.Key == ConsoleKey.F || aa.Key == ConsoleKey.D || aa.Key == ConsoleKey.S || aa.Key == ConsoleKey.A || aa.Key == ConsoleKey.Q || aa.Key == ConsoleKey.W || aa.Key == ConsoleKey.E || aa.Key == ConsoleKey.R || aa.Key == ConsoleKey.T || aa.Key == ConsoleKey.Y || aa.Key == ConsoleKey.U || aa.Key == ConsoleKey.I || aa.Key == ConsoleKey.O || aa.Key == ConsoleKey.P || aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.Z || aa.Key == ConsoleKey.L || aa.Key == ConsoleKey.X || aa.Key == ConsoleKey.C || aa.Key == ConsoleKey.B || aa.Key == ConsoleKey.V || aa.Key == ConsoleKey.N || aa.Key == ConsoleKey.M || aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.Oem4 || aa.Key == ConsoleKey.Oem6 || aa.Key == ConsoleKey.Oem5 || aa.Key == ConsoleKey.Oem7 || aa.Key == ConsoleKey.OemPeriod || aa.Key == ConsoleKey.OemComma || aa.Key == ConsoleKey.D0 || aa.Key == ConsoleKey.D1 || aa.Key == ConsoleKey.D2 || aa.Key == ConsoleKey.D3 || aa.Key == ConsoleKey.D4 || aa.Key == ConsoleKey.D5 || aa.Key == ConsoleKey.D6 || aa.Key == ConsoleKey.D7 || aa.Key == ConsoleKey.D8 || aa.Key == ConsoleKey.D9 || aa.Key == ConsoleKey.Oem3 || aa.Key == ConsoleKey.Oem1)
                {
                    g = aa.KeyChar;
                    l.a0.Add(g);
                }
                
                if (aa.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos < 0)
                    {
                        pos++;
                    }
                    break;
                }
                if (aa.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos > 3)
                    {
                        pos--;
                    }
                    break;
                }
                Console.Clear();
                l.t2();
            } while (true);
            break;
        case 1:
            Console.Clear();
            l.t2();
            do
            {
                Console.SetCursorPosition(0, pos);
                aa = Console.ReadKey();
                if (aa.Key == ConsoleKey.Backspace)
                {
                    l.a1 = l.a1.SkipLast(1).ToList();
                }
                if (aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.J || aa.Key == ConsoleKey.H || aa.Key == ConsoleKey.G || aa.Key == ConsoleKey.F || aa.Key == ConsoleKey.D || aa.Key == ConsoleKey.S || aa.Key == ConsoleKey.A || aa.Key == ConsoleKey.Q || aa.Key == ConsoleKey.W || aa.Key == ConsoleKey.E || aa.Key == ConsoleKey.R || aa.Key == ConsoleKey.T || aa.Key == ConsoleKey.Y || aa.Key == ConsoleKey.U || aa.Key == ConsoleKey.I || aa.Key == ConsoleKey.O || aa.Key == ConsoleKey.P || aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.Z || aa.Key == ConsoleKey.L || aa.Key == ConsoleKey.X || aa.Key == ConsoleKey.C || aa.Key == ConsoleKey.B || aa.Key == ConsoleKey.V || aa.Key == ConsoleKey.N || aa.Key == ConsoleKey.M || aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.Oem4 || aa.Key == ConsoleKey.Oem6 || aa.Key == ConsoleKey.Oem5 || aa.Key == ConsoleKey.Oem7 || aa.Key == ConsoleKey.OemPeriod || aa.Key == ConsoleKey.OemComma || aa.Key == ConsoleKey.D0 || aa.Key == ConsoleKey.D1 || aa.Key == ConsoleKey.D2 || aa.Key == ConsoleKey.D3 || aa.Key == ConsoleKey.D4 || aa.Key == ConsoleKey.D5 || aa.Key == ConsoleKey.D6 || aa.Key == ConsoleKey.D7 || aa.Key == ConsoleKey.D8 || aa.Key == ConsoleKey.D9 || aa.Key == ConsoleKey.Oem3 || aa.Key == ConsoleKey.Oem1)
                {
                    g = aa.KeyChar;
                    l.a1.Add(g);
                }

                if (aa.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos < 0)
                    {
                        pos++;
                    }
                    break;
                }
                if (aa.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos > 3)
                    {
                        pos--;
                    }
                    break;
                }
                Console.Clear();
                l.t2();
            } while (true);
            break;
        case 2:
            Console.Clear();
            l.t2();
            do
            {
                Console.SetCursorPosition(0, pos);
                aa = Console.ReadKey();
                if (aa.Key == ConsoleKey.Backspace)
                {
                    l.a2 = l.a2.SkipLast(1).ToList();
                }
                if (aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.J || aa.Key == ConsoleKey.H || aa.Key == ConsoleKey.G || aa.Key == ConsoleKey.F || aa.Key == ConsoleKey.D || aa.Key == ConsoleKey.S || aa.Key == ConsoleKey.A || aa.Key == ConsoleKey.Q || aa.Key == ConsoleKey.W || aa.Key == ConsoleKey.E || aa.Key == ConsoleKey.R || aa.Key == ConsoleKey.T || aa.Key == ConsoleKey.Y || aa.Key == ConsoleKey.U || aa.Key == ConsoleKey.I || aa.Key == ConsoleKey.O || aa.Key == ConsoleKey.P || aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.Z || aa.Key == ConsoleKey.L || aa.Key == ConsoleKey.X || aa.Key == ConsoleKey.C || aa.Key == ConsoleKey.B || aa.Key == ConsoleKey.V || aa.Key == ConsoleKey.N || aa.Key == ConsoleKey.M || aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.Oem4 || aa.Key == ConsoleKey.Oem6 || aa.Key == ConsoleKey.Oem5 || aa.Key == ConsoleKey.Oem7 || aa.Key == ConsoleKey.OemPeriod || aa.Key == ConsoleKey.OemComma || aa.Key == ConsoleKey.D0 || aa.Key == ConsoleKey.D1 || aa.Key == ConsoleKey.D2 || aa.Key == ConsoleKey.D3 || aa.Key == ConsoleKey.D4 || aa.Key == ConsoleKey.D5 || aa.Key == ConsoleKey.D6 || aa.Key == ConsoleKey.D7 || aa.Key == ConsoleKey.D8 || aa.Key == ConsoleKey.D9 || aa.Key == ConsoleKey.Oem3 || aa.Key == ConsoleKey.Oem1)
                {
                    g = aa.KeyChar;
                    l.a2.Add(g);
                }

                if (aa.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos < 0)
                    {
                        pos++;
                    }
                    break;
                }
                if (aa.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos > 3)
                    {
                        pos--;
                    }
                    break;
                }
                Console.Clear();
                l.t2();
            } while (true);
            break;
        case 3:
            Console.Clear();
            l.t2();
            do
            {
                Console.SetCursorPosition(0, pos);
                aa = Console.ReadKey();
                if (aa.Key == ConsoleKey.Backspace)
                {
                    l.a3 = l.a3.SkipLast(1).ToList();
                }
                if (aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.J || aa.Key == ConsoleKey.H || aa.Key == ConsoleKey.G || aa.Key == ConsoleKey.F || aa.Key == ConsoleKey.D || aa.Key == ConsoleKey.S || aa.Key == ConsoleKey.A || aa.Key == ConsoleKey.Q || aa.Key == ConsoleKey.W || aa.Key == ConsoleKey.E || aa.Key == ConsoleKey.R || aa.Key == ConsoleKey.T || aa.Key == ConsoleKey.Y || aa.Key == ConsoleKey.U || aa.Key == ConsoleKey.I || aa.Key == ConsoleKey.O || aa.Key == ConsoleKey.P || aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.Z || aa.Key == ConsoleKey.L || aa.Key == ConsoleKey.X || aa.Key == ConsoleKey.C || aa.Key == ConsoleKey.B || aa.Key == ConsoleKey.V || aa.Key == ConsoleKey.N || aa.Key == ConsoleKey.M || aa.Key == ConsoleKey.K || aa.Key == ConsoleKey.Oem4 || aa.Key == ConsoleKey.Oem6 || aa.Key == ConsoleKey.Oem5 || aa.Key == ConsoleKey.Oem7 || aa.Key == ConsoleKey.OemPeriod || aa.Key == ConsoleKey.OemComma || aa.Key == ConsoleKey.D0 || aa.Key == ConsoleKey.D1 || aa.Key == ConsoleKey.D2 || aa.Key == ConsoleKey.D3 || aa.Key == ConsoleKey.D4 || aa.Key == ConsoleKey.D5 || aa.Key == ConsoleKey.D6 || aa.Key == ConsoleKey.D7 || aa.Key == ConsoleKey.D8 || aa.Key == ConsoleKey.D9 || aa.Key == ConsoleKey.Oem3 || aa.Key == ConsoleKey.Oem1)
                {
                    g = aa.KeyChar;
                    l.a3.Add(g);
                }

                if (aa.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos < 0)
                    {
                        pos++;
                    }
                    break;
                }
                if (aa.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos > 3)
                    {
                        pos--;
                    }
                    break;
                }
                Console.Clear();
                l.t2();
            } while (true);
            break;
    }
} while (true);
string a, b, c, d;
for (int i = 0; i < l.a0.Count; i++)
{

}
figurs com1 = new figurs();
com1.figura1 = 
List<figurs> figurr = new List<figurs> { };

