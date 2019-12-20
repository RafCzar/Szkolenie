using lab38___Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab38___Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            var bikes = new List<Bike>
            {
                new Bike{ Number = "001", BikeType = BikeType.Mountain},
                new Bike{ Number = "004", BikeType = BikeType.Road},
                new Bike{ Number = "008", BikeType = BikeType.Town},
                new Bike{ Number = "011", BikeType = BikeType.Mountain},
                new Bike{ Number = "012", BikeType = BikeType.Road},
            };

            using (var context = new RentBikeContext())
            {
                context.Bikes.AddRange(bikes);
                context.SaveChanges();
            }
        }
    }
}
