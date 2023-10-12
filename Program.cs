using KolcsonzoOOP;

List<IKolcsonozheto> katalogus = new List<IKolcsonozheto>();
katalogus.Add(new Konyv("Game of Thrones","George R.R Martin","is12aa23s"));
katalogus.Add(new Dvd("Star Wars", 120));
katalogus.Add(new Ujsag("Magyar Hírlap",2003,30));

Dvd dvd = new Dvd("Lord of THe Rings", 300);
dvd.fillDvd();
dvd.Dvdk.Sort();
foreach (var k in katalogus)
{
    Console.WriteLine(k);
}
Console.WriteLine("----------");
foreach  (var d in dvd.Dvdk)
{
    Console.WriteLine(d);
}