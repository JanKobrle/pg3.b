﻿//vlastní statická metoda = funkce
//ref říká, že se funkce může měnit i z venku dovnitř
//out 
static void UltimátníOdpověď();
{
    return Console.Write("42");
}

/*
do
{

    float faktcislo1 = 0;
    float faktcislo2 = 0;

    bool zkouska = false;

    do
    {
        Console.WriteLine("zadej cislo");
        string cislo1 = Console.ReadLine();

        zkouska = float.TryParse(cislo1, out faktcislo1);
        if (zkouska == false)
        { Console.WriteLine("toto neni cislo"); }


    } while (zkouska == false);

    zkouska = false;

    do
    {
        Console.WriteLine("zadej druhe cislo");
        string cislo2 = Console.ReadLine();

        zkouska = float.TryParse(cislo2, out faktcislo2);
        if (zkouska == false)
        { Console.WriteLine("toto neni cislo"); }

    } while (zkouska == false);




    Console.WriteLine("zadej ciselnou oeraci (+,-,*,/)");
    char operace = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (operace)
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
    }
    Console.WriteLine("Chceš spočítat další příklad? Pokud ano, napiš \"ano\" ");

} while (Console.ReadLine() == "ano");
*/