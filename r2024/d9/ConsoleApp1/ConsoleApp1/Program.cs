
using ConsoleApp1;
using System.Text;

String line;
StringBuilder linia1 = new StringBuilder();
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
        linia1.Append(line);
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



Console.WriteLine(linia1);

List<liczba> dysk = new List<liczba>();
/*
int j = 0;
for(int i = 0; i < linia.Length; i++)
{
    if (i % 2 == 0)
    {
        for(int k = 0;k< Int32.Parse(linia[i].ToString()); k++)
        dysk.Append(j);
        j++;
        Console.WriteLine(j);
    }
    else
    {
        for (int k = 0; k < Int32.Parse(linia[i].ToString()); k++)
            dysk.Append(".");
    }
}

bool zmiana = false;

for(int i = dysk.Length - 1; i >= 0; i--)
{
        if (dysk[i] == '.') continue;

        zmiana = false;
        for(int k = 0; k < i; k++)
        {
            if (dysk[k] == '.')
            {
                dysk[k]= dysk[i];
                dysk[i] = '.';
                zmiana = true;
                break;
            }
        }
    Console.WriteLine(i);
    if (zmiana == false) break;
}

Console.WriteLine(dysk.ToString());

*/

int koniec = linia1.Length - 1;
int m = 0;
if(koniec %2 == 1)koniec = koniec - 1;

Console.WriteLine(dysk.ToString());

//for (int i = 0; koniec >= i; i++)
//{
//    if (i % 2 == 0)
//    {
//        for (int j = 0; j < Int32.Parse(linia[i].ToString()); j++)
//        {
//            dysk.Add (new liczba(i - i / 2));

//        }
//    }
//    else
//    {
//        for (int j = 0; j < Int32.Parse(linia[i].ToString()); j++)
//        {
//            while (linia[koniec] == '0')
//                koniec = koniec - 2;

//            if (koniec < i) break;
//            dysk.Add(new liczba(koniec - koniec / 2));
//            linia[koniec] = Char.Parse((Int32.Parse(linia[koniec].ToString()) - 1).ToString());
//        }

//    }
//}

liczba[] linia = new liczba[koniec+1];
for(int i = 0; i <= koniec; i++)
{
    linia[i] = new liczba(Int32.Parse(linia1[i].ToString()));
}



for(int i = 0; koniec >= i; i++)
{
    if (i % 2 == 0  && linia[i].warosc>0)
    {
        for (int j = 0; j < linia[i].warosc; j++)
        {
            dysk.Add(new liczba(i - i / 2));

        }
    }
    else
    {
        int miejsce;
        if (i % 2 == 0)
        {
             miejsce = Math.Abs(linia[i].warosc);
        }
        else
        {
             miejsce = linia[i].warosc;
        }
        for (int j = koniec; j > i && miejsce!=0; j = j - 2)
        {
            if (linia[j].warosc <= 0) continue;
            if (linia[j].warosc <= miejsce)
                for (int k = 0; k < linia[j].warosc; k++)
                {
                    dysk.Add(new liczba(j - j / 2));
                }
            else { continue; }
            miejsce = miejsce - linia[j].warosc;
            linia[j].warosc = -linia[j].warosc;
            j = koniec;
        }

        //foreach (var item in dysk)
        //{
        //    Console.Write(item.warosc + " ");
        //}
        //Console.WriteLine(" ");
        for (int j = 0; j < miejsce; j++)
        {
            //Console.WriteLine(miejsce);
            dysk.Add(new liczba(0));
        }



    }
}


//foreach (var item in dysk)
//{
//    Console.Write(item.warosc+" ");
//}


long wynik = 0;

for (int i = 0; i < dysk.Count(); i++)
{
    wynik += i * dysk[i].warosc;

}







Console.WriteLine(wynik);


