List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

//1.  first eruption in Chile and print the result
Eruption FirstChile = eruptions.FirstOrDefault(erup => erup.Location == "Chile");
Console.WriteLine(FirstChile);

//2. First Hawaii Island
Eruption? FirstHawaii = eruptions.FirstOrDefault(erup => erup.Location == "Hawaiian Is");
if (FirstHawaii == null)
{
    Console.WriteLine("No Hawaiian Is Eruption found");

}
else
{
    Console.WriteLine(FirstHawaii);

}

//3. First Greenland 
Eruption? FirstGreenland = eruptions.FirstOrDefault(erup => erup.Location == "Greenland");
if (FirstGreenland == null)
{
    Console.WriteLine("No Greenland Eruption found");

}
else
{
    Console.WriteLine(FirstGreenland);

}

//4. First New zealand and after 1900
Eruption FirstNZ = eruptions.Where(erup => erup.Year > 1900).FirstOrDefault(erup => erup.Location == "New Zealand");
Console.WriteLine(FirstNZ);

//5. All eruptions over 2000

IEnumerable<Eruption> OverTwoThousand = eruptions.Where(erup => erup.ElevationInMeters > 2000);
PrintEach(OverTwoThousand, "***********************");

//6. Eruptions that start witht letter "L". Also, print sum of eruptions found. 

IEnumerable<Eruption> EruptionsBeginningWithL = eruptions.Where(erup => erup.Volcano.StartsWith("L"));
int NumOfEruptions = EruptionsBeginningWithL.Count();
PrintEach(EruptionsBeginningWithL, "***********************");
Console.WriteLine(NumOfEruptions);

//7. MaxHeight
int MaxHeight = eruptions.Max(erup => erup.ElevationInMeters);
Console.WriteLine(MaxHeight);

//8. Print volcano with maxheight

string VolcanoWithMaxHeight = eruptions.Where(erup => erup.ElevationInMeters == MaxHeight).Select(erup => erup.Volcano).ToList()[0];
Console.WriteLine(VolcanoWithMaxHeight);

//9. Print all Volcanoes alphabetically
IEnumerable<string> SortedAlphabetically = eruptions.OrderBy(erup => erup.Volcano).Select(erup => erup.Volcano);
foreach (string name in SortedAlphabetically)
{
    Console.WriteLine(name);
}

//10. Sum of all elevations
int ElevationSum = eruptions.Sum(erup => erup.ElevationInMeters);
Console.WriteLine(ElevationSum);

// 11. Print True if any volcanoes erputed in 2000, if not then print false. 
bool VolcanoErupt2000 = eruptions.Any(erup => erup.Year == 2000);
Console.WriteLine(VolcanoErupt2000);

// 12. Find all stratovolcanoes and print first 3.
IEnumerable<Eruption> StratoThree = eruptions.Where(erup => erup.Type == "Stratovolcano").Take(3);
PrintEach(StratoThree);

// 13. 
IEnumerable<Eruption> EruptBefore1000 = eruptions.Where(erup => erup.Year < 1000).OrderBy(erup => erup.Volcano);
PrintEach(EruptBefore1000);

// 14
IEnumerable<string> NamesEruptBefore1000 = eruptions.Where(erup => erup.Year < 1000).OrderBy(erup => erup.Volcano).Select(erup => erup.Volcano);
// Loops through and prints each name
foreach (string name in NamesEruptBefore1000)
{
    Console.WriteLine(name);
}
// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
