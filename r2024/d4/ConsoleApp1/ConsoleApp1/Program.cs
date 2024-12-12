String line;
int n = 0;
int x = 0;
try
{
    //Pass the file path and file name to the StreamReader constructor
    StreamReader sr = new StreamReader("tak.txt");
    //Read the first line of text
    line = sr.ReadLine();
    x = line.Length;
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




String[] lines  = new string[n];


int z = 0;
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
        lines[z] = line; z++;
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


int wynik = 0;

int[][] tab = new int[n][];

for(int i=0; i<n; i++)
{
    Console.WriteLine(lines[i].Length);
    tab[i] = new int[lines[i].Length];
}

// -> x

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < lines[i].Length - 4; j++)
    {
        if (lines[i][j] == 'X' && lines[i][j + 1] == 'M' && lines[i][j + 2] == 'A' && lines[i][j + 3] == 'S')
        {
            tab[i][j]++;
            tab[i][j+1]++;
            tab[i][j + 2]++;
            tab[i][j + 3]++;
            wynik++;
        }

    }
}

//<-  x

for (int i = 0; i < n; i++)
{
    for (int j = 3; j < lines[i].Length; j++)
    {
        if (lines[i][j] == 'X' && lines[i][j - 1] == 'M' && lines[i][j - 2] == 'A' && lines[i][j - 3] == 'S')
        {
            tab[i][j]++;
            tab[i][j - 1]++;
            tab[i][j - 2]++;
            tab[i][j - 3]++;
            wynik++;
        }
    }
}

//|
//v

for (int i = 0; i <= n - 4; i++)
{
    for (int j = 0; j < lines[i].Length; j++)
    {
        if (lines[i][j] == 'X' && lines[i + 1][j] == 'M' && lines[i + 2][j] == 'A' && lines[i + 3][j] == 'S')
        {
            tab[i][j]++;
            tab[i + 1][j ]++;
            tab[i + 2][j ]++;
            tab[i + 3][j ]++;
            wynik++;
        }
    }
}


//^
//|   x

for (int i = 3; i < n; i++)
{
    for (int j = 0; j < lines[i].Length; j++)
    {
        if (lines[i][j] == 'X' && lines[i - 1][j] == 'M' && lines[i - 2][j] == 'A' && lines[i - 3][j] == 'S')
        {
            tab[i][j]++;
            tab[i - 1][j]++;
            tab[i - 2][j]++;
            tab[i - 3][j]++;
            wynik++;
        }
    }
}

// \
//  > x

for (int i = 0; i <= n - 4; i++)
{
    for (int j = 0; j <= lines[i].Length-4; j++)
    {
        if (lines[i][j] == 'X' && lines[i + 1][j + 1] == 'M' && lines[i + 2][j + 2] == 'A' && lines[i + 3][j + 3] == 'S')
        {
            tab[i][j]++;
            tab[i + 1][j + 1]++;
            tab[i + 2][j + 2]++;
            tab[i + 3][j + 3]++;
            wynik++;
        }
    }
}
// <
//  \

for (int i = n - 1; i >= 3; i--)
{
    for (int j = lines[i].Length-1; j >=3; j--)
    {
        if (lines[i][j] == 'X' && lines[i - 1][j - 1] == 'M' && lines[i - 2][j - 2] == 'A' && lines[i - 3][j - 3] == 'S')
        {
            tab[i][j]++;
            tab[i - 1][j - 1]++;
            tab[i - 2][j - 2]++;
            tab[i - 3][j - 3]++;
            wynik++;
        }
    }
}


// /
//<
for (int i = 0; i <= n - 4; i++)
{
    for (int j = lines[i].Length - 1; j >= 3; j--)
    {
        if (lines[i][j] == 'X' && lines[i + 1][j - 1] == 'M' && lines[i + 2][j - 2] == 'A' && lines[i + 3][j - 3] == 'S')
        {
            tab[i][j]++;
            tab[i + 1][j - 1]++;
            tab[i + 2][j - 2]++;
            tab[i + 3][j - 3]++;
            wynik++;
        }
    }
}

//  ^
// /

for (int i = n - 1; i >= 3; i--)
{
    for (int j = 0; j <= lines[i].Length - 4; j++)
    {
        if (lines[i][j] == 'X' && lines[i - 1][j + 1] == 'M' && lines[i - 2][j + 2] == 'A' && lines[i - 3][j + 3] == 'S')
        {
            tab[i][j]++;
            tab[i - 1][j + 1]++;
            tab[i - 2][j + 2]++;
            tab[i - 3][j + 3]++;
            wynik++;
        }
    }
}
Console.WriteLine(wynik);

Console.WriteLine();

for(int i = 0;i<n; i++)
{
    for(int j = 0;j < tab[i].Length; j++)
    {
        Console.Write(tab[i][j] > 0?lines[i][j]:".");
    }
    Console.WriteLine();
}