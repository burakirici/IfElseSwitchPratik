int elma = 2;
int armut = 3;
int cilek = 2;
int muz = 3;
int diger = 4;

Console.WriteLine("Ruya Manavina Hosgeldiniz!");
Console.WriteLine($"Elma = {elma} TL ");
Console.WriteLine($"ARmut = {armut} TL ");
Console.WriteLine($"Cilek = {cilek} TL ");
Console.WriteLine($"Muz = {muz} TL ");
Console.WriteLine($"Diger butun meyveler = {diger} TL ");
Console.Write($"Hangi meyveyi satin almak istiyorsunuz? (Elma/Armut/Cilek/Muz/Diger) ");
string meyveler = Console.ReadLine().ToLower();
if (meyveler == "elma")
{
    Console.WriteLine($"Sectiginiz Meyvenin fiyati: {elma} TL dir.");
}
else if (meyveler == "armut")
{
    Console.WriteLine($"Sectiginiz Meyvenin fiyati: {armut} TL dir.");
}
else if (meyveler == "cilek")
{
    Console.WriteLine($"Sectiginiz Meyvenin fiyati: {cilek} TL dir.");
}
else if (meyveler == "muz")
{
    Console.WriteLine($"Sectiginiz Meyvenin fiyati: {muz} TL dir.");
}
else
{
    Console.WriteLine($"Sectiginiz Urunun fiyati {diger} TL dir.");
}



switch (meyveler) 
{
    case "elma":
    Console.WriteLine("Elma = 2 TL");
    break;
    case "armut":
    Console.WriteLine("Armut = 3 TL");
    break;
    case "cilek":
    Console.WriteLine("Cilek = 2 TL");
    break;
    case "muz":
    Console.WriteLine("Muz = 3 TL");
    break;
    default:
    Console.WriteLine($"Sectiginiz urun {diger} TL dir.");
    break;
   
}


