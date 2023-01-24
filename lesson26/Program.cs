using lesson26;

Console.WriteLine("*****Fun with IEnumerable / IEnumerator****\n");
Garage carLot = new Garage();

//проход по всем обьектам Car в колекции
foreach(Car c in carLot)
{
    Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrentSpeed);

}
Console.ReadLine();