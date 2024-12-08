
String line;


int stan = 0;
int wynik = 0;
int l1 = 0, l2 = 0;
bool flaga = true;
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

        for (int i = 0; i < line.Length; i++)
        {
            Console.Write(stan);
            Console.Write(line[i]);
            Console.WriteLine(" stan: "+stan);

            if(line[i] == 'd')
            {
                stan = -1;
                continue;
            }

            if(stan == -1)
            {
                if (line[i] == 'o') stan = -2;
                else stan = 0;
            }else if(stan == -2)
            {
                if (line[i] == '(') stan = -3;
                else if (line[i] == 'n') stan = -4;
                else stan = 0;
            }else if (stan == -3)
            {
                if (line[i] == ')') flaga = true;
                    stan = 0;
            }else if (stan == -4)
            {
                if (line[i].ToString().Equals("'")) stan = -5;
                else stan = 0;
            }else if (stan == -5)
            {
                if (line[i] == 't') stan = -6;
                else stan = 0;
            }else if ((stan == -6))
            {
                if (line[i] == '(') stan = -7;
                else stan = 0;
            }
            else if ((stan == -7))
            {
                if (line[i] == ')') flaga = false;
                stan = 0;
            }

            if (flaga && stan>=0)
            {


                if (stan == 0)
                {
                    l1 = 0;
                    l2 = 0;
                    if (line[i] == 'm') stan = 1;
                    else stan = 0;
                }
                else if (stan == 1)
                {
                    if (line[i] == 'u') stan = 2;
                    else stan = 0;
                }
                else if (stan == 2)
                {
                    if (line[i] == 'l') stan = 3;
                    else stan = 0;
                }
                else if (stan == 3)
                {
                    if (line[i] == '(') stan = 4;
                    else stan = 0;
                }
                else if (stan == 4)
                {
                    if (Char.IsDigit(line[i]))
                    {
                        l1 *= 10;
                        l1 += Int32.Parse(line[i].ToString());

                    }
                    else
                    {
                        if (line[i] == ',') stan = 5;
                        else stan = 0;
                    }
                }
                else if (stan == 5)
                {
                    if (Char.IsDigit(line[i]))
                    {
                        l2 *= 10;
                        l2 += Int32.Parse(line[i].ToString());

                    }
                    else
                    {
                        if (line[i] == ')')
                        {
                            Console.WriteLine("l1:" + l1);
                            Console.WriteLine("l2:" + l2);

                            wynik += l1 * l2;
                            Console.WriteLine("wynik:" + wynik);
                            l1 = 0;
                            l2 = 0;
                            stan = 0;
                        }
                        else { stan = 0; }
                    }
                }
                else { stan = 0; }
            }
        }



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


Console.WriteLine(wynik);