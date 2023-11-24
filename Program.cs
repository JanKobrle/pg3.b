
static void Obdelnik()
{
    Console.WriteLine("budu po tobě potřebovat strany a a b");

    float a;
    bool zkouska = false;
    do
    {
        Console.WriteLine("zadej stranu a");
        string cislo1 = Console.ReadLine();

        zkouska = float.TryParse(cislo1, out a);
        if (zkouska == false)
        { Console.WriteLine("toto neni cislo"); }


    } while (zkouska == false);

    float b;
    bool zkouska2 = false;
    do
    {
        Console.WriteLine("zadej stranu b");
        string cislo1 = Console.ReadLine();

        zkouska2 = float.TryParse(cislo1, out b);
        if (zkouska2 == false)
        { Console.WriteLine("toto neni cislo"); }


    } while (zkouska == false);


    Console.WriteLine("Obvod tohoto obdelníku je {0}", 2*(a+b));
    Console.WriteLine("Obvod tohoto obdelníku je {0}", a * b);
}

static void Trojuhelnik()
{
    Console.WriteLine("budu po tobě potřebovat strany a, b a c");

    float a;
    bool zkouska = false;
    do
    {
        Console.WriteLine("zadej stranu a");
        string cislo1 = Console.ReadLine();

        zkouska = float.TryParse(cislo1, out a);
        if (zkouska == false)
        { Console.WriteLine("toto neni cislo"); }


    } while (zkouska == false);

    float b;
    bool zkouska2 = false;
    do
    {
        Console.WriteLine("zadej stranu a");
        string cislo1 = Console.ReadLine();

        zkouska2 = float.TryParse(cislo1, out b);
        if (zkouska2 == false)
        { Console.WriteLine("toto neni cislo"); }


    } while (zkouska2 == false);

    float c;
    bool zkouska3 = false;
    do
    {
        Console.WriteLine("zadej stranu a");
        string cislo1 = Console.ReadLine();

        zkouska3 = float.TryParse(cislo1, out c);
        if (zkouska3 == false)
        { Console.WriteLine("toto neni cislo"); }


    } while (zkouska3 == false);

    Console.WriteLine("obvod tohoto trojúhelníku je {0} cm", a+b+c);
    double s= (a*b*c)/2;
    double po = s * (s - a) * (s - b) * (s - c);
    double vysledek = Math.Sqrt(po);
    Console.WriteLine("obsah tohoto trojúhelníku je {0} cm2", vysledek );
}
//static void ObsahKruhu()
//{

//}














Console.WriteLine("ahoj, vypocitam ti obsah jakehokoliv triviálníhogeometrického tvaru");
string pokracovani = "ne";
do
{
    Console.WriteLine("zadej, zda chceš počítat obsah pro: \"obdelnik\", \"kruh\", \"trojuhelnik\"");
    string tvar = Console.ReadLine();
    if (tvar == "obdelnik")
    {
        Trojuhelnik();
    }
    if (tvar == "obdelnik")
    {
        Obdelnik();
    }

    else Console.WriteLine("chceš počítat dál? Pokud ano napiš \"ano\"");

    Console.WriteLine("chceš počítat dál? Pokud ano napiš \"ano\"");
    pokracovani = Console.ReadLine();

} while (pokracovani == "ano");