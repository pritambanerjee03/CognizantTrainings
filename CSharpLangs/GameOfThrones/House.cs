using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrones
{
    class House
    {
        public string HouseId { get; set; }
        public string HouseName { get; set; }
        public string HouseLoacation { get; set; }

        public House(string houseId, string houseName, string houseLoaction)
        {
            HouseId = houseId;
            HouseName = houseName;
            HouseLoacation = houseLoaction;
        }

        public override string ToString()
        {
            return string.Format("House Id: {0},  Name: {1}, Location: {2}", HouseId
                , HouseName, HouseLoacation);
        }

        public static List<House> GetGreatHouseList()
        {
            return new List<House>()
            {
                new House("STA", "House Stark", "Winterfel -The North"),
                new House("LAN", "House Lannister", "Casterly Rock-Westerlands"),
                new House("GRE", "House Grejoy", "Salt Castle-Iron Islands"),
                new House("TAR", "House Targaryan", "Dragonstone-Crownlands"),
                new House("TRL", "Tarly", "Horn Hill")
            };
        }
    }
}
