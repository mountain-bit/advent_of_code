long wynik = 0;

bool wszystko(bool[]z, int n)
{
    for(int i = 0; i < n; i++)
    {
        if (z[i] == false) return false;
    }
    return true;
}

 bool[] NastępnyCiągBitów(bool[] ciągBitów)
{
    int n = ciągBitów.Length;

    for(int i = 0; i < n; i++)
    {
        if (ciągBitów[i] == false)
        {
            ciągBitów[i] = true;
            for(int j = i - 1; j >= 0; j--)
            {
                ciągBitów[j] = false;
            }
            return ciągBitów;
        }
    }

    return ciągBitów;
}


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
        

        String [] pozial = line.Split(":");
        String []liczby = pozial[1].Trim().Split(" ");
        bool[] znaki = new bool[liczby.Length-1];
        
        int j = 0;
        do
        {
            long pom = Int64.Parse(liczby[0]);
            for (int k = 0; k < liczby.Length-1; k++)
            {
                if (znaki[k] == false)
                {
                    pom += Int64.Parse(liczby[k+1]);
                }
                else
                {
                    pom *= Int64.Parse(liczby[k+1]);
                }
            }
            if (pom == Int64.Parse(pozial[0]))
            {
                wynik += pom;
                Console.WriteLine(pom);
                break;
            }
            NastępnyCiągBitów(znaki);
            j++;

            //Console.WriteLine(j);
            //Console.WriteLine(pom);
            //for(int k = 0;k < znaki.Length; k++)
            //{
            //    Console.Write(znaki[k]);
            //}
            //Console.WriteLine();

        } while (j<Math.Pow(2,liczby.Length-1));

        




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

Console.WriteLine(wynik);