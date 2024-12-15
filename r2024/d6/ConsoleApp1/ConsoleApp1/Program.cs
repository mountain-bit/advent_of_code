String line;
int n = 0;
int m = 0;
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
        m = line.Length;
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

char[][] lines = new char[n][];


int l = 0;
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
        lines[l] = line.ToArray();
        l++;
        //Read the next line
        line = sr.ReadLine();

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


int x=-1, y=-1;


for(int i = 0; i < n; i++)
{
    for(int j = 0; j < lines[i].Length; j++)
    {
        if (lines[i][j] == '^')
        {
            x= i;
            y = j;
            break;
        }
    }
    if (x != -1) break;
}

Console.WriteLine(x);
Console.WriteLine(y);
int wynik = 0;
int kierunek = 0;
while (x < n && y < m &&x>=0&&y>=0)
{
    switch(kierunek)
    {
        case 0:
            if (lines[x][y] == '#')
            {
                kierunek = 1;
                x++;
            }
            else
            {
                
                if(lines[x][y] != 'X')
                wynik++;
                lines[x][y] = 'X';
                x--;
            }

        break;
        case 1:
            if (lines[x][y] == '#')
            {
                kierunek = 2;
                y--;
            }
            else
            {
               
                if (lines[x][y] != 'X')
                    wynik++;
                lines[x][y] = 'X';
                y++;
            }
            break;
        case 2:
            if (lines[x][y] == '#')
            {
                kierunek = 3;
                x--;
            }
            else
            {
               
                if (lines[x][y] != 'X')
                    wynik++;
                lines[x][y] = 'X';
                x++;
            }
            break;
        case 3:
            if (lines[x][y] == '#')
            {
                kierunek = 0;
               y++;
            }
            else
            {
               
                if (lines[x][y] != 'X')
                    wynik++;
                lines[x][y] = 'X';
                y--;
            }
            break;
    }
}



for (int i = 0; i < n; i++)
{
    for (int j = 0; j < lines[i].Length; j++)
    {
        Console.Write(lines[i][j]);
    }
    Console.WriteLine();
}

Console.WriteLine(wynik);