 void SortowaniePrzezWstawianie(int[] tablica)
{
    for (int i = 1; i < tablica.Length; i++)
    {
        int klucz = tablica[i];
        int j = i - 1;

        while (j >= 0 && tablica[j] > klucz)
        {
            tablica[j + 1] = tablica[j];
            j--;
        }
        tablica[j + 1] = klucz;
    }
}



int ZliczWystapienia(int[] tablica, int liczba)
{
    int licznik = 0;
    foreach (int element in tablica)
    {
        if (element == liczba)
        {
            licznik++;
        }
        if (element > liczba) break;
    }
    return licznik;
}













int n=0;

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


int[] line1 = new int[n];
int[] line2 = new int[n];


try
{
    int i= 0;
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

        string[] pom = line.Split("   ");
        line1[i] = Int32.Parse(pom[0]);
        line2[i] = Int32.Parse(pom[1]);

     i++;
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


SortowaniePrzezWstawianie(line1);
SortowaniePrzezWstawianie(line2 );


int wynik = 0;
for (int i = 0; i < n; i++)
{
    wynik += Math.Abs(line1[i] - line2[i]);
}

Console.WriteLine(wynik);

int pom2 = 0;
wynik = 0;
for (int i = 0; i < n; i++)
{
    pom2 = ZliczWystapienia(line2, line1[i]);
    wynik += line1[i]*pom2;
}

Console.WriteLine(wynik);