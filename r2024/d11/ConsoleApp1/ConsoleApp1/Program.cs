
using System.Text;

String line;
List<long> kamienie = new List<long>();

int mrugniecia = 35;
try
{
    //Pass the file path and file name to the StreamReader constructor
    StreamReader sr = new StreamReader("tak.txt");
    //Read the first line of text
    line = sr.ReadLine();

    string sciezkaPliku = "wyniki.txt";

    // Zapis listy do pliku
    using (StreamWriter writer = new StreamWriter(sciezkaPliku))
    {
        writer.WriteLine("początek");
        while (line != null)
        {
            kamienie.Clear();
        
            kamienie.Add(Int64.Parse(line));
            line = sr.ReadLine();



            for (int i = 1; i <= mrugniecia; i++)
            {

                long ile = kamienie.Count();
                Console.WriteLine("mrug " + i + " " + ile);
                for (int j = 0; j < ile; j++)
                {
                    if (kamienie[j] == 0) kamienie[j] = 1;
                    else if (kamienie[j].ToString().Length % 2 == 0)
                    {
                        string pom = kamienie[j].ToString();

                        kamienie.Add(Int64.Parse(pom.Substring(0, pom.Length / 2)));



                        kamienie[j] = Int64.Parse(pom.Substring(pom.Length / 2));
                    }
                    else
                    {
                        kamienie[j] = kamienie[j] * 2024;
                    }
                }

                //kamienie.ForEach(x => Console.Write(x+" "));
                //Console.WriteLine();
            }
            writer.WriteLine(kamienie.Count());




            //}

        }
    }
    //Continue to read until you reach end of file
    //write the line to console window
    //    for (int i = 0; i < line.Length; i++)
    //{
    //    Console.WriteLine(line[i]);
    //}
    //Read the next line
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



//for (int i = 0;i < line.Length; i++)
//{
//    kamienie.Add(Int64.Parse( line[i]));
//}

//kamienie.ForEach(x => Console.WriteLine(x));
Console.WriteLine("----------------");



//56218624
//144
//32578304
//110235136
//175845120
//3703304704
//32
//4063803392
//2851216896
//856
//3166653248
//2756995648
//47758304
//43198232
//44689920
//72963176
//518
//340
//493

for (int i = 1; i <=mrugniecia ; i++)
{

    long ile = kamienie.Count();
    Console.WriteLine("mrug " + i +" "+ ile);
    for (int j = 0; j <ile ; j++)
    {
        if (kamienie[j]==0) kamienie[j] = 1;
        else if (kamienie[j].ToString().Length % 2 == 0)
        {
            string pom = kamienie[j].ToString();

            kamienie.Add(Int64.Parse(pom.Substring(0, pom.Length / 2)));

        

            kamienie[j] = Int64.Parse(pom.Substring(pom.Length / 2));
        }
        else
        {
            kamienie[j] = kamienie[j]*2024;
        }
    }

    //kamienie.ForEach(x => Console.Write(x+" "));
    //Console.WriteLine();
}

//kamienie.ForEach(x => Console.WriteLine(x));
//Console.WriteLine(kamienie.Count());

//string sciezkaPliku = "tak.txt";

//// Zapis listy do pliku
//using (StreamWriter writer = new StreamWriter(sciezkaPliku))
//{
//    foreach (long element in kamienie)
//    {
//        writer.WriteLine(element);
//    }
//}
          