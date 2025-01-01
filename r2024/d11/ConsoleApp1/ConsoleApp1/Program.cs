
using System.Text;

String[] line = new String[1];

try
{
    //Pass the file path and file name to the StreamReader constructor
    StreamReader sr = new StreamReader("tak.txt");
    //Read the first line of text
    line = sr.ReadLine().Split(" ");

    //Continue to read until you reach end of file
        //write the line to console window
        for (int i = 0; i < line.Length; i++)
    {
        Console.WriteLine(line[i]);
    }
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

List<long> kamienie = new List<long>();

for (int i = 0;i < line.Length; i++)
{
    kamienie.Add(Int64.Parse( line[i]));
}

//kamienie.ForEach(x => Console.WriteLine(x));
Console.WriteLine("----------------");

int mrugniecia = 75;



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
Console.WriteLine(kamienie.Count());