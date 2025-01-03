



String line;
int Ax, Bx, Ay, By;
int X, Y;
int tymX=0,tymY=0;
try
{
    //Pass the file path and file name to the StreamReader constructor
    StreamReader sr = new StreamReader("tak.txt");
    //Read the first line of text
    line = sr.ReadLine();
    //Continue to read until you reach end of file
    while (line != null)
    {
        line = sr.ReadLine();
        //write the line to console window
        for (int i = 0; i < line.Split(" ")[2].Split("+").Length; i++) {
            Console.WriteLine(line.Split(" ")[2].Split("+")[i]);
        }


        Ax = Convert.ToInt32(line.Split(" ")[2].Split("+")[1]);

        for (int i = 0; i < line.Split(" ")[3].Split("+").Length; i++)
        {
            Console.WriteLine(line.Split(" ")[3].Split("+")[i]);
        }
        Ay = Convert.ToInt32(line.Split(" ")[3].Split("+")[1]);
        //Read the next line
        line = sr.ReadLine();

        for (int i = 0; i < line.Split(" ")[2].Split("+").Length; i++)
        {
            Console.WriteLine(line.Split(" ")[2].Split("+")[i]);
        }
        Bx = Convert.ToInt32(line.Split(" ")[2].Split("+")[1]);

        for (int i = 0; i < line.Split(" ")[3].Split("+").Length; i++)
        {
            Console.WriteLine(line.Split(" ")[3].Split("+")[i]);
        }
        By = Convert.ToInt32(line.Split(" ")[3].Split("+")[1]);
        //Read the next line
        line = sr.ReadLine();

        for (int i = 0; i < line.Split(" ")[1].Split("=").Length; i++)
        {
            Console.WriteLine(line.Split(" ")[1].Split("=")[i]);
        }

        X = Convert.ToInt32(line.Split(" ")[1].Split("=")[1]);
        for (int i = 0; i < line.Split(" ")[2].Split("=").Length; i++)
        {
            Console.WriteLine(line.Split(" ")[2].Split("=")[i]);
        }
        Y = Convert.ToInt32(line.Split(" ")[2].Split("=")[1]);
       
        line = sr.ReadLine();


        //tu taj reszta

        tymX = 100 * Bx; tymY = 100 *By;

        do
        {
            if()






        }while(tymX!=X&& tymY!=Y);





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
