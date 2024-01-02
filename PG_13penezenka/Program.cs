
using System.Linq.Expressions;

string baseDir = @"..\..\..\";

  //moje práce:

//udělá soubor penezenka, poku neexistuje
using (TextWriter writer = new StreamWriter(baseDir + "penezenka", true)) {}

//definování funkcí:
static string[] ReadLines(TextReader reader)
{
    string[] lines = new string[10];
    int count = 0;
    string line;


    while ((line = reader.ReadLine()) != null)
    {
        if (count >= lines.Length)
        {
            Array.Resize(ref lines, lines.Length * 2);
        }
        lines[count] = line;
        count += 1;
    }

    Array.Resize(ref lines, count);
    return lines;
}

static string[] ReadFile(string fileName)
{
    try 
    {
        using (TextReader reader = new StreamReader(fileName))
        {
            return ReadLines(reader);
        }
    }
    
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return null;
    }

}

static void WriteLines(TextWriter writer, string[] lines)
{
    foreach (string line in lines)
    {
        writer.WriteLine(line);
    }
}

static void WriteFile(string fileName, string[] lines, bool append = false)
{
    // druhý parametr StreamWriter - přepsat soubor (false, výchozí), nebo psát na konec (true)
    using (TextWriter writer = new StreamWriter(fileName, append))
    {
        WriteLines(writer, lines);
    }
}

//menu
static void Menu()
{
    Console.Clear();

    Console.WriteLine("______________________________");
    Console.WriteLine("add record: \"1\"");
    Console.WriteLine("wryte down all records: \"2\"");
    Console.WriteLine("change record: \"3\"");
    Console.WriteLine("delete record: \"4\"");
    Console.WriteLine("end the programe: \"0\" ");
    Console.WriteLine("______________________________");
    string i =Console.ReadLine();
    
    switch (i)
    {
        case "1":
           // Console.WriteLine();
            
           // WriteFile(baseDir + "penezenka", string[] lines, true);
            break;
        case "2":
            ReadFile(@"D:\OneDrive - Gymnázium, Praha 9, Špitálská 2\PŘEDMĚTY\PG\PG_13penezenka");
                break;
        case "3":

              break;
         case "4":

            break;
        case "0":

            break;


        default:
            Console.WriteLine("unknown operation");
            break;
    }
}

Menu();


/* 
pozn: 
    if( File.Exists(cesta))
    cestu dělat přez Patht.Combine(cesty)
*/

