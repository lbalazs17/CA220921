using CA220921;

List<Kuldetes>  kuldetesek = new List<Kuldetes>();
using StreamReader sr = new(@"..\..\..\res\kuldetesek.csv");
while (!sr.EndOfStream) 
    kuldetesek.Add(new Kuldetes(sr.ReadLine()));

//3.feladat
Console.WriteLine($"3. feladat:\n\t" +
    $"Összesen {kuldetesek.Count} alkalommal indítottak űrsiklót");

//LINQ = Language-Integrated Query
int uo = kuldetesek.Sum(x=>x.Legenyseg);
Console.WriteLine($"4. feladat: \n\t" + 
    $"{uo} utas indult az űrbe összesen.");

//5.feladat
int km5u = kuldetesek.Count(x => x.Legenyseg < 5);
Console.WriteLine("5.feladat:\n\t" +
    $"Összesen {km5u} alkalommal küldtek kevesebb,mint 5 embert.");

//6.feladat
int cuul = kuldetesek
    .Where(x=> x.SikloNeve == "Columbia")
    .OrderByDescending(x => x.Datum)
    .First()
    .Legenyseg();
    Console.WriteLine("6.feladat:\n\t" +
        $"{cuul} asztronauta volt a Columbia fedélzetén annak utolsó útján.");

//7.feladat
 Kuldetes lhk = kuldetesek
    .OrderBy(x => x.KuldetesHossza)
    .Last();
Console.WriteLine($"7.feladat: " +
    $"A leghoszabb ideig a {lhk.SikloNeve} volt az űrben a" +
     $" {lhk.Kod} küldetés során\n\t" + 
     $"Összesen {lhk.KuldetesHossza} órát volt távol a Földtől.");

