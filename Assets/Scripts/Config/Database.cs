using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS
{
    public class Database
    {
        Dictionary<string, Table> tables = new Dictionary<string, Table>();
        public void Add(string v, Table table)
        {
            tables.Add(v, table);
        }

        public Table Get(string v)
        {
            return tables[v];
        }
    }
}
