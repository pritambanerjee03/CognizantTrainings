using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrones
{
    class Program
    {
        static void Main(string[] args)
        {
            //all heroes
            //var heroes = from h in Hero.GetHeroesList()
            //             select h;
            //foreach (var hero in heroes)
            //{
            //    Console.WriteLine(hero);
            //}

            //Console.WriteLine();

            //var houses = from hs in House.GetGreatHouseList()
            //             select hs;
            //foreach (var house in houses)
            //{
            //    Console.WriteLine(house);
            //}

            //var heroes = from h in Hero.GetHeroesList()
            //             where (h.HouseId == "STA")
            //             select h;

            //var heroes = from h in Hero.GetHeroesList()
            //            where (h.HouseId == "STA" && h.Gender == "F")
            //            select new { h.Id, h.Name };

            //var heroes = from h in Hero.GetHeroesList()
            //             where (h.HouseId == "STA" && h.Name.Contains("a"))
            //             orderby h.Name
            //             select new { h.Id, h.Name };

            //var heroes = from h in Hero.GetHeroesList()
            //             where (h.HouseId == "STA" || h.HouseId == "TAR")
            //             orderby h.HouseId
            //             select new { h.HouseId, h.Name };
            //foreach (var hero in heroes)
            //    {
            //        Console.WriteLine(hero);
            //    }

            //var houses = from hs in House.GetGreatHouseList()
            //             where (hs.HouseLoacation.Contains("Crownlands") ||
            //             hs.HouseLoacation.Contains("Westerland"))
            //             select hs;

            //var houses = from hs in House.GetGreatHouseList()
            //             from h in Hero.GetHeroesList()
            //             where (hs.HouseId == h.HouseId)
            //             orderby h.Name
            //             select new { h.Name, hs.HouseLoacation };

            //var housePerson = from hero in Hero.GetHeroesList()
            //                  join house in House.GetGreatHouseList()
            //                  on hero.HouseId equals house.HouseId
            //                  orderby hero.Name
            //                  select new { hero.Name, house.HouseLoacation };

            var houses = from house in House.GetGreatHouseList()
                         from hero in Hero.GetHeroesList()
                         where (house.HouseId == hero.HouseId)
                         && (hero.Gender == "F")
                         && (house.HouseLoacation.Contains("Dragonstone"))
                         orderby hero.Name
                         select new { hero.Name};

            foreach (var house in houses)
            {
                Console.WriteLine(house);
            }
            Console.Read();
        }
    }
}
