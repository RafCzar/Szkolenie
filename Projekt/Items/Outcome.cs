using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Items
{
    class Outcome : Item
    {
        public Outcome(int id, string name, decimal amount, DateTime date)
        {
            Id = id;
            Name = name;
            Type = ItemType.Outcome;
            Amount = amount;
            Date = date;
        }
    }
}
