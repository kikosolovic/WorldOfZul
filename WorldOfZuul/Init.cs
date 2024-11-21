using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveCountries
{
    public class Init
    {

        public List<Country> CreateCountries()
        {
            List<Country> Countries = new List<Country>();
            Country? India = new("India", "Wouldn't you know, India is located in South Asia");
            Countries.Add(India);
            Country? Haiti = new("Haiti", "Wouldn't you know, Haiti is located in the Caribbean");
            Countries.Add(Haiti);
            
            Country? Brazil = new("Brazil", "Wouldn't you know, Brazil is located in South America");
            Countries.Add(Brazil);
            Country? Mozambique = new("Mozambique", "Wouldn't you know, Mozambique is located in Africa");
            Countries.Add(Mozambique);
            Country? USA = new("USA", "Wouldn't you know, USA is located in North America");
            Countries.Add(USA);

            Haiti.SetExits(Haiti, India, Brazil, Mozambique, USA);
            India.SetExits(Haiti, India, Brazil, Mozambique, USA);
            Brazil.SetExits(Haiti, India, Brazil, Mozambique, USA);
            Mozambique.SetExits(Haiti, India, Brazil, Mozambique, USA);
            USA.SetExits(Haiti, India, Brazil, Mozambique, USA);

            return Countries;


        }
        public void CreateRooms(List<Country> countries)
        {
            Country Haiti = countries[1];
            Country India = countries[0];
            Country Brazil = countries[2];
            Country Mozambique = countries[3];
            Country USA = countries[4];

             // //initialize rooms to Haiti
            Haiti.InitRoom("Outside", "You are standing outside the main entrance of the university. To the east is a large building, to the south is a computing lab, and to the west is the campus pub.");
            Haiti.InitRoom("Theatre", "You find yourself inside a large lecture theatre. Rows of seats ascend up to the back, and there's a podium at the front. It's quite dark and quiet.");
            Haiti.InitRoom("Pub", "You've entered the campus pub. It's a cosy place, with a few students chatting over drinks. There's a bar near you and some pool tables at the far end.");
            Haiti.InitRoom("Lab", "You're in a computing lab. Desks with computers line the walls, and there's an office to the east. The hum of machines fills the room.");
            Haiti.InitRoom("Office", "You've entered what seems to be an administration office. There's a large desk with a computer on it, and some bookshelves lining one wall.");
            Haiti.InitRoom("BlaBla", "You've entered what seems to be an administration office. There's a large desk with a computer on it, and some bookshelves lining one wall.");
            Haiti.InitRoom("BlaBla2", "You've entered what seems to be an administration office. There's a large desk with a computer on it, and some bookshelves lining one wall.");


            Haiti.addExit("Outside", new List<string> { "east", "south", "west", "north"}, new List<string> { "Theatre", "Lab", "Pub","BlaBla" });
            Haiti.addExit("Theatre", new List<string> { "west" }, new List<string> { "Outside" });
            Haiti.addExit("Pub", new List<string> { "east" }, new List<string> { "Outside" });
            Haiti.addExit("Lab", new List<string> { "north", "east" }, new List<string> { "Outside", "Office" });
            Haiti.addExit("Office", new List<string> { "west" }, new List<string> { "Lab" });
            Haiti.addExit("BlaBla", new List<string> { "south", "north" }, new List<string> { "Outside","BlaBla2" });
            Haiti.addExit("BlaBla2", new List<string> { "south" }, new List<string> { "BlaBla" });


            // //initialize rooms to India
            India.InitRoom("UN Outpost", "You are just outside of a UN outpost located between your two objectives. You can go either north or south.");
            India.InitRoom("O.S.T.P.", "You find yourself outside the abandoned plant mentioned in your report. The entrance to the lobby is to the north.");
            India.InitRoom("Lobby", "You're inside the lobby of the plant. There is a storage room to the east and the tank room is to the west.");
            India.InitRoom("Tank Room", "You're inside the tank room. You ascertain that the tanks are rusty and full of holes and that the pipes need replacing. You should maybe check the storage room to see if you can't find spare ones.");
            India.InitRoom("Storage Room", "You're in a storage room. You look around and find the pipes you need.");
            India.InitRoom("Crop Field", "You're at the crop field mentioned in the report. You will need drip tubes and emitters to be able to install the irrigation system. There's two sheds to the west and east. You should check what's inside them.");
            India.InitRoom("Eastern Shed", "You're in a shed. You look around and you find a box with emitters in it. Just the ones you need.");
            India.InitRoom("Western Shed", "You're in a shed. You look around and spot drip tubes on one of the shelves. Jackpot!");

            //Outside Sewage Treatment Plant-> O.S.T.P.
            India.addExit("UN Outpost", new List<string> { "north", "south" }, new List<string> { "O.S.T.P.", "Crop Field" });
            India.addExit("O.S.T.P.", new List<string> { "south", "north" }, new List<string> { "UN Outpost", "Lobby" });
            India.addExit("Lobby", new List<string> { "south", "west", "east" }, new List<string> { "O.S.T.P.", "Storage Room", "Tank Room" });
            India.addExit("Tank Room", new List<string> { "west" }, new List<string> { "Lobby" });
            India.addExit("Storage Room", new List<string> { "east" }, new List<string> { "Lobby" });
            India.addExit("Crop Field", new List<string> { "north", "east", "west" }, new List<string> { "UN Outpost", "Eastern Shed", "Western Shed" });
            India.addExit("Eastern Shed", new List<string> { "west" }, new List<string> { "Crop Field" });
            India.addExit("Western Shed", new List<string> { "east" }, new List<string> { "Crop Field" });



            // //initialize rooms to Brazil
            Brazil.InitRoom("Outside", "You are standing outside the main entrance of the university. To the east is a large building, to the south is a computing lab, and to the west is the campus pub.");
            Brazil.InitRoom("Theatre", "You find yourself inside a large lecture theatre. Rows of seats ascend up to the back, and there's a podium at the front. It's quite dark and quiet.");
            Brazil.InitRoom("Pub", "You've entered the campus pub. It's a cosy place, with a few students chatting over drinks. There's a bar near you and some pool tables at the far end.");
            Brazil.InitRoom("Lab", "You're in a computing lab. Desks with computers line the walls, and there's an office to the east. The hum of machines fills the room.");
            Brazil.InitRoom("Office", "You've entered what seems to be an administration office. There's a large desk with a computer on it, and some bookshelves lining one wall.");


            Brazil.addExit("Outside", new List<string> { "east", "south", "west" }, new List<string> { "Theatre", "Lab", "Pub" });
            Brazil.addExit("Theatre", new List<string> { "west" }, new List<string> { "Outside" });
            Brazil.addExit("Pub", new List<string> { "east" }, new List<string> { "Outside" });
            Brazil.addExit("Lab", new List<string> { "north", "east" }, new List<string> { "Outside", "Office" });
            Brazil.addExit("Office", new List<string> { "west" }, new List<string> { "Lab" });


            //initialize rooms to Mozambique
            Mozambique.InitRoom("Dock", "You just arrived to Mozambique. The boat dropped you off at a small dock. ");//, minigameFunctions.Dock);
            Mozambique.InitRoom("Village", "You find yourself inside a large lecture theatre. Rows of seats ascend up to the back, and there's a podium at the front. It's quite dark and quiet.");
            Mozambique.InitRoom("Hill", "You've entered the campus pub. It's a cosy place, with a few students chatting over drinks. There's a bar near you and some pool tables at the far end.");
            Mozambique.InitRoom("Lab", "You're in a computing lab. Desks with computers line the walls, and there's an office to the east. The hum of machines fills the room.");
            Mozambique.InitRoom("Office", "You've entered what seems to be an administration office. There's a large desk with a computer on it, and some bookshelves lining one wall.");


            Mozambique.addExit("Dock", new List<string> { "west" }, new List<string> { "Village" });
            Mozambique.addExit("Village", new List<string> { "north", "east" }, new List<string> { "Hill", "Dock" });
            Mozambique.addExit("Hill", new List<string> { "south" }, new List<string> { "village" });
            Mozambique.addExit("Lab", new List<string> {"east" }, new List<string> {"Office" });
            Mozambique.addExit("Office", new List<string> { "west" }, new List<string> { "Lab" });



            // //initialize rooms to USA
            USA.InitRoom("New York City", "You are in New York City, where waste management and recycling initiatives are critical to reducing urban waste.");//, minigameFunctions.RecyclingSortingMinigameNYC);
            USA.InitRoom("Los Angeles", "You are in Los Angeles, dealing with challenges related to plastic waste and sustainable disposal methods..");
            USA.InitRoom("San Francisco", "You are in San Francisco, known for its zero-waste goals and composting initiatives.");
            USA.InitRoom("Houston", "You are in Houston, where industrial waste and hazardous waste management are major concerns.");
            USA.InitRoom("Chicago", "You are in Chicago, focusing on electronic waste recycling and management.");


            USA.addExit("New York City", new List<string> { "east", "south", "west" }, new List<string> { "Los Angeles", "Houston", "San Francisco" });
            USA.addExit("Los Angeles", new List<string> { "west" }, new List<string> { "New York City" });
            USA.addExit("San Francisco", new List<string> { "east" }, new List<string> { "New York City" });
            USA.addExit("Houston", new List<string> { "north", "east" }, new List<string> { "New York City", "Chicago" });
            USA.addExit("Chicago", new List<string> { "west" }, new List<string> { "Houston" });

        }

        public List<Minigame> CreateGames()
        {
            List<Minigame> minigames = new List<Minigame>();
            Minigame[] Games = {
                new("Haiti", "Lab", "This is 1 game.", 11),
                new("Haiti", "Lab", "This is 2 game.", 12),
                new("Haiti", "Lab", "This is 3 game.", 13),
                new("Haiti", "Lab", "This is 4 game.", 14),
            
            };
            foreach (Minigame minigame in Games)
            {
                minigames.Add(minigame);
            }
            
            return minigames;
        }

        
    }
}