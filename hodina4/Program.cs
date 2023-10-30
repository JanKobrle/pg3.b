
//int[] array=new int[10]; 
// vic, nez jen jedno i!
//ctrl r pro p5eps8n9 prom2nn7ch

/*  
  
    pro každé i >= 2, i * i <= maximum, pokud je hodnota v poli true, nastavím pro všechny násobky hodnotu v poli na false
    vypíšu čísla, pro která v poli zůstalo true */



int size;
bool success;
do
{
    Console.Write("Napiš číslo kam aš chceš hledat prvočísla");
    success = int.TryParse(Console.ReadLine(), out size) && size >= 0;
    if (!success)
    {
        Console.WriteLine("tak tos fakt nezvlát, zkus to znova");
    }
} while (!success);


bool[] array = new bool[size];

for (int i = 0; i < size; i += 1);
{
    array[i] = true;
}

for ();
{

}



//for (array = true;)
//Console.WriteLine("0", array = true);

/*for (int tri; tri < size; tri += 2)
{
    array[tri] = false;
}*/

