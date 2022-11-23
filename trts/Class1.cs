using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace trts
{
    internal class baza
    {
        static Fig ihz = new Fig();
        public static void deserializaciya(string sslka)
        {
            if (sslka.Contains("txt"))
            {
                string[] asd = new string[4];
                asd = File.ReadAllLines(sslka);
                List<char> a1 = asd[0].ToCharArray().ToList();
                List<char> a2 = asd[1].ToCharArray().ToList();
                List<char> a3 = asd[2].ToCharArray().ToList();
                List<char> a4 = asd[3].ToCharArray().ToList();
                ConsoleKeyInfo ssl = rbstxt(a1, a2, a3, a4, $"Сериализовать в .xml файл - F1, Сериализовать в .json файл - F2");
                if (ssl.Key == ConsoleKey.F1)
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Fig));
                    using (FileStream fs = new FileStream("C:\\Users\\user\\Desktop\\Result.xml", FileMode.OpenOrCreate))
                    {
                        xml.Serialize(fs, ihz);
                    }
                }
                if (ssl.Key == ConsoleKey.F2)
                {
                    string jsom = JsonConvert.SerializeObject(ihz);
                    File.WriteAllText("C:\\Users\\user\\Desktop\\Result.json", jsom);
                }
            }
            if (sslka.Contains("json"))
            {
                string text = File.ReadAllText(sslka);
                Fig js = JsonConvert.DeserializeObject<Fig>(text);
                List<char> a1 = js.f1.ToCharArray().ToList();
                List<char> a2 = js.f2.ToCharArray().ToList();
                List<char> a3 = js.f3.ToCharArray().ToList();
                List<char> a4 = js.f4.ToCharArray().ToList();
                ConsoleKeyInfo ssl = rbstxt(a1, a2, a3, a4, $"Сериализовать в .xml файл - F1, Сериализовать в .txt файл - F2");
                if (ssl.Key == ConsoleKey.F1)
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Fig));
                    using (FileStream fs = new FileStream("C:\\Users\\user\\Desktop\\Result.xml", FileMode.OpenOrCreate))
                    {
                        xml.Serialize(fs, ihz);
                    }
                }
                if (ssl.Key == ConsoleKey.F2)
                {
                    string b = "";
                    b += ihz.f1 + "\n";
                    b += ihz.f2 + "\n";
                    b += ihz.f3 + "\n";
                    b += ihz.f4 + "\n";
                    File.WriteAllText("C:\\Users\\user\\Desktop\\Result.txt", b);
                }
            }
            if (sslka.Contains("xml"))
            {
                Fig ih;
                XmlSerializer xml = new XmlSerializer(typeof(Fig));
                using (FileStream fs = new FileStream("C:\\Users\\user\\Desktop\\Result.xml", FileMode.Open))
                {
                    ih = (Fig)xml.Deserialize(fs);
                }
                List<char> a1 = ih.f1.ToCharArray().ToList();
                List<char> a2 = ih.f2.ToCharArray().ToList();
                List<char> a3 = ih.f3.ToCharArray().ToList();
                List<char> a4 = ih.f4.ToCharArray().ToList();
                ConsoleKeyInfo ssl = rbstxt(a1, a2, a3, a4, $"Сериализовать в .txt файл - F1, Сериализовать в .json файл - F2");
                if (ssl.Key == ConsoleKey.F1)
                {
                    string b = "";
                    b += ihz.f1 + "\n";
                    b += ihz.f2 + "\n";
                    b += ihz.f3 + "\n";
                    b += ihz.f4 + "\n";
                    File.WriteAllText("C:\\Users\\user\\Desktop\\Result.txt", b);
                }
                if (ssl.Key == ConsoleKey.F2)
                {
                    string jsom = JsonConvert.SerializeObject(ihz);
                    File.WriteAllText("C:\\Users\\user\\Desktop\\Result.json", jsom);
                }
            }
        }
        static ConsoleKeyInfo rbstxt(List<char> a1, List<char> a2, List<char> a3, List<char> a4, string txt)
        {
            int pos = 1;
            char g;
            ConsoleKeyInfo al;
            Console.Clear();
            Console.WriteLine(txt);
            vvod(a1, a2, a3, a4);
            do
            {
                Console.SetCursorPosition(0, pos);
                al = Console.ReadKey();
                if (char.IsLetterOrDigit(al.KeyChar))
                {
                    g = al.KeyChar;
                    switch (pos)
                    {
                        case 1:
                            a1.Add(g);
                            break;
                        case 2:
                            a2.Add(g);
                            break;
                        case 3:
                            a3.Add(g);
                            break;
                        case 4:
                            a4.Add(g);
                            break;
                    }
                }
                if (al.Key == ConsoleKey.Backspace)
                {
                    switch (pos)
                    {
                        case 1:
                            a1 = a1.SkipLast(1).ToList();
                            break;
                        case 2:
                            a2 = a2.SkipLast(1).ToList();
                            break;
                        case 3:
                            a3 = a3.SkipLast(1).ToList();
                            break;
                        case 4:
                            a4 = a4.SkipLast(1).ToList();
                            break;
                    }
                }
                else if (al.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos > 4)
                    {
                        pos--;
                    }
                }
                else if (al.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos < 2)
                    {
                        pos++;
                    }
                }
                och();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(txt);
                Console.SetCursorPosition(0, 1);
                vvod(a1, a2, a3, a4);
            } while (al.Key != ConsoleKey.F1 && al.Key != ConsoleKey.F2);
            Fig ih = new Fig();
            ih.f1 = string.Concat(a1);
            ih.f2 = string.Concat(a2);
            ih.f3 = string.Concat(a3);
            ih.f4 = string.Concat(a4);
            ihz = ih;
            return al;
        }
        static void och()
        {
            char[,] a = new char[5, 30];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = ' ';
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void vvod(List<char> a1, List<char> a2, List<char> a3, List<char> a4)
        {
            foreach (char c in a1)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            foreach (char c in a2)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            foreach (char c in a3)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            foreach (char c in a4)
            {
                Console.Write(c);
            }
        }
    }
    public class Fig
    {
        public string f1;
        public string f2;
        public string f3;
        public string f4;
    }
}
