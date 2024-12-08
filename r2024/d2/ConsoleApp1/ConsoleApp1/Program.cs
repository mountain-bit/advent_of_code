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


int i = 0;
String[] tab = new String[n];
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
        tab[i] = line;
        //Read the next line
        line = sr.ReadLine();
        i++;
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

bool rosnie(int n,int a)
{
    return n < a && Math.Abs(n - a) <= 3;
}

bool maleje(int n, int a)
{
    return n > a && Math.Abs(n - a) <= 3;
}


bool bez(String[] t, int i)
{
    int pom = -1;
    int kier = 0;
    bool f = true;
    for (int k = 0; k < t.Length; k++)
    {
        if (k == i) continue;
        if (pom == -1)
        {
            pom = Int32.Parse(t[k]);
            continue;
        }
        if (kier == 0)
        {
            kier = pom < Int32.Parse(t[k]) ? 1 : -1;

        }
        if (kier == 1)
        {
            //rośnie
            if (rosnie(pom, Int32.Parse(t[k])))
            {


            }
            else
            {
                f = false;

                break;
            }


        }
        else
        {
            //maleje
            if (maleje(pom, Int32.Parse(t[k])))
            {


            }
            else
            {
                f = false;

                break;
            }
        }
        pom = Int32.Parse(t[k]);

    }
    if (f) return true;
    return false;

}


int wynik = 0;
for(int j=0; j<n; j++)
{
    String[] t = tab[j].Split(" ");
    int pom = -1;
    int kier = 0;
    bool f = true;
    for (int k = 0; k < t.Length; k++)
    {
        if (pom == -1)
        {
            pom = Int32.Parse(t[k]);
            continue;
        }
        if (kier == 0)
        {
            kier = pom < Int32.Parse(t[k]) ? 1 : -1;

        }
        if (kier==1)
        {
            //rośnie
            if (rosnie(pom, Int32.Parse(t[k])))
            {


            }
            else
            {
                f = false;
                break;
            }


        }
        else
        {
            //maleje
            if (maleje(pom, Int32.Parse(t[k])))
            {


            }
            else
            {
                f = false;
                break;
            }
        }
        pom = Int32.Parse(t[k]);

    }
    if (f) wynik++;
    else
    {
        int m = 0;
        do
        {
            if (bez(t, m)){

                wynik++;
                break;
            }
            m++;
           
        }while (m < t.Length);
    }

    f = true;
    
}

Console.WriteLine(wynik); 