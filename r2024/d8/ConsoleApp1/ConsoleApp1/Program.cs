
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;

namespace abc
{

    struct znak
    {
        public int x;
        public int y;
        public znak(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    };
    class Tak
    {

        static void Main(String[] args)
        {

            int n = 0;
            int m = 0;
            List<List<znak>> znaki = new List<List<znak>>();
            string g = "";
            String line;
            char[] c;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("tak.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);

                    c = line.ToArray();
                    m = c.Length;
                    for (int i = 0; i < c.Length; i++)
                    {
                        if (c[i] == '.') continue;
                        if (g.IndexOf(c[i]) == -1)
                        {
                            g += c[i].ToString();
                            znaki.Add(new List<znak>());
                            znaki[g.IndexOf(c[i])].Add(new znak(n, i));
                        }
                        else
                        {
                            znaki[g.IndexOf(c[i])].Add(new znak(n, i));
                        }
                    }


                    //Read the next line
                    line = sr.ReadLine();
                    n++;
                }
                //close the file
                sr.Close();
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            char[][] tab = new char[n][];
            for (int i = 0; i < n; i++)
            {
                tab[i] = new char[m];
            }

            znaki.ForEach(znakia =>
            {
                znakia.ForEach(z1 =>
                {
                    znakia.ForEach(z2 =>
                    {
                        if (z1.x != z2.x && z1.y != z2.y)
                        {
                            int i = 1;
                            int x = Math.Abs(z1.x - z2.x);
                            int y = Math.Abs(z1.y - z2.y);

                            if (z1.x <= z2.x)
                            {
                                if(z1.y>= z2.y)
                                {
                                    while (z1.x - x*i >= 0 && z1.y + y * i < m)
                                    { 
                                        tab[z1.x - x * i][z1.y + y * i] = '#';
                                        i++;
                                    }

                                }
                                else
                                {
                                    while (z1.x - x * i >= 0 && z1.y - y * i >= 0) {
                                        tab[z1.x - x * i][z1.y - y * i] = '#'; i++;
                                    }
                                }
                            }
                            else
                            {
                                if (z1.y >= z2.y)
                                {
                                while (z1.x + x * i < m && z1.y + y * i < m) { tab[z1.x + x * i][z1.y + y * i] = '#'; i++; }
                                }
                                else
                                {
                                while (z1.x + x * i < m && z1.y - y * i >= 0) { tab[z1.x + x * i][z1.y - y * i] = '#'; i++; }
                                }
                            }
                        }
                    });
                    //z1
                });
            });
            int wynik = 0;
            znaki.ForEach(znakia =>
            {
                znakia.ForEach(z1 =>
                {
                    tab[z1.x][z1.y] = 'A';
                });
            });
           
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (tab[i][j] == '#')
                    {
                        wynik++;
                        Console.Write(tab[i][j]);
                    }
                    else if (tab[i][j] =='A')
                    {
                        wynik++;
                        Console.Write(tab[i][j]);
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(wynik);
        }
    }
}



