
Console.WriteLine("ahoj, jsem program co ti sposita linearni rovnici ve tvaru a*x+b=0");
static float ReadNumber(string cislocisla)
{
    float faktcislo1;
    bool zkouska = false;
    do
    {
        Console.WriteLine("zadej koeficient {0}:", cislocisla);
        string cislo1 = Console.ReadLine();

        zkouska = float.TryParse(cislo1, out faktcislo1);
        if (zkouska == false)
        { Console.WriteLine("neplatný koeficient"); }


    } while (zkouska == false);
    return faktcislo1;
}

float a = ReadNumber("a");

float b = ReadNumber("b");

if (a != 0)
{
    Console.WriteLine("u rovnice {0}*x+{1}=0 se x={2}", a, b, -b / a);
}

if (a == 0)
{
    Console.WriteLine("nulou nelze nělit");
}
