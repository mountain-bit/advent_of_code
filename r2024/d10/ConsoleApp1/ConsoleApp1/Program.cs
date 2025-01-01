// See https://aka.ms/new-console-template for more information


int n = 0;
String line;
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

int[][] tab = new int[n][];

List<pole> pola = new List<pole>();


int i = 0;
try
{
    //Pass the file path and file name to the StreamReader constructor
    StreamReader sr = new StreamReader("tak.txt");
    //Read the first line of text
    line = sr.ReadLine();
    //Continue to read until you reach end of file
    while (line != null)
    {
        tab[i] = new int[line.Length];
        int j = 0;
        //write the line to console window
        foreach (var item in line.ToArray())
        {
            tab[i][j] = Int32.Parse(item.ToString());
            if (item == '0') pola.Add(new pole(i, j));
            j++;
            
        };
        i++;
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

for(int k=0; k<tab.Length; k++)
{
    for(int l = 0; l < tab[k].Length; l++)
    {
        Console.Write(tab[k][l]);
    }
    Console.WriteLine("");
}

Console.WriteLine(pola.Count());

void zadanie(pole P, int x, int y, int[][] tab)
{
    do
    {
        int[] kierunekX = new int[4];
        int[] kierunekY = new int[4];

        kierunekX[0] = -1;
        kierunekX[1] = -1;
        kierunekX[2] = -1;
        kierunekX[3] = -1;

        kierunekY[0] = -1;
        kierunekY[1] = -1;
        kierunekY[2] = -1;
        kierunekY[3] = -1;

        if (x - 1 >= 0 && tab[x - 1][y] - tab[x][y] == 1)
        {
            kierunekX[0] = x-1;
            kierunekY[0] = y;
        }
        if(y - 1 >= 0 && tab[x][y - 1] - tab[x][y] == 1)
        {
            kierunekX[1] = x;
            kierunekY[1] = y-1;
        }
        if (x + 1 < tab.Length && tab[x + 1][y] - tab[x][y] == 1)
        {
            kierunekX[2] = x+1;
            kierunekY[2] = y;
        }
        if((y + 1) < tab[x].Length && tab[x][y + 1] - tab[x][y] == 1)
        {
            kierunekX[3] = x;
            kierunekY[3] = y+1;
        }



        bool pierwszy = true;

        for(int i = 0; i < 4; i++)
        {
            if (pierwszy)
            {
                if (kierunekX[i] != -1)
                {
                    pierwszy = false;
                    x = kierunekX[i];
                    y = kierunekY[i];
                }

            }
            else
            {
                if (kierunekX[i] != -1)
                {
                    zadanie(P, kierunekX[i], kierunekY[i], tab);
                }

            }

        }

        if (pierwszy)
        {
           
            if (tab[x][y] == 9)
            {
                Console.WriteLine("dodaj");
                //if (P.czyLiczyc(x, y))
                //{

                P.score++;
                //    P.gX.Add(x);
                //    P.gY.Add(y);
                //}


            }
            break;
        }
        


    } while (true);



    
}
int wynik = 0;

foreach (var item in pola)
{
    zadanie(item, item.x, item.y, tab);
    wynik+= item.score;
}

Console.WriteLine(wynik);