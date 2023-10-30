
using System.Net.Mail;

Console.WriteLine("zadej přídavné jméno (s velým písmenem na začátku)");
string pod = Console.ReadLine();

Console.WriteLine("zadej podstatné jméno");
string pří = Console.ReadLine();

Console.WriteLine("zadej sloveso (v třetí osobě)");
string slo = Console.ReadLine();

Console.WriteLine("zadej příslovečné určení");
string přísl = Console.ReadLine();


Console.WriteLine("{0} {1} {2} {3}.", pod, pří, slo, přísl);
//alt shift . = více kurzorů (konec-esc)//