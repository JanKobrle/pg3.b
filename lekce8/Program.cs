//vlastní statická metoda = funkce
//ref říká, že se funkce může měnit i z venku dovnitř
//out 

Console.WriteLine("ahoj, jsem program co ti sposita jakoukoliv trivialni operaci, budu pro to od tebe potrebovat dve cisala a jejich operaci:");
static float ReadNumber(string cislocisla)
{
    float faktcislo1;
    bool zkouska = false;
    do
    {
    Console.WriteLine("zadej cislo {0}",cislocisla);
    string cislo1 = Console.ReadLine();

    zkouska = float.TryParse(cislo1, out faktcislo1);
    if (zkouska == false)
    { Console.WriteLine("toto neni cislo"); }


    } while (zkouska == false);
    return faktcislo1;
}

static void Operace(string operace)
{


}

do
{
    float faktcislo1 = ReadNumber("1");
    float faktcislo2 = ReadNumber("2");



    Console.WriteLine("zadej ciselnou oeraci (+,-,*,/)");
    char operace = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if (operace == "/" && faktcislo2 == 0) 
    {
        Console.WriteLine("nulou nejde dělit ty matláku")
    else
         case '+':
                faktcislo1 + faktcislo2;
                break;

            case '-':
                faktcislo1 - faktcislo2;
                break;

            case '*':
                faktcislo1* faktcislo2;
                break;

            case '/':
                faktcislo1 / faktcislo2;
                break;

            default:
                Console.WriteLine("neznámá operace");
                break;
            }
                Console.WriteLine("{0}{1}{2}={3}", faktcislo1, operace, faktcislo2, vysledek)
        

        Console.WriteLine("Chceš spočítat další příklad? Pokud ano, napiš \"ano\" ");
    }
} while (Console.ReadLine() == "ano");

 
 /* switch (operace)
    {
        case '+':
            Console.WriteLine("{0}+{1}={2}", faktcislo1, faktcislo2, faktcislo1 + faktcislo2);
            break;

        case '-':
            Console.WriteLine("{0}-{1}={2}", faktcislo1, faktcislo2, faktcislo1 - faktcislo2);
            break;

        case '*':
            Console.WriteLine("{0}*{1}={2}", faktcislo1, faktcislo2, faktcislo1 * faktcislo2);
            break;

        case '/':
            Console.WriteLine("{0}/{1}={2}", faktcislo1, faktcislo2, faktcislo1 / faktcislo2);
            break;

        default:
            Console.WriteLine("neznámá operace");
            break;
                           
    }  */  