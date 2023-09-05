using WONDERS.ColossusOfRhodes;
using WONDERS.EgyptPyramid;
using WONDERS.HangingGardensOfBabylon;
using WONDERS.LighthouseOfAlexandria;
using WONDERS.MausoleumAtHalicarnassus;
using WONDERS.StatueOfZeus;
using WONDERS.TempleOfArtemisAtEphesus;




internal class Program
{

    public static void Main()
    {
        var pyramid = new EgyptPyramids();
        var gardens = new HangingGardensOfBabylon();
        var statue = new StatueOfZeus();
        var temple = new TempleOfArtemisAtEphesus();
        var mausoleum = new MausoleumAtHalicarnassus();
        var colossus = new ColossusOfRhodes();
        var lighthouse = new LighthouseOfAlexandria();

        Console.WriteLine("7 Wonders of the World:");
        Console.WriteLine("1. " + pyramid.Name);
        Console.WriteLine("   Location: " + pyramid.Location);
        Console.WriteLine("   Description: " + pyramid.Description);
        Console.WriteLine("2. " + gardens.Name);
        Console.WriteLine("   Location: " + gardens.Location);
        Console.WriteLine("   Description: " + gardens.Description);
        Console.WriteLine("3. " + statue.Name);
        Console.WriteLine("   Location: " + statue.Location);
        Console.WriteLine("   Description: " + statue.Description);
        Console.WriteLine("4. " + temple.Name);
        Console.WriteLine("   Location: " + temple.Location);
        Console.WriteLine("   Description: " + temple.Description);
        Console.WriteLine("5. " + mausoleum.Name);
        Console.WriteLine("   Location: " + mausoleum.Location);
        Console.WriteLine("   Description: " + mausoleum.Description);
        Console.WriteLine("6. " + colossus.Name);
        Console.WriteLine("   Location: " + colossus.Location);
        Console.WriteLine("   Description: " + colossus.Description);
        Console.WriteLine("7. " + lighthouse.Name);
        Console.WriteLine("   Location: " + lighthouse.Location);
        Console.WriteLine("   Description: " + lighthouse.Description);
    }
}
namespace WONDERS
{
   
    namespace ColossusOfRhodes
    {
        internal class ColossusOfRhodes
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Description { get; set; }
            public ColossusOfRhodes()
            {
                Name = "Colossus of Rhodes";
                Location = "Greece";
                Description = "An ancient statue in Rhodes.";
            }
        }
    }


    namespace HangingGardensOfBabylon
    {

        public class HangingGardensOfBabylon
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Description { get; set; }

            public HangingGardensOfBabylon()
            {
                Name = "Hanging Gardens of Babylon";
                Location = "Iraq";
                Description = "An ancient garden in Babylon.";
            }
        }
    }

    namespace EgyptPyramid
    {
        class EgyptPyramids
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Description { get; set; }
            public EgyptPyramids()
            {
                Name = "Pyramids of Giza";
                Location = "Egypt";
                Description = "Ancient pyramids";
            }
        }
    }


    namespace LighthouseOfAlexandria
    {
        class LighthouseOfAlexandria
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Description { get; set; }

            public LighthouseOfAlexandria()
            {
                Name = "Lighthouse of Alexandria";
                Location = "Egypt";
                Description = "An ancient lighthouse in Alexandria.";
            }
        }
    }

    namespace MausoleumAtHalicarnassus
    {
        class MausoleumAtHalicarnassus
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Description { get; set; }

            public MausoleumAtHalicarnassus()
            {
                Name = "Mausoleum at Halicarnassus";
                Location = "Turkey";
                Description = "An ancient mausoleum in Halicarnassus.";
            }
        }
    }

    namespace TempleOfArtemisAtEphesus
    {
        class TempleOfArtemisAtEphesus
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Description { get; set; }

            public TempleOfArtemisAtEphesus()
            {
                Name = "Temple of Artemis at Ephesus";
                Location = "Turkey";
                Description = "An ancient temple in Ephesus";
            }
        }

    }

    namespace StatueOfZeus
    {

        class StatueOfZeus
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Description { get; set; }

            public StatueOfZeus()
            {
                Name = "Statue of Zeus at Olympia";
                Location = "Greece";
                Description = "A statue of Zeus in Olympia.";
            }
        }

    }

}

