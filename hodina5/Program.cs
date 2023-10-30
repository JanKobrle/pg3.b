
//cipherChar = ((plainChar - 'A' + key) % 26) + 'A';
//ABCDEFGHIJKLMNOPQRSTUVWXYZ


bool zkouska = false;
int posun;
do
{
    Console.WriteLine("napiš posun (ideal max 26)");
    string moznaposun = Console.ReadLine();

    zkouska = int.TryParse(moznaposun, out posun);
    if (zkouska == false)
    { Console.WriteLine("toto neni cislo"); }


} while (zkouska == false);

