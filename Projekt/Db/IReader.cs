using Projekt.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Db
{
    interface IReader
    {
        int GetNextId();
        IEnumerable<Item> ReadAll();
    }
}
